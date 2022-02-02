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
    public partial class Form1 : Form
    {
        Thread cad,inicio;
        public static int id;
        public static string nome,gen;
        string usuario, senha, confse;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCReVersao.Text = ("\u00A9" + DateTime.Now.ToString("yyyy") + " - Vitality   v1.0.0");
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            cad = new Thread(cadastrar);
            cad.SetApartmentState(ApartmentState.STA);
            cad.Start();
        }

        private void cadastrar()
        {
            Application.Run(new Form02_Cadastro());
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuarioLogin.Text;
            confse = txtSenhaLogin.Text;
            try
            {
                SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                    "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                conexao.Open();
                SQLiteCommand login = new SQLiteCommand("SELECT ID_Usuario,Nome,Senha,Genero FROM vit_usuarios WHERE Usuario='" + usuario + "'", conexao);
                SQLiteDataReader confere;
                confere = login.ExecuteReader();
                confere.Read();
                id = confere.GetInt32(0);
                nome = confere.GetString(1);
                senha = confere.GetString(2);
                gen = confere.GetString(3);
                conexao.Close();
                if (senha == confse)
                {
                    this.Close();
                    inicio = new Thread(FormInicio);
                    inicio.SetApartmentState(ApartmentState.STA);
                    inicio.Start();
                }
                else if (senha != confse)
                {
                    MessageBox.Show("Senha incorreta!");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Nome de usuário inválido ou insexistente!");
            }
        }

        private void FormInicio()
        {
            Application.Run(new Form03_Inicio());
        }
    }
}
