using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Threading; 
class Worker
{
    public static void Main()
    {
        ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "task_queue", durable: true, exclusive: false, autoDelete: false, arguments: null);
            channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
            EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                String message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"[X] received {message}");

                int dots = message.Split('.').Length - 1;
                Thread.Sleep(dots*1000);

                Console.WriteLine("[X] Done");
                channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };
            channel.BasicConsume(queue: "task_queue", autoAck: false, consumer: consumer);
            Console.WriteLine("Press [ENTER] to exit.");
            Console.ReadLine();
        }
    }
}
