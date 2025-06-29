using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

public sealed class HttpListenerRequest
{
	private enum SslStatus : byte
	{
		Insecure,
		NoClientCert,
		ClientCert
	}

	private static class Helpers
	{
		private class UrlDecoder
		{
			private int _bufferSize;

			private int _numChars;

			private char[] _charBuffer;

			private int _numBytes;

			private byte[] _byteBuffer;

			private Encoding _encoding;

			private void FlushBytes()
			{
				if (_numBytes > 0)
				{
					_numChars += _encoding.GetChars(_byteBuffer, 0, _numBytes, _charBuffer, _numChars);
					_numBytes = 0;
				}
			}

			internal UrlDecoder(int bufferSize, Encoding encoding)
			{
				_bufferSize = bufferSize;
				_encoding = encoding;
				_charBuffer = new char[bufferSize];
			}

			internal void AddChar(char ch)
			{
				if (_numBytes > 0)
				{
					FlushBytes();
				}
				_charBuffer[_numChars++] = ch;
			}

			internal void AddByte(byte b)
			{
				if (_byteBuffer == null)
				{
					_byteBuffer = new byte[_bufferSize];
				}
				_byteBuffer[_numBytes++] = b;
			}

			internal string GetString()
			{
				if (_numBytes > 0)
				{
					FlushBytes();
				}
				if (_numChars > 0)
				{
					return new string(_charBuffer, 0, _numChars);
				}
				return string.Empty;
			}
		}

		internal static string GetAttributeFromHeader(string headerValue, string attrName)
		{
			if (headerValue == null)
			{
				return null;
			}
			int length = headerValue.Length;
			int length2 = attrName.Length;
			int i;
			for (i = 1; i < length; i += length2)
			{
				i = CultureInfo.InvariantCulture.CompareInfo.IndexOf(headerValue, attrName, i, CompareOptions.IgnoreCase);
				if (i < 0 || i + length2 >= length)
				{
					break;
				}
				char c = headerValue[i - 1];
				char c2 = headerValue[i + length2];
				if ((c == ';' || c == ',' || char.IsWhiteSpace(c)) && (c2 == '=' || char.IsWhiteSpace(c2)))
				{
					break;
				}
			}
			if (i < 0 || i >= length)
			{
				return null;
			}
			for (i += length2; i < length && char.IsWhiteSpace(headerValue[i]); i++)
			{
			}
			if (i >= length || headerValue[i] != '=')
			{
				return null;
			}
			for (i++; i < length && char.IsWhiteSpace(headerValue[i]); i++)
			{
			}
			if (i >= length)
			{
				return null;
			}
			string text = null;
			int num;
			if (i < length && headerValue[i] == '"')
			{
				if (i == length - 1)
				{
					return null;
				}
				num = headerValue.IndexOf('"', i + 1);
				if (num < 0 || num == i + 1)
				{
					return null;
				}
				return headerValue.Substring(i + 1, num - i - 1).Trim();
			}
			for (num = i; num < length && headerValue[num] != ' ' && headerValue[num] != ','; num++)
			{
			}
			if (num == i)
			{
				return null;
			}
			return headerValue.Substring(i, num - i).Trim();
		}

		internal static string[] ParseMultivalueHeader(string s)
		{
			if (s == null)
			{
				return null;
			}
			int length = s.Length;
			ArrayList arrayList = new ArrayList();
			int num = 0;
			while (num < length)
			{
				int num2 = s.IndexOf(',', num);
				if (num2 < 0)
				{
					num2 = length;
				}
				arrayList.Add(s.Substring(num, num2 - num));
				num = num2 + 1;
				if (num < length && s[num] == ' ')
				{
					num++;
				}
			}
			int count = arrayList.Count;
			string[] array;
			if (count == 0)
			{
				array = new string[1] { string.Empty };
			}
			else
			{
				array = new string[count];
				arrayList.CopyTo(0, array, 0, count);
			}
			return array;
		}

