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

namespace Vitality
{
    public partial class Loading : Form
    {
        Thread dadosOK;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbGif.Visible = false;
            lblDadosLoad.Visible = false;
            lblDadosConc.Visible = true;
            lblOKDados.Visible = true;
            btnDadosOK.Visible = true;
        }

        private void btnDadosOK_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
