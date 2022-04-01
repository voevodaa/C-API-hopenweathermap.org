using System.Web;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Runtime;

namespace APIOpenWeatherMap
{
    public partial class Form1 : Form
    {
        public double min = 100;
        public double max = 100;
        public int tempNight;
        public int longDay;

        public Form1()
        {
            InitializeComponent();
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://api.openweathermap.org/data/2.5/onecall?lat=52.73167&lon=41.433891&exclude=current,minutely,hourly,alerts&appid=0f4b8cc18a16a5ffd9bfa912bc7d8130&lang=ru&units=metric";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resultResponse = streamReader.ReadToEnd();
                Root Daily = JsonConvert.DeserializeObject<Root>(resultResponse);
                for (int i = 0; i < 8; i++)
                {
                    double resultTemp = Daily.daily[i].temp.night - Daily.daily[i].feels_like.night;
                    if (resultTemp < min )
                    {
                        min = resultTemp;
                        tempNight = i;
                    }
                }
                tempReal.Text = Convert.ToString(Daily.daily[tempNight].temp.night);
                tempFeelLike.Text = Convert.ToString(Daily.daily[tempNight].feels_like.night);
                minTemp.Text = Convert.ToString(min);
                whenDay.Text = Convert.ToString(UnixTimeToDateTime(Daily.daily[tempNight].dt));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var url = "https://api.openweathermap.org/data/2.5/onecall?lat=52.73167&lon=41.433891&exclude=current,minutely,hourly,alerts&appid=0f4b8cc18a16a5ffd9bfa912bc7d8130&lang=ru&units=metric";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resultResponse = streamReader.ReadToEnd();
                Root Daily = JsonConvert.DeserializeObject<Root>(resultResponse);
                for (int i = 0; i < 5; i++)
                {
                    double resultMaxLongDay = Daily.daily[i].sunset - Daily.daily[i].sunrise;
                    if (resultMaxLongDay > max)
                    {
                        max = resultMaxLongDay;
                        longDay = i;
                    }
                }
                LongSolsticeDay.Text = Convert.ToString(UnixTimeToDateTime(Daily.daily[longDay].dt));
                double resultDayInHours = max / 60 / 60;
                double resultDayInMinutes = max % 60;
                dayLengthHours.Text = Convert.ToString(Math.Floor(resultDayInHours));
                dayLengthMinutes.Text = Convert.ToString(resultDayInMinutes);
            }
        }
    }
}