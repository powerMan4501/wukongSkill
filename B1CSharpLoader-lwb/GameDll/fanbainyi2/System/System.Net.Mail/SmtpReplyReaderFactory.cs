using System.Collections;
using System.IO;
using System.Text;

namespace System.Net.Mail;

internal class SmtpReplyReaderFactory
{
	private enum ReadState
	{
		Status0,
		Status1,
		Status2,
		ContinueFlag,
		ContinueCR,
		ContinueLF,
		LastCR,
		LastLF,
		Done
	}

	private class ReadLinesAsyncResult : LazyAsyncResult
	{
		private StringBuilder builder;

		private ArrayList lines;

		private SmtpReplyReaderFactory parent;

		private static AsyncCallback readCallback = ReadCallback;

		private int read;

		private int statusRead;

		private bool oneLine;

		internal ReadLinesAsyncResult(SmtpReplyReaderFactory parent, AsyncCallback callback, object state)
			: base(null, state, callback)
		{
			this.parent = parent;
		}

		internal ReadLinesAsyncResult(SmtpReplyReaderFactory parent, AsyncCallback callback, object state, bool oneLine)
			: base(null, state, callback)
		{
			this.oneLine = oneLine;
			this.parent = parent;
		}

		internal void Read(SmtpReplyReader caller)
		{
			if (parent.currentReader != caller || parent.readState == ReadState.Done)
			{
				InvokeCallback();
				return;
			}
			if (parent.byteBuffer == null)
			{
				parent.byteBuffer = new byte[256];
			}
			builder = new StringBuilder();
			lines = new ArrayList();
			Read();
		}

		internal static LineInfo[] End(IAsyncResult result)
		{
			ReadLinesAsyncResult readLinesAsyncResult = (ReadLinesAsyncResult)result;
			readLinesAsyncResult.InternalWaitForCompletion();
			return (LineInfo[])readLinesAsyncResult.lines.ToArray(typeof(LineInfo));
		}

		private void Read()
		{
			do
			{
				IAsyncResult asyncResult = parent.bufferedStream.BeginRead(parent.byteBuffer, 0, parent.byteBuffer.Length, readCallback, this);
				if (!asyncResult.CompletedSynchronously)
				{
					break;
				}
				read = parent.bufferedStream.EndRead(asyncResult);
			}
			while (ProcessRead());
		}

		private static void ReadCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			Exception ex = null;
			ReadLinesAsyncResult readLinesAsyncResult = (ReadLinesAsyncResult)result.AsyncState;
			try
			{
				readLinesAsyncResult.read = readLinesAsyncResult.parent.bufferedStream.EndRead(result);
				if (readLinesAsyncResult.ProcessRead())
				{
					readLinesAsyncResult.Read();
				}
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			if (ex != null)
			{
				readLinesAsyncResult.InvokeCallback(ex);
			}
		}

		private bool ProcessRead()
		{
			if (read == 0)
			{
				throw new IOException(SR.GetString("net_io_readfailure", "net_io_connectionclosed"));
			}
			int num = 0;
			while (num != read)
			{
				int num2 = parent.ProcessRead(parent.byteBuffer, num, read - num, readLine: true);
				if (statusRead < 4)
				{
					int num3 = Math.Min(4 - statusRead, num2);
					statusRead += num3;
					num += num3;
					num2 -= num3;
					if (num2 == 0)
					{
						continue;
					}
				}
				builder.Append(Encoding.UTF8.GetString(parent.byteBuffer, num, num2));
				num += num2;
				if (parent.readState == ReadState.Status0)
				{
					lines.Add(new LineInfo(parent.statusCode, builder.ToString(0, builder.Length - 2)));
					builder = new StringBuilder();
					statusRead = 0;
					if (oneLine)
					{
						parent.bufferedStream.Push(parent.byteBuffer, num, read - num);
						InvokeCallback();
						return false;
					}
				}
				else if (parent.readState == ReadState.Done)
				{
					lines.Add(new LineInfo(parent.statusCode, builder.ToString(0, builder.Length - 2)));
					parent.bufferedStream.Push(parent.byteBuffer, num, read - num);
					InvokeCallback();
					return false;
				}
			}
			return true;
		}
	}

