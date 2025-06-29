namespace System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[Conditional("DEBUG")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[__DynamicallyInvokable]
public sealed class ContractClassAttribute : Attribute
{
	private Type _typeWithContracts;

	[__DynamicallyInvokable]
	public Type TypeContainingContracts
	{
		[__DynamicallyInvokable]
		get
		{
			return _typeWithContracts;
		}
	}

	[__DynamicallyInvokable]
	public ContractClassAttribute(Type typeContainingContracts)
	{
		_typeWithContracts = typeContainingContracts;
	}
}
