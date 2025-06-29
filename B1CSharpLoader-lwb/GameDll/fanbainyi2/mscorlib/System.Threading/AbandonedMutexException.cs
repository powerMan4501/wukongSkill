using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(false)]
[__DynamicallyInvokable]
public class AbandonedMutexException : SystemException
{
	private int m_MutexIndex = -1;

	private Mutex m_Mutex;

	[__DynamicallyInvokable]
	public Mutex Mutex
	{
		[__DynamicallyInvokable]
		get
		{
			return m_Mutex;
		}
	}

	[__DynamicallyInvokable]
	public int MutexIndex
	{
		[__DynamicallyInvokable]
		get
		{
			return m_MutexIndex;
		}
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException()
		: base(Environment.GetResourceString("Threading.AbandonedMutexException"))
	{
		SetErrorCode(-2146233043);
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException(string message)
		: base(message)
	{
		SetErrorCode(-2146233043);
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233043);
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException(int location, WaitHandle handle)
		: base(Environment.GetResourceString("Threading.AbandonedMutexException"))
	{
		SetErrorCode(-2146233043);
		SetupException(location, handle);
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException(string message, int location, WaitHandle handle)
		: base(message)
	{
		SetErrorCode(-2146233043);
		SetupException(location, handle);
	}

	[__DynamicallyInvokable]
	public AbandonedMutexException(string message, Exception inner, int location, WaitHandle handle)
		: base(message, inner)
	{
		SetErrorCode(-2146233043);
		SetupException(location, handle);
	}

	private void SetupException(int location, WaitHandle handle)
	{
		m_MutexIndex = location;
		if (handle != null)
		{
			m_Mutex = handle as Mutex;
		}
	}

	protected AbandonedMutexException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
