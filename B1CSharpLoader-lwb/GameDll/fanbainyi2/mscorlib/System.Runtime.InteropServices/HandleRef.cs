namespace System.Runtime.InteropServices;

[ComVisible(true)]
public struct HandleRef
{
	internal object m_wrapper;

	internal IntPtr m_handle;

	public object Wrapper => m_wrapper;

	public IntPtr Handle => m_handle;

	public HandleRef(object wrapper, IntPtr handle)
	{
		m_wrapper = wrapper;
		m_handle = handle;
	}

	public static explicit operator IntPtr(HandleRef value)
	{
		return value.m_handle;
	}

	public static IntPtr ToIntPtr(HandleRef value)
	{
		return value.m_handle;
	}
}
