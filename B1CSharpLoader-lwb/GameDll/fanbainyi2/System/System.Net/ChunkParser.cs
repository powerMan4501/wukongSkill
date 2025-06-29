using System.IO;
using System.Net.Configuration;
using System.Threading;

namespace System.Net;

internal sealed class ChunkParser
{
	private enum ReadState
	{
		ChunkLength,
		Extension,
		Payload,
		PayloadEnd,
		Trailer,
		Done,
		Error
	}

	private const int chunkLengthBuffer = 12;

	private const int noChunkLength = -1;

	private static readonly bool[] tokenChars;

	private byte[] buffer;

	private int bufferCurrentPos;

	private int bufferFillLength;

	private int maxBufferLength;

	private byte[] userBuffer;

	private int userBufferOffset;

	private int userBufferCount;

	private LazyAsyncResult userAsyncResult;

	private Stream dataSource;

	private ReadState readState;

	private int totalTrailerHeadersLength;

	private int currentChunkLength;

	private int currentChunkBytesRead;

	private int currentOperationBytesRead;

	private int syncResult;

	private bool IsAsync => userAsyncResult != null;

	static ChunkParser()
	{
		tokenChars = new bool[128];
		for (int i = 33; i < 127; i++)
		{
			tokenChars[i] = true;
		}
		tokenChars[40] = false;
		tokenChars[41] = false;
		tokenChars[60] = false;
		tokenChars[62] = false;
		tokenChars[64] = false;
		tokenChars[44] = false;
		tokenChars[59] = false;
		tokenChars[58] = false;
		tokenChars[92] = false;
		tokenChars[34] = false;
		tokenChars[47] = false;
		tokenChars[91] = false;
		tokenChars[93] = false;
		tokenChars[63] = false;
		tokenChars[61] = false;
		tokenChars[123] = false;
		tokenChars[125] = false;
	}

	public ChunkParser(Stream dataSource, byte[] internalBuffer, int initialBufferOffset, int initialBufferCount, int maxBufferLength)
	{
		this.dataSource = dataSource;
		buffer = internalBuffer;
		bufferCurrentPos = initialBufferOffset;
		bufferFillLength = initialBufferOffset + initialBufferCount;
		this.maxBufferLength = maxBufferLength;
		currentChunkLength = -1;
		readState = ReadState.ChunkLength;
	}

	public IAsyncResult ReadAsync(object caller, byte[] userBuffer, int userBufferOffset, int userBufferCount, AsyncCallback callback, object state)
	{
		SetReadParameters(userBuffer, userBufferOffset, userBufferCount);
		userAsyncResult = new LazyAsyncResult(caller, state, callback);
		IAsyncResult result = userAsyncResult;
		try
		{
			ProcessResponse();
		}
		catch (Exception result2)
		{
			CompleteUserRead(result2);
		}
		return result;
	}

	public int Read(byte[] userBuffer, int userBufferOffset, int userBufferCount)
	{
		SetReadParameters(userBuffer, userBufferOffset, userBufferCount);
		try
		{
			ProcessResponse();
		}
		catch (Exception)
		{
			TransitionToErrorState();
			throw;
		}
		return syncResult;
	}

	private void SetReadParameters(byte[] userBuffer, int userBufferOffset, int userBufferCount)
	{
		if (Interlocked.CompareExchange(ref this.userBuffer, userBuffer, null) != null)
		{
			throw new InvalidOperationException(SR.GetString("net_inasync"));
		}
		this.userBufferCount = userBufferCount;
		this.userBufferOffset = userBufferOffset;
	}

	public bool TryGetLeftoverBytes(out byte[] buffer, out int leftoverBufferOffset, out int leftoverBufferSize)
	{
		leftoverBufferOffset = 0;
		leftoverBufferSize = 0;
		buffer = null;
		if (readState != ReadState.Done)
		{
			return false;
		}
		if (bufferCurrentPos == bufferFillLength)
		{
			return false;
		}
		leftoverBufferOffset = bufferCurrentPos;
		leftoverBufferSize = bufferFillLength - bufferCurrentPos;
		buffer = this.buffer;
		return true;
	}

