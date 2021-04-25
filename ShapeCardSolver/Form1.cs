using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCardSolver
{
    public partial class ShapeCardSolver : Form
    {
        int counter = 1;
        BindingList<Card> cards = new BindingList<Card>();
        public ShapeCardSolver()
        {
            InitializeComponent();
            CardList.DataSource = cards;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card c = new Card(counter);
            counter++;
            
            RadioButton shape = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            switch(shape.Tag)
            {
                case "1":c.shape = 1; break;
                case "2":c.shape = 2; break;
                case "3":c.shape = 3; break;
            }
            RadioButton colour = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            switch (colour.Tag)
            {
                case "1": c.colour = 1; break;
                case "2": c.colour = 2; break;
                case "3": c.colour = 3; break;
            }
            RadioButton fill = groupBox3.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            switch (fill.Tag)
            {
                case "1": c.fill = 1; break;
                case "2": c.fill = 2; break;
                case "3": c.fill = 3; break;
            }
            RadioButton amount = groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            switch (amount.Tag)
            {
                case "1": c.amount = 1; break;
                case "2": c.amount = 2; break;
                case "3": c.amount = 3; break;
            }

            cards.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> solutions = new List<string>();
            for (int i = 0; i < cards.Count; i++)
            {
                Card a = cards[i];
                for (int j = i + 1; j < cards.Count; j++)
                {
                    Card b = cards[j];
                    for (int h = j + 1; h < cards.Count; h++)
                    {
                        Card c = cards[h];
                        if (Checkresults(a, b, c))
                            solutions.Add("match found: " + a.position + "," + b.position + "," + c.position);
                    }
                }
            }
            if (solutions.Count == 0)
                solutions.Add("no matches found");
            solutionsfield.DataSource = solutions;
        }

        static bool Checkresults(Card a, Card b, Card c)
        {
            if ((a.colour + b.colour + c.colour) % 3 != 0)
                return false;
            if ((a.shape + b.shape + c.shape) % 3 != 0)
                return false;
            if ((a.fill + b.fill + c.fill) % 3 != 0)
                return false;
            if ((a.amount + b.amount + c.amount) % 3 != 0)
                return false;
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cards = new BindingList<Card>();
            CardList.DataSource = cards;
            solutionsfield.DataSource = null;
            counter = 1;
        }
    }
}
