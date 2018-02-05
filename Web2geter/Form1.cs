using System;
using System.Windows.Forms;

namespace Web2geter
{
	public partial class form_Main : Form
	{
		GetHotelInfo hotelInfo = new GetHotelInfo();

		public form_Main()
		{
			InitializeComponent();
		}

		public void button1_Click(object sender, EventArgs e)
		{
			Price1.Text = hotelInfo.AgodaGetPrice(tb_html1.Text);
			day1.Text = hotelInfo.GetDay();
			Name1.Text = hotelInfo.HotelName(tb_html1.Text);
		}

		private void Del1_Click(object sender, EventArgs e)
		{
			Price1.Text = "";
			day1.Text = "";
		}

		private void URL_Clear_Click(object sender, EventArgs e)
		{
			tb_html1.Text = "";
		}

		private void Save1_Click(object sender, EventArgs e)
		{
			hotelInfo.CsvFileSave(day1.Text);
		}
	}
}