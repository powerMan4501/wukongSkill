namespace System.Runtime.InteropServices;

[Serializable]
[__DynamicallyInvokable]
public sealed class VariantWrapper
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
	public VariantWrapper(object obj)
	{
		m_WrappedObject = obj;
	}
}
