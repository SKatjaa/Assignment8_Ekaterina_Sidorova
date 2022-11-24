using System.Diagnostics;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boyNames = new string[100];
            int index = 0;

            StreamReader inputFile;
            inputFile = File.OpenText("BoyNames.txt");
            while (index < boyNames.Length && !inputFile.EndOfStream)
            {
                boyNames[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();

            string[] girlNames = new string[100];
            int index2 = 0;

            StreamReader inputFile2;
            inputFile2 = File.OpenText("GirlNames.txt");
            while (index2 < girlNames.Length && !inputFile2.EndOfStream)
            {
                girlNames[index2] = inputFile2.ReadLine();
                index2++;
            }
            inputFile2.Close();


            string userGirl, userBoy;
            userGirl = textBox1.Text;
            userBoy = textBox2.Text;

            string isGirl, isBoy;
            isBoy = "";
            isGirl = "";


            foreach (string girl in girlNames)
            {
                if (girl.ToLower() == userGirl.ToLower())
                {
                    isGirl = "yes";
                    break;
                }
                else
                {
                    isGirl = "no";
                }
            }

            foreach (string boy in boyNames)
            {
                if (boy.ToLower() == userBoy.ToLower())
                {
                    isBoy = "yes";
                    break;
                }
                else
                {
                    isBoy = "no";
                }
            }


            if (userGirl == "" && userBoy == "")
            {
                label4.Text = "You did not enter any names!";
            }
            else if (userGirl == "" && isBoy == "yes")
            {
                label4.Text = userBoy + " is in top 100 boys' names!";
            }
            else if (userGirl == "" && isBoy == "no")
            {
                label4.Text = userBoy + " is not in top 100 boys' names!";
            }

            else if (isGirl == "yes" && userBoy == "")
            {
                label4.Text = userGirl + " is in top 100 girls' names!";
            }
            else if (isGirl == "yes" && isBoy == "yes")
            {
                label4.Text = userGirl + " and  " + userBoy + " are in top 100 names!";
            }
            else if (isGirl == "yes" && isBoy == "no")
            {
                label4.Text = userGirl + "is in top 100 girls' names! But " + userBoy + " is not in top 100 boys' names!";
            }

            else if (isGirl == "no" && userBoy == "")
            {
                label4.Text = userGirl + " is not in top 100 girls' names!";
            }
            else if (isGirl == "no" && isBoy == "yes")
            {
                label4.Text = userBoy + "is in top 100 girls' names! But " + userGirl + " is not in top 100 boys' names!";
            }
            else if (isGirl == "no" && isBoy == "no")
            {
                label4.Text = userGirl + " and  " + userBoy + " are not in top 100 names!";
            }
            

            //label4.Text = boyNames[0] + girlNames[0];
            label4.Visible = true;
        }
    }
}