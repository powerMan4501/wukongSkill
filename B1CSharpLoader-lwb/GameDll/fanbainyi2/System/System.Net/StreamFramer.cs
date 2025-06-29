using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace System.Net;

internal class StreamFramer
{
	private Stream m_Transport;

	private bool m_Eof;

	private FrameHeader m_WriteHeader = new FrameHeader();

	private FrameHeader m_CurReadHeader = new FrameHeader();

	private FrameHeader m_ReadVerifier = new FrameHeader(-1, -1, -1);

	private byte[] m_ReadHeaderBuffer;

	private byte[] m_WriteHeaderBuffer;

	private readonly AsyncCallback m_ReadFrameCallback;

	private readonly AsyncCallback m_BeginWriteCallback;

	private NetworkStream m_NetworkStream;

	public FrameHeader ReadHeader => m_CurReadHeader;

	public FrameHeader WriteHeader => m_WriteHeader;

	public Stream Transport => m_Transport;

	public StreamFramer(Stream Transport)
	{
		if (Transport == null || Transport == Stream.Null)
		{
			throw new ArgumentNullException("Transport");
		}
		m_Transport = Transport;
		if (m_Transport.GetType() == typeof(NetworkStream))
		{
			m_NetworkStream = Transport as NetworkStream;
		}
		m_ReadHeaderBuffer = new byte[m_CurReadHeader.Size];
		m_WriteHeaderBuffer = new byte[m_WriteHeader.Size];
		m_ReadFrameCallback = ReadFrameCallback;
		m_BeginWriteCallback = BeginWriteCallback;
	}

	public byte[] ReadMessage()
	{
		if (m_Eof)
		{
			return null;
		}
		int i = 0;
		byte[] readHeaderBuffer;
		int num;
		for (readHeaderBuffer = m_ReadHeaderBuffer; i < readHeaderBuffer.Length; i += num)
		{
			num = Transport.Read(readHeaderBuffer, i, readHeaderBuffer.Length - i);
			if (num == 0)
			{
				if (i == 0)
				{
					m_Eof = true;
					return null;
				}
				throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
			}
		}
		m_CurReadHeader.CopyFrom(readHeaderBuffer, 0, m_ReadVerifier);
		if (m_CurReadHeader.PayloadSize > m_CurReadHeader.MaxMessageSize)
		{
			throw new InvalidOperationException(SR.GetString("net_frame_size", m_CurReadHeader.MaxMessageSize.ToString(NumberFormatInfo.InvariantInfo), m_CurReadHeader.PayloadSize.ToString(NumberFormatInfo.InvariantInfo)));
		}
		readHeaderBuffer = new byte[m_CurReadHeader.PayloadSize];
		for (i = 0; i < readHeaderBuffer.Length; i += num)
		{
			num = Transport.Read(readHeaderBuffer, i, readHeaderBuffer.Length - i);
			if (num == 0)
			{
				throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
			}
		}
		return readHeaderBuffer;
	}

	public IAsyncResult BeginReadMessage(AsyncCallback asyncCallback, object stateObject)
	{
		WorkerAsyncResult workerAsyncResult;
		if (m_Eof)
		{
			workerAsyncResult = new WorkerAsyncResult(this, stateObject, asyncCallback, null, 0, 0);
			workerAsyncResult.InvokeCallback(-1);
			return workerAsyncResult;
		}
		workerAsyncResult = new WorkerAsyncResult(this, stateObject, asyncCallback, m_ReadHeaderBuffer, 0, m_ReadHeaderBuffer.Length);
		IAsyncResult asyncResult = Transport.BeginRead(m_ReadHeaderBuffer, 0, m_ReadHeaderBuffer.Length, m_ReadFrameCallback, workerAsyncResult);
		if (asyncResult.CompletedSynchronously)
		{
			ReadFrameComplete(asyncResult);
		}
		return workerAsyncResult;
	}

