using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.IO.Compression;

internal class InflaterZlib : IInflater, IDisposable
{
	private bool _finished;

	private bool _isDisposed;

	private ZLibNative.ZLibStreamHandle _zlibStream;

	private GCHandle _inputBufferHandle;

	private readonly object _syncLock = new object();

	private int _isValid;

	public int AvailableOutput => (int)_zlibStream.AvailOut;

	internal InflaterZlib(int windowBits)
	{
		_finished = false;
		_isDisposed = false;
		InflateInit(windowBits);
	}

	public bool Finished()
	{
		return _finished;
	}

	public int Inflate(byte[] bytes, int offset, int length)
	{
		if (length == 0)
		{
			return 0;
		}
		try
		{
			int bytesRead;
			ZLibNative.ErrorCode errorCode = ReadInflateOutput(bytes, offset, length, ZLibNative.FlushCode.NoFlush, out bytesRead);
			if (errorCode == ZLibNative.ErrorCode.StreamEnd)
			{
				_finished = true;
			}
			return bytesRead;
		}
		finally
		{
			if (_zlibStream.AvailIn == 0 && _inputBufferHandle.IsAllocated)
			{
				DeallocateInputBufferHandle();
			}
		}
	}

	public bool NeedsInput()
	{
		return _zlibStream.AvailIn == 0;
	}

	public void SetInput(byte[] inputBuffer, int startIndex, int count)
	{
		if (count == 0)
		{
			return;
		}
		lock (_syncLock)
		{
			_inputBufferHandle = GCHandle.Alloc(inputBuffer, GCHandleType.Pinned);
			_isValid = 1;
			_zlibStream.NextIn = _inputBufferHandle.AddrOfPinnedObject() + startIndex;
			_zlibStream.AvailIn = (uint)count;
			_finished = false;
		}
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed)
		{
			if (disposing)
			{
				_zlibStream.Dispose();
			}
			if (_inputBufferHandle.IsAllocated)
			{
				DeallocateInputBufferHandle();
			}
			_isDisposed = true;
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~InflaterZlib()
	{
		if (!Environment.HasShutdownStarted)
		{
			Dispose(disposing: false);
		}
	}

	[SecuritySafeCritical]
	private void InflateInit(int windowBits)
	{
		ZLibNative.ErrorCode errorCode;
		try
		{
			errorCode = ZLibNative.CreateZLibStreamForInflate(out _zlibStream, windowBits);
		}
		catch (Exception inner)
		{
			throw new ZLibException(SR.GetString("ZLibErrorDLLLoadError"), inner);
		}
		switch (errorCode)
		{
		case ZLibNative.ErrorCode.Ok:
			break;
		case ZLibNative.ErrorCode.MemError:
			throw new ZLibException(SR.GetString("ZLibErrorNotEnoughMemory"), "inflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		case ZLibNative.ErrorCode.VersionError:
			throw new ZLibException(SR.GetString("ZLibErrorVersionMismatch"), "inflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		case ZLibNative.ErrorCode.StreamError:
			throw new ZLibException(SR.GetString("ZLibErrorIncorrectInitParameters"), "inflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		default:
			throw new ZLibException(SR.GetString("ZLibErrorUnexpected"), "inflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		}
	}

	private unsafe ZLibNative.ErrorCode ReadInflateOutput(byte[] outputBuffer, int offset, int length, ZLibNative.FlushCode flushCode, out int bytesRead)
	{
		lock (_syncLock)
		{
			fixed (byte* ptr = outputBuffer)
			{
				_zlibStream.NextOut = (IntPtr)ptr + offset;
				_zlibStream.AvailOut = (uint)length;
				ZLibNative.ErrorCode result = Inflate(flushCode);
				bytesRead = length - (int)_zlibStream.AvailOut;
				return result;
			}
		}
	}

	[SecuritySafeCritical]
	private ZLibNative.ErrorCode Inflate(ZLibNative.FlushCode flushCode)
	{
		ZLibNative.ErrorCode errorCode;
		try
		{
			errorCode = _zlibStream.Inflate(flushCode);
		}
		catch (Exception inner)
		{
			throw new ZLibException(SR.GetString("ZLibErrorDLLLoadError"), inner);
		}
		switch (errorCode)
		{
		case ZLibNative.ErrorCode.Ok:
		case ZLibNative.ErrorCode.StreamEnd:
			return errorCode;
		case ZLibNative.ErrorCode.BufError:
			return errorCode;
		case ZLibNative.ErrorCode.MemError:
			throw new ZLibException(SR.GetString("ZLibErrorNotEnoughMemory"), "inflate_", (int)errorCode, _zlibStream.GetErrorMessage());
		case ZLibNative.ErrorCode.DataError:
			throw new InvalidDataException(SR.GetString("GenericInvalidData"));
		case ZLibNative.ErrorCode.StreamError:
			throw new ZLibException(SR.GetString("ZLibErrorInconsistentStream"), "inflate_", (int)errorCode, _zlibStream.GetErrorMessage());
		default:
			throw new ZLibException(SR.GetString("ZLibErrorUnexpected"), "inflate_", (int)errorCode, _zlibStream.GetErrorMessage());
		}
	}

	private void DeallocateInputBufferHandle()
	{
		lock (_syncLock)
		{
			_zlibStream.AvailIn = 0u;
			_zlibStream.NextIn = ZLibNative.ZNullPtr;
			if (Interlocked.Exchange(ref _isValid, 0) != 0)
			{
				_inputBufferHandle.Free();
			}
		}
	}
}
