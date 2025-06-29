using System.Threading;

namespace System.Net.Sockets;

internal abstract class MultipleConnectAsync
{
	private enum State
	{
		NotStarted,
		DnsQuery,
		ConnectAttempt,
		Completed,
		Canceled
	}

	protected SocketAsyncEventArgs userArgs;

	protected SocketAsyncEventArgs internalArgs;

	protected DnsEndPoint endPoint;

	protected IPAddress[] addressList;

	protected int nextAddress;

	private State state;

	private object lockObject = new object();

	public bool StartConnectAsync(SocketAsyncEventArgs args, DnsEndPoint endPoint)
	{
		lock (lockObject)
		{
			userArgs = args;
			this.endPoint = endPoint;
			if (state == State.Canceled)
			{
				SyncFail(new SocketException(SocketError.OperationAborted));
				return false;
			}
			state = State.DnsQuery;
			IAsyncResult asyncResult = Dns.BeginGetHostAddresses(endPoint.Host, DnsCallback, null);
			if (asyncResult.CompletedSynchronously)
			{
				return DoDnsCallback(asyncResult, sync: true);
			}
			return true;
		}
	}

	private void DnsCallback(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			DoDnsCallback(result, sync: false);
		}
	}

	private bool DoDnsCallback(IAsyncResult result, bool sync)
	{
		Exception ex = null;
		lock (lockObject)
		{
			if (state == State.Canceled)
			{
				return true;
			}
			try
			{
				addressList = Dns.EndGetHostAddresses(result);
			}
			catch (Exception ex2)
			{
				state = State.Completed;
				ex = ex2;
			}
			if (ex == null)
			{
				state = State.ConnectAttempt;
				internalArgs = new SocketAsyncEventArgs();
				internalArgs.Completed += InternalConnectCallback;
				internalArgs.SetBuffer(userArgs.Buffer, userArgs.Offset, userArgs.Count);
				ex = AttemptConnection();
				if (ex != null)
				{
					state = State.Completed;
				}
			}
		}
		if (ex != null)
		{
			return Fail(sync, ex);
		}
		return true;
	}

	private void InternalConnectCallback(object sender, SocketAsyncEventArgs args)
	{
		Exception ex = null;
		lock (lockObject)
		{
			if (state == State.Canceled)
			{
				ex = new SocketException(SocketError.OperationAborted);
			}
			else if (args.SocketError == SocketError.Success)
			{
				state = State.Completed;
			}
			else if (args.SocketError == SocketError.OperationAborted)
			{
				ex = new SocketException(SocketError.OperationAborted);
				state = State.Canceled;
			}
			else
			{
				SocketError socketError = args.SocketError;
				Exception ex2 = AttemptConnection();
				if (ex2 == null)
				{
					return;
				}
				ex = ((!(ex2 is SocketException { SocketErrorCode: SocketError.NoData })) ? ex2 : new SocketException(socketError));
				state = State.Completed;
			}
		}
		if (ex == null)
		{
			Succeed();
		}
		else
		{
			AsyncFail(ex);
		}
	}

	private Exception AttemptConnection()
	{
		try
		{
			Socket attemptSocket = null;
			IPAddress iPAddress = GetNextAddress(out attemptSocket);
			if (iPAddress == null)
			{
				return new SocketException(SocketError.NoData);
			}
			internalArgs.RemoteEndPoint = new IPEndPoint(iPAddress, endPoint.Port);
			if (!attemptSocket.ConnectAsync(internalArgs))
			{
				return new SocketException(internalArgs.SocketError);
			}
		}
		catch (ObjectDisposedException)
		{
			return new SocketException(SocketError.OperationAborted);
		}
		catch (Exception result)
		{
			return result;
		}
		return null;
	}

	protected abstract void OnSucceed();

	protected void Succeed()
	{
		OnSucceed();
		userArgs.FinishWrapperConnectSuccess(internalArgs.ConnectSocket, internalArgs.BytesTransferred, internalArgs.SocketFlags);
		internalArgs.Dispose();
	}

	protected abstract void OnFail(bool abortive);

	private bool Fail(bool sync, Exception e)
	{
		if (sync)
		{
			SyncFail(e);
			return false;
		}
		AsyncFail(e);
		return true;
	}

	private void SyncFail(Exception e)
	{
		OnFail(abortive: false);
		if (internalArgs != null)
		{
			internalArgs.Dispose();
		}
		if (e is SocketException exception)
		{
			userArgs.FinishConnectByNameSyncFailure(exception, 0, SocketFlags.None);
			return;
		}
		throw e;
	}

	private void AsyncFail(Exception e)
	{
		OnFail(abortive: false);
		if (internalArgs != null)
		{
			internalArgs.Dispose();
		}
		userArgs.FinishOperationAsyncFailure(e, 0, SocketFlags.None);
	}

	public void Cancel()
	{
		bool flag = false;
		lock (lockObject)
		{
			switch (state)
			{
			case State.NotStarted:
				flag = true;
				break;
			case State.DnsQuery:
				ThreadPool.QueueUserWorkItem(CallAsyncFail);
				flag = true;
				break;
			case State.ConnectAttempt:
				flag = true;
				break;
			}
			state = State.Canceled;
		}
		if (flag)
		{
			OnFail(abortive: true);
		}
	}

	private void CallAsyncFail(object ignored)
	{
		AsyncFail(new SocketException(SocketError.OperationAborted));
	}

	protected abstract IPAddress GetNextAddress(out Socket attemptSocket);
}
