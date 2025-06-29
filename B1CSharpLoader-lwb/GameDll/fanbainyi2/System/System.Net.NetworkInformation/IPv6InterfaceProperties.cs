namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPv6InterfaceProperties
{
	[global::__DynamicallyInvokable]
	public abstract int Index
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int Mtu
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public virtual long GetScopeId(ScopeLevel scopeLevel)
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	protected IPv6InterfaceProperties()
	{
	}
}
