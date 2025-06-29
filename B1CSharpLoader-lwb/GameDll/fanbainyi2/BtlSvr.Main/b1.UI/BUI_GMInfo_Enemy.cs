using System;
using System.Collections.Generic;
using System.Reflection;
using b1.ECS;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMInfo_Enemy")]
internal class BUI_GMInfo_Enemy : BUI_Widget
{
	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	private const string INFONAME_PART_ID = "PartID";

	private const string INFONAME_PART_STAGE = "PartStage";

	private const string INFONAME_PART_NAME = "PartName";

	private const string INFONAME_PART_STATE = "PartState";

	private const string INFONAME_PART_DMG = "PartDamageValue";

	private Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private Dictionary<int, b1.UI.PartInfoTextBlock> PartInfoDic = new Dictionary<int, b1.UI.PartInfoTextBlock>();

	private UTextBlock TargetName;

	private UTextBlock MoveMode;

	private UTextBlock Gravity;

	private UTextBlock CollisionProfiler;

	private UTextBlock SimpleState;

	private UTextBlock UnitState;

	private UVerticalBox InfoBox;

	private UVerticalBox PartInfoBox;

	private const string TARGETNAME_NAME = "TargetName";

	private const string MOVEMODE_NAME = "MoveMode";

	private const string GRAVITY_NAME = "Gravity";

	private const string COLLISIONPROFILER_NAME = "CollisionProfiler";

	private const string SIMPLESTATE_NAME = "SimpleState";

	private const string UNITSTATE_NAME = "UnitState";

	private const string INFOBOX_NAME = "InfoBox";

	private const string PARTINFOBOX_NAME = "PartInfoBox";

	private const string INFOCONTENT_1 = "离玩家距离";

	private const string INFOCONTENT_2 = "玩家于怪物的角度";

	private const string INFOCONTENT_3 = "MMState";

	private const string INFOCONTENT_4 = "血量";

	private const string INFOCONTENT_6 = "技能霸体护甲";

	private const string INFOCONTENT_7 = "MoveMode";

	private const string INFOCONTENT_8 = "致盲槽";

	private const string INFOCONTENT_10 = "受击InfoID";

	private const string INFOCONTENT_11 = "部位规则ID";

	private const string INFOCONTENT_20 = "死亡信息ID";

	private const string INFOCONTENT_12 = "格挡次数";

	private const string INFOCONTENT_13 = "格挡崩防值";

	private const string INFOCONTENT_14 = "硬直反击次数";

	private const string INFOCONTENT_15 = "冰属性异常";

	private const string INFOCONTENT_16 = "火属性异常";

	private const string INFOCONTENT_17 = "毒属性异常";

	private const string INFOCONTENT_18 = "雷属性异常";

	private const string INFOCONTENT_29 = "阴属性异常";

	private const string INFOCONTENT_30 = "阳属性异常";

	private const string INFOCONTENT_19 = "蓄力技能阶段";

	private const string INFOCONTENT_21 = "辟冰";

	private const string INFOCONTENT_22 = "辟火";

	private const string INFOCONTENT_23 = "辟毒";

	private const string INFOCONTENT_24 = "辟雷";

	private const string INFOCONTENT_25 = "当前所处环境表面类型";

	private const string INFOCONTENT_26 = "当前使用的技能ID";

	private const string INFOCONTENT_27 = "当前播放的AM";

	private const string INFOCONTENT_31 = "当前所属关卡";

	private const string INFOCONTENT_32 = "当前生命最大值万分比";

	private const string INFOCONTENT_33 = "当前品质";

	private UTextBlock BuffText;

	private UTextBlock SkillCDText;

	private UTextBlock PassiveSkillText;

	private const string BUFFTEXT_NAME = "BuffText";

	private const string SKILLCDTEXT_NAME = "SkillCDText";

	private const string PASSIVESKILL_NAME = "PassiveSkillText";

	private string buffstr;

	private BGUCharacterCS PlayerCharacter;

	private IBUC_TargetInfoData TargetInfoData;

	private BGUCharacterCS Target;

	private BUC_BuffData TargetBuffData;

	private BUC_SimpleStateData SimpStateData;

	private BUC_UnitStateData UnitStateData;

	private Entity CurrentUpdatePartInfoTargetID = Entity.Null;

	private IBUC_SkillInstsData TargetSkillData;

	private string SkillCDStr = "SkillID: s\n";

