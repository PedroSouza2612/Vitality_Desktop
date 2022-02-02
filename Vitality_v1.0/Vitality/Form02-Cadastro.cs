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
using System.Data.SQLite;

namespace Vitality
{
    public partial class Form02_Cadastro : Form
    {
        Thread logar;
        string gen, sen, confsen;
        public Form02_Cadastro()
        {
            InitializeComponent();
        }

        private void Form02_Cadastro_Load(object sender, EventArgs e)
        {
            lblCReVersao.Text = ("\u00A9" + DateTime.Now.ToString("yyyy") + " - Vitality   v1.0.0");

        }

        private void CheckTermos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTermos.Checked)
            {
                btnCad.Enabled = true;
            }
            else
            {
                btnCad.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Close();
            logar = new Thread(login);
            logar.SetApartmentState(ApartmentState.STA);
            logar.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCadLoad.Visible = false;
            pbGif.Visible = false;
            btnCadConcluido.Visible = true;
            lblNomeConc.Text = ("Cadastro concluído " + txtNome.Text + "!");
            lblNomeConc.Visible = true;
            lblOKCOnc.Visible = true;
            timer1.Stop();
        }

        private void btnCadConcluido_Click(object sender, EventArgs e)
        {
            this.Close();
            logar = new Thread(login);
            logar.SetApartmentState(ApartmentState.STA);
            logar.Start();
        }

        private void login()
        {
            Application.Run(new Form1());
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            sen = txtSenha.Text;
            confsen = txtConfSe.Text;

            if (rbtM.Checked)
            {
                gen = "M";
            }
            else if (rbtF.Checked)
            {
                gen = "F";
            }
            else if (rbtI.Checked)
            {
                gen = "I";
            }

            if (sen == confsen)
            {
                try
                {
                    SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                        "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                    conexao.Open();
                    SQLiteCommand insert = new SQLiteCommand("INSERT INTO vit_usuarios (Nome,Sobrenome,Endereco,Cidade," +
                        "CEP,UF,Telefone,Data_Nasc,Email,Usuario,Senha,Genero,Foto) VALUES" +
                        "(@Nome,@Sobrenome,@Endereco,@Cidade," +
                        "@CEP,@UF,@Telefone,@Data_Nascimento,@Email,@Usuario,@Senha,@Genero,@Foto)", conexao);
                    insert.Parameters.Add("@Nome", System.Data.DbType.String, 30).Value = txtNome.Text;
                    insert.Parameters.Add("@Sobrenome", System.Data.DbType.String, 50).Value = txtSobrenome.Text;
                    insert.Parameters.Add("@Endereco", System.Data.DbType.String, 100).Value = txtEndereco.Text;
                    insert.Parameters.Add("@Cidade", System.Data.DbType.String, 70).Value = txtCidade.Text;
                    insert.Parameters.Add("@CEP", System.Data.DbType.String, 30).Value = mskCEP.Text;
                    insert.Parameters.Add("@UF", System.Data.DbType.String, 2).Value = cbUF.Text;
                    insert.Parameters.Add("@Telefone", System.Data.DbType.String, 20).Value = mskTel.Text;
                    insert.Parameters.Add("@Data_Nascimento", System.Data.DbType.String).Value = mskData.Text;
                    insert.Parameters.Add("@Email", System.Data.DbType.String, 100).Value = txtEmail.Text;
                    insert.Parameters.Add("@Usuario", System.Data.DbType.String, 30).Value = txtUsuario.Text;
                    insert.Parameters.Add("@Senha", System.Data.DbType.String, 10).Value = txtSenha.Text;
                    insert.Parameters.Add("@Genero", System.Data.DbType.String, 1).Value = gen;
                    insert.Parameters.Add("@Foto", System.Data.DbType.String, 200).Value = "Sem Foto";
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    conexao.Close();
                    pnlCadLoad.Visible = true;
                    timer1.Start();


                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao cadastrar!" + err.Message);
                }
            }
            else
            {
                MessageBox.Show("As senhas não conferem!");
            }

        }
    }
}