using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class BufferedReadStream : DelegatedStream
{
	private class ReadAsyncResult : LazyAsyncResult
	{
		private BufferedReadStream parent;

		private int read;

		private static AsyncCallback onRead = OnRead;

		internal ReadAsyncResult(BufferedReadStream parent, AsyncCallback callback, object state)
			: base(null, state, callback)
		{
			this.parent = parent;
		}

		internal void Read(byte[] buffer, int offset, int count)
		{
			if (parent.storedOffset < parent.storedLength)
			{
				read = Math.Min(count, parent.storedLength - parent.storedOffset);
				Buffer.BlockCopy(parent.storedBuffer, parent.storedOffset, buffer, offset, read);
				parent.storedOffset += read;
				if (read == count || !parent.readMore)
				{
					InvokeCallback();
					return;
				}
				count -= read;
				offset += read;
			}
			IAsyncResult asyncResult = parent.BaseStream.BeginRead(buffer, offset, count, onRead, this);
			if (asyncResult.CompletedSynchronously)
			{
				read += parent.BaseStream.EndRead(asyncResult);
				InvokeCallback();
			}
		}

		internal static int End(IAsyncResult result)
		{
			ReadAsyncResult readAsyncResult = (ReadAsyncResult)result;
			readAsyncResult.InternalWaitForCompletion();
			return readAsyncResult.read;
		}

		private static void OnRead(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			ReadAsyncResult readAsyncResult = (ReadAsyncResult)result.AsyncState;
			try
			{
				readAsyncResult.read += readAsyncResult.parent.BaseStream.EndRead(result);
				readAsyncResult.InvokeCallback();
			}
			catch (Exception result2)
			{
				if (readAsyncResult.IsCompleted)
				{
					throw;
				}
				readAsyncResult.InvokeCallback(result2);
			}
		}
	}

	private byte[] storedBuffer;

	private int storedLength;

	private int storedOffset;

	private bool readMore;

	public override bool CanWrite => false;

	public override bool CanSeek => false;

	internal BufferedReadStream(Stream stream)
		: this(stream, readMore: false)
	{
	}

	internal BufferedReadStream(Stream stream, bool readMore)
		: base(stream)
	{
		this.readMore = readMore;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		ReadAsyncResult readAsyncResult = new ReadAsyncResult(this, callback, state);
		readAsyncResult.Read(buffer, offset, count);
		return readAsyncResult;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return ReadAsyncResult.End(asyncResult);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		if (storedOffset < storedLength)
		{
			num = Math.Min(count, storedLength - storedOffset);
			Buffer.BlockCopy(storedBuffer, storedOffset, buffer, offset, num);
			storedOffset += num;
			if (num == count || !readMore)
			{
				return num;
			}
			offset += num;
			count -= num;
		}
		return num + base.Read(buffer, offset, count);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		int num = 0;
		if (storedOffset >= storedLength)
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}
		num = Math.Min(count, storedLength - storedOffset);
		Buffer.BlockCopy(storedBuffer, storedOffset, buffer, offset, num);
		storedOffset += num;
		if (num == count || !readMore)
		{
			return Task.FromResult(num);
		}
		offset += num;
		count -= num;
		return ReadMoreAsync(num, buffer, offset, count, cancellationToken);
	}

	private async Task<int> ReadMoreAsync(int bytesAlreadyRead, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return bytesAlreadyRead + await base.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override int ReadByte()
	{
		if (storedOffset < storedLength)
		{
			return storedBuffer[storedOffset++];
		}
		return base.ReadByte();
	}

	internal void Push(byte[] buffer, int offset, int count)
	{
		if (count == 0)
		{
			return;
		}
		if (storedOffset == storedLength)
		{
			if (storedBuffer == null || storedBuffer.Length < count)
			{
				storedBuffer = new byte[count];
			}
			storedOffset = 0;
			storedLength = count;
		}
		else if (count <= storedOffset)
		{
			storedOffset -= count;
		}
		else if (count <= storedBuffer.Length - storedLength + storedOffset)
		{
			Buffer.BlockCopy(storedBuffer, storedOffset, storedBuffer, count, storedLength - storedOffset);
			storedLength += count - storedOffset;
			storedOffset = 0;
		}
		else
		{
			byte[] dst = new byte[count + storedLength - storedOffset];
			Buffer.BlockCopy(storedBuffer, storedOffset, dst, count, storedLength - storedOffset);
			storedLength += count - storedOffset;
			storedOffset = 0;
			storedBuffer = dst;
		}
		Buffer.BlockCopy(buffer, offset, storedBuffer, storedOffset, count);
	}

	internal void Append(byte[] buffer, int offset, int count)
	{
		if (count == 0)
		{
			return;
		}
		int num;
		if (storedOffset == storedLength)
		{
			if (storedBuffer == null || storedBuffer.Length < count)
			{
				storedBuffer = new byte[count];
			}
			storedOffset = 0;
			storedLength = count;
			num = 0;
		}
		else if (count <= storedBuffer.Length - storedLength)
		{
			num = storedLength;
			storedLength += count;
		}
		else if (count <= storedBuffer.Length - storedLength + storedOffset)
		{
			Buffer.BlockCopy(storedBuffer, storedOffset, storedBuffer, 0, storedLength - storedOffset);
			num = storedLength - storedOffset;
			storedOffset = 0;
			storedLength = count + num;
		}
		else
		{
			byte[] dst = new byte[count + storedLength - storedOffset];
			Buffer.BlockCopy(storedBuffer, storedOffset, dst, 0, storedLength - storedOffset);
			num = storedLength - storedOffset;
			storedOffset = 0;
			storedLength = count + num;
			storedBuffer = dst;
		}
		Buffer.BlockCopy(buffer, offset, storedBuffer, num, count);
	}
}
