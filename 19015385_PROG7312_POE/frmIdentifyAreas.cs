using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_PROG7312_POE
{


    public partial class frmIdentifyAreas : Form
    {
        private Dictionary<string, string> number_descriptions = new Dictionary<string, string>();

        /*
         * Code Attribution:
         * The above code was taken from Tutorials Teacher: 
         * URL: https://www.tutorialsteacher.com/csharp/csharp-dictionary
         * Author:C# Tutorials Teacher
         * */

        public frmIdentifyAreas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome f1 = new frmHome();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
       
                
                lstbxClues.Items.Clear();
                lstbxDefinition.Items.Clear();
                setRandomCluesDefinitions();
                setRandomCallNumberDefinitions();
              
            

        
           
        }

        private void populateDictionary()
        {
            number_descriptions.Add("000", "General Knowlege");
            number_descriptions.Add("100", "Philosophy & Pyschology");
            number_descriptions.Add("200", "Religion");
            number_descriptions.Add("300", "Social Sciences");
            number_descriptions.Add("400", "Languages");

            number_descriptions.Add("500", "Science");
            number_descriptions.Add("600", "Technology");
            number_descriptions.Add("700", "Arts & Recreation");
            number_descriptions.Add("800", "Literature");
            number_descriptions.Add("900", "History & Geography");


        }

        public List<string> definitions = new List<string>();
        public List<string> callNumbers = new List<string>();

        public void populateListBoxes()
        {

            //get call numbers from dictionary and put into callNumebrs List 
            Dictionary<string, string>.KeyCollection keys = number_descriptions.Keys;
            foreach (string key in keys)
            {
                callNumbers.Add(key);

            }
  


            //get definitions from Dictionary and put into definitions List 
            Dictionary<string, string>.ValueCollection values = number_descriptions.Values;
            foreach (string val in values)
            {
                definitions.Add(val);

            }


            setRandomClues();

            setRandomDefinitions();
          


        }
        /*
   * The above code was taken from Stack Overflow:
   * URL: https://stackoverflow.com/questions/17890233/extracting-key-and-values-in-dictionary-with-in-dictionary-in-c-sharp
   * Author: Brian Rogers
   * */

        public void setRandomDefinitions()
        {
            var random = new Random();
            //Add Random 7 definitions from definitions List to lstbxDefinition
            for (int i = 0; i < 7; i++)
            {
                
                int index = random.Next(definitions.Count);
           

                if (lstbxDefinition.Items.Contains(definitions[index]))
                {
                    index = random.Next(definitions.Count);
              
                }
                lstbxDefinition.Items.Add(definitions[index]);
            }
         

        }

        public void setRandomCallNumberDefinitions()
        {
            var random = new Random();
            //Add Random 7 definitions from definitions List to lstbxDefinition
            for (int i = 0; i < 7; i++)
            {

                int index = random.Next(callNumbers.Count);


                if (lstbxDefinition.Items.Contains(callNumbers[index]))
                {
                    index = random.Next(callNumbers.Count);

                }
                lstbxDefinition.Items.Add(callNumbers[index]);
            }
        }

        public void setRandomClues()
        {
            var random = new Random();
            //Add random 4 call numbers from callNumbers List to lstboxClues 
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(callNumbers.Count);
               
                if (lstbxClues.Items.Contains(callNumbers[index]))
                {
                    index = random.Next(callNumbers.Count);
                  
                }
                lstbxClues.Items.Add(callNumbers[index]);

            }
         

         
        }

        public void setRandomCluesDefinitions()
        {
            var random = new Random();
            //Add random 4 call numbers from callNumbers List to lstboxClues 
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(definitions.Count);

                if (lstbxClues.Items.Contains(definitions[index]))
                {
                    index = random.Next(definitions.Count);

                }
                lstbxClues.Items.Add(definitions[index]);

            }
        }
        /*
   * The above code was taken from tutorials point:
   * URL: https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
   * Author: Arjun Thakur
   * */

        private void frmIdentifyAreas_Load(object sender, EventArgs e)
        {

            populateDictionary();
            populateListBoxes(); 
            lstbxDefinition.Enabled = false;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            lstbxClues.Items.Clear();
            lstbxDefinition.Items.Clear();
            setRandomClues();
            setRandomDefinitions();
        }
        private SortedDictionary<string, string> newDictionary = new SortedDictionary<string, string>();

        /* The above code was taken from c# corner:
  * URL: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-sort-a-dictionary-with-C-Sharp/
  * Author: Mahesh Chand
  * */


        private void lstbxClues_SelectedIndexChanged(object sender, EventArgs e)
        {

                lstbxClues.Enabled = false;
                lstbxDefinition.Enabled = true;
           
                
            
       
            
        }

        private void lstbxDefinition_SelectedIndexChanged(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you happy with your choice?",
                      "Confirm Answer", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    

                    if (lstbxClues.SelectedItem!=null)
                    {
                        if (newDictionary.ContainsKey((string)lstbxClues.SelectedItem))
                        {
                            newDictionary.Remove((string)lstbxClues.SelectedItem);
                        }
                        newDictionary.Add((string)lstbxClues.SelectedItem, (string)lstbxDefinition.SelectedItem);
                        lstbxClues.Items.RemoveAt(lstbxClues.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("You did not Select a Level 1 Call Number!","ATTENTION",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lstbxClues.Enabled = true;
                        lstbxDefinition.Enabled = false;
                    }

                
                    break;
                case DialogResult.No:
                    break;
            }
            /*
   * The above code was taken from c# corner:
   * URL: https://www.c-sharpcorner.com/uploadfile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
   * Author: Mahesh Chand
   * */




            lstbxClues.Enabled = true;
            lstbxDefinition.Enabled = false;
        }

        private void lstbxClues_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose the appropriate definition");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int points = 0;

            //Compare new Dictionary keys and values with corresponding original Dictionary key and values
            foreach(string value in newDictionary.Values)
            {
                foreach(string oValue in number_descriptions.Values)
                {
                    if (value == oValue)
                    {
                        //if corresponding key values are the same in both dictionaries then award 1 point.
                       
                        foreach(string key in newDictionary.Keys)
                        {
                            foreach(string oKey in number_descriptions.Keys)
                            {
                                if(value == oValue && (key == oKey))
                                {
                                    points = points + 1;
                                }
                            }
                        }


                        
                    }
                }
            }


            //Calculate Score
            //Display Score 
            MessageBox.Show("Final Score: " + points.ToString());
            //If Score greater than average then trophy displayed

            double average;

            average = (points / newDictionary.Count) * 100;

            if (average >= 70)
            {
                MessageBox.Show("CONGRATULATIONS!!! YOUR AVERAGE IS ABOVE 70! YOU RECEIVE A TROPHY!", "WINNER WINNER", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                imgTrophy.Visible = true;
            }
            else
            {
                MessageBox.Show("UNLUCKY!!! YOUR AVERAGE IS BELOW 70! YOU DO NOT RECEIVE A TROPHY! Better luck next time!" , "LOSE",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }

            
            

        }
    }
}
