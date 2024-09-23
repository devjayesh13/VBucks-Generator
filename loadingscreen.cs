using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBucks_Generator
{
    public partial class loadingscreen : Form
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void loadingscreen_Load(object sender, EventArgs e)
        {

        }
         public void updateprogress(int progress)
        {
            progressBar1.Value = progress;
        }
    }
}
