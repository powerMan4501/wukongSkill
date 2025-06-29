using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_PoleDrinkComp : UActorCompBaseCS
{
	private BUC_PoleDrinkData PoleDrinkData;

	private IBUC_AttrContainer AttrContainer;

	public override void OnAttach()
	{
		PoleDrinkData = RequireWritableData<BUC_PoleDrinkData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		base.BUSEventCollection.Evt_PoleDrinkStateBegin += new Del_PoleDrinkStateBegin(PoleDrinkStateBegin);
		base.BUSEventCollection.Evt_PoleDrinkStateEnd += new Del_Void(PoleDrinkStateEnd);
		base.BUSEventCollection.Evt_DoPoleDrink += new Del_DoPoleDrink(DoPoleDrink);
	}

	private void PoleDrinkStateBegin(UAnimMontage DrinkHPBottomSuccessAM, UAnimMontage DrinkHPBottomFailedAM, TMapReadWrite<int, UAnimMontage> UseItemAMMapping)
	{
		PoleDrinkData.bPoleDrinkFlag = true;
		PoleDrinkData.DrinkHPBottomSuccessAM = DrinkHPBottomSuccessAM;
		PoleDrinkData.DrinkHPBottomFailedAM = DrinkHPBottomFailedAM;
		PoleDrinkData.UseItemAMMapping.Clear();
		foreach (KeyValuePair<int, UAnimMontage> item in UseItemAMMapping)
		{
			PoleDrinkData.UseItemAMMapping.Add(item.Key, item.Value);
		}
	}

	private void PoleDrinkStateEnd()
	{
		if (PoleDrinkData.bPoleDrinkFlag)
		{
			PoleDrinkData.bPoleDrinkFlag = false;
			if (PoleDrinkData.CurPlayAM != null)
			{
				OwnerAsCharacterCS.StopAnimMontage(PoleDrinkData.CurPlayAM);
			}
			base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka.Invoke(0f);
			PoleDrinkData.CurMontageLength = 0f;
			PoleDrinkData.CurMontageRemainTime = 0f;
		}
	}

	private void DoPoleDrink(EPoleDrinkType PoleDrinkType, int SkillID, int PosIndex)
	{
		if (UGSE_AnimFuncLib.IsSlotPlayingMontage(OwnerAsCharacterCS.Mesh.GetAnimInstance(), B1GlobalFNames.AMMatryoshka))
		{
			return;
		}
		UAnimMontage uAnimMontage = null;
		switch (PoleDrinkType)
		{
		case EPoleDrinkType.DrinkHPBottom:
			uAnimMontage = PoleDrinkData.DrinkHPBottomFailedAM;
			if (AttrContainer != null && (int)AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNum) > 0)
			{
				uAnimMontage = PoleDrinkData.DrinkHPBottomSuccessAM;
			}
			break;
		case EPoleDrinkType.UseItem:
		{
			if (PoleDrinkData.UseItemAMMapping.TryGetValue(SkillID, out var value))
			{
				uAnimMontage = value;
			}
			break;
		}
		}
		if (!(uAnimMontage == null))
		{
			float num = BGUFuncLibAnim.BGUActorTryPlayMontage(OwnerAsCharacterCS, uAnimMontage, FName.None);
			if (num > 0f)
			{
				PoleDrinkData.CurPlayAM = uAnimMontage;
				PoleDrinkData.CurMontageLength = num;
				PoleDrinkData.CurMontageRemainTime = PoleDrinkData.CurMontageLength;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PoleDrinkData.CurMontageRemainTime > 0f)
		{
			PoleDrinkData.CurMontageRemainTime -= DeltaTime;
			float num = 0f;
			num = ((PoleDrinkData.CurMontageRemainTime <= 0f) ? 0f : ((PoleDrinkData.CurMontageRemainTime <= PoleDrinkData.BlendOutTime) ? ((!(PoleDrinkData.BlendOutTime > 0f)) ? 0f : (PoleDrinkData.CurMontageRemainTime / PoleDrinkData.BlendOutTime)) : ((!(PoleDrinkData.CurMontageLength - PoleDrinkData.CurMontageRemainTime <= PoleDrinkData.BlendInTime)) ? 1f : ((!(PoleDrinkData.BlendInTime > 0f)) ? 1f : ((PoleDrinkData.CurMontageLength - PoleDrinkData.CurMontageRemainTime) / PoleDrinkData.BlendInTime)))));
			base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka.Invoke(num);
		}
	}
}
