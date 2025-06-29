namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	private CallingConvention m_callingConvention;

	[__DynamicallyInvokable]
	public CharSet CharSet;

	[__DynamicallyInvokable]
	public bool BestFitMapping;

	[__DynamicallyInvokable]
	public bool ThrowOnUnmappableChar;

	[__DynamicallyInvokable]
	public bool SetLastError;

	[__DynamicallyInvokable]
	public CallingConvention CallingConvention
	{
		[__DynamicallyInvokable]
		get
		{
			return m_callingConvention;
		}
	}

	[__DynamicallyInvokable]
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
	{
		m_callingConvention = callingConvention;
	}
}
