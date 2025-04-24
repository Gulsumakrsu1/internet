using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akarsu_internet
{
    public partial class frmsatısraporu: Form
    {
        public frmsatısraporu()
        {
            InitializeComponent();
        }

        private void frmsatısraporu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
