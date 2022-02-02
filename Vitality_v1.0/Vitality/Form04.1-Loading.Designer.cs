
namespace Vitality
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.pnlCadLoad = new System.Windows.Forms.Panel();
            this.lblDadosConc = new System.Windows.Forms.Label();
            this.lblOKDados = new System.Windows.Forms.Label();
            this.btnDadosOK = new System.Windows.Forms.Button();
            this.lblDadosLoad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbGif = new System.Windows.Forms.PictureBox();
            this.pnlCadLoad.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadLoad
            // 
            this.pnlCadLoad.BackColor = System.Drawing.Color.White;
            this.pnlCadLoad.Controls.Add(this.lblDadosConc);
            this.pnlCadLoad.Controls.Add(this.lblOKDados);
            this.pnlCadLoad.Controls.Add(this.btnDadosOK);
            this.pnlCadLoad.Controls.Add(this.lblDadosLoad);
            this.pnlCadLoad.Controls.Add(this.pbGif);
            this.pnlCadLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadLoad.Location = new System.Drawing.Point(3, 3);
            this.pnlCadLoad.Name = "pnlCadLoad";
            this.pnlCadLoad.Size = new System.Drawing.Size(356, 173);
            this.pnlCadLoad.TabIndex = 52;
            // 
            // lblDadosConc
            // 
            this.lblDadosConc.AutoSize = true;
            this.lblDadosConc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblDadosConc.Location = new System.Drawing.Point(113, 49);
            this.lblDadosConc.Name = "lblDadosConc";
            this.lblDadosConc.Size = new System.Drawing.Size(128, 17);
            this.lblDadosConc.TabIndex = 30;
            this.lblDadosConc.Text = "Dados atualizados!";
            this.lblDadosConc.Visible = false;
            // 
            // lblOKDados
            // 
            this.lblOKDados.AutoSize = true;
            this.lblOKDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblOKDados.Location = new System.Drawing.Point(56, 80);
            this.lblOKDados.Name = "lblOKDados";
            this.lblOKDados.Size = new System.Drawing.Size(245, 34);
            this.lblOKDados.TabIndex = 29;
            this.lblOKDados.Text = "As modificações feitas já estão sendo\r\n            aplicadas no programa.";
            this.lblOKDados.Visible = false;
            // 
            // btnDadosOK
            // 
            this.btnDadosOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnDadosOK.FlatAppearance.BorderSize = 0;
            this.btnDadosOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDadosOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.btnDadosOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.btnDadosOK.Location = new System.Drawing.Point(126, 134);
            this.btnDadosOK.Name = "btnDadosOK";
            this.btnDadosOK.Size = new System.Drawing.Size(89, 30);
            this.btnDadosOK.TabIndex = 28;
            this.btnDadosOK.Text = "OK";
            this.btnDadosOK.UseVisualStyleBackColor = true;
            this.btnDadosOK.Visible = false;
            this.btnDadosOK.Click += new System.EventHandler(this.btnDadosOK_Click);
            // 
            // lblDadosLoad
            // 
            this.lblDadosLoad.AutoSize = true;
            this.lblDadosLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lblDadosLoad.Location = new System.Drawing.Point(37, 114);
            this.lblDadosLoad.Name = "lblDadosLoad";
            this.lblDadosLoad.Size = new System.Drawing.Size(289, 17);
            this.lblDadosLoad.TabIndex = 1;
            this.lblDadosLoad.Text = "Aguarde, estamos atualizando seus dados...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.pnlCadLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 180);
            this.panel1.TabIndex = 53;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.pnlCadLoad.ResumeLayout(false);
            this.pnlCadLoad.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadLoad;
        private System.Windows.Forms.Label lblDadosConc;
        private System.Windows.Forms.Label lblOKDados;
        private System.Windows.Forms.Button btnDadosOK;
        private System.Windows.Forms.Label lblDadosLoad;
        private System.Windows.Forms.PictureBox pbGif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}