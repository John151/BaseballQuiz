using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfQuestions = trkNumberQuestions.Value;
        }

        private void trkNumberQuestions_Scroll(object sender, EventArgs e)
        {
            trkNumberQuestions.Minimum = 5;
            trkNumberQuestions.Maximum = 20;
            lblNumberQuestionsDisplay.Text = Convert.ToString(trkNumberQuestions.Value);
        }
    }

    //public class QuizQuestion
    //{
    //    public string question;
    //    public string correctAnswer;
    //    public List<string> wrongAnswerPool;

    //    public bool insane;
    //    public Random random;
    //    public int firstAvailableButton;
    //    public int lastAvailableButton;

    //    public void populateForm()
    //    {
    //        lblMainText.text = question;
    //    }
    //}
}
