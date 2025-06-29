using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.IO.Compression;

internal class DeflaterZLib : IDeflater, IDisposable
{
	private ZLibNative.ZLibStreamHandle _zlibStream;

	private GCHandle _inputBufferHandle;

	private bool _isDisposed;

	private int _isValid;

	private readonly object syncLock = new object();

	internal DeflaterZLib()
		: this(CompressionLevel.Optimal)
	{
	}

	internal DeflaterZLib(CompressionLevel compressionLevel)
	{
		ZLibNative.CompressionLevel compressionLevel2;
		int windowBits;
		int memLevel;
		ZLibNative.CompressionStrategy strategy;
		switch (compressionLevel)
		{
		case CompressionLevel.Optimal:
			compressionLevel2 = (ZLibNative.CompressionLevel)6;
			windowBits = -15;
			memLevel = 8;
			strategy = ZLibNative.CompressionStrategy.DefaultStrategy;
			break;
		case CompressionLevel.Fastest:
			compressionLevel2 = ZLibNative.CompressionLevel.BestSpeed;
			windowBits = -15;
			memLevel = 8;
			strategy = ZLibNative.CompressionStrategy.DefaultStrategy;
			break;
		case CompressionLevel.NoCompression:
			compressionLevel2 = ZLibNative.CompressionLevel.NoCompression;
			windowBits = -15;
			memLevel = 7;
			strategy = ZLibNative.CompressionStrategy.DefaultStrategy;
			break;
		default:
			throw new ArgumentOutOfRangeException("compressionLevel");
		}
		_isDisposed = false;
		DeflateInit(compressionLevel2, windowBits, memLevel, strategy);
	}

	~DeflaterZLib()
	{
		if (!Environment.HasShutdownStarted)
		{
			Dispose(disposing: false);
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
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

	private bool NeedsInput()
	{
		return ((IDeflater)this).NeedsInput();
	}

	[SecuritySafeCritical]
	bool IDeflater.NeedsInput()
	{
		return _zlibStream.AvailIn == 0;
	}

	[SecuritySafeCritical]
	void IDeflater.SetInput(byte[] inputBuffer, int startIndex, int count)
	{
		if (count == 0)
		{
			return;
		}
		lock (syncLock)
		{
			_inputBufferHandle = GCHandle.Alloc(inputBuffer, GCHandleType.Pinned);
			_isValid = 1;
			_zlibStream.NextIn = _inputBufferHandle.AddrOfPinnedObject() + startIndex;
			_zlibStream.AvailIn = (uint)count;
		}
	}

	[SecuritySafeCritical]
	int IDeflater.GetDeflateOutput(byte[] outputBuffer)
	{
		try
		{
			ReadDeflateOutput(outputBuffer, ZLibNative.FlushCode.NoFlush, out var bytesRead);
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

	private unsafe ZLibNative.ErrorCode ReadDeflateOutput(byte[] outputBuffer, ZLibNative.FlushCode flushCode, out int bytesRead)
	{
		lock (syncLock)
		{
			fixed (byte* ptr = outputBuffer)
			{
				_zlibStream.NextOut = (IntPtr)ptr;
				_zlibStream.AvailOut = (uint)outputBuffer.Length;
				ZLibNative.ErrorCode result = Deflate(flushCode);
				bytesRead = outputBuffer.Length - (int)_zlibStream.AvailOut;
				return result;
			}
		}
	}

	bool IDeflater.Finish(byte[] outputBuffer, out int bytesRead)
	{
		ZLibNative.ErrorCode errorCode = ReadDeflateOutput(outputBuffer, ZLibNative.FlushCode.Finish, out bytesRead);
		return errorCode == ZLibNative.ErrorCode.StreamEnd;
	}

	private void DeallocateInputBufferHandle()
	{
		lock (syncLock)
		{
			_zlibStream.AvailIn = 0u;
			_zlibStream.NextIn = ZLibNative.ZNullPtr;
			if (Interlocked.Exchange(ref _isValid, 0) != 0)
			{
				_inputBufferHandle.Free();
			}
		}
	}

	[SecuritySafeCritical]
	private void DeflateInit(ZLibNative.CompressionLevel compressionLevel, int windowBits, int memLevel, ZLibNative.CompressionStrategy strategy)
	{
		ZLibNative.ErrorCode errorCode;
		try
		{
			errorCode = ZLibNative.CreateZLibStreamForDeflate(out _zlibStream, compressionLevel, windowBits, memLevel, strategy);
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
			throw new ZLibException(SR.GetString("ZLibErrorNotEnoughMemory"), "deflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		case ZLibNative.ErrorCode.VersionError:
			throw new ZLibException(SR.GetString("ZLibErrorVersionMismatch"), "deflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		case ZLibNative.ErrorCode.StreamError:
			throw new ZLibException(SR.GetString("ZLibErrorIncorrectInitParameters"), "deflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		default:
			throw new ZLibException(SR.GetString("ZLibErrorUnexpected"), "deflateInit2_", (int)errorCode, _zlibStream.GetErrorMessage());
		}
	}

	[SecuritySafeCritical]
	private ZLibNative.ErrorCode Deflate(ZLibNative.FlushCode flushCode)
	{
		ZLibNative.ErrorCode errorCode;
		try
		{
			errorCode = _zlibStream.Deflate(flushCode);
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
		case ZLibNative.ErrorCode.StreamError:
			throw new ZLibException(SR.GetString("ZLibErrorInconsistentStream"), "deflate", (int)errorCode, _zlibStream.GetErrorMessage());
		default:
			throw new ZLibException(SR.GetString("ZLibErrorUnexpected"), "deflate", (int)errorCode, _zlibStream.GetErrorMessage());
		}
	}
}
