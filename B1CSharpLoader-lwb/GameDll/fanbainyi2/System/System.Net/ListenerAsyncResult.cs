using System.Threading;

namespace System.Net;

internal class ListenerAsyncResult : LazyAsyncResult
{
	private unsafe static readonly IOCompletionCallback s_IOCallback = WaitCallback;

	private AsyncRequestContext m_RequestContext;

	internal static IOCompletionCallback IOCallback => s_IOCallback;

	internal ListenerAsyncResult(object asyncObject, object userState, AsyncCallback callback)
		: base(asyncObject, userState, callback)
	{
		m_RequestContext = new AsyncRequestContext(this);
	}

	private unsafe static void IOCompleted(ListenerAsyncResult asyncResult, uint errorCode, uint numBytes)
	{
		object obj = null;
		try
		{
			if (errorCode != 0 && errorCode != 234)
			{
				asyncResult.ErrorCode = (int)errorCode;
				obj = new HttpListenerException((int)errorCode);
			}
			else
			{
				HttpListener httpListener = asyncResult.AsyncObject as HttpListener;
				if (errorCode == 0)
				{
					bool stoleBlob = false;
					try
					{
						if (httpListener.ValidateRequest(asyncResult.m_RequestContext))
						{
							obj = httpListener.HandleAuthentication(asyncResult.m_RequestContext, out stoleBlob);
						}
					}
					finally
					{
						if (stoleBlob)
						{
							asyncResult.m_RequestContext = ((obj == null) ? new AsyncRequestContext(asyncResult) : null);
						}
						else
						{
							asyncResult.m_RequestContext.Reset(0uL, 0u);
						}
					}
				}
				else
				{
					asyncResult.m_RequestContext.Reset(asyncResult.m_RequestContext.RequestBlob->RequestId, numBytes);
				}
				if (obj == null)
				{
					uint num = asyncResult.QueueBeginGetContext();
					if (num != 0 && num != 997)
					{
						obj = new HttpListenerException((int)num);
					}
				}
				if (obj == null)
				{
					return;
				}
			}
		}
		catch (Exception ex)
		{
			if (NclUtilities.IsFatal(ex))
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.HttpListener, ValidationHelper.HashString(asyncResult), "IOCompleted", ex.ToString());
			}
			obj = ex;
		}
		asyncResult.InvokeCallback(obj);
	}

	private unsafe static void WaitCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(nativeOverlapped);
		ListenerAsyncResult asyncResult = (ListenerAsyncResult)overlapped.AsyncResult;
		IOCompleted(asyncResult, errorCode, numBytes);
	}

	internal unsafe uint QueueBeginGetContext()
	{
		uint num = 0u;
		while (true)
		{
			(base.AsyncObject as HttpListener).EnsureBoundHandle();
			uint num2 = 0u;
			num = UnsafeNclNativeMethods.HttpApi.HttpReceiveHttpRequest((base.AsyncObject as HttpListener).RequestQueueHandle, m_RequestContext.RequestBlob->RequestId, 1u, m_RequestContext.RequestBlob, m_RequestContext.Size, &num2, m_RequestContext.NativeOverlapped);
			if (num == 87 && m_RequestContext.RequestBlob->RequestId != 0L)
			{
				m_RequestContext.RequestBlob->RequestId = 0uL;
				continue;
			}
			switch (num)
			{
			case 234u:
				m_RequestContext.Reset(m_RequestContext.RequestBlob->RequestId, num2);
				continue;
			case 0u:
				if (HttpListener.SkipIOCPCallbackOnSuccess)
				{
					IOCompleted(this, num, num2);
				}
				break;
			}
			break;
		}
		return num;
	}

	protected override void Cleanup()
	{
		if (m_RequestContext != null)
		{
			m_RequestContext.ReleasePins();
			m_RequestContext.Close();
		}
		base.Cleanup();
	}
}
