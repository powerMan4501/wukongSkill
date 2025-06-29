using System.Runtime.InteropServices;

namespace System.Resources;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	private string _version;

	[__DynamicallyInvokable]
	public string Version
	{
		[__DynamicallyInvokable]
		get
		{
			return _version;
		}
	}

	[__DynamicallyInvokable]
	public SatelliteContractVersionAttribute(string version)
	{
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		_version = version;
	}
}
