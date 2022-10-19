using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace HelloWorld
{
    class Receive
    {
        public static void Main()
        {
            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
                EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    byte[] body = ea.Body.ToArray();
                    String message = Encoding.UTF8.GetString(body);
                    Console.WriteLine($"[X] received {message}");
                };
                channel.BasicConsume(queue: "hello", autoAck: true, consumer: consumer);
                Console.WriteLine("Press [ENTER] to exit.");
                Console.ReadLine();
            }
        }
    }
}
