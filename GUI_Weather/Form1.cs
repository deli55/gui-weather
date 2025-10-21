using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnFetchWeather_Click(object sender, EventArgs e)
        {
            string apiKey = txtApiKey.Text.Trim();

            if (string.IsNullOrEmpty(apiKey))
            {
                Log("❌ Please enter your OpenWeatherMap API key first.");
                return;
            }

            await FetchWeatherAsync(apiKey);
        }

        private async Task FetchWeatherAsync(string apiKey)
        {
            string city = "Belgrade"; // default city
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Log($"Fetching weather for {city}...");
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Log("Success!");
                        Log(json);
                    }
                    else
                    {
                        Log($"API request failed: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log($"Error: {ex.Message}");
            }
        }

        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
