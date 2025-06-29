namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
[__DynamicallyInvokable]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName;

	private bool _allInternalsVisible = true;

	[__DynamicallyInvokable]
	public string AssemblyName
	{
		[__DynamicallyInvokable]
		get
		{
			return _assemblyName;
		}
	}

	public bool AllInternalsVisible
	{
		get
		{
			return _allInternalsVisible;
		}
		set
		{
			_allInternalsVisible = value;
		}
	}

	[__DynamicallyInvokable]
	public InternalsVisibleToAttribute(string assemblyName)
	{
		_assemblyName = assemblyName;
	}
}
