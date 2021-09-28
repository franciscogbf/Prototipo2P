using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form frm = new Estudiante();
            frm.Show();
        }

        private void ingresoCatedráticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form frm = new Catedratico();
            frm.Show();
        }
    }
}
