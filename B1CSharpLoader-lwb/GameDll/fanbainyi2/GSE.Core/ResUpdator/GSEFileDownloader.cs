using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using b1;
using b1.GSFile;

namespace ResUpdator;

public class GSEFileDownloader : IDisposable
{
	public delegate void DownloaderCallback();

	public enum State
	{
		None,
		Downloading,
		LostConnection,
		Failed,
		Done
	}

	private const int MAX_STRING_RESPONSE_LEN = 10240;

	private const int DEFAULT_RETRY_COUNT = 3;

	public const int ErrMainFileCantOpen = 22001;

	public const int ErrMainFileCantWrite = 22002;

	public const int ErrMainWebException = 22003;

	public const int ErrMainHttpTimeout = 22004;

	public const int ErrMainHttpDNSErr = 22005;

	public const int ErrMainIOErr = 22006;

	public bool canResume;

	public int mainErrorCode;

	public int subErrorCode;

	protected string mPostParam;

	protected string mLocalPath;

	protected string mStringResponse = "";

	protected int mRetryCount = 3;

	protected State mState;

	protected bool mAbort;

	protected double mProgress;

	private DateTime lastSetReadSizeTime = DateTime.UtcNow;

	private float mTimeout = 30f;

	protected static bool sInit;

	protected static bool sIsDebug;

	public string mUrl { get; protected set; }

	public string errorMsg { get; protected set; }

	public long mContentSize { get; private set; }

	public long mReadSize { get; set; }

	public static long s_TotleReadSize { get; private set; }

	public static double s_TotalElapseTime { get; private set; }

	public static float s_DownloadSpeed { get; private set; }

	public static void ResetDownloadSpeed()
	{
		s_TotleReadSize = 0L;
		s_TotalElapseTime = 0.0;
		s_DownloadSpeed = 0f;
	}

	private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	public string GetFilePath()
	{
		return mLocalPath;
	}

	protected void SetFilePath(string value)
	{
		mLocalPath = value;
	}

	protected static void InitHttps()
	{
		if (!sInit)
		{
			sInit = true;
			ServicePointManager.DefaultConnectionLimit = 50;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
			ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
		}
	}

	public void StartSync(string url, string localpath)
	{
		InitHttps();
		errorMsg = "";
		mReadSize = 0L;
		SetTimeout(30f);
		SetRetryCount(3);
		mAbort = false;
		mState = State.None;
		mUrl = url;
		mPostParam = "";
		mLocalPath = localpath;
		mAbort = false;
		ProcDownload(this);
	}

	public void Start(string url, string localpath)
	{
		InitHttps();
		errorMsg = "";
		mReadSize = 0L;
		SetTimeout(30f);
		SetRetryCount(3);
		mAbort = false;
		mState = State.None;
		mUrl = url;
		mPostParam = "";
		mLocalPath = localpath;
		mAbort = false;
		ThreadPool.QueueUserWorkItem(ProcDownload, this);
	}

	public void StartGetString(string url)
	{
		InitHttps();
		SetTimeout(16f);
		SetRetryCount(2);
		mAbort = false;
		mState = State.None;
		mUrl = url;
		mPostParam = "";
		mLocalPath = "";
		mAbort = false;
		ThreadPool.QueueUserWorkItem(ProcDownload, this);
	}

	public void StartPost(string url, string postParam)
	{
		InitHttps();
		SetTimeout(mTimeout);
		SetRetryCount(1);
		mAbort = false;
		mState = State.None;
		mUrl = url;
		mPostParam = postParam;
		mLocalPath = "";
		mAbort = false;
		ThreadPool.QueueUserWorkItem(ProcDownload, this);
	}

	public void SetTimeout(float timeout)
	{
		mTimeout = timeout;
	}

	public void Abort()
	{
		lock (this)
		{
			mAbort = true;
		}
	}

	public void SetRetryCount(int retryCount)
	{
		mRetryCount = retryCount;
	}

	protected void SetStateSync(State state)
	{
		lock (this)
		{
			mState = state;
		}
	}

	private void SetContentSizeSync(long contentSize)
	{
		lock (this)
		{
			mContentSize = contentSize;
		}
	}

