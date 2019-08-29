using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccumulateTescScores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> scores = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateScore(txtScore.Text))
            {
                int Score = Convert.ToInt32(txtScore.Text);
                scores.Add(Score);
                int total = AddToTotal(Score);
                int count = UpdateCount();
                UpdateAverage(total, count);
            }
            txtScore.Clear();
        }

        private void UpdateAverage(int total, int count)
        {
            double average = total / count;
            txtAverage.Text = average.ToString();
        }

        private int UpdateCount()
        {
            txtCount.Text = scores.Count.ToString();
            return scores.Count;
        }

        private int AddToTotal(int score)
        {
            int Total = Convert.ToInt32(txtTotal.Text);
            Total += score;   
            txtTotal.Text = Total.ToString();
            return Total;
        }

        private bool ValidateScore(string score)
        {
            if (score.Trim() != "")
            {
                int scoreValue = 0;
                try
                {
                    scoreValue = Convert.ToInt32(score);
                }
                catch (Exception)
                {
                    MessageBox.Show("Score must be a number.");
                    return false;
                }
                if (scoreValue >= 0 && scoreValue <= 100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Scores must be from 0 to 100");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("A value must be entered before adding to the list");
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            txtTotal.Text = 0.ToString();
            txtCount.Text = 0.ToString();
            txtAverage.Text = 0.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            scores.Sort();
            string s = String.Join("\n", scores);
            MessageBox.Show(s, "Sorted Scores");
        }
    }
}
