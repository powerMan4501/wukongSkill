namespace System.StubHelpers;

internal struct CopyCtorStubCookie
{
	public IntPtr m_srcInstancePtr;

	public uint m_dstStackOffset;

	public IntPtr m_ctorPtr;

	public IntPtr m_dtorPtr;

	public IntPtr m_pNext;

	public void SetData(IntPtr srcInstancePtr, uint dstStackOffset, IntPtr ctorPtr, IntPtr dtorPtr)
	{
		m_srcInstancePtr = srcInstancePtr;
		m_dstStackOffset = dstStackOffset;
		m_ctorPtr = ctorPtr;
		m_dtorPtr = dtorPtr;
	}

	public void SetNext(IntPtr pNext)
	{
		m_pNext = pNext;
	}
}
