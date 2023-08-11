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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();

            string versionProgram = "1.0";
            version.Text = string.Format("Wersja programu: {0}", versionProgram);
            string authorProgram = "Kamil Kubiak";
            author.Text = string.Format("Autor: {0}", authorProgram);
            string unit = "Wydział Inwestycji i Remontów Komendy Wojewódzkiej Policji w Poznaniu";
            unit_label.Text = unit;
        }
    }
}
