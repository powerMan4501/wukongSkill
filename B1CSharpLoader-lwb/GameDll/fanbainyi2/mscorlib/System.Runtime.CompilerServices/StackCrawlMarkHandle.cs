namespace System.Runtime.CompilerServices;

internal struct StackCrawlMarkHandle
{
	private IntPtr m_ptr;

	internal StackCrawlMarkHandle(IntPtr stackMark)
	{
		m_ptr = stackMark;
	}
}
