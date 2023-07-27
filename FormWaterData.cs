using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWIiR_APP
{
    public partial class FormWaterData : Form
    {
        public FormWaterData()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
