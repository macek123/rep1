using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PEERTOPEERKOMUNIKACE
{
    public partial class Form1 : Form
    {
        private Socket komunikace;
        EndPoint cizibod;
        EndPoint lokalnibod;
        byte[] velikostdat;

        public Form1()
        {
            InitializeComponent();
            komunikace = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            komunikace.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

        }
        private void Zpracovani(IAsyncResult vysledek)
        {
            try
            {
                int velikostZpravy = komunikace.EndReceiveFrom(vysledek, ref cizibod);

                if (velikostZpravy > 0)
                {
                    velikostdat = (byte[])vysledek.AsyncState;
                    UTF8Encoding dekodovac = new UTF8Encoding();
                    string zprava = dekodovac.GetString(velikostdat);

                    Invoke(new Action(() =>
                    {
                        listBox1.Items.Add("Oponent:" + zprava);
                    }));

                    velikostdat = new byte[2500];
                    komunikace.BeginReceiveFrom(velikostdat, 0, velikostdat.Length, SocketFlags.None, ref cizibod, new AsyncCallback(Zpracovani), velikostdat);
                }
            }
            catch (Exception chyba)
            {
                MessageBox.Show(chyba.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            IPAddress adresa = IPAddress.Parse(textBoxMistniIP.Text);
            int mistniport = int.Parse(textBoxMistniPort.Text);
            lokalnibod = new IPEndPoint(adresa, mistniport);

            IPAddress ciziadresa = IPAddress.Parse(textBoxCiziIP.Text);
            int ciziport = int.Parse(textBoxCiziPort.Text);
            cizibod = new IPEndPoint(ciziadresa, ciziport);

            komunikace.Bind(lokalnibod);
            komunikace.Connect(cizibod);
            komunikace.BeginReceiveFrom(velikostdat, 0, velikostdat.Length, SocketFlags.None, ref cizibod, new AsyncCallback(Zpracovani), velikostdat);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UTF8Encoding kodovac = new UTF8Encoding();
            byte[] zprava = new byte[velikostdat.Length];

            zprava = kodovac.GetBytes(textBoxChat.Text);
            komunikace.Send(zprava);
            listBox1.Items.Add("Já:" + zprava);
            textBoxChat.Text = "";
        }
    }
}