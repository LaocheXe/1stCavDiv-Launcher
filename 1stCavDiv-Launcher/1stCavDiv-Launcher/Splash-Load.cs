using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stCavDiv_Launcher
{
    public partial class Splash_Load : Form
    {
        public Splash_Load()
        {
            InitializeComponent();
        }

        private void Splash_Load_Load(object sender, EventArgs e)
        {

        }

        private void tLoading_Tick(object sender, EventArgs e)
        {
            pgbLoading.Increment(1);
            if (pgbLoading.Value == 500)
            {
                tLoading.Stop();
            }
        }
    }
}
