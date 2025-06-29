using System;
using System.Collections.Generic;
using System.Linq;
using AOT;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_RegisterGMSystemComp : UActorCompBaseCS
{
	private static List<string> sNameList = new List<string>();

	public override void OnBeginPlay()
	{
		InitAndRegisterConsoleCommand();
	}

	private void InitAndRegisterConsoleCommand()
	{
		InitCheatGM();
		InitDebugGM();
	}

	private void InitCheatGM()
	{
		if (BGWConsoleCommands.HasGMFlag(2))
		{
			GMInfo.SetCurRegistInfo(EGMType.GM_BUS, 2);
			RegisterConsoleCommand("bn.suicide", "Suicide Player", OnSuicide);
			RegisterConsoleCommand("bn.lockHp", "Lock Player Hp", OnLockHp);
			RegisterConsoleCommand("bn.unLockHp", "Unlock Player Hp", OnUnLockHp);
			RegisterConsoleCommand("bn.invincible", "Power Overwhelming", OnInvincible);
			RegisterConsoleCommand("bn.unInvincible", "Power Underwhelming", OnUnInvincible);
			RegisterConsoleCommand("bn.setAtk", "Set Player Attack (1 arg)", OnSetAttack);
			RegisterConsoleCommand("bn.setMaxHp", "Set Player Max Hp (1 arg)", OnSetMaxHp);
			RegisterConsoleCommand("bn.setMaxMp", "Set Player Max Mp (1 arg)", OnSetMaxMp);
			RegisterConsoleCommand("bn.fullHp", "Full Hp", OnFullHp);
			RegisterConsoleCommand("bn.fullMp", "Full Mp", OnFullMp);
			RegisterConsoleCommand("bn.fullBloodBottom", "Full BloodBottom", OnFullBloodBottom);
			RegisterConsoleCommand("bn.fullStamina", "Full Stamina", OnFullStamina);
			RegisterConsoleCommand("bn.fullEnergy", "Full Energy", OnFullEnergy);
			RegisterConsoleCommand("bn.addBuff", "Add Buff", OnAddBuff);
			RegisterConsoleCommand("bn.removeBuff", "Remove Buff", OnRemoveBuff);
			RegisterConsoleCommand("bn.removeAllBuff", "Remove All Buff", OnRemoveAllBuff);
			GMInfo.ResetCurRegistInfo();
		}
	}

	private void InitDebugGM()
	{
		if (BGWConsoleCommands.HasGMFlag(4))
		{
			GMInfo.SetCurRegistInfo(EGMType.GM_BUS, 4);
			RegisterConsoleCommand("bn.teleportToPosition", "Teleport To Position (3 args)", OnTeleportToPosition);
			RegisterConsoleCommand("bn.teleportToLevelPosition", "bn.teleportToLevelPosition LevelId X Y Z Pitch Yaw Roll", OnTeleportToLevelPosition);
			RegisterConsoleCommand("bn.returnToStart", "Return To Start", OnReturnToStart);
			RegisterConsoleCommand("bn.TickRateLogic", "Close TickRateLogic", OnTickRateLogic);
			RegisterConsoleCommand("bn.KillAllTargetInRange", "KillAllTargetInRange", OnKillAllTargetInRange);
			RegisterConsoleCommand("bn.UesItem", "Uesitem", OnUesitem);
			RegisterConsoleCommand("bn.SetQuickItem", "SetquickItem", OnSetquickItem);
			RegisterConsoleCommand("bn.UesQuickitem", "Uesitem", UesQuickitem);
			RegisterConsoleCommand("bn.ShepherdTest", "Shepherd Test", OnShepherdTest);
			RegisterConsoleCommand("bn.TryCastSkill", "TryCastSkill + UnitGuid + SkillId", OnGSTryCastSkill);
			RegisterConsoleCommand("bn.SGDTest", "SGD Test", OnSGDTest);
			RegisterConsoleCommand("bn.OpenInputLog", "Open input log", OnOpenInputLog);
			RegisterConsoleCommand("bn.CloseNetConnection", "Close net connection with our own close reason", OnCloseNetConnection);
			RegisterConsoleCommand("bn.CloseServerConnection", "Close server connection", OnCloseServerConnection);
			GMInfo.ResetCurRegistInfo();
		}
	}

	private void OnShepherdTest(string[] args)
	{
	}

	private void OnCloseNetConnection(string[] args)
	{
		UGameplayStatics.GetAllActorsOfClass(Owner, UClass.GetClass<APlayerController>(), out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item != UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner))
			{
				BPS_EventCollectionCS.Get(item as APlayerController).Evt_CloseConnectionWithResult.Invoke(EGSNetCloseResult.Test);
			}
		}
	}

	private void OnCloseServerConnection(string[] args)
	{
		UGSE_OnlineFuncLib.CloseServerConnection(EGSNetCloseResult.Test, Owner);
	}

	private void OnOpenInputLog(string[] args)
	{
		if (args.Length == 1)
		{
			if (args[0] == "0")
			{
				base.BGWEventCollection.Evt_OpenInputLog(bOpen: false);
			}
			else if (args[0] == "1")
			{
				base.BGWEventCollection.Evt_OpenInputLog(bOpen: true);
			}
		}
		else if (args.Length == 2)
		{
			if (args[0] == "0")
			{
				base.BGWEventCollection.Evt_OpenInputLog(bOpen: false);
			}
			else if (args[0] == "1")
			{
				base.BGWEventCollection.Evt_OpenInputLog(bOpen: true, args[1]);
			}
		}
		else
		{
			base.BGWEventCollection.Evt_OpenInputLog(bOpen: true);
		}
	}

	private void OnGSTryCastSkill(string[] args)
	{
		if (args.Length > 1)
		{
			string unitGuid = args[0];
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner.World, unitGuid);
			if (!(actorByGuid == null) && int.TryParse(args[1], out var result))
			{
				BGUFunctionLibraryCS.BGUTryCastSpell(actorByGuid, result, ECastSkillSourceType.GM);
			}
		}
	}

	private void ShepherdTest1(FName Key)
	{
	}

	private void ShepherdTest2(FName Key)
	{
	}

	private void OnReturnToStart(string[] args)
	{
		FVector actorLocation = UGameplayStatics.GetActorOfClass(GetOwner(), UClass.GetClass<APlayerStart>()).GetActorLocation();
		if (GetOwner() as BGUCharacterCS != null)
		{
			base.BUSEventCollection?.Evt_SetActorLocationGM.Invoke(actorLocation, bSweep: false, bTeleport: true);
		}
	}

	private void OnTeleportToPosition(string[] args)
	{
		if (args.Length == 3 && GetOwner() as BGUCharacterCS != null)
		{
			float.TryParse(args[0], out var result);
			float.TryParse(args[1], out var result2);
			float.TryParse(args[2], out var result3);
			base.BUSEventCollection?.Evt_SetActorLocationGM.Invoke(new FVector(result, result2, result3), bSweep: false, bTeleport: true);
			ActorFuncLib.SetActorTransformSimple(GetOwner().Address, new FTransform(new FVector(result, result2, result3)), bSweep: false, 1);
			BGUFunctionLibraryCS.BlockTillLevelStreamingCompleted(GetOwner().World);
		}
	}

	private void OnTeleportToLevelPosition(string[] args)
	{
		if (args.Length >= 1 && GetOwner() as BGUCharacterCS != null)
		{
			int.TryParse(args[0], out var result);
			bool levelTravelUseDefaultPlayerStart = true;
			float result2 = 0f;
			float result3 = 0f;
			float result4 = 0f;
			float result5 = 0f;
			float result6 = 0f;
			float result7 = 0f;
			if (args.Length >= 4)
			{
				levelTravelUseDefaultPlayerStart = false;
				float.TryParse(args[1], out result2);
				float.TryParse(args[2], out result3);
				float.TryParse(args[3], out result4);
			}
			if (args.Length >= 7)
			{
				float.TryParse(args[4], out result5);
				float.TryParse(args[5], out result6);
				float.TryParse(args[6], out result7);
			}
			FTransform teleportTransform = new FTransform(new FRotator(result5, result6, result7), new FVector(result2, result3, result4));
			BPS_EventCollectionCS.Get((Owner as APawn).PlayerState).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.SimpleLevelIdAndTransform, new TeleportParam_SimpleLevelIdAndTransform
			{
				LevelId = result,
				LevelTravelUseDefaultPlayerStart = levelTravelUseDefaultPlayerStart,
				TeleportTransform = teleportTransform
			}, EPlayerTeleportReason.Test);
		}
	}

	private void OnAddBuff(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result))
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BGUFunctionLibraryCS.BGUAddBuff(bGUCharacterCS, bGUCharacterCS, (int)result, EBuffSourceType.GM);
			}
		}
	}

	private void OnRemoveBuff(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result))
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BGUFunctionLibraryCS.BGURemoveBuffImmediately(bGUCharacterCS, (int)result, EBuffEffectTriggerType.None);
			}
		}
	}

	private void OnRemoveAllBuff(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGURemoveAllBuff(bGUCharacterCS, EBuffEffectTriggerType.None);
		}
	}

	private void OnFullHp(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.HpMax));
		}
	}

	private void OnFullEnergy(string[] args)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner() as BGUCharacterCS);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_GMSetFullEnergy.Invoke(1f);
		}
	}

	private void OnFullMp(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Mp, BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.MpMax));
		}
	}

	private void OnFullBloodBottom(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			float newValue = BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.BloodBottomNumMax);
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BloodBottomNum, newValue);
		}
	}

	private void OnFullStamina(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			float newValue = BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.StaminaMax);
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Stamina, newValue);
		}
	}

	private void OnSetMaxHp(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result) && !(result <= 0f))
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.HpMaxBase, result);
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, result);
		}
	}

	private void OnSetMaxMp(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result) && !(result <= 0f))
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.MpMaxBase, result);
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Mp, result);
		}
	}

	private void OnSuicide(string[] args)
	{
		base.BUSEventCollection?.Evt_GMUnitSuicide.Invoke();
	}

	private void OnTickRateLogic(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result))
		{
			BGS_GSEventCollection.Get(GetOwner()).Evt_BGS_SwitchTickRateLogic.Invoke((int)result);
		}
	}

	private void OnSGDTest(string[] args)
	{
		BGS_GSEventCollection.Get(GetOwner()).Evt_BGS_SwitchTickRateLogic.Invoke(1);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetOwner().World, UClass.GetClass<BGUPlayerCharacterCS>());
		foreach (AActor aActor in allActorsOfClass)
		{
			if (!aActor.IsNullOrDestroyed())
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueDamage, IsRemove: false);
			}
		}
		ABGUCharacter[] allActorsOfClass2 = GetOwner().World.GetAllActorsOfClass<ABGUCharacter>();
		if (allActorsOfClass2.Length < 1)
		{
			return;
		}
		ABGUCharacter[] array = allActorsOfClass2;
		foreach (ABGUCharacter aBGUCharacter in array)
		{
			if (BGUFunctionLibraryCS.BGUIsEnemyTeam(GetOwner(), aBGUCharacter))
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(aBGUCharacter, EBGUSimpleState.CancelSkillCD))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.CancelSkillCD, IsRemove: false);
				}
				BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(412107, ECastSkillSourceType.GM));
			}
		}
	}

	private void OnLockHp(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueDamage, IsRemove: false);
		}
	}

	private void OnKillAllTargetInRange(string[] args)
	{
		if (args.Length != 1)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(GetOwner());
		if (!float.TryParse(args[0].ToLower(), out var result))
		{
			return;
		}
		BGUCharacterCS[] array = allActorsOfClass;
		foreach (BGUCharacterCS bGUCharacterCS2 in array)
		{
			if (!bGUCharacterCS2.IsPlayerControlled() && FVector.Distance(bGUCharacterCS2.GetActorLocation(), bGUCharacterCS.GetActorLocation()) < result)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS2)?.Evt_UnitDead.Invoke(bGUCharacterCS, EDeadReason.SkillDamage, 0);
			}
		}
	}

	private void OnUesitem(string[] args)
	{
		if (args.Length == 1)
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (!(bGUCharacterCS == null) && int.TryParse(args[0].ToLower(), out var result))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_TriggerItemSkillAction_UseItem.Invoke(result);
			}
		}
	}

	private void OnSetquickItem(string[] args)
	{
		if (args.Length == 1)
		{
			_ = GetOwner() as BGUCharacterCS == null;
		}
	}

	private void UesQuickitem(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUC_PlayerItemData bUC_PlayerItemData = RequireWritableData<BUC_PlayerItemData>();
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_TriggerItemSkillAction_UseItem.Invoke(bUC_PlayerItemData.CurQuickItemId);
		}
	}

	private void OnUnLockHp(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueDamage, IsRemove: true);
		}
	}

	private void OnSetAttack(string[] args)
	{
		if (args.Length == 1 && float.TryParse(args[0].ToLower(), out var result))
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.AtkBase, result);
		}
	}

	private void OnInvincible(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueDamage, IsRemove: false);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueStiff, IsRemove: false);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueImmobilizing, IsRemove: false);
		}
	}

	private void OnUnInvincible(string[] args)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueDamage, IsRemove: true);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueStiff, IsRemove: true);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.ImmueImmobilizing, IsRemove: true);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ConsoleCommandCallback(IntPtr worldPtr)
	{
		try
		{
			UObject worldHelper = IConsoleManager.GetWorldHelper(worldPtr);
			List<string> p = ABGPPlayerController.GetCachedConsoleCommandCS().Split(' ').ToList();
			AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(worldHelper).GetControlledPawn();
			if (controlledPawn != null)
			{
				BUS_EventCollectionCS.Get(controlledPawn).Evt_ExecuteCommandGM.Invoke(p);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	private void RegisterConsoleCommand(string name, string help, FConsoleCommandInGMSystemDelegate command)
	{
		if (!sNameList.Contains(name))
		{
			sNameList.Add(name);
			try
			{
				IConsoleManager.Get().RegisterConsoleCommandWithWorld(name, help, ConsoleCommandCallback);
				GMInfo.RegisterGMInfo(name, help);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("failed to register console command " + name);
				BGW_LogUtil.LogError(ex.ToString());
				BGW_LogUtil.LogError(ex.StackTrace.ToString());
			}
		}
		RequireReadOnlyData<IBUC_GMSystemData, BUC_GMSystemData>()?.AddNameCommand(name, command);
	}
}
