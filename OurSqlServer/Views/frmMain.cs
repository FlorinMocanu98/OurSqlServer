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
        List<string> schools = new List<string>();

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


            // Salvo dentro una lista i nomi di tutte le scuole, sono elementi di secondo livello nell'albero
            foreach (TreeNode tn in treeView1.Nodes[0].Nodes) 
                schools.Add(tn.Text);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Se il nodo selezionato è una scuola si genera il comando USE + scuola_selezionata

            if (schools.Any(item => item == e.Node.Text)) {
                txtQuery.Text = "USE " + e.Node.Text;

            }
            else
                txtQuery.Clear();



        }
    }
}