	private void SetReadSizeSync(long readsize)
	{
		lock (this)
		{
			TimeSpan timeSpan = DateTime.UtcNow - lastSetReadSizeTime;
			lastSetReadSizeTime = DateTime.UtcNow;
			s_TotleReadSize += readsize - mReadSize;
			s_TotalElapseTime += timeSpan.TotalSeconds;
			s_DownloadSpeed = (float)((double)s_TotleReadSize / s_TotalElapseTime / 1000.0);
			mReadSize = readsize;
			if (mContentSize > 0)
			{
				mProgress = (double)mReadSize / (double)mContentSize;
			}
		}
	}

	private void OnWebException(WebException e)
	{
		mainErrorCode = 22003;
		subErrorCode = (int)e.Status;
		if (e.Status == WebExceptionStatus.NameResolutionFailure)
		{
			mainErrorCode = 22005;
		}
		else if (e.Status == WebExceptionStatus.Timeout)
		{
			mainErrorCode = 22004;
		}
		BGW_LogUtil.LogError("fd OnWebException " + mUrl);
		errorMsg = "(" + mainErrorCode + "-" + subErrorCode + ")";
	}

	private void OnIOException(IOException e)
	{
		mainErrorCode = 22006;
		BGW_LogUtil.LogError("fd OnIOException");
		errorMsg = "(" + mainErrorCode + ")";
	}

