using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace mqtt1
{
    public partial class Form1 : Form
    {

        string IP_ADDR = "192.168.1.85";

        public Form1()
        {
            InitializeComponent();
        }

        private void startMqtt_button_Click(object sender, EventArgs e)
        {
            Boolean dir_up = true;
            int counter = 0;

            
            while (true)
            {
                publish_to_mqtt(counter.ToString());
                if (dir_up == true)
                    counter += 1;
                else
                    counter -= 1;

                if (counter==10)
                {
                    dir_up = false;
                }
                if (counter==0)
                {
                    dir_up = true;
                }
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            



        }

        private void MQtt_button2_Click(object sender, EventArgs e)
        {
            /*
            string MQTT_BROKER_ADDRESS = "192.168.1.85";
            MqttClient client = new MqttClient(IPAddress.Parse(MQTT_BROKER_ADDRESS));

           string clientId = Guid.NewGuid().ToString();
           client.Connect(clientId);

            //string strValue = Convert.ToString(value);
            */
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publish_to_mqtt(string _in_str)
        {
            MqttClient client = new MqttClient(IP_ADDR);
            //byte code = client.Connect(Guid.NewGuid().ToString());
            byte code = client.Connect(new Guid().ToString(), null, null, true, 10);
            ushort msgId = client.Publish("test", Encoding.UTF8.GetBytes(_in_str), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);

            /*
            byte code = client.Connect(Guid.NewGuid().ToString(), null, null,
                false, // will retain flag
                MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // will QoS
                true, // will flag
                "/test", // will topic
                "will_message", // will message
                true,60); 
                */

            Console.WriteLine("Code is: " + code.ToString());
            Console.WriteLine("Guid is: " + Guid.NewGuid().ToString());

            /*
            ushort msgId = client.Publish("test", // topic
                              Encoding.UTF8.GetBytes("MyMessageBody"), // message body
                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                              false); // retained
            */

            Console.WriteLine("msgId is: " + msgId.ToString());
            Thread.Sleep(1000);

            client.Disconnect();
            client = null;
        }


    }
}
