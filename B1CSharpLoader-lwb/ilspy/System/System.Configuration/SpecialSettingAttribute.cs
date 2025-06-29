namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class SpecialSettingAttribute : Attribute
{
	private readonly SpecialSetting _specialSetting;

	public SpecialSetting SpecialSetting => _specialSetting;

	public SpecialSettingAttribute(SpecialSetting specialSetting)
	{
		_specialSetting = specialSetting;
	}
}
