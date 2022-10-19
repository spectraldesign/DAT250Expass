using RabbitMQ.Client;
using System.Text;

class Send
{
    public static void Main()
    {
        ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
            String message = "Hello World!";
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: messageBytes);
            Console.WriteLine($"[X] Sent {message}");
        }
        Console.WriteLine("Press [ENTER] to exit");
        Console.ReadLine();
    }
}