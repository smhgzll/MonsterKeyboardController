using MonsterNotebook.ControlCenter.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MonsterNotebook.ControlCenter
{
    public class MQTTDatsService
    {
        public delegate void MQTTDatsServiceDataHandler(object topic, object data);

        public delegate void ClientConnectionHandler(bool connection);

        private static readonly MQTTDatsService service = new MQTTDatsService();

        private Dictionary<string, byte> TopicList = new Dictionary<string, byte>();

        private MqttClient client;

        private string clientId;

        private string username;

        private string password;

        public static MQTTDatsService GetInstance()
        {
            return service;
        }

        public event MQTTDatsServiceDataHandler DataChange;

        private MQTTDatsService()
        {
            InitlizeTopics();
            Task task = Task.Run(delegate
            {
                ClientConnection();
            });
            task.GetAwaiter().OnCompleted(delegate
            {
                Task task2 = new Task(CheckConnection);
                task2.Start();
            });
        }

        public string GetClientId()
        {
            return clientId;
        }

        private void InitlizeTopics()
        {
            byte value = 0;
            TopicList.Add("System/CpuInfo", value);
            TopicList.Add("System/MemoryInfo", value);
            TopicList.Add("System/GpuInfo", value);
            TopicList.Add("System/NetworkInfo", value);
            TopicList.Add("System/BatteryInfo", value);
            TopicList.Add("System/DiskInfo", value);
            TopicList.Add("System/StaticsData", value);
            TopicList.Add("Setting/Status", value);
            TopicList.Add("Fan/Status", value);
            TopicList.Add("MyRgbLightbar/Status", value);
            TopicList.Add("MyRgbLightbar/Type", value);
            TopicList.Add("Keyboard/Status", value);
            TopicList.Add("Keyboard/Ctrl", value);
            TopicList.Add("Customize/Info", value);
            TopicList.Add("Languages/Info", value);
        }

        public List<string> GetMQTT_Topics(string viewName)
        {
            return TopicList.Keys.Where((string n) => n.Contains(viewName)).ToList();
        }

        private async void ClientConnection()
        {
            try
            {
                int pocessCount = 3;
                string brokerHostName = "localhost";
                int brokerPort = 13688;
                clientId = "UWPClient_" + pocessCount;
                username = "UWPClient_User_" + pocessCount;
                password = "UWPClient_Pwd_" + pocessCount;
                string[] topic = TopicList.Keys.ToArray();
                byte[] qosLevels = TopicList.Values.ToArray();
                client = new MqttClient(brokerHostName, brokerPort, secure: false, null, null, MqttSslProtocols.None);
                client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                client.MqttMsgPublished += Client_MqttMsgPublished;
                client.ConnectionClosed += Client_ConnectionClosed;
                client.MqttMsgSubscribed += Client_MqttMsgSubscribed;
                client.MqttMsgUnsubscribed += Client_MqttMsgUnsubscribed;
                client.Connect(clientId, username, password, cleanSession: false, 1);
                client.Subscribe(topic, qosLevels);
            }
            catch (Exception ex)
            {
                Exception e = ex;
                if (e is AggregateException)
                {
                }
                Console.WriteLine("Connection Failed !");
            }
        }

        private async void CheckConnection()
        {
            while (true)
            {
                if (client != null && !client.IsConnected)
                {
                    ClientConnection();
                }
                await Task.Delay(TimeSpan.FromSeconds(5.0));
            }
        }

        public void Disconnect()
        {
            try
            {
                if (client.IsConnected)
                {
                    client.Disconnect();
                }
            }
            catch
            {
            }
        }

        private void Client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            Console.WriteLine("Published " + e.MessageId.ToString());
        }

        private void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            Console.WriteLine("SubScribed " + e.MessageId.ToString());
        }

        private void Client_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            Console.WriteLine("UnSubScribed " + e.MessageId.ToString());
        }

        private void Client_ConnectionClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Connecttion Closed !");
        }

        private async void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Message);
            dynamic data = await Json.ToObjectAsync<object>(message);
            DataChange?.Invoke(e.Topic, data);
        }
        public async void PublishTopic(string topic, object data)
        {
            string text = await Json.StringifyAsync(data);
            string msg = text;
            await Task.Run(delegate
            {
                try
                {
                    if (client.IsConnected)
                    {
                        client.Publish(topic, Encoding.ASCII.GetBytes(msg), 2, retain: true);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            });
        }
    }
}
