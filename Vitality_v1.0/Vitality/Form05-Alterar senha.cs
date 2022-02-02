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
    public partial class Form05_Alterar_senha : Form
    {
        Thread login,cancelar;
        string Csenha;
        public Form05_Alterar_senha()
        {
            InitializeComponent();
        }

        private void Form05_Alterar_senha_Load(object sender, EventArgs e)
        {
            lblCReVA.Text = Vit_Globais.CReVersao;
            SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos" +
                       "\\PHfaculESenai\\Vitality_v1.0" +
                       "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
            conexao.Open();
            SQLiteCommand senha = new SQLiteCommand("SELECT Senha FROM vit_usuarios WHERE ID_Usuario = @id", conexao);
            senha.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
            SQLiteDataReader cof;
            cof = senha.ExecuteReader();
            cof.Read();
            Csenha = cof.GetString(0);
            conexao.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((txtConfNSenha.Text == "") && (txtNsenha.Text == ""))
            {
                pnlAlterações.Visible = true;
                lblErro.Visible = true;
                lblErro.Text = "ERRO.:Inisra a nova senha antes!";
                btnOKerro.Visible = true;
            }
            else if (txtNsenha.Text == "")
            {
                pnlAlterações.Visible = true;
                lblErro.Visible = true;
                lblErro.Text = "A senha não pode estar vazia!";
                btnOKerro.Visible = true;
            }
            else if (txtConfNSenha.Text == "")
            {
                pnlAlterações.Visible = true;
                lblErro.Visible = true;
                lblErro.Text = "Confirme a nova senha primeiro!";
                btnOKerro.Visible = true;
            }
            else if (txtConfNSenha.Text != txtNsenha.Text)
            {
                pnlAlterações.Visible = true;
                lblErro.Visible = true;
                lblErro.Text = "ERRO.:As senhas não conferem!";
                btnOKerro.Visible = true;
            }
            else if (txtConfNSenha.Text == txtNsenha.Text)
            {
                if (txtNsenha.Text == Csenha)
                {
                    MessageBox.Show("A senha não pode ser igual a anterior");
                }
                else
                {
                    try
                    {
                        SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos" +
                            "\\PHfaculESenai\\Vitality_v1.0" +
                            "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                        conexao.Open();
                        SQLiteCommand update = new SQLiteCommand("UPDATE vit_usuarios SET" +
                            " Senha = @senha WHERE ID_Usuario = @id", conexao);
                        update.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                        update.Parameters.Add("@senha", DbType.String).Value = txtNsenha.Text;
                        update.CommandType = CommandType.Text;
                        update.ExecuteNonQuery();
                        conexao.Close();
                        pnlAlterações.Visible = true;
                        pbGif.Visible = true;
                        lblSenhaLoad.Visible = true;
                        btnOKerro.Visible = false;
                        btnSenhaOK.Visible = false;
                        timer1.Start();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSenhaLoad.Visible = false;
            pbGif.Visible = false;
            lblSenhaAtu.Visible = true;
            lblOKSenha.Visible = true;
            btnSenhaOK.Visible = true;
            timer1.Stop();
        }

        private void btnOKerro_Click(object sender, EventArgs e)
        {
            pnlAlterações.Visible = false;
            lblErro.Visible = false;
            btnOKerro.Visible = false;
        }

        private void btnSenhaOK_Click(object sender, EventArgs e)
        {
            this.Close();
            login = new Thread(SenhaAlterada);
            login.SetApartmentState(ApartmentState.STA);
            login.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = new Thread(Cancel);
            cancelar.SetApartmentState(ApartmentState.STA);
            cancelar.Start();
        }

        private void SenhaAlterada()
        {
            Application.Run(new Form1());
        }
        private void Cancel()
        {
            Application.Run(new Form03_Inicio());
        }
    }
}
