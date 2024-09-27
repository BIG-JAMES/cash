using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace cash
{
    public partial class calculator : Form
    {

        double mousePrice = 7.69;
        int numOfmouse = 0;
        double consolePrice = 600;
        int numOfconsole = 0;
        double computerPrice = 470;
        int numOfcomputer = 0;
        int tendPay = 0;

        double Mu = 0;
        double com = 0;
        double con = 0;

        double taxRate = 0.13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double endpayment = 0;

        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void computer_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tendPay = Convert.ToInt32(textBox4.Text);

                endpayment = tendPay - totalPrice;

                label14.Text = $"change: {endpayment.ToString("C")}";
            }
            catch
            {
                label14.Text = $"change: error";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Cash_Register__Kaching____Sound_Effect__HD_);
                player.Play();

                numOfmouse = Convert.ToInt32(textBox1.Text);
                numOfconsole = Convert.ToInt32(textBox2.Text);
                numOfcomputer = Convert.ToInt32(textBox3.Text);

                Mu = numOfmouse * mousePrice;
                com = numOfconsole * consolePrice;
                con = numOfcomputer * computerPrice;

                subtotal = Mu + com + con;
                taxAmount = taxRate * subtotal;
                totalPrice = taxAmount + subtotal;

                label11.Text = $"{subtotal.ToString("C")}";
                label13.Text = $"{taxAmount.ToString("C")}";
                label12.Text = $"{totalPrice.ToString("C")}";

            }
            catch
            {
                label11.Text = $"error";
                label13.Text = $"error";
                label12.Text = $"error";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void backg_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.printer_106935);
            player.Play();

            backg.Text = $"\n                                                  EB Games";

            Refresh();
            Thread.Sleep(400);

            backg.Text += $"\n                                             374 Rinehart Road";

            Refresh();
            Thread.Sleep(400);

            backg.Text += $"\n.............................................................................................................";

            backg.Text += $"\n    ";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\nmouse X{numOfmouse}      {Mu.ToString("C")}";

            Refresh();
            Thread.Sleep(400);

            backg.Text += $"\nconsole X{numOfconsole}    {con.ToString("C")}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\ncomputer X{numOfcomputer}  {com.ToString("C")}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n----------------------------------------------------------------";

            backg.Text += $"\n    ";

            Refresh();
            Thread.Sleep(400);

            backg.Text += $"\n(before tax)  price:      {subtotal}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n                       tax:      {taxAmount}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n(after tax)  totalprice:  {totalPrice}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n\npayed with: {tendPay}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\nchange back: {totalPrice}";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n.............................................................................................................";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\n\ndigital items, cards, and products that are unsafe for return. Devices are also non-returnable more than 30 days after delivery.";

            Refresh();
            Thread.Sleep(600);

            backg.Text += $"\n\n⬛⬛ ||⬛| |⬛⬛|⬛⬛⬛⬛ |⬛| ||||||||⬛⬛⬛ ⬛⬛ ⬛| ⬛⬛||| ⬛⬛⬛ ";
            backg.Text += $"\n⬛⬛ ||⬛| |⬛⬛|⬛⬛⬛⬛ |⬛| ||||||||⬛⬛⬛ ⬛⬛ ⬛| ⬛⬛||| ⬛⬛⬛ ";
            backg.Text += $"\n⬛⬛ ||⬛| |⬛⬛|⬛⬛⬛⬛ |⬛| ||||||||⬛⬛⬛ ⬛⬛ ⬛| ⬛⬛||| ⬛⬛⬛ ";

            Refresh();
            Thread.Sleep(300);

            backg.Text += $"\nscan to enter half off with all your purchases";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
