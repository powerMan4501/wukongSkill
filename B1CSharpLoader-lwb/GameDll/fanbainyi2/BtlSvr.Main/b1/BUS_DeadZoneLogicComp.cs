using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DeadZoneLogicComp")]
public class BUS_DeadZoneLogicComp : UActorCompBaseUObj
{
	private BUC_DeadAreaLogicData DeadAreaLogicData;

	private static bool PlayerCliffFallRollBack_IsValid;

	private static IntPtr PlayerCliffFallRollBack_FunctionAddress;

	private static int PlayerCliffFallRollBack_ParamsSize;

	public override void OnAttach()
	{
		DeadAreaLogicData = RequireWritableData<BUC_DeadAreaLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DeadAreaLogicData.DeadActor != null)
		{
			BUS_EventCollectionCS.Get(DeadAreaLogicData.DeadActor).Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
			DeadAreaLogicData.DeadActor = null;
		}
	}

	private void OnActorEnter(AActor OtherActor)
	{
		if (DebugConfig.EnablePlaneMoveMode || OtherActor.IsNullOrDestroyed())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		bool flag = false;
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueDeadZone) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CloudMove))
		{
			return;
		}
		if (BGU_DataUtil.GetActorType(bGUCharacterCS) == BGU_ActorType.CharacterAI)
		{
			int resID = bGUCharacterCS.GetResID();
			if (resID == 3800 || resID == 3900)
			{
				return;
			}
			Wrapper_SkillDamage(bGUCharacterCS, 10000f);
			flag = true;
		}
		else
		{
			Wrapper_SkillDamage(bGUCharacterCS, 10000f);
			flag = BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Dead);
			if (!flag)
			{
				this.SetTimer("PlayerCliffFallRollBack", 2f, bLooping: false);
			}
			else
			{
				bUS_GSEventCollection.Evt_FallIntoDeadZone.Invoke();
			}
		}
		if (flag)
		{
			DeadAreaLogicData.DeadActor = OtherActor;
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_DeadZoneLogicComp:PlayerCliffFallRollBack")]
	private void PlayerCliffFallRollBack()
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner()).GetControlledPawn()).Evt_PlayerFallCliffRollBack.Invoke();
	}

	private void Wrapper_SkillDamage(AActor Target, float TargetHpMaxRatio)
	{
		BUS_EventCollectionCS.Get(Target)?.Evt_TriggerNormalDamageEffect.Invoke(null, new FSkillDamageConfig
		{
			DamageCalcType = EDamageCalcType.HPMaxRatioAbs,
			HPMaxINV10000Damage_Abs = TargetHpMaxRatio,
			DamageImmueLevel = 2,
			DmgReason = EDamageReason.DeadZone
		}, default(FEffectInstReq), new FBattleAttrSnapShot(null));
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_DeadZoneLogicComp:PlayerCliffFallRollBack")]
	private static void PlayerCliffFallRollBack__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_DeadZoneLogicComp bUS_DeadZoneLogicComp = GCHelper.Find<BUS_DeadZoneLogicComp>(obj);
		bUS_DeadZoneLogicComp.PlayerCliffFallRollBack();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_DeadZoneLogicComp");
		PlayerCliffFallRollBack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayerCliffFallRollBack");
		PlayerCliffFallRollBack_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayerCliffFallRollBack_FunctionAddress);
		PlayerCliffFallRollBack_IsValid = PlayerCliffFallRollBack_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_DeadZoneLogicComp:PlayerCliffFallRollBack", PlayerCliffFallRollBack_IsValid);
	}

	static BUS_DeadZoneLogicComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DeadZoneLogicComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DeadZoneLogicComp));
	}
}
