namespace System.Net.WebSockets;

public class WebSocketReceiveResult
{
	public int Count { get; private set; }

	public bool EndOfMessage { get; private set; }

	public WebSocketMessageType MessageType { get; private set; }

	public WebSocketCloseStatus? CloseStatus { get; private set; }

	public string CloseStatusDescription { get; private set; }

	public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage)
		: this(count, messageType, endOfMessage, null, null)
	{
	}

	public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeStatusDescription)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		Count = count;
		EndOfMessage = endOfMessage;
		MessageType = messageType;
		CloseStatus = closeStatus;
		CloseStatusDescription = closeStatusDescription;
	}

	internal WebSocketReceiveResult Copy(int count)
	{
		Count -= count;
		return new WebSocketReceiveResult(count, MessageType, Count == 0 && EndOfMessage, CloseStatus, CloseStatusDescription);
	}
}
