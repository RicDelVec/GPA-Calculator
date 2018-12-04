using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Input Grades
            int COMP1030 = 0;
            bool is1030 = Int32.TryParse(txtComp1030.Text, out COMP1030);
            int GNED2030 = 0;
            bool is2030 = Int32.TryParse(txtGned2030.Text, out GNED2030);
            int COMP1102 = 0;
            bool is1102 = Int32.TryParse(txtComp1102.Text, out COMP1102);
            int COMP1002 = 0;
            bool is1002 = Int32.TryParse(txtComp1002.Text, out COMP1002);
            int COMM1016 = 0;
            bool is1016 = Int32.TryParse(txtComm1016.Text, out COMM1016);
            int COMP1051 = 0;
            bool is1051 = Int32.TryParse(txtComp1051.Text, out COMP1051);

            //Input Array
            int[] grades = { COMP1030, GNED2030, COMP1102, COMP1002, COMM1016, COMP1051 };

            //Grades Validation
            if (grades[0] > 0 && grades[1] > 0 && grades[2] > 0 && grades[3] > 0 && grades[4] > 0 && grades[5] > 0)            
            {
                int sum = 0;
                for (int i = 0; i < grades.Length; i++)
                    {
                        sum += grades[i];
                    }

                //Calculating Average
                double average = sum / 6;

                //Display Sum
                lblOutputGrade.Text = "Your Global Average is: " + average;

                //Decision Letter Grade COMP1030
                if (COMP1030 >= 80)
                    lblOutput1030.Text = "A";
                else if (COMP1030 >= 70)
                    lblOutput1030.Text = "B";
                else if (COMP1030 >= 60)
                    lblOutput1030.Text = "C";
                else if (COMP1030 >= 50)
                    lblOutput1030.Text = "D";
                else
                    lblOutput1030.Text = "F";

                //Decision Letter Grade GNED2030
                if (GNED2030 >= 80)
                    lblOutput2030.Text = "A";
                else if (GNED2030 >= 70)
                    lblOutput2030.Text = "B";
                else if (GNED2030 >= 60)
                    lblOutput2030.Text = "C";
                else if (GNED2030 >= 50)
                    lblOutput2030.Text = "D";
                else
                    lblOutput2030.Text = "F";

                //Decision Letter Grade COMP1102
                if (COMP1102 >= 80)
                    lblOutput1102.Text = "A";
                else if (COMP1102 >= 70)
                    lblOutput1102.Text = "B";
                else if (COMP1102 >= 60)
                    lblOutput1102.Text = "C";
                else if (COMP1102 >= 50)
                    lblOutput1102.Text = "D";
                else
                    lblOutput1102.Text = "F";

                //Decision Letter Grade COMP1002
                if (COMP1002 >= 80)
                    lblOutput1002.Text = "A";
                else if (COMP1002 >= 70)
                    lblOutput1002.Text = "B";
                else if (COMP1002 >= 60)
                    lblOutput1002.Text = "C";
                else if (COMP1002 >= 50)
                    lblOutput1002.Text = "D";
                else
                    lblOutput1002.Text = "F";

                //Decision Letter Grade COMM1016
                if (COMM1016 >= 80)
                    lblOutput1016.Text = "A";
                else if (COMM1016 >= 70)
                    lblOutput1016.Text = "B";
                else if (COMM1016 >= 60)
                    lblOutput1016.Text = "C";
                else if (COMM1016 >= 50)
                    lblOutput1016.Text = "D";
                else
                    lblOutput1016.Text = "F";

                //Decision Letter Grade COMP1051
                if (COMP1051 >= 80)
                    lblOutput1051.Text = "A";
                else if (COMP1051 >= 70)
                    lblOutput1051.Text = "B";
                else if (COMP1051 >= 60)
                    lblOutput1051.Text = "C";
                else if (COMP1051 >= 50)
                    lblOutput1051.Text = "D";
                else
                    lblOutput1051.Text = "F";

                //Decision Letter Grade average
                if (average >= 80)
                    lblOutputLetter.Text = "A";
                else if (average >= 70)
                    lblOutputLetter.Text = "B";
                else if (average >= 60)
                    lblOutputLetter.Text = "C";
                else if (average >= 50)
                    lblOutputLetter.Text = "D";
                else
                    lblOutputLetter.Text = "F";
            }
            else
            {
                Error();
            }
        }

        private void Error()
        {
            MessageBox.Show("Invalid entry. Try again.");
        }
    }
}
