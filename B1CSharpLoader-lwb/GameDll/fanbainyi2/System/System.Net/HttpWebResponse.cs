using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public class HttpWebResponse : WebResponse, ISerializable
{
	private Uri m_Uri;

	private KnownHttpVerb m_Verb;

	private HttpStatusCode m_StatusCode;

	private string m_StatusDescription;

	private Stream m_ConnectStream;

	private CoreResponseData m_CoreResponseData;

	private WebHeaderCollection m_HttpResponseHeaders;

	private long m_ContentLength;

	private string m_MediaType;

	private string m_CharacterSet;

	private bool m_IsVersionHttp11;

	internal X509Certificate m_Certificate;

	private CookieCollection m_cookies;

	private bool m_disposed;

	private bool m_propertiesDisposed;

	private bool m_UsesProxySemantics;

	private bool m_IsMutuallyAuthenticated;

	private bool m_IsWebSocketResponse;

	private string m_ConnectionGroupName;

	private Stream m_WebSocketConnectionStream;

	internal bool IsWebSocketResponse
	{
		get
		{
			return m_IsWebSocketResponse;
		}
		set
		{
			m_IsWebSocketResponse = value;
		}
	}

	internal string ConnectionGroupName
	{
		get
		{
			return m_ConnectionGroupName;
		}
		set
		{
			m_ConnectionGroupName = value;
		}
	}

	internal Stream ResponseStream
	{
		get
		{
			return m_ConnectStream;
		}
		set
		{
			m_ConnectStream = value;
		}
	}

	internal CoreResponseData CoreResponseData => m_CoreResponseData;

	public override bool IsMutuallyAuthenticated
	{
		get
		{
			CheckDisposed();
			return m_IsMutuallyAuthenticated;
		}
	}

	internal bool InternalSetIsMutuallyAuthenticated
	{
		set
		{
			m_IsMutuallyAuthenticated = value;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual CookieCollection Cookies
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			if (m_cookies == null)
			{
				m_cookies = new CookieCollection();
			}
			return m_cookies;
		}
		set
		{
			CheckDisposed();
			m_cookies = value;
		}
	}

	[global::__DynamicallyInvokable]
	public override WebHeaderCollection Headers
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_HttpResponseHeaders;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool SupportsHeaders
	{
		[global::__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[global::__DynamicallyInvokable]
	public override long ContentLength
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_ContentLength;
		}
	}

	public string ContentEncoding
	{
		get
		{
			CheckDisposed();
			string text = m_HttpResponseHeaders["Content-Encoding"];
			if (text != null)
			{
				return text;
			}
			return string.Empty;
		}
	}

	[global::__DynamicallyInvokable]
	public override string ContentType
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			string contentType = m_HttpResponseHeaders.ContentType;
			if (contentType != null)
			{
				return contentType;
			}
			return string.Empty;
		}
	}

	public string CharacterSet
	{
		get
		{
			CheckDisposed();
			string contentType = m_HttpResponseHeaders.ContentType;
			if (m_CharacterSet == null && !ValidationHelper.IsBlankString(contentType))
			{
				m_CharacterSet = string.Empty;
				string text = contentType.ToLower(CultureInfo.InvariantCulture);
				if (text.Trim().StartsWith("text/"))
				{
					m_CharacterSet = "ISO-8859-1";
				}
				int i = text.IndexOf(";");
				if (i > 0)
				{
					while ((i = text.IndexOf("charset", i)) >= 0)
					{
						i += 7;
						if (text[i - 8] != ';' && text[i - 8] != ' ')
						{
							continue;
						}
						for (; i < text.Length && text[i] == ' '; i++)
						{
						}
						if (i < text.Length - 1 && text[i] == '=')
						{
							i++;
							int num = text.IndexOf(';', i);
							if (num > i)
							{
								m_CharacterSet = contentType.Substring(i, num - i).Trim();
							}
							else
							{
								m_CharacterSet = contentType.Substring(i).Trim();
							}
							break;
						}
					}
				}
			}
			return m_CharacterSet;
		}
	}

	public string Server
	{
		get
		{
			CheckDisposed();
			string server = m_HttpResponseHeaders.Server;
			if (server != null)
			{
				return server;
			}
			return string.Empty;
		}
	}

	public DateTime LastModified
	{
		get
		{
			CheckDisposed();
			string lastModified = m_HttpResponseHeaders.LastModified;
			if (lastModified == null)
			{
				return DateTime.Now;
			}
			return HttpProtocolUtils.string2date(lastModified);
		}
	}

	[global::__DynamicallyInvokable]
	public virtual HttpStatusCode StatusCode
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_StatusCode;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string StatusDescription
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_StatusDescription;
		}
	}

	public Version ProtocolVersion
	{
		get
		{
			CheckDisposed();
			if (!m_IsVersionHttp11)
			{
				return HttpVersion.Version10;
			}
			return HttpVersion.Version11;
		}
	}

	internal bool KeepAlive
	{
		get
		{
			if (m_UsesProxySemantics)
			{
				string text = Headers["Proxy-Connection"];
				if (text != null)
				{
					if (text.ToLower(CultureInfo.InvariantCulture).IndexOf("close") >= 0)
					{
						return text.ToLower(CultureInfo.InvariantCulture).IndexOf("keep-alive") >= 0;
					}
					return true;
				}
			}
			string text2 = Headers["Connection"];
			if (text2 != null)
			{
				text2 = text2.ToLower(CultureInfo.InvariantCulture);
			}
			if (ProtocolVersion == HttpVersion.Version10)
			{
				if (text2 != null)
				{
					return text2.IndexOf("keep-alive") >= 0;
				}
				return false;
			}
			if (ProtocolVersion >= HttpVersion.Version11)
			{
				if (text2 != null && text2.IndexOf("close") >= 0)
				{
					return text2.IndexOf("keep-alive") >= 0;
				}
				return true;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public override Uri ResponseUri
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_Uri;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string Method
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_Verb.Name;
		}
	}

	[global::__DynamicallyInvokable]
	public override Stream GetResponseStream()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "GetResponseStream", "");
		}
		CheckDisposed();
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "ContentLength=" + m_ContentLength);
		}
		Stream stream;
		if (m_IsWebSocketResponse && m_StatusCode == HttpStatusCode.SwitchingProtocols)
		{
			if (m_WebSocketConnectionStream == null)
			{
				ConnectStream connectStream = m_ConnectStream as ConnectStream;
				m_WebSocketConnectionStream = new WebSocketConnectionStream(connectStream, ConnectionGroupName);
			}
			stream = m_WebSocketConnectionStream;
		}
		else
		{
			stream = m_ConnectStream;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "GetResponseStream", stream);
		}
		return stream;
	}

	public override void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Close", "");
		}
		if (!m_disposed)
		{
			m_disposed = true;
			try
			{
				Stream connectStream = m_ConnectStream;
				if (connectStream is ICloseEx closeEx)
				{
					closeEx.CloseEx(CloseExState.Normal);
				}
				else
				{
					connectStream?.Close();
				}
			}
			finally
			{
				if (IsWebSocketResponse && m_ConnectStream is ConnectStream { Connection: not null } connectStream2)
				{
					connectStream2.Connection.ServicePoint.CloseConnectionGroup(ConnectionGroupName);
				}
			}
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "Close", "");
		}
	}

	internal void Abort()
	{
		Stream connectStream = m_ConnectStream;
		ICloseEx closeEx = connectStream as ICloseEx;
		try
		{
			if (closeEx != null)
			{
				closeEx.CloseEx(CloseExState.Abort);
			}
			else
			{
				connectStream?.Close();
			}
		}
		catch
		{
		}
	}

	[global::__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			base.Dispose(disposing: true);
			m_propertiesDisposed = true;
		}
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HttpWebResponse()
	{
	}

	internal HttpWebResponse(Uri responseUri, KnownHttpVerb verb, CoreResponseData coreData, string mediaType, bool usesProxySemantics, DecompressionMethods decompressionMethod, bool isWebSocketResponse, string connectionGroupName)
	{
		m_Uri = responseUri;
		m_Verb = verb;
		m_MediaType = mediaType;
		m_UsesProxySemantics = usesProxySemantics;
		m_CoreResponseData = coreData;
		m_ConnectStream = coreData.m_ConnectStream;
		m_HttpResponseHeaders = coreData.m_ResponseHeaders;
		m_ContentLength = coreData.m_ContentLength;
		m_StatusCode = coreData.m_StatusCode;
		m_StatusDescription = coreData.m_StatusDescription;
		m_IsVersionHttp11 = coreData.m_IsVersionHttp11;
		m_IsWebSocketResponse = isWebSocketResponse;
		m_ConnectionGroupName = connectionGroupName;
		if (m_ContentLength == 0L && m_ConnectStream is ConnectStream)
		{
			((ConnectStream)m_ConnectStream).CallDone();
		}
		string text = m_HttpResponseHeaders["Content-Location"];
		if (text != null)
		{
			try
			{
				m_Uri = new Uri(m_Uri, text);
			}
			catch (UriFormatException)
			{
			}
		}
		if (decompressionMethod == DecompressionMethods.None)
		{
			return;
		}
		string text2 = m_HttpResponseHeaders["Content-Encoding"];
		if (text2 != null)
		{
			if ((decompressionMethod & DecompressionMethods.GZip) != DecompressionMethods.None && text2.IndexOf("gzip", StringComparison.CurrentCulture) != -1)
			{
				m_ConnectStream = new GZipWrapperStream(m_ConnectStream, CompressionMode.Decompress);
				m_ContentLength = -1L;
				m_HttpResponseHeaders["Content-Encoding"] = null;
			}
			else if ((decompressionMethod & DecompressionMethods.Deflate) != DecompressionMethods.None && text2.IndexOf("deflate", StringComparison.CurrentCulture) != -1)
			{
				m_ConnectStream = new DeflateWrapperStream(m_ConnectStream, CompressionMode.Decompress);
				m_ContentLength = -1L;
				m_HttpResponseHeaders["Content-Encoding"] = null;
			}
		}
	}

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
		m_HttpResponseHeaders = (WebHeaderCollection)serializationInfo.GetValue("m_HttpResponseHeaders", typeof(WebHeaderCollection));
		m_Uri = (Uri)serializationInfo.GetValue("m_Uri", typeof(Uri));
		m_Certificate = (X509Certificate)serializationInfo.GetValue("m_Certificate", typeof(X509Certificate));
		Version version = (Version)serializationInfo.GetValue("m_Version", typeof(Version));
		m_IsVersionHttp11 = version.Equals(HttpVersion.Version11);
		m_StatusCode = (HttpStatusCode)serializationInfo.GetInt32("m_StatusCode");
		m_ContentLength = serializationInfo.GetInt64("m_ContentLength");
		m_Verb = KnownHttpVerb.Parse(serializationInfo.GetString("m_Verb"));
		m_StatusDescription = serializationInfo.GetString("m_StatusDescription");
		m_MediaType = serializationInfo.GetString("m_MediaType");
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		GetObjectData(serializationInfo, streamingContext);
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		serializationInfo.AddValue("m_HttpResponseHeaders", m_HttpResponseHeaders, typeof(WebHeaderCollection));
		serializationInfo.AddValue("m_Uri", m_Uri, typeof(Uri));
		serializationInfo.AddValue("m_Certificate", m_Certificate, typeof(X509Certificate));
		serializationInfo.AddValue("m_Version", ProtocolVersion, typeof(Version));
		serializationInfo.AddValue("m_StatusCode", m_StatusCode);
		serializationInfo.AddValue("m_ContentLength", m_ContentLength);
		serializationInfo.AddValue("m_Verb", m_Verb.Name);
		serializationInfo.AddValue("m_StatusDescription", m_StatusDescription);
		serializationInfo.AddValue("m_MediaType", m_MediaType);
		base.GetObjectData(serializationInfo, streamingContext);
	}

	public string GetResponseHeader(string headerName)
	{
		CheckDisposed();
		string text = m_HttpResponseHeaders[headerName];
		if (text != null)
		{
			return text;
		}
		return string.Empty;
	}

	private void CheckDisposed()
	{
		if (m_propertiesDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}
}
