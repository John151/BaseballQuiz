using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballQuiz
{
    public partial class Form1 : Form
    {
        public string[][] answerbank =
            //questions and trivia from http://www.baseballroundtable.com/top-99-trivia-answers/
            //https://www.buzzfeed.com/summeranne/35-odd-baseball-facts-that-are-too-strange-to-be-made-up

            //question is in position 0
            //correct answer in position 1
            //some text about the correct answer is in position 2
            //the rest are wrong answers
            {
        new string [] { "Who is the only pitcher to lead both the NL and AL in shutouts – in the same season?",
               "C.C Sabathia",
               "C.C Sabathia, who started the 2008 season with the AL Indians and went 6-8, with a 3.83 ERA and 2 shutouts (which tied with 7 others for the AL lead) and, in July, was traded to the NL Brewers and went 11-2 with a 1.65 ERA and 3 shutouts (which tied teammate Ben Sheets for the NL lead.)",
               "Bob Meusel", "John Reilly", "George Burns", "Jacob deGrom", "Gerrit Cole", "Max Scherzer", "Justin Verlander"},
           new string [] { "What was the original name of the NY Yankees franchise?",
               "Baltimore Orioles",
               "The Yankees started out as the Baltimore Orioles (1901), moving to NY (1903) to become the Highlanders and later the Yankees.",
               "NY Highlanders", "Brooklyn Dodgers", "Bronx Bombers", "Cincinnati Red Stockings", "Hartford Dark Blues", "Mutual of New York", "New York Athletics"},
           new string [] { "Who is the only player to hit a major league home run and score an NFL touchdown in the same week?",
               "Deion Sanders",
               "Deion Sanders, who on September 5, 1989, hit a home run for the NY Yankees and followed up on September 9 with a 68-yard touchdown return for the Atlanta Falcons.  Sanders’ MLB career covered the years 1989-1995, 1997, 2001; his NFL career included the 1989-2000 and 2004 seasons.",
               "Ross Verba", "Chad Hutchinson", "Bo Jackson", "Drew Henson", "Russell Wilson", "Jordan Henson", "Matt Kinzer"},
           new string [] { "What major league pitcher racked up the most career wins without ever winning the Cy Young Award? ",
               "Cy Young",
               "Cy Young, with 511 career victories.",
               "Roger Clemens", "Randy Johnson", "Bob Gibson", "Justin Verlander", "Blake Snell", "Corey Kluber", "Rick Porcello"},
           new string [] { "Which pitcher holds the MLB record for the most strikeouts in a single game?",
               "Tom Cheney",
               "Washington Senator Tom Cheney, who fanned 21 in a 16-inning, 2-1 win over the Orioles on September 12, 1962.",
               "Randy Johnson", "Roger Clemens", "Pedro Martinez", "Corey Kluber", "Max Scherzer", "Justin Verlander", "David Price"},
           new string [] { "With only 23 perfect games in MLB history, which year proved a boon, with three perfect games in the regular season?",
               "2012",
               "2012 perfect games pitched by Felix Hernandez (Mariners), Phil Humber (White Sox), Matt Cain (Giants).",
               "1977", "2004", "1962", "2015", "1987", "1999", "2005"},
           new string [] { "Retired numbers are pretty common these days, but they had to start somewhere.  Whose number was the first ever retired by a MLB team?",
               "Lou Gehrig, #4",
               "On July 4, 1939, the Yankees retired Lou “The Iron Horse” Gehrig’s number four.",
               "Babe Ruth, #3", "Joe DiMaggio, #5", "Bobby Doerr, #1", "LaMarr Hoyt #2", "Warren Spahn #6", "Whitey Ford #4", "Bob Turley #2"},
           new string [] { "Which future hall-of-fameer hit the same spectator, Alice Roth, with a foul ball twice!?",
               "Richie Ashburn",
               "August 17, 1957, centerfielder Richie Ashburn of the Philadelphia Phillies hit spectator Alice Roth with a foul ball, breaking her nose. As Roth was being carried off the field on a stretcher, Ashburn hit her with another foul ball, breaking a bone in her knee. The odds of a fan being hit by a baseball are 300,000 to one. The odds of the same fan being hit twice during the same at-bat, and breaking bones both times, are beyond astronomical.",
               "Minnie Minoso", "Bobby Shantz", "Ted Williams", "Mickey Mantle", "Tris Speaker", "Duke Snider", "Hugh Duffy"},
           new string [] { "The year was 1993 as fans watched Jose Canseco misjudge a fly ball, hit him in the head, and sail over the fence for a home run. Who was the batter that was given a free home run?",
               "Carlos Martinez",
               "He is affectionately nicknamed \"Little Pedro\" due to his similar pitching style to Pedro Martinez.",
               "Joe Carter", "John Kruk", "Greg Maddux", "Lenny Dykstra", "Frank Thomas", "John Olerud", "Barry Bonds"},
           new string [] { "Which player ran the bases facing backwards to celebrate his 100th home run?",
               "Jimmy Piersall",
               "When Jimmy Pearsall hit his 100th home run in 1963, he ran the bases in the correct order but facing backward to celebrate.",
               "Greg Maddux", "Lee Smith", "Doug Drabek", "Mark McGwire", "Aaron Judge", "Gary Sanchez", "Ryan Howard"},//10
           new string [] { "Which MLB pitcher had a 10 season career despite being born without a right hand?",
                "Jim Abbott",
                "Pitcher Jim Abbott was born without a right hand and had a 10-season baseball career, including throwing a no-hitter for the New York Yankees vs. Cleveland in 1993.",
                "Jimmy Key", "Jeff Montgomery", "Rube Waddell", " Eddie Gaedel", "Joe Nuxhall", "Petwe Wyshner", "Peter J. Gray"},
           new string [] { "The shortest MLB Player Ever was Eddie Gaedel. How tall was he?",
                "3 feet 7 in",
                "The three foot seven inch, 65 pound batter for the St. Louis Browns is the sports all-time smallest player by a land-slide. On August 19, 1951, Gaedel appeared at the plate as a publicity stint.",
                "4 feet 5 in", "4 feet 10 in", "3 feet 11 in", "4 feet even", "4 feet 9 in", "5 feet 1 in", "5 feet 3 in"},
           new string [] { "Whose 1985 Topps baseball card didn't have his picture on the front, but had a picture of his brother printed instead by mistake?",
                "Gary Pettis",
                "Don't ask Gary Pettis to sign it though. \"A lot of people try to get me to sign it, but I know where it's going to end up. They're going to try to sell it. I don't ever bother with that one.\"",
                "Joe Mauer", "Ken Griffey Jr", "Rube Waddell", "Thurman Munson", "Mike Torrez", "Nolan Ryan", "Greg Maddux"},
           new string [] { "In the same week in the 2011 season, two different American League teams in the same division, each threw a no-hitter just four days apart. Which teams were they?",
                "Twins - Tigers",
                "In the entire 2010 season, the American League threw two no-hitters while the National League threw four.",
                "Diamondbacks - Rockies", "Cubs - Astros", "Rays - Yankees", "Blue Jays - Red Socks", "Diamondbacks - Astros", "Cubs - Yankees", "Twins - Brewers"},
           new string [] { "in 1963 Los Angeles Dodgers pitcher Sandy Koufax and New York Yankees catcher Elston Howard each won their respective league’s Most Valuable Player Award trophies that year. Both players wore what number?",
                "32",
                "The NFL’s Most Valuable Player Award winner that year, Jim Brown, also wore the number 32.",
                "42", "17", "84", "49", "55", "47", "17"},
           new string [] { "In the National League in the 1890s many seasons had 12 teams. Which team was boycotted by the other 11 teams, who refused to play games in that team's home ballpark?",
                "Cleveland Spiders",
                "The Spiders barely drew over 3000 fans total in their first 16 home games. The other teams refused to play at Cleveland's League Park because there was not enough ticket sales to pay the visiting teams. The Spiders were forced to play over 100 games on the road.",
                "Pittsburgh Alleghenys", "New York Giants", "Brooklyn Bridegrooms", "Chicago Colts", "Boston Beaneaters", "Cincinnati Reds", "Louisville Colonels"},
           new string [] { "July 17, 1914, the New York Giants and Pittsburgh Pirates were engaged in a marathon 21-inning game. Giants outfielder Red Murray camped under a fly ball that would finally end the game, but something extrordinary happened:",
                "He was struck by lightning",
                "After making the catch, Murray was struck by a bolt of lightning which rendered him unconscious. (He apparently hung on to the ball.)",
                "A bird interfered with the ball", "He tripped on another player and the game continued", "A fan went streaking", "He had a heart attack", "A pack of dogs ran onto the field", "The umpire had a stroke", "He had a stroke"},
           new string [] { "Who is credited with the invention of the modern baseball bat. He was the first player to order a bat with a knob on the end of the handle.",
                "Babe Ruth",
                "Louisville Slugger produced the custom-made bat with which he hit a record 29 home runs in 1919. His previous season high had been 11.",
                "Wally Schang", "Ken Williams", "Ty Cobb", "Jack Fournier", "Lou Gehrig", "Al Simmons", "Goose Goslin"},
           new string [] { "Ken Griffey Sr. and Ken Griffey Jr. were the first father-son duo rostered as players on the same team in the same season. The second father-son combination rostered as players was found later on which team together?",
                "Baltimore Orioles",
                "The second pair was Tim Raines and Tim Raines Jr. The were both rostered on the Baltimore Orioles in the 2001 season.",
                "Minnesota Twins", "Milwaukee Brewers", "Atlanta Braves", "Minnesota Twins", "Pittsburgh Pirates", "Atlanta Braves", "Toronto Blue Jays"},
           new string [] { "Which pitcher famously threw a no-hitter while high on LSD?",
                "Dock Ellis",
                "Fourteen years after the game was played, Ellis opened up about how he played nearly every game under the influence of LSD, including the famous no-hitter.",
                "Tim Lincecum", "Al Hrabosky", "Nick Swisher", "Bill Lee", "Kevin Rhomberg", "Phenomenal Smith", "Turk Wendell"},
        };
        //establishing some variables
        int questionNumber = 0;
        int score;
        int numberOfQuestions;//how many questions in the quiz?
        bool insane;
        List<int> saneQuestionID = new List<int>{1, 3, 4, 5};
        List<int> insaneQuestionID = new List<int> {1, 3, 4, 5, 6, 7, 8, 9};
        List<int> questionID;

        public Form1()
        {
            InitializeComponent();
            invisiblizeButtons();
            lblResults.Visible = false;
            btnExit.Visible = false;

        }

        private void invisiblizeButtons()
        {
            btn1.Visible = false;
            btn6.Visible = false;
            btn3.Visible = false;
            btn8.Visible = false;
            btn5.Visible = false;
            btn2.Visible = false;
            btn7.Visible = false;
            btn4.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfQuestions = trkNumberQuestions.Value; //how many questions will be asked
                                                              //these next instructions dissappear the starting controls
                btnStart.Visible = false;
                trkNumberQuestions.Visible = false;
                insane = chkInsane.Checked;
                chkInsane.Visible = false;
                lblNumberQuestions.Visible = false;
                lblNumberQuestionsDisplay.Visible = false;

                //sets progress bar maximum, indicates that the first question is asked
                progressBar1.Maximum = numberOfQuestions;
                progressBar1.Value = 1;

                //randomizes questions
                Random rnd = new Random();

                for (int i = answerbank.Length - 1; i >= 1; i--)
                {
                    int j = rnd.Next(0, i + 1);

                    if (i != j)
                    {   //I call this a dosi-do, I'm sure it has a real name but I don't know it
                        string[] shuffledQuestion = answerbank[i];
                        answerbank[i] = answerbank[j];
                        answerbank[j] = shuffledQuestion;
                        //string test = answerbank[i][0] + " " + answerbank[j][0];
                        //MessageBox.Show(test, "test");
                    }
                }

                //these next instructions make visible the controls we'll need
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;

                if (insane)
                {
                    btn5.Visible = true;
                    btn6.Visible = true;
                    btn7.Visible = true;
                    btn8.Visible = true;
                }
                //todo fill buttons with possible answers

                askQuestion(questionNumber);//asks the first question 
            }
            catch (Exception ex)
            {
                //live exception for user
                MessageBox.Show("I'm sorry, something has gone wrong. We are looking in the error", "Error");
                //exception for developer
                //MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }   
        private void trkNumberQuestions_Scroll(object sender, EventArgs e)
        {
            trkNumberQuestions.Minimum = 5;
            trkNumberQuestions.Maximum = 20;
            lblNumberQuestionsDisplay.Text = Convert.ToString(trkNumberQuestions.Value);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            lblMainText.Text = answerbank[questionNumber][2]; //displays info about answer
            string correctAnswer = answerbank[questionNumber][1]; //created variable to store correct answer
            var button = (Button)sender; //determines which button called the function, sets it to a variable
            string selectedAnswer = Convert.ToString(button.Text); //gets the text information from call button's properties


            if (selectedAnswer == correctAnswer)
            {
                button.BackColor = Color.Lime;
                score++;
                MessageBox.Show($"{selectedAnswer} is Correct!", correctAnswer);

            }
            else
            {
                button.BackColor = Color.Red;

                if (btn1.Text == correctAnswer)
                { btn1.BackColor = Color.Lime; }
                else if (btn2.Text == correctAnswer)
                { btn2.BackColor = Color.Lime; }
                else if (btn3.Text == correctAnswer)
                { btn3.BackColor = Color.Lime; }
                else if (btn4.Text == correctAnswer)
                { btn4.BackColor = Color.Lime; }
                else if (btn5.Text == correctAnswer)
                { btn5.BackColor = Color.Lime; }
                else if (btn6.Text == correctAnswer)
                { btn6.BackColor = Color.Lime; }
                else if (btn7.Text == correctAnswer)
                { btn7.BackColor = Color.Lime; }
                else if (btn8.Text == correctAnswer)
                { btn8.BackColor = Color.Lime; }
                else
                {
                    MessageBox.Show("Error in assigning colors to buttons", "err");
                };
                MessageBox.Show("Incorrect", correctAnswer);
            }

            checkIfLastRoundOrGoAgain();

        }

        private void checkIfLastRoundOrGoAgain()
        {
            if ((questionNumber + 1 == numberOfQuestions))
            {
                lblMainText.Text = "";
                string evaluation = "";
                int battingAverage = 1000 * score / numberOfQuestions;
                if (battingAverage > 500)
                    evaluation += "That's amazing!";
                else if (battingAverage > 260)
                    evaluation += "That's pretty good!";
                else evaluation += "Keep at it!";
                invisiblizeButtons();
                lblResults.Visible = true;
                btnExit.Visible = true;
                lblResults.Text = $"You got {score} correct\nOut of {numberOfQuestions}\n" +
                    $"That's a {battingAverage} batting average\n" +
                    $"{evaluation}";
            }
            else
            {
                questionNumber++;
                askQuestion(questionNumber);
            }
        }

        private void askQuestion(int questionNumber)
        {
            //answerbank[number][0] is the question
            //answerbank[number][1] is the correct answer
            //answerbank[number][2] is txt about the answer
            //answerbank[number][3+] is the incorrect answer

            returnButtonsDefaultColor();

            lblMainText.Text = answerbank[questionNumber][0];

            Random rnd = new Random();

            if (insane)
            { questionID = insaneQuestionID; }
            else
            { questionID = saneQuestionID; }

            for (int i = questionID.Count - 1; i >= 0; i--)
            {
                int j = rnd.Next(0, i + 1);

                if (i != j)
                {   //dosi-do
                    int shuffledIndex = questionID[i];
                    questionID[i] = questionID[j];
                    questionID[j] = shuffledIndex;
                }
            }
            //int count = 0;
            //foreach (int n in questionID)
            //{
            //    count++;
            //    Console.WriteLine($"Element #{count}: {n}"); 
            //}

            btn1.Text = answerbank[questionNumber][questionID[0]];
            btn2.Text = answerbank[questionNumber][questionID[1]];
            btn3.Text = answerbank[questionNumber][questionID[2]];
            btn4.Text = answerbank[questionNumber][questionID[3]];

            if (insane)
            {
                btn5.Text = answerbank[questionNumber][questionID[4]];
                btn6.Text = answerbank[questionNumber][questionID[5]];
                btn7.Text = answerbank[questionNumber][questionID[6]];
                btn8.Text = answerbank[questionNumber][questionID[7]];
            }

            if (questionNumber == 0)
            {
                return;
            }
            else if ((questionNumber + 1) != numberOfQuestions) //check to make sure we're not increasing beyond the number of questions on the final round
            {
                progressBar1.Value++;
                return;
            }
            else
            {
                progressBar1.Value++;
                MessageBox.Show("Last Question!\nGood Luck!", "Exciting announcment");
            }
            //this check exists because I'm getting a weird "out of index error" even though I'm not calling for things out of index
            //string check = answerbank[questionNumber][1] + "\n"
            //    + answerbank[questionNumber][2] + "\n"
            //+
            //answerbank[questionNumber][3] + "\n"
            //    + answerbank[questionNumber][4];
            //MessageBox.Show(check);
            return;
        }

        private void returnButtonsDefaultColor()
        {
            btn1.BackColor = default(Color);
            btn2.BackColor = default(Color);
            btn3.BackColor = default(Color);
            btn4.BackColor = default(Color);
            btn5.BackColor = default(Color);
            btn6.BackColor = default(Color);
            btn7.BackColor = default(Color);
            btn8.BackColor = default(Color);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
