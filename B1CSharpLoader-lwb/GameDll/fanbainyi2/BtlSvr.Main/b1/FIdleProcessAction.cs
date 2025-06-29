using System;
using System.Collections.Generic;
using b1.Plugins.AsyncLoadingScreen;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.IdleProcessAction")]
public struct FIdleProcessAction
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Action类型")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:ActionType")]
	public EIdleProcessActionType ActionType;

	[DisplayName("是否跨关卡传送")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:bTeleportToOtherLevel")]
	public bool bTeleportToOtherLevel;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("目标关卡ID")]
	[Tooltip("需要勾选跨关卡传送")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "bTeleportToOtherLevel")]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:TargetLevelID")]
	public int TargetLevelID;

	[UProperty]
	[Category("传送")]
	[BlueprintReadWrite]
	[DisplayName("传送点ID")]
	[EditAnywhere]
	[Tooltip("可缺省")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:PointName")]
	public FName PointName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传送前动画")]
	[Category("传送前")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:BeforeTeleportMontage")]
	public TSoftObject<UAnimMontage> BeforeTeleportMontage;

	[Category("传送后")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("传送后动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AfterTeleportMontage")]
	public TSoftObject<UAnimMontage> AfterTeleportMontage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传送后存档")]
	[Category("传送后")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:bSaveArchiveAfterTeleport")]
	public bool bSaveArchiveAfterTeleport;

	[UMeta(MDProp.EditCondition, "bSaveArchiveAfterTeleport")]
	[DisplayName("传送后存档标记")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("传送后")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:ArchiveLabel")]
	public FName ArchiveLabel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("复活点ID")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:RebirthPointID")]
	public int RebirthPointID;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("禁用此复活点传送")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:IsBlockRebirthpoint")]
	public bool IsBlockRebirthpoint;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Unit")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:Unit")]
	public FGsSmartParam Unit;

	[DisplayName("UnitOrPlayerorNPC")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:UnitOrPlayerorNPC")]
	public FGsSmartParam UnitOrPlayerorNPC;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("取刀器Guid")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:DropItemManageGuid")]
	public string DropItemManageGuid;

	[DisplayName("AiConversation")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AiConversation")]
	public FGsSmartParam AiConversation;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("NPC")]
	[DisplayName("NPC单位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCUnit")]
	public FGsSmartParam NPCUnit;

	[EditAnywhere]
	[DisplayName("NPC队伍ID")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("NPC")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCTeamID")]
	public int NPCTeamID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("NPC")]
	[DisplayName("NPC待机动画序号")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCIdleAMIdx")]
	public int NPCIdleAMIdx;

	[UProperty]
	[Category("NPC")]
	[BlueprintReadWrite]
	[DisplayName("NPC Leisure动画序号")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCLeisureAnimIndex")]
	public int NPCLeisureAnimIndex;

	[EditAnywhere]
	[DisplayName("NPC表演动画技能ID")]
	[Category("NPC")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCActionSkillID")]
	public int NPCActionSkillID;

	[UProperty]
	[BlueprintReadWrite]
	[Category("NPC")]
	[EditAnywhere]
	[DisplayName("NPC交互组ID")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCInteractGroupID")]
	public int NPCInteractGroupID;

	[BlueprintReadWrite]
	[Category("NPC")]
	[DisplayName("目标Actor")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:TargetActor")]
	public FGsActorGuidReference TargetActor;

	[DisplayName("移动类型")]
	[Category("NPC")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:MoveAIType")]
	public EBGUMoveAIType MoveAIType;

	[EditAnywhere]
	[UProperty]
	[Category("NPC")]
	[BlueprintReadWrite]
	[DisplayName("移动速度类型")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:MoveSpeedType")]
	public EAIMoveSpeedType MoveSpeedType;

	[EditAnywhere]
	[DisplayName("移动到达可接受范围")]
	[UProperty]
	[Category("NPC")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:MoveAcceptableRadius")]
	public float MoveAcceptableRadius;

	[DisplayName("NPC显隐状态")]
	[Category("NPC")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NPCShowState")]
	public EGsNPCShowState NPCShowState;

	[EditAnywhere]
	[UProperty]
	[DisplayName("单位混战触发配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:UnitTriggerBattleConfigs")]
	public List<FProcessUnitTriggerBattleConfig> UnitTriggerBattleConfigs;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("协战单位配置ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationUnitInfoConfigId")]
	public FGsSmartParam AssociationUnitInfoConfigId;

	[Tooltip("单位是秒")]
	[DisplayName("协战单位刷新延迟执行时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationUnitSpawnInfoDelayExecuteTime")]
	public int AssociationUnitSpawnInfoDelayExecuteTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("协战单位刷新类型")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationUnitSpawnInfoSpawnType")]
	public EAssociationUnitSpawnType AssociationUnitSpawnInfoSpawnType;

	[BlueprintReadWrite]
	[DisplayName("协战单位激活类型")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationUnitSpawnInfoActiveType")]
	public EAssociationUnitActiveType AssociationUnitSpawnInfoActiveType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("协战单位激活后目标")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationUnitTarget")]
	public FGsSmartParam AssociationUnitTarget;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("接战技能ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:AssociationOnFightSkillID")]
	public int AssociationOnFightSkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Npc移动类型")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NpcMoveType")]
	public ENpcMoveType NpcMoveType;

	[DisplayName("NpcSpline引路配置")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:NpcGuideSplineMoveConfig")]
	public FNpcGuideSplineMoveConfig NpcGuideSplineMoveConfig;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("弱表演配置ID")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:WeakPerformConfigID")]
	public int WeakPerformConfigID;

	[UProperty]
	[DisplayName("跟随作战单位配置ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:FollowPartnerConfigId")]
	public FGsSmartParam FollowPartnerConfigId;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:GameplayTag")]
	public FGameplayTag GameplayTag;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("不重置玩家状态")]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:bDontResetPlayerState")]
	public bool bDontResetPlayerState;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("传送Loading Screen类型")]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:LoadingScreenType")]
	public EGSLoadingScreenType LoadingScreenType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("击杀慢镜头UI")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:UnitExtendID")]
	public int UnitExtendID;

	[Category("传送")]
	[UMeta(MDProp.EditCondition, "LoadingScreenType == EGSLoadingScreenType::Full")]
	[DisplayName("传送指定Tips的Id")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("需要类型为Full")]
	[USharpPath("/Script/b1-Managed.IdleProcessAction:TeleportLoadingTips")]
	public List<int> TeleportLoadingTips;

	private static int IdleProcessAction_StructSize;

	private static int IdleProcessAction_IsValid;

	private static bool ActionType_IsValid;

	private static int ActionType_Offset;

	private static FFieldAddress ActionType_PropertyAddress;

	private static bool bTeleportToOtherLevel_IsValid;

	private static int bTeleportToOtherLevel_Offset;

	private static FFieldAddress bTeleportToOtherLevel_PropertyAddress;

	private static bool TargetLevelID_IsValid;

	private static int TargetLevelID_Offset;

	private static bool PointName_IsValid;

	private static int PointName_Offset;

	private static bool BeforeTeleportMontage_IsValid;

	private static int BeforeTeleportMontage_Offset;

	private static bool AfterTeleportMontage_IsValid;

	private static int AfterTeleportMontage_Offset;

	private static bool bSaveArchiveAfterTeleport_IsValid;

	private static int bSaveArchiveAfterTeleport_Offset;

	private static FFieldAddress bSaveArchiveAfterTeleport_PropertyAddress;

	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	private static bool RebirthPointID_IsValid;

	private static int RebirthPointID_Offset;

	private static bool IsBlockRebirthpoint_IsValid;

	private static int IsBlockRebirthpoint_Offset;

	private static FFieldAddress IsBlockRebirthpoint_PropertyAddress;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool UnitOrPlayerorNPC_IsValid;

	private static int UnitOrPlayerorNPC_Offset;

	private static bool DropItemManageGuid_IsValid;

	private static int DropItemManageGuid_Offset;

	private static bool AiConversation_IsValid;

	private static int AiConversation_Offset;

	private static bool NPCUnit_IsValid;

	private static int NPCUnit_Offset;

	private static bool NPCTeamID_IsValid;

	private static int NPCTeamID_Offset;

	private static bool NPCIdleAMIdx_IsValid;

	private static int NPCIdleAMIdx_Offset;

	private static bool NPCLeisureAnimIndex_IsValid;

	private static int NPCLeisureAnimIndex_Offset;

	private static bool NPCActionSkillID_IsValid;

	private static int NPCActionSkillID_Offset;

	private static bool NPCInteractGroupID_IsValid;

	private static int NPCInteractGroupID_Offset;

	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool MoveSpeedType_IsValid;

	private static int MoveSpeedType_Offset;

	private static FFieldAddress MoveSpeedType_PropertyAddress;

	private static bool MoveAcceptableRadius_IsValid;

	private static int MoveAcceptableRadius_Offset;

	private static bool NPCShowState_IsValid;

	private static int NPCShowState_Offset;

	private static FFieldAddress NPCShowState_PropertyAddress;

	private static bool UnitTriggerBattleConfigs_IsValid;

	private static int UnitTriggerBattleConfigs_Offset;

	private static FFieldAddress UnitTriggerBattleConfigs_PropertyAddress;

	private static bool AssociationUnitInfoConfigId_IsValid;

	private static int AssociationUnitInfoConfigId_Offset;

	private static bool AssociationUnitSpawnInfoDelayExecuteTime_IsValid;

	private static int AssociationUnitSpawnInfoDelayExecuteTime_Offset;

	private static bool AssociationUnitSpawnInfoSpawnType_IsValid;

	private static int AssociationUnitSpawnInfoSpawnType_Offset;

	private static FFieldAddress AssociationUnitSpawnInfoSpawnType_PropertyAddress;

	private static bool AssociationUnitSpawnInfoActiveType_IsValid;

	private static int AssociationUnitSpawnInfoActiveType_Offset;

	private static FFieldAddress AssociationUnitSpawnInfoActiveType_PropertyAddress;

	private static bool AssociationUnitTarget_IsValid;

	private static int AssociationUnitTarget_Offset;

	private static bool AssociationOnFightSkillID_IsValid;

	private static int AssociationOnFightSkillID_Offset;

	private static bool NpcMoveType_IsValid;

	private static int NpcMoveType_Offset;

	private static FFieldAddress NpcMoveType_PropertyAddress;

	private static bool NpcGuideSplineMoveConfig_IsValid;

	private static int NpcGuideSplineMoveConfig_Offset;

	private static bool WeakPerformConfigID_IsValid;

	private static int WeakPerformConfigID_Offset;

	private static bool FollowPartnerConfigId_IsValid;

	private static int FollowPartnerConfigId_Offset;

	private static bool GameplayTag_IsValid;

	private static int GameplayTag_Offset;

	private static bool bDontResetPlayerState_IsValid;

	private static int bDontResetPlayerState_Offset;

	private static FFieldAddress bDontResetPlayerState_PropertyAddress;

	private static bool LoadingScreenType_IsValid;

	private static int LoadingScreenType_Offset;

	private static FFieldAddress LoadingScreenType_PropertyAddress;

	private static bool UnitExtendID_IsValid;

	private static int UnitExtendID_Offset;

	private static bool TeleportLoadingTips_IsValid;

	private static int TeleportLoadingTips_Offset;

	private static FFieldAddress TeleportLoadingTips_PropertyAddress;

	public FIdleProcessAction Copy()
	{
		FIdleProcessAction result = this;
		if (UnitTriggerBattleConfigs != null)
		{
			result.UnitTriggerBattleConfigs = new List<FProcessUnitTriggerBattleConfig>(UnitTriggerBattleConfigs);
		}
		if (TeleportLoadingTips != null)
		{
			result.TeleportLoadingTips = new List<int>(TeleportLoadingTips);
		}
		return result;
	}

	public static FIdleProcessAction FromNative(IntPtr nativeBuffer)
	{
		return new FIdleProcessAction(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIdleProcessAction value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIdleProcessAction FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIdleProcessAction(IntPtr.Add(nativeBuffer, arrayIndex * IdleProcessAction_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIdleProcessAction value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IdleProcessAction_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IdleProcessAction_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IdleProcessAction");
			return;
		}
		EnumMarshaler<EIdleProcessActionType>.ToNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address, ActionType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bTeleportToOtherLevel_Offset), 0, bTeleportToOtherLevel_PropertyAddress.Address, bTeleportToOtherLevel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetLevelID_Offset), TargetLevelID);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PointName_Offset), PointName);
		TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BeforeTeleportMontage_Offset), BeforeTeleportMontage);
		TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AfterTeleportMontage_Offset), AfterTeleportMontage);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSaveArchiveAfterTeleport_Offset), 0, bSaveArchiveAfterTeleport_PropertyAddress.Address, bSaveArchiveAfterTeleport);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset), ArchiveLabel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebirthPointID_Offset), RebirthPointID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsBlockRebirthpoint_Offset), 0, IsBlockRebirthpoint_PropertyAddress.Address, IsBlockRebirthpoint);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, UnitOrPlayerorNPC_Offset), UnitOrPlayerorNPC);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DropItemManageGuid_Offset), DropItemManageGuid);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, AiConversation_Offset), AiConversation);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, NPCUnit_Offset), NPCUnit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NPCTeamID_Offset), NPCTeamID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NPCIdleAMIdx_Offset), NPCIdleAMIdx);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NPCLeisureAnimIndex_Offset), NPCLeisureAnimIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NPCActionSkillID_Offset), NPCActionSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NPCInteractGroupID_Offset), NPCInteractGroupID);
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, TargetActor_Offset), TargetActor);
		EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, MoveAIType);
		EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(nativeStruct, MoveSpeedType_Offset), 0, MoveSpeedType_PropertyAddress.Address, MoveSpeedType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoveAcceptableRadius_Offset), MoveAcceptableRadius);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, NPCShowState_Offset), 0, NPCShowState_PropertyAddress.Address, NPCShowState);
		new TArrayCopyMarshaler<FProcessUnitTriggerBattleConfig>(1, UnitTriggerBattleConfigs_PropertyAddress, CachedMarshalingDelegates<FProcessUnitTriggerBattleConfig, FProcessUnitTriggerBattleConfig>.FromNative, CachedMarshalingDelegates<FProcessUnitTriggerBattleConfig, FProcessUnitTriggerBattleConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, UnitTriggerBattleConfigs_Offset), UnitTriggerBattleConfigs);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, AssociationUnitInfoConfigId_Offset), AssociationUnitInfoConfigId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoDelayExecuteTime_Offset), AssociationUnitSpawnInfoDelayExecuteTime);
		EnumMarshaler<EAssociationUnitSpawnType>.ToNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoSpawnType_Offset), 0, AssociationUnitSpawnInfoSpawnType_PropertyAddress.Address, AssociationUnitSpawnInfoSpawnType);
		EnumMarshaler<EAssociationUnitActiveType>.ToNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoActiveType_Offset), 0, AssociationUnitSpawnInfoActiveType_PropertyAddress.Address, AssociationUnitSpawnInfoActiveType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, AssociationUnitTarget_Offset), AssociationUnitTarget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AssociationOnFightSkillID_Offset), AssociationOnFightSkillID);
		EnumMarshaler<ENpcMoveType>.ToNative(IntPtr.Add(nativeStruct, NpcMoveType_Offset), 0, NpcMoveType_PropertyAddress.Address, NpcMoveType);
		FNpcGuideSplineMoveConfig.ToNative(IntPtr.Add(nativeStruct, NpcGuideSplineMoveConfig_Offset), NpcGuideSplineMoveConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, WeakPerformConfigID_Offset), WeakPerformConfigID);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, FollowPartnerConfigId_Offset), FollowPartnerConfigId);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, GameplayTag_Offset), GameplayTag);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDontResetPlayerState_Offset), 0, bDontResetPlayerState_PropertyAddress.Address, bDontResetPlayerState);
		EnumMarshaler<EGSLoadingScreenType>.ToNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address, LoadingScreenType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UnitExtendID_Offset), UnitExtendID);
		new TArrayCopyMarshaler<int>(1, TeleportLoadingTips_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TeleportLoadingTips_Offset), TeleportLoadingTips);
	}

	public FIdleProcessAction(IntPtr nativeStruct)
	{
		if (IdleProcessAction_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IdleProcessAction");
			ActionType = EIdleProcessActionType.None;
			bTeleportToOtherLevel = false;
			TargetLevelID = 0;
			PointName = default(FName);
			BeforeTeleportMontage = default(TSoftObject<UAnimMontage>);
			AfterTeleportMontage = default(TSoftObject<UAnimMontage>);
			bSaveArchiveAfterTeleport = false;
			ArchiveLabel = default(FName);
			RebirthPointID = 0;
			IsBlockRebirthpoint = false;
			Unit = default(FGsSmartParam);
			UnitOrPlayerorNPC = default(FGsSmartParam);
			DropItemManageGuid = null;
			AiConversation = default(FGsSmartParam);
			NPCUnit = default(FGsSmartParam);
			NPCTeamID = 0;
			NPCIdleAMIdx = 0;
			NPCLeisureAnimIndex = 0;
			NPCActionSkillID = 0;
			NPCInteractGroupID = 0;
			TargetActor = default(FGsActorGuidReference);
			MoveAIType = EBGUMoveAIType.None;
			MoveSpeedType = EAIMoveSpeedType.JOG;
			MoveAcceptableRadius = 0f;
			NPCShowState = EGsNPCShowState.Show;
			UnitTriggerBattleConfigs = null;
			AssociationUnitInfoConfigId = default(FGsSmartParam);
			AssociationUnitSpawnInfoDelayExecuteTime = 0;
			AssociationUnitSpawnInfoSpawnType = EAssociationUnitSpawnType.BySceneItem;
			AssociationUnitSpawnInfoActiveType = EAssociationUnitActiveType.ActiveImmediately;
			AssociationUnitTarget = default(FGsSmartParam);
			AssociationOnFightSkillID = 0;
			NpcMoveType = ENpcMoveType.Navigation;
			NpcGuideSplineMoveConfig = default(FNpcGuideSplineMoveConfig);
			WeakPerformConfigID = 0;
			FollowPartnerConfigId = default(FGsSmartParam);
			GameplayTag = default(FGameplayTag);
			bDontResetPlayerState = false;
			LoadingScreenType = EGSLoadingScreenType.Unknown;
			UnitExtendID = 0;
			TeleportLoadingTips = null;
		}
		else
		{
			ActionType = EnumMarshaler<EIdleProcessActionType>.FromNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address);
			bTeleportToOtherLevel = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bTeleportToOtherLevel_Offset), 0, bTeleportToOtherLevel_PropertyAddress.Address);
			TargetLevelID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetLevelID_Offset));
			PointName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PointName_Offset));
			BeforeTeleportMontage = TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BeforeTeleportMontage_Offset));
			AfterTeleportMontage = TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AfterTeleportMontage_Offset));
			bSaveArchiveAfterTeleport = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSaveArchiveAfterTeleport_Offset), 0, bSaveArchiveAfterTeleport_PropertyAddress.Address);
			ArchiveLabel = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset));
			RebirthPointID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebirthPointID_Offset));
			IsBlockRebirthpoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsBlockRebirthpoint_Offset), 0, IsBlockRebirthpoint_PropertyAddress.Address);
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			UnitOrPlayerorNPC = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, UnitOrPlayerorNPC_Offset));
			DropItemManageGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DropItemManageGuid_Offset));
			AiConversation = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, AiConversation_Offset));
			NPCUnit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, NPCUnit_Offset));
			NPCTeamID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NPCTeamID_Offset));
			NPCIdleAMIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NPCIdleAMIdx_Offset));
			NPCLeisureAnimIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NPCLeisureAnimIndex_Offset));
			NPCActionSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NPCActionSkillID_Offset));
			NPCInteractGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NPCInteractGroupID_Offset));
			TargetActor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, TargetActor_Offset));
			MoveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
			MoveSpeedType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(nativeStruct, MoveSpeedType_Offset), 0, MoveSpeedType_PropertyAddress.Address);
			MoveAcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoveAcceptableRadius_Offset));
			NPCShowState = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, NPCShowState_Offset), 0, NPCShowState_PropertyAddress.Address);
			UnitTriggerBattleConfigs = new TArrayCopyMarshaler<FProcessUnitTriggerBattleConfig>(1, UnitTriggerBattleConfigs_PropertyAddress, CachedMarshalingDelegates<FProcessUnitTriggerBattleConfig, FProcessUnitTriggerBattleConfig>.FromNative, CachedMarshalingDelegates<FProcessUnitTriggerBattleConfig, FProcessUnitTriggerBattleConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, UnitTriggerBattleConfigs_Offset));
			AssociationUnitInfoConfigId = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, AssociationUnitInfoConfigId_Offset));
			AssociationUnitSpawnInfoDelayExecuteTime = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoDelayExecuteTime_Offset));
			AssociationUnitSpawnInfoSpawnType = EnumMarshaler<EAssociationUnitSpawnType>.FromNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoSpawnType_Offset), 0, AssociationUnitSpawnInfoSpawnType_PropertyAddress.Address);
			AssociationUnitSpawnInfoActiveType = EnumMarshaler<EAssociationUnitActiveType>.FromNative(IntPtr.Add(nativeStruct, AssociationUnitSpawnInfoActiveType_Offset), 0, AssociationUnitSpawnInfoActiveType_PropertyAddress.Address);
			AssociationUnitTarget = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, AssociationUnitTarget_Offset));
			AssociationOnFightSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AssociationOnFightSkillID_Offset));
			NpcMoveType = EnumMarshaler<ENpcMoveType>.FromNative(IntPtr.Add(nativeStruct, NpcMoveType_Offset), 0, NpcMoveType_PropertyAddress.Address);
			NpcGuideSplineMoveConfig = FNpcGuideSplineMoveConfig.FromNative(IntPtr.Add(nativeStruct, NpcGuideSplineMoveConfig_Offset));
			WeakPerformConfigID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, WeakPerformConfigID_Offset));
			FollowPartnerConfigId = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, FollowPartnerConfigId_Offset));
			GameplayTag = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, GameplayTag_Offset));
			bDontResetPlayerState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDontResetPlayerState_Offset), 0, bDontResetPlayerState_PropertyAddress.Address);
			LoadingScreenType = EnumMarshaler<EGSLoadingScreenType>.FromNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address);
			UnitExtendID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UnitExtendID_Offset));
			TeleportLoadingTips = new TArrayCopyMarshaler<int>(1, TeleportLoadingTips_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TeleportLoadingTips_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IdleProcessAction");
		IdleProcessAction_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ActionType_PropertyAddress, intPtr, "ActionType");
		ActionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionType");
		ActionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bTeleportToOtherLevel_PropertyAddress, intPtr, "bTeleportToOtherLevel");
		bTeleportToOtherLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTeleportToOtherLevel");
		bTeleportToOtherLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTeleportToOtherLevel", Classes.FBoolProperty);
		TargetLevelID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetLevelID");
		TargetLevelID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetLevelID", Classes.FIntProperty);
		PointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointName");
		PointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointName", Classes.FNameProperty);
		BeforeTeleportMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeforeTeleportMontage");
		BeforeTeleportMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeforeTeleportMontage", Classes.FSoftObjectProperty);
		AfterTeleportMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "AfterTeleportMontage");
		AfterTeleportMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AfterTeleportMontage", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bSaveArchiveAfterTeleport_PropertyAddress, intPtr, "bSaveArchiveAfterTeleport");
		bSaveArchiveAfterTeleport_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSaveArchiveAfterTeleport");
		bSaveArchiveAfterTeleport_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSaveArchiveAfterTeleport", Classes.FBoolProperty);
		ArchiveLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		RebirthPointID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthPointID");
		RebirthPointID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthPointID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsBlockRebirthpoint_PropertyAddress, intPtr, "IsBlockRebirthpoint");
		IsBlockRebirthpoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsBlockRebirthpoint");
		IsBlockRebirthpoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsBlockRebirthpoint", Classes.FBoolProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		UnitOrPlayerorNPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitOrPlayerorNPC");
		UnitOrPlayerorNPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitOrPlayerorNPC", Classes.FStructProperty);
		DropItemManageGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "DropItemManageGuid");
		DropItemManageGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DropItemManageGuid", Classes.FStrProperty);
		AiConversation_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiConversation");
		AiConversation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiConversation", Classes.FStructProperty);
		NPCUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCUnit");
		NPCUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCUnit", Classes.FStructProperty);
		NPCTeamID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCTeamID");
		NPCTeamID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCTeamID", Classes.FIntProperty);
		NPCIdleAMIdx_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCIdleAMIdx");
		NPCIdleAMIdx_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCIdleAMIdx", Classes.FIntProperty);
		NPCLeisureAnimIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCLeisureAnimIndex");
		NPCLeisureAnimIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCLeisureAnimIndex", Classes.FIntProperty);
		NPCActionSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCActionSkillID");
		NPCActionSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCActionSkillID", Classes.FIntProperty);
		NPCInteractGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCInteractGroupID");
		NPCInteractGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCInteractGroupID", Classes.FIntProperty);
		TargetActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetActor");
		TargetActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, intPtr, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveSpeedType_PropertyAddress, intPtr, "MoveSpeedType");
		MoveSpeedType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveSpeedType");
		MoveSpeedType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveSpeedType", Classes.FEnumProperty);
		MoveAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAcceptableRadius");
		MoveAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NPCShowState_PropertyAddress, intPtr, "NPCShowState");
		NPCShowState_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCShowState");
		NPCShowState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCShowState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UnitTriggerBattleConfigs_PropertyAddress, intPtr, "UnitTriggerBattleConfigs");
		UnitTriggerBattleConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitTriggerBattleConfigs");
		UnitTriggerBattleConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitTriggerBattleConfigs", Classes.FArrayProperty);
		AssociationUnitInfoConfigId_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationUnitInfoConfigId");
		AssociationUnitInfoConfigId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationUnitInfoConfigId", Classes.FStructProperty);
		AssociationUnitSpawnInfoDelayExecuteTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationUnitSpawnInfoDelayExecuteTime");
		AssociationUnitSpawnInfoDelayExecuteTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationUnitSpawnInfoDelayExecuteTime", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AssociationUnitSpawnInfoSpawnType_PropertyAddress, intPtr, "AssociationUnitSpawnInfoSpawnType");
		AssociationUnitSpawnInfoSpawnType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationUnitSpawnInfoSpawnType");
		AssociationUnitSpawnInfoSpawnType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationUnitSpawnInfoSpawnType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AssociationUnitSpawnInfoActiveType_PropertyAddress, intPtr, "AssociationUnitSpawnInfoActiveType");
		AssociationUnitSpawnInfoActiveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationUnitSpawnInfoActiveType");
		AssociationUnitSpawnInfoActiveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationUnitSpawnInfoActiveType", Classes.FEnumProperty);
		AssociationUnitTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationUnitTarget");
		AssociationUnitTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationUnitTarget", Classes.FStructProperty);
		AssociationOnFightSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssociationOnFightSkillID");
		AssociationOnFightSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssociationOnFightSkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NpcMoveType_PropertyAddress, intPtr, "NpcMoveType");
		NpcMoveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "NpcMoveType");
		NpcMoveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NpcMoveType", Classes.FEnumProperty);
		NpcGuideSplineMoveConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "NpcGuideSplineMoveConfig");
		NpcGuideSplineMoveConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NpcGuideSplineMoveConfig", Classes.FStructProperty);
		WeakPerformConfigID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeakPerformConfigID");
		WeakPerformConfigID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeakPerformConfigID", Classes.FIntProperty);
		FollowPartnerConfigId_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowPartnerConfigId");
		FollowPartnerConfigId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowPartnerConfigId", Classes.FStructProperty);
		GameplayTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameplayTag");
		GameplayTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameplayTag", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bDontResetPlayerState_PropertyAddress, intPtr, "bDontResetPlayerState");
		bDontResetPlayerState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDontResetPlayerState");
		bDontResetPlayerState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDontResetPlayerState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LoadingScreenType_PropertyAddress, intPtr, "LoadingScreenType");
		LoadingScreenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoadingScreenType");
		LoadingScreenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoadingScreenType", Classes.FEnumProperty);
		UnitExtendID_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitExtendID");
		UnitExtendID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitExtendID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TeleportLoadingTips_PropertyAddress, intPtr, "TeleportLoadingTips");
		TeleportLoadingTips_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportLoadingTips");
		TeleportLoadingTips_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportLoadingTips", Classes.FArrayProperty);
		IdleProcessAction_IsValid = ((intPtr != IntPtr.Zero && ActionType_IsValid && bTeleportToOtherLevel_IsValid && TargetLevelID_IsValid && PointName_IsValid && BeforeTeleportMontage_IsValid && AfterTeleportMontage_IsValid && bSaveArchiveAfterTeleport_IsValid && ArchiveLabel_IsValid && RebirthPointID_IsValid && IsBlockRebirthpoint_IsValid && Unit_IsValid && UnitOrPlayerorNPC_IsValid && DropItemManageGuid_IsValid && AiConversation_IsValid && NPCUnit_IsValid && NPCTeamID_IsValid && NPCIdleAMIdx_IsValid && NPCLeisureAnimIndex_IsValid && NPCActionSkillID_IsValid && NPCInteractGroupID_IsValid && TargetActor_IsValid && MoveAIType_IsValid && MoveSpeedType_IsValid && MoveAcceptableRadius_IsValid && NPCShowState_IsValid && UnitTriggerBattleConfigs_IsValid && AssociationUnitInfoConfigId_IsValid && AssociationUnitSpawnInfoDelayExecuteTime_IsValid && AssociationUnitSpawnInfoSpawnType_IsValid && AssociationUnitSpawnInfoActiveType_IsValid && AssociationUnitTarget_IsValid && AssociationOnFightSkillID_IsValid && NpcMoveType_IsValid && NpcGuideSplineMoveConfig_IsValid && WeakPerformConfigID_IsValid && FollowPartnerConfigId_IsValid && GameplayTag_IsValid && bDontResetPlayerState_IsValid && LoadingScreenType_IsValid && UnitExtendID_IsValid && TeleportLoadingTips_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IdleProcessAction", (byte)IdleProcessAction_IsValid != 0);
	}

	static FIdleProcessAction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FIdleProcessAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIdleProcessAction));
	}
}
