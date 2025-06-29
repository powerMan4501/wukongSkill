using System;
using BtlShare;
using OssB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibPlayer")]
public class BGUFuncLibPlayer : UBlueprintFunctionLibrary
{
	public struct SpawnControlledPawnBlendParam
	{
		public bool NeedBlend;

		public float PossessBlendTime;

		public int PossessBlendFunc;

		public float PossessBlendExp;

		public bool EnableBlendViewTarget;
	}

	public static void SpwanAndPossesPlayerContrlledPawn(ABGPPlayerController Controller, UClass PawnClass, FTransform SpawnTransform, Action<APawn> BeforeBeginPlayCB, SpawnControlledPawnBlendParam BlendParam)
	{
		APawn controlledPawn = Controller.GetControlledPawn();
		APawn aPawn = BGU_UnrealActorUtil.BGUBeginDeferredActorSpawnFromClass(Controller.World, PawnClass, SpawnTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as APawn;
		if (BlendParam.NeedBlend)
		{
			Controller.OnPossessWithViewTargetBlend(aPawn, BlendParam.PossessBlendTime, (EViewTargetBlendFunction)BlendParam.PossessBlendFunc, BlendParam.PossessBlendExp, bLockOutgoing: true, BlendParam.EnableBlendViewTarget);
		}
		else
		{
			Controller.Possess(aPawn);
		}
		BeforeBeginPlayCB(aPawn);
		ACharacter obj = aPawn as ACharacter;
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		BGU_UnrealActorUtil.BGUFinishSpawningActorAndECSBeginPlay(Controller, aPawn, SpawnTransform);
		BPS_GSEventCollection.Get(Controller).Evt_BPS_OnControlledPawnChange.Invoke(aPawn);
		BGS_EventCollectionCS.Get(Controller)?.Evt_NotifyPossessEntityChanged.Invoke(ECSExtension.ToEntity(controlledPawn), ECSExtension.ToEntity(aPawn));
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		UGSE_ActorFuncLib.UpdateActorOverlaps(obj);
	}

	public static void SpwanAndPossesPlayerContrlledPawnWithoutECSBeginplay(ABGPPlayerController Controller, UClass PawnClass, FTransform SpawnTransform, Action<APawn> BeforeBeginPlayCB, SpawnControlledPawnBlendParam BlendParam)
	{
		APawn controlledPawn = Controller.GetControlledPawn();
		APawn aPawn = BGU_UnrealActorUtil.BGUBeginDeferredActorSpawnFromClass(Controller.World, PawnClass, SpawnTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as APawn;
		AActor viewTarget = Controller.GetViewTarget();
		if (BlendParam.NeedBlend)
		{
			Controller.OnPossessWithViewTargetBlend(aPawn, BlendParam.PossessBlendTime, (EViewTargetBlendFunction)BlendParam.PossessBlendFunc, BlendParam.PossessBlendExp, bLockOutgoing: true, BlendParam.EnableBlendViewTarget);
		}
		else
		{
			Controller.Possess(aPawn);
		}
		if (B1Global.GIsMovieRendering)
		{
			Controller.SetViewTargetWithBlend(viewTarget);
		}
		BeforeBeginPlayCB(aPawn);
		ACharacter obj = aPawn as ACharacter;
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		BGU_UnrealActorUtil.BGUFinishSpawningActor(aPawn, SpawnTransform);
		BPS_GSEventCollection.Get(Controller).Evt_BPS_OnControlledPawnChange.Invoke(aPawn);
		BGS_EventCollectionCS.Get(Controller)?.Evt_NotifyPossessEntityChanged.Invoke(ECSExtension.ToEntity(controlledPawn), ECSExtension.ToEntity(aPawn));
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		obj.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		UGSE_ActorFuncLib.UpdateActorOverlaps(obj);
	}

	public static PlayerInfo GetPlayerInfoData(UObject WorldCtx)
	{
		PlayerInfo playerInfo = new PlayerInfo();
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldCtx)?.GetControlledPawn();
		if (aPawn != null && aPawn.GetController() != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPawn.GetController());
			playerInfo.Battle = GetSvrPlayerInfoBattleData(WorldCtx);
			if (readOnlyData != null && readOnlyData.RoleData != null)
			{
				playerInfo.Role = new PlayerInfoRole();
				RoleDataHelper.FillOssPlayerRoleInfo(readOnlyData.RoleData, playerInfo.Role, WorldCtx);
			}
		}
		return playerInfo;
	}

	public static DeviceInfo GetDeviceInfoData()
	{
		DeviceInfo deviceInfo = new DeviceInfo();
		UGSE_EngineFuncLib.GetDeviceInfo(out var Cpu, out var Gpu, out var MemSize);
		deviceInfo.Mem = (uint)MemSize;
		deviceInfo.Cpu = Cpu;
		deviceInfo.Gpu = Gpu;
		return deviceInfo;
	}

	public static PlayerInfoBattle GetSvrPlayerInfoBattleData(UObject WorldCtx)
	{
		return GetPlayerInfoBattleData(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldCtx)?.GetControlledPawn());
	}

	public static PlayerInfoBattle GetPlayerInfoBattleData(APawn Player)
	{
		PlayerInfoBattle playerInfoBattle = new PlayerInfoBattle();
		if (BGU_DataUtil.GetActorType(Player) != BGU_ActorType.CharacterPlayer)
		{
			return playerInfoBattle;
		}
		if (Player != null && Player.GetController() != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(Player.GetController());
			IBUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Player);
			playerInfoBattle.ResId = BGU_DataUtil.GetActorResID(Player);
			if (readOnlyData2 != null)
			{
				playerInfoBattle.MaxHp = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.HpMax);
				playerInfoBattle.MaxMp = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.MpMax);
				playerInfoBattle.MaxPh = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.StaminaMax);
				playerInfoBattle.CurHp = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.Hp);
				playerInfoBattle.CurMp = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.Mp);
				playerInfoBattle.MaxGourd = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.BloodBottomNumMax);
				playerInfoBattle.CurGourd = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.BloodBottomNum);
				playerInfoBattle.CurAtk = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.Atk);
				playerInfoBattle.CurDefence = (int)readOnlyData2.GetFloatValue(EBGUAttrFloat.Def);
			}
			if (readOnlyData != null && readOnlyData.RoleData != null)
			{
				playerInfoBattle.RoleId = readOnlyData.RoleData.RoleCs.Base.Roleid;
				playerInfoBattle.WearInfo = new PlayerInfoWear();
				RoleDataHelper.FillOssPlayerWearInfo(readOnlyData.RoleData, playerInfoBattle.WearInfo);
			}
		}
		return playerInfoBattle;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibPlayer");
	}

	static BGUFuncLibPlayer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibPlayer));
	}
}
