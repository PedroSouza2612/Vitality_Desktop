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

namespace Vitality
{
    public partial class Form03_Inicio : Form
    {
        Thread MP, Cont, Sob, Logout, consulta;
        string nome, gen;
        public Form03_Inicio()
        {
            InitializeComponent();
        }
        private void Form03_Inicio_Load(object sender, EventArgs e)
        {
            lblCReVersao.Text = Vit_Globais.CReVersao;
            try
            {
                SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                    "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                conexao.Open();
                SQLiteCommand update = new SQLiteCommand("SELECT Nome,Genero FROM vit_usuarios WHERE ID_Usuario= @id", conexao);
                update.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                SQLiteDataReader conf;
                conf = update.ExecuteReader();
                conf.Read();
                nome = conf.GetString(0);
                gen = conf.GetString(1);
                conexao.Close();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
                if (gen == "M")
                {
                    lblNome.Text = ("Bem-vindo " + nome + "!");
                }
                else if (gen == "F")
                {
                    lblNome.Text = ("Bem-vinda " + nome + "!");
                }
                else if (gen == "I")
                {
                    lblNome.Text = ("Olá " + nome + "!");
                }
        }
        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            MP = new Thread(MeuPerfil);
            MP.SetApartmentState(ApartmentState.STA);
            MP.Start();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Logout = new Thread(SairConta);
            Logout.SetApartmentState(ApartmentState.STA);
            Logout.Start();
        }
        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            pnlOpcoes.Visible = true;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Close();
            consulta = new Thread(FormConsulta);
            consulta.SetApartmentState(ApartmentState.STA);
            consulta.Start();

        }

        private void FormConsulta()
        {
            Application.Run(new Form07_Consultas());
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            pnlOpcoes.Visible = false;
        }


        private void SairConta()
        {
            Application.Run(new Form1());
        }
        private void MeuPerfil()
        {
            Application.Run(new Form04_MeuPerfil());
        }
        private void btnSairApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
