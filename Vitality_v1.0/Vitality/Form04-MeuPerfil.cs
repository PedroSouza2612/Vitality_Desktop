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
    public partial class Form04_MeuPerfil : Form
    {
        string confFoto, confGen, updGen, uniTel, uniUsu, uniEmail;
        Thread volta,loading,altSenha,deletar;
        SQLiteConnection conexao = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality v1.0" +
                    "\\Vitality\\BD_Vitality\\Banco_Vitality.db");

  

        public Form04_MeuPerfil()
        {
            InitializeComponent();
        }

        private void Form04_MeuPerfil_Load(object sender, EventArgs e)
        {
            lblCReVersao.Text = Vit_Globais.CReVersao;
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=D:\\Documentos\\PHfaculESenai\\Vitality_v1.0" +
                    "\\Vitality\\BD_Vitality\\Banco_Vitality.db");
                con.Open();
                SQLiteCommand update = new SQLiteCommand("SELECT Nome,Sobrenome,Endereco," +
                    "Cidade,UF,CEP,Telefone,Email,Usuario,Data_Nasc," +
                    "Genero,Foto FROM vit_usuarios WHERE ID_Usuario= @id", con);
                update.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                SQLiteDataReader conf;
                conf = update.ExecuteReader();
                conf.Read();
                txtNome.Text = conf.GetString(0);
                txtSobreNome.Text = conf.GetString(1);
                txtEndereco.Text = conf.GetString(2);
                txtCidade.Text = conf.GetString(3);
                cbUF.Text = conf.GetString(4);
                mskCEP.Text = conf.GetString(5);
                mskTel.Text = conf.GetString(6);
                txtEmail.Text = conf.GetString(7);
                txtUsuario.Text = conf.GetString(8);
                mskData.Text = conf.GetString(9);
                confGen = conf.GetString(10);
                confFoto = conf.GetString(11);
                uniUsu = txtUsuario.Text;
                uniTel = mskTel.Text;
                uniEmail = txtEmail.Text;
                con.Close();
                if (confGen == "M")
                {
                    rbtM.Checked = true;
                }
                else if (confGen == "F")
                {
                    rbtF.Checked = true;
                }
                else if (confGen == "I")
                {
                    rbtI.Checked = true;
                }

                if (confFoto == "Sem Foto")
                {
                    btnAdcOuAltFoto.Text = "Adicionar Foto";
                    btnRemoverFoto.Visible = false;
                }
                lblName.Text = (txtNome.Text + " " + txtSobreNome.Text);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
               
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCidade.Enabled = true;
            mskCEP.Enabled = true;
            cbUF.Enabled = true;
            mskTel.Enabled = true;
            txtEmail.Enabled = true;
            mskData.Enabled = true;
            txtUsuario.Enabled = true;
            groupBox1.Enabled = true;
            btnSalvar.Visible = true;
            btnCad.Visible = false;

            txtNome.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rbtM.Checked)
            {
                updGen = "M";
            }
            else if (rbtF.Checked)
            {
                updGen = "F";
            }
            else if (rbtI.Checked)
            {
                updGen = "I";
            }

            if (txtEmail.Text == uniEmail)
            {
                try
                {
                   
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep, Telefone = @telefone," +
                        "Usuario = @usuario, Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@telefone", DbType.String).Value = mskTel.Text;
                    atualiza.Parameters.Add("@usuario", DbType.String).Value = txtUsuario.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;

                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if (txtUsuario.Text == uniUsu)
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep, Telefone = @telefone,Email = @email," +
                        "Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@telefone", DbType.String).Value = mskTel.Text;
                    atualiza.Parameters.Add("@email", DbType.String).Value = txtEmail.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;


                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if (mskTel.Text == uniTel)
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep,Email = @email," +
                        "Usuario = @usuario, Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@email", DbType.String).Value = txtEmail.Text;
                    atualiza.Parameters.Add("@usuario", DbType.String).Value = txtUsuario.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;


                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if ((mskTel.Text == uniTel) && (txtUsuario.Text == uniUsu))
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep,Email = @email," +
                        "Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@email", DbType.String).Value = txtEmail.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;

                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;

            }

            if ((mskTel.Text == uniTel) && (txtEmail.Text == uniEmail))
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep,Usuario = @usuario, Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@usuario", DbType.String).Value = txtUsuario.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;

                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if ((txtEmail.Text == uniEmail) && (txtUsuario.Text == uniUsu))
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep, Telefone = @telefone, Data_Nasc = @data, " +
                        "Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@telefone", DbType.String).Value = mskTel.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;


                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if ((txtEmail.Text == uniEmail) && (txtUsuario.Text == uniUsu) && (mskTel.Text == uniTel))
            {
                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep, Telefone = @telefone,Email = @email," +
                        "Usuario = @usuario, Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;

                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
                return;
            }

            if ((txtEmail.Text != uniEmail) && (txtUsuario.Text != uniUsu) && (mskTel.Text != uniTel))
            {

                try
                {
                    conexao.Open();
                    SQLiteCommand atualiza = new SQLiteCommand("UPDATE vit_usuarios SET Nome = @nome," +
                        "Sobrenome = @sobrenome, Endereco = @endereco, Cidade = @cidade," +
                        "UF = @uf, CEP = @cep, Telefone = @telefone,Email = @email," +
                        "Usuario = @usuario, Data_Nasc = @data, Genero = @gen WHERE ID_Usuario = @id", conexao);
                    atualiza.Parameters.Add("@id", DbType.Int32).Value = Form1.id;
                    atualiza.Parameters.Add("@nome", DbType.String).Value = txtNome.Text;
                    atualiza.Parameters.Add("@sobrenome", DbType.String).Value = txtSobreNome.Text;
                    atualiza.Parameters.Add("@cidade", DbType.String).Value = txtCidade.Text;
                    atualiza.Parameters.Add("@endereco", DbType.String).Value = txtEndereco.Text;
                    atualiza.Parameters.Add("@uf", DbType.String).Value = cbUF.Text;
                    atualiza.Parameters.Add("@cep", DbType.String).Value = mskCEP.Text;
                    atualiza.Parameters.Add("@telefone", DbType.String).Value = mskTel.Text;
                    atualiza.Parameters.Add("@email", DbType.String).Value = txtEmail.Text;
                    atualiza.Parameters.Add("@usuario", DbType.String).Value = txtUsuario.Text;
                    atualiza.Parameters.Add("@data", DbType.String).Value = mskData.Text;
                    atualiza.Parameters.Add("@gen", DbType.String).Value = updGen;
                    atualiza.CommandType = CommandType.Text;
                    atualiza.ExecuteNonQuery();
                    conexao.Close();
                    loading = new Thread(LoadingDados);
                    loading.SetApartmentState(ApartmentState.STA);
                    loading.Start();
                    txtNome.Enabled = false;
                    txtSobreNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    mskCEP.Enabled = false;
                    cbUF.Enabled = false;
                    mskTel.Enabled = false;
                    txtEmail.Enabled = false;
                    mskData.Enabled = false;
                    txtUsuario.Enabled = false;
                    groupBox1.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCad.Visible = true;


                }
                catch (Exception err)
                {
                    MessageBox.Show("Falha ao atualizar os dados" + err.Message);
                    conexao.Close();
                }
             
            }
            return;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
            volta = new Thread(SairAtualizacao);
            volta.SetApartmentState(ApartmentState.STA);
            volta.Start();
        }
        private void btnAltSenha_Click(object sender, EventArgs e)
        {
            this.Close();
            altSenha = new Thread(AlterarASenha);
            altSenha.SetApartmentState(ApartmentState.STA);
            altSenha.Start();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            deletar = new Thread(FormDeletar);
            deletar.SetApartmentState(ApartmentState.STA);
            deletar.Start();
        }

        private void SairAtualizacao()
        {
            Application.Run(new Form03_Inicio());
        }
        private void LoadingDados()
        {
            Application.Run(new Loading());
        }
        private void AlterarASenha()
        {
            Application.Run(new Form05_Alterar_senha());
        }
        private void FormDeletar()
        {
            Application.Run(new Form06_Deletar_Conta());
        }

    }
}



