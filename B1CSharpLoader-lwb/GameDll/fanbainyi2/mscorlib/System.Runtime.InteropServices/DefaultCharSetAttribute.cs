namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Module, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DefaultCharSetAttribute : Attribute
{
	internal CharSet _CharSet;

	[__DynamicallyInvokable]
	public CharSet CharSet
	{
		[__DynamicallyInvokable]
		get
		{
			return _CharSet;
		}
	}

	[__DynamicallyInvokable]
	public DefaultCharSetAttribute(CharSet charSet)
	{
		_CharSet = charSet;
	}
}
