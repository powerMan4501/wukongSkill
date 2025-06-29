namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
[__DynamicallyInvokable]
public sealed class ReferenceAssemblyAttribute : Attribute
{
	private string _description;

	[__DynamicallyInvokable]
	public string Description
	{
		[__DynamicallyInvokable]
		get
		{
			return _description;
		}
	}

	[__DynamicallyInvokable]
	public ReferenceAssemblyAttribute()
	{
	}

	[__DynamicallyInvokable]
	public ReferenceAssemblyAttribute(string description)
	{
		_description = description;
	}
}