	private string PassiveSkillStr = "PassiveSkill:\n";

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	private static bool PartInfoTemp_IsValid;

	private static int PartInfoTemp_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMInfo_Enemy:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Enemy:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Enemy:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_GMInfo_Enemy:PartInfoTemp")]
	public TSubclassOf<UUserWidget> PartInfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!PartInfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Enemy:PartInfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, PartInfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PartInfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMInfo_Enemy:PartInfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, PartInfoTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
		PlayerCharacter = controlledPawn as BGUCharacterCS;
		if (!(controlledPawn == null) && !(PlayerCharacter == null))
		{
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(PlayerCharacter);
			TargetName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TargetName")) as UTextBlock;
			MoveMode = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("MoveMode")) as UTextBlock;
			Gravity = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("Gravity")) as UTextBlock;
			CollisionProfiler = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CollisionProfiler")) as UTextBlock;
			InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
			PartInfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PartInfoBox")) as UVerticalBox;
			BuffText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BuffText")) as UTextBlock;
			SkillCDText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SkillCDText")) as UTextBlock;
			SimpleState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SimpleState")) as UTextBlock;
			UnitState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitState")) as UTextBlock;
			PassiveSkillText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PassiveSkillText")) as UTextBlock;
			if (!(TargetName == null) && !(MoveMode == null) && !(Gravity == null) && !(CollisionProfiler == null) && !(InfoBox == null) && !(BuffText == null) && !(SimpleState == null) && !(UnitState == null))
			{
				AddInitInfo(InfoBox, "离玩家距离");
				AddInitInfo(InfoBox, "玩家于怪物的角度");
				AddInitInfo(InfoBox, "MMState");
				AddInitInfo(InfoBox, "血量");
				AddInitInfo(InfoBox, "技能霸体护甲");
				AddInitInfo(InfoBox, "MoveMode");
				AddInitInfo(InfoBox, "致盲槽");
				AddInitInfo(InfoBox, "受击InfoID");
				AddInitInfo(InfoBox, "部位规则ID");
				AddInitInfo(InfoBox, "死亡信息ID");
				AddInitInfo(InfoBox, "格挡次数");
				AddInitInfo(InfoBox, "格挡崩防值");
				AddInitInfo(InfoBox, "硬直反击次数");
				AddInitInfo(InfoBox, "冰属性异常");
				AddInitInfo(InfoBox, "火属性异常");
				AddInitInfo(InfoBox, "毒属性异常");
				AddInitInfo(InfoBox, "雷属性异常");
				AddInitInfo(InfoBox, "蓄力技能阶段");
				AddInitInfo(InfoBox, "阴属性异常");
				AddInitInfo(InfoBox, "阳属性异常");
				AddInitInfo(InfoBox, "辟冰");
				AddInitInfo(InfoBox, "辟火");
				AddInitInfo(InfoBox, "辟毒");
				AddInitInfo(InfoBox, "辟雷");
				AddInitInfo(InfoBox, "当前所处环境表面类型");
				AddInitInfo(InfoBox, "当前使用的技能ID");
				AddInitInfo(InfoBox, "当前播放的AM");
				AddInitInfo(InfoBox, "当前所属关卡");
				AddInitInfo(InfoBox, "当前生命最大值万分比");
				AddInitInfo(InfoBox, "当前品质");
			}
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (!IsVisible())
		{
			return;
		}
		if (PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			if (firstLocalPlayerController == null)
			{
				return;
			}
			AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
			PlayerCharacter = controlledPawn as BGUCharacterCS;
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(PlayerCharacter);
		}
		if (PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		Target = targetInfo.LockTargetActor as BGUCharacterCS;
		if (Target == null)
		{
			if (TargetName != null)
			{
				TargetName.SetText(FText.FromString("NoTarget"));
			}
			if (MoveMode != null)
			{
				MoveMode.SetText(FText.FromString("MoveMode"));
			}
			if (Gravity != null)
			{
				Gravity.SetText(FText.FromString("Gravity"));
			}
			if (CollisionProfiler != null)
			{
				CollisionProfiler.SetText(FText.FromString("CollisionProfiler"));
			}
			return;
		}
		if (TargetName != null)
		{
			TargetName.SetText(FText.FromString(Target.GetName()));
		}
		if (MoveMode != null)
		{
			MoveMode.SetText(FText.FromString($"MoveMode : {Target.CharacterMovement.MovementMode}"));
		}
		if (Gravity != null)
		{
			Gravity.SetText(FText.FromString($"GravityScale : {Target.CharacterMovement.GravityScale}"));
		}
		if (CollisionProfiler != null)
		{
			string text = "";
			UCapsuleComponent capsuleComponent = Target.CapsuleComponent;
			if (capsuleComponent != null)
			{
				text += $"CapsuleProfiler : {capsuleComponent.GetCollisionProfileName()}";
			}
			USkeletalMeshComponent mesh = Target.Mesh;
			if (mesh != null)
			{
				text += $", MeshProfiler : {mesh.GetCollisionProfileName()}";
			}
			CollisionProfiler.SetText(FText.FromString(text));
		}
		UpdateBaseInfo();
		UpdateBuffInfo();
		UpdateStateInfo();
		UpdateSkillCDInfo();
		UpdatePassiveSkillInfo();
		UpdatePartInfo(targetInfo.LockTargetEntity);
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

	private void AddInitPartInfo(UVerticalBox infobox, int PartID, PartInfoData PID)
	{
		if (!(infobox == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, PartInfoTemp.Value);
			UTextBlock uTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("PartID")) as UTextBlock;
			uTextBlock.SetText(FText.FromString(PartID.ToString()));
			UTextBlock partStageTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("PartStage")) as UTextBlock;
			UTextBlock uTextBlock2 = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("PartName")) as UTextBlock;
			uTextBlock2.SetText(FText.FromString(PID.PartName));
			UTextBlock partStateTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("PartState")) as UTextBlock;
			UTextBlock partDmgValueTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("PartDamageValue")) as UTextBlock;
			PartInfoDic.Add(PartID, new b1.UI.PartInfoTextBlock(PartID, PID.PartName, uTextBlock, partStageTextBlock, uTextBlock2, partStateTextBlock, partDmgValueTextBlock));
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
		if (Target == null || PlayerCharacter == null || PlayerCharacter.IsNullOrDestroyed() || Target.IsNullOrDestroyed())
		{
			return;
		}
		if (Target != PlayerCharacter)
		{
			InfoDic["离玩家距离"].SetText(FText.FromString(FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter), BGUFuncLibActorTransformCS.BGUGetActorLocation(Target)).ToString()));
			FVector actorForwardVector = Target.GetActorForwardVector();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
			float num = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D());
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(num.ToString("0.00")));
			string arg = (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.SkillSuperArmor) ? "激活" : "未激活");
			string arg2 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmor).ToString();
			string arg3 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmorMax).ToString();
			InfoDic["技能霸体护甲"].SetText(FText.FromString($"({arg}){arg2} / {arg3}"));
			IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Target);
			InfoDic["受击InfoID"].SetText(FText.FromString($"{readOnlyData.GetCurrentBeAttackedInfoID()}"));
			IBUC_PartMgrData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Target);
			InfoDic["部位规则ID"].SetText(FText.FromString($"{readOnlyData2.PartRuleID}"));
			IBUC_DeadData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_DeadData, BUC_DeadData>(Target);
			InfoDic["死亡信息ID"].SetText(FText.FromString($"{unPersistentReadOnlyData.GetDeadInfoID()}"));
			IBUC_ArmorData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(Target);
			readOnlyData3.GetBlockCounterInfo(out var CurCount, out var PerfectBlockTime, out var TotalTimes, out var BlockCD, out var _);
			readOnlyData3.GetHitRecoverCounterInfo(out var CurCount2, out var TotalTimes2);
			if (BlockCD <= 0f)
			{
				InfoDic["格挡次数"].SetText(FText.FromString($"当前: {CurCount} | 完美: {PerfectBlockTime} | 最大: {TotalTimes}"));
			}
			else
			{
				InfoDic["格挡次数"].SetText(FText.FromString($"In CD : {BlockCD}"));
			}
			string arg4 = ((BGUFunctionLibraryCS.BGUHasUnitState(Target, EBGUUnitState.BlockBeatBack) || BGUFunctionLibraryCS.BGUHasUnitState(Target, EBGUUnitState.PerfectBlockBeatBack)) ? "激活" : "未激活");
			string arg5 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlockCollapseArmor).ToString();
			string arg6 = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlockCollapseArmorMax).ToString();
			InfoDic["格挡崩防值"].SetText(FText.FromString($"({arg4}){arg5} / {arg6}"));
			InfoDic["硬直反击次数"].SetText(FText.FromString($"{CurCount2} / {TotalTimes2}"));
		}
		else
		{
			InfoDic["离玩家距离"].SetText(FText.FromString(""));
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(""));
			InfoDic["技能霸体护甲"].SetText(FText.FromString(""));
			InfoDic["受击InfoID"].SetText(FText.FromString(""));
			InfoDic["部位规则ID"].SetText(FText.FromString(""));
			InfoDic["格挡次数"].SetText(FText.FromString(""));
			InfoDic["硬直反击次数"].SetText(FText.FromString(""));
		}
		InfoDic["血量"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.Hp) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.HpMax)));
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Target);
		if (unPersistentReadOnlyData2 != null)
		{
			InfoDic["MMState"].SetText(FText.FromString(unPersistentReadOnlyData2.MotionMatchingState.ToString()));
		}
		BUC_MovementModes unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(Target);
		if (Target == null || Target == PlayerCharacter)
		{
			InfoDic["MoveMode"].SetText(FText.FromString("No Target"));
		}
		else if (unPersistentReadOnlyData3 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData3.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				InfoDic["MoveMode"].SetText(FText.FromString(array[1]));
			}
			else
			{
				InfoDic["MoveMode"].SetText(FText.FromString("No ActiveMover"));
			}
		}
		InfoDic["致盲槽"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlindSlot) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BlindSlotMax)));
		BUC_AbnormalStateHandlers unPersistentReadOnlyData4 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(Target);
		if (unPersistentReadOnlyData4 != null)
		{
			InfoDic["冰属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Freeze.IsInFinalEffect() ? (" 冰冻 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Freeze):F2}") : "")));
			InfoDic["火属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Burn.IsInFinalEffect() ? (" 炎上 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Burn):F2}") : "")));
			InfoDic["毒属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Poison.IsInFinalEffect() ? (" 中毒 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Poison):F2}") : "")));
			InfoDic["雷属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Thunder.IsInFinalEffect() ? (" 麻痹 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Thunder):F2}") : "")));
			InfoDic["阴属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YinAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YinAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Yin.IsInFinalEffect() ? (" 阴状态 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Yin):F2}") : "")));
			InfoDic["阳属性异常"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YangAbnormalAcc) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.YangAbnormalAccMax) + (unPersistentReadOnlyData4.AbnormalHanddler_Yang.IsInFinalEffect() ? (" 阳状态 " + $"{unPersistentReadOnlyData4.GetFinalEffectRemainTime(EAbnormalStateType.Abnormal_Yang):F2}") : "")));
			InfoDic["辟冰"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.FreezeDef) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.FreezeImmue) ? "  | 冰冻免疫" : "")));
			InfoDic["辟火"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.BurnDef) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.BurnImmue) ? "  | 灼烧免疫" : "")));
			InfoDic["辟毒"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.PoisonDef) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.PoisonImmue) ? "  | 中毒免疫" : "")));
			InfoDic["辟雷"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.ThunderDef) + (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.ThunderImmue) ? "  | 易伤免疫" : "")));
		}
		IBUC_ChargeSkillData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Target);
		if (readOnlyData4 != null && readOnlyData4.IsCastingChargeSkill)
		{
			InfoDic["蓄力技能阶段"].SetText(FText.FromString($"{readOnlyData4.ChargeSkillStage}"));
		}
		else
		{
			InfoDic["蓄力技能阶段"].SetText(FText.FromString("No ChargeSkill"));
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(Target);
		if (readOnlyData5 != null)
		{
			InfoDic["当前所处环境表面类型"].SetText(FText.FromString(readOnlyData5.ResultSurfaceType.ToString()));
		}
		IBUC_SkillInstsData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Target);
		if (readOnlyData6 != null)
		{
			InfoDic["当前使用的技能ID"].SetText(FText.FromString(readOnlyData6.CurrentCastingSkillID.ToString()));
		}
		UAnimInstance animInstance = Target.Mesh.GetAnimInstance();
		if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
		{
			InfoDic["当前播放的AM"].SetText(FText.FromString(animInstance.GetCurrentActiveMontage().GetPathName()));
		}
		else
		{
			InfoDic["当前播放的AM"].SetText(FText.FromString("None"));
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(Target.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			InfoDic["当前所属关卡"].SetText(FText.FromString(BGW_GameDB.GetActualLevelNumericalStrength(unitBattleInfoExtendDesc).ToString()));
			InfoDic["当前生命最大值万分比"].SetText(FText.FromString(unitBattleInfoExtendDesc.HPFixedDM.ToString()));
			InfoDic["当前品质"].SetText(FText.FromString(unitBattleInfoExtendDesc.QualityType.ToString()));
		}
		else
		{
			InfoDic["当前所属关卡"].SetText(FText.FromString(""));
			InfoDic["当前生命最大值万分比"].SetText(FText.FromString(""));
			InfoDic["当前品质"].SetText(FText.FromString(""));
		}
	}

	private void UpdatePartInfo(Entity NowTargetEntity)
	{
		if (Target == null || Target.IsNullOrDestroyed())
		{
			CurrentUpdatePartInfoTargetID = Entity.Null;
			PartInfoBox.ClearChildren();
			PartInfoDic.Clear();
		}
		else
		{
			if (Target == null || PlayerCharacter == null || PlayerCharacter.IsNullOrDestroyed() || Target.IsNullOrDestroyed())
			{
				return;
			}
			if (Target != PlayerCharacter)
			{
				if (CurrentUpdatePartInfoTargetID == Entity.Null || CurrentUpdatePartInfoTargetID != NowTargetEntity)
				{
					CurrentUpdatePartInfoTargetID = NowTargetEntity;
					PartInfoBox.ClearChildren();
					PartInfoDic.Clear();
				}
				IBUC_PartMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Target);
				if (readOnlyData == null || !readOnlyData.GetAllPartInfo(out var PartInfoDataDic))
				{
					return;
				}
				if (PartInfoDic.Count != PartInfoDataDic.Count)
				{
					PartInfoBox.ClearChildren();
					PartInfoDic.Clear();
					foreach (KeyValuePair<int, PartInfoData> item in PartInfoDataDic)
					{
						int key = item.Key;
						PartInfoData value = item.Value;
						AddInitPartInfo(PartInfoBox, key, value);
					}
				}
				{
					foreach (KeyValuePair<int, PartInfoData> item2 in PartInfoDataDic)
					{
						int key2 = item2.Key;
						PartInfoData value2 = item2.Value;
						if (PartInfoDic.TryGetValue(key2, out var value3))
						{
							string arg = value2.CurrentDamagedStage.ToString();
							string arg2 = value2.TotalDamagedStage.ToString();
							value3.PartStageTextBlock?.SetText(FText.FromString($"{arg} / {arg2}"));
							string str = ((!value2.IsActive) ? "未激活!" : (value2.IsBreak ? "已破碎!" : "激活!"));
							value3.PartStateTextBlock?.SetText(FText.FromString(str));
							string str2 = value2.CurrentPartDamagedValue.ToString();
							value3.PartDmgValueTextBlock?.SetText(FText.FromString(str2));
						}
					}
					return;
				}
			}
			PartInfoBox.ClearChildren();
			PartInfoDic.Clear();
		}
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

	private void UpdateSkillCDInfo()
	{
		SkillCDStr = "SkillID: \n";
		if (Target == null || Target.GetResID() == 10)
		{
			SkillCDText.SetText(FText.FromString(SkillCDStr));
			return;
		}
		TargetSkillData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Target);
		int num = Target.GetResID() * 100 + 99;
		for (int i = Target.GetResID() * 100 + 1; i < num; i++)
		{
			if (BGW_GameDB.GetSkillSDesc(i, Target) == null)
			{
				continue;
			}
			if (!TargetSkillData.GetSkillCooldownTime(i, out var RemainingCooldownTime, out var RemainingPreCooldownTime))
			{
				if (RemainingPreCooldownTime > 0f)
				{
					SkillCDStr = SkillCDStr + i + "  PreCD：" + RemainingPreCooldownTime + "s\n";
				}
				else if (RemainingCooldownTime > 0f)
				{
					SkillCDStr = SkillCDStr + i + "  CD：" + RemainingCooldownTime + "s\n";
				}
			}
			else
			{
				SkillCDStr = SkillCDStr + i + "  NoCd\n";
			}
		}
		SkillCDText.SetText(FText.FromString(SkillCDStr));
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

	private void ChangeInfoValueByName(string infoname, string infovalue)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMInfo_Enemy");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InfoTemp", Classes.FClassProperty);
		PartInfoTemp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PartInfoTemp");
		PartInfoTemp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PartInfoTemp", Classes.FClassProperty);
	}

	static BUI_GMInfo_Enemy()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMInfo_Enemy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMInfo_Enemy));
	}
}
