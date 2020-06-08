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
        int global_counter = 0;
        string MQTT_TOPIC = "test";

        public Form1()
        {
            InitializeComponent();
        }

        private void startMqtt_button_Click(object sender, EventArgs e)
        {

            MqttClient client = new MqttClient(IP_ADDR);

            byte code = client.Connect(new Guid().ToString(), null, null, true, 10);
            if (code == 0)
            {
                Console.WriteLine("port numbr      : " + client.Settings.Port.ToString());
                Console.WriteLine("ClientID        : " + client.ClientId.ToString());
                Console.WriteLine("Is connected?   : " + client.IsConnected.ToString());
                Console.WriteLine("Protocol version: " + client.ProtocolVersion.ToString());                
            }
            else
            {
                Console.WriteLine("Failed to connect with  " + code.ToString());
                Console.WriteLine("Code is: " + code.ToString());
                return;
            }



            // try to subscribe
            // from https://m2mqtt.wordpress.com/using-mqttclient/
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //string[] topic = { "sensor/temp", "sensor/humidity" }; // list of topins to subscribe to
            string[] topic = { "test" }; // list of topins to subscribe to
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
            client.Subscribe(topic, qosLevels);





            Boolean dir_up = true;
            int counter = 0;
           
            for (int i=0; i<1000; i++)
            {
                ushort msgId = client.Publish(MQTT_TOPIC, Encoding.UTF8.GetBytes(counter.ToString()), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
                Console.WriteLine("msgId is: " + msgId.ToString());
                Thread.Sleep(1000);

                mqtt_msg_box.Text = counter.ToString();
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

                global_counter += 1;

                mqtt_msg_cnt_box.Text = global_counter.ToString();
                Application.DoEvents();
                Thread.Sleep(1000);
            }

            Console.WriteLine("Finished. Numbe of iterations:  " + global_counter.ToString());





            client.Unsubscribe(topic);
            client.Disconnect();
            client = null;

        }

        private void MQtt_button2_Click(object sender, EventArgs e)
        {

            MqttClient client = new MqttClient(IP_ADDR);
            byte code = client.Connect(new Guid().ToString(), null, null, true, 10);
            client.Subscribe(new string[] { MQTT_TOPIC }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            Console.WriteLine("port numbr: " + client.Settings.Port.ToString());

            /*
            var topicObservable = client.Observe<String, AsciiPayloadConverter>("Nmqtt_quickstart_topic",
                                                                                MqttQos.AtLeastOnce);
            topicObservable.Subscribe(
                msg => Console.WriteLine(String.Format("Msg Received on '{0}' is '{1}'", msg.Topic, msg.Payload)));
            topicObservable.Subscribe(
                msg => Console.WriteLine(String.Format("Second Msg Received on '{0}' is '{1}'", msg.Topic, msg.Payload)));
            Console.ReadKey();
            */
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publish_to_mqtt(string _in_str)
        {
            
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("message recieved: " + e.Message);

            // access data bytes throug e.Message
        }

    }
}
