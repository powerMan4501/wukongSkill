using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace System.Net.Security;

internal class _SslStream
{
	private class SplitWriteAsyncProtocolRequest : AsyncProtocolRequest
	{
		internal SplitWritesState SplitWritesState;

		internal SplitWriteAsyncProtocolRequest(LazyAsyncResult userAsyncResult)
			: base(userAsyncResult)
		{
		}

		internal void SetNextRequest(SplitWritesState splitWritesState, AsyncProtocolCallback callback)
		{
			SplitWritesState = splitWritesState;
			SetNextRequest(null, 0, 0, callback);
		}
	}

	private static AsyncCallback _WriteCallback = WriteCallback;

	private static AsyncCallback _MulitpleWriteCallback = MulitpleWriteCallback;

	private static AsyncProtocolCallback _ResumeAsyncWriteCallback = ResumeAsyncWriteCallback;

	private static AsyncProtocolCallback _ResumeAsyncReadCallback = ResumeAsyncReadCallback;

	private static AsyncProtocolCallback _ReadHeaderCallback = ReadHeaderCallback;

	private static AsyncProtocolCallback _ReadFrameCallback = ReadFrameCallback;

	private const int PinnableReadBufferSize = 16416;

	private static PinnableBufferCache s_PinnableReadBufferCache = new PinnableBufferCache("System.Net.SslStream", 16416);

	private const int PinnableWriteBufferSize = 5120;

	private static PinnableBufferCache s_PinnableWriteBufferCache = new PinnableBufferCache("System.Net.SslStream", 5120);

	private SslState _SslState;

	private int _NestedWrite;

	private int _NestedRead;

	private byte[] _InternalBuffer;

	private bool _InternalBufferFromPinnableCache;

	private byte[] _PinnableOutputBuffer;

	private byte[] _PinnableOutputBufferInUse;

	private int _InternalOffset;

	private int _InternalBufferCount;

	private FixedSizeReader _Reader;

	internal bool DataAvailable => InternalBufferCount != 0;

	private byte[] InternalBuffer => _InternalBuffer;

	private int InternalOffset => _InternalOffset;

	private int InternalBufferCount => _InternalBufferCount;

	internal _SslStream(SslState sslState)
	{
		if (PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			PinnableBufferCacheEventSource.Log.DebugMessage1("CTOR: In System.Net._SslStream.SslStream", GetHashCode());
		}
		_SslState = sslState;
		_Reader = new FixedSizeReader(_SslState.InnerStream);
	}

	private void FreeReadBuffer()
	{
		if (_InternalBufferFromPinnableCache)
		{
			s_PinnableReadBufferCache.FreeBuffer(_InternalBuffer);
			_InternalBufferFromPinnableCache = false;
		}
		_InternalBuffer = null;
	}

	~_SslStream()
	{
		if (_InternalBufferFromPinnableCache)
		{
			if (PinnableBufferCacheEventSource.Log.IsEnabled())
			{
				PinnableBufferCacheEventSource.Log.DebugMessage2("DTOR: In System.Net._SslStream.~SslStream Freeing Read Buffer", GetHashCode(), PinnableBufferCacheEventSource.AddressOfByteArray(_InternalBuffer));
			}
			FreeReadBuffer();
		}
		if (_PinnableOutputBuffer != null)
		{
			if (PinnableBufferCacheEventSource.Log.IsEnabled())
			{
				PinnableBufferCacheEventSource.Log.DebugMessage2("DTOR: In System.Net._SslStream.~SslStream Freeing Write Buffer", GetHashCode(), PinnableBufferCacheEventSource.AddressOfByteArray(_PinnableOutputBuffer));
			}
			s_PinnableWriteBufferCache.FreeBuffer(_PinnableOutputBuffer);
		}
	}

	internal int Read(byte[] buffer, int offset, int count)
	{
		return ProcessRead(buffer, offset, count, null);
	}

	internal void Write(byte[] buffer, int offset, int count)
	{
		ProcessWrite(buffer, offset, count, null);
	}

	internal void Write(BufferOffsetSize[] buffers)
	{
		ProcessWrite(buffers, null);
	}

