
namespace Vitality
{
    partial class Form05_Alterar_senha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form05_Alterar_senha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAlterações = new System.Windows.Forms.Panel();
            this.pnlCadLoad = new System.Windows.Forms.Panel();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblSenhaAtu = new System.Windows.Forms.Label();
            this.lblOKSenha = new System.Windows.Forms.Label();
            this.btnSenhaOK = new System.Windows.Forms.Button();
            this.lblSenhaLoad = new System.Windows.Forms.Label();
            this.pbGif = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCReVA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtConfNSenha = new System.Windows.Forms.TextBox();
            this.txtNsenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCReVersao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOKerro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlAlterações.SuspendLayout();
            this.pnlCadLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.pnlAlterações);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCReVA);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCReVersao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 10F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 347);
            this.panel1.TabIndex = 1;
            // 
            // pnlAlterações
            // 
            this.pnlAlterações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.pnlAlterações.Controls.Add(this.pnlCadLoad);
            this.pnlAlterações.Location = new System.Drawing.Point(135, 83);
            this.pnlAlterações.Name = "pnlAlterações";
            this.pnlAlterações.Size = new System.Drawing.Size(363, 180);
            this.pnlAlterações.TabIndex = 55;
            this.pnlAlterações.Visible = false;
            // 
            // pnlCadLoad
            // 
            this.pnlCadLoad.BackColor = System.Drawing.Color.White;
            this.pnlCadLoad.Controls.Add(this.btnOKerro);
            this.pnlCadLoad.Controls.Add(this.lblErro);
            this.pnlCadLoad.Controls.Add(this.lblSenhaAtu);
            this.pnlCadLoad.Controls.Add(this.lblOKSenha);
            this.pnlCadLoad.Controls.Add(this.btnSenhaOK);
            this.pnlCadLoad.Controls.Add(this.lblSenhaLoad);
            this.pnlCadLoad.Controls.Add(this.pbGif);
            this.pnlCadLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadLoad.Location = new System.Drawing.Point(3, 3);
            this.pnlCadLoad.Name = "pnlCadLoad";
            this.pnlCadLoad.Size = new System.Drawing.Size(356, 173);
            this.pnlCadLoad.TabIndex = 52;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblErro.Location = new System.Drawing.Point(73, 64);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(226, 17);
            this.lblErro.TabIndex = 31;
            this.lblErro.Text = "ERRO:. Insira a nova senha antes!";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErro.Visible = false;
            // 
            // lblSenhaAtu
            // 
            this.lblSenhaAtu.AutoSize = true;
            this.lblSenhaAtu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblSenhaAtu.Location = new System.Drawing.Point(118, 49);
            this.lblSenhaAtu.Name = "lblSenhaAtu";
            this.lblSenhaAtu.Size = new System.Drawing.Size(121, 17);
            this.lblSenhaAtu.TabIndex = 30;
            this.lblSenhaAtu.Text = "Senha atualizada!";
            this.lblSenhaAtu.Visible = false;
            // 
            // lblOKSenha
            // 
            this.lblOKSenha.AutoSize = true;
            this.lblOKSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblOKSenha.Location = new System.Drawing.Point(73, 80);
            this.lblOKSenha.Name = "lblOKSenha";
            this.lblOKSenha.Size = new System.Drawing.Size(218, 34);
            this.lblOKSenha.TabIndex = 29;
            this.lblOKSenha.Text = "Logue novamente para continuar\r\n           utilizando o Vitality.";
            this.lblOKSenha.Visible = false;
            // 
            // btnSenhaOK
            // 
            this.btnSenhaOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnSenhaOK.FlatAppearance.BorderSize = 0;
            this.btnSenhaOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSenhaOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnSenhaOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenhaOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenhaOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnSenhaOK.Location = new System.Drawing.Point(126, 134);
            this.btnSenhaOK.Name = "btnSenhaOK";
            this.btnSenhaOK.Size = new System.Drawing.Size(89, 30);
            this.btnSenhaOK.TabIndex = 28;
            this.btnSenhaOK.Text = "OK";
            this.btnSenhaOK.UseVisualStyleBackColor = true;
            this.btnSenhaOK.Visible = false;
            this.btnSenhaOK.Click += new System.EventHandler(this.btnSenhaOK_Click);
            // 
            // lblSenhaLoad
            // 
            this.lblSenhaLoad.AutoSize = true;
            this.lblSenhaLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblSenhaLoad.Location = new System.Drawing.Point(36, 114);
            this.lblSenhaLoad.Name = "lblSenhaLoad";
            this.lblSenhaLoad.Size = new System.Drawing.Size(287, 17);
            this.lblSenhaLoad.TabIndex = 1;
            this.lblSenhaLoad.Text = "Aguarde, estamos carregando a alteração...";
            this.lblSenhaLoad.Visible = false;
            // 
            // pbGif
            // 
            this.pbGif.Image = global::Vitality.Properties.Resources.Loading_GIF;
            this.pbGif.Location = new System.Drawing.Point(106, 16);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(144, 84);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGif.TabIndex = 0;
            this.pbGif.TabStop = false;
            this.pbGif.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "A senha deve conter no máximo\r\n10 caracteres.";
            // 
            // lblCReVA
            // 
            this.lblCReVA.AutoSize = true;
            this.lblCReVA.Location = new System.Drawing.Point(3, 325);
            this.lblCReVA.Name = "lblCReVA";
            this.lblCReVA.Size = new System.Drawing.Size(193, 17);
            this.lblCReVA.TabIndex = 5;
            this.lblCReVA.Text = "Versão Vitality e Ano atual";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.txtConfNSenha);
            this.panel2.Controls.Add(this.txtNsenha);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.panel2.Location = new System.Drawing.Point(271, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 320);
            this.panel2.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(196, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vitality.Properties.Resources.Logo_Oficial2;
            this.pictureBox3.Location = new System.Drawing.Point(105, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(24, 275);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 35);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtConfNSenha
            // 
            this.txtConfNSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtConfNSenha.Location = new System.Drawing.Point(90, 236);
            this.txtConfNSenha.Name = "txtConfNSenha";
            this.txtConfNSenha.Size = new System.Drawing.Size(150, 24);
            this.txtConfNSenha.TabIndex = 6;
            this.txtConfNSenha.UseSystemPasswordChar = true;
            // 
            // txtNsenha
            // 
            this.txtNsenha.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.txtNsenha.Location = new System.Drawing.Point(90, 175);
            this.txtNsenha.Name = "txtNsenha";
            this.txtNsenha.Size = new System.Drawing.Size(150, 24);
            this.txtNsenha.TabIndex = 5;
            this.txtNsenha.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Confirmar senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nova senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alterar senha";
            // 
            // lblCReVersao
            // 
            this.lblCReVersao.AutoSize = true;
            this.lblCReVersao.Location = new System.Drawing.Point(3, 464);
            this.lblCReVersao.Name = "lblCReVersao";
            this.lblCReVersao.Size = new System.Drawing.Size(48, 17);
            this.lblCReVersao.TabIndex = 4;
            this.lblCReVersao.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira a nova senha e em seguida \r\nlogue novamente no aplicativo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar senha:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOKerro
            // 
            this.btnOKerro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnOKerro.FlatAppearance.BorderSize = 0;
            this.btnOKerro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOKerro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnOKerro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKerro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnOKerro.Location = new System.Drawing.Point(126, 134);
            this.btnOKerro.Name = "btnOKerro";
            this.btnOKerro.Size = new System.Drawing.Size(89, 30);
            this.btnOKerro.TabIndex = 32;
            this.btnOKerro.Text = "OK";
            this.btnOKerro.UseVisualStyleBackColor = true;
            this.btnOKerro.Click += new System.EventHandler(this.btnOKerro_Click);
            // 
            // Form05_Alterar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 347);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form05_Alterar_senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form05_Alterar_senha";
            this.Load += new System.EventHandler(this.Form05_Alterar_senha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAlterações.ResumeLayout(false);
            this.pnlCadLoad.ResumeLayout(false);
            this.pnlCadLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtConfNSenha;
        private System.Windows.Forms.TextBox txtNsenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCReVersao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCReVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAlterações;
        private System.Windows.Forms.Panel pnlCadLoad;
        private System.Windows.Forms.Label lblSenhaAtu;
        private System.Windows.Forms.Label lblOKSenha;
        private System.Windows.Forms.Button btnSenhaOK;
        private System.Windows.Forms.Label lblSenhaLoad;
        private System.Windows.Forms.PictureBox pbGif;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnOKerro;
    }
}