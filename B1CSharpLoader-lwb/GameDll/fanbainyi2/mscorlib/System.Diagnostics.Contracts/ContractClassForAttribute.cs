namespace System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
[__DynamicallyInvokable]
public sealed class ContractClassForAttribute : Attribute
{
	private Type _typeIAmAContractFor;

	[__DynamicallyInvokable]
	public Type TypeContractsAreFor
	{
		[__DynamicallyInvokable]
		get
		{
			return _typeIAmAContractFor;
		}
	}

	[__DynamicallyInvokable]
	public ContractClassForAttribute(Type typeContractsAreFor)
	{
		_typeIAmAContractFor = typeContractsAreFor;
	}
}
