namespace System.Runtime.CompilerServices;

internal struct ObjectHandleOnStack
{
	private IntPtr m_ptr;

	internal ObjectHandleOnStack(IntPtr pObject)
	{
		m_ptr = pObject;
	}
}
