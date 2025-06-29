namespace System.Net;

internal abstract class RequestContextBase : IDisposable
{
	private unsafe UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* m_MemoryBlob;

	private unsafe UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* m_OriginalBlobAddress;

	private byte[] m_BackingBuffer;

	internal unsafe UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* RequestBlob => m_MemoryBlob;

	internal byte[] RequestBuffer => m_BackingBuffer;

	internal uint Size => (uint)m_BackingBuffer.Length;

	internal unsafe IntPtr OriginalBlobAddress
	{
		get
		{
			UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* memoryBlob = m_MemoryBlob;
			return (IntPtr)((memoryBlob == null) ? m_OriginalBlobAddress : memoryBlob);
		}
	}

	protected unsafe void BaseConstruction(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* requestBlob)
	{
		if (requestBlob == null)
		{
			GC.SuppressFinalize(this);
		}
		else
		{
			m_MemoryBlob = requestBlob;
		}
	}

	internal unsafe void ReleasePins()
	{
		m_OriginalBlobAddress = m_MemoryBlob;
		UnsetBlob();
		OnReleasePins();
	}

	protected abstract void OnReleasePins();

	public void Close()
	{
		Dispose();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~RequestContextBase()
	{
		Dispose(disposing: false);
	}

	protected unsafe void SetBlob(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* requestBlob)
	{
		if (requestBlob == null)
		{
			UnsetBlob();
			return;
		}
		if (m_MemoryBlob == null)
		{
			GC.ReRegisterForFinalize(this);
		}
		m_MemoryBlob = requestBlob;
	}

	protected unsafe void UnsetBlob()
	{
		if (m_MemoryBlob != null)
		{
			GC.SuppressFinalize(this);
		}
		m_MemoryBlob = null;
	}

	protected void SetBuffer(int size)
	{
		m_BackingBuffer = ((size == 0) ? null : new byte[size]);
	}
}
