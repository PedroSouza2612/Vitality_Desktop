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
    public partial class Form06_Deletar_Conta : Form
    {
        Thread cancelar, deletado;
        string senha;
        public Form06_Deletar_Conta()
        {
            InitializeComponent();
        }
        private void Form06_Deletar_Conta_Load(object sender, EventArgs e)
        {
            lblCReVA.Text = Vit_Globais.CReVersao;
            SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                      "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
            conexao.Open();
            SQLiteCommand select = new SQLiteCommand("SELECT Senha FROM vit_usuarios" +
                " WHERE ID_Usuario = @id", conexao);
            select.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
            SQLiteDataReader sen;
            sen = select.ExecuteReader();
            sen.Read();
            senha = sen.GetString(0);
            conexao.Close();
        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtDelSenha.Text == "")
            {
                lblAtencao.Visible = false;
                pnlConfDel.Visible = true;
                lblErro.Visible = true;
                btnErro.Visible = true;
            }
            else if (txtDelSenha.Text != senha)
            {
                lblAtencao.Visible = false;
                pnlConfDel.Visible = true;
                lblErro.Visible = true;
                lblErro.Text = "ERRO:A senha está incorreta!";
                btnErro.Visible = true;
            }
            else
            {
                lblAtencao.Visible = true;
                pnlConfDel.Visible = true;
                lblDeletar.Visible = true;
                btnCancel.Visible = true;
                btnOkDel.Visible = true;
                btnErro.Visible = false;
                lblErro.Visible = false;
            }
        }
        private void btnOkDel_Click(object sender, EventArgs e)
        {

            try
            {
                SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                 "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                conexao.Open();
                SQLiteCommand delete = new SQLiteCommand("DELETE FROM vit_usuarios WHERE ID_Usuario = @id", conexao);
                delete.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                delete.CommandType = CommandType.Text;
                delete.ExecuteNonQuery();
                this.Close();
                deletado = new Thread(ContaDeletada);
                deletado.SetApartmentState(ApartmentState.STA);
                deletado.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlConfDel.Visible = false;
            btnOkDel.Visible = false;
            btnCancel.Visible = false;
            lblDeletar.Visible = false;
            
        }

        private void ContaDeletada()
        {
            Application.Run(new Form02_Cadastro());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            cancelar = new Thread(CancelarDelete);
            cancelar.SetApartmentState(ApartmentState.STA);
            cancelar.Start();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            pnlConfDel.Visible = false;
            btnErro.Visible = false;
            lblErro.Visible = false;
        }

        private void CancelarDelete()
        {
            Application.Run(new Form03_Inicio());
        }
    }
}
