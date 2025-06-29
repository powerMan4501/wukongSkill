using System;
using System.Collections.Generic;
using System.Reflection;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMInfo_Player")]
internal class BUI_GMInfo_Player : BUI_Widget
{
	private int PlayerIndex;

	private float DisplayDebugSphereTimer;

	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	private Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private UTextBlock TargetName;

	private UTextBlock SimpleState;

	private UTextBlock UnitState;

	private UVerticalBox InfoBox;

	private const string TARGETNAME_NAME = "TargetName";

	private const string SIMPLESTATE_NAME = "SimpleState";

	private const string UNITSTATE_NAME = "UnitState";

	private const string INFOBOX_NAME = "InfoBox";

	private const string INFOCONTENT_3 = "MMState";

	private const string INFOCONTENT_4 = "血量";

	private const string INFOCONTENT_6 = "技能霸体护甲";

	private const string INFOCONTENT_8 = "C#_MoveMode";

	private const string INFOCONTENT_9 = "C++MoveMode";

	private const string INFOCONTENT_10 = "受击InfoID";

	private const string INFOCONTENT_11 = "冰属性异常";

	private const string INFOCONTENT_12 = "火属性异常";

	private const string INFOCONTENT_13 = "毒属性异常";

	private const string INFOCONTENT_14 = "雷属性异常";

	private const string INFOCONTENT_29 = "阴属性异常";

	private const string INFOCONTENT_30 = "阳属性异常";

	private const string INFOCONTENT_16 = "蓄力等级";

	private const string INFOCONTENT_17 = "蓄力";

	private const string INFOCONTENT_18 = "当前所处环境表面类型";

	private const string INFOCONTENT_19 = "致盲槽";

	private const string INFOCONTENT_20 = "当前镜头组ID";

	private const string INFOCONTENT_21 = "当前主角/锁定镜头ID";

	private const string INFOCONTENT_22 = "救命毫毛";

	private const string INFOCONTENT_23 = "冰属性";

	private const string INFOCONTENT_24 = "火属性";

	private const string INFOCONTENT_25 = "毒属性";

	private const string INFOCONTENT_26 = "雷属性";

	private const string INFOCONTENT_27 = "棍势";

	private const string INFOCONTENT_28 = "当前使用的技能ID";

	private const string INFOCONTENT_31 = "离地高度：";

	private const string INFOCONTENT_32 = "蛛丝计数：";

	private const string INFOCONTENT_33 = "关卡血量期望：";

	private const string INFOCONTENT_34 = "AMMatryoshka：";

	private const string INFOCONTENT_35 = "OnLand：";

	private const string INFOCONTENT_36 = "GravityScale";

	private const string INFOCONTENT_37 = "FallingTimer";

	private const string INFOCONTENT_38 = "战斗计时：";

	private UTextBlock BuffText;

	private UTextBlock PassiveSkillText;

	private const string BUFFTEXT_NAME = "BuffText";

	private const string CURFSMSTATE_NAME = "CurFSMState";

	private const string PASSIVESKILL_NAME = "PassiveSkillText";

	private FName PlayerFSMName = B1GlobalFNames.Comboing;

	private string buffstr;

	private ABGUCharacter PlayerCharacter;

	private IBUC_ControllerData ControllerData;

	private ABGUCharacter Target;

	private BUC_BuffData TargetBuffData;

	private BUC_SimpleStateData SimpStateData;

	private BUC_UnitStateData UnitStateData;

	private IBUC_PlayerCameraData CameraData;

	private IBIC_BossRushData BossRushData;

