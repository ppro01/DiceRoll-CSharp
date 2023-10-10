using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRolagem_Click(object sender, EventArgs e)
        {
            frmRolagem fr = new frmRolagem();
            fr.ShowDialog();
        }

        private void btnIniciativa_Click(object sender, EventArgs e)
        {
            frmIniciativa fi = new frmIniciativa();
            fi.ShowDialog();
        }
    }
}
