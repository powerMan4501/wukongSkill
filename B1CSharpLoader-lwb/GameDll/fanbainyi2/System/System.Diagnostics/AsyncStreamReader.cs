using System.Collections;
using System.IO;
using System.Text;
using System.Threading;

namespace System.Diagnostics;

internal class AsyncStreamReader : IDisposable
{
	internal const int DefaultBufferSize = 1024;

	private const int MinBufferSize = 128;

	private Stream stream;

	private Encoding encoding;

	private Decoder decoder;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private int _maxCharsPerBuffer;

	private Process process;

	private UserCallBack userCallBack;

	private bool cancelOperation;

	private ManualResetEvent eofEvent;

	private Queue messageQueue;

	private StringBuilder sb;

	private bool bLastCarriageReturn;

	private int currentLinePos;

	public virtual Encoding CurrentEncoding => encoding;

	public virtual Stream BaseStream => stream;

	internal AsyncStreamReader(Process process, Stream stream, UserCallBack callback, Encoding encoding)
		: this(process, stream, callback, encoding, 1024)
	{
	}

	internal AsyncStreamReader(Process process, Stream stream, UserCallBack callback, Encoding encoding, int bufferSize)
	{
		Init(process, stream, callback, encoding, bufferSize);
		messageQueue = new Queue();
	}

	private void Init(Process process, Stream stream, UserCallBack callback, Encoding encoding, int bufferSize)
	{
		this.process = process;
		this.stream = stream;
		this.encoding = encoding;
		userCallBack = callback;
		decoder = encoding.GetDecoder();
		if (bufferSize < 128)
		{
			bufferSize = 128;
		}
		byteBuffer = new byte[bufferSize];
		_maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
		charBuffer = new char[_maxCharsPerBuffer];
		cancelOperation = false;
		eofEvent = new ManualResetEvent(initialState: false);
		sb = null;
		bLastCarriageReturn = false;
	}

	public virtual void Close()
	{
		Dispose(disposing: true);
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && stream != null)
		{
			stream.Close();
		}
		if (stream != null)
		{
			stream = null;
			encoding = null;
			decoder = null;
			byteBuffer = null;
			charBuffer = null;
		}
		if (eofEvent != null)
		{
			eofEvent.Close();
			eofEvent = null;
		}
	}

	internal void BeginReadLine()
	{
		if (cancelOperation)
		{
			cancelOperation = false;
		}
		if (sb == null)
		{
			sb = new StringBuilder(1024);
			stream.BeginRead(byteBuffer, 0, byteBuffer.Length, ReadBuffer, null);
		}
		else
		{
			FlushMessageQueue();
		}
	}

	internal void CancelOperation()
	{
		cancelOperation = true;
	}

	private void ReadBuffer(IAsyncResult ar)
	{
		int num;
		try
		{
			num = stream.EndRead(ar);
		}
		catch (IOException)
		{
			num = 0;
		}
		catch (OperationCanceledException)
		{
			num = 0;
		}
		if (num == 0)
		{
			lock (messageQueue)
			{
				if (sb.Length != 0)
				{
					messageQueue.Enqueue(sb.ToString());
					sb.Length = 0;
				}
				messageQueue.Enqueue(null);
			}
			try
			{
				FlushMessageQueue();
				return;
			}
			finally
			{
				eofEvent.Set();
			}
		}
		int chars = decoder.GetChars(byteBuffer, 0, num, charBuffer, 0);
		sb.Append(charBuffer, 0, chars);
		GetLinesFromStringBuilder();
		stream.BeginRead(byteBuffer, 0, byteBuffer.Length, ReadBuffer, null);
	}

	private void GetLinesFromStringBuilder()
	{
		int i = currentLinePos;
		int num = 0;
		int length = sb.Length;
		if (bLastCarriageReturn && length > 0 && sb[0] == '\n')
		{
			i = 1;
			num = 1;
			bLastCarriageReturn = false;
		}
		for (; i < length; i++)
		{
			char c = sb[i];
			if (c == '\r' || c == '\n')
			{
				string obj = sb.ToString(num, i - num);
				num = i + 1;
				if (c == '\r' && num < length && sb[num] == '\n')
				{
					num++;
					i++;
				}
				lock (messageQueue)
				{
					messageQueue.Enqueue(obj);
				}
			}
		}
		if (length > 0 && sb[length - 1] == '\r')
		{
			bLastCarriageReturn = true;
		}
		if (num < length)
		{
			if (num == 0)
			{
				currentLinePos = i;
			}
			else
			{
				sb.Remove(0, num);
				currentLinePos = 0;
			}
		}
		else
		{
			sb.Length = 0;
			currentLinePos = 0;
		}
		FlushMessageQueue();
	}

	private void FlushMessageQueue()
	{
		while (messageQueue.Count > 0)
		{
			lock (messageQueue)
			{
				if (messageQueue.Count > 0)
				{
					string data = (string)messageQueue.Dequeue();
					if (!cancelOperation)
					{
						userCallBack(data);
					}
				}
			}
		}
	}

	internal void WaitUtilEOF()
	{
		if (eofEvent != null)
		{
			eofEvent.WaitOne();
			eofEvent.Close();
			eofEvent = null;
		}
	}
}
