using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurSqlServer.Data;
using System.IO;

namespace OurSqlServer
{
    public partial class frmSSMS : Form
    {
        public frmSSMS()
        {
            InitializeComponent();
        }

        private void frmSSMS_Load(object sender, EventArgs e)
        {
            List<Insegnanti> myinsISII = new List<Insegnanti>();
            List<Insegnanti> myinsTRAMELLO = new List<Insegnanti>();
            List<Studenti> mystudISII = new List<Studenti>();
            List<Studenti> mystudTRAMELLO = new List<Studenti>();

            string path_insISII =@"..\..\TextData\InsegnantiISII.txt";
            string path_insTRAMELLO = @"..\..\TextData\InsegnantiTRAMELLO.txt";
            string path_studISII = @"..\..\TextData\StudentiISII.txt";
            string path_studTRAMELLO = @"..\..\TextData\StudentiTRAMELLO.txt";

            var line_insISII = File.ReadLines(path_insISII);
            var line_insTRAMELLO = File.ReadLines(path_insTRAMELLO);
            var line_studISII = File.ReadLines(path_studISII);
            var line_studTRAMELLO = File.ReadLines(path_studTRAMELLO);

            foreach (var line in line_insISII)
            {
                string[] token = line.Split('@');
                Insegnanti insegnantiISII = new Insegnanti(token[0], token[1], token[2]);
                myinsISII.Add(insegnantiISII);
                
            }

            foreach (var line in line_insTRAMELLO)
            {
                string[] token = line.Split('@');
                Insegnanti insegnantiTRAMELLO = new Insegnanti(token[0], token[1], token[2]);
                myinsTRAMELLO.Add(insegnantiTRAMELLO);
            }

            foreach (var line in line_studISII)
            {
                string[] token = line.Split('@');
                Studenti studentiISII = new Studenti(token[0], token[1], token[2]);
                mystudISII.Add(studentiISII);
            }

            foreach (var line in line_studTRAMELLO)
            {
                string[] token = line.Split('@');
                Studenti studentiTRAMELLO = new Studenti(token[0], token[1], token[2]);
                mystudTRAMELLO.Add(studentiTRAMELLO);
            }

          

           
        }
    }
}
