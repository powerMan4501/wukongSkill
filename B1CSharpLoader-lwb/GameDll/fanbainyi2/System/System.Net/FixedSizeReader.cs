using System.IO;

namespace System.Net;

internal class FixedSizeReader
{
	private static readonly AsyncCallback _ReadCallback = ReadCallback;

	private readonly Stream _Transport;

	private AsyncProtocolRequest _Request;

	private int _TotalRead;

	public FixedSizeReader(Stream transport)
	{
		_Transport = transport;
	}

	public int ReadPacket(byte[] buffer, int offset, int count)
	{
		int num = count;
		do
		{
			int num2 = _Transport.Read(buffer, offset, num);
			if (num2 == 0)
			{
				if (num != count)
				{
					throw new IOException(SR.GetString("net_io_eof"));
				}
				return 0;
			}
			num -= num2;
			offset += num2;
		}
		while (num != 0);
		return count;
	}

	public void AsyncReadPacket(AsyncProtocolRequest request)
	{
		_Request = request;
		_TotalRead = 0;
		StartReading();
	}

	private void StartReading()
	{
		int bytes;
		do
		{
			IAsyncResult asyncResult = _Transport.BeginRead(_Request.Buffer, _Request.Offset + _TotalRead, _Request.Count - _TotalRead, _ReadCallback, this);
			if (asyncResult.CompletedSynchronously)
			{
				bytes = _Transport.EndRead(asyncResult);
				continue;
			}
			break;
		}
		while (!CheckCompletionBeforeNextRead(bytes));
	}

	private bool CheckCompletionBeforeNextRead(int bytes)
	{
		if (bytes == 0)
		{
			if (_TotalRead == 0)
			{
				_Request.CompleteRequest(0);
				return true;
			}
			throw new IOException(SR.GetString("net_io_eof"));
		}
		if ((_TotalRead += bytes) == _Request.Count)
		{
			_Request.CompleteRequest(_Request.Count);
			return true;
		}
		return false;
	}

	private static void ReadCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		FixedSizeReader fixedSizeReader = (FixedSizeReader)transportResult.AsyncState;
		AsyncProtocolRequest request = fixedSizeReader._Request;
		try
		{
			int bytes = fixedSizeReader._Transport.EndRead(transportResult);
			if (!fixedSizeReader.CheckCompletionBeforeNextRead(bytes))
			{
				fixedSizeReader.StartReading();
			}
		}
		catch (Exception e)
		{
			if (request.IsUserCompleted)
			{
				throw;
			}
			request.CompleteWithError(e);
		}
	}
}
