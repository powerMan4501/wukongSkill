using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net;

public sealed class HttpListenerResponse : IDisposable
{
	private enum ResponseState
	{
		Created,
		ComputedHeaders,
		SentHeaders,
		Closed
	}

	private Encoding m_ContentEncoding;

	private CookieCollection m_Cookies;

	private string m_StatusDescription;

	private bool m_KeepAlive;

	private ResponseState m_ResponseState;

	private WebHeaderCollection m_WebHeaders;

	private HttpResponseStream m_ResponseStream;

	private long m_ContentLength;

	private BoundaryType m_BoundaryType;

	private UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE m_NativeResponse;

	private HttpListenerContext m_HttpContext;

	private static readonly int[] s_NoResponseBody = new int[5] { 100, 101, 204, 205, 304 };

	private HttpListenerContext HttpListenerContext => m_HttpContext;

	private HttpListenerRequest HttpListenerRequest => HttpListenerContext.Request;

	public Encoding ContentEncoding
	{
		get
		{
			return m_ContentEncoding;
		}
		set
		{
			m_ContentEncoding = value;
		}
	}

	public string ContentType
	{
		get
		{
			return Headers[HttpResponseHeader.ContentType];
		}
		set
		{
			CheckDisposed();
			if (string.IsNullOrEmpty(value))
			{
				Headers.Remove(HttpResponseHeader.ContentType);
			}
			else
			{
				Headers.Set(HttpResponseHeader.ContentType, value);
			}
		}
	}

	public Stream OutputStream
	{
		get
		{
			CheckDisposed();
			EnsureResponseStream();
			return m_ResponseStream;
		}
	}

	public string RedirectLocation
	{
		get
		{
			return Headers[HttpResponseHeader.Location];
		}
		set
		{
			CheckDisposed();
			if (string.IsNullOrEmpty(value))
			{
				Headers.Remove(HttpResponseHeader.Location);
			}
			else
			{
				Headers.Set(HttpResponseHeader.Location, value);
			}
		}
	}

	public int StatusCode
	{
		get
		{
			return m_NativeResponse.StatusCode;
		}
		set
		{
			CheckDisposed();
			if (value < 100 || value > 999)
			{
				throw new ProtocolViolationException(SR.GetString("net_invalidstatus"));
			}
			m_NativeResponse.StatusCode = (ushort)value;
		}
	}

