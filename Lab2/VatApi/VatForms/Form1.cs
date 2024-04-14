using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using VatApi;

namespace VatForms
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private VatRepository repository;
        private ApiVatFetcher apiVatFetcher;
        private ViesApproximateDeseralizer viesApproximateDeseralizer;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            repository = new VatRepository();
            apiVatFetcher = new ApiVatFetcher();
            viesApproximateDeseralizer = new ViesApproximateDeseralizer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*repository.removeAllVats();*/
            repository.add(true, "123");
            repository.add(false, "456");
            repository.add(true, "789");
            List<VatDb> result = repository.searchVatsWhereConditionIsFulfilled(true);

            foreach (var student in result)
            {
                textBox1.Text += student.ToString();
            }


           /* string nip = textBox2.Text.ToString();
            string json =  apiVatFetcher.getDataFromGivenNip(nip);
            Vat vat = viesApproximateDeseralizer.deseralizeStudents(json);
            textBox1.Text = json.ToString();*/


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
