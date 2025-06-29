namespace System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
[__DynamicallyInvokable]
public sealed class ContractVerificationAttribute : Attribute
{
	private bool _value;

	[__DynamicallyInvokable]
	public bool Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _value;
		}
	}

	[__DynamicallyInvokable]
	public ContractVerificationAttribute(bool value)
	{
		_value = value;
	}
}
