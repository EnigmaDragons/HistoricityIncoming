namespace HistoricityIncoming.Messages
{
    public class Message
    {
        public string Name { get; }
        public string Content { get; }
        public Side Side { get; }

        public Message(string name, string content, Side side)
        {
            Name = name;
            Content = content;
            Side = side;
        }
    }
}
