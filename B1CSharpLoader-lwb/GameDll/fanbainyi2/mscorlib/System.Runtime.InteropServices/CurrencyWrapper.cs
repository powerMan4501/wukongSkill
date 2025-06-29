namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class CurrencyWrapper
{
	private decimal m_WrappedObject;

	[__DynamicallyInvokable]
	public decimal WrappedObject
	{
		[__DynamicallyInvokable]
		get
		{
			return m_WrappedObject;
		}
	}

	[__DynamicallyInvokable]
	public CurrencyWrapper(decimal obj)
	{
		m_WrappedObject = obj;
	}

	[__DynamicallyInvokable]
	public CurrencyWrapper(object obj)
	{
		if (!(obj is decimal))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDecimal"), "obj");
		}
		m_WrappedObject = (decimal)obj;
	}
}
