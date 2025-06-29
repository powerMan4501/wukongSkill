using BtlB1;

namespace b1;

public class FSpellEffectForData
{
	public ESpellTriggerEffectType TriggerEffectType { get; }

	public ESpellTargetBaseType TargetBaseType { get; }

	public int Value { get; }

	public FSpellEffectForData(FSpellEffect InSpellEffect)
	{
		TriggerEffectType = InSpellEffect.EffectType;
		TargetBaseType = InSpellEffect.TargetBaseType;
		Value = InSpellEffect.Value;
	}
}
