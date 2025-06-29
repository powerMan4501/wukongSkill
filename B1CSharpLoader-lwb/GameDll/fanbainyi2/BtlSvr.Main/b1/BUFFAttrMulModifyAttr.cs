using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public class BUFFAttrMulModifyAttr : BUFixFunctionTemplate
{
	public BUFFAttrMulModifyAttr()
	{
		Type = EFixFunctionType.AttrMulModifyAttr;
	}

	public override void ApplyBySkill(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
	}

	public override void ApplyByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
	}

	public override void RemoveByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
		OutAbs = 0f - OutAbs;
		OutMul = 1f / OutMul;
	}

	private void Apply(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		float valueFromAttrID = BGUFunctionLibraryCS.GetValueFromAttrID(Target, Param2);
		float valueFromAttrID2 = BGUFunctionLibraryCS.GetValueFromAttrID(Target, Param3);
		float num = (float)Param4 / 10000f;
		OutAbs = ((valueFromAttrID <= valueFromAttrID2 * num) ? (valueFromAttrID * Param6) : (valueFromAttrID2 * num * Param6));
		OutMul = OutAbs / 10000f;
	}
}
