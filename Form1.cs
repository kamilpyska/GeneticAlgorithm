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
            Dictionary<List<int>, int> fileAsDictionary = new Dictionary<List<int>, int>();

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string[] text = File.ReadAllLines(file); 
                    
                    foreach (string line in text)
                    {
                        string[] splitedLine = line.Split(' ');
                        List<int> dictionaryValueList = new List<int>();

                        for (int i = 0; i < splitedLine.Length -1; i++)
                        {
                            dictionaryValueList.Add(Convert.ToInt32(splitedLine[i]));
                        }
                        fileAsDictionary.Add(dictionaryValueList, Convert.ToInt32(splitedLine[line.Length-1]));
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
