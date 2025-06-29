namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class UnknownWrapper
{
	private object m_WrappedObject;

	[__DynamicallyInvokable]
	public object WrappedObject
	{
		[__DynamicallyInvokable]
		get
		{
			return m_WrappedObject;
		}
	}

	[__DynamicallyInvokable]
	public UnknownWrapper(object obj)
	{
		m_WrappedObject = obj;
	}
}