		private static string UrlDecodeStringFromStringInternal(string s, Encoding e)
		{
			int length = s.Length;
			UrlDecoder urlDecoder = new UrlDecoder(length, e);
			for (int i = 0; i < length; i++)
			{
				char c = s[i];
				switch (c)
				{
				case '+':
					c = ' ';
					break;
				case '%':
					if (i >= length - 2)
					{
						break;
					}
					if (s[i + 1] == 'u' && i < length - 5)
					{
						int num = HexToInt(s[i + 2]);
						int num2 = HexToInt(s[i + 3]);
						int num3 = HexToInt(s[i + 4]);
						int num4 = HexToInt(s[i + 5]);
						if (num >= 0 && num2 >= 0 && num3 >= 0 && num4 >= 0)
						{
							c = (char)((num << 12) | (num2 << 8) | (num3 << 4) | num4);
							i += 5;
							urlDecoder.AddChar(c);
							continue;
						}
					}
					else
					{
						int num5 = HexToInt(s[i + 1]);
						int num6 = HexToInt(s[i + 2]);
						if (num5 >= 0 && num6 >= 0)
						{
							byte b = (byte)((num5 << 4) | num6);
							i += 2;
							urlDecoder.AddByte(b);
							continue;
						}
					}
					break;
				}
				if ((c & 0xFF80) == 0)
				{
					urlDecoder.AddByte((byte)c);
				}
				else
				{
					urlDecoder.AddChar(c);
				}
			}
			return urlDecoder.GetString();
		}

		private static int HexToInt(char h)
		{
			if (h < '0' || h > '9')
			{
				if (h < 'a' || h > 'f')
				{
					if (h < 'A' || h > 'F')
					{
						return -1;
					}
					return h - 65 + 10;
				}
				return h - 97 + 10;
			}
			return h - 48;
		}

		internal static void FillFromString(NameValueCollection nvc, string s, bool urlencoded, Encoding encoding)
		{
			int num = s?.Length ?? 0;
			for (int i = ((s.Length > 0 && s[0] == '?') ? 1 : 0); i < num; i++)
			{
				int num2 = i;
				int num3 = -1;
				for (; i < num; i++)
				{
					switch (s[i])
					{
					case '=':
						if (num3 < 0)
						{
							num3 = i;
						}
						continue;
					default:
						continue;
					case '&':
						break;
					}
					break;
				}
				string text = null;
				string text2 = null;
				if (num3 >= 0)
				{
					text = s.Substring(num2, num3 - num2);
					text2 = s.Substring(num3 + 1, i - num3 - 1);
				}
				else
				{
					text2 = s.Substring(num2, i - num2);
				}
				if (urlencoded)
				{
					nvc.Add((text == null) ? null : UrlDecodeStringFromStringInternal(text, encoding), UrlDecodeStringFromStringInternal(text2, encoding));
				}
				else
				{
					nvc.Add(text, text2);
				}
				if (i == num - 1 && s[i] == '&')
				{
					nvc.Add(null, "");
				}
			}
		}
	}

	private Uri m_RequestUri;

	private ulong m_RequestId;

	internal ulong m_ConnectionId;

	private SslStatus m_SslStatus;

	private string m_RawUrl;

	private string m_CookedUrlHost;

	private string m_CookedUrlPath;

	private string m_CookedUrlQuery;

	private long m_ContentLength;

	private Stream m_RequestStream;

	private string m_HttpMethod;

	private TriState m_KeepAlive;

	private Version m_Version;

	private WebHeaderCollection m_WebHeaders;

	private IPEndPoint m_LocalEndPoint;

	private IPEndPoint m_RemoteEndPoint;

	private BoundaryType m_BoundaryType;

	private ListenerClientCertState m_ClientCertState;

	private X509Certificate2 m_ClientCertificate;

	private int m_ClientCertificateError;

	private RequestContextBase m_MemoryBlob;

	private CookieCollection m_Cookies;

	private HttpListenerContext m_HttpContext;

	private bool m_IsDisposed;

	internal const uint CertBoblSize = 1500u;

	private string m_ServiceName;

	private object m_Lock = new object();

	private List<TokenBinding> m_TokenBindings;

	private int m_TokenBindingVerifyMessageStatus;

	internal HttpListenerContext HttpListenerContext => m_HttpContext;

	internal byte[] RequestBuffer
	{
		get
		{
			CheckDisposed();
			return m_MemoryBlob.RequestBuffer;
		}
	}