	public string StatusDescription
	{
		get
		{
			if (m_StatusDescription == null)
			{
				m_StatusDescription = HttpStatusDescription.Get(StatusCode);
			}
			if (m_StatusDescription == null)
			{
				m_StatusDescription = string.Empty;
			}
			return m_StatusDescription;
		}
		set
		{
			CheckDisposed();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.Length; i++)
			{
				char c = (char)(0xFF & value[i]);
				if ((c <= '\u001f' && c != '\t') || c == '\u007f')
				{
					throw new ArgumentException(SR.GetString("net_WebHeaderInvalidControlChars"), "name");
				}
			}
			m_StatusDescription = value;
		}
	}

	public CookieCollection Cookies
	{
		get
		{
			if (m_Cookies == null)
			{
				m_Cookies = new CookieCollection(IsReadOnly: false);
			}
			return m_Cookies;
		}
		set
		{
			m_Cookies = value;
		}
	}

	public bool SendChunked
	{
		get
		{
			return EntitySendFormat == EntitySendFormat.Chunked;
		}
		set
		{
			if (value)
			{
				EntitySendFormat = EntitySendFormat.Chunked;
			}
			else
			{
				EntitySendFormat = EntitySendFormat.ContentLength;
			}
		}
	}

	internal EntitySendFormat EntitySendFormat
	{
		get
		{
			return (EntitySendFormat)m_BoundaryType;
		}
		set
		{
			CheckDisposed();
			if (m_ResponseState >= ResponseState.SentHeaders)
			{
				throw new InvalidOperationException(SR.GetString("net_rspsubmitted"));
			}
			if (value == EntitySendFormat.Chunked && HttpListenerRequest.ProtocolVersion.Minor == 0)
			{
				throw new ProtocolViolationException(SR.GetString("net_nochunkuploadonhttp10"));
			}
			m_BoundaryType = (BoundaryType)value;
			if (value != EntitySendFormat.ContentLength)
			{
				m_ContentLength = -1L;
			}
		}
	}

	public bool KeepAlive
	{
		get
		{
			return m_KeepAlive;
		}
		set
		{
			CheckDisposed();
			m_KeepAlive = value;
		}
	}

	public WebHeaderCollection Headers
	{
		get
		{
			return m_WebHeaders;
		}
		set
		{
			m_WebHeaders.Clear();
			string[] allKeys = value.AllKeys;
			foreach (string name in allKeys)
			{
				m_WebHeaders.Add(name, value[name]);
			}
		}
	}

	public long ContentLength64
	{
		get
		{
			return m_ContentLength;
		}
		set
		{
			CheckDisposed();
			if (m_ResponseState >= ResponseState.SentHeaders)
			{
				throw new InvalidOperationException(SR.GetString("net_rspsubmitted"));
			}
			if (value >= 0)
			{
				m_ContentLength = value;
				m_BoundaryType = BoundaryType.ContentLength;
				return;
			}
			throw new ArgumentOutOfRangeException("value", SR.GetString("net_clsmall"));
		}
	}

	public Version ProtocolVersion
	{
		get
		{
			return new Version(m_NativeResponse.Version.MajorVersion, m_NativeResponse.Version.MinorVersion);
		}
		set
		{
			CheckDisposed();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Major != 1 || (value.Minor != 0 && value.Minor != 1))
			{
				throw new ArgumentException(SR.GetString("net_wrongversion"), "value");
			}
			m_NativeResponse.Version.MajorVersion = (ushort)value.Major;
			m_NativeResponse.Version.MinorVersion = (ushort)value.Minor;
		}
	}

	internal BoundaryType BoundaryType => m_BoundaryType;

	internal bool SentHeaders => m_ResponseState >= ResponseState.SentHeaders;

	internal bool ComputedHeaders => m_ResponseState >= ResponseState.ComputedHeaders;

	internal HttpListenerResponse()
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, ".ctor", "");
		}
		m_NativeResponse = default(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE);
		m_WebHeaders = new WebHeaderCollection(WebHeaderCollectionType.HttpListenerResponse);
		m_BoundaryType = BoundaryType.None;
		m_NativeResponse.StatusCode = 200;
		m_NativeResponse.Version.MajorVersion = 1;
		m_NativeResponse.Version.MinorVersion = 1;
		m_KeepAlive = true;
		m_ResponseState = ResponseState.Created;
	}

	internal HttpListenerResponse(HttpListenerContext httpContext)
		: this()
	{
		if (Logging.On)
		{
			Logging.Associate(Logging.HttpListener, this, httpContext);
		}
		m_HttpContext = httpContext;
	}

	public void CopyFrom(HttpListenerResponse templateResponse)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "CopyFrom", "templateResponse#" + ValidationHelper.HashString(templateResponse));
		}
		m_NativeResponse = default(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE);
		m_ResponseState = ResponseState.Created;
		m_WebHeaders = templateResponse.m_WebHeaders;
		m_BoundaryType = templateResponse.m_BoundaryType;
		m_ContentLength = templateResponse.m_ContentLength;
		m_NativeResponse.StatusCode = templateResponse.m_NativeResponse.StatusCode;
		m_NativeResponse.Version.MajorVersion = templateResponse.m_NativeResponse.Version.MajorVersion;
		m_NativeResponse.Version.MinorVersion = templateResponse.m_NativeResponse.Version.MinorVersion;
		m_StatusDescription = templateResponse.m_StatusDescription;
		m_KeepAlive = templateResponse.m_KeepAlive;
	}

	private bool CanSendResponseBody(int responseCode)
	{
		for (int i = 0; i < s_NoResponseBody.Length; i++)
		{
			if (responseCode == s_NoResponseBody[i])
			{
				return false;
			}
		}
		return true;
	}

	public void AddHeader(string name, string value)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "AddHeader", " name=" + name + " value=" + value);
		}
		Headers.SetInternal(name, value);
	}

	public void AppendHeader(string name, string value)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "AppendHeader", " name=" + name + " value=" + value);
		}
		Headers.Add(name, value);
	}

	public void Redirect(string url)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "Redirect", " url=" + url);
		}
		Headers.SetInternal(HttpResponseHeader.Location, url);
		StatusCode = 302;
		StatusDescription = HttpStatusDescription.Get(StatusCode);
	}

	public void AppendCookie(Cookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "AppendCookie", " cookie#" + ValidationHelper.HashString(cookie));
		}
		Cookies.Add(cookie);
	}

	public void SetCookie(Cookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		Cookie cookie2 = cookie.Clone();
		int num = Cookies.InternalAdd(cookie2, isStrict: true);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, "SetCookie", " cookie#" + ValidationHelper.HashString(cookie));
		}
		if (num != 1)
		{
			throw new ArgumentException(SR.GetString("net_cookie_exists"), "cookie");
		}
	}

	public void Abort()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "abort", "");
		}
		try
		{
			if (m_ResponseState < ResponseState.Closed)
			{
				m_ResponseState = ResponseState.Closed;
				HttpListenerContext.Abort();
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "abort", "");
			}
		}
	}

	public void Close(byte[] responseEntity, bool willBlock)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Close", " responseEntity=" + ValidationHelper.HashString(responseEntity) + " willBlock=" + willBlock);
		}
		try
		{
			CheckDisposed();
			if (responseEntity == null)
			{
				throw new ArgumentNullException("responseEntity");
			}
			if (m_ResponseState < ResponseState.SentHeaders && m_BoundaryType != BoundaryType.Chunked)
			{
				ContentLength64 = responseEntity.Length;
			}
			EnsureResponseStream();
			if (willBlock)
			{
				try
				{
					m_ResponseStream.Write(responseEntity, 0, responseEntity.Length);
					return;
				}
				catch (Win32Exception)
				{
					return;
				}
				finally
				{
					m_ResponseStream.Close();
					m_ResponseState = ResponseState.Closed;
					HttpListenerContext.Close();
				}
			}
			m_ResponseStream.BeginWrite(responseEntity, 0, responseEntity.Length, NonBlockingCloseCallback, null);
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Close", "");
			}
		}
	}

	public void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Close", "");
		}
		try
		{
			((IDisposable)this).Dispose();
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Close", "");
			}
		}
	}

	private void Dispose(bool disposing)
	{
		if (m_ResponseState < ResponseState.Closed)
		{
			EnsureResponseStream();
			m_ResponseStream.Close();
			m_ResponseState = ResponseState.Closed;
			HttpListenerContext.Close();
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void EnsureResponseStream()
	{
		if (m_ResponseStream == null)
		{
			m_ResponseStream = new HttpResponseStream(HttpListenerContext);
		}
	}

	private void NonBlockingCloseCallback(IAsyncResult asyncResult)
	{
		try
		{
			m_ResponseStream.EndWrite(asyncResult);
		}
		catch (Win32Exception)
		{
		}
		finally
		{
			m_ResponseStream.Close();
			HttpListenerContext.Close();
			m_ResponseState = ResponseState.Closed;
		}
	}

	internal unsafe uint SendHeaders(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK* pDataChunk, HttpResponseStreamAsyncResult asyncResult, UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS flags, bool isWebSocketHandshake)
	{
		if (StatusCode == 401)
		{
			HttpListenerContext.SetAuthenticationHeaders();
		}
		if (Logging.On)
		{
			StringBuilder stringBuilder = new StringBuilder("HttpListenerResponse Headers:\n");
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
		m_ResponseState = ResponseState.SentHeaders;
		List<GCHandle> pinnedHeaders = SerializeHeaders(ref m_NativeResponse.Headers, isWebSocketHandshake);
		uint num;
		try
		{
			if (pDataChunk != null)
			{
				m_NativeResponse.EntityChunkCount = 1;
				m_NativeResponse.pEntityChunks = pDataChunk;
			}
			else if (asyncResult != null && asyncResult.pDataChunks != null)
			{
				m_NativeResponse.EntityChunkCount = asyncResult.dataChunkCount;
				m_NativeResponse.pEntityChunks = asyncResult.pDataChunks;
			}
			else
			{
				m_NativeResponse.EntityChunkCount = 0;
				m_NativeResponse.pEntityChunks = null;
			}
			uint numBytes = default(uint);
			if (StatusDescription.Length > 0)
			{
				byte[] array = new byte[WebHeaderCollection.HeaderEncoding.GetByteCount(StatusDescription)];
				fixed (byte* pReason = array)
				{
					m_NativeResponse.ReasonLength = (ushort)array.Length;
					WebHeaderCollection.HeaderEncoding.GetBytes(StatusDescription, 0, array.Length, array, 0);
					m_NativeResponse.pReason = (sbyte*)pReason;
					fixed (UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE* nativeResponse = &m_NativeResponse)
					{
						if (asyncResult != null)
						{
							HttpListenerContext.EnsureBoundHandle();
						}
						num = UnsafeNclNativeMethods.HttpApi.HttpSendHttpResponse(HttpListenerContext.RequestQueueHandle, HttpListenerRequest.RequestId, (uint)flags, nativeResponse, null, &numBytes, SafeLocalFree.Zero, 0u, (asyncResult == null) ? null : asyncResult.m_pOverlapped, null);
						if (asyncResult != null && num == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
						{
							asyncResult.IOCompleted(num, numBytes);
						}
					}
				}
			}
			else
			{
				fixed (UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE* nativeResponse2 = &m_NativeResponse)
				{
					if (asyncResult != null)
					{
						HttpListenerContext.EnsureBoundHandle();
					}
					num = UnsafeNclNativeMethods.HttpApi.HttpSendHttpResponse(HttpListenerContext.RequestQueueHandle, HttpListenerRequest.RequestId, (uint)flags, nativeResponse2, null, &numBytes, SafeLocalFree.Zero, 0u, (asyncResult == null) ? null : asyncResult.m_pOverlapped, null);
					if (asyncResult != null && num == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
					{
						asyncResult.IOCompleted(num, numBytes);
					}
				}
			}
		}
		finally
		{
			FreePinnedHeaders(pinnedHeaders);
		}
		return num;
	}

	internal void ComputeCookies()
	{
		if (m_Cookies == null)
		{
			return;
		}
		string text = null;
		string text2 = null;
		for (int i = 0; i < m_Cookies.Count; i++)
		{
			Cookie cookie = m_Cookies[i];
			string text3 = cookie.ToServerString();
			if (text3 != null && text3.Length != 0)
			{
				if (cookie.Variant == CookieVariant.Rfc2965 || (HttpListenerContext.PromoteCookiesToRfc2965 && cookie.Variant == CookieVariant.Rfc2109))
				{
					text = ((text == null) ? text3 : (text + ", " + text3));
				}
				else
				{
					text2 = ((text2 == null) ? text3 : (text2 + ", " + text3));
				}
			}
		}
		if (!string.IsNullOrEmpty(text2))
		{
			Headers.Set(HttpResponseHeader.SetCookie, text2);
			if (string.IsNullOrEmpty(text))
			{
				Headers.Remove("Set-Cookie2");
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			Headers.Set("Set-Cookie2", text);
			if (string.IsNullOrEmpty(text2))
			{
				Headers.Remove("Set-Cookie");
			}
		}
	}

	internal UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS ComputeHeaders()
	{
		UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS hTTP_FLAGS = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE;
		m_ResponseState = ResponseState.ComputedHeaders;
		ComputeCoreHeaders();
		if (m_BoundaryType == BoundaryType.None)
		{
			if (HttpListenerRequest.ProtocolVersion.Minor == 0)
			{
				m_KeepAlive = false;
			}
			else
			{
				m_BoundaryType = BoundaryType.Chunked;
			}
			if (CanSendResponseBody(m_HttpContext.Response.StatusCode))
			{
				m_ContentLength = -1L;
			}
			else
			{
				ContentLength64 = 0L;
			}
		}
		if (m_BoundaryType == BoundaryType.ContentLength)
		{
			Headers.SetInternal(HttpResponseHeader.ContentLength, m_ContentLength.ToString("D", NumberFormatInfo.InvariantInfo));
			if (m_ContentLength == 0L)
			{
				hTTP_FLAGS = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE;
			}
		}
		else if (m_BoundaryType == BoundaryType.Chunked)
		{
			Headers.SetInternal(HttpResponseHeader.TransferEncoding, "chunked");
		}
		else if (m_BoundaryType == BoundaryType.None)
		{
			hTTP_FLAGS = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE;
		}
		else
		{
			m_KeepAlive = false;
		}
		if (!m_KeepAlive)
		{
			Headers.Add(HttpResponseHeader.Connection, "close");
			if (hTTP_FLAGS == UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE)
			{
				hTTP_FLAGS = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY;
			}
		}
		else if (HttpListenerRequest.ProtocolVersion.Minor == 0)
		{
			Headers.SetInternal(HttpResponseHeader.KeepAlive, "true");
		}
		return hTTP_FLAGS;
	}

	internal void ComputeCoreHeaders()
	{
		if (HttpListenerContext.MutualAuthentication != null && HttpListenerContext.MutualAuthentication.Length > 0)
		{
			Headers.SetInternal(HttpResponseHeader.WwwAuthenticate, HttpListenerContext.MutualAuthentication);
		}
		ComputeCookies();
	}

	private unsafe List<GCHandle> SerializeHeaders(ref UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADERS headers, bool isWebSocketHandshake)
	{
		UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER[] array = null;
		if (Headers.Count == 0)
		{
			return null;
		}
		byte[] array2 = null;
		List<GCHandle> list = new List<GCHandle>();
		int num = 0;
		for (int i = 0; i < Headers.Count; i++)
		{
			string key = Headers.GetKey(i);
			int num2 = UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID.IndexOfKnownHeader(key);
			if (num2 == 27 || (isWebSocketHandshake && num2 == 1))
			{
				num2 = -1;
			}
			if (num2 == -1)
			{
				string[] values = Headers.GetValues(i);
				num += values.Length;
			}
		}
		try
		{
			fixed (UnsafeNclNativeMethods.HttpApi.HTTP_KNOWN_HEADER* knownHeaders = &headers.KnownHeaders)
			{
				for (int j = 0; j < Headers.Count; j++)
				{
					string key = Headers.GetKey(j);
					string text = Headers.Get(j);
					int num2 = UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID.IndexOfKnownHeader(key);
					if (num2 == 27 || (isWebSocketHandshake && num2 == 1))
					{
						num2 = -1;
					}
					if (num2 == -1)
					{
						if (array == null)
						{
							array = new UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER[num];
							GCHandle item = GCHandle.Alloc(array, GCHandleType.Pinned);
							list.Add(item);
							headers.pUnknownHeaders = (UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER*)(void*)item.AddrOfPinnedObject();
						}
						string[] values2 = Headers.GetValues(j);
						for (int k = 0; k < values2.Length; k++)
						{
							array2 = new byte[WebHeaderCollection.HeaderEncoding.GetByteCount(key)];
							array[headers.UnknownHeaderCount].NameLength = (ushort)array2.Length;
							WebHeaderCollection.HeaderEncoding.GetBytes(key, 0, array2.Length, array2, 0);
							GCHandle item = GCHandle.Alloc(array2, GCHandleType.Pinned);
							list.Add(item);
							array[headers.UnknownHeaderCount].pName = (sbyte*)(void*)item.AddrOfPinnedObject();
							text = values2[k];
							array2 = new byte[WebHeaderCollection.HeaderEncoding.GetByteCount(text)];
							array[headers.UnknownHeaderCount].RawValueLength = (ushort)array2.Length;
							WebHeaderCollection.HeaderEncoding.GetBytes(text, 0, array2.Length, array2, 0);
							item = GCHandle.Alloc(array2, GCHandleType.Pinned);
							list.Add(item);
							array[headers.UnknownHeaderCount].pRawValue = (sbyte*)(void*)item.AddrOfPinnedObject();
							headers.UnknownHeaderCount++;
						}
					}
					else if (text != null)
					{
						array2 = new byte[WebHeaderCollection.HeaderEncoding.GetByteCount(text)];
						knownHeaders[num2].RawValueLength = (ushort)array2.Length;
						WebHeaderCollection.HeaderEncoding.GetBytes(text, 0, array2.Length, array2, 0);
						GCHandle item = GCHandle.Alloc(array2, GCHandleType.Pinned);
						list.Add(item);
						knownHeaders[num2].pRawValue = (sbyte*)(void*)item.AddrOfPinnedObject();
					}
				}
				return list;
			}
		}
		catch
		{
			FreePinnedHeaders(list);
			throw;
		}
	}

	private void FreePinnedHeaders(List<GCHandle> pinnedHeaders)
	{
		if (pinnedHeaders == null)
		{
			return;
		}
		foreach (GCHandle pinnedHeader in pinnedHeaders)
		{
			if (pinnedHeader.IsAllocated)
			{
				pinnedHeader.Free();
			}
		}
	}

	private void CheckDisposed()
	{
		if (m_ResponseState >= ResponseState.Closed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	internal void CancelLastWrite(CriticalHandle requestQueueHandle)
	{
		if (m_ResponseStream != null)
		{
			m_ResponseStream.CancelLastWrite(requestQueueHandle);
		}
	}
}
