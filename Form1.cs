using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytajTestowy_Click(object sender, EventArgs e)
        {

        }

        private void btnWczytajTreningowy_Click(object sender, EventArgs e)
        {

        }

        private void btnReadValidationSystem_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<List<int>, int> openFile() 
        {
            Dictionary<List<int>, int> fileAsDictionary;

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string[] text = File.ReadAllLines(file); 
                    
                    foreach (string line in text)
                    {
                        int stringLength = line.Length;
                        List<string> dictionaryValueList = new List<string>();
                        //podzielic linie na stringi i ostatni zapisac jako decyzje a reszte jako liste stringow
                        for (int i = 0; i < stringLength-1; i++)
                        {

                        }
                    }

                }
                catch (IOException)
                {
                }

                
            }
            return fileAsDictionary;
        }
    }


    }
