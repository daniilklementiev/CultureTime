using System;
using System.Globalization;
using System.IO;

namespace CultureTime
{
    public partial class Form1 : Form
    {
        DateTime dt;
       
        
        public Form1()
        {
            InitializeComponent();
            dt = DateTime.Now;
            // listBox1.Items.Add($"Tokyo: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Tokyo Standard Time")}"); 
            // listBox1.Items.Add($"New York: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Eastern Standard Time")}");
            // listBox1.Items.Add($"California: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Pacific Standard Time")}");
            // listBox1.Items.Add($"London: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "GMT Standard Time")}");
            // listBox1.Items.Add($"Kyiv: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "FLE Standard Time")}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // показать время в Токио
            CultureInfo tokyoCulture = new CultureInfo("ja-JP");
            DateTimeFormatInfo dtfi = tokyoCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"Tokyo: {dt.ToString("t", dtfi)}");
            // показать время в Нью-Йорке
            listBox1.Items.Add($"New York: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Eastern Standard Time")}");
            // показать время в Калифорнии
            listBox1.Items.Add($"California: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Pacific Standard Time")}");
            // показать время в Лондоне
            CultureInfo londonCulture = new CultureInfo("en-GB");
            dtfi = londonCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"London: {dt.ToString("t", dtfi)}");
            // показать время в Киеве 
            CultureInfo ukraineCulture = new CultureInfo("uk-UA");
            dtfi = ukraineCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"Kyiv: {dt.ToString("t", dtfi)}");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}