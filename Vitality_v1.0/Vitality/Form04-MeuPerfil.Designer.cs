
namespace Vitality
{
    partial class Form04_MeuPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form04_MeuPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblCReVersao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtI = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.btnAdcOuAltFoto = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAltSenha = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pcBoxFotodePerfil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFotodePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.lblSair);
            this.panel1.Controls.Add(this.lblCReVersao);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 677);
            this.panel1.TabIndex = 1;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSair.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(2, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 22);
            this.lblSair.TabIndex = 10;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblCReVersao
            // 
            this.lblCReVersao.AutoSize = true;
            this.lblCReVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCReVersao.ForeColor = System.Drawing.Color.White;
            this.lblCReVersao.Location = new System.Drawing.Point(3, 658);
            this.lblCReVersao.Name = "lblCReVersao";
            this.lblCReVersao.Size = new System.Drawing.Size(46, 17);
            this.lblCReVersao.TabIndex = 6;
            this.lblCReVersao.Text = "label5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnRemoverFoto);
            this.panel2.Controls.Add(this.btnAdcOuAltFoto);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAltSenha);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.mskData);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.mskTel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnCad);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbUF);
            this.panel2.Controls.Add(this.mskCEP);
            this.panel2.Controls.Add(this.txtCidade);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.txtSobreNome);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pcBoxFotodePerfil);
            this.panel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 618);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtI);
            this.groupBox1.Controls.Add(this.rbtF);
            this.groupBox1.Controls.Add(this.rbtM);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 53);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                                 Genêro";
            // 
            // rbtI
            // 
            this.rbtI.AutoSize = true;
            this.rbtI.FlatAppearance.BorderSize = 0;
            this.rbtI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtI.Location = new System.Drawing.Point(325, 22);
            this.rbtI.Name = "rbtI";
            this.rbtI.Size = new System.Drawing.Size(130, 21);
            this.rbtI.TabIndex = 2;
            this.rbtI.TabStop = true;
            this.rbtI.Text = "Prefiro não dizer";
            this.rbtI.UseVisualStyleBackColor = true;
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.FlatAppearance.BorderSize = 0;
            this.rbtF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtF.Location = new System.Drawing.Point(177, 22);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(82, 21);
            this.rbtF.TabIndex = 1;
            this.rbtF.TabStop = true;
            this.rbtF.Text = "Feminino";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.FlatAppearance.BorderSize = 0;
            this.rbtM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtM.Location = new System.Drawing.Point(18, 23);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(88, 21);
            this.rbtM.TabIndex = 0;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "Masculino";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnRemoverFoto.FlatAppearance.BorderSize = 0;
            this.btnRemoverFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRemoverFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnRemoverFoto.Location = new System.Drawing.Point(18, 178);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(134, 31);
            this.btnRemoverFoto.TabIndex = 48;
            this.btnRemoverFoto.Text = "Remover foto";
            this.btnRemoverFoto.UseVisualStyleBackColor = true;
            // 
            // btnAdcOuAltFoto
            // 
            this.btnAdcOuAltFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnAdcOuAltFoto.FlatAppearance.BorderSize = 0;
            this.btnAdcOuAltFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdcOuAltFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnAdcOuAltFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcOuAltFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcOuAltFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnAdcOuAltFoto.Location = new System.Drawing.Point(18, 153);
            this.btnAdcOuAltFoto.Name = "btnAdcOuAltFoto";
            this.btnAdcOuAltFoto.Size = new System.Drawing.Size(134, 31);
            this.btnAdcOuAltFoto.TabIndex = 47;
            this.btnAdcOuAltFoto.Text = "Alterar foto";
            this.btnAdcOuAltFoto.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(348, 542);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 40);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Excluir minha conta";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAltSenha
            // 
            this.btnAltSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnAltSenha.FlatAppearance.BorderSize = 0;
            this.btnAltSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAltSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnAltSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnAltSenha.Location = new System.Drawing.Point(204, 542);
            this.btnAltSenha.Name = "btnAltSenha";
            this.btnAltSenha.Size = new System.Drawing.Size(120, 40);
            this.btnAltSenha.TabIndex = 45;
            this.btnAltSenha.Text = "Alterar senha";
            this.btnAltSenha.UseVisualStyleBackColor = true;
            this.btnAltSenha.Click += new System.EventHandler(this.btnAltSenha_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnSalvar.Location = new System.Drawing.Point(26, 542);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 40);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label12.Location = new System.Drawing.Point(15, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nome de Usuário:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label11.Location = new System.Drawing.Point(15, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(15, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(15, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(15, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(15, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(15, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Data de Nascimento:";
            // 
            // mskData
            // 
            this.mskData.BackColor = System.Drawing.Color.White;
            this.mskData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskData.Enabled = false;
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.mskData.Location = new System.Drawing.Point(161, 411);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(70, 23);
            this.mskData.TabIndex = 35;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtUsuario.Location = new System.Drawing.Point(143, 438);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 23);
            this.txtUsuario.TabIndex = 32;
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.White;
            this.mskTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTel.Enabled = false;
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.mskTel.Location = new System.Drawing.Point(321, 356);
            this.mskTel.Mask = "(00)00000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(97, 23);
            this.mskTel.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label9.Location = new System.Drawing.Point(247, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Telefone:";
            // 
            // btnCad
            // 
            this.btnCad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnCad.Location = new System.Drawing.Point(32, 542);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(120, 40);
            this.btnCad.TabIndex = 27;
            this.btnCad.Text = "Alterar dados";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtEmail.Location = new System.Drawing.Point(67, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label7.Location = new System.Drawing.Point(141, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(15, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "CEP:";
            // 
            // cbUF
            // 
            this.cbUF.BackColor = System.Drawing.Color.White;
            this.cbUF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUF.Enabled = false;
            this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbUF.Location = new System.Drawing.Point(177, 356);
            this.cbUF.MaxLength = 2;
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(50, 24);
            this.cbUF.TabIndex = 17;
            // 
            // mskCEP
            // 
            this.mskCEP.BackColor = System.Drawing.Color.White;
            this.mskCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCEP.Enabled = false;
            this.mskCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.mskCEP.Location = new System.Drawing.Point(60, 356);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(65, 23);
            this.mskCEP.TabIndex = 15;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtCidade.Location = new System.Drawing.Point(77, 326);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(193, 23);
            this.txtCidade.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtEndereco.Location = new System.Drawing.Point(94, 296);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(241, 23);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.BackColor = System.Drawing.Color.White;
            this.txtSobreNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobreNome.Enabled = false;
            this.txtSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobreNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtSobreNome.Location = new System.Drawing.Point(106, 269);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(289, 23);
            this.txtSobreNome.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtNome.Location = new System.Drawing.Point(70, 239);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblName.Location = new System.Drawing.Point(158, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nome do usuario";
            // 
            // pcBoxFotodePerfil
            // 
            this.pcBoxFotodePerfil.Image = global::Vitality.Properties.Resources.sem_foto;
            this.pcBoxFotodePerfil.Location = new System.Drawing.Point(18, 30);
            this.pcBoxFotodePerfil.Name = "pcBoxFotodePerfil";
            this.pcBoxFotodePerfil.Size = new System.Drawing.Size(134, 120);
            this.pcBoxFotodePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxFotodePerfil.TabIndex = 1;
            this.pcBoxFotodePerfil.TabStop = false;
            // 
            // Form04_MeuPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 677);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form04_MeuPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form04_MeuPerfil";
            this.Load += new System.EventHandler(this.Form04_MeuPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFotodePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.Button btnAdcOuAltFoto;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAltSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskData;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pcBoxFotodePerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtI;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.Label lblCReVersao;
        private System.Windows.Forms.Label lblSair;
    }
}