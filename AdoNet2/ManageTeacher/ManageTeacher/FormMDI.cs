using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTeacher
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void menuStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStripBasis_Click(object sender, EventArgs e)
        {
            FormBasis1 fBasis = new FormBasis1();
            fBasis.MdiParent = this;
            fBasis.Show();
        }

        private void menuStripUnit_Click(object sender, EventArgs e)
        {
            FormUnit fUnit = new FormUnit();
            fUnit.MdiParent = this;
            fUnit.Show();
        }

        private void menuStripTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher fTeacher = new FormTeacher();
            fTeacher.MdiParent = this;
            fTeacher.Show();
        }
    }
}
