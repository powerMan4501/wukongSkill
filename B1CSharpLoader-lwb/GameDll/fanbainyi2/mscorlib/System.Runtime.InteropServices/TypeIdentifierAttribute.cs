namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[ComVisible(false)]
[__DynamicallyInvokable]
public sealed class TypeIdentifierAttribute : Attribute
{
	internal string Scope_;

	internal string Identifier_;

	[__DynamicallyInvokable]
	public string Scope
	{
		[__DynamicallyInvokable]
		get
		{
			return Scope_;
		}
	}

	[__DynamicallyInvokable]
	public string Identifier
	{
		[__DynamicallyInvokable]
		get
		{
			return Identifier_;
		}
	}

	[__DynamicallyInvokable]
	public TypeIdentifierAttribute()
	{
	}

	[__DynamicallyInvokable]
	public TypeIdentifierAttribute(string scope, string identifier)
	{
		Scope_ = scope;
		Identifier_ = identifier;
	}
}
