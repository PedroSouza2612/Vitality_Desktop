using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Vitality
{
    public partial class Form07_Consultas : Form
    {
        Thread volta;
        public Form07_Consultas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cardiologista")
            {
                try
                {
                    SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                        "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                    conexao.Open();
                    SQLiteCommand busca = new SQLiteCommand("SELECT Nome FROM vit_profissionais WHERE Formacao = 'Cardiologista' OR Formacao = 'Cardiologia'", conexao);
                    SQLiteDataReader confere;
                    confere = busca.ExecuteReader();
                    confere.Read();
                    btnNome.Text = confere.GetString(0);
                    btnNome.Visible = true;
                    conexao.Close();

                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            volta = new Thread(CancelaConsulta);
            volta.SetApartmentState(ApartmentState.STA);
            volta.Start();

        }

        private void CancelaConsulta()
        {
            Application.Run(new Form03_Inicio());
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                    "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                conexao.Open();
                SQLiteCommand busca = new SQLiteCommand("SELECT Sobrenome, Formacao, Instituicao_Formacao FROM vit_profissionais WHERE Nome = @nome", conexao);
                busca.Parameters.Add("@nome", DbType.String).Value = btnNome.Text;
                SQLiteDataReader confere;
                confere = busca.ExecuteReader();
                confere.Read();
                txtNome.Text = btnNome.Text;
                txtSobreN.Text = confere.GetString(0);
                txtFormacao.Text = confere.GetString(1);
                txtInstituicao.Text = confere.GetString(2);
                conexao.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Vit_Globais.caminhoPDF + "Consulta.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter conteudoPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, 
            (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Consulta com " + txtNome.Text + "\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15,
            (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("Agendada pelo Vitality\n");

            doc.Open();
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Close();
        }
    }
}
