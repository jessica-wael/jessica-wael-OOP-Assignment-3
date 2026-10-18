namespace RefactoringLab;

public interface IChannel
{
    string Name { get; }
}

public class EmailChannel : IChannel
{
    public string Name => "email";
}

public class SmsChannel : IChannel
{
    public string Name => "sms";
}

public class Notification
{
    private readonly IChannel _channel;
    private readonly bool _urgent;
    private readonly DateTime? _sendAt;

    public Notification(IChannel channel, bool urgent = false, DateTime? sendAt = null)
    {
        _channel = channel;
        _urgent = urgent;
        _sendAt = sendAt;
    }

    public void Send(string to, string message)
    {
        if (_urgent)
            message = $"[URGENT] {message}";

        if (_sendAt.HasValue)
            Console.WriteLine($"[{_channel.Name} scheduled {_sendAt.Value:g}] {to}: {message}");
        else
            Console.WriteLine($"[{_channel.Name}] {to}: {message}");
    }
}