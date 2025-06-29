namespace System.Net;

internal struct WriteHeadersCallbackState
{
	internal HttpWebRequest request;

	internal ConnectStream stream;

	internal WriteHeadersCallbackState(HttpWebRequest request, ConnectStream stream)
	{
		this.request = request;
		this.stream = stream;
	}
}
