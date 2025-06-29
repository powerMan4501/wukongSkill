using BtlB1;

namespace b1;

public class FPartHitAttrRecoverConfig
{
	public EHitPartRecoverAttrType RecoverAttrType;

	public EHitPartRecoverAttrConversionType RecoverAttrConversionType;

	public float DamageConversionRatio;

	public EValueClampType ValueClampType;

	public float MinValue;

	public float MaxValue;

	public FPartHitAttrRecoverConfig(FUStPartHitAttrRecoverConfig PartHitAttrConfigDesc)
	{
		RecoverAttrType = PartHitAttrConfigDesc.RecoverAttrType;
		RecoverAttrConversionType = PartHitAttrConfigDesc.RecoverAttrConversionType;
		DamageConversionRatio = PartHitAttrConfigDesc.DamageConversionRatio;
		ValueClampType = PartHitAttrConfigDesc.ValueClampType;
		MinValue = PartHitAttrConfigDesc.MinValue;
		MaxValue = PartHitAttrConfigDesc.MaxValue;
	}
}