	private BufferedReadStream bufferedStream;

	private byte[] byteBuffer;

	private SmtpReplyReader currentReader;

	private const int DefaultBufferSize = 256;

	private ReadState readState;

	private SmtpStatusCode statusCode;

	internal SmtpReplyReader CurrentReader => currentReader;

	internal SmtpStatusCode StatusCode => statusCode;

	internal SmtpReplyReaderFactory(Stream stream)
	{
		bufferedStream = new BufferedReadStream(stream);
	}

	internal IAsyncResult BeginReadLines(SmtpReplyReader caller, AsyncCallback callback, object state)
	{
		ReadLinesAsyncResult readLinesAsyncResult = new ReadLinesAsyncResult(this, callback, state);
		readLinesAsyncResult.Read(caller);
		return readLinesAsyncResult;
	}

	internal IAsyncResult BeginReadLine(SmtpReplyReader caller, AsyncCallback callback, object state)
	{
		ReadLinesAsyncResult readLinesAsyncResult = new ReadLinesAsyncResult(this, callback, state, oneLine: true);
		readLinesAsyncResult.Read(caller);
		return readLinesAsyncResult;
	}

	internal void Close(SmtpReplyReader caller)
	{
		if (currentReader != caller)
		{
			return;
		}
		if (readState != ReadState.Done)
		{
			if (byteBuffer == null)
			{
				byteBuffer = new byte[256];
			}
			while (Read(caller, byteBuffer, 0, byteBuffer.Length) != 0)
			{
			}
		}
		currentReader = null;
	}

	internal LineInfo[] EndReadLines(IAsyncResult result)
	{
		return ReadLinesAsyncResult.End(result);
	}

	internal LineInfo EndReadLine(IAsyncResult result)
	{
		LineInfo[] array = ReadLinesAsyncResult.End(result);
		if (array != null && array.Length != 0)
		{
			return array[0];
		}
		return default(LineInfo);
	}

	internal SmtpReplyReader GetNextReplyReader()
	{
		if (currentReader != null)
		{
			currentReader.Close();
		}
		readState = ReadState.Status0;
		currentReader = new SmtpReplyReader(this);
		return currentReader;
	}

	private unsafe int ProcessRead(byte[] buffer, int offset, int read, bool readLine)
	{
		if (read == 0)
		{
			throw new IOException(SR.GetString("net_io_readfailure", "net_io_connectionclosed"));
		}
		fixed (byte* ptr = buffer)
		{
			byte* ptr2 = ptr + offset;
			byte* ptr3 = ptr2;
			byte* ptr4 = ptr3 + read;
			switch (readState)
			{
			case ReadState.Status0:
				if (ptr3 < ptr4)
				{
					byte b = *(ptr3++);
					if (b < 48 && b > 57)
					{
						throw new FormatException(SR.GetString("SmtpInvalidResponse"));
					}
					statusCode = (SmtpStatusCode)(100 * (b - 48));
					goto case ReadState.Status1;
				}
				readState = ReadState.Status0;
				break;
			case ReadState.Status1:
				if (ptr3 < ptr4)
				{
					byte b3 = *(ptr3++);
					if (b3 < 48 && b3 > 57)
					{
						throw new FormatException(SR.GetString("SmtpInvalidResponse"));
					}
					statusCode += 10 * (b3 - 48);
					goto case ReadState.Status2;
				}
				readState = ReadState.Status1;
				break;
			case ReadState.Status2:
				if (ptr3 < ptr4)
				{
					byte b2 = *(ptr3++);
					if (b2 < 48 && b2 > 57)
					{
						throw new FormatException(SR.GetString("SmtpInvalidResponse"));
					}
					statusCode += b2 - 48;
					goto case ReadState.ContinueFlag;
				}
				readState = ReadState.Status2;
				break;
			case ReadState.ContinueFlag:
				if (ptr3 < ptr4)
				{
					byte b4 = *(ptr3++);
					if (b4 != 32)
					{
						if (b4 != 45)
						{
							throw new FormatException(SR.GetString("SmtpInvalidResponse"));
						}
						goto case ReadState.ContinueCR;
					}
					goto case ReadState.LastCR;
				}
				readState = ReadState.ContinueFlag;
				break;
			case ReadState.ContinueCR:
				while (ptr3 < ptr4)
				{
					if (*(ptr3++) != 13)
					{
						continue;
					}
					goto case ReadState.ContinueLF;
				}
				readState = ReadState.ContinueCR;
				break;
			case ReadState.ContinueLF:
				if (ptr3 < ptr4)
				{
					if (*(ptr3++) != 10)
					{
						throw new FormatException(SR.GetString("SmtpInvalidResponse"));
					}
					if (readLine)
					{
						readState = ReadState.Status0;
						return (int)(ptr3 - ptr2);
					}
					goto case ReadState.Status0;
				}
				readState = ReadState.ContinueLF;
				break;
			case ReadState.LastCR:
				while (ptr3 < ptr4)
				{
					if (*(ptr3++) != 13)
					{
						continue;
					}
					goto case ReadState.LastLF;
				}
				readState = ReadState.LastCR;
				break;
			case ReadState.LastLF:
				if (ptr3 < ptr4)
				{
					if (*(ptr3++) != 10)
					{
						throw new FormatException(SR.GetString("SmtpInvalidResponse"));
					}
					goto case ReadState.Done;
				}
				readState = ReadState.LastLF;
				break;
			case ReadState.Done:
			{
				int result = (int)(ptr3 - ptr2);
				readState = ReadState.Done;
				return result;
			}
			}
			return (int)(ptr3 - ptr2);
		}
	}

