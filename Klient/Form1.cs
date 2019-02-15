using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Klient
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        
        //TcpListener lyssnare;
        int port = 12345;
        TcpListener lyssnare = new TcpListener(IPAddress.Any, 12345);


        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
            tbxIp.Text = "127.0.0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
        }
        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIp.Text);
                await klient.ConnectAsync(adress, port);
                
                lbxLogger.Items.Add("Starta anslutning med adressen: " + adress.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show("Klient_Starta anslutning: " + error.Message, Text);
                return;
            }
            btnAnslut.Enabled = false;
            
            //lyssnare.Start();
            //StartaMottagning();
            StartaLäsning(klient);
        }
        public async void StartaSändning(string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);

            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
                lbxLogger.Items.Add("Starta sänding");
            }
            catch (Exception error)
            {
                MessageBox.Show("Klient_Starta sändning: " + error.Message, Text);
                return;
            }
            StartaLäsning(klient);
        }
        public async void StartaLäsning(TcpClient k)
        {
            byte[] buffert = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
                lbxLogger.Items.Add("Starta läsning, n: " + n.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show("Klient_Starta läsning :"+ error.Message, Text);
                return;
            }
            string result = Encoding.Unicode.GetString(buffert, 0, n);
            lbxChat.Items.Add(result);
            //StartaMottagning();
            StartaLäsning(klient);
        }
        public async void StartaMottagning()
        {
            try
            {
                lyssnare.Start();
                klient = await lyssnare.AcceptTcpClientAsync();
                lbxLogger.Items.Add("Starta mottagning med: " + klient.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show("Klient_Starta mottagning: "+error.Message, Text);
                return;
            }
            StartaLäsning(klient);
            StartaMottagning();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            string skicka = tbxSkicka.Text;
            StartaSändning(skicka);
        }
    }
}