	internal IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		BufferAsyncResult bufferAsyncResult = new BufferAsyncResult(this, buffer, offset, count, asyncState, asyncCallback);
		AsyncProtocolRequest asyncRequest = new AsyncProtocolRequest(bufferAsyncResult);
		ProcessRead(buffer, offset, count, asyncRequest);
		return bufferAsyncResult;
	}

	internal int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is BufferAsyncResult bufferAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", asyncResult.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedRead, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
		}
		bufferAsyncResult.InternalWaitForCompletion();
		if (bufferAsyncResult.Result is Exception)
		{
			if (bufferAsyncResult.Result is IOException)
			{
				throw (Exception)bufferAsyncResult.Result;
			}
			throw new IOException(SR.GetString("net_io_read"), (Exception)bufferAsyncResult.Result);
		}
		return (int)bufferAsyncResult.Result;
	}

	internal IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(this, asyncState, asyncCallback);
		AsyncProtocolRequest asyncRequest = new AsyncProtocolRequest(lazyAsyncResult);
		ProcessWrite(buffer, offset, count, asyncRequest);
		return lazyAsyncResult;
	}

	internal IAsyncResult BeginWrite(BufferOffsetSize[] buffers, AsyncCallback asyncCallback, object asyncState)
	{
		LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(this, asyncState, asyncCallback);
		SplitWriteAsyncProtocolRequest asyncRequest = new SplitWriteAsyncProtocolRequest(lazyAsyncResult);
		ProcessWrite(buffers, asyncRequest);
		return lazyAsyncResult;
	}

	internal void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is LazyAsyncResult lazyAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", asyncResult.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedWrite, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndWrite"));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		if (lazyAsyncResult.Result is Exception)
		{
			if (lazyAsyncResult.Result is IOException)
			{
				throw (Exception)lazyAsyncResult.Result;
			}
			throw new IOException(SR.GetString("net_io_write"), (Exception)lazyAsyncResult.Result);
		}
	}

	private void DecrementInternalBufferCount(int decrCount)
	{
		_InternalOffset += decrCount;
		_InternalBufferCount -= decrCount;
	}

	private void EnsureInternalBufferSize(int curOffset, int addSize)
	{
		if (_InternalBuffer == null || _InternalBuffer.Length < addSize + curOffset)
		{
			bool internalBufferFromPinnableCache = _InternalBufferFromPinnableCache;
			byte[] internalBuffer = _InternalBuffer;
			int num = addSize + curOffset;
			if (num <= 16416)
			{
				if (PinnableBufferCacheEventSource.Log.IsEnabled())
				{
					PinnableBufferCacheEventSource.Log.DebugMessage2("In System.Net._SslStream.EnsureInternalBufferSize IS pinnable", GetHashCode(), num);
				}
				_InternalBufferFromPinnableCache = true;
				_InternalBuffer = s_PinnableReadBufferCache.AllocateBuffer();
			}
			else
			{
				if (PinnableBufferCacheEventSource.Log.IsEnabled())
				{
					PinnableBufferCacheEventSource.Log.DebugMessage2("In System.Net._SslStream.EnsureInternalBufferSize NOT pinnable", GetHashCode(), num);
				}
				_InternalBufferFromPinnableCache = false;
				_InternalBuffer = new byte[num];
			}
			if (internalBuffer != null && curOffset != 0)
			{
				Buffer.BlockCopy(internalBuffer, 0, _InternalBuffer, 0, curOffset);
			}
			if (internalBufferFromPinnableCache)
			{
				s_PinnableReadBufferCache.FreeBuffer(internalBuffer);
			}
		}
		_InternalOffset = curOffset;
		_InternalBufferCount = curOffset + addSize;
	}

	private void ValidateParameters(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("net_offset_plus_count"));
		}
	}

	private void ProcessWrite(BufferOffsetSize[] buffers, SplitWriteAsyncProtocolRequest asyncRequest)
	{
		_SslState.CheckThrow(authSuccessCheck: true, shutdownCheck: true);
		foreach (BufferOffsetSize bufferOffsetSize in buffers)
		{
			ValidateParameters(bufferOffsetSize.Buffer, bufferOffsetSize.Offset, bufferOffsetSize.Size);
		}
		if (Interlocked.Exchange(ref _NestedWrite, 1) == 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", (asyncRequest != null) ? "BeginWrite" : "Write", "write"));
		}
		bool flag = false;
		try
		{
			SplitWritesState splitWritesState = new SplitWritesState(buffers);
			asyncRequest?.SetNextRequest(splitWritesState, _ResumeAsyncWriteCallback);
			StartWriting(splitWritesState, asyncRequest);
		}
		catch (Exception ex)
		{
			_SslState.FinishWrite();
			flag = true;
			if (ex is IOException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_write"), ex);
		}
		finally
		{
			if (asyncRequest == null || flag)
			{
				_NestedWrite = 0;
			}
		}
	}

	private void ProcessWrite(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (_SslState.LastPayload != null)
		{
			BufferOffsetSize[] buffers = new BufferOffsetSize[1]
			{
				new BufferOffsetSize(buffer, offset, count, copyBuffer: false)
			};
			if (asyncRequest != null)
			{
				ProcessWrite(buffers, new SplitWriteAsyncProtocolRequest(asyncRequest.UserAsyncResult));
			}
			else
			{
				ProcessWrite(buffers, null);
			}
			return;
		}
		ValidateParameters(buffer, offset, count);
		_SslState.CheckThrow(authSuccessCheck: true, shutdownCheck: true);
		if (Interlocked.Exchange(ref _NestedWrite, 1) == 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", (asyncRequest != null) ? "BeginWrite" : "Write", "write"));
		}
		bool flag = false;
		try
		{
			StartWriting(buffer, offset, count, asyncRequest);
		}
		catch (Exception ex)
		{
			_SslState.FinishWrite();
			flag = true;
			if (ex is IOException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_write"), ex);
		}
		finally
		{
			if (asyncRequest == null || flag)
			{
				_NestedWrite = 0;
			}
		}
	}

	private void StartWriting(SplitWritesState splitWrite, SplitWriteAsyncProtocolRequest asyncRequest)
	{
		while (!splitWrite.IsDone)
		{
			if (_SslState.CheckEnqueueWrite(asyncRequest))
			{
				return;
			}
			byte[] lastHandshakePayload = null;
			if (_SslState.LastPayload != null)
			{
				lastHandshakePayload = _SslState.LastPayload;
				_SslState.LastPayloadConsumed();
			}
			BufferOffsetSize[] nextBuffers = splitWrite.GetNextBuffers();
			nextBuffers = EncryptBuffers(nextBuffers, lastHandshakePayload);
			if (asyncRequest != null)
			{
				IAsyncResult asyncResult = ((NetworkStream)_SslState.InnerStream).BeginMultipleWrite(nextBuffers, _MulitpleWriteCallback, asyncRequest);
				if (!asyncResult.CompletedSynchronously)
				{
					return;
				}
				((NetworkStream)_SslState.InnerStream).EndMultipleWrite(asyncResult);
			}
			else
			{
				((NetworkStream)_SslState.InnerStream).MultipleWrite(nextBuffers);
			}
			_SslState.FinishWrite();
		}
		asyncRequest?.CompleteUser();
	}

	private BufferOffsetSize[] EncryptBuffers(BufferOffsetSize[] buffers, byte[] lastHandshakePayload)
	{
		List<BufferOffsetSize> list = null;
		SecurityStatus securityStatus = SecurityStatus.OK;
		BufferOffsetSize[] array = buffers;
		foreach (BufferOffsetSize bufferOffsetSize in array)
		{
			int num = Math.Min(bufferOffsetSize.Size, _SslState.MaxDataSize);
			byte[] outBuffer = null;
			securityStatus = _SslState.EncryptData(bufferOffsetSize.Buffer, bufferOffsetSize.Offset, num, ref outBuffer, out var outSize);
			if (securityStatus != SecurityStatus.OK)
			{
				break;
			}
			if (num != bufferOffsetSize.Size || list != null)
			{
				if (list == null)
				{
					list = new List<BufferOffsetSize>(buffers.Length * (bufferOffsetSize.Size / num + 1));
					if (lastHandshakePayload != null)
					{
						list.Add(new BufferOffsetSize(lastHandshakePayload, copyBuffer: false));
					}
					BufferOffsetSize[] array2 = buffers;
					foreach (BufferOffsetSize bufferOffsetSize2 in array2)
					{
						if (bufferOffsetSize2 == bufferOffsetSize)
						{
							break;
						}
						list.Add(bufferOffsetSize2);
					}
				}
				list.Add(new BufferOffsetSize(outBuffer, 0, outSize, copyBuffer: false));
				while ((bufferOffsetSize.Size -= num) != 0)
				{
					bufferOffsetSize.Offset += num;
					num = Math.Min(bufferOffsetSize.Size, _SslState.MaxDataSize);
					outBuffer = null;
					securityStatus = _SslState.EncryptData(bufferOffsetSize.Buffer, bufferOffsetSize.Offset, num, ref outBuffer, out outSize);
					if (securityStatus != SecurityStatus.OK)
					{
						break;
					}
					list.Add(new BufferOffsetSize(outBuffer, 0, outSize, copyBuffer: false));
				}
			}
			else
			{
				bufferOffsetSize.Buffer = outBuffer;
				bufferOffsetSize.Offset = 0;
				bufferOffsetSize.Size = outSize;
			}
			if (securityStatus != SecurityStatus.OK)
			{
				break;
			}
		}
		if (securityStatus != SecurityStatus.OK)
		{
			ProtocolToken protocolToken = new ProtocolToken(null, securityStatus);
			throw new IOException(SR.GetString("net_io_encrypt"), protocolToken.GetException());
		}
		if (list != null)
		{
			buffers = list.ToArray();
		}
		else if (lastHandshakePayload != null)
		{
			BufferOffsetSize[] array3 = new BufferOffsetSize[buffers.Length + 1];
			Array.Copy(buffers, 0, array3, 1, buffers.Length);
			array3[0] = new BufferOffsetSize(lastHandshakePayload, copyBuffer: false);
			buffers = array3;
		}
		return buffers;
	}

	private void StartWriting(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		asyncRequest?.SetNextRequest(buffer, offset, count, _ResumeAsyncWriteCallback);
		if (count >= 0)
		{
			byte[] outBuffer = null;
			if (_PinnableOutputBufferInUse == null)
			{
				if (_PinnableOutputBuffer == null)
				{
					_PinnableOutputBuffer = s_PinnableWriteBufferCache.AllocateBuffer();
				}
				_PinnableOutputBufferInUse = buffer;
				outBuffer = _PinnableOutputBuffer;
				if (PinnableBufferCacheEventSource.Log.IsEnabled())
				{
					PinnableBufferCacheEventSource.Log.DebugMessage3("In System.Net._SslStream.StartWriting Trying Pinnable", GetHashCode(), count, PinnableBufferCacheEventSource.AddressOfByteArray(outBuffer));
				}
			}
			else if (PinnableBufferCacheEventSource.Log.IsEnabled())
			{
				PinnableBufferCacheEventSource.Log.DebugMessage2("In System.Net._SslStream.StartWriting BufferInUse", GetHashCode(), count);
			}
			do
			{
				if (_SslState.CheckEnqueueWrite(asyncRequest))
				{
					return;
				}
				int num = Math.Min(count, _SslState.MaxDataSize);
				int outSize;
				SecurityStatus securityStatus = _SslState.EncryptData(buffer, offset, num, ref outBuffer, out outSize);
				if (securityStatus != SecurityStatus.OK)
				{
					ProtocolToken protocolToken = new ProtocolToken(null, securityStatus);
					throw new IOException(SR.GetString("net_io_encrypt"), protocolToken.GetException());
				}
				if (PinnableBufferCacheEventSource.Log.IsEnabled())
				{
					PinnableBufferCacheEventSource.Log.DebugMessage3("In System.Net._SslStream.StartWriting Got Encrypted Buffer", GetHashCode(), outSize, PinnableBufferCacheEventSource.AddressOfByteArray(outBuffer));
				}
				if (asyncRequest != null)
				{
					asyncRequest.SetNextRequest(buffer, offset + num, count - num, _ResumeAsyncWriteCallback);
					IAsyncResult asyncResult = _SslState.InnerStream.BeginWrite(outBuffer, 0, outSize, _WriteCallback, asyncRequest);
					if (!asyncResult.CompletedSynchronously)
					{
						return;
					}
					_SslState.InnerStream.EndWrite(asyncResult);
				}
				else
				{
					_SslState.InnerStream.Write(outBuffer, 0, outSize);
				}
				offset += num;
				count -= num;
				_SslState.FinishWrite();
			}
			while (count != 0);
		}
		asyncRequest?.CompleteUser();
		if (buffer == _PinnableOutputBufferInUse)
		{
			_PinnableOutputBufferInUse = null;
			if (PinnableBufferCacheEventSource.Log.IsEnabled())
			{
				PinnableBufferCacheEventSource.Log.DebugMessage1("In System.Net._SslStream.StartWriting Freeing buffer.", GetHashCode());
			}
		}
	}

	private int ProcessRead(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		ValidateParameters(buffer, offset, count);
		if (Interlocked.Exchange(ref _NestedRead, 1) == 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", (asyncRequest != null) ? "BeginRead" : "Read", "read"));
		}
		bool flag = false;
		try
		{
			if (InternalBufferCount != 0)
			{
				int num = ((InternalBufferCount > count) ? count : InternalBufferCount);
				if (num != 0)
				{
					Buffer.BlockCopy(InternalBuffer, InternalOffset, buffer, offset, num);
					DecrementInternalBufferCount(num);
				}
				asyncRequest?.CompleteUser(num);
				return num;
			}
			return StartReading(buffer, offset, count, asyncRequest);
		}
		catch (Exception ex)
		{
			_SslState.FinishRead(null);
			flag = true;
			if (ex is IOException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_read"), ex);
		}
		finally
		{
			if (asyncRequest == null || flag)
			{
				_NestedRead = 0;
			}
		}
	}

	private int StartReading(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		int num = 0;
		do
		{
			asyncRequest?.SetNextRequest(buffer, offset, count, _ResumeAsyncReadCallback);
			int num2 = _SslState.CheckEnqueueRead(buffer, offset, count, asyncRequest);
			switch (num2)
			{
			case 0:
				return 0;
			case -1:
				continue;
			}
			asyncRequest?.CompleteUser(num2);
			return num2;
		}
		while ((num = StartFrameHeader(buffer, offset, count, asyncRequest)) == -1);
		return num;
	}

	private int StartFrameHeader(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		int num = 0;
		EnsureInternalBufferSize(0, 5);
		if (asyncRequest != null)
		{
			asyncRequest.SetNextRequest(InternalBuffer, 0, 5, _ReadHeaderCallback);
			_Reader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return 0;
			}
			num = asyncRequest.Result;
		}
		else
		{
			num = _Reader.ReadPacket(InternalBuffer, 0, 5);
		}
		return StartFrameBody(num, buffer, offset, count, asyncRequest);
	}

	private int StartFrameBody(int readBytes, byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (readBytes == 0)
		{
			DecrementInternalBufferCount(InternalBufferCount);
			asyncRequest?.CompleteUser(0);
			return 0;
		}
		readBytes = _SslState.GetRemainingFrameSize(InternalBuffer, readBytes);
		if (readBytes < 0)
		{
			throw new IOException(SR.GetString("net_frame_read_size"));
		}
		EnsureInternalBufferSize(5, readBytes);
		if (asyncRequest != null)
		{
			asyncRequest.SetNextRequest(InternalBuffer, 5, readBytes, _ReadFrameCallback);
			_Reader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return 0;
			}
			readBytes = asyncRequest.Result;
		}
		else
		{
			readBytes = _Reader.ReadPacket(InternalBuffer, 5, readBytes);
		}
		return ProcessFrameBody(readBytes, buffer, offset, count, asyncRequest);
	}

	private int ProcessFrameBody(int readBytes, byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (readBytes == 0)
		{
			throw new IOException(SR.GetString("net_io_eof"));
		}
		readBytes += 5;
		int offset2 = 0;
		SecurityStatus securityStatus = _SslState.DecryptData(InternalBuffer, ref offset2, ref readBytes);
		if (securityStatus != SecurityStatus.OK)
		{
			byte[] array = null;
			if (readBytes != 0)
			{
				array = new byte[readBytes];
				Buffer.BlockCopy(InternalBuffer, offset2, array, 0, readBytes);
			}
			DecrementInternalBufferCount(InternalBufferCount);
			return ProcessReadErrorCode(securityStatus, buffer, offset, count, asyncRequest, array);
		}
		if (readBytes == 0 && count != 0)
		{
			DecrementInternalBufferCount(InternalBufferCount);
			return -1;
		}
		EnsureInternalBufferSize(0, offset2 + readBytes);
		DecrementInternalBufferCount(offset2);
		if (readBytes > count)
		{
			readBytes = count;
		}
		Buffer.BlockCopy(InternalBuffer, InternalOffset, buffer, offset, readBytes);
		DecrementInternalBufferCount(readBytes);
		_SslState.FinishRead(null);
		asyncRequest?.CompleteUser(readBytes);
		return readBytes;
	}

	private int ProcessReadErrorCode(SecurityStatus errorCode, byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest, byte[] extraBuffer)
	{
		ProtocolToken protocolToken = new ProtocolToken(null, errorCode);
		if (protocolToken.Renegotiate)
		{
			_SslState.ReplyOnReAuthentication(extraBuffer);
			return -1;
		}
		if (protocolToken.CloseConnection)
		{
			_SslState.FinishRead(null);
			asyncRequest?.CompleteUser(0);
			return 0;
		}
		throw new IOException(SR.GetString("net_io_decrypt"), protocolToken.GetException());
	}

	private static void WriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)transportResult.AsyncState;
		_SslStream sslStream = (_SslStream)asyncProtocolRequest.AsyncObject;
		try
		{
			sslStream._SslState.InnerStream.EndWrite(transportResult);
			sslStream._SslState.FinishWrite();
			if (asyncProtocolRequest.Count == 0)
			{
				asyncProtocolRequest.Count = -1;
			}
			sslStream.StartWriting(asyncProtocolRequest.Buffer, asyncProtocolRequest.Offset, asyncProtocolRequest.Count, asyncProtocolRequest);
		}
		catch (Exception e)
		{
			if (asyncProtocolRequest.IsUserCompleted)
			{
				throw;
			}
			sslStream._SslState.FinishWrite();
			asyncProtocolRequest.CompleteWithError(e);
		}
	}

	private static void MulitpleWriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		SplitWriteAsyncProtocolRequest splitWriteAsyncProtocolRequest = (SplitWriteAsyncProtocolRequest)transportResult.AsyncState;
		_SslStream sslStream = (_SslStream)splitWriteAsyncProtocolRequest.AsyncObject;
		try
		{
			((NetworkStream)sslStream._SslState.InnerStream).EndMultipleWrite(transportResult);
			sslStream._SslState.FinishWrite();
			sslStream.StartWriting(splitWriteAsyncProtocolRequest.SplitWritesState, splitWriteAsyncProtocolRequest);
		}
		catch (Exception e)
		{
			if (splitWriteAsyncProtocolRequest.IsUserCompleted)
			{
				throw;
			}
			sslStream._SslState.FinishWrite();
			splitWriteAsyncProtocolRequest.CompleteWithError(e);
		}
	}

	private static void ResumeAsyncReadCallback(AsyncProtocolRequest request)
	{
		try
		{
			((_SslStream)request.AsyncObject).StartReading(request.Buffer, request.Offset, request.Count, request);
		}
		catch (Exception e)
		{
			if (request.IsUserCompleted)
			{
				throw;
			}
			((_SslStream)request.AsyncObject)._SslState.FinishRead(null);
			request.CompleteWithError(e);
		}
	}

	private static void ResumeAsyncWriteCallback(AsyncProtocolRequest asyncRequest)
	{
		try
		{
			if (asyncRequest is SplitWriteAsyncProtocolRequest splitWriteAsyncProtocolRequest)
			{
				((_SslStream)asyncRequest.AsyncObject).StartWriting(splitWriteAsyncProtocolRequest.SplitWritesState, splitWriteAsyncProtocolRequest);
			}
			else
			{
				((_SslStream)asyncRequest.AsyncObject).StartWriting(asyncRequest.Buffer, asyncRequest.Offset, asyncRequest.Count, asyncRequest);
			}
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			((_SslStream)asyncRequest.AsyncObject)._SslState.FinishWrite();
			asyncRequest.CompleteWithError(e);
		}
	}

	private static void ReadHeaderCallback(AsyncProtocolRequest asyncRequest)
	{
		try
		{
			_SslStream sslStream = (_SslStream)asyncRequest.AsyncObject;
			BufferAsyncResult bufferAsyncResult = (BufferAsyncResult)asyncRequest.UserAsyncResult;
			if (-1 == sslStream.StartFrameBody(asyncRequest.Result, bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest))
			{
				sslStream.StartReading(bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest);
			}
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			asyncRequest.CompleteWithError(e);
		}
	}

	private static void ReadFrameCallback(AsyncProtocolRequest asyncRequest)
	{
		try
		{
			_SslStream sslStream = (_SslStream)asyncRequest.AsyncObject;
			BufferAsyncResult bufferAsyncResult = (BufferAsyncResult)asyncRequest.UserAsyncResult;
			if (-1 == sslStream.ProcessFrameBody(asyncRequest.Result, bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest))
			{
				sslStream.StartReading(bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest);
			}
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			asyncRequest.CompleteWithError(e);
		}
	}
}