	internal int Read(SmtpReplyReader caller, byte[] buffer, int offset, int count)
	{
		if (count == 0 || currentReader != caller || readState == ReadState.Done)
		{
			return 0;
		}
		int num = bufferedStream.Read(buffer, offset, count);
		int num2 = ProcessRead(buffer, offset, num, readLine: false);
		if (num2 < num)
		{
			bufferedStream.Push(buffer, offset + num2, num - num2);
		}
		return num2;
	}

	internal LineInfo ReadLine(SmtpReplyReader caller)
	{
		LineInfo[] array = ReadLines(caller, oneLine: true);
		if (array != null && array.Length != 0)
		{
			return array[0];
		}
		return default(LineInfo);
	}

	internal LineInfo[] ReadLines(SmtpReplyReader caller)
	{
		return ReadLines(caller, oneLine: false);
	}

	internal LineInfo[] ReadLines(SmtpReplyReader caller, bool oneLine)
	{
		if (caller != currentReader || readState == ReadState.Done)
		{
			return new LineInfo[0];
		}
		if (byteBuffer == null)
		{
			byteBuffer = new byte[256];
		}
		StringBuilder stringBuilder = new StringBuilder();
		ArrayList arrayList = new ArrayList();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (true)
		{
			if (num2 == num3)
			{
				num3 = bufferedStream.Read(byteBuffer, 0, byteBuffer.Length);
				num2 = 0;
			}
			int num4 = ProcessRead(byteBuffer, num2, num3 - num2, readLine: true);
			if (num < 4)
			{
				int num5 = Math.Min(4 - num, num4);
				num += num5;
				num2 += num5;
				num4 -= num5;
				if (num4 == 0)
				{
					continue;
				}
			}
			stringBuilder.Append(Encoding.UTF8.GetString(byteBuffer, num2, num4));
			num2 += num4;
			if (readState == ReadState.Status0)
			{
				num = 0;
				arrayList.Add(new LineInfo(statusCode, stringBuilder.ToString(0, stringBuilder.Length - 2)));
				if (oneLine)
				{
					bufferedStream.Push(byteBuffer, num2, num3 - num2);
					return (LineInfo[])arrayList.ToArray(typeof(LineInfo));
				}
				stringBuilder = new StringBuilder();
			}
			else if (readState == ReadState.Done)
			{
				break;
			}
		}
		arrayList.Add(new LineInfo(statusCode, stringBuilder.ToString(0, stringBuilder.Length - 2)));
		bufferedStream.Push(byteBuffer, num2, num3 - num2);
		return (LineInfo[])arrayList.ToArray(typeof(LineInfo));
	}
}
