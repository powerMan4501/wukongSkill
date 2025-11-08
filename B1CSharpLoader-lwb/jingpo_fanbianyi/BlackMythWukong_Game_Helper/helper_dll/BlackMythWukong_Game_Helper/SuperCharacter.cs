using System;
using System.Collections.Generic;
using System.Reflection;
using b1;
using b1.BGW;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public class SuperCharacter
{
	private AttrBool AttrBool_;

	public AttrBool Att => AttrBool_;

	public SuperCharacter()
	{
		AttrBool_ = GlobalObjectMgr.Get<AttrBool>();
	}

	public void OnGSLockHP()
	{
		AActor controlledPawn = MyUtils.GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueDamage))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueDamage, IsRemove: false);
				Att.LockHP = true;
			}
			else
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueDamage, IsRemove: true);
				Att.LockHP = false;
			}
		}
		UIPlayStory(Att.LockHP ? "锁血开启" : "锁血关闭", 1f);
	}

	public void OnGSLockMP()
	{
		AActor controlledPawn = MyUtils.GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(controlledPawn, EBGUSimpleState.LockMP))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.LockMP, IsRemove: false);
				Att.LockMP = true;
			}
			else
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.LockMP, IsRemove: true);
				Att.LockMP = false;
			}
		}
		UIPlayStory(Att.LockMP ? "锁蓝开启" : "锁蓝关闭", 1f);
	}

	public void OnGSLockPE()
	{
		AActor controlledPawn = MyUtils.GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(controlledPawn, EBGUSimpleState.PELock))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.PELock, IsRemove: false);
				BGUFunctionLibraryCS.GM_AddAttr(controlledPawn, (EBGUAttrFloat)191, 999f);
				Att.LockPE = true;
			}
			else
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.PELock, IsRemove: true);
				Att.LockPE = false;
			}
		}
		UIPlayStory(Att.LockPE ? "锁棍势开启" : "锁棍势关闭", 1f);
	}

	public void OnGSLockStamina()
	{
		Att.LockStamina = !Att.LockStamina;
		AActor controlledPawn = MyUtils.GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.StaminaLock, !Att.LockStamina);
		}
		UIPlayStory(Att.LockStamina ? "锁耐力开启" : "锁耐力关闭", 1f);
	}

	public void OnGSLockVigorEnergy()
	{
		Att.LockVigorEnergy = !Att.LockVigorEnergy;
		AActor controlledPawn = MyUtils.GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.VigorEnergyLock, !Att.LockVigorEnergy);
		}
		UIPlayStory(Att.LockVigorEnergy ? "锁精魄能量开启" : "锁精魄能量关闭", 1f);
	}

	public void OnGSLockCD()
	{
		AActor controlledPawn = MyUtils.GetControlledPawn();
		BUS_EventCollectionCS.Get(controlledPawn).Evt_ResetSkillCD.Invoke();
		BUS_EventCollectionCS.Get(controlledPawn).Evt_GMSetFullEnergy.Invoke(1f);
		UIPlayStory("法术CD重置成功", 1f);
	}

	public void OnGSSetSpeed()
	{
		Att.LockSpeed = !Att.LockSpeed;
		BUC_SpeedCtrlData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SpeedCtrlData>((AActor)(object)(MyUtils.GetControlledPawn() as BGUPlayerCharacterCS));
		if (Att.LockSpeed)
		{
			unPersistentReadOnlyData.SetSpeedInfoBase(5400f, 4550f, 160f);
		}
		else
		{
			unPersistentReadOnlyData.SetSpeedInfoBase(1080f, 650f, 160f);
		}
		UIPlayStory(Att.LockSpeed ? "超级移速开启" : "超级移速关闭", 1f);
	}

	public void OnGSPreciseDodge()
	{
		if (Att.LockPrecise && Att.LockPreciseType != 0)
		{
			Att.LockPreciseType = 0;
			UIPlayStory("精准闪避开启", 1f);
		}
		else
		{
			Att.LockPreciseType = 0;
			Att.LockPrecise = !Att.LockPrecise;
			UIPlayStory((Att.LockPreciseType == 0 && Att.LockPrecise) ? "精准闪避开启" : "精准闪避关闭", 1f);
		}
	}

	public void OnGSPreciseGP()
	{
		if (Att.LockPrecise && Att.LockPreciseType != 1)
		{
			Att.LockPreciseType = 1;
			UIPlayStory("自动识破开启", 1f);
		}
		else
		{
			Att.LockPreciseType = 1;
			Att.LockPrecise = !Att.LockPrecise;
			UIPlayStory((Att.LockPreciseType == 1 && Att.LockPrecise) ? "自动识破开启" : "自动识破关闭", 1f);
		}
	}

	public void OnGSPreciseHMQ()
	{
		if (Att.LockPrecise && Att.LockPreciseType != 2)
		{
			Att.LockPreciseType = 2;
			UIPlayStory("精准定身开启", 1f);
		}
		else
		{
			Att.LockPreciseType = 2;
			Att.LockPrecise = !Att.LockPrecise;
			UIPlayStory((Att.LockPreciseType == 2 && Att.LockPrecise) ? "精准定身开启" : "精准定身关闭", 1f);
		}
	}

	public void OnGSLockJDY()
	{
		Att.LockJDY = !Att.LockJDY;
		BGUFunctionLibraryCS.BGUTryCastSpellWithStartSection(MyUtils.GetControlledPawn(), Att.LockJDY ? 10203 : 10211, new FName("AM_Dasheng_ComGpoA_01_Z_1"));
	}

	public void OnGsKuaiSuXuLi(int num)
	{
		int num2 = ((num == Att.LockKuaiSuXuLi) ? 1 : num);
		FUStPassiveSkillDesc passiveSkillDescByMappingIndex = BGW_GameDB.GetPassiveSkillDescByMappingIndex(10507, 4);
		if (passiveSkillDescByMappingIndex != null)
		{
			passiveSkillDescByMappingIndex.ValOp = (EValOp)2;
			passiveSkillDescByMappingIndex.BaseValue = 5 * num2;
			passiveSkillDescByMappingIndex.MainID = "50016,50091,246,285,286";
			BUS_GSEventCollection bUS_GSEventCollection = MyUtils.GetBUS_GSEventCollection();
			bUS_GSEventCollection.Evt_PassiveSkillModifyParam.Invoke(10507, 4, bRecover: false, 4);
			bUS_GSEventCollection.Evt_PassiveSkillModifyParam.Invoke(20302, 1, bRecover: false, 1);
			Att.LockKuaiSuXuLi = num2;
			UIPlayStory($"当前蓄力速度{num2}倍", 1f);
		}
	}

	public void OnGSLockSpellRebirth()
	{
		Att.LockSpellRebirth = !Att.LockSpellRebirth;
		UIPlayStory(Att.LockSpellRebirth ? "法术轮回开启" : "法术轮回关闭", 1f);
	}

	public static void UIPlayStory(string _string, float time)
	{
		try
		{
			BGW_UIMgr.Get(MyUtils.GetWorld())?.PlaySubtitle("浪漫", _string, time);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	public static void OnSummonBossByAssetPath(string AssetPath)
	{
		APawn controlledPawn = MyUtils.GetControlledPawn();
		UWorld world = MyUtils.GetWorld();
		UClass uClass = BGW_PreloadAssetMgr.Get((UObject)controlledPawn.World).TryGetCachedResourceObj<UClass>(AssetPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, (Action<int, UObject>)null, -1, -1);
		if (uClass != null)
		{
			AActor aActor = controlledPawn;
			FVector actorLocation = controlledPawn.GetActorLocation();
			FVector fVector = controlledPawn.GetActorForwardVector() * 1500.0;
			FVector fVector2 = actorLocation + fVector;
			FRotator rotation = UMathLibrary.FindLookAtRotation(fVector2, actorLocation);
			BUTamerActor bUTamerActor = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, fVector2, rotation) as BUTamerActor;
			if (!((UObject)(object)bUTamerActor == null))
			{
				bUTamerActor.CurrentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
				int finalBattleInfoExtendID = bUTamerActor.GetFinalBattleInfoExtendID();
				FTransform actorTransform = controlledPawn.GetActorTransform();
				actorTransform.Translation = fVector2 + bUTamerActor.CurrentRef.CapsuleHalfHeight + aActor.GetActorForwardVector();
				FTamerRef currentRef = bUTamerActor.CurrentRef;
				currentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
				currentRef.ResetLocationCache();
				currentRef.TamerTransform = actorTransform;
				FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
				currentRef.OverrideResetType = (EBGUResetType)3;
				currentRef.GroupOverrideResetType = (EBGUResetType)3;
				field.SetValue(currentRef, ETamerPhase.Loaded);
				((ABGUTamerBase)bUTamerActor).TamerType = (ETamerType)2;
				currentRef.ResetLocationCache();
				currentRef.TamerTransform = actorTransform;
			}
		}
	}

	public static void MonsterTeleport(int num)
	{
		try
		{
			GMMonsterTeleportDesc gMMonsterTeleportDesc = GameDBRuntime.GetGMMonsterTeleportDesc(num);
			if (gMMonsterTeleportDesc == null)
			{
				BGW_LogUtil.LogError($"MonsterTeleport MonsterTeleportId:{num} InValid!!!");
				return;
			}
			SGI_Global globalFSMInstanceCurState = BGW_GameLifeTimeMgr.Get(MyUtils.GetControlledPawn()).GlobalFSMInstanceCurState;
			switch (globalFSMInstanceCurState)
			{
			case SGI_Global.MainMenu:
				BGW_EventCollection.Get(MyUtils.GetControlledPawn()).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GMLevelTravel, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					GMTravelParams = new GMTravelParams
					{
						MonsterTeleportId = num,
						GMTravelType = EGMTravelType.MonsterTeleport
					}
				});
				break;
			case SGI_Global.InBattleStandAlone:
				BGUFunctionLibraryCS.TeleportToLevelPosition(MyUtils.GetControlledPawn(), gMMonsterTeleportDesc.LevelId, new FVector(gMMonsterTeleportDesc.Position.PosX, gMMonsterTeleportDesc.Position.PosY, gMMonsterTeleportDesc.Position.PosZ), new FRotator(gMMonsterTeleportDesc.Rotation.PosX, gMMonsterTeleportDesc.Rotation.PosY, gMMonsterTeleportDesc.Rotation.PosZ), TravelUseDefaultPlayerStart: false, delegate
				{
					BUS_EventCollectionCS.Get((AActor)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)MyUtils.GetControlledPawn()).GetControlledPawn())?.Evt_GMRecordRebirthPos.Invoke();
				});
				break;
			default:
				BGW_LogUtil.LogError($"MonsterTeleport ActiveGlobalFSMState:{globalFSMInstanceCurState} InValid");
				break;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	public static int BGUGetCurPELevel(AActor Unit)
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>(Unit).GetCurPELevel(Unit);
	}

	public static void HuiMaQiang(AActor wukong)
	{
		FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(10519, ECastSkillSourceType.PreciseDodge);
		fCastSkillInfo.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
		fCastSkillInfo.NeedCheckSkillCanCast = false;
		BUS_EventCollectionCS.Get(wukong).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo);
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 10000102, EBuffSourceType.GM, 1500f);
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 10000101, EBuffSourceType.GM, 1500f);
		PlayerGm.SpellCD(5101);
	}

	public static void TeleportToLevelPositionAndPreviewSeqWithCallBack(UObject WorldContext, int SeqId, Action OnSeqFinish)
	{
		if (BGUFuncLibSequenceCS.GetPreviewSeqInfo(WorldContext, SeqId, out var LevelId, out var PreviewPosition, out var PreviewRotation, out var OnleportFinish, OnSeqFinish))
		{
			TeleportToLevelPosition(WorldContext, LevelId, PreviewPosition, PreviewRotation, TravelUseDefaultPlayerStart: false, OnleportFinish);
		}
	}

	public static void TeleportToLevelPosition(UObject WorldContext, int levelId, FVector Position, FRotator Rotation, bool TravelUseDefaultPlayerStart, Action OnFinish = null)
	{
		LevelDesc val = GameDBRuntime.FastGetLevelDesc(levelId);
		if (val == null && levelId != -1)
		{
			return;
		}
		FTransform fTransform = new FTransform(Rotation, Position);
		if (BGW_GameLifeTimeMgr.Get(WorldContext).GlobalFSMInstanceCurState == SGI_Global.InBattleStandAlone)
		{
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			if ((UObject)(object)bGUCharacterCS != null)
			{
				BPS_EventCollectionCS.Get(((APawn)(object)bGUCharacterCS).PlayerState).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.SimpleLevelIdAndTransform, new TeleportParam_SimpleLevelIdAndTransform
				{
					LevelId = levelId,
					LevelTravelUseDefaultPlayerStart = TravelUseDefaultPlayerStart,
					TeleportTransform = fTransform,
					TeleportFinishCallback = OnFinish
				}, EPlayerTeleportReason.Test);
			}
		}
		else
		{
			FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.OverrideUnKnowLevelTravelPlayerStart = fTransform;
			FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.UnKnowLevelTravelUseDefaultPlayerStart = TravelUseDefaultPlayerStart;
			if (val != null)
			{
				UGameplayStatics.OpenLevel(WorldContext, new FName(val.Path));
			}
		}
	}

	public static void BU_TimerSystem_Add(float delay, Action action, int id = -1, bool isloop = false)
	{
		GlobalObjectMgr.Get<BU_TimerSystem>().Add(delay, action, id, isloop);
	}

	public static void BU_TimerSystem_RemoveByID(int key)
	{
		GlobalObjectMgr.Get<BU_TimerSystem>().RemoveByID(key);
	}

	public static void BU_TimerSystem_RemoveAll()
	{
		GlobalObjectMgr.Get<BU_TimerSystem>().RemoveAll();
	}

	public static bool BU_TimerSystem_HasTimerByID(int id)
	{
		return GlobalObjectMgr.Get<BU_TimerSystem>().HasTimerByID(id);
	}

	public static void BU_PlayerTransSystem_SpawnActor(string UClassPath, int skill, float Scale3D, EState_MM eStateMM, bool isinit = true)
	{
		BU_PlayerTransSystem.IsInit = isinit;
		GlobalObjectMgr.Get<BU_PlayerTransSystem>().SpawnActor(UClassPath, skill, Scale3D, eStateMM);
	}

	public static void BU_PlayerTransSysem_BS(int bossId, int skill, float Scale3D, EState_MM eStateMM, bool isinit = true)
	{
		string text = null;
		List<BossInfoA> list = GlobalObjectMgr.Get<TB_BossInfoA>().list;
		foreach (BossInfoA item in list)
		{
			if (item.BossID == bossId)
			{
				text = item.AssetPath;
				break;
			}
		}
		if (text != null)
		{
			BU_PlayerTransSystem.IsInit = isinit;
			GlobalObjectMgr.Get<BU_PlayerTransSystem>().SpawnActor(text, skill, Scale3D, eStateMM);
		}
	}

	public static void BU_PlayerTransSysemA_BS(int bossId, float scale3D)
	{
		GlobalObjectMgr.Get<BU_PlayerTransSysemA>().bsA(bossId, scale3D);
	}
}
