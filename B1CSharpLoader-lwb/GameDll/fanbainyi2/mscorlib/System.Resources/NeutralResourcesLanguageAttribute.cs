using System.Runtime.InteropServices;

namespace System.Resources;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	private string _culture;

	private UltimateResourceFallbackLocation _fallbackLoc;

	[__DynamicallyInvokable]
	public string CultureName
	{
		[__DynamicallyInvokable]
		get
		{
			return _culture;
		}
	}

	public UltimateResourceFallbackLocation Location => _fallbackLoc;

	[__DynamicallyInvokable]
	public NeutralResourcesLanguageAttribute(string cultureName)
	{
		if (cultureName == null)
		{
			throw new ArgumentNullException("cultureName");
		}
		_culture = cultureName;
		_fallbackLoc = UltimateResourceFallbackLocation.MainAssembly;
	}

	public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location)
	{
		if (cultureName == null)
		{
			throw new ArgumentNullException("cultureName");
		}
		if (!Enum.IsDefined(typeof(UltimateResourceFallbackLocation), location))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidNeutralResourcesLanguage_FallbackLoc", location));
		}
		_culture = cultureName;
		_fallbackLoc = location;
	}
}
