using RabbitMQ.Client;
using System.Text;
class NewTask
{
    public static void Main(string[] args)
    {
        ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "task_queue", durable: true, exclusive: false, autoDelete: false, arguments: null);
            String message = getMessage(args);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            IBasicProperties properties = channel.CreateBasicProperties();
            properties.Persistent = true;
            channel.BasicPublish(exchange: "", routingKey: "task_queue", basicProperties: null, body: messageBytes);
            Console.WriteLine($"[X] Sent {message}");
        }
        Console.WriteLine("Press [ENTER] to exit");
        Console.ReadLine();
    }
    private static string getMessage(string[] args)
    {
        return ((args.Length > 0) ? string.Join(" ", args) : "Hello World!");
    }
}