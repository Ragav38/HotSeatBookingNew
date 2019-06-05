using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Web.Security;
using HotSeatBooking.Models;

namespace HotSeatBooking.Views.Home
{
    public partial class BookingForm : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

            Button1.BackColor = SystemColors.Control;
            Button2.BackColor = SystemColors.Control;
            Button3.BackColor = SystemColors.Control;
            Button4.BackColor = SystemColors.Control;
            Button5.BackColor = SystemColors.Control;
            Button6.BackColor = SystemColors.Control;
            Button7.BackColor = SystemColors.Control;
            Button8.BackColor = SystemColors.Control;
            Button9.BackColor = SystemColors.Control;
            Button10.BackColor = SystemColors.Control;
            Button11.BackColor = SystemColors.Control;
            Button12.BackColor = SystemColors.Control;
            Button13.BackColor = SystemColors.Control;
            Button14.BackColor = SystemColors.Control;
            Button15.BackColor = SystemColors.Control;
            Button16.BackColor = SystemColors.Control;
            Button17.BackColor = SystemColors.Control;
            Button18.BackColor = SystemColors.Control;
            Button19.BackColor = SystemColors.Control;
            Button20.BackColor = SystemColors.Control;
            Button21.BackColor = SystemColors.Control;
            Button22.BackColor = SystemColors.Control;
            Button23.BackColor = SystemColors.Control;
            Button24.BackColor = SystemColors.Control;
            Button25.BackColor = SystemColors.Control;
            Button26.BackColor = SystemColors.Control;
            Button27.BackColor = SystemColors.Control;
            Button28.BackColor = SystemColors.Control;
            Button29.BackColor = SystemColors.Control;
            Button30.BackColor = SystemColors.Control;
            Button31.BackColor = SystemColors.Control;
            Button32.BackColor = SystemColors.Control;
            Button33.BackColor = SystemColors.Control;
            Button34.BackColor = SystemColors.Control;
            Button35.BackColor = SystemColors.Control;
            Button36.BackColor = SystemColors.Control;
            Button37.BackColor = SystemColors.Control;
            Button38.BackColor = SystemColors.Control;
            Button39.BackColor = SystemColors.Control;
            Button40.BackColor = SystemColors.Control;
            Button41.BackColor = SystemColors.Control;
            Button42.BackColor = SystemColors.Control;
            Button43.BackColor = SystemColors.Control;
            Button44.BackColor = SystemColors.Control;
            Button45.BackColor = SystemColors.Control;
            Button46.BackColor = SystemColors.Control;
            Button47.BackColor = SystemColors.Control;
            Button48.BackColor = SystemColors.Control;
            Button49.BackColor = SystemColors.Control;
            Button50.BackColor = SystemColors.Control;

            ManageLoginsViewModel login = new ManageLoginsViewModel();

            //HttpContext.Current.Response.Write(Session["UserName"]);

            DataSet ds = new DataSet();
            SqlConnection sc = new SqlConnection("Data Source = dp200.database.windows.net; Initial Catalog = DP200; User ID = raga; Password = Super*38; Integrated Security = False");
            sc.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 1", sc);

