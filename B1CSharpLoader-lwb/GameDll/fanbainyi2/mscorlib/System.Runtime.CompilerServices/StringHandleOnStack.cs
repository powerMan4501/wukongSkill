namespace System.Runtime.CompilerServices;

internal struct StringHandleOnStack
{
	private IntPtr m_ptr;

	internal StringHandleOnStack(IntPtr pString)
	{
		m_ptr = pString;
	}
}
