using System.IO;

namespace System.Net;

public class FtpWebResponse : WebResponse, IDisposable
{
	internal class EmptyStream : MemoryStream
	{
		internal EmptyStream()
			: base(new byte[0], writable: false)
		{
		}
	}

	internal Stream m_ResponseStream;

	private long m_ContentLength;

	private Uri m_ResponseUri;

	private FtpStatusCode m_StatusCode;

	private string m_StatusLine;

	private WebHeaderCollection m_FtpRequestHeaders;

	private HttpWebResponse m_HttpWebResponse;

	private DateTime m_LastModified;

	private string m_BannerMessage;

	private string m_WelcomeMessage;

	private string m_ExitMessage;

	public override long ContentLength
	{
		get
		{
			if (HttpProxyMode)
			{
				return m_HttpWebResponse.ContentLength;
			}
			return m_ContentLength;
		}
	}

	public override WebHeaderCollection Headers
	{
		get
		{
			if (HttpProxyMode)
			{
				return m_HttpWebResponse.Headers;
			}
			if (m_FtpRequestHeaders == null)
			{
				lock (this)
				{
					if (m_FtpRequestHeaders == null)
					{
						m_FtpRequestHeaders = new WebHeaderCollection(WebHeaderCollectionType.FtpWebResponse);
					}
				}
			}
			return m_FtpRequestHeaders;
		}
	}

	public override bool SupportsHeaders => true;

	public override Uri ResponseUri
	{
		get
		{
			if (HttpProxyMode)
			{
				return m_HttpWebResponse.ResponseUri;
			}
			return m_ResponseUri;
		}
	}

	public FtpStatusCode StatusCode
	{
		get
		{
			if (HttpProxyMode)
			{
				return (FtpStatusCode)m_HttpWebResponse.StatusCode;
			}
			return m_StatusCode;
		}
	}

	public string StatusDescription
	{
		get
		{
			if (HttpProxyMode)
			{
				return m_HttpWebResponse.StatusDescription;
			}
			return m_StatusLine;
		}
	}

	public DateTime LastModified
	{
		get
		{
			if (HttpProxyMode)
			{
				return m_HttpWebResponse.LastModified;
			}
			return m_LastModified;
		}
	}

	public string BannerMessage => m_BannerMessage;

	public string WelcomeMessage => m_WelcomeMessage;

	public string ExitMessage => m_ExitMessage;

	private bool HttpProxyMode => m_HttpWebResponse != null;

	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
	{
		m_ResponseStream = responseStream;
		if (responseStream == null && contentLength < 0)
		{
			contentLength = 0L;
		}
		m_ContentLength = contentLength;
		m_ResponseUri = responseUri;
		m_StatusCode = statusCode;
		m_StatusLine = statusLine;
		m_LastModified = lastModified;
		m_BannerMessage = bannerMessage;
		m_WelcomeMessage = welcomeMessage;
		m_ExitMessage = exitMessage;
	}

	internal FtpWebResponse(HttpWebResponse httpWebResponse)
	{
		m_HttpWebResponse = httpWebResponse;
		base.InternalSetFromCache = m_HttpWebResponse.IsFromCache;
		base.InternalSetIsCacheFresh = m_HttpWebResponse.IsCacheFresh;
	}

	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
	{
		m_StatusCode = statusCode;
		m_StatusLine = statusLine;
		m_ExitMessage = exitMessage;
	}

	public override Stream GetResponseStream()
	{
		Stream stream = null;
		if (HttpProxyMode)
		{
			return m_HttpWebResponse.GetResponseStream();
		}
		if (m_ResponseStream != null)
		{
			return m_ResponseStream;
		}
		return m_ResponseStream = new EmptyStream();
	}

	internal void SetResponseStream(Stream stream)
	{
		if (stream != null && stream != Stream.Null && !(stream is EmptyStream))
		{
			m_ResponseStream = stream;
		}
	}

	public override void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Close", "");
		}
		if (HttpProxyMode)
		{
			m_HttpWebResponse.Close();
		}
		else
		{
			m_ResponseStream?.Close();
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "Close", "");
		}
	}

	internal void SetContentLength(long value)
	{
		if (!HttpProxyMode)
		{
			m_ContentLength = value;
		}
	}
}
