using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net.WebSockets;

public sealed class ClientWebSocketOptions
{
	private bool isReadOnly;

	private readonly IList<string> requestedSubProtocols;

	private readonly WebHeaderCollection requestHeaders;

	private TimeSpan keepAliveInterval;

	private int receiveBufferSize;

	private int sendBufferSize;

	private ArraySegment<byte>? buffer;

	private bool useDefaultCredentials;

	private ICredentials credentials;

	private IWebProxy proxy;

	private X509CertificateCollection clientCertificates;

	private CookieContainer cookies;

	internal WebHeaderCollection RequestHeaders => requestHeaders;

	public bool UseDefaultCredentials
	{
		get
		{
			return useDefaultCredentials;
		}
		set
		{
			ThrowIfReadOnly();
			useDefaultCredentials = value;
		}
	}

	public ICredentials Credentials
	{
		get
		{
			return credentials;
		}
		set
		{
			ThrowIfReadOnly();
			credentials = value;
		}
	}

	public IWebProxy Proxy
	{
		get
		{
			return proxy;
		}
		set
		{
			ThrowIfReadOnly();
			proxy = value;
		}
	}

	public X509CertificateCollection ClientCertificates
	{
		get
		{
			if (clientCertificates == null)
			{
				clientCertificates = new X509CertificateCollection();
			}
			return clientCertificates;
		}
		set
		{
			ThrowIfReadOnly();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			clientCertificates = value;
		}
	}

	internal X509CertificateCollection InternalClientCertificates => clientCertificates;

	public CookieContainer Cookies
	{
		get
		{
			return cookies;
		}
		set
		{
			ThrowIfReadOnly();
			cookies = value;
		}
	}

	internal int ReceiveBufferSize => receiveBufferSize;

	internal int SendBufferSize => sendBufferSize;

	internal IList<string> RequestedSubProtocols => requestedSubProtocols;

	public TimeSpan KeepAliveInterval
	{
		get
		{
			return keepAliveInterval;
		}
		set
		{
			ThrowIfReadOnly();
			if (value < Timeout.InfiniteTimeSpan)
			{
				throw new ArgumentOutOfRangeException("value", value, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", Timeout.InfiniteTimeSpan.ToString()));
			}
			keepAliveInterval = value;
		}
	}

	internal ClientWebSocketOptions()
	{
		requestedSubProtocols = new List<string>();
		requestHeaders = new WebHeaderCollection(WebHeaderCollectionType.HttpWebRequest);
		Proxy = WebRequest.DefaultWebProxy;
		receiveBufferSize = 16384;
		sendBufferSize = 16384;
		keepAliveInterval = WebSocket.DefaultKeepAliveInterval;
	}

	public void SetRequestHeader(string headerName, string headerValue)
	{
		ThrowIfReadOnly();
		requestHeaders.Set(headerName, headerValue);
	}

	public void SetBuffer(int receiveBufferSize, int sendBufferSize)
	{
		ThrowIfReadOnly();
		WebSocketHelpers.ValidateBufferSizes(receiveBufferSize, sendBufferSize);
		buffer = null;
		this.receiveBufferSize = receiveBufferSize;
		this.sendBufferSize = sendBufferSize;
	}

	public void SetBuffer(int receiveBufferSize, int sendBufferSize, ArraySegment<byte> buffer)
	{
		ThrowIfReadOnly();
		WebSocketHelpers.ValidateBufferSizes(receiveBufferSize, sendBufferSize);
		WebSocketHelpers.ValidateArraySegment(buffer, "buffer");
		WebSocketBuffer.Validate(buffer.Count, receiveBufferSize, sendBufferSize, isServerBuffer: false);
		this.receiveBufferSize = receiveBufferSize;
		this.sendBufferSize = sendBufferSize;
		if (AppDomain.CurrentDomain.IsFullyTrusted)
		{
			this.buffer = buffer;
		}
		else
		{
			this.buffer = null;
		}
	}

	internal ArraySegment<byte> GetOrCreateBuffer()
	{
		if (!buffer.HasValue)
		{
			buffer = WebSocket.CreateClientBuffer(receiveBufferSize, sendBufferSize);
		}
		return buffer.Value;
	}

	public void AddSubProtocol(string subProtocol)
	{
		ThrowIfReadOnly();
		WebSocketHelpers.ValidateSubprotocol(subProtocol);
		foreach (string requestedSubProtocol in requestedSubProtocols)
		{
			if (string.Equals(requestedSubProtocol, subProtocol, StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(SR.GetString("net_WebSockets_NoDuplicateProtocol", subProtocol), "subProtocol");
			}
		}
		requestedSubProtocols.Add(subProtocol);
	}

	internal void SetToReadOnly()
	{
		isReadOnly = true;
	}

	private void ThrowIfReadOnly()
	{
		if (isReadOnly)
		{
			throw new InvalidOperationException(SR.GetString("net_WebSockets_AlreadyStarted"));
		}
	}
}
