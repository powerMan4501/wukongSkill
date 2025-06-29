using BtlB1;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class BUFFPlayerWinePartnerAttr : BUFixFunctionTemplate
{
	public BUFFPlayerWinePartnerAttr()
	{
		Type = EFixFunctionType.PlayerWinePartnerAttr;
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
		ABGUCharacter aBGUCharacter = Target as ABGUCharacter;
		int num = 0;
		if (aBGUCharacter != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aBGUCharacter.GetController());
			if (readOnlyData != null)
			{
				ReadOnlyRoleDataCS roleCs = readOnlyData.RoleData.RoleCs;
				int wineId = roleCs.Actor.Wear.WineId;
				foreach (ReadOnlyRoleWine wine in roleCs.Bag.WineList)
				{
					if (wine.WineId != wineId)
					{
						continue;
					}
					foreach (ReadOnlyWinePartner item in wine.ItemList)
					{
						if (item.ItemId != 0)
						{
							num++;
						}
					}
					break;
				}
			}
		}
		OutAbs = (float)num * Param6;
		OutMul = OutAbs / 10000f;
	}
}
