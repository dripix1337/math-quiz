using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_quiz
{
    enum e_action
    {
        action_sum,
        action_diff,
        action_product,
        action_quotient
    };
    struct example_t
    {
        public e_action action;

        public int first;
        public int second;

        public int result;
    };

    public partial class Form : System.Windows.Forms.Form
    {
        private Random random = new Random();

        private example_t eFirstExample;
        private example_t eSecondExample;
        private example_t eThirdExample;
        private example_t eFourthExample;

        private int iLeftTime = 0;
        private bool checkAnswers()
        {
            return (firstOut.Value == eFirstExample.result &&
                   secondOut.Value == eSecondExample.result &&
                   thirdOut.Value == eThirdExample.result &&
                   fourthOut.Value == eFourthExample.result);
        }

        public Form()
        {
            InitializeComponent();
        }

        private example_t generateExample(e_action type)
        {
            example_t ex = new example_t();
            ex.action = type;

            switch (type)
            {
                case e_action.action_sum:
                    {
                        ex.first = random.Next(51);
                        ex.second = random.Next(51);
                        ex.result = ex.first + ex.second;

                        break;
                    }
                case e_action.action_diff:
                    {
                        ex.first = random.Next(1, 101);
                        ex.second = random.Next(1, ex.first);
                        ex.result = ex.first - ex.second;

                        break;
                    }
                case e_action.action_product:
                    {
                        ex.first = random.Next(2, 11);
                        ex.second = random.Next(2, 11);
                        ex.result = ex.first * ex.second;

                        break;
                    }
                case e_action.action_quotient:
                    {
                        int tmpQuotinent = random.Next(2, 11);

                        ex.second = random.Next(2, 11);
                        ex.first = ex.second * tmpQuotinent;

                        ex.result = ex.first / ex.second;

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return ex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eFirstExample = generateExample(e_action.action_sum);
            eSecondExample = generateExample(e_action.action_diff);
            eThirdExample = generateExample(e_action.action_product);
            eFourthExample = generateExample(e_action.action_quotient);

            firstExample.Text = eFirstExample.first + " + " + eFirstExample.second + " = ";
            secondExample.Text = eSecondExample.first + " - " + eSecondExample.second + " = ";
            thirdExample.Text = eThirdExample.first + " * " + eThirdExample.second + " = ";
            fourthExample.Text = eFourthExample.first + " / " + eFourthExample.second + " = ";

            firstOut.Value = 0;
            secondOut.Value = 0;
            thirdOut.Value = 0;
            fourthOut.Value = 0;

            button1.Enabled = false;

            iLeftTime = 60;
            timer1.Start();

            timeLabel.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();

                MessageBox.Show("Все ответы верные!", "Поздравляю!");
                timeLabel.ForeColor = Color.Green;

                button1.Enabled = true;
            }
            else if (iLeftTime > 0)
            {
                iLeftTime--;
                timeLabel.Text = iLeftTime + " секунд(а)";

                if (iLeftTime < 5)
                    timeLabel.ForeColor = Color.Red;
            }
            else
            {
                timer1.Stop();

                MessageBox.Show("Время вышло!", "Вы не успели ответить на вопросы");
                button1.Enabled = true;
            }
        }
    }
}
