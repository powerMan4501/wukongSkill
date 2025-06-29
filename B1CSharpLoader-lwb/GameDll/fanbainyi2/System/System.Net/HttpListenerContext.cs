using System.ComponentModel;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading.Tasks;

namespace System.Net;

public sealed class HttpListenerContext
{
	private HttpListener m_Listener;

	private HttpListenerRequest m_Request;

	private HttpListenerResponse m_Response;

	private IPrincipal m_User;

	private string m_MutualAuthentication;

	private AuthenticationSchemes m_AuthenticationSchemes;

	private ExtendedProtectionPolicy m_ExtendedProtectionPolicy;

	private bool m_PromoteCookiesToRfc2965;

	internal const string NTLM = "NTLM";

	public HttpListenerRequest Request => m_Request;

	public HttpListenerResponse Response
	{
		get
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.HttpListener, this, "Response", "");
			}
			if (m_Response == null)
			{
				m_Response = new HttpListenerResponse(this);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Response", "");
			}
			return m_Response;
		}
	}

	public IPrincipal User
	{
		get
		{
			if (!(m_User is WindowsPrincipal))
			{
				return m_User;
			}
			new SecurityPermission(SecurityPermissionFlag.ControlPrincipal).Demand();
			return m_User;
		}
	}

	internal AuthenticationSchemes AuthenticationSchemes
	{
		get
		{
			return m_AuthenticationSchemes;
		}
		set
		{
			m_AuthenticationSchemes = value;
		}
	}

	internal ExtendedProtectionPolicy ExtendedProtectionPolicy
	{
		get
		{
			return m_ExtendedProtectionPolicy;
		}
		set
		{
			m_ExtendedProtectionPolicy = value;
		}
	}

	internal bool PromoteCookiesToRfc2965 => m_PromoteCookiesToRfc2965;

	internal string MutualAuthentication => m_MutualAuthentication;

	internal HttpListener Listener => m_Listener;

	internal CriticalHandle RequestQueueHandle => m_Listener.RequestQueueHandle;

	internal ulong RequestId => Request.RequestId;

	internal unsafe HttpListenerContext(HttpListener httpListener, RequestContextBase memoryBlob)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, ".ctor", "httpListener#" + ValidationHelper.HashString(httpListener) + " requestBlob=" + ValidationHelper.HashString((IntPtr)memoryBlob.RequestBlob));
		}
		m_Listener = httpListener;
		m_Request = new HttpListenerRequest(this, memoryBlob);
		m_AuthenticationSchemes = httpListener.AuthenticationSchemes;
		m_ExtendedProtectionPolicy = httpListener.ExtendedProtectionPolicy;
	}

	internal void SetIdentity(IPrincipal principal, string mutualAuthentication)
	{
		m_MutualAuthentication = mutualAuthentication;
		m_User = principal;
	}

	internal void EnsureBoundHandle()
	{
		m_Listener.EnsureBoundHandle();
	}

	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol)
	{
		return AcceptWebSocketAsync(subProtocol, 16384, WebSocket.DefaultKeepAliveInterval);
	}

	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval)
	{
		return AcceptWebSocketAsync(subProtocol, 16384, keepAliveInterval);
	}

	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval)
	{
		WebSocketHelpers.ValidateOptions(subProtocol, receiveBufferSize, 16, keepAliveInterval);
		ArraySegment<byte> internalBuffer = WebSocketBuffer.CreateInternalBufferArraySegment(receiveBufferSize, 16, isServerBuffer: true);
		return AcceptWebSocketAsync(subProtocol, receiveBufferSize, keepAliveInterval, internalBuffer);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
	{
		return WebSocketHelpers.AcceptWebSocketAsync(this, subProtocol, receiveBufferSize, keepAliveInterval, internalBuffer);
	}

	internal void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Close()", "");
		}
		try
		{
			if (m_Response != null)
			{
				m_Response.Close();
			}
		}
		finally
		{
			try
			{
				m_Request.Close();
			}
			finally
			{
				IDisposable disposable = ((m_User == null) ? null : (m_User.Identity as IDisposable));
				if (disposable != null && m_User.Identity.AuthenticationType != "NTLM" && !m_Listener.UnsafeConnectionNtlmAuthentication)
				{
					disposable.Dispose();
				}
			}
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "Close", "");
		}
	}

	internal void Abort()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Abort", "");
		}
		ForceCancelRequest(RequestQueueHandle, m_Request.RequestId);
		try
		{
			m_Request.Close();
		}
		finally
		{
			((m_User == null) ? null : (m_User.Identity as IDisposable))?.Dispose();
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "Abort", "");
		}
	}

	internal UnsafeNclNativeMethods.HttpApi.HTTP_VERB GetKnownMethod()
	{
		return UnsafeNclNativeMethods.HttpApi.GetKnownVerb(Request.RequestBuffer, Request.OriginalBlobAddress);
	}

	internal static void CancelRequest(CriticalHandle requestQueueHandle, ulong requestId)
	{
		uint num = UnsafeNclNativeMethods.HttpApi.HttpCancelHttpRequest(requestQueueHandle, requestId, IntPtr.Zero);
	}

	internal void ForceCancelRequest(CriticalHandle requestQueueHandle, ulong requestId)
	{
		uint num = UnsafeNclNativeMethods.HttpApi.HttpCancelHttpRequest(requestQueueHandle, requestId, IntPtr.Zero);
		if (num == 1229)
		{
			m_Response.CancelLastWrite(requestQueueHandle);
		}
	}

	internal void SetAuthenticationHeaders()
	{
		Listener.SetAuthenticationHeaders(this);
	}
}
