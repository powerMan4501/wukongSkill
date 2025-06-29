namespace System.Threading;

internal struct ThreadHandle
{
	private IntPtr m_ptr;

	internal ThreadHandle(IntPtr pThread)
	{
		m_ptr = pThread;
	}
}
