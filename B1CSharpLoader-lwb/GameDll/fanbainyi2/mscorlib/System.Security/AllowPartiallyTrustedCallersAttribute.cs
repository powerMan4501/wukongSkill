using System.Runtime.InteropServices;

namespace System.Security;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AllowPartiallyTrustedCallersAttribute : Attribute
{
	private PartialTrustVisibilityLevel _visibilityLevel;

	public PartialTrustVisibilityLevel PartialTrustVisibilityLevel
	{
		get
		{
			return _visibilityLevel;
		}
		set
		{
			_visibilityLevel = value;
		}
	}

	[__DynamicallyInvokable]
	public AllowPartiallyTrustedCallersAttribute()
	{
	}
}
