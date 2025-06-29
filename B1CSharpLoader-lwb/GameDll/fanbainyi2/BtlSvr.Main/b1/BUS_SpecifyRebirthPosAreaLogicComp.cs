using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaLogicComp")]
public class BUS_SpecifyRebirthPosAreaLogicComp : UActorCompBaseUObj
{
	private BUC_SpecifyRebirthPosAreaData SpecifyRebirthPosData;

	private IBUC_GuidData GuidData;

	private b1.IBUC_AreaBasicData AreaBasicData;

	public override void OnAttach()
	{
		SpecifyRebirthPosData = RequireWritableData<BUC_SpecifyRebirthPosAreaData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		AreaBasicData = RequireReadOnlyData<b1.IBUC_AreaBasicData, BUC_AreaBasicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnterArea);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeaveArea);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	private void OnActorEnterArea(AActor OverlapActor)
	{
		if (OverlapActor is BGUPlayerCharacterCS bGUPlayerCharacterCS && AreaBasicData.IsLocalPlayer(bGUPlayerCharacterCS))
		{
			BPS_EventCollectionCS.Get(bGUPlayerCharacterCS.PlayerState)?.Evt_RegSpecialRebirthPoint.Invoke(new List<int> { SpecifyRebirthPosData.BindTuDiMiaoID, SpecifyRebirthPosData.BindZhaoHunFanID });
		}
	}

	private void OnActorLeaveArea(AActor OverlapActor)
	{
		if (OverlapActor is BGUPlayerCharacterCS bGUPlayerCharacterCS && AreaBasicData.IsLocalPlayer(bGUPlayerCharacterCS))
		{
			BPS_EventCollectionCS.Get(bGUPlayerCharacterCS.PlayerState)?.Evt_UnregSpecialRebirthPoint.Invoke(new List<int> { SpecifyRebirthPosData.BindTuDiMiaoID, SpecifyRebirthPosData.BindZhaoHunFanID });
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaLogicComp");
	}

	static BUS_SpecifyRebirthPosAreaLogicComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpecifyRebirthPosAreaLogicComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpecifyRebirthPosAreaLogicComp));
	}
}
