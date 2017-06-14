using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTDash
{
    public partial class Dashboard : Form
    {
        // MQTT Constants
        private const string MqttBroker = "146.185.157.205";
        private const string MqttUser = "debug";
        private const string MqttPass = "fhict";


        // Privates
        private List<Node> nodes;

        private static Dashboard _dash;

        public Dashboard()
        {
            InitializeComponent();

            // Setup MQTT
            // create client instance
            MqttClient client = new MqttClient(MqttBroker);


            // register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            try
            {
                client.Connect(clientId, MqttUser, MqttPass);
            }
            catch (Exception e)
            {
                MessageBox.Show("MQTT Connection broken, check your internet connection and restart.");
                this.Close();
            }

            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(new string[] { "DRINQ" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            _dash = this;
        }

        // Handel incomming messages
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                lbIncommingMQTT.Items.Add(Encoding.UTF8.GetString(e.Message));
                lbIncommingMQTT.SelectedIndex = lbIncommingMQTT.Items.Count - 1;
                ParseMQTT(Encoding.UTF8.GetString(e.Message));
            }));
        }

        private void ParseMQTT(string msg)
        {
            string[] splits = msg.Split(':');
            if (!Int32.TryParse(splits[0], out int identifierResult))
            {
                return;
            }
            foreach (var s in splits)
            {
                if (!Int32.TryParse(s, out int result) && ((NodeType)Int32.Parse(splits[0]) != NodeType.Mixer) && splits.Length < 2) return;
            }

            if ((NodeType)Int32.Parse(splits[0]) == NodeType.Breathalyzer && splits.Length > 2)
            {
                UpdateBAC(Int16.Parse(splits[1], System.Globalization.NumberStyles.HexNumber), Int16.Parse(splits[2]));
                
            }
            else if ((NodeType) Int32.Parse(splits[0]) == NodeType.CupChecker)
            {
                UpdateCup((splits[1] == "01\r"));
            }
            else if ((NodeType) Int32.Parse(splits[0]) == NodeType.Mixer)
            {

                int one = Int16.Parse(splits[3], System.Globalization.NumberStyles.HexNumber);
                int two = Int16.Parse(splits[2], System.Globalization.NumberStyles.HexNumber);
                int ml = ((one << 8)&0xFF) | (two & 0xFF);
                UpdateMixer(Int16.Parse(splits[1], System.Globalization.NumberStyles.HexNumber), ml);
            }
            else if ((NodeType)Int32.Parse(splits[0]) == NodeType.Cooling)
            {
                UpdateTemp(Int16.Parse(splits[1], System.Globalization.NumberStyles.HexNumber));
            }
            else if ((NodeType)Int32.Parse(splits[0]) == NodeType.Ui)
            {
                UpdateUi(splits[3], splits[4]);
            }
        }

        void UpdateUi(string bottle1, string bottle2)
        {
            lblConcentration1.Text = Int32.Parse(bottle1, System.Globalization.NumberStyles.HexNumber).ToString();
            lblConcentration2.Text = Int32.Parse(bottle2, System.Globalization.NumberStyles.HexNumber).ToString();
            lblCupSize.Text = (Int32.Parse(bottle1, System.Globalization.NumberStyles.HexNumber) + Int32.Parse(bottle2, System.Globalization.NumberStyles.HexNumber)).ToString();

            // 10:00:01:32:32
            // id:bottle1:
        }

        private void UpdateBAC (int bac, int status)
        {
            lblBACLatest.Text = bac.ToString();
            lblBACStatus.Text = status.ToString();
        }

        private void UpdateCup(bool status)
        {
            if (status)
            {
                lblCupStatus.Text = "Cup is present";
                lblCupStatus.ForeColor = Color.Green;
                return;
            }

            lblCupStatus.Text = "Cup not present";
            lblCupStatus.ForeColor = Color.Red;
        }

        private void UpdateMixer(int status, int weight)
        {
            if (weight > 110)
            {
                lblMixerWarning.Visible = true;
                return;
            }

            lblMixerWarning.Visible = false;
            lblWeight.Text = weight.ToString();
            pbWeight.Value = weight;
            switch ((MixerStatus)status)
            {
                case MixerStatus.SendingWeight:
                    lblStatusMixer.ForeColor = Color.Green;
                    lblStatusMixer.Text = "Filling Cup";
                    break;

                case MixerStatus.Emptying:
                    lblStatusMixer.ForeColor = Color.Green;
                    lblStatusMixer.Text = "Emptying Cup";
                    break;
                    
                case MixerStatus.NoCup:
                    lblStatusMixer.ForeColor = Color.Orange;
                    lblStatusMixer.Text = "Waiting for cup";
                    break;

                case MixerStatus.Empty:
                    lblStatusMixer.ForeColor = Color.Green;
                    lblStatusMixer.Text = "Enjoy your drink";
                    break;


            }
        }

        private void UpdateTemp(int temp)
        {
            if (temp > 30)
            {
                lblTempWarning.Visible = true;
                pbTemp.Value = pbTemp.Maximum;
                pbTemp.ForeColor = Color.Red;
                return;
            }
            lblTempWarning.Visible = false;
            pbTemp.ForeColor = Color.Green;
            lblTemp.Text = temp.ToString();
            pbTemp.Value = temp;
        }
    }
}
