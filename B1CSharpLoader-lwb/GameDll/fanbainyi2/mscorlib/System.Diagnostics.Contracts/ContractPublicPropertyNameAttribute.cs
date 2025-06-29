namespace System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Field)]
[__DynamicallyInvokable]
public sealed class ContractPublicPropertyNameAttribute : Attribute
{
	private string _publicName;

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return _publicName;
		}
	}

	[__DynamicallyInvokable]
	public ContractPublicPropertyNameAttribute(string name)
	{
		_publicName = name;
	}
}
