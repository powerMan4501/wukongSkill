namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
[__DynamicallyInvokable]
public sealed class RuntimeCompatibilityAttribute : Attribute
{
	private bool m_wrapNonExceptionThrows;

	[__DynamicallyInvokable]
	public bool WrapNonExceptionThrows
	{
		[__DynamicallyInvokable]
		get
		{
			return m_wrapNonExceptionThrows;
		}
		[__DynamicallyInvokable]
		set
		{
			m_wrapNonExceptionThrows = value;
		}
	}

	[__DynamicallyInvokable]
	public RuntimeCompatibilityAttribute()
	{
	}
}