	private string PassiveSkillStr = "PassiveSkill:\n";

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMInfo_Player:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Player:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Player:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		if (BGU_CommonUtil.GetCurrentPlayer(this, out var Player))
		{
			PlayerCharacter = Player as ABGUCharacter;
		}
		if (!(Player == null) && !(PlayerCharacter == null))
		{
			ControllerData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ControllerData, BUC_ControllerData>(PlayerCharacter);
			CameraData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>(PlayerCharacter);
			TargetName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TargetName")) as UTextBlock;
			InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
			BuffText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BuffText")) as UTextBlock;
			SimpleState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SimpleState")) as UTextBlock;
			UnitState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitState")) as UTextBlock;
			PassiveSkillText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PassiveSkillText")) as UTextBlock;
			if (!(TargetName == null) && !(InfoBox == null) && !(BuffText == null) && !(SimpleState == null) && !(UnitState == null))
			{
				AddInitInfo(InfoBox, "MMState");
				AddInitInfo(InfoBox, "血量");
				AddInitInfo(InfoBox, "技能霸体护甲");
				AddInitInfo(InfoBox, "C#_MoveMode");
				AddInitInfo(InfoBox, "C++MoveMode");
				AddInitInfo(InfoBox, "受击InfoID");
				AddInitInfo(InfoBox, "冰属性异常");
				AddInitInfo(InfoBox, "火属性异常");
				AddInitInfo(InfoBox, "毒属性异常");
				AddInitInfo(InfoBox, "雷属性异常");
				AddInitInfo(InfoBox, "阴属性异常");
				AddInitInfo(InfoBox, "阳属性异常");
				AddInitInfo(InfoBox, "蓄力等级");
				AddInitInfo(InfoBox, "蓄力");
				AddInitInfo(InfoBox, "当前所处环境表面类型");
				AddInitInfo(InfoBox, "致盲槽");
				AddInitInfo(InfoBox, "当前镜头组ID");
				AddInitInfo(InfoBox, "当前主角/锁定镜头ID");
				AddInitInfo(InfoBox, "救命毫毛");
				AddInitInfo(InfoBox, "冰属性");
				AddInitInfo(InfoBox, "火属性");
				AddInitInfo(InfoBox, "毒属性");
				AddInitInfo(InfoBox, "雷属性");
				AddInitInfo(InfoBox, "棍势");
				AddInitInfo(InfoBox, "当前使用的技能ID");
				AddInitInfo(InfoBox, "离地高度：");
				AddInitInfo(InfoBox, "蛛丝计数：");
				AddInitInfo(InfoBox, "关卡血量期望：");
				AddInitInfo(InfoBox, "AMMatryoshka：");
				AddInitInfo(InfoBox, "OnLand：");
				AddInitInfo(InfoBox, "GravityScale");
				AddInitInfo(InfoBox, "FallingTimer");
				AddInitInfo(InfoBox, "战斗计时：");
				Target = PlayerCharacter;
			}
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (IsVisible())
		{
			if (BGU_CommonUtil.GetCurrentPlayer(this, out var Player))
			{
				PlayerCharacter = Player as ABGUCharacter;
			}
			if (!(PlayerCharacter == null) && !PlayerCharacter.IsPendingKill)
			{
				ControllerData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ControllerData, BUC_ControllerData>(PlayerCharacter);
				CameraData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>(PlayerCharacter);
				Target = PlayerCharacter;
				TargetName.SetText(FText.FromString(Target.GetName()));
				UpdateBaseInfo();
				UpdateBuffInfo();
				UpdateStateInfo();
				UpdateMovementModeStack();
				UpdateDisplayDebugSphere(InDeltaTime);
			}
		}
	}

	private void UpdateDisplayDebugSphere(float InDeltaTime)
	{
		if (DisplayDebugSphereTimer > 0f)
		{
			DisplayDebugSphereTimer -= InDeltaTime;
			UCapsuleComponent capsuleComponent = PlayerCharacter.CapsuleComponent;
			float scaledCapsuleRadius = capsuleComponent.GetScaledCapsuleRadius();
			float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
			USystemLibrary.DrawDebugBox(this, PlayerCharacter.GetActorLocation(), new FVector(scaledCapsuleRadius, scaledCapsuleRadius, scaledCapsuleHalfHeight), FLinearColor.AliceBlue, PlayerCharacter.GetActorRotation(), 0f, 2f);
		}
	}

