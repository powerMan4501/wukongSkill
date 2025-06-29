namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class BestFitMappingAttribute : Attribute
{
	internal bool _bestFitMapping;

	[__DynamicallyInvokable]
	public bool ThrowOnUnmappableChar;

	[__DynamicallyInvokable]
	public bool BestFitMapping
	{
		[__DynamicallyInvokable]
		get
		{
			return _bestFitMapping;
		}
	}

	[__DynamicallyInvokable]
	public BestFitMappingAttribute(bool BestFitMapping)
	{
		_bestFitMapping = BestFitMapping;
	}
}
