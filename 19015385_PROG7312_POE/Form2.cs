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
    public partial class frmReplacingBooks : Form
    {
        private String[] callNumbers = new String[10];
        private String[] randomNumbers = new String[10];
        private String[] randomLetters = new String[10];

        private String[] sortedCallNumbers = new string[10];

        private String[] userSorted = new string[10];
        public frmReplacingBooks()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome f1 = new frmHome();
            f1.Show();
        }

        public void setCallNumbers()
        {
            Random rand = new Random();

            //The following code was taken from 
            //Microsoft
            //URL: https://forums.asp.net/t/1704723.aspx?HOW+TO+GENERATE+RANDOM+DECIMAL+NUMBERS+IN+C+
            //Author: ROHIT SOOD

            //generate random numbers 
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                string randomNum = string.Format("{0:000.###}", rand.NextDouble() * 1000);

                randomNumbers[i] = randomNum;


                //Generate Random Alphabets 
                var alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var stringChars = new char[3];

                for (int j = 0; j < stringChars.Length; j++)

                {
                    stringChars[j] = alphabets[rand.Next(alphabets.Length)];
                }

                var sfinal = new String(stringChars);
                randomLetters[i] = sfinal;

            }

            //set final call Number
            for (int i = 0; i < callNumbers.Length; i++)
            {
                string callNumber = randomNumbers[i] + randomLetters[i];
                callNumbers[i] = callNumber;
                sortedCallNumbers[i] = callNumbers[i];

            }

            //The following code was taken from 
            //Microsoft 
            //URL: https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0
            //Author: Microsoft Co-operation

            //Sort Call Numbers 
            Array.Sort(sortedCallNumbers, StringComparer.Ordinal);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            for (int i = 0; i < callNumbers.Length; i++)
            {
                lstbxCallNumbers.Items.Add(callNumbers[i]);
            }
        }

        private void NewRandomButton_Click(object sender, EventArgs e)
        {
            imgTrophy.Visible = false;
            lstbxCallNumbers.Items.Clear();
            setCallNumbers();
            Display();
        }

        //The Following code was taken from:
        //Stack Overflow 
        //URL: https://stackoverflow.com/questions/16591975/c-sharp-drag-and-drop-from-listbox
        //Author: B L

        private void lstbxCallNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            lstbxCallNumbers.DoDragDrop(lstbxCallNumbers.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }


        //Drag Drop From List Box to Listbox----------------------------------------------------
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
                private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            lstBoxUserSort.Items.Add (e.Data.GetData(DataFormats.Text).ToString());
            lstbxCallNumbers.SelectedItem = "";
        }
        //-----------------------------------------------------------------------------------------------------


        
        public void getFromList()
        {
            for (int i = 0; i < userSorted.Length; i++)
            {
                userSorted[i] = (string)lstBoxUserSort.Items[i];
            }
        }

        public Boolean isSorted()
        {

            //The following code was taken from 
            //Stack Overflow
            //URL: https://stackoverflow.com/questions/4423318/how-to-compare-arrays-in-c
            //Author: AMing

            bool isEqual = Enumerable.SequenceEqual(sortedCallNumbers, userSorted);

            if (!isEqual)
            {
                return false;
            }

            return true;
        }

           private void btnSubmit_Click(object sender, EventArgs e)
        {
            getFromList();

            if (isSorted() == true)
            {
                MessageBox.Show("CONGRATULATIONS!!! YOU WIN A TROPHY");
                imgTrophy.Visible = true;

            }
            else
            {
                MessageBox.Show("Call Numbers Sorted. Incorrectly. Try Again? ");
            }
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<<<WELCOME TO DEWY LIBRARIAN>>>");
            MessageBox.Show("Begin by clicking the GENERATE CALL NUMBERS button");
            MessageBox.Show("Rearrange the Call Numbers in Ascending Order by dragging and dropping into the empty List Box");
            MessageBox.Show("Once All Call Numbers have been sorted, Click the Submit Button");
            MessageBox.Show("Earn Trophies for sorting Call Numbers Correctly");
        }
    }
}