	private void ReadFrameCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		WorkerAsyncResult workerAsyncResult = (WorkerAsyncResult)transportResult.AsyncState;
		try
		{
			ReadFrameComplete(transportResult);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (!(ex is IOException))
			{
				ex = new IOException(SR.GetString("net_io_readfailure", ex.Message), ex);
			}
			workerAsyncResult.InvokeCallback(ex);
		}
	}

	private void ReadFrameComplete(IAsyncResult transportResult)
	{
		do
		{
			WorkerAsyncResult workerAsyncResult = (WorkerAsyncResult)transportResult.AsyncState;
			int num = Transport.EndRead(transportResult);
			workerAsyncResult.Offset += num;
			if (num <= 0)
			{
				object obj = null;
				obj = ((workerAsyncResult.HeaderDone || workerAsyncResult.Offset != 0) ? new IOException(SR.GetString("net_frame_read_io")) : ((object)(-1)));
				workerAsyncResult.InvokeCallback(obj);
				break;
			}
			if (workerAsyncResult.Offset >= workerAsyncResult.End)
			{
				if (workerAsyncResult.HeaderDone)
				{
					workerAsyncResult.HeaderDone = false;
					workerAsyncResult.InvokeCallback(workerAsyncResult.End);
					break;
				}
				workerAsyncResult.HeaderDone = true;
				m_CurReadHeader.CopyFrom(workerAsyncResult.Buffer, 0, m_ReadVerifier);
				int payloadSize = m_CurReadHeader.PayloadSize;
				if (payloadSize < 0)
				{
					workerAsyncResult.InvokeCallback(new IOException(SR.GetString("net_frame_read_size")));
				}
				if (payloadSize == 0)
				{
					workerAsyncResult.InvokeCallback(0);
					break;
				}
				if (payloadSize > m_CurReadHeader.MaxMessageSize)
				{
					throw new InvalidOperationException(SR.GetString("net_frame_size", m_CurReadHeader.MaxMessageSize.ToString(NumberFormatInfo.InvariantInfo), payloadSize.ToString(NumberFormatInfo.InvariantInfo)));
				}
				workerAsyncResult.End = (workerAsyncResult.Buffer = new byte[payloadSize]).Length;
				workerAsyncResult.Offset = 0;
			}
			transportResult = Transport.BeginRead(workerAsyncResult.Buffer, workerAsyncResult.Offset, workerAsyncResult.End - workerAsyncResult.Offset, m_ReadFrameCallback, workerAsyncResult);
		}
		while (transportResult.CompletedSynchronously);
	}

	public byte[] EndReadMessage(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is WorkerAsyncResult workerAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", typeof(WorkerAsyncResult).FullName), "asyncResult");
		}
		if (!workerAsyncResult.InternalPeekCompleted)
		{
			workerAsyncResult.InternalWaitForCompletion();
		}
		if (workerAsyncResult.Result is Exception)
		{
			throw (Exception)workerAsyncResult.Result;
		}
		switch ((int)workerAsyncResult.Result)
		{
		case -1:
			m_Eof = true;
			return null;
		case 0:
			return new byte[0];
		default:
			return workerAsyncResult.Buffer;
		}
	}

	public void WriteMessage(byte[] message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		m_WriteHeader.PayloadSize = message.Length;
		m_WriteHeader.CopyTo(m_WriteHeaderBuffer, 0);
		if (m_NetworkStream != null && message.Length != 0)
		{
			BufferOffsetSize[] buffers = new BufferOffsetSize[2]
			{
				new BufferOffsetSize(m_WriteHeaderBuffer, 0, m_WriteHeaderBuffer.Length, copyBuffer: false),
				new BufferOffsetSize(message, 0, message.Length, copyBuffer: false)
			};
			m_NetworkStream.MultipleWrite(buffers);
		}
		else
		{
			Transport.Write(m_WriteHeaderBuffer, 0, m_WriteHeaderBuffer.Length);
			if (message.Length != 0)
			{
				Transport.Write(message, 0, message.Length);
			}
		}
	}

	public IAsyncResult BeginWriteMessage(byte[] message, AsyncCallback asyncCallback, object stateObject)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		m_WriteHeader.PayloadSize = message.Length;
		m_WriteHeader.CopyTo(m_WriteHeaderBuffer, 0);
		if (m_NetworkStream != null && message.Length != 0)
		{
			BufferOffsetSize[] buffers = new BufferOffsetSize[2]
			{
				new BufferOffsetSize(m_WriteHeaderBuffer, 0, m_WriteHeaderBuffer.Length, copyBuffer: false),
				new BufferOffsetSize(message, 0, message.Length, copyBuffer: false)
			};
			return m_NetworkStream.BeginMultipleWrite(buffers, asyncCallback, stateObject);
		}
		if (message.Length == 0)
		{
			return Transport.BeginWrite(m_WriteHeaderBuffer, 0, m_WriteHeaderBuffer.Length, asyncCallback, stateObject);
		}
		WorkerAsyncResult workerAsyncResult = new WorkerAsyncResult(this, stateObject, asyncCallback, message, 0, message.Length);
		IAsyncResult asyncResult = Transport.BeginWrite(m_WriteHeaderBuffer, 0, m_WriteHeaderBuffer.Length, m_BeginWriteCallback, workerAsyncResult);
		if (asyncResult.CompletedSynchronously)
		{
			BeginWriteComplete(asyncResult);
		}
		return workerAsyncResult;
	}

	private void BeginWriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		WorkerAsyncResult workerAsyncResult = (WorkerAsyncResult)transportResult.AsyncState;
		try
		{
			BeginWriteComplete(transportResult);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			workerAsyncResult.InvokeCallback(ex);
		}
	}

	private void BeginWriteComplete(IAsyncResult transportResult)
	{
		do
		{
			WorkerAsyncResult workerAsyncResult = (WorkerAsyncResult)transportResult.AsyncState;
			Transport.EndWrite(transportResult);
			if (workerAsyncResult.Offset == workerAsyncResult.End)
			{
				workerAsyncResult.InvokeCallback();
				break;
			}
			workerAsyncResult.Offset = workerAsyncResult.End;
			transportResult = Transport.BeginWrite(workerAsyncResult.Buffer, 0, workerAsyncResult.End, m_BeginWriteCallback, workerAsyncResult);
		}
		while (transportResult.CompletedSynchronously);
	}

	public void EndWriteMessage(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult is WorkerAsyncResult workerAsyncResult)
		{
			if (!workerAsyncResult.InternalPeekCompleted)
			{
				workerAsyncResult.InternalWaitForCompletion();
			}
			if (workerAsyncResult.Result is Exception)
			{
				throw (Exception)workerAsyncResult.Result;
			}
		}
		else
		{
			Transport.EndWrite(asyncResult);
		}
	}
}