            if (cmd1.ExecuteScalar() != null)
            {
                Button1.BackColor = Color.Red;
                Button1.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd2 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 2", sc);

            if (cmd2.ExecuteScalar() != null)
            {
                Button2.BackColor = Color.Red;
                Button2.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd3 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 3", sc);

            if (cmd3.ExecuteScalar() != null)
            {
                Button3.BackColor = Color.Red;
                Button3.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd4 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 4", sc);

            if (cmd4.ExecuteScalar() != null)
            {
                Button4.BackColor = Color.Red;
                Button4.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd5 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 5", sc);

            if (cmd5.ExecuteScalar() != null)
            {
                Button5.BackColor = Color.Red;
                Button5.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd6 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 6", sc);

            if (cmd6.ExecuteScalar() != null)
            {
                Button6.BackColor = Color.Red;
                Button6.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd7 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 7", sc);

            if (cmd7.ExecuteScalar() != null)
            {
                Button7.BackColor = Color.Red;
                Button7.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd8 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 8", sc);

            if (cmd8.ExecuteScalar() != null)
            {
                Button8.BackColor = Color.Red;
                Button8.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd9 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 9", sc);

            if (cmd9.ExecuteScalar() != null)
            {
                Button9.BackColor = Color.Red;
                Button9.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd10 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 10", sc);

            if (cmd10.ExecuteScalar() != null)
            {
                Button10.BackColor = Color.Red;
                Button10.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd11 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 11", sc);

            if (cmd11.ExecuteScalar() != null)
            {
                Button11.BackColor = Color.Red;
                Button11.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd12 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 12", sc);

            if (cmd12.ExecuteScalar() != null)
            {
                Button12.BackColor = Color.Red;
                Button12.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd13 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 13", sc);

            if (cmd13.ExecuteScalar() != null)
            {
                Button13.BackColor = Color.Red;
                Button13.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd14 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 14", sc);

            if (cmd14.ExecuteScalar() != null)
            {
                Button14.BackColor = Color.Red;
                Button14.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd15 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 15", sc);

            if (cmd15.ExecuteScalar() != null)
            {
                Button15.BackColor = Color.Red;
                Button15.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd16 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 16", sc);

            if (cmd16.ExecuteScalar() != null)
            {
                Button16.BackColor = Color.Red;
                Button16.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd17 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 17", sc);

            if (cmd17.ExecuteScalar() != null)
            {
                Button17.BackColor = Color.Red;
                Button17.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd18 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 18", sc);

            if (cmd18.ExecuteScalar() != null)
            {
                Button18.BackColor = Color.Red;
                Button18.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd19 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 19", sc);

            if (cmd19.ExecuteScalar() != null)
            {
                Button19.BackColor = Color.Red;
                Button19.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd20 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 20", sc);

            if (cmd20.ExecuteScalar() != null)
            {
                Button20.BackColor = Color.Red;
                Button20.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd21 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 21", sc);

            if (cmd21.ExecuteScalar() != null)
            {
                Button21.BackColor = Color.Red;
                Button21.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd22 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 22", sc);

            if (cmd22.ExecuteScalar() != null)
            {
                Button22.BackColor = Color.Red;
                Button22.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd23 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 23", sc);

            if (cmd23.ExecuteScalar() != null)
            {
                Button23.BackColor = Color.Red;
                Button23.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd24 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 24", sc);

            if (cmd24.ExecuteScalar() != null)
            {
                Button24.BackColor = Color.Red;
                Button24.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd25 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 25", sc);

            if (cmd25.ExecuteScalar() != null)
            {
                Button25.BackColor = Color.Red;
                Button25.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd26 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 26", sc);

            if (cmd26.ExecuteScalar() != null)
            {
                Button26.BackColor = Color.Red;
                Button26.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd27 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 27", sc);

            if (cmd27.ExecuteScalar() != null)
            {
                Button27.BackColor = Color.Red;
                Button27.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd28 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 28", sc);

            if (cmd28.ExecuteScalar() != null)
            {
                Button28.BackColor = Color.Red;
                Button28.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd29 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 29", sc);

            if (cmd29.ExecuteScalar() != null)
            {
                Button29.BackColor = Color.Red;
                Button29.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd30 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 30", sc);

            if (cmd30.ExecuteScalar() != null)
            {
                Button30.BackColor = Color.Red;
                Button30.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd31 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 31", sc);

            if (cmd31.ExecuteScalar() != null)
            {
                Button31.BackColor = Color.Red;
                Button31.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd32 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 32", sc);

            if (cmd32.ExecuteScalar() != null)
            {
                Button32.BackColor = Color.Red;
                Button32.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd33 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 33", sc);

            if (cmd33.ExecuteScalar() != null)
            {
                Button33.BackColor = Color.Red;
                Button33.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd34 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 34", sc);

            if (cmd34.ExecuteScalar() != null)
            {
                Button34.BackColor = Color.Red;
                Button34.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd35 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 35", sc);

            if (cmd35.ExecuteScalar() != null)
            {
                Button35.BackColor = Color.Red;
                Button35.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd36 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 36", sc);

            if (cmd36.ExecuteScalar() != null)
            {
                Button36.BackColor = Color.Red;
                Button36.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd37 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 37", sc);

            if (cmd37.ExecuteScalar() != null)
            {
                Button37.BackColor = Color.Red;
                Button37.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd38 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 38", sc);

            if (cmd38.ExecuteScalar() != null)
            {
                Button38.BackColor = Color.Red;
                Button38.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd39 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 39", sc);

            if (cmd39.ExecuteScalar() != null)
            {
                Button39.BackColor = Color.Red;
                Button39.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd40 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 40", sc);

            if (cmd2.ExecuteScalar() != null)
            {
                Button40.BackColor = Color.Red;
                Button40.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd41 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 41", sc);

            if (cmd41.ExecuteScalar() != null)
            {
                Button41.BackColor = Color.Red;
                Button41.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd42 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 42", sc);

            if (cmd42.ExecuteScalar() != null)
            {
                Button42.BackColor = Color.Red;
                Button42.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd43 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 43", sc);

            if (cmd2.ExecuteScalar() != null)
            {
                Button43.BackColor = Color.Red;
                Button43.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd44 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 44", sc);

            if (cmd44.ExecuteScalar() != null)
            {
                Button44.BackColor = Color.Red;
                Button44.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd45 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 45", sc);

            if (cmd45.ExecuteScalar() != null)
            {
                Button45.BackColor = Color.Red;
                Button45.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd46 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 46", sc);

            if (cmd46.ExecuteScalar() != null)
            {
                Button46.BackColor = Color.Red;
                Button46.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd47 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 47", sc);

            if (cmd47.ExecuteScalar() != null)
            {
                Button47.BackColor = Color.Red;
                Button47.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd48 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 48", sc);

            if (cmd2.ExecuteScalar() != null)
            {
                Button48.BackColor = Color.Red;
                Button48.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd49 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 49", sc);

            if (cmd49.ExecuteScalar() != null)
            {
                Button49.BackColor = Color.Red;
                Button49.Enabled = false;
            }

            sc.Close();

            sc.Open();

            SqlCommand cmd50 = new SqlCommand("SELECT seat_id FROM tblBooking WHERE seat_id = 50", sc);

            if (cmd50.ExecuteScalar() != null)
            {
                Button50.BackColor = Color.Red;
                Button50.Enabled = false;
            }

            sc.Close();

        }

        private const string seat_id = "0";

        public void Button1_Click(object sender, EventArgs e)
        {

            if (Button1.BackColor == SystemColors.Control)
            {
                var a = "1";
                ViewState[seat_id] = a;
                Button1.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button1.BackColor = SystemColors.Control;
            }

        }

        public void Button2_Click(object sender, EventArgs e)
        {

            if (Button2.BackColor == SystemColors.Control)
            {
                var a = "2";
                ViewState[seat_id] = a;
                Button2.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button2.BackColor = SystemColors.Control;
            }

        }

        public void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.BackColor == SystemColors.Control)
            {
                var a = "3";
                ViewState[seat_id] = a;
                Button3.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button3.BackColor = SystemColors.Control;
            }

        }

        public void Button4_Click(object sender, EventArgs e)
        {
            if (Button1.BackColor == SystemColors.Control)
            {
                var a = "4";
                ViewState[seat_id] = a;
                Button4.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button4.BackColor = SystemColors.Control;
            }

        }

        public void Button5_Click(object sender, EventArgs e)
        {
            if (Button5.BackColor == SystemColors.Control)
            {
                var a = "5";
                ViewState[seat_id] = a;
                Button1.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button5.BackColor = SystemColors.Control;
            }

        }

        public void Button6_Click(object sender, EventArgs e)
        {
            if (Button6.BackColor == SystemColors.Control)
            {
                var a = "6";
                ViewState[seat_id] = a;
                Button6.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button6.BackColor = SystemColors.Control;
            }

        }

        public void Button7_Click(object sender, EventArgs e)
        {
            if (Button7.BackColor == SystemColors.Control)
            {
                var a = "7";
                ViewState[seat_id] = a;
                Button7.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button7.BackColor = SystemColors.Control;
            }

        }

        public void Button8_Click(object sender, EventArgs e)
        {
            if (Button8.BackColor == SystemColors.Control)
            {
                var a = "8";
                ViewState[seat_id] = a;
                Button1.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button8.BackColor = SystemColors.Control;
            }

        }

        public void Button9_Click(object sender, EventArgs e)
        {
            if (Button9.BackColor == SystemColors.Control)
            {
                var a = "9";
                ViewState[seat_id] = a;
                Button9.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button9.BackColor = SystemColors.Control;
            }

        }

        public void Button10_Click(object sender, EventArgs e)
        {
            if (Button10.BackColor == SystemColors.Control)
            {
                var a = "10";
                ViewState[seat_id] = a;
                Button10.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button10.BackColor = SystemColors.Control;
            }

        }

        public void Button11_Click(object sender, EventArgs e)
        {
            if (Button11.BackColor == SystemColors.Control)
            {
                var a = "11";
                ViewState[seat_id] = a;
                Button11.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button11.BackColor = SystemColors.Control;
            }

        }

        public void Button12_Click(object sender, EventArgs e)
        {
            if (Button12.BackColor == SystemColors.Control)
            {
                var a = "12";
                ViewState[seat_id] = a;
                Button12.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button12.BackColor = SystemColors.Control;
            }

        }

        public void Button13_Click(object sender, EventArgs e)
        {
            if (Button13.BackColor == SystemColors.Control)
            {
                var a = "13";
                ViewState[seat_id] = a;
                Button13.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button13.BackColor = SystemColors.Control;
            }

        }

        public void Button14_Click(object sender, EventArgs e)
        {
            if (Button14.BackColor == SystemColors.Control)
            {
                var a = "14";
                ViewState[seat_id] = a;
                Button14.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button14.BackColor = SystemColors.Control;
            }
        }

        public void Button15_Click(object sender, EventArgs e)
        {
            if (Button15.BackColor == SystemColors.Control)
            {
                var a = "15";
                ViewState[seat_id] = a;
                Button15.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button15.BackColor = SystemColors.Control;
            }
        }

        public void Button16_Click(object sender, EventArgs e)
        {
            if (Button16.BackColor == SystemColors.Control)
            {
                var a = "16";
                ViewState[seat_id] = a;
                Button16.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button16.BackColor = SystemColors.Control;
            }
        }

        public void Button17_Click(object sender, EventArgs e)
        {
            if (Button17.BackColor == SystemColors.Control)
            {
                var a = "17";
                ViewState[seat_id] = a;
                Button17.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button17.BackColor = SystemColors.Control;
            }
        }

        public void Button18_Click(object sender, EventArgs e)
        {
            if (Button18.BackColor == SystemColors.Control)
            {
                var a = "18";
                ViewState[seat_id] = a;
                Button18.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button18.BackColor = SystemColors.Control;
            }
        }

        public void Button19_Click(object sender, EventArgs e)
        {
            if (Button19.BackColor == SystemColors.Control)
            {
                var a = "19";
                ViewState[seat_id] = a;
                Button19.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button19.BackColor = SystemColors.Control;
            }
        }

        public void Button20_Click(object sender, EventArgs e)
        {
            if (Button20.BackColor == SystemColors.Control)
            {
                var a = "20";
                ViewState[seat_id] = a;
                Button20.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button20.BackColor = SystemColors.Control;
            }
        }

        public void Button21_Click(object sender, EventArgs e)
        {
            if (Button21.BackColor == SystemColors.Control)
            {
                var a = "21";
                ViewState[seat_id] = a;
                Button21.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button21.BackColor = SystemColors.Control;
            }
        }

        public void Button22_Click(object sender, EventArgs e)
        {
            if (Button22.BackColor == SystemColors.Control)
            {
                var a = "22";
                ViewState[seat_id] = a;
                Button22.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button22.BackColor = SystemColors.Control;
            }
        }

        public void Button23_Click(object sender, EventArgs e)
        {
            if (Button23.BackColor == SystemColors.Control)
            {
                var a = "23";
                ViewState[seat_id] = a;
                Button23.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button23.BackColor = SystemColors.Control;
            }
        }

        public void Button24_Click(object sender, EventArgs e)
        {
            if (Button24.BackColor == SystemColors.Control)
            {
                var a = "24";
                ViewState[seat_id] = a;
                Button24.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button24.BackColor = SystemColors.Control;
            }
        }

        public void Button25_Click(object sender, EventArgs e)
        {
            if (Button25.BackColor == SystemColors.Control)
            {
                var a = "25";
                ViewState[seat_id] = a;
                Button25.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button25.BackColor = SystemColors.Control;
            }
        }

        public void Button26_Click(object sender, EventArgs e)
        {
            if (Button26.BackColor == SystemColors.Control)
            {
                var a = "26";
                ViewState[seat_id] = a;
                Button26.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button26.BackColor = SystemColors.Control;
            }
        }

        public void Button27_Click(object sender, EventArgs e)
        {
            if (Button27.BackColor == SystemColors.Control)
            {
                var a = "27";
                ViewState[seat_id] = a;
                Button27.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button27.BackColor = SystemColors.Control;
            }
        }

        public void Button28_Click(object sender, EventArgs e)
        {
            if (Button28.BackColor == SystemColors.Control)
            {
                var a = "28";
                ViewState[seat_id] = a;
                Button28.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button28.BackColor = SystemColors.Control;
            }
        }

        public void Button29_Click(object sender, EventArgs e)
        {
            if (Button29.BackColor == SystemColors.Control)
            {
                var a = "29";
                ViewState[seat_id] = a;
                Button29.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button29.BackColor = SystemColors.Control;
            }
        }

        public void Button30_Click(object sender, EventArgs e)
        {
            if (Button30.BackColor == SystemColors.Control)
            {
                var a = "30";
                ViewState[seat_id] = a;
                Button1.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button30.BackColor = SystemColors.Control;
            }
        }

        public void Button31_Click(object sender, EventArgs e)
        {
            if (Button31.BackColor == SystemColors.Control)
            {
                var a = "31";
                ViewState[seat_id] = a;
                Button31.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button31.BackColor = SystemColors.Control;
            }
        }

        public void Button32_Click(object sender, EventArgs e)
        {
            if (Button32.BackColor == SystemColors.Control)
            {
                var a = "32";
                ViewState[seat_id] = a;
                Button32.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button32.BackColor = SystemColors.Control;
            }
        }

        public void Button33_Click(object sender, EventArgs e)
        {
            if (Button33.BackColor == SystemColors.Control)
            {
                var a = "33";
                ViewState[seat_id] = a;
                Button33.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button33.BackColor = SystemColors.Control;
            }
        }

        public void Button34_Click(object sender, EventArgs e)
        {
            if (Button34.BackColor == SystemColors.Control)
            {
                var a = "34";
                ViewState[seat_id] = a;
                Button34.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button34.BackColor = SystemColors.Control;
            }
        }

        public void Button35_Click(object sender, EventArgs e)
        {
            if (Button35.BackColor == SystemColors.Control)
            {
                var a = "35";
                ViewState[seat_id] = a;
                Button35.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button35.BackColor = SystemColors.Control;
            }
        }

        public void Button36_Click(object sender, EventArgs e)
        {
            if (Button36.BackColor == SystemColors.Control)
            {
                var a = "36";
                ViewState[seat_id] = a;
                Button36.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button36.BackColor = SystemColors.Control;
            }
        }

        public void Button37_Click(object sender, EventArgs e)
        {
            if (Button37.BackColor == SystemColors.Control)
            {
                var a = "37";
                ViewState[seat_id] = a;
                Button37.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button37.BackColor = SystemColors.Control;
            }
        }

        public void Button38_Click(object sender, EventArgs e)
        {
            if (Button38.BackColor == SystemColors.Control)
            {
                var a = "38";
                ViewState[seat_id] = a;
                Button38.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button38.BackColor = SystemColors.Control;
            }
        }

        public void Button39_Click(object sender, EventArgs e)
        {
            if (Button39.BackColor == SystemColors.Control)
            {
                var a = "39";
                ViewState[seat_id] = a;
                Button39.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button39.BackColor = SystemColors.Control;
            }
        }

        public void Button40_Click(object sender, EventArgs e)
        {
            if (Button40.BackColor == SystemColors.Control)
            {
                var a = "40";
                ViewState[seat_id] = a;
                Button40.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button40.BackColor = SystemColors.Control;
            }
        }

        public void Button41_Click(object sender, EventArgs e)
        {
            if (Button41.BackColor == SystemColors.Control)
            {
                var a = "41";
                ViewState[seat_id] = a;
                Button41.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button41.BackColor = SystemColors.Control;
            }
        }

        public void Button42_Click(object sender, EventArgs e)
        {
            if (Button42.BackColor == SystemColors.Control)
            {
                var a = "42";
                ViewState[seat_id] = a;
                Button42.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button42.BackColor = SystemColors.Control;
            }
        }

        public void Button43_Click(object sender, EventArgs e)
        {
            if (Button43.BackColor == SystemColors.Control)
            {
                var a = "43";
                ViewState[seat_id] = a;
                Button43.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button43.BackColor = SystemColors.Control;
            }
        }

        public void Button44_Click(object sender, EventArgs e)
        {
            if (Button44.BackColor == SystemColors.Control)
            {
                var a = "44";
                ViewState[seat_id] = a;
                Button44.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button44.BackColor = SystemColors.Control;
            }
        }

        public void Button45_Click(object sender, EventArgs e)
        {
            if (Button45.BackColor == SystemColors.Control)
            {
                var a = "45";
                ViewState[seat_id] = a;
                Button45.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button45.BackColor = SystemColors.Control;
            }
        }

        public void Button46_Click(object sender, EventArgs e)
        {
            if (Button46.BackColor == SystemColors.Control)
            {
                var a = "46";
                ViewState[seat_id] = a;
                Button46.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button46.BackColor = SystemColors.Control;
            }
        }

        public void Button47_Click(object sender, EventArgs e)
        {
            if (Button47.BackColor == SystemColors.Control)
            {
                var a = "47";
                ViewState[seat_id] = a;
                Button47.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button47.BackColor = SystemColors.Control;
            }
        }

        public void Button48_Click(object sender, EventArgs e)
        {
            if (Button48.BackColor == SystemColors.Control)
            {
                var a = "48";
                ViewState[seat_id] = a;
                Button48.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button48.BackColor = SystemColors.Control;
            }
        }

        public void Button49_Click(object sender, EventArgs e)
        {
            if (Button49.BackColor == SystemColors.Control)
            {
                var a = "49";
                ViewState[seat_id] = a;
                Button49.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button49.BackColor = SystemColors.Control;
            }
        }

        public void Button50_Click(object sender, EventArgs e)
        {
            if (Button1.BackColor == SystemColors.Control)
            {
                var a = "50";
                ViewState[seat_id] = a;
                Button50.BackColor = Color.DarkGreen;
            }
            else
            {
                var a = "0";
                ViewState[seat_id] = a;
                Button50.BackColor = SystemColors.Control;
            }
        }

        public void Button51_Click(object sender, EventArgs e)
        {
            if ((string)ViewState[seat_id] == "0" || DropDownList1.Text == "")
            {
                HttpContext.Current.Response.Write(ViewState[seat_id]);
                HttpContext.Current.Response.Write(DropDownList1.Text);
            }

            else
            {
                DataSet ds = new DataSet();
                SqlConnection sc = new SqlConnection("Data Source = dp200.database.windows.net; Initial Catalog = DP200; User ID = raga; Password = Super*38; Integrated Security = False");
                sc.Open();

                string sqlselect;
                string sqlinsert;

                sqlselect = "SELECT seat_id FROM tblBooking WHERE user_id = " + "'" + Session["UserName"] + "'";

                sqlinsert = "INSERT INTO tblBooking (seat_id, user_id, login_time) VALUES (" + "'" + ViewState[seat_id] + "'" + "," + "'" + Session["UserName"] + "'" + "," + "'" + DropDownList1.Text + "'" + ")";

                SqlCommand cmdx = new SqlCommand(sqlselect, sc);
                SqlCommand cmdi = new SqlCommand(sqlinsert, sc);

                if (cmdx.ExecuteScalar() != null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User already booked a seat for the day!')", true);
                    sc.Close();
                }
                else
                {
                    cmdi.ExecuteNonQuery();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Booking done successfully!')", true);
                    sc.Close();

                }

            }
        }
    }
}