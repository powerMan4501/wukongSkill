using System.Net.WebSockets;

namespace System.Net;

internal class WebSocketHttpRequestCreator : IWebRequestCreate
{
	private string m_httpScheme;

	public WebSocketHttpRequestCreator(bool usingHttps)
	{
		m_httpScheme = (usingHttps ? Uri.UriSchemeHttps : Uri.UriSchemeHttp);
	}

	public WebRequest Create(Uri Uri)
	{
		UriBuilder uriBuilder = new UriBuilder(Uri);
		uriBuilder.Scheme = m_httpScheme;
		HttpWebRequest request = new HttpWebRequest(uriBuilder.Uri, null, isWebSocketRequest: true, "WebSocket" + Guid.NewGuid().ToString());
		WebSocketHelpers.PrepareWebRequest(ref request);
		return request;
	}
}
