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
        Dictionary<List<int>, int> tstDictionary = new Dictionary<List<int>, int>();
        Dictionary<List<int>, int> trnDictionary = new Dictionary<List<int>, int>();
        Dictionary<List<int>, int> valDictionary = new Dictionary<List<int>, int>();

        Algorithm algorithm = new Algorithm();
        

        public Form1()
        {
            InitializeComponent();
        }
        private void btnReadTestSystem_Click(object sender, EventArgs e)
        {
            tstDictionary = openFileAsDictionary();
        }
        private void btnReadTrainingSystem_Click(object sender, EventArgs e)
        {
            trnDictionary = openFileAsDictionary();
        }
        private void btnReadValidationSystem_Click(object sender, EventArgs e)
        {
            valDictionary = openFileAsDictionary();
        }

        private Dictionary<List<int>, int> openFileAsDictionary() 
        {
            Dictionary<List<int>, int> fileAsDictionary = new Dictionary<List<int>, int>();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                try
                {
                    string[] text = File.ReadAllLines(file);
                    
                    foreach (string line in text)
                    {
                        string[] splitedLine = line.Split(' ');
                        List<int> dictionaryValueList = new List<int>();
                        int decisionC = 0;

                        for (int i = 0; i < splitedLine.Length-1; i++) //all attributes without the last
                        {
                            dictionaryValueList.Add(Convert.ToInt32(splitedLine[i]));
                        }
                        decisionC = Convert.ToInt32(splitedLine[splitedLine.Length - 1]); //the last attribute is the decision C
                        fileAsDictionary.Add(dictionaryValueList, decisionC);
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