	internal IntPtr OriginalBlobAddress
	{
		get
		{
			CheckDisposed();
			return m_MemoryBlob.OriginalBlobAddress;
		}
	}

	public unsafe Guid RequestTraceIdentifier
	{
		get
		{
			Guid result = default(Guid);
			*(1 + (long*)(&result)) = (long)RequestId;
			return result;
		}
	}

	internal ulong RequestId => m_RequestId;

	public string[] AcceptTypes => Helpers.ParseMultivalueHeader(GetKnownHeader(HttpRequestHeader.Accept));

	public Encoding ContentEncoding
	{
		get
		{
			if (UserAgent != null && CultureInfo.InvariantCulture.CompareInfo.IsPrefix(UserAgent, "UP"))
			{
				string text = Headers["x-up-devcap-post-charset"];
				if (text != null && text.Length > 0)
				{
					try
					{
						return Encoding.GetEncoding(text);
					}
					catch (ArgumentException)
					{
					}
				}
			}
			if (HasEntityBody && ContentType != null)
			{
				string attributeFromHeader = Helpers.GetAttributeFromHeader(ContentType, "charset");
				if (attributeFromHeader != null)
				{
					try
					{
						return Encoding.GetEncoding(attributeFromHeader);
					}
					catch (ArgumentException)
					{
					}
				}
			}
			return Encoding.Default;
		}
	}

	public long ContentLength64
	{
		get
		{
			if (m_BoundaryType == BoundaryType.None)
			{
				if ("chunked".Equals(GetKnownHeader(HttpRequestHeader.TransferEncoding), StringComparison.OrdinalIgnoreCase))
				{
					m_BoundaryType = BoundaryType.Chunked;
					m_ContentLength = -1L;
				}
				else
				{
					m_ContentLength = 0L;
					m_BoundaryType = BoundaryType.ContentLength;
					string knownHeader = GetKnownHeader(HttpRequestHeader.ContentLength);
					if (knownHeader != null && !long.TryParse(knownHeader, NumberStyles.None, CultureInfo.InvariantCulture.NumberFormat, out m_ContentLength))
					{
						m_ContentLength = 0L;
						m_BoundaryType = BoundaryType.Invalid;
					}
				}
			}
			return m_ContentLength;
		}
	}

	public string ContentType => GetKnownHeader(HttpRequestHeader.ContentType);

	public NameValueCollection Headers
	{
		get
		{
			if (m_WebHeaders == null)
			{
				m_WebHeaders = UnsafeNclNativeMethods.HttpApi.GetHeaders(RequestBuffer, OriginalBlobAddress);
			}
			return m_WebHeaders;
		}
	}

	public string HttpMethod
	{
		get
		{
			if (m_HttpMethod == null)
			{
				m_HttpMethod = UnsafeNclNativeMethods.HttpApi.GetVerb(RequestBuffer, OriginalBlobAddress);
			}
			return m_HttpMethod;
		}
	}