	private void ProcessResponse()
	{
		while (readState < ReadState.Done)
		{
			switch (readState switch
			{
				ReadState.ChunkLength => (int)ParseChunkLength(), 
				ReadState.Extension => (int)ParseExtension(), 
				ReadState.Payload => (int)HandlePayload(), 
				ReadState.PayloadEnd => (int)ParsePayloadEnd(), 
				ReadState.Trailer => (int)ParseTrailer(), 
				_ => throw new InternalException(), 
			})
			{
			case 2:
				return;
			case 3:
			case 4:
				CompleteUserRead(new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed"))));
				return;
			case 0:
				if (!TryGetMoreData())
				{
					return;
				}
				break;
			default:
				throw new InternalException();
			case 1:
				break;
			}
		}
	}

	private void CompleteUserRead(object result)
	{
		bool flag = result is Exception;
		userBuffer = null;
		userBufferCount = 0;
		userBufferOffset = 0;
		if (flag)
		{
			TransitionToErrorState();
		}
		if (IsAsync)
		{
			LazyAsyncResult lazyAsyncResult = userAsyncResult;
			userAsyncResult = null;
			lazyAsyncResult.InvokeCallback(result);
			return;
		}
		if (flag)
		{
			throw result as Exception;
		}
		syncResult = (int)result;
	}

	private void TransitionToErrorState()
	{
		readState = ReadState.Error;
	}

	private bool TryGetMoreData()
	{
		PrepareBufferForMoreData();
		int num = buffer.Length - bufferFillLength;
		if (readState == ReadState.ChunkLength)
		{
			num = Math.Min(12, num);
		}
		int num2 = 0;
		if (IsAsync)
		{
			IAsyncResult asyncResult = dataSource.BeginRead(buffer, bufferFillLength, num, ReadCallback, null);
			CheckAsyncResult(asyncResult);
			if (!asyncResult.CompletedSynchronously)
			{
				return false;
			}
			num2 = dataSource.EndRead(asyncResult);
		}
		else
		{
			num2 = dataSource.Read(buffer, bufferFillLength, num);
		}
		CompleteMetaDataReadOperation(num2);
		return true;
	}

	private void PrepareBufferForMoreData()
	{
		int num = bufferCurrentPos;
		bufferCurrentPos = 0;
		if (num == bufferFillLength)
		{
			bufferFillLength = 0;
			return;
		}
		if (num > 0 || bufferFillLength < buffer.Length)
		{
			if (num > 0)
			{
				int count = bufferFillLength - num;
				Buffer.BlockCopy(buffer, num, buffer, 0, count);
				bufferFillLength = count;
			}
			return;
		}
		if (buffer.Length == maxBufferLength)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		int num2 = Math.Min(maxBufferLength, buffer.Length * 2);
		byte[] dst = new byte[num2];
		Buffer.BlockCopy(buffer, 0, dst, 0, buffer.Length);
		buffer = dst;
	}

	private void CheckAsyncResult(IAsyncResult ar)
	{
		if (ar == null)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
	}

	private void CompleteMetaDataReadOperation(int bytesRead)
	{
		if (bytesRead == 0)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		bufferFillLength += bytesRead;
	}

	public void ReadCallback(IAsyncResult ar)
	{
		if (ar.CompletedSynchronously)
		{
			return;
		}
		try
		{
			int bytesRead = dataSource.EndRead(ar);
			if (readState == ReadState.Payload)
			{
				CompletePayloadReadOperation(bytesRead);
				return;
			}
			CompleteMetaDataReadOperation(bytesRead);
			ProcessResponse();
		}
		catch (Exception result)
		{
			CompleteUserRead(result);
		}
	}

	private DataParseStatus HandlePayload()
	{
		if (bufferCurrentPos < bufferFillLength)
		{
			int num = Math.Min(Math.Min(userBufferCount, bufferFillLength - bufferCurrentPos), currentChunkLength - currentChunkBytesRead);
			Buffer.BlockCopy(buffer, bufferCurrentPos, userBuffer, userBufferOffset, num);
			bufferCurrentPos += num;
			if (currentChunkBytesRead + num == currentChunkLength || num == userBufferCount)
			{
				CompletePayloadReadOperation(num);
				return DataParseStatus.Done;
			}
			currentOperationBytesRead += num;
			currentChunkBytesRead += num;
		}
		int count = Math.Min(userBufferCount - currentOperationBytesRead, currentChunkLength - currentChunkBytesRead);
		if (IsAsync)
		{
			IAsyncResult asyncResult = dataSource.BeginRead(userBuffer, userBufferOffset + currentOperationBytesRead, count, ReadCallback, null);
			CheckAsyncResult(asyncResult);
			if (asyncResult.CompletedSynchronously)
			{
				CompletePayloadReadOperation(dataSource.EndRead(asyncResult));
			}
		}
		else
		{
			int bytesRead = dataSource.Read(userBuffer, userBufferOffset + currentOperationBytesRead, count);
			CompletePayloadReadOperation(bytesRead);
		}
		return DataParseStatus.Done;
	}

	private void CompletePayloadReadOperation(int bytesRead)
	{
		if (bytesRead == 0)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.ConnectionClosed), WebExceptionStatus.ConnectionClosed);
		}
		currentChunkBytesRead += bytesRead;
		int num = currentOperationBytesRead + bytesRead;
		if (currentChunkBytesRead == currentChunkLength)
		{
			readState = ReadState.PayloadEnd;
		}
		currentOperationBytesRead = 0;
		CompleteUserRead(num);
	}

	private DataParseStatus ParseChunkLength()
	{
		int num = -1;
		for (int i = bufferCurrentPos; i < bufferFillLength; i++)
		{
			byte b = buffer[i];
			if ((b < 48 || b > 57) && (b < 65 || b > 70) && (b < 97 || b > 102))
			{
				if (num == -1)
				{
					return DataParseStatus.Invalid;
				}
				bufferCurrentPos = i;
				currentChunkLength = num;
				readState = ReadState.Extension;
				return DataParseStatus.ContinueParsing;
			}
			byte b2 = (byte)((b < 65) ? (b - 48) : (10 + ((b < 97) ? (b - 65) : (b - 97))));
			if (num == -1)
			{
				num = b2;
				continue;
			}
			if (num >= 134217728)
			{
				return DataParseStatus.Invalid;
			}
			num = (num << 4) + b2;
		}
		return DataParseStatus.NeedMoreData;
	}

	private DataParseStatus ParseExtension()
	{
		int pos = bufferCurrentPos;
		DataParseStatus dataParseStatus = ParseWhitespaces(ref pos);
		if (dataParseStatus != DataParseStatus.ContinueParsing)
		{
			return dataParseStatus;
		}
		dataParseStatus = ParseExtensionNameValuePairs(ref pos);
		if (dataParseStatus != DataParseStatus.ContinueParsing)
		{
			return dataParseStatus;
		}
		dataParseStatus = ParseCRLF(ref pos);
		if (dataParseStatus != DataParseStatus.ContinueParsing)
		{
			return dataParseStatus;
		}
		bufferCurrentPos = pos;
		if (currentChunkLength == 0)
		{
			readState = ReadState.Trailer;
		}
		else
		{
			readState = ReadState.Payload;
		}
		return DataParseStatus.ContinueParsing;
	}

	private DataParseStatus ParsePayloadEnd()
	{
		DataParseStatus dataParseStatus = ParseCRLF(ref bufferCurrentPos);
		if (dataParseStatus != DataParseStatus.ContinueParsing)
		{
			return dataParseStatus;
		}
		currentChunkLength = -1;
		currentChunkBytesRead = 0;
		readState = ReadState.ChunkLength;
		return DataParseStatus.ContinueParsing;
	}

	private DataParseStatus ParseTrailer()
	{
		if (ParseWhitespaces(ref bufferCurrentPos) == DataParseStatus.NeedMoreData)
		{
			return DataParseStatus.NeedMoreData;
		}
		int unparsed = bufferCurrentPos;
		WebParseError parseError = default(WebParseError);
		parseError.Section = WebParseErrorSection.Generic;
		parseError.Code = WebParseErrorCode.Generic;
		WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
		DataParseStatus dataParseStatus = ((!SettingsSectionInternal.Section.UseUnsafeHeaderParsing) ? webHeaderCollection.ParseHeadersStrict(buffer, bufferFillLength, ref unparsed, ref totalTrailerHeadersLength, maxBufferLength, ref parseError) : webHeaderCollection.ParseHeaders(buffer, bufferFillLength, ref unparsed, ref totalTrailerHeadersLength, maxBufferLength, ref parseError));
		if (dataParseStatus == DataParseStatus.NeedMoreData || dataParseStatus == DataParseStatus.Done)
		{
			bufferCurrentPos = unparsed;
		}
		if (dataParseStatus != DataParseStatus.Done)
		{
			return dataParseStatus;
		}
		readState = ReadState.Done;
		CompleteUserRead(0);
		return DataParseStatus.Done;
	}

	private DataParseStatus ParseCRLF(ref int pos)
	{
		if (pos + 2 > bufferFillLength)
		{
			return DataParseStatus.NeedMoreData;
		}
		if (buffer[pos] != 13 || buffer[pos + 1] != 10)
		{
			return DataParseStatus.Invalid;
		}
		pos += 2;
		return DataParseStatus.ContinueParsing;
	}

	private DataParseStatus ParseWhitespaces(ref int pos)
	{
		for (int i = pos; i < bufferFillLength; i++)
		{
			byte c = buffer[i];
			if (!IsWhiteSpace(c))
			{
				pos = i;
				return DataParseStatus.ContinueParsing;
			}
		}
		return DataParseStatus.NeedMoreData;
	}

	private static bool IsWhiteSpace(byte c)
	{
		if (c != 32)
		{
			return c == 9;
		}
		return true;
	}

	private DataParseStatus ParseExtensionNameValuePairs(ref int pos)
	{
		int pos2 = pos;
		while (buffer[pos2] == 59)
		{
			pos2++;
			DataParseStatus dataParseStatus = ParseWhitespaces(ref pos2);
			if (dataParseStatus != DataParseStatus.ContinueParsing)
			{
				return dataParseStatus;
			}
			dataParseStatus = ParseToken(ref pos2);
			if (dataParseStatus != DataParseStatus.ContinueParsing)
			{
				return dataParseStatus;
			}
			dataParseStatus = ParseWhitespaces(ref pos2);
			if (dataParseStatus != DataParseStatus.ContinueParsing)
			{
				return dataParseStatus;
			}
			if (buffer[pos2] == 61)
			{
				pos2++;
				dataParseStatus = ParseWhitespaces(ref pos2);
				if (dataParseStatus != DataParseStatus.ContinueParsing)
				{
					return dataParseStatus;
				}
				dataParseStatus = ParseToken(ref pos2);
				if (dataParseStatus == DataParseStatus.Invalid)
				{
					dataParseStatus = ParseQuotedString(ref pos2);
				}
				if (dataParseStatus != DataParseStatus.ContinueParsing)
				{
					return dataParseStatus;
				}
				dataParseStatus = ParseWhitespaces(ref pos2);
				if (dataParseStatus != DataParseStatus.ContinueParsing)
				{
					return dataParseStatus;
				}
			}
		}
		pos = pos2;
		return DataParseStatus.ContinueParsing;
	}

	private DataParseStatus ParseQuotedString(ref int pos)
	{
		if (pos == bufferFillLength)
		{
			return DataParseStatus.NeedMoreData;
		}
		if (buffer[pos] != 34)
		{
			return DataParseStatus.Invalid;
		}
		int num = pos + 1;
		while (num < bufferFillLength)
		{
			if (buffer[num] == 34)
			{
				pos = num + 1;
				return DataParseStatus.ContinueParsing;
			}
			if (buffer[num] == 92)
			{
				num++;
				if (num == bufferFillLength)
				{
					return DataParseStatus.NeedMoreData;
				}
				if (buffer[num] <= 127)
				{
					num++;
					continue;
				}
			}
			num++;
		}
		return DataParseStatus.NeedMoreData;
	}

	private DataParseStatus ParseToken(ref int pos)
	{
		for (int i = pos; i < bufferFillLength; i++)
		{
			if (!IsTokenChar(buffer[i]))
			{
				if (i > pos)
				{
					pos = i;
					return DataParseStatus.ContinueParsing;
				}
				return DataParseStatus.Invalid;
			}
		}
		return DataParseStatus.NeedMoreData;
	}

	private static bool IsTokenChar(byte character)
	{
		if (character > 127)
		{
			return false;
		}
		return tokenChars[character];
	}
}
