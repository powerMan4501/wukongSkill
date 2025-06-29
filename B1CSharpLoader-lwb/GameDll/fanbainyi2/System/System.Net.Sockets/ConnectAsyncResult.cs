namespace System.Net.Sockets;

internal class ConnectAsyncResult : ContextAwareResult
{
	private EndPoint m_EndPoint;

	internal EndPoint RemoteEndPoint => m_EndPoint;

	internal ConnectAsyncResult(object myObject, EndPoint endPoint, object myState, AsyncCallback myCallBack)
		: base(myObject, myState, myCallBack)
	{
		m_EndPoint = endPoint;
	}
}
