using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Principal;

namespace System.Net.WebSockets;

public class HttpListenerWebSocketContext : WebSocketContext
{
	private Uri m_RequestUri;

	private NameValueCollection m_Headers;

	private CookieCollection m_CookieCollection;

	private IPrincipal m_User;

	private bool m_IsAuthenticated;

	private bool m_IsLocal;

	private bool m_IsSecureConnection;

	private string m_Origin;

	private IEnumerable<string> m_SecWebSocketProtocols;

	private string m_SecWebSocketVersion;

	private string m_SecWebSocketKey;

	private WebSocket m_WebSocket;

	public override Uri RequestUri => m_RequestUri;

	public override NameValueCollection Headers => m_Headers;

	public override string Origin => m_Origin;

	public override IEnumerable<string> SecWebSocketProtocols => m_SecWebSocketProtocols;

	public override string SecWebSocketVersion => m_SecWebSocketVersion;

	public override string SecWebSocketKey => m_SecWebSocketKey;

	public override CookieCollection CookieCollection => m_CookieCollection;

	public override IPrincipal User => m_User;

	public override bool IsAuthenticated => m_IsAuthenticated;

	public override bool IsLocal => m_IsLocal;

	public override bool IsSecureConnection => m_IsSecureConnection;

	public override WebSocket WebSocket => m_WebSocket;

	internal HttpListenerWebSocketContext(Uri requestUri, NameValueCollection headers, CookieCollection cookieCollection, IPrincipal user, bool isAuthenticated, bool isLocal, bool isSecureConnection, string origin, IEnumerable<string> secWebSocketProtocols, string secWebSocketVersion, string secWebSocketKey, WebSocket webSocket)
	{
		m_CookieCollection = new CookieCollection();
		m_CookieCollection.Add(cookieCollection);
		m_Headers = new NameValueCollection(headers);
		m_User = CopyPrincipal(user);
		m_RequestUri = requestUri;
		m_IsAuthenticated = isAuthenticated;
		m_IsLocal = isLocal;
		m_IsSecureConnection = isSecureConnection;
		m_Origin = origin;
		m_SecWebSocketProtocols = secWebSocketProtocols;
		m_SecWebSocketVersion = secWebSocketVersion;
		m_SecWebSocketKey = secWebSocketKey;
		m_WebSocket = webSocket;
	}

	private static IPrincipal CopyPrincipal(IPrincipal user)
	{
		IPrincipal result = null;
		if (user != null)
		{
			if (!(user is WindowsPrincipal))
			{
				if (user.Identity is HttpListenerBasicIdentity httpListenerBasicIdentity)
				{
					result = new GenericPrincipal(new HttpListenerBasicIdentity(httpListenerBasicIdentity.Name, httpListenerBasicIdentity.Password), null);
				}
			}
			else
			{
				WindowsIdentity windowsIdentity = (WindowsIdentity)user.Identity;
				result = new WindowsPrincipal(HttpListener.CreateWindowsIdentity(windowsIdentity.Token, windowsIdentity.AuthenticationType, WindowsAccountType.Normal, isAuthenticated: true));
			}
		}
		return result;
	}
}