	private void AddInitInfo(UVerticalBox infobox, string infoname)
	{
		if (!(infobox == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, InfoTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoName")) as UTextBlock).SetText(FText.FromString(infoname));
			UTextBlock value = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoValue")) as UTextBlock;
			InfoDic.Add(infoname, value);
			infobox.AddChild(uUserWidget);
		}
	}

	private void UpdateBuffInfo()
	{
		TargetBuffData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		buffstr = "BuffID [Layer] Time\n";
		foreach (BuffInstData allBuffInstDatum in TargetBuffData.GetAllBuffInstData())
		{
			buffstr += $"{allBuffInstDatum.BuffID} [{allBuffInstDatum.Layer}] {$"{allBuffInstDatum.LeftTime:F2}"}s \n";
		}
		BuffText.SetText(FText.FromString(buffstr));
	}

	private void UpdateBaseInfo()
	{
		if (Target == null || PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			return;
		}
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Target);
		InfoDic["受击InfoID"].SetText(FText.FromString($"{readOnlyData.GetCurrentBeAttackedInfoID()}"));
		InfoDic["血量"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.Hp) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.HpMax)));
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Target);
		if (unPersistentReadOnlyData != null)
		{
			InfoDic["MMState"].SetText(FText.FromString(unPersistentReadOnlyData.MotionMatchingState.ToString()));
		}
		string arg = (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.SkillSuperArmor) ? "激活" : "未激活");
		string arg2 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmor).ToString();
		string arg3 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmorMax).ToString();
		InfoDic["技能霸体护甲"].SetText(FText.FromString($"({arg}){arg2} / {arg3}"));
		BUC_MovementModes unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(PlayerCharacter);
		if (unPersistentReadOnlyData2 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData2.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				InfoDic["C#_MoveMode"].SetText(FText.FromString(array[1]));
			}
			else
			{
				InfoDic["C#_MoveMode"].SetText(FText.FromString("No ActiveMover"));
			}
		}
		if (PlayerCharacter != null)
		{
			InfoDic["C++MoveMode"].SetText(FText.FromString(PlayerCharacter.CharacterMovement.MovementMode.ToString()));
		}
		InfoDic["致盲槽"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlindSlot) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlindSlotMax)));
		BUC_LifeSavingData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_LifeSavingData>(Target);
		if (readOnlyData2 != null)
		{
			string text = (readOnlyData2.bEnable ? "开启 " : "关闭 ");
			text += $"{readOnlyData2.CoolDownRemainTimer.ToString():F2}";
			text += (readOnlyData2.bActive_ExtLifeSaving ? "(存在额外救命毫毛)" : "");
			InfoDic["救命毫毛"].SetText(FText.FromString(text));
		}
		InfoDic["当前镜头组ID"].SetText(FText.FromString($"{CameraData.GetCurrentCameraGroupID()}"));
		InfoDic["当前主角/锁定镜头ID"].SetText(FText.FromString($"{CameraData.GetCurrentFreeCameraID()}/{CameraData.GetCurrentLockCameraID()}"));
		BUC_AbnormalStateHandlers unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(Target);
		if (unPersistentReadOnlyData3 != null)
		{
			InfoDic["冰属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Freeze.IsInFinalEffect() ? (" 冰冻 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Freeze):F2}") : "")));
			InfoDic["火属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Burn.IsInFinalEffect() ? (" 炎上 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Burn):F2}") : "")));
			InfoDic["毒属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Poison.IsInFinalEffect() ? (" 中毒 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Poison):F2}") : "")));
			InfoDic["雷属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Thunder.IsInFinalEffect() ? (" 麻痹 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Thunder):F2}") : "")));
			InfoDic["阴属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YinAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YinAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Yin.IsInFinalEffect() ? (" 阴状态 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Yin):F2}") : "")));
			InfoDic["阳属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YangAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YangAbnormalAccMax) + (unPersistentReadOnlyData3.AbnormalHanddler_Yang.IsInFinalEffect() ? (" 阳状态 " + $"{unPersistentReadOnlyData3.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Yang):F2}") : "")));
			InfoDic["冰属性"].SetText(FText.FromString("Def:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeDef) + "  Atk:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeAtk) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.FreezeImmue) ? "  | 冰冻免疫" : "")));
			InfoDic["火属性"].SetText(FText.FromString("Def:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnDef) + "  Atk:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnAtk) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.BurnImmue) ? "  | 灼烧免疫" : "")));
			InfoDic["毒属性"].SetText(FText.FromString("Def:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonDef) + "  Atk:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonAtk) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.PoisonImmue) ? "  | 中毒免疫" : "")));
			InfoDic["雷属性"].SetText(FText.FromString("Def:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderDef) + "  Atk:" + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderAtk) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.ThunderImmue) ? "  | 易伤免疫" : "")));
		}
		BUC_PotentialEnergyData unPersistentReadOnlyData4 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PotentialEnergyData>(Target);
		if (unPersistentReadOnlyData4 != null)
		{
			InfoDic["棍势"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.Pevalue) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PevalueMax) + "  保护时间：" + $"{FMath.Max(unPersistentReadOnlyData4.ProtectTime, unPersistentReadOnlyData4.DecreaseProtecTimer):F2}" + "s  " + BGUFunctionLibraryCS.BGUGetCurPELevel(Target) + "级"));
		}
		BUC_ChargeSkillData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Target);
		if (readOnlyData3 != null)
		{
			InfoDic["蓄力等级"].SetText(FText.FromString("Level " + readOnlyData3.CurChargeLevel + "  " + $"{readOnlyData3.IntoNextCLevelRemaining:F2}" + "s"));
			InfoDic["蓄力"].SetText(FText.FromString(" " + readOnlyData3.ChargeSkillStage.ToString() + "  " + $"{readOnlyData3.ChargeTimer:F2}" + "s   " + readOnlyData3.NeedTriggerNextStage));
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(PlayerCharacter);
		if (readOnlyData4 != null)
		{
			InfoDic["当前所处环境表面类型"].SetText(FText.FromString(readOnlyData4.ResultSurfaceType.ToString()));
		}
		IBUC_SkillInstsData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(PlayerCharacter);
		if (readOnlyData5 != null)
		{
			InfoDic["当前使用的技能ID"].SetText(FText.FromString(readOnlyData5.CurrentCastingSkillID.ToString()));
		}
		IBUC_FallingData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<IBUC_FallingData, BUC_FallingData>(PlayerCharacter);
		if (readOnlyData6 != null)
		{
			InfoDic["离地高度："].SetText(FText.FromString(readOnlyData6.FloorDistance.ToString()));
			InfoDic["FallingTimer"].SetText(FText.FromString(readOnlyData6.FallingTimer.ToString()));
		}
		IBUC_SpiderSilkEntangleData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<IBUC_SpiderSilkEntangleData, BUC_SpiderSilkEntangleData>(PlayerCharacter);
		if (readOnlyData7 != null)
		{
			InfoDic["蛛丝计数："].SetText(FText.FromString(readOnlyData7.GetCount().ToString()));
		}
		int LevelID;
		int CurrentGamePlusCount;
		bool bIsDebug;
		float levelPlayerDesiredHPMax = GetLevelPlayerDesiredHPMax(out LevelID, out CurrentGamePlusCount, out bIsDebug);
		string text2 = (bIsDebug ? ",Debug" : "");
		InfoDic["关卡血量期望："].SetText(FText.FromString($"{levelPlayerDesiredHPMax}, Level:{LevelID},{CurrentGamePlusCount}周目{text2}"));
		bool flag = UGSE_AnimFuncLib.IsSlotPlayingMontage(PlayerCharacter.Mesh.GetAnimInstance(), B1GlobalFNames.AMMatryoshka);
		InfoDic["AMMatryoshka："].SetText(FText.FromString(flag.ToString()));
		if (PlayerCharacter != null)
		{
			InfoDic["GravityScale"].SetText(FText.FromString($"{PlayerCharacter.CharacterMovement.GravityScale}"));
		}
		if (B1Global.GIsBossRushMode)
		{
			if (BossRushData == null)
			{
				BossRushData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(PlayerCharacter);
			}
			if (BossRushData != null && BossRushData.BossRushBattleData != null)
			{
				InfoDic["战斗计时："].SetText(FText.FromString(BossRushData.BossRushBattleData.TotalTime.ToString()));
			}
		}
	}

	private float GetLevelPlayerDesiredHPMax(out int LevelID, out int CurrentGamePlusCount, out bool bIsDebug)
	{
		float num = 0f;
		CurrentGamePlusCount = 1;
		LevelID = -1;
		bIsDebug = false;
		int valueInGameThread = GSGameplayCVar.CVar_LevelDesiredPlayerHP.GetValueInGameThread();
		if (valueInGameThread > 0)
		{
			num = valueInGameThread;
			bIsDebug = true;
		}
		else if (!PlayerCharacter.IsNullOrDestroyed())
		{
			CurrentGamePlusCount = BGW_GamePlayCountUtil.GetCurGamePlayCount(PlayerCharacter);
			IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(PlayerCharacter);
			if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.IsValidLevel())
			{
				LevelID = gameInstanceReadonlyData.CurrentLevelID;
				LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(gameInstanceReadonlyData.CurrentLevelID);
				if (DebugConfig.DebugGameCount > 0)
				{
					CurrentGamePlusCount = DebugConfig.DebugGameCount;
				}
				CurrentGamePlusCount = ((CurrentGamePlusCount > 6) ? 6 : CurrentGamePlusCount);
				if (levelDesc != null && levelDesc.PlayerDesiredHp.Count >= CurrentGamePlusCount)
				{
					num = levelDesc.PlayerDesiredHp[CurrentGamePlusCount - 1];
				}
			}
		}
		if (num <= 0f)
		{
			num = CurrentGamePlusCount switch
			{
				1 => 300f, 
				2 => 850f, 
				_ => 900f, 
			};
		}
		return num;
	}

	private void UpdateStateInfo()
	{
		string text = "";
		string text2 = "";
		SimpStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Target);
		string text3 = SimpStateData.GetString();
		string text4 = "SimpleStateList:";
		string text5 = text3.Substring(text4.Length, text3.Length - text4.Length);
		for (int i = 0; i < text5.Length; i++)
		{
			text = ((text5[i] == ',') ? (text + "\n") : (text + text5[i]));
		}
		SimpleState.SetText(FText.FromString(text));
		UnitStateData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Target);
		string text6 = UnitStateData.GetString();
		string text7 = "UnitStateData:";
		string text8 = text6.Substring(text7.Length, text6.Length - text7.Length);
		for (int j = 0; j < text8.Length; j++)
		{
			text2 = ((text8[j] == ',') ? (text2 + "\n") : (text2 + text8[j]));
		}
		UnitState.SetText(FText.FromString(text2));
	}

	private void UpdatePassiveSkillInfo()
	{
		PassiveSkillStr = "PassiveSkill:\n";
		if (Target == null)
		{
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		string Str = "";
		foreach (KeyValuePair<int, FUStSkillSDesc> cachedSkillSDesc in readOnlyData.CachedSkillSDescs)
		{
			FUStSkillSDesc value = cachedSkillSDesc.Value;
			FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(cachedSkillSDesc.Key);
			FieldInfo[] fields = typeof(FUStSkillSDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				object value2 = fields[i].GetValue(value);
				object value3 = fields[i].GetValue(originalSkillSDesc);
				if (value2 != null && value3 != null)
				{
					string text = value2.ToString();
					string text2 = value3.ToString();
					if (text != text2)
					{
						Str = Str + "SkillS." + fields[i].Name + ": " + text + "(" + text2 + ")\n";
					}
				}
			}
		}
		foreach (KeyValuePair<int, FUStSkillEffectDesc> cachedSkillEffectDesc in readOnlyData.CachedSkillEffectDescs)
		{
			FUStSkillEffectDesc value4 = cachedSkillEffectDesc.Value;
			FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(cachedSkillEffectDesc.Key);
			FieldInfo[] fields2 = typeof(FUStSkillEffectDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int j = 0; j < fields2.Length; j++)
			{
				RepeatedField<float> repeatedField = fields2[j].GetValue(value4) as RepeatedField<float>;
				RepeatedField<float> repeatedField2 = fields2[j].GetValue(originalSkillEffectDesc) as RepeatedField<float>;
				if (repeatedField != null && repeatedField2 != null)
				{
					for (int k = 0; k < repeatedField.Count; k++)
					{
						if (repeatedField[k] != repeatedField2[k])
						{
							Str = Str + "SkillEffect.ParamsFloat[" + k + "]: " + repeatedField[k] + "(" + repeatedField2[k] + ")\n";
						}
					}
				}
				RepeatedField<int> repeatedField3 = fields2[j].GetValue(value4) as RepeatedField<int>;
				RepeatedField<int> repeatedField4 = fields2[j].GetValue(originalSkillEffectDesc) as RepeatedField<int>;
				if (repeatedField3 == null || repeatedField4 == null)
				{
					continue;
				}
				for (int l = 0; l < repeatedField3.Count; l++)
				{
					if (repeatedField3[l] != repeatedField4[l])
					{
						Str = Str + "SkillEffect.ParamsInt[" + l + "]: " + repeatedField3[l] + "(" + repeatedField4[l] + ")\n";
					}
				}
			}
		}
		foreach (KeyValuePair<int, FUStPlayerInputSkillMappingDesc> cachedPlayerCommSkillDesc in readOnlyData.CachedPlayerCommSkillDescs)
		{
			FUStPlayerInputSkillMappingDesc value5 = cachedPlayerCommSkillDesc.Value;
			FUStPlayerInputSkillMappingDesc originalPlayerInputSkillMappingDesc = BGW_GameDB.GetOriginalPlayerInputSkillMappingDesc(cachedPlayerCommSkillDesc.Key);
			FieldInfo[] fields3 = typeof(FUStPlayerInputSkillMappingDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int m = 0; m < fields3.Length; m++)
			{
				object value6 = fields3[m].GetValue(value5);
				object value7 = fields3[m].GetValue(originalPlayerInputSkillMappingDesc);
				if (value6 != null && value7 != null)
				{
					string text3 = value6.ToString();
					string text4 = value7.ToString();
					if (text3 != text4)
					{
						Str = Str + "PlayerInputSkillMapping." + fields3[m].Name + ": " + text3 + "(" + text4 + ")\n";
					}
				}
			}
		}
		BGUFunctionLibraryCS.DisplayGMInfoForPassiveSkills(readOnlyData.CachedBuffModifyData, ref Str);
		if (string.IsNullOrEmpty(Str))
		{
			PassiveSkillStr = "";
		}
		else
		{
			PassiveSkillStr += Str;
		}
		PassiveSkillText.SetText(FText.FromString(PassiveSkillStr));
	}

	private void UpdateMovementModeStack()
	{
		if (PassiveSkillText == null)
		{
			return;
		}
		string text = "MoveModeStack:\n";
		PassiveSkillText.SetText(FText.FromString(text));
		BUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_PropMgrData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		if (readOnlyData.MapPropType2HandleID.TryGetValue(EPropType.Movement_MovementMode, out var value))
		{
			foreach (uint item in value)
			{
				if (readOnlyData.MapPropRequest.TryGetValue(item, out var value2) && value2 is BGU_EnumPropRequest bGU_EnumPropRequest)
				{
					EMovementMode eMovementMode = (EMovementMode)bGU_EnumPropRequest.Value;
					string resourceInfo = bGU_EnumPropRequest.ResourceInfo;
					text = text + eMovementMode.ToString() + "\n";
					text = text + resourceInfo + "\n";
					text += "\n";
				}
			}
		}
		PassiveSkillText.SetText(FText.FromString(text));
	}

	private void ChangeInfoValueByName(string infoname, string infovalue)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMInfo_Player");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InfoTemp", Classes.FClassProperty);
	}

	static BUI_GMInfo_Player()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMInfo_Player)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMInfo_Player));
	}
}
