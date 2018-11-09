using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurSqlServer.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Add("ISII");
            treeView1.Nodes[0].Nodes.Add("Tramello");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Insegnanti");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Insegnanti");
            treeView1.EndUpdate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