	public static void ProcDownload(object state)
	{
		GSEFileDownloader gSEFileDownloader = (GSEFileDownloader)state;
		int num = gSEFileDownloader.mRetryCount;
		bool flag = false;
		string requestUriString = gSEFileDownloader.mUrl;
		while (!flag && num > 0)
		{
			gSEFileDownloader.errorMsg = "";
			_ = sIsDebug;
			num--;
			WebResponse webResponse = null;
			WebRequest webRequest = null;
			try
			{
				bool flag2 = gSEFileDownloader.mPostParam.Length > 0;
				int num2 = 0;
				if (gSEFileDownloader.mLocalPath.Length > 0)
				{
					GSEFileUtil.EnsureFileWritable(gSEFileDownloader.mLocalPath);
					if (!flag2 && gSEFileDownloader.canResume && File.Exists(gSEFileDownloader.mLocalPath))
					{
						num2 = (int)new FileInfo(gSEFileDownloader.mLocalPath).Length;
					}
				}
				GC.Collect();
				_ = sIsDebug;
				gSEFileDownloader.SetStateSync(State.Downloading);
				webRequest = WebRequest.Create(requestUriString);
				if (num2 > 0)
				{
					_ = sIsDebug;
					((HttpWebRequest)webRequest).AddRange(num2);
				}
				webRequest.Timeout = (int)(gSEFileDownloader.mTimeout * 1000f);
				((HttpWebRequest)webRequest).ReadWriteTimeout = (int)(gSEFileDownloader.mTimeout * 1000f);
				((HttpWebRequest)webRequest).KeepAlive = false;
				_ = sIsDebug;
				if (flag2)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(gSEFileDownloader.mPostParam);
					webRequest.Method = "POST";
					webRequest.ContentType = "application/x-www-form-urlencoded";
					webRequest.ContentLength = bytes.Length;
					using Stream stream = webRequest.GetRequestStream();
					if (stream.CanWrite)
					{
						for (int i = 0; i < bytes.Length; i++)
						{
							if (stream.CanWrite)
							{
								stream.WriteByte(bytes[i]);
							}
						}
						stream.Close();
					}
				}
				_ = sIsDebug;
				webResponse = webRequest.GetResponse();
				long contentLength = webResponse.ContentLength;
				long num3 = 0L;
				gSEFileDownloader.SetContentSizeSync(contentLength);
				_ = sIsDebug;
				using (Stream stream2 = webResponse.GetResponseStream())
				{
					if (gSEFileDownloader.mLocalPath.Length > 0)
					{
						_ = sIsDebug;
						FileStream fileStream = null;
						try
						{
							fileStream = ((num2 <= 0) ? File.Create(gSEFileDownloader.mLocalPath) : new FileStream(gSEFileDownloader.mLocalPath, FileMode.Append, FileAccess.Write, FileShare.Write));
							_ = sIsDebug;
							byte[] buffer = new byte[10240];
							int num4 = 1;
							while (num4 > 0 && !gSEFileDownloader.mAbort)
							{
								if (!stream2.CanRead)
								{
									if (!sIsDebug)
									{
									}
									break;
								}
								if (!fileStream.CanWrite)
								{
									if (!sIsDebug)
									{
									}
									break;
								}
								num4 = stream2.Read(buffer, 0, 10240);
								num3 += num4;
								fileStream.Write(buffer, 0, num4);
								gSEFileDownloader.SetReadSizeSync(num3);
							}
							_ = sIsDebug;
							fileStream.Close();
						}
						catch (Exception ex)
						{
							gSEFileDownloader.errorMsg = ex.Message;
							BGW_LogUtil.LogError(ex.ToString());
							fileStream?.Close();
							if (ex is IOException)
							{
								throw ex;
							}
						}
					}
					else if (contentLength < 10240)
					{
						_ = sIsDebug;
						byte[] array = new byte[10240];
						byte[] array2 = new byte[10240];
						int num5 = 1;
						while (num5 > 0 && !gSEFileDownloader.mAbort)
						{
							num5 = stream2.Read(array, 0, 10240);
							Array.Copy(array, 0L, array2, num3, num5);
							num3 += num5;
							gSEFileDownloader.SetReadSizeSync(num3);
						}
						_ = sIsDebug;
						gSEFileDownloader.mStringResponse = Encoding.UTF8.GetString(array2);
					}
					else
					{
						_ = sIsDebug;
						gSEFileDownloader.mStringResponse = "response length too big = " + contentLength;
					}
				}
				_ = sIsDebug;
				if ((num3 < contentLength || gSEFileDownloader.errorMsg.Length > 0) && !gSEFileDownloader.mAbort)
				{
					gSEFileDownloader.SetStateSync(State.LostConnection);
					if (!sIsDebug)
					{
					}
				}
				else
				{
					gSEFileDownloader.SetStateSync(State.Done);
					flag = true;
					_ = sIsDebug;
				}
			}
			catch (Exception ex2)
			{
				if (ex2 is WebException)
				{
					gSEFileDownloader.OnWebException(ex2 as WebException);
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("Http Error for url:");
					stringBuilder.Append(gSEFileDownloader.mUrl);
					stringBuilder.Append("\n");
					stringBuilder.Append(ex2.ToString());
					BGW_LogUtil.LogError(stringBuilder.ToString());
					gSEFileDownloader.SetStateSync(State.Failed);
					if (File.Exists(gSEFileDownloader.mLocalPath))
					{
						GSEFileUtil.RemoveFile(gSEFileDownloader.mLocalPath);
					}
				}
				else if (ex2 is IOException)
				{
					gSEFileDownloader.OnIOException(ex2 as IOException);
					gSEFileDownloader.SetStateSync(State.Failed);
					if (File.Exists(gSEFileDownloader.mLocalPath))
					{
						GSEFileUtil.RemoveFile(gSEFileDownloader.mLocalPath);
					}
				}
				else
				{
					gSEFileDownloader.SetStateSync(State.Failed);
					if (File.Exists(gSEFileDownloader.mLocalPath))
					{
						GSEFileUtil.RemoveFile(gSEFileDownloader.mLocalPath);
					}
				}
			}
			finally
			{
				_ = sIsDebug;
				try
				{
					if (webResponse != null)
					{
						webResponse.Close();
						webResponse = null;
					}
					if (webRequest != null)
					{
						webRequest.Abort();
						webRequest = null;
					}
				}
				catch (Exception ex3)
				{
					BGW_LogUtil.LogError(ex3.ToString());
				}
				_ = sIsDebug;
			}
		}
		_ = sIsDebug;
		lock (gSEFileDownloader)
		{
		}
		_ = sIsDebug;
	}

	public bool HasError()
	{
		State state = GetState();
		if (state != State.Failed)
		{
			return state == State.LostConnection;
		}
		return true;
	}

	public bool IsDone()
	{
		return GetState() == State.Done;
	}

	public bool IsAvailable()
	{
		return GetState() != State.Downloading;
	}

	public State GetState()
	{
		State state = State.None;
		lock (this)
		{
			return mState;
		}
	}

	public double GetProgress()
	{
		double num = 0.0;
		lock (this)
		{
			return mProgress;
		}
	}

	public string GetStringResponse()
	{
		return mStringResponse;
	}

	public void Dispose()
	{
		mAbort = true;
	}
}
