using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal dolar = 0;
        decimal euro = 0;
        decimal sterlin = 0;
        #region Dolar
        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
        {
        { "x-rapidapi-key", "0b227f1d86msh3c5c8c801e35090p16c0b2jsn8514ae77ce79" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lbldollar.Text = "1$ = " + value + "₺";
                dolar = decimal.Parse(value);
                
            }

            #endregion
            #region Euro

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
        {
        { "x-rapidapi-key", "0b227f1d86msh3c5c8c801e35090p16c0b2jsn8514ae77ce79" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
        },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text = "1€ = " + value2 + "₺";
                //Console.WriteLine(body);
                euro = decimal.Parse(value2);
            }

            #endregion

            #region Sterlin


            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
        {
        { "x-rapidapi-key", "0b227f1d86msh3c5c8c801e35090p16c0b2jsn8514ae77ce79" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
        },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblSterlin.Text = "1£ = " + value3 + "₺";
                sterlin = decimal.Parse(value3);
                //Console.WriteLine(body);
            }

            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtBirimFiyat.Text);

            decimal totalprice = 0;

            if (rddolar.Checked)
            {
                totalprice = unitPrice * dolar;
                txtTutar.Text = totalprice.ToString();
            }
            if (rdeuro.Checked)
            {
                totalprice = unitPrice * euro;
                txtTutar.Text = totalprice.ToString();
            }
            if (rdsterlin.Checked)
            {
                totalprice = unitPrice * sterlin;
                txtTutar.Text = totalprice.ToString();
            }
        }
    }
}