	public Stream InputStream
	{
		get
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.HttpListener, this, "InputStream_get", "");
			}
			if (m_RequestStream == null)
			{
				m_RequestStream = (HasEntityBody ? new HttpRequestStream(HttpListenerContext) : Stream.Null);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "InputStream_get", "");
			}
			return m_RequestStream;
		}
	}

	public bool IsAuthenticated
	{
		get
		{
			IPrincipal user = HttpListenerContext.User;
			if (user != null && user.Identity != null)
			{
				return user.Identity.IsAuthenticated;
			}
			return false;
		}
	}

	public bool IsLocal => LocalEndPoint.Address.Equals(RemoteEndPoint.Address);

	public bool IsSecureConnection => m_SslStatus != SslStatus.Insecure;

	public bool IsWebSocketRequest
	{
		get
		{
			if (!WebSocketProtocolComponent.IsSupported)
			{
				return false;
			}
			bool flag = false;
			if (string.IsNullOrEmpty(Headers["Connection"]) || string.IsNullOrEmpty(Headers["Upgrade"]))
			{
				return false;
			}
			string[] values = Headers.GetValues("Connection");
			foreach (string strA in values)
			{
				if (string.Compare(strA, "Upgrade", StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			string[] values2 = Headers.GetValues("Upgrade");
			foreach (string strA2 in values2)
			{
				if (string.Compare(strA2, "websocket", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public NameValueCollection QueryString
	{
		get
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			Helpers.FillFromString(nameValueCollection, Url.Query, urlencoded: true, ContentEncoding);
			return nameValueCollection;
		}
	}

	public string RawUrl => m_RawUrl;

	public string ServiceName
	{
		get
		{
			return m_ServiceName;
		}
		internal set
		{
			m_ServiceName = value;
		}
	}

	public Uri Url => RequestUri;

	public Uri UrlReferrer
	{
		get
		{
			string knownHeader = GetKnownHeader(HttpRequestHeader.Referer);
			if (knownHeader == null)
			{
				return null;
			}
			if (!Uri.TryCreate(knownHeader, UriKind.RelativeOrAbsolute, out var result))
			{
				return null;
			}
			return result;
		}
	}

	public string UserAgent => GetKnownHeader(HttpRequestHeader.UserAgent);

	public string UserHostAddress => LocalEndPoint.ToString();

	public string UserHostName => GetKnownHeader(HttpRequestHeader.Host);

	public string[] UserLanguages => Helpers.ParseMultivalueHeader(GetKnownHeader(HttpRequestHeader.AcceptLanguage));

	public int ClientCertificateError
	{
		get
		{
			if (m_ClientCertState == ListenerClientCertState.NotInitialized)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_mustcall", "GetClientCertificate()/BeginGetClientCertificate()"));
			}
			if (m_ClientCertState == ListenerClientCertState.InProgress)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_mustcompletecall", "GetClientCertificate()/BeginGetClientCertificate()"));
			}
			return m_ClientCertificateError;
		}
	}

	internal X509Certificate2 ClientCertificate
	{
		set
		{
			m_ClientCertificate = value;
		}
	}

	internal ListenerClientCertState ClientCertState
	{
		set
		{
			m_ClientCertState = value;
		}
	}

	public TransportContext TransportContext => new HttpListenerRequestContext(this);

	public CookieCollection Cookies
	{
		get
		{
			if (m_Cookies == null)
			{
				string knownHeader = GetKnownHeader(HttpRequestHeader.Cookie);
				if (knownHeader != null && knownHeader.Length > 0)
				{
					m_Cookies = ParseCookies(RequestUri, knownHeader);
				}
				if (m_Cookies == null)
				{
					m_Cookies = new CookieCollection();
				}
				if (HttpListenerContext.PromoteCookiesToRfc2965)
				{
					for (int i = 0; i < m_Cookies.Count; i++)
					{
						if (m_Cookies[i].Variant == CookieVariant.Rfc2109)
						{
							m_Cookies[i].Variant = CookieVariant.Rfc2965;
						}
					}
				}
			}
			return m_Cookies;
		}
	}

	public Version ProtocolVersion => m_Version;

	public bool HasEntityBody
	{
		get
		{
			if ((ContentLength64 <= 0 || m_BoundaryType != BoundaryType.ContentLength) && m_BoundaryType != BoundaryType.Chunked)
			{
				return m_BoundaryType == BoundaryType.Multipart;
			}
			return true;
		}
	}

	public bool KeepAlive
	{
		get
		{
			if (m_KeepAlive == TriState.Unspecified)
			{
				string text = Headers["Proxy-Connection"];
				if (string.IsNullOrEmpty(text))
				{
					text = GetKnownHeader(HttpRequestHeader.Connection);
				}
				if (string.IsNullOrEmpty(text))
				{
					if (ProtocolVersion >= HttpVersion.Version11)
					{
						m_KeepAlive = TriState.True;
					}
					else
					{
						text = GetKnownHeader(HttpRequestHeader.KeepAlive);
						m_KeepAlive = ((!string.IsNullOrEmpty(text)) ? TriState.True : TriState.False);
					}
				}
				else
				{
					text = text.ToLower(CultureInfo.InvariantCulture);
					m_KeepAlive = ((text.IndexOf("close") < 0 || text.IndexOf("keep-alive") >= 0) ? TriState.True : TriState.False);
				}
			}
			return m_KeepAlive == TriState.True;
		}
	}

	public IPEndPoint RemoteEndPoint
	{
		get
		{
			if (m_RemoteEndPoint == null)
			{
				m_RemoteEndPoint = UnsafeNclNativeMethods.HttpApi.GetRemoteEndPoint(RequestBuffer, OriginalBlobAddress);
			}
			return m_RemoteEndPoint;
		}
	}

	public IPEndPoint LocalEndPoint
	{
		get
		{
			if (m_LocalEndPoint == null)
			{
				m_LocalEndPoint = UnsafeNclNativeMethods.HttpApi.GetLocalEndPoint(RequestBuffer, OriginalBlobAddress);
			}
			return m_LocalEndPoint;
		}
	}

	private string RequestScheme
	{
		get
		{
			if (!IsSecureConnection)
			{
				return "http";
			}
			return "https";
		}
	}

	private Uri RequestUri
	{
		get
		{
			if (m_RequestUri == null)
			{
				m_RequestUri = HttpListenerRequestUriBuilder.GetRequestUri(m_RawUrl, RequestScheme, m_CookedUrlHost, m_CookedUrlPath, m_CookedUrlQuery);
			}
			return m_RequestUri;
		}
	}

	internal unsafe HttpListenerRequest(HttpListenerContext httpContext, RequestContextBase memoryBlob)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, ".ctor", "httpContext#" + ValidationHelper.HashString(httpContext) + " memoryBlob# " + ValidationHelper.HashString((IntPtr)memoryBlob.RequestBlob));
		}
		if (Logging.On)
		{
			Logging.Associate(Logging.HttpListener, this, httpContext);
		}
		m_HttpContext = httpContext;
		m_MemoryBlob = memoryBlob;
		m_BoundaryType = BoundaryType.None;
		m_RequestId = memoryBlob.RequestBlob->RequestId;
		m_ConnectionId = memoryBlob.RequestBlob->ConnectionId;
		m_SslStatus = ((memoryBlob.RequestBlob->pSslInfo != null) ? ((memoryBlob.RequestBlob->pSslInfo->SslClientCertNegotiated == 0) ? SslStatus.NoClientCert : SslStatus.ClientCert) : SslStatus.Insecure);
		if (memoryBlob.RequestBlob->pRawUrl != null && memoryBlob.RequestBlob->RawUrlLength > 0)
		{
			m_RawUrl = Marshal.PtrToStringAnsi((IntPtr)memoryBlob.RequestBlob->pRawUrl, memoryBlob.RequestBlob->RawUrlLength);
		}
		UnsafeNclNativeMethods.HttpApi.HTTP_COOKED_URL cookedUrl = memoryBlob.RequestBlob->CookedUrl;
		if (cookedUrl.pHost != null && cookedUrl.HostLength > 0)
		{
			m_CookedUrlHost = Marshal.PtrToStringUni((IntPtr)cookedUrl.pHost, cookedUrl.HostLength / 2);
		}
		if (cookedUrl.pAbsPath != null && cookedUrl.AbsPathLength > 0)
		{
			m_CookedUrlPath = Marshal.PtrToStringUni((IntPtr)cookedUrl.pAbsPath, cookedUrl.AbsPathLength / 2);
		}
		if (cookedUrl.pQueryString != null && cookedUrl.QueryStringLength > 0)
		{
			m_CookedUrlQuery = Marshal.PtrToStringUni((IntPtr)cookedUrl.pQueryString, cookedUrl.QueryStringLength / 2);
		}
		m_Version = new Version(memoryBlob.RequestBlob->Version.MajorVersion, memoryBlob.RequestBlob->Version.MinorVersion);
		m_ClientCertState = ListenerClientCertState.NotInitialized;
		m_KeepAlive = TriState.Unspecified;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, ".ctor", "httpContext#" + ValidationHelper.HashString(httpContext) + " RequestUri:" + ValidationHelper.ToString(RequestUri) + " Content-Length:" + ValidationHelper.ToString(ContentLength64) + " HTTP Method:" + ValidationHelper.ToString(HttpMethod));
		}
		if (Logging.On)
		{
			StringBuilder stringBuilder = new StringBuilder("HttpListenerRequest Headers:\n");
			for (int i = 0; i < Headers.Count; i++)
			{
				stringBuilder.Append("\t");
				stringBuilder.Append(Headers.GetKey(i));
				stringBuilder.Append(" : ");
				stringBuilder.Append(Headers.Get(i));
				stringBuilder.Append("\n");
			}
			Logging.PrintInfo(Logging.HttpListener, this, ".ctor", stringBuilder.ToString());
		}
	}

	internal void DetachBlob(RequestContextBase memoryBlob)
	{
		if (memoryBlob != null && memoryBlob == m_MemoryBlob)
		{
			m_MemoryBlob = null;
		}
	}

	internal void ReleasePins()
	{
		m_MemoryBlob.ReleasePins();
	}

	internal void SetClientCertificateError(int clientCertificateError)
	{
		m_ClientCertificateError = clientCertificateError;
	}

	public X509Certificate2 GetClientCertificate()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "GetClientCertificate", "");
		}
		try
		{
			ProcessClientCertificate();
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "GetClientCertificate", ValidationHelper.ToString(m_ClientCertificate));
			}
		}
		return m_ClientCertificate;
	}

	public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "BeginGetClientCertificate", "");
		}
		return AsyncProcessClientCertificate(requestCallback, state);
	}

	public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "EndGetClientCertificate", "");
		}
		X509Certificate2 x509Certificate = null;
		try
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is ListenerClientCertAsyncResult listenerClientCertAsyncResult) || listenerClientCertAsyncResult.AsyncObject != this)
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (listenerClientCertAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndGetClientCertificate"));
			}
			listenerClientCertAsyncResult.EndCalled = true;
			x509Certificate = listenerClientCertAsyncResult.InternalWaitForCompletion() as X509Certificate2;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "EndGetClientCertificate", ValidationHelper.HashString(x509Certificate));
			}
		}
		return x509Certificate;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<X509Certificate2> GetClientCertificateAsync()
	{
		return Task<X509Certificate2>.Factory.FromAsync(BeginGetClientCertificate, EndGetClientCertificate, null);
	}

	private CookieCollection ParseCookies(Uri uri, string setCookieHeader)
	{
		CookieCollection cookieCollection = new CookieCollection();
		CookieParser cookieParser = new CookieParser(setCookieHeader);
		while (true)
		{
			Cookie server = cookieParser.GetServer();
			if (server == null)
			{
				break;
			}
			if (server.Name.Length != 0)
			{
				cookieCollection.InternalAdd(server, isStrict: true);
			}
		}
		return cookieCollection;
	}

	internal void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Close", "");
		}
		RequestContextBase memoryBlob = m_MemoryBlob;
		if (memoryBlob != null)
		{
			memoryBlob.Close();
			m_MemoryBlob = null;
		}
		m_IsDisposed = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "Close", "");
		}
	}

	private unsafe ListenerClientCertAsyncResult AsyncProcessClientCertificate(AsyncCallback requestCallback, object state)
	{
		if (m_ClientCertState == ListenerClientCertState.InProgress)
		{
			throw new InvalidOperationException(SR.GetString("net_listener_callinprogress", "GetClientCertificate()/BeginGetClientCertificate()"));
		}
		m_ClientCertState = ListenerClientCertState.InProgress;
		HttpListenerContext.EnsureBoundHandle();
		ListenerClientCertAsyncResult listenerClientCertAsyncResult = null;
		if (m_SslStatus != SslStatus.Insecure)
		{
			uint num = 1500u;
			listenerClientCertAsyncResult = new ListenerClientCertAsyncResult(this, state, requestCallback, num);
			try
			{
				while (true)
				{
					uint num2 = 0u;
					uint num3 = UnsafeNclNativeMethods.HttpApi.HttpReceiveClientCertificate(HttpListenerContext.RequestQueueHandle, m_ConnectionId, 0u, listenerClientCertAsyncResult.RequestBlob, num, &num2, listenerClientCertAsyncResult.NativeOverlapped);
					switch (num3)
					{
					case 234u:
						break;
					default:
						throw new HttpListenerException((int)num3);
					case 0u:
					case 997u:
						if (num3 == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
						{
							listenerClientCertAsyncResult.IOCompleted(num3, num2);
						}
						goto end_IL_0056;
					}
					UnsafeNclNativeMethods.HttpApi.HTTP_SSL_CLIENT_CERT_INFO* requestBlob = listenerClientCertAsyncResult.RequestBlob;
					num = num2 + requestBlob->CertEncodedSize;
					listenerClientCertAsyncResult.Reset(num);
					continue;
					end_IL_0056:
					break;
				}
			}
			catch
			{
				listenerClientCertAsyncResult?.InternalCleanup();
				throw;
			}
		}
		else
		{
			listenerClientCertAsyncResult = new ListenerClientCertAsyncResult(this, state, requestCallback, 0u);
			listenerClientCertAsyncResult.InvokeCallback();
		}
		return listenerClientCertAsyncResult;
	}

	private unsafe void ProcessClientCertificate()
	{
		if (m_ClientCertState == ListenerClientCertState.InProgress)
		{
			throw new InvalidOperationException(SR.GetString("net_listener_callinprogress", "GetClientCertificate()/BeginGetClientCertificate()"));
		}
		m_ClientCertState = ListenerClientCertState.InProgress;
		if (m_SslStatus != SslStatus.Insecure)
		{
			uint num = 1500u;
			while (true)
			{
				byte[] array = new byte[checked((int)num)];
				fixed (byte* ptr = array)
				{
					UnsafeNclNativeMethods.HttpApi.HTTP_SSL_CLIENT_CERT_INFO* ptr2 = (UnsafeNclNativeMethods.HttpApi.HTTP_SSL_CLIENT_CERT_INFO*)ptr;
					uint num2 = 0u;
					switch (UnsafeNclNativeMethods.HttpApi.HttpReceiveClientCertificate(HttpListenerContext.RequestQueueHandle, m_ConnectionId, 0u, ptr2, num, &num2, null))
					{
					case 234u:
						num = num2 + ptr2->CertEncodedSize;
						continue;
					case 0u:
						if (ptr2 == null)
						{
							break;
						}
						if (ptr2->pCertEncoded != null)
						{
							try
							{
								byte[] array2 = new byte[ptr2->CertEncodedSize];
								Marshal.Copy((IntPtr)ptr2->pCertEncoded, array2, 0, array2.Length);
								m_ClientCertificate = new X509Certificate2(array2);
							}
							catch (CryptographicException)
							{
							}
							catch (SecurityException)
							{
							}
						}
						m_ClientCertificateError = (int)ptr2->CertFlags;
						break;
					}
				}
				break;
			}
		}
		m_ClientCertState = ListenerClientCertState.Completed;
	}

	private string GetKnownHeader(HttpRequestHeader header)
	{
		return UnsafeNclNativeMethods.HttpApi.GetKnownHeader(RequestBuffer, OriginalBlobAddress, (int)header);
	}

	internal ChannelBinding GetChannelBinding()
	{
		return HttpListenerContext.Listener.GetChannelBindingFromTls(m_ConnectionId);
	}

	internal IEnumerable<TokenBinding> GetTlsTokenBindings()
	{
		if (Volatile.Read(ref m_TokenBindings) == null)
		{
			lock (m_Lock)
			{
				if (Volatile.Read(ref m_TokenBindings) == null)
				{
					if (UnsafeNclNativeMethods.TokenBindingOSHelper.SupportsTokenBinding)
					{
						ProcessTlsTokenBindings();
					}
					else
					{
						m_TokenBindings = new List<TokenBinding>();
					}
				}
			}
		}
		if (m_TokenBindingVerifyMessageStatus != 0)
		{
			throw new HttpListenerException(m_TokenBindingVerifyMessageStatus);
		}
		return m_TokenBindings.AsReadOnly();
	}

	private unsafe void ProcessTlsTokenBindings()
	{
		if (m_TokenBindings != null)
		{
			return;
		}
		m_TokenBindings = new List<TokenBinding>();
		UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_TOKEN_BINDING_INFO* tlsTokenBindingRequestInfo = UnsafeNclNativeMethods.HttpApi.GetTlsTokenBindingRequestInfo(RequestBuffer, OriginalBlobAddress);
		UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_TOKEN_BINDING_INFO_V1* ptr = null;
		bool flag = false;
		if (tlsTokenBindingRequestInfo == null)
		{
			ptr = UnsafeNclNativeMethods.HttpApi.GetTlsTokenBindingRequestInfo_V1(RequestBuffer, OriginalBlobAddress);
			flag = true;
		}
		if (tlsTokenBindingRequestInfo == null && ptr == null)
		{
			return;
		}
		UnsafeNclNativeMethods.HttpApi.HeapAllocHandle resultList = null;
		m_TokenBindingVerifyMessageStatus = -1;
		fixed (byte* requestBuffer = RequestBuffer)
		{
			UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_V2* ptr2 = (UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_V2*)requestBuffer;
			long num = requestBuffer - (byte*)(void*)OriginalBlobAddress;
			if (flag && ptr != null)
			{
				m_TokenBindingVerifyMessageStatus = UnsafeNclNativeMethods.HttpApi.TokenBindingVerifyMessage_V1(ptr->TokenBinding + num, ptr->TokenBindingSize, (IntPtr)((byte*)(void*)ptr->KeyType + num), ptr->TlsUnique + num, ptr->TlsUniqueSize, out resultList);
			}
			else
			{
				m_TokenBindingVerifyMessageStatus = UnsafeNclNativeMethods.HttpApi.TokenBindingVerifyMessage(tlsTokenBindingRequestInfo->TokenBinding + num, tlsTokenBindingRequestInfo->TokenBindingSize, tlsTokenBindingRequestInfo->KeyType, tlsTokenBindingRequestInfo->TlsUnique + num, tlsTokenBindingRequestInfo->TlsUniqueSize, out resultList);
			}
		}
		if (m_TokenBindingVerifyMessageStatus != 0)
		{
			throw new HttpListenerException(m_TokenBindingVerifyMessageStatus);
		}
		using (resultList)
		{
			if (flag)
			{
				GenerateTokenBindings_V1(resultList);
			}
			else
			{
				GenerateTokenBindings(resultList);
			}
		}
	}

	private unsafe void GenerateTokenBindings(UnsafeNclNativeMethods.HttpApi.HeapAllocHandle handle)
	{
		UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_LIST* ptr = (UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_LIST*)(void*)handle.DangerousGetHandle();
		for (int i = 0; i < ptr->resultCount; i++)
		{
			UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_DATA* ptr2 = ptr->resultData + i;
			if (ptr2 != null)
			{
				byte[] array = new byte[ptr2->identifierSize];
				Marshal.Copy((IntPtr)ptr2->identifierData, array, 0, array.Length);
				if (ptr2->bindingType == UnsafeNclNativeMethods.HttpApi.TOKENBINDING_TYPE.TOKENBINDING_TYPE_PROVIDED)
				{
					m_TokenBindings.Add(new TokenBinding(TokenBindingType.Provided, array));
				}
				else if (ptr2->bindingType == UnsafeNclNativeMethods.HttpApi.TOKENBINDING_TYPE.TOKENBINDING_TYPE_REFERRED)
				{
					m_TokenBindings.Add(new TokenBinding(TokenBindingType.Referred, array));
				}
			}
		}
	}

	private unsafe void GenerateTokenBindings_V1(UnsafeNclNativeMethods.HttpApi.HeapAllocHandle handle)
	{
		UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_LIST_V1* ptr = (UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_LIST_V1*)(void*)handle.DangerousGetHandle();
		for (int i = 0; i < ptr->resultCount; i++)
		{
			UnsafeNclNativeMethods.HttpApi.TOKENBINDING_RESULT_DATA_V1* ptr2 = ptr->resultData + i;
			if (ptr2 != null)
			{
				byte[] array = new byte[ptr2->identifierSize - 1];
				Marshal.Copy((IntPtr)(&ptr2->identifierData->hashAlgorithm), array, 0, array.Length);
				if (ptr2->identifierData->bindingType == UnsafeNclNativeMethods.HttpApi.TOKENBINDING_TYPE.TOKENBINDING_TYPE_PROVIDED)
				{
					m_TokenBindings.Add(new TokenBinding(TokenBindingType.Provided, array));
				}
				else if (ptr2->identifierData->bindingType == UnsafeNclNativeMethods.HttpApi.TOKENBINDING_TYPE.TOKENBINDING_TYPE_REFERRED)
				{
					m_TokenBindings.Add(new TokenBinding(TokenBindingType.Referred, array));
				}
			}
		}
	}

	internal void CheckDisposed()
	{
		if (m_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}
}
