using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public class BUFFPlayerCountAttr : BUFixFunctionTemplate
{
	public BUFFPlayerCountAttr()
	{
		Type = EFixFunctionType.PlayerCountAttr;
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
		BGC_LevelBattleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_LevelBattleData>(UGameplayStatics.GetGameState(Target.World));
		BUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		int num = 0;
		if (readOnlyData != null)
		{
			num = readOnlyData2.GetBuffLayer(readOnlyData.DifficultBuffId);
		}
		OutMul = 1f;
		switch (num)
		{
		case 1:
			OutAbs = Param2;
			break;
		case 2:
			OutAbs = Param3;
			break;
		case 3:
			OutAbs = Param4;
			break;
		default:
			OutAbs = 0f;
			break;
		}
	}
}
