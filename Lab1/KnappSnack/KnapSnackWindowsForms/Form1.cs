using KnappSnack;
using System.Windows.Forms;

namespace KnapSnackWindowsForms
{
    public partial class Form1 : Form
    {
        private int amountOfItems = 0;
        private int seed1 = 0;
        private int capacityOfKnapSnack = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.amountOfItems = int.Parse(numberOfItems.Text);
            this.seed1 = int.Parse(seed.Text);
            this.capacityOfKnapSnack = int.Parse(capacity.Text);

            Problem problem = new Problem(amountOfItems, seed1);

            Result result = problem.solveKnappSnackProblem(capacityOfKnapSnack);

            string itemsString = "";
            for (int i = 0; i < result.result.Count; i++)
            {
                itemsString += result.result[i].id.ToString() + " ";
            }


            for (int i = 0; i < result.result.Count; i++)
            {
                instance.Items.Add(result.result[i]);
            }

            results.Items.Add("items: " + itemsString);
            results.Items.Add("totalValue: " + result.totalValue);
            results.Items.Add("totalWeigth: " + result.totalWeight);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberOfItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
