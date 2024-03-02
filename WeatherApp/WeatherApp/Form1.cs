using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

using static WeatherApp.Weatherinfo;
using System.Runtime.CompilerServices;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // string apiKey = "a11eb532899f0fb4d047de49e6b1ba8e";
        //string cityname = "Bengaluru";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            getWeatherAsync();
        }

       // void getWeather()
        //{
          //  using (WebClient web = new WebClient())
            //{
              //  string url= $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={apiKey}&units=metric";
                //var json=web.DownloadString(url);
                //WeatherInfo Info=JsonConvert.DeserializeObject<WeatherInfo>(json);
            //}
        //}
        async Task getWeatherAsync()
        {
            string apiKey = "a11eb532899f0fb4d047de49e6b1ba8e";
            string city = locationbox.Text;
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);
                DateTime cityTime = DateTime.UtcNow.AddSeconds(weatherInfo.timezone);
                image.ImageLocation = "https://openweathermap.org/img/w/" + weatherInfo.weather[0].icon + ".png";
                templabel.Text = (weatherInfo.main.temp).ToString()+" degrees";
                //time.Text = (DateTime.Now).ToString();
                time.Text= cityTime.ToString();
                cloud.Text = weatherInfo.weather[0].description;
                rain.Text = (weatherInfo.rain?.rain_1h ?? 0).ToString() + " mm";
                snow.Text = (weatherInfo.snow?.snow_1h ?? 0).ToString() + " mm";
                sunrise.Text= UnixTimeStampToDateTime(weatherInfo.sys.sunrise, weatherInfo.timezone).ToString("HH:mm")+" A.M";
                sunset.Text = UnixTimeStampToDateTime(weatherInfo.sys.sunset, weatherInfo.timezone).ToString("HH:mm") + " P.M";
                humidity.Text = (weatherInfo.main.humidity).ToString()+"%";
                //Console.WriteLine($"Date Time: {DateTime.Now}");
                //Console.WriteLine($"Temperature: {weatherInfo.main.temp}");
                //Console.WriteLine($"Humidity: {weatherInfo.main.humidity}");
                //Console.WriteLine($"Weather Main: {weatherInfo.weather[0].main}");
                //Console.WriteLine($"Weather Description: {weatherInfo.weather[0].description}");
                //Console.WriteLine($"Weather Icon: {weatherInfo.weather[0].icon}");
                //Console.WriteLine($"Sunrise: {UnixTimeStampToDateTime(weatherInfo.sys.sunrise)}");
                //Console.WriteLine($"Sunset: {UnixTimeStampToDateTime(weatherInfo.sys.sunset)}");
                //Console.WriteLine($"Rainfall: {weatherInfo.rain?.rain_1h ?? 0} mm"); // Rainfall in the last 1 hour, if available
                //Console.WriteLine($"Snowfall: {weatherInfo.snow?.snow_1h ?? 0} mm"); // Snowfall in the last 1 hour, if available
            }
            else
            {
                Console.WriteLine($"Failed to retrieve weather data. Status code: {response.StatusCode}");
            }
        }

        
    }
}
