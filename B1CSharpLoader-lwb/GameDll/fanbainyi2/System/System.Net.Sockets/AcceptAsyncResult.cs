namespace System.Net.Sockets;

internal class AcceptAsyncResult : ContextAwareResult
{
	internal AcceptAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
		: base(myObject, myState, myCallBack)
	{
	}
}
