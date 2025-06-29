namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
[__DynamicallyInvokable]
public sealed class AssemblySignatureKeyAttribute : Attribute
{
	private string _publicKey;

	private string _countersignature;

	[__DynamicallyInvokable]
	public string PublicKey
	{
		[__DynamicallyInvokable]
		get
		{
			return _publicKey;
		}
	}

	[__DynamicallyInvokable]
	public string Countersignature
	{
		[__DynamicallyInvokable]
		get
		{
			return _countersignature;
		}
	}

	[__DynamicallyInvokable]
	public AssemblySignatureKeyAttribute(string publicKey, string countersignature)
	{
		_publicKey = publicKey;
		_countersignature = countersignature;
	}
}
