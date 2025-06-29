using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.UI.Comm;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;
using UnrealEngine.UMG;

namespace b1.AutoQA;

[UClass]
[USharpPath("/Script/b1-Managed.AutoTestHelperLib")]
public class AutoTestHelperLib : UBlueprintFunctionLibrary
{
	[UClass]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TamerListConfig")]
	public class BGWDataAsset_TamerListConfig : UBGWDataAsset
	{
		private static bool CommandList_IsValid;

		private static int CommandList_Offset;

		private static FFieldAddress CommandList_PropertyAddress;

		private TArrayReadWriteMarshaler<string> CommandList_Marshaler;

		private static bool TamerList_IsValid;

		private static int TamerList_Offset;

		private static FFieldAddress TamerList_PropertyAddress;

		private TArrayReadWriteMarshaler<string> TamerList_Marshaler;

		[UProperty]
		[EditAnywhere]
		[BlueprintReadWrite]
		[Tooltip("需运行的控制台指令")]
		[USharpPath("/Script/b1-Managed.BGWDataAsset_TamerListConfig:CommandList")]
		public TArrayReadWrite<string> CommandList
		{
			get
			{
				CheckDestroyed();
				if (!CommandList_IsValid)
				{
					NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TamerListConfig:CommandList");
					return null;
				}
				if (CommandList_Marshaler == null)
				{
					CommandList_Marshaler = new TArrayReadWriteMarshaler<string>(1, CommandList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
				}
				return CommandList_Marshaler.FromNative(IntPtr.Add(base.Address, CommandList_Offset));
			}
		}

		[Tooltip("Tamer路径（字符串）")]
		[UProperty]
		[EditAnywhere]
		[BlueprintReadWrite]
		[USharpPath("/Script/b1-Managed.BGWDataAsset_TamerListConfig:TamerList")]
		public TArrayReadWrite<string> TamerList
		{
			get
			{
				CheckDestroyed();
				if (!TamerList_IsValid)
				{
					NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TamerListConfig:TamerList");
					return null;
				}
				if (TamerList_Marshaler == null)
				{
					TamerList_Marshaler = new TArrayReadWriteMarshaler<string>(1, TamerList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
				}
				return TamerList_Marshaler.FromNative(IntPtr.Add(base.Address, TamerList_Offset));
			}
		}

		private static void LoadNativeType()
		{
			IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TamerListConfig");
			NativeReflection.GetPropertyRef(ref CommandList_PropertyAddress, unrealStruct, "CommandList");
			CommandList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommandList");
			CommandList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommandList", Classes.FArrayProperty);
			NativeReflection.GetPropertyRef(ref TamerList_PropertyAddress, unrealStruct, "TamerList");
			TamerList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerList");
			TamerList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerList", Classes.FArrayProperty);
		}

		static BGWDataAsset_TamerListConfig()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TamerListConfig)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TamerListConfig));
		}
	}

	public static int StuckCounter;

	public static FVector LastTimePlayerLocation;

	private static readonly bool QA_Can_Blink;

	private static bool Jump_IsValid;

	private static IntPtr Jump_FunctionAddress;

	private static int Jump_ParamsSize;

	private static bool Jump_WorldContext_IsValid;

	private static int Jump_WorldContext_Offset;

	private static bool Spin_IsValid;

	private static IntPtr Spin_FunctionAddress;

	private static int Spin_ParamsSize;

	private static bool Spin_WorldContext_IsValid;

	private static int Spin_WorldContext_Offset;

	private static bool Dodge_IsValid;

	private static IntPtr Dodge_FunctionAddress;

	private static int Dodge_ParamsSize;

	private static bool Dodge_WorldContext_IsValid;

	private static int Dodge_WorldContext_Offset;

	private static bool UseItem_IsValid;

	private static IntPtr UseItem_FunctionAddress;

	private static int UseItem_ParamsSize;

	private static bool UseItem_WorldContext_IsValid;

	private static int UseItem_WorldContext_Offset;

	private static bool UseItem_ItemPosition_IsValid;

	private static int UseItem_ItemPosition_Offset;

	private static bool OpenBag_IsValid;

	private static IntPtr OpenBag_FunctionAddress;

	private static int OpenBag_ParamsSize;

	private static bool OpenBag_WorldContext_IsValid;

	private static int OpenBag_WorldContext_Offset;

	private static bool OpenBag_IsOpen_IsValid;

	private static int OpenBag_IsOpen_Offset;

	private static FFieldAddress OpenBag_IsOpen_PropertyAddress;

	private static bool SetMaxHp_IsValid;

	private static IntPtr SetMaxHp_FunctionAddress;

	private static int SetMaxHp_ParamsSize;

	private static bool SetMaxHp_Unit_IsValid;

	private static int SetMaxHp_Unit_Offset;

	private static bool FindText_IsValid;

	private static IntPtr FindText_FunctionAddress;

	private static int FindText_ParamsSize;

	private static bool FindText_WorldContext_IsValid;

	private static int FindText_WorldContext_Offset;

	private static bool FindText_Text_IsValid;

	private static int FindText_Text_Offset;

	private static FFieldAddress FindText_Text_PropertyAddress;

	private static bool FindText_bNeedClick_IsValid;

	private static int FindText_bNeedClick_Offset;

	private static FFieldAddress FindText_bNeedClick_PropertyAddress;

	private static bool FindText_ReturnValue_IsValid;

	private static int FindText_ReturnValue_Offset;

	private static FFieldAddress FindText_ReturnValue_PropertyAddress;

	private static bool TestCode_IsValid;

	private static IntPtr TestCode_FunctionAddress;

	private static int TestCode_ParamsSize;

	private static bool TestCode_WorldContext_IsValid;

	private static int TestCode_WorldContext_Offset;

	private static bool HasSpell_IsValid;

	private static IntPtr HasSpell_FunctionAddress;

	private static int HasSpell_ParamsSize;

	private static bool HasSpell_WorldContext_IsValid;

	private static int HasSpell_WorldContext_Offset;

	private static bool HasSpell_SpellID_IsValid;

	private static int HasSpell_SpellID_Offset;

	private static bool HasSpell_ReturnValue_IsValid;

	private static int HasSpell_ReturnValue_Offset;

	private static FFieldAddress HasSpell_ReturnValue_PropertyAddress;

	private static bool Interact_IsValid;

	private static IntPtr Interact_FunctionAddress;

	private static int Interact_ParamsSize;

	private static bool Interact_WorldContext_IsValid;

	private static int Interact_WorldContext_Offset;

	private static bool Interact_ReturnValue_IsValid;

	private static int Interact_ReturnValue_Offset;

	private static FFieldAddress Interact_ReturnValue_PropertyAddress;

	private static bool GenActor_IsValid;

	private static IntPtr GenActor_FunctionAddress;

	private static int GenActor_ParamsSize;

	private static bool GenActor_World_IsValid;

	private static int GenActor_World_Offset;

	private static bool GenActor_ActorClass_IsValid;

	private static int GenActor_ActorClass_Offset;

	private static bool QAPauseBT_IsValid;

	private static IntPtr QAPauseBT_FunctionAddress;

	private static int QAPauseBT_ParamsSize;

	private static bool QAPauseBT_Unit_IsValid;

	private static int QAPauseBT_Unit_Offset;

	private static bool QAPauseBT_Status_IsValid;

	private static int QAPauseBT_Status_Offset;

	private static FFieldAddress QAPauseBT_Status_PropertyAddress;

	private static bool KillEnemy_IsValid;

	private static IntPtr KillEnemy_FunctionAddress;

	private static int KillEnemy_ParamsSize;

	private static bool KillEnemy_WorldContext_IsValid;

	private static int KillEnemy_WorldContext_Offset;

	private static bool KillEnemy_KillTarget_IsValid;

	private static int KillEnemy_KillTarget_Offset;

	private static bool CastSpell_IsValid;

	private static IntPtr CastSpell_FunctionAddress;

	private static int CastSpell_ParamsSize;

	private static bool CastSpell_WorldContext_IsValid;

	private static int CastSpell_WorldContext_Offset;

	private static bool CastSpell_SkillType_IsValid;

	private static int CastSpell_SkillType_Offset;

	private static FFieldAddress CastSpell_SkillType_PropertyAddress;

	private static bool RunToEnemy_IsValid;

	private static IntPtr RunToEnemy_FunctionAddress;

	private static int RunToEnemy_ParamsSize;

	private static bool RunToEnemy_WorldContext_IsValid;

	private static int RunToEnemy_WorldContext_Offset;

	private static bool RunToEnemy_Enemy_IsValid;

	private static int RunToEnemy_Enemy_Offset;

	private static bool RunToEnemy_ReachRadius_IsValid;

	private static int RunToEnemy_ReachRadius_Offset;

	private static bool RunToEnemy_ReturnValue_IsValid;

	private static int RunToEnemy_ReturnValue_Offset;

	private static FFieldAddress RunToEnemy_ReturnValue_PropertyAddress;

	private static bool MouseGoBack_IsValid;

	private static IntPtr MouseGoBack_FunctionAddress;

	private static int MouseGoBack_ParamsSize;

	private static bool MouseGoBack_WorldContext_IsValid;

	private static int MouseGoBack_WorldContext_Offset;

	private static bool ClickButton_IsValid;

	private static IntPtr ClickButton_FunctionAddress;

	private static int ClickButton_ParamsSize;

	private static bool ClickButton_Btn_IsValid;

	private static int ClickButton_Btn_Offset;

	private static bool HeavyAttack_IsValid;

	private static IntPtr HeavyAttack_FunctionAddress;

	private static int HeavyAttack_ParamsSize;

	private static bool HeavyAttack_WorldContext_IsValid;

	private static int HeavyAttack_WorldContext_Offset;

	private static bool LightAttack_IsValid;

	private static IntPtr LightAttack_FunctionAddress;

	private static int LightAttack_ParamsSize;

	private static bool LightAttack_WorldContext_IsValid;

	private static int LightAttack_WorldContext_Offset;

	private static bool SetCurrentHp_IsValid;

	private static IntPtr SetCurrentHp_FunctionAddress;

	private static int SetCurrentHp_ParamsSize;

	private static bool SetCurrentHp_Unit_IsValid;

	private static int SetCurrentHp_Unit_Offset;

	private static bool SetCurrentHp_Hp_IsValid;

	private static int SetCurrentHp_Hp_Offset;

	private static bool MagicArtifact_IsValid;

	private static IntPtr MagicArtifact_FunctionAddress;

	private static int MagicArtifact_ParamsSize;

	private static bool MagicArtifact_WorldContext_IsValid;

	private static int MagicArtifact_WorldContext_Offset;

	private static bool RemoveGroupAI_IsValid;

	private static IntPtr RemoveGroupAI_FunctionAddress;

	private static int RemoveGroupAI_ParamsSize;

	private static bool RemoveGroupAI_WorldContext_IsValid;

	private static int RemoveGroupAI_WorldContext_Offset;

	private static bool RemoveGroupAI_OwnerActor_IsValid;

	private static int RemoveGroupAI_OwnerActor_Offset;

	private static bool ReadDataTable_IsValid;

	private static IntPtr ReadDataTable_FunctionAddress;

	private static int ReadDataTable_ParamsSize;

	private static bool ReadDataTable_ID_IsValid;

	private static int ReadDataTable_ID_Offset;

	private static bool ReadDataTable_ReturnValue_IsValid;

	private static int ReadDataTable_ReturnValue_Offset;

	private static FFieldAddress ReadDataTable_ReturnValue_PropertyAddress;

	private static bool HasItemNumber_IsValid;

	private static IntPtr HasItemNumber_FunctionAddress;

	private static int HasItemNumber_ParamsSize;

	private static bool HasItemNumber_WorldContext_IsValid;

	private static int HasItemNumber_WorldContext_Offset;

	private static bool HasItemNumber_ItemID_IsValid;

	private static int HasItemNumber_ItemID_Offset;

	private static bool HasItemNumber_ReturnValue_IsValid;

	private static int HasItemNumber_ReturnValue_Offset;

	private static bool UseVigorSkill_IsValid;

	private static IntPtr UseVigorSkill_FunctionAddress;

	private static int UseVigorSkill_ParamsSize;

	private static bool UseVigorSkill_WorldContext_IsValid;

	private static int UseVigorSkill_WorldContext_Offset;

	private static bool RunToPosition_IsValid;

	private static IntPtr RunToPosition_FunctionAddress;

	private static int RunToPosition_ParamsSize;

	private static bool RunToPosition_WorldContext_IsValid;

	private static int RunToPosition_WorldContext_Offset;

	private static bool RunToPosition_TargetLocation_IsValid;

	private static int RunToPosition_TargetLocation_Offset;

	private static FFieldAddress RunToPosition_TargetLocation_PropertyAddress;

	private static bool RunToPosition_ReachRadius_IsValid;

	private static int RunToPosition_ReachRadius_Offset;

	private static bool RunToPosition_ReturnValue_IsValid;

	private static int RunToPosition_ReturnValue_Offset;

	private static FFieldAddress RunToPosition_ReturnValue_PropertyAddress;

	private static bool FindNearbyUnit_IsValid;

	private static IntPtr FindNearbyUnit_FunctionAddress;

	private static int FindNearbyUnit_ParamsSize;

	private static bool FindNearbyUnit_WorldContext_IsValid;

	private static int FindNearbyUnit_WorldContext_Offset;

	private static bool FindNearbyUnit_AttackRadius_IsValid;

	private static int FindNearbyUnit_AttackRadius_Offset;

	private static bool FindNearbyUnit_EnemyUnit_IsValid;

	private static int FindNearbyUnit_EnemyUnit_Offset;

	private static bool FindNearbyUnit_UnitBP_IsValid;

	private static int FindNearbyUnit_UnitBP_Offset;

	private static FFieldAddress FindNearbyUnit_UnitBP_PropertyAddress;

	private static bool FindNearbyUnit_ReturnValue_IsValid;

	private static int FindNearbyUnit_ReturnValue_Offset;

	private static FFieldAddress FindNearbyUnit_ReturnValue_PropertyAddress;

	private static bool IsUnitInBattle_IsValid;

	private static IntPtr IsUnitInBattle_FunctionAddress;

	private static int IsUnitInBattle_ParamsSize;

	private static bool IsUnitInBattle_Unit_IsValid;

	private static int IsUnitInBattle_Unit_Offset;

	private static bool IsUnitInBattle_ReturnValue_IsValid;

	private static int IsUnitInBattle_ReturnValue_Offset;

	private static FFieldAddress IsUnitInBattle_ReturnValue_PropertyAddress;

	private static bool GenShiXianFeng_IsValid;

	private static IntPtr GenShiXianFeng_FunctionAddress;

	private static int GenShiXianFeng_ParamsSize;

	private static bool GenShiXianFeng_World_IsValid;

	private static int GenShiXianFeng_World_Offset;

	private static bool SetPlayerAttack_IsValid;

	private static IntPtr SetPlayerAttack_FunctionAddress;

	private static int SetPlayerAttack_ParamsSize;

	private static bool SetPlayerAttack_Unit_IsValid;

	private static int SetPlayerAttack_Unit_Offset;

	private static bool SetPlayerAttack_AttackNum_IsValid;

	private static int SetPlayerAttack_AttackNum_Offset;

	private static bool CanUnitBeTarget_IsValid;

	private static IntPtr CanUnitBeTarget_FunctionAddress;

	private static int CanUnitBeTarget_ParamsSize;

	private static bool CanUnitBeTarget_Enemy_IsValid;

	private static int CanUnitBeTarget_Enemy_Offset;

	private static bool CanUnitBeTarget_ReturnValue_IsValid;

	private static int CanUnitBeTarget_ReturnValue_Offset;

	private static FFieldAddress CanUnitBeTarget_ReturnValue_PropertyAddress;

	private static bool DrinkBloodBottom_IsValid;

	private static IntPtr DrinkBloodBottom_FunctionAddress;

	private static int DrinkBloodBottom_ParamsSize;

	private static bool DrinkBloodBottom_WorldContext_IsValid;

	private static int DrinkBloodBottom_WorldContext_Offset;

	private static bool QADrawSkillRange_IsValid;

	private static IntPtr QADrawSkillRange_FunctionAddress;

	private static int QADrawSkillRange_ParamsSize;

	private static bool QADrawSkillRange_Unit_IsValid;

	private static int QADrawSkillRange_Unit_Offset;

	private static bool QADrawSkillRange_SkillID_IsValid;

	private static int QADrawSkillRange_SkillID_Offset;

	private static bool QADrawSkillRange_Duration_IsValid;

	private static int QADrawSkillRange_Duration_Offset;

	private static bool CameraLockTarget_IsValid;

	private static IntPtr CameraLockTarget_FunctionAddress;

	private static int CameraLockTarget_ParamsSize;

	private static bool CameraLockTarget_WorldContext_IsValid;

	private static int CameraLockTarget_WorldContext_Offset;

	private static bool CameraLockTarget_LockTarget_IsValid;

	private static int CameraLockTarget_LockTarget_Offset;

	private static bool AutoMoveComplete_IsValid;

	private static IntPtr AutoMoveComplete_FunctionAddress;

	private static int AutoMoveComplete_ParamsSize;

	private static bool AutoMoveComplete_WorldContext_IsValid;

	private static int AutoMoveComplete_WorldContext_Offset;

	private static bool IsEquippingSpell_IsValid;

	private static IntPtr IsEquippingSpell_FunctionAddress;

	private static int IsEquippingSpell_ParamsSize;

	private static bool IsEquippingSpell_WorldContext_IsValid;

	private static int IsEquippingSpell_WorldContext_Offset;

	private static bool IsEquippingSpell_SpellID_IsValid;

	private static int IsEquippingSpell_SpellID_Offset;

	private static bool IsEquippingSpell_ReturnValue_IsValid;

	private static int IsEquippingSpell_ReturnValue_Offset;

	private static FFieldAddress IsEquippingSpell_ReturnValue_PropertyAddress;

	private static bool QAStringArraySort_IsValid;

	private static IntPtr QAStringArraySort_FunctionAddress;

	private static int QAStringArraySort_ParamsSize;

	private static bool QAStringArraySort_StringList_IsValid;

	private static int QAStringArraySort_StringList_Offset;

	private static FFieldAddress QAStringArraySort_StringList_PropertyAddress;

	private static bool QAStringArraySort_ReturnValue_IsValid;

	private static int QAStringArraySort_ReturnValue_Offset;

	private static FFieldAddress QAStringArraySort_ReturnValue_PropertyAddress;

	private static bool GetUnitAllSkillID_IsValid;

	private static IntPtr GetUnitAllSkillID_FunctionAddress;

	private static int GetUnitAllSkillID_ParamsSize;

	private static bool GetUnitAllSkillID_Unit_IsValid;

	private static int GetUnitAllSkillID_Unit_Offset;

	private static bool GetUnitAllSkillID_ReturnValue_IsValid;

	private static int GetUnitAllSkillID_ReturnValue_Offset;

	private static FFieldAddress GetUnitAllSkillID_ReturnValue_PropertyAddress;

	private static bool QAGetCurrentAMName_IsValid;

	private static IntPtr QAGetCurrentAMName_FunctionAddress;

	private static int QAGetCurrentAMName_ParamsSize;

	private static bool QAGetCurrentAMName_Target_IsValid;

	private static int QAGetCurrentAMName_Target_Offset;

	private static bool QAGetCurrentAMName_ReturnValue_IsValid;

	private static int QAGetCurrentAMName_ReturnValue_Offset;

	private static FFieldAddress QAGetCurrentAMName_ReturnValue_PropertyAddress;

	private static bool JudgeWidgetVisible_IsValid;

	private static IntPtr JudgeWidgetVisible_FunctionAddress;

	private static int JudgeWidgetVisible_ParamsSize;

	private static bool JudgeWidgetVisible_Widget_IsValid;

	private static int JudgeWidgetVisible_Widget_Offset;

	private static bool JudgeWidgetVisible_ReturnValue_IsValid;

	private static int JudgeWidgetVisible_ReturnValue_Offset;

	private static FFieldAddress JudgeWidgetVisible_ReturnValue_PropertyAddress;

	private static bool QAGetCurrentSkillID_IsValid;

	private static IntPtr QAGetCurrentSkillID_FunctionAddress;

	private static int QAGetCurrentSkillID_ParamsSize;

	private static bool QAGetCurrentSkillID_Target_IsValid;

	private static int QAGetCurrentSkillID_Target_Offset;

	private static bool QAGetCurrentSkillID_ReturnValue_IsValid;

	private static int QAGetCurrentSkillID_ReturnValue_Offset;

	private static FFieldAddress QAGetCurrentSkillID_ReturnValue_PropertyAddress;

	private static bool GetTamerInViewCount_IsValid;

	private static IntPtr GetTamerInViewCount_FunctionAddress;

	private static int GetTamerInViewCount_ParamsSize;

	private static bool GetTamerInViewCount_WorldContext_IsValid;

	private static int GetTamerInViewCount_WorldContext_Offset;

	private static bool GetPlayerTargetActor_IsValid;

	private static IntPtr GetPlayerTargetActor_FunctionAddress;

	private static int GetPlayerTargetActor_ParamsSize;

	private static bool GetPlayerTargetActor_WorldContext_IsValid;

	private static int GetPlayerTargetActor_WorldContext_Offset;

	private static bool GetPlayerTargetActor_ReturnValue_IsValid;

	private static int GetPlayerTargetActor_ReturnValue_Offset;

	private static bool IsPlayingCameraMovie_IsValid;

	private static IntPtr IsPlayingCameraMovie_FunctionAddress;

	private static int IsPlayingCameraMovie_ParamsSize;

	private static bool IsPlayingCameraMovie_WorldContext_IsValid;

	private static int IsPlayingCameraMovie_WorldContext_Offset;

	private static bool IsPlayingCameraMovie_ReturnValue_IsValid;

	private static int IsPlayingCameraMovie_ReturnValue_Offset;

	private static FFieldAddress IsPlayingCameraMovie_ReturnValue_PropertyAddress;

	private static bool GetPlayingSequenceID_IsValid;

	private static IntPtr GetPlayingSequenceID_FunctionAddress;

	private static int GetPlayingSequenceID_ParamsSize;

	private static bool GetPlayingSequenceID_WorldContext_IsValid;

	private static int GetPlayingSequenceID_WorldContext_Offset;

	private static bool GetPlayingSequenceID_SequenceID_IsValid;

	private static int GetPlayingSequenceID_SequenceID_Offset;

	private static bool GetPlayingSequenceID_ReturnValue_IsValid;

	private static int GetPlayingSequenceID_ReturnValue_Offset;

	private static FFieldAddress GetPlayingSequenceID_ReturnValue_PropertyAddress;

	private static bool GetActorLocationByName_IsValid;

	private static IntPtr GetActorLocationByName_FunctionAddress;

	private static int GetActorLocationByName_ParamsSize;

	private static bool GetActorLocationByName_WorldContext_IsValid;

	private static int GetActorLocationByName_WorldContext_Offset;

	private static bool GetActorLocationByName_ActorName_IsValid;

	private static int GetActorLocationByName_ActorName_Offset;

	private static FFieldAddress GetActorLocationByName_ActorName_PropertyAddress;

	private static bool GetActorLocationByName_ActorLocation_IsValid;

	private static int GetActorLocationByName_ActorLocation_Offset;

	private static FFieldAddress GetActorLocationByName_ActorLocation_PropertyAddress;

	private static bool GetActorLocationByName_ReturnValue_IsValid;

	private static int GetActorLocationByName_ReturnValue_Offset;

	private static FFieldAddress GetActorLocationByName_ReturnValue_PropertyAddress;

	private static bool QAUploadPerformanceData_IsValid;

	private static IntPtr QAUploadPerformanceData_FunctionAddress;

	private static int QAUploadPerformanceData_ParamsSize;

	private static bool QAUploadPerformanceData_WorldContext_IsValid;

	private static int QAUploadPerformanceData_WorldContext_Offset;

	private static bool QAUploadPerformanceData_Catelog_IsValid;

	private static int QAUploadPerformanceData_Catelog_Offset;

	private static FFieldAddress QAUploadPerformanceData_Catelog_PropertyAddress;

	private static bool QAUploadPerformanceData_Summary_IsValid;

	private static int QAUploadPerformanceData_Summary_Offset;

	private static FFieldAddress QAUploadPerformanceData_Summary_PropertyAddress;

	private static bool QAUploadPerformanceData_FileList_IsValid;

	private static int QAUploadPerformanceData_FileList_Offset;

	private static FFieldAddress QAUploadPerformanceData_FileList_PropertyAddress;

	private static bool RebirthPointChoiceClick_IsValid;

	private static IntPtr RebirthPointChoiceClick_FunctionAddress;

	private static int RebirthPointChoiceClick_ParamsSize;

	private static bool RebirthPointChoiceClick_WorldContext_IsValid;

	private static int RebirthPointChoiceClick_WorldContext_Offset;

	private static bool RebirthPointChoiceClick_Choice_IsValid;

	private static int RebirthPointChoiceClick_Choice_Offset;

	private static FFieldAddress RebirthPointChoiceClick_Choice_PropertyAddress;

	private static bool RebirthPointChoiceClick_ReturnValue_IsValid;

	private static int RebirthPointChoiceClick_ReturnValue_Offset;

	private static FFieldAddress RebirthPointChoiceClick_ReturnValue_PropertyAddress;

	private static bool AutoTestInjectInputEvent_IsValid;

	private static IntPtr AutoTestInjectInputEvent_FunctionAddress;

	private static int AutoTestInjectInputEvent_ParamsSize;

	private static bool AutoTestInjectInputEvent_WorldContext_IsValid;

	private static int AutoTestInjectInputEvent_WorldContext_Offset;

	private static bool AutoTestInjectInputEvent_ActionName_IsValid;

	private static int AutoTestInjectInputEvent_ActionName_Offset;

	private static FFieldAddress AutoTestInjectInputEvent_ActionName_PropertyAddress;

	private static bool AutoTestInjectInputEvent_TriggerEvent_IsValid;

	private static int AutoTestInjectInputEvent_TriggerEvent_Offset;

	private static FFieldAddress AutoTestInjectInputEvent_TriggerEvent_PropertyAddress;

	[BlueprintCallable]
	[UFunction]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:IsPlayingCameraMovie")]
	public static bool IsPlayingCameraMovie(UObject WorldContext)
	{
		return BGS_EventCollectionCS.Get(WorldContext)?.Evt_QueryIsPlayingCameraMovie.Invoke() ?? false;
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GetPlayingSequenceID")]
	public static bool GetPlayingSequenceID(UObject WorldContext, out int SequenceID)
	{
		SequenceID = BGS_EventCollectionCS.Get(WorldContext)?.Evt_QueryPlayingSequenceID.Invoke() ?? 0;
		return SequenceID != 0;
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:LightAttack")]
	public static void LightAttack(UObject WorldContext)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1LightAttack", ETriggerEvent.Started, FInputActionValue.True);
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1LightAttack", ETriggerEvent.Completed, FInputActionValue.True);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:HeavyAttack")]
	public static void HeavyAttack(UObject WorldContext)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1HeavyAttack", ETriggerEvent.Started, FInputActionValue.True);
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1HeavyAttack", ETriggerEvent.Completed, FInputActionValue.True);
	}

	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:Dodge")]
	public static void Dodge(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Roll_KB", ETriggerEvent.Started, FInputActionValue.True);
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:Jump")]
	public static void Jump(UObject WorldContext)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Jump", ETriggerEvent.Started, FInputActionValue.True);
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Jump", ETriggerEvent.Completed, FInputActionValue.True);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:Spin")]
	public static void Spin(UObject WorldContext)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spin", ETriggerEvent.Started, FInputActionValue.True);
		BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spin", ETriggerEvent.Completed, FInputActionValue.True);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:UseVigorSkill")]
	public static void UseVigorSkill(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)?.Evt_TriggerInputActionImpl.Invoke("IA_B1UseVigorSkill", ETriggerEvent.Started, FInputActionValue.True);
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:MagicArtifact")]
	public static void MagicArtifact(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)?.Evt_TriggerInputActionImpl.Invoke("IA_B1MagicArtifact", ETriggerEvent.Started, FInputActionValue.True);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:DrinkBloodBottom")]
	public static void DrinkBloodBottom(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)?.Evt_TriggerInputActionImpl.Invoke("IA_B1DrinkBloodBottom", ETriggerEvent.Started, FInputActionValue.True);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:UseItem")]
	public static void UseItem(UObject WorldContext, int ItemPosition)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		if (ItemPosition > 0 && ItemPosition < 5)
		{
			BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1UseItem_" + ItemPosition, ETriggerEvent.Started, FInputActionValue.True);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:Interact")]
	public static bool Interact(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn()).Evt_InputInteract.Invoke();
		return true;
	}

	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:CastSpell")]
	public static void CastSpell(UObject WorldContext, SpellType SkillType)
	{
		BGUCharacterCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		switch (SkillType)
		{
		case SpellType.QiShu:
			BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spell_QS", ETriggerEvent.Started, FInputActionValue.True);
			break;
		case SpellType.ShenFa:
			BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spell_SF", ETriggerEvent.Started, FInputActionValue.True);
			break;
		case SpellType.HaoMao:
			BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spell_HM", ETriggerEvent.Started, FInputActionValue.True);
			break;
		case SpellType.BianShen:
			BUS_EventCollectionCS.Get(actor)?.Evt_TriggerInputActionImpl.Invoke("IA_B1Spell_BS", ETriggerEvent.Started, FInputActionValue.True);
			break;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:CameraLockTarget")]
	public static void CameraLockTarget(UObject WorldContext, AActor LockTarget)
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn()).Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(LockTarget, ETargetSourceType.None));
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:HasItemNumber")]
	public static int HasItemNumber(UObject WorldContext, int ItemID)
	{
		return RoleDataHelper.GetBagItemNum(BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)), ItemID);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:IsEquippingSpell")]
	public static bool IsEquippingSpell(UObject WorldContext, int SpellID)
	{
		foreach (ReadOnlySpellItem spell in BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)).RoleData.RoleCs.Actor.Wear.SpellList)
		{
			if (spell.SpellId == SpellID)
			{
				return true;
			}
		}
		return false;
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:HasSpell")]
	public static bool HasSpell(UObject WorldContext, int SpellID)
	{
		foreach (int spell in BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)).RoleData.RoleCs.Actor.Progress.SpellList)
		{
			if (spell == SpellID)
			{
				return true;
			}
		}
		return false;
	}

	public static void RandomSetFaBao(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] CurPC.IsNullOrDestroyed!");
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] BTFEventCollection == null!");
			return;
		}
		List<int> list = new List<int> { 19001, 19002, 19004, 19005 };
		List<ulong> list2 = new List<ulong>();
		foreach (ReadOnlyRoleEquip equip in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Bag.EquipList)
		{
			if (list.Contains(equip.EquipId))
			{
				list2.Add(equip.Uid);
			}
		}
		int index = new Random().Next(0, list2.Count);
		ulong num = list2[index];
		if (num != 0)
		{
			CSMsgActorWearEquipReq actorWearEquip = new CSMsgActorWearEquipReq
			{
				EquipUid = num
			};
			bTF_EventCollectionCS.Evt_ActorWearEquipReq(actorWearEquip, delegate
			{
			});
		}
	}

	public static void RandomSetVigorSkill(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] CurPC.IsNullOrDestroyed!");
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] BTFEventCollection == null!");
			return;
		}
		List<ulong> list = new List<ulong>();
		foreach (ReadOnlyRoleSoulSkill soulSkill in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Bag.SoulSkillList)
		{
			list.Add(soulSkill.Uid);
		}
		int index = new Random().Next(0, list.Count);
		ulong num = list[index];
		if (num != 0)
		{
			CSMsgActorSetSoulSkillReq actorSetSoulSkill = new CSMsgActorSetSoulSkillReq
			{
				Uid = num
			};
			bTF_EventCollectionCS.Evt_ActorSetSoulSkillReq(actorSetSoulSkill, delegate
			{
			});
		}
	}

	public static void RandomSetSpell(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] CurPC.IsNullOrDestroyed!");
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[AutoTestHelperLib] BTFEventCollection == null!");
			return;
		}
		Dictionary<SpellType, List<int>> dictionary = new Dictionary<SpellType, List<int>>();
		foreach (SpellType value in Enum.GetValues(typeof(SpellType)))
		{
			dictionary[value] = new List<int>();
		}
		List<SpellType> list = new List<SpellType>
		{
			SpellType.QiShu,
			SpellType.ShenFa,
			SpellType.HaoMao,
			SpellType.BianShen
		};
		foreach (int spell in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Actor.Progress.SpellList)
		{
			SpellType type = GameDBRuntime.GetSpellDesc(spell).Type;
			if (list.Contains(type))
			{
				dictionary[type].Add(spell);
			}
		}
		foreach (SpellType key in dictionary.Keys)
		{
			if (dictionary[key].Count != 0)
			{
				int index = new Random().Next(0, dictionary[key].Count);
				int num = dictionary[key][index];
				if (num <= 5400)
				{
					CSMsgActorSetSpellReq actorSetSpell = new CSMsgActorSetSpellReq
					{
						SpellId = num
					};
					bTF_EventCollectionCS.Evt_ActorSetSpellReq(actorSetSpell, delegate
					{
					});
				}
			}
		}
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GetActorLocationByName")]
	public static bool GetActorLocationByName(UObject WorldContext, string ActorName, out FVector ActorLocation)
	{
		ActorLocation = default(FVector);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
		foreach (AActor aActor in allActorsOfClass)
		{
			if (aActor.GetName() == ActorName)
			{
				ActorLocation = aActor.GetActorLocation();
				return true;
			}
		}
		return false;
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:ReadDataTable")]
	public static string ReadDataTable(int ID)
	{
		BGW_GameDB.GetAllRebirthPointDesc();
		return BGW_GameDB.GetRebirthPointDesc(ID).Name;
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:KillEnemy")]
	public static void KillEnemy(UObject WorldContext, ref AActor KillTarget)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(KillTarget);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_UnitDead.Invoke(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EDeadReason.SkillDamage);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:RemoveGroupAI")]
	public static void RemoveGroupAI(UObject WorldContext, AActor OwnerActor)
	{
		BGS_EventCollectionCS.Get(OwnerActor).Evt_BGS_RemovePerformerInList.Invoke(ECSExtension.ToEntity(OwnerActor), ERecoverTokenReason.AutoTest);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_SwitchBehaviourTree.Invoke(P1: false, "");
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GenActor")]
	public static void GenActor(ref UWorld World, TSubclassOf<AActor> ActorClass)
	{
		FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).GetControlledPawn().GetActorLocation();
		FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).GetControlledPawn().GetControlRotation()
			.GetForwardVector() * 300.0;
		FVector location = actorLocation + fVector;
		FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
		FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		World.SpawnActor(ActorClass.Value, ref location, ref rotation, ref parameters);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GenShiXianFeng")]
	public static void GenShiXianFeng(ref UWorld World)
	{
		FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).GetControlledPawn().GetActorLocation();
		FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).GetControlledPawn().GetControlRotation()
			.GetForwardVector() * 300.0;
		FVector location = actorLocation + fVector;
		FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
		FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		UClass unrealClass = BGW_PreloadAssetMgr.Get(World).TryGetCachedResourceObj<UClass>("PrefabricatorAsset'/Game/00Main/Design/Units/HFM/Unit_HFM_ShiXianFeng_01_Prefab.Unit_HFM_ShiXianFeng_01_Prefab_C'", ELoadResourceType.SyncLoadAndCache);
		World.SpawnActor(unrealClass, ref location, ref rotation, ref parameters);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:SetPlayerAttack")]
	public static void SetPlayerAttack(AActor Unit, int AttackNum)
	{
		BUS_EventCollectionCS.Get(Unit).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.AtkBase, AttackNum);
		BUS_EventCollectionCS.Get(Unit).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Atk, AttackNum);
	}

	public static void QALog(UObject WorldContext, string InString)
	{
		USystemLibrary.PrintString(WorldContext, InString, bPrintToScreen: true, bPrintToLog: false, FLinearColor.Aqua, 5f, new FName("None"));
		UGSE_EngineFuncLib.LogWLevel(InString, 4);
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:SetCurrentHp")]
	public static void SetCurrentHp(AActor Unit, int Hp)
	{
		BUS_EventCollectionCS.Get(Unit)?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, Hp);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:SetMaxHp")]
	public static void SetMaxHp(AActor Unit)
	{
		BUS_EventCollectionCS.Get(Unit)?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, BGUFunctionLibraryCS.BGUGetFloatAttr(Unit, EBGUAttrFloat.HpMax));
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:RebirthPointChoiceClick")]
	public static bool RebirthPointChoiceClick(UObject WorldContext, string Choice)
	{
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Btn/BI_Shrine_Main_Btn.BI_Shrine_Main_Btn_C'", ELoadResourceType.SyncLoadAndCache);
		UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, uClass, TopLevelOnly: false);
		bool result = false;
		foreach (BUI_Button item in FoundWidgets)
		{
			if ((UGSE_UMGFuncLib.GetWidgetFromName(item, new FName("TxtName")) as UTextBlock).GetText() == Choice)
			{
				result = true;
				ClickButton(item);
				break;
			}
		}
		return result;
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:JudgeWidgetVisible")]
	public static bool JudgeWidgetVisible(UWidget Widget)
	{
		if (!Widget.IsVisible())
		{
			return false;
		}
		if (Widget.GetParent() != null)
		{
			return JudgeWidgetVisible(Widget.GetParent());
		}
		if (Widget.GetOuter() != null && Widget.GetOuter().GetOuter() as UWidget != null)
		{
			return JudgeWidgetVisible(Widget.GetOuter().GetOuter() as UWidget);
		}
		return true;
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:FindText")]
	public static bool FindText(UObject WorldContext, string Text, bool bNeedClick = false)
	{
		bool result = false;
		UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(WorldContext, out var FoundWidgets, UClass.GetClass<UTextBlock>());
		foreach (UTextBlock item in FoundWidgets)
		{
			if (item.GetText() == Text && JudgeWidgetVisible(item))
			{
				if (bNeedClick)
				{
					ClickButton(item);
				}
				result = true;
			}
		}
		return result;
	}

	private static int GetMapIDFromSequenceID(int SequenceID)
	{
		int num = SequenceID / 1000000;
		if (num >= 10 && num < 100)
		{
			return num;
		}
		return 0;
	}

	private static bool IsInGameSequenceItem(FUStMovieSequenceDesc Desc)
	{
		if (Desc.SeqDesc.Length == 0)
		{
			return false;
		}
		if (GetMapIDFromSequenceID(Desc.ID) != 0)
		{
			return true;
		}
		return false;
	}

	public static void RunBat(ProcessStartInfo StartInfo, bool IsWait, bool IsCatchExitCode = false)
	{
		try
		{
			Process process = new Process();
			process.StartInfo = StartInfo;
			process.Start();
			if (IsWait)
			{
				process.WaitForExit();
				if (process.ExitCode != 0 && IsCatchExitCode)
				{
					throw new Exception($"Run bat {StartInfo.FileName} in {StartInfo.WorkingDirectory} exits with code: {process.ExitCode}");
				}
			}
		}
		catch (Exception ex)
		{
			FMessage.OpenDialog(ex.Message);
			BGW_LogUtil.LogError(ex.Message);
		}
	}

	private static bool CheckIsPlayerInTransState(UObject WorldContext)
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
		if (controlledPawn != null)
		{
			APlayerState playerState = controlledPawn.PlayerState;
			if (playerState != null)
			{
				IBPC_TransData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(playerState);
				IBPC_PlayerTagData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(playerState);
				if (readOnlyData != null && readOnlyData2.HasTag(EBGPPlayerTag.Transforming))
				{
					return true;
				}
			}
		}
		return false;
	}

	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:TestCode")]
	public static void TestCode(UObject WorldContext)
	{
		new List<FVector>
		{
			new FVector(1.0, 2.0, 3.0),
			new FVector(2.0, 3.0, 4.0),
			new FVector(3.0, 4.0, 5.0),
			new FVector(4.0, 5.0, 6.0)
		};
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:ClickButton")]
	public static void ClickButton(UWidget Btn)
	{
		UWidget uWidget = Btn;
		while (!(uWidget is BUI_Button))
		{
			UWidget parent = uWidget.GetParent();
			if (parent == null)
			{
				if (!(uWidget.GetOuter() != null) || !(uWidget.GetOuter().GetOuter() as UWidget != null))
				{
					uWidget = null;
					break;
				}
				uWidget = uWidget.GetOuter().GetOuter() as UWidget;
			}
			else
			{
				uWidget = parent;
			}
		}
		if (uWidget != null)
		{
			QALog(Btn, "能找到对应的BUTTON，则直接调用C#");
			(uWidget as BUI_Button).TriggerGSClicked();
			return;
		}
		QALog(Btn, "模拟鼠标点击，但只能用于PC");
		UGSE_UMGFuncLib.QAGetWidgetCenterPosition(Btn, out var _, out var CenterPosition, out var _);
		QASimulateWindowsOperations.SetCursorPosition((int)CenterPosition.X, (int)CenterPosition.Y);
		QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.LeftDown);
		QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.LeftUp);
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:MouseGoBack")]
	public static void MouseGoBack(UObject WorldContext)
	{
		QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.RightDown);
		QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.RightUp);
	}

	[UFunction]
	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:OpenBag")]
	public static void OpenBag(UObject WorldContext, bool IsOpen)
	{
		if (IsOpen)
		{
			BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent("IA_B1BattleStart", ETriggerEvent.Triggered, FInputActionValue.True);
		}
		else
		{
			BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent("IA_GSUIStart", ETriggerEvent.Triggered, FInputActionValue.True);
		}
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:AutoTestInjectInputEvent")]
	public static void AutoTestInjectInputEvent(UObject WorldContext, string ActionName, ETriggerEvent TriggerEvent)
	{
		BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent(ActionName, TriggerEvent, FInputActionValue.True);
	}

	[Category("QA|AutoTest")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:IsUnitInBattle")]
	public static bool IsUnitInBattle(AActor Unit)
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(Unit).IsUnitInBattle();
	}

	[Category("QA|AutoTest")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:CanUnitBeTarget")]
	public static bool CanUnitBeTarget(BGUCharacterCS Enemy)
	{
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Enemy).GetControlledPawn() as BGUCharacterCS;
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Enemy);
		bool result = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Enemy)?.GetTargetInfo()?.LockTargetActor == bGUCharacterCS;
		bool flag = unPersistentReadOnlyData != null && unPersistentReadOnlyData.UnitAIAttackType == EUnitAIAttackType.PassiveAttack;
		if (BGUFunctionLibraryCS.BGUHasBuffByID(Enemy, 920))
		{
			return true;
		}
		if (!BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Enemy, EBGUSimpleState.BounceAttack) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Enemy, EBGUSimpleState.CantBeLock) && !BGUFunctionLibraryCS.BGUHasBuffByID(Enemy, 802) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Enemy, EBGUSimpleState.CantBeBaseTarget) && BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS, Enemy))
		{
			if (flag)
			{
				return result;
			}
			return true;
		}
		return false;
	}

	[Category("QA|AutoTest")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:FindNearbyUnit")]
	public static bool FindNearbyUnit(UObject WorldContext, int AttackRadius, out BGUCharacterCS EnemyUnit, string UnitBP = "Blueprint'/Game/00Main/BPLibrary/UnitBase/BP_BotBase.BP_BotBase_C'")
	{
		EnemyUnit = null;
		if (AttackRadius == 0)
		{
			return false;
		}
		double num = double.MaxValue;
		UClass actorClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(UnitBP, ELoadResourceType.SyncLoadAndCache);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, actorClass);
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS2 = (BGUCharacterCS)array[i];
			if (CanUnitBeTarget(bGUCharacterCS2))
			{
				FVector actorLocation = bGUCharacterCS.GetActorLocation();
				FVector actorLocation2 = bGUCharacterCS2.GetActorLocation();
				double num2 = UMathLibrary.Distance2D(new FVector2D(actorLocation.X, actorLocation.Y), new FVector2D(actorLocation2.X, actorLocation2.Y));
				UBGUFunctionLibraryForCS.BGUGetBounds(bGUCharacterCS2.Mesh, out var Origin, out var BoxExtent);
				_ = BoxExtent.X;
				_ = BoxExtent.Y;
				float z = BoxExtent.Z;
				UBGUFunctionLibraryForCS.BGUGetBounds(bGUCharacterCS.Mesh, out var Origin2, out var BoxExtent2);
				_ = BoxExtent2.X;
				_ = BoxExtent2.Y;
				float z2 = BoxExtent2.Z;
				if (num2 < (double)AttackRadius && FMath.Abs((Origin2 - Origin).Z) < z + z2 && num2 < num)
				{
					num = num2;
					EnemyUnit = bGUCharacterCS2;
				}
			}
		}
		return EnemyUnit != null;
	}

	public static void KillNearbyUnits(UObject WorldContext, int Radius)
	{
		UClass actorClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/UnitBase/BP_BotBase.BP_BotBase_C'", ELoadResourceType.SyncLoadAndCache);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, actorClass);
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS2 = (BGUCharacterCS)array[i];
			if (!BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS2, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasBuffByID(bGUCharacterCS2, 802) && UMathLibrary.Vector_Distance(bGUCharacterCS2.GetActorLocation(), bGUCharacterCS.GetActorLocation()) < (double)Radius && BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS, bGUCharacterCS2))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS2).Evt_UnitDead.Invoke(bGUCharacterCS, EDeadReason.SkillDamage);
			}
		}
	}

	public static bool FindNearbyRebirthPoint(UObject WorldContext, int Radius, out AActor RebirthPointActor)
	{
		RebirthPointActor = null;
		UClass actorClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Maps/HFM02/RebirthPoint/RebirthPoint_HFM_Default.RebirthPoint_HFM_Default_C'", ELoadResourceType.SyncLoadAndCache);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, actorClass);
		foreach (AActor aActor in allActorsOfClass)
		{
			if (!aActor.IsNullOrDestroyed() && UMathLibrary.Vector_Distance(aActor.GetActorLocation(), UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation()) < (double)Radius)
			{
				RebirthPointActor = aActor;
				return true;
			}
		}
		return false;
	}

	public static void ApproachAndAttack(UObject WorldContext, BGUCharacterCS Enemy)
	{
		List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery4 };
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
		FVector actorLocation = controlledPawn.GetActorLocation();
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(controlledPawn);
		if ((double)(readOnlyData.GetFloatValue(EBGUAttrFloat.Hp) / readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax)) < 0.5 && readOnlyData.GetFloatValue(EBGUAttrFloat.BloodBottomNum) > 0f)
		{
			DrinkBloodBottom(WorldContext);
			return;
		}
		UBGUSelectUtil.LineTraceForObjects(WorldContext, actorLocation + controlledPawn.GetActorRotation().GetForwardVector() * 150.0, Enemy.GetActorLocation(), objectTypes, bDebug: false, out var HitResult);
		if (!(UMathLibrary.Distance2D(new FVector2D(Enemy.GetActorLocation()), new FVector2D(actorLocation)) < 1000.0))
		{
			_ = HitResult.HitLocation;
			if (!(HitResult.HitLocation != FVector.ZeroVector) || !(UMathLibrary.Vector_Distance(HitResult.HitLocation, actorLocation) < 1000.0))
			{
				RunToEnemy(WorldContext, Enemy);
				return;
			}
		}
		CameraLockTarget(WorldContext, Enemy);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		firstLocalPlayerController.StopMovement();
		int num = BGUFunctionLibraryCS.BGUGetCurPELevel(controlledPawn);
		if (num >= 3)
		{
			HeavyAttack(WorldContext);
			return;
		}
		int num2 = new Random().Next(10);
		switch (num2)
		{
		case 1:
			if (num >= 2)
			{
				HeavyAttack(WorldContext);
			}
			else
			{
				LightAttack(WorldContext);
			}
			break;
		case 2:
		{
			int p = new Random(Guid.NewGuid().GetHashCode()).Next(3);
			BUS_EventCollectionCS.Get(controlledPawn)?.Evt_SwitchWeaponPoseByType.Invoke(p);
			LightAttack(WorldContext);
			break;
		}
		case 3:
			Spin(WorldContext);
			break;
		case 4:
		{
			IBPC_PlayerRoleData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
			if (readOnlyData3 == null || readOnlyData3.RoleData == null)
			{
				LightAttack(WorldContext);
				break;
			}
			int? num4 = readOnlyData3.RoleData?.RoleCs?.Actor?.Wear?.WearSoulSkill?.SoulSkillId;
			if (num4.HasValue && num4 > 0)
			{
				UseVigorSkill(WorldContext);
			}
			LightAttack(WorldContext);
			break;
		}
		case 5:
			Dodge(WorldContext);
			break;
		case 6:
			if (BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipFaBaoData>(controlledPawn).FaBaoState == EFaBaoState.Carry)
			{
				MagicArtifact(WorldContext);
			}
			LightAttack(WorldContext);
			break;
		case 9:
		{
			if (BIS_AutoTestManagerV2.Get(WorldContext).IsInvincibleMode)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.fullMP", null);
			}
			List<FUStMagicConfInfo> list = new List<FUStMagicConfInfo>();
			IBUC_PlayerSpellConfData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(controlledPawn);
			if (readOnlyData2?.MagicConfInfo != null)
			{
				new StringBuilder();
				int num3 = Math.Min(readOnlyData2.MagicConfInfo.Count, 4);
				for (int i = 0; i < num3; i++)
				{
					FUStMagicConfInfo item = readOnlyData2.MagicConfInfo[i];
					list.Add(item);
				}
			}
			BGUCharacterCS Caster = firstLocalPlayerController.GetControlledPawn() as BGUCharacterCS;
			List<SpellType> Types = new List<SpellType>
			{
				SpellType.QiShu,
				SpellType.ShenFa,
				SpellType.HaoMao
			};
			readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(controlledPawn);
			if (readOnlyData.GetFloatValue(EBGUAttrFloat.CurEnergy) == readOnlyData.GetFloatValue(EBGUAttrFloat.TransEnergyMax))
			{
				Types.Add(SpellType.BianShen);
			}
			FUStMagicConfInfo fUStMagicConfInfo = (from fUStMagicConfInfo2 in list
				where fUStMagicConfInfo2.SpellID != 0 && Types.Contains(fUStMagicConfInfo2.Type) && BGU_CommonUtil.CheckSkillCanCast(Caster, GameDBRuntime.GetSpellDesc(fUStMagicConfInfo2.SpellID).SkillId, BGUFuncLibSkillCS.BGUGetSkillIDByMapping(Caster, GameDBRuntime.GetSpellDesc(fUStMagicConfInfo2.SpellID).SkillId)) == ECanCastSkillResult.CCSR_OK
				orderby new Random().Next(10)
				select fUStMagicConfInfo2).FirstOrDefault();
			if (fUStMagicConfInfo != null)
			{
				CastSpell(WorldContext, fUStMagicConfInfo.Type);
			}
			else
			{
				LightAttack(WorldContext);
			}
			break;
		}
		default:
			LightAttack(WorldContext);
			break;
		}
	}

	public static EAINodeActionType GetAutoTestActionState(UObject WorldContext)
	{
		return BGU_DataUtil.GetReadOnlyData<IBPC_AutoTestData, BPC_AutoTestData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).PlayerState).CurrentActionType;
	}

	public static void Combo(UObject WorldContext, float MaxTime, AActor Enemy)
	{
		((UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext) as BGP_PlayerControllerCS).PlayerState as BGP_PlayerStateCS).PlayerEventCollection.Evt_BPS_Combo.Invoke(MaxTime, Enemy);
	}

	public static void RunToPos(UObject WorldContext, FVector Locaton, bool IsForvedMove, float MaxTime, int ReachRadius = 250)
	{
		((UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext) as BGP_PlayerControllerCS).PlayerState as BGP_PlayerStateCS).PlayerEventCollection.Evt_BPS_MoveToPos.Invoke(Locaton, IsForvedMove, MaxTime);
	}

	public static void StopCurrentAction(UObject WorldContext)
	{
		((UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext) as BGP_PlayerControllerCS).PlayerState as BGP_PlayerStateCS).PlayerEventCollection.Evt_BPS_StopCurrentAction.Invoke();
	}

	[Category("QA|AutoTest")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:RunToPosition")]
	public static bool RunToPosition(UObject WorldContext, FVector TargetLocation, int ReachRadius = 150)
	{
		if (TargetLocation == FVector.ZeroVector)
		{
			return false;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		FVector actorLocation = firstLocalPlayerController.GetControlledPawn().GetActorLocation();
		double num = UMathLibrary.Distance2D(new FVector2D(actorLocation.X, actorLocation.Y), new FVector2D(TargetLocation.X, TargetLocation.Y));
		AutoTestLoggerLib.QALogInfo(WorldContext, "距离目的地还有" + num);
		if (num < (double)ReachRadius)
		{
			firstLocalPlayerController.StopMovement();
			return true;
		}
		return RunToImpl(WorldContext, TargetLocation);
	}

	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:RunToEnemy")]
	public static bool RunToEnemy(UObject WorldContext, BGUCharacterCS Enemy, int ReachRadius = 200)
	{
		if (Enemy == null)
		{
			return false;
		}
		FVector actorLocation = Enemy.GetActorLocation();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		BGUCharacterCS obj = firstLocalPlayerController.GetControlledPawn() as BGUCharacterCS;
		FVector actorLocation2 = obj.GetActorLocation();
		double num = UMathLibrary.Distance2D(new FVector2D(actorLocation2.X, actorLocation2.Y), new FVector2D(actorLocation.X, actorLocation.Y));
		UBGUFunctionLibraryForCS.BGUGetBounds(Enemy.Mesh, out var Origin, out var BoxExtent);
		_ = BoxExtent.X;
		_ = BoxExtent.Y;
		float z = BoxExtent.Z;
		UBGUFunctionLibraryForCS.BGUGetBounds(obj.Mesh, out var Origin2, out var BoxExtent2);
		_ = BoxExtent2.X;
		_ = BoxExtent2.Y;
		float z2 = BoxExtent2.Z;
		if (num < (double)ReachRadius && FMath.Abs((Origin2 - Origin).Z) < z + z2)
		{
			firstLocalPlayerController.StopMovement();
			return true;
		}
		return RunToImpl(WorldContext, actorLocation - new FVector(0.0, 0.0, z));
	}

	private static bool GetBestNextPoint(FVector PlayerLocation, TArrayReadOnly<FVector> Points, int BoundDistance, out FVector BestPoint)
	{
		double num = double.MaxValue;
		BestPoint = default(FVector);
		foreach (FVector Point in Points)
		{
			float num2 = FVector2D.Distance(new FVector2D(PlayerLocation), new FVector2D(Point));
			if (num2 > (float)BoundDistance && (double)num2 < num)
			{
				num = num2;
				BestPoint = Point;
			}
		}
		return num != double.MaxValue;
	}

	public static bool RunToImpl(UObject WorldContext, FVector TargetLocation)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		BGUCharacterCS bGUCharacterCS = firstLocalPlayerController.GetControlledPawn() as BGUCharacterCS;
		FVector actorLocation = bGUCharacterCS.GetActorLocation();
		if (!BGUFunctionLibraryCS.BGUCanMoveRun(bGUCharacterCS))
		{
			firstLocalPlayerController.StopMovement();
			return false;
		}
		UAIHelperLibrary.SimpleMoveToLocation(firstLocalPlayerController, TargetLocation);
		firstLocalPlayerController.GetControlledPawn().PawnMakeNoise(1f, actorLocation, bUseNoiseMakerLocation: false, bGUCharacterCS);
		UNavigationPath currentPath = UAIHelperLibrary.GetCurrentPath(firstLocalPlayerController);
		if (currentPath == null)
		{
			firstLocalPlayerController.StopMovement();
			AutoTestLoggerLib.QALogError(WorldContext, "NavigationPath == null, 寻路失败！当前点为 " + actorLocation.ToString() + " 目标点为 " + TargetLocation.ToString());
			StuckCounter++;
			if (StuckCounter > 30)
			{
				QA_Blink(WorldContext, TargetLocation, bGUCharacterCS, actorLocation);
			}
		}
		else
		{
			if (currentPath.IsPartial())
			{
				AutoTestLoggerLib.QALogWarning(WorldContext, "目标点：" + TargetLocation.ToString() + "在NavMesh上不可达。当前点：" + actorLocation.ToString());
			}
			for (int i = 0; i < currentPath.PathPoints.Count - 1; i++)
			{
				USystemLibrary.DrawDebugSphere(WorldContext, currentPath.PathPoints[i], 25f, 8, FLinearColor.Black, 1f, 10f);
				USystemLibrary.DrawDebugLine(WorldContext, currentPath.PathPoints[i], currentPath.PathPoints[i + 1], FLinearColor.Black, 1f, 10f);
			}
			USystemLibrary.DrawDebugSphere(WorldContext, currentPath.PathPoints[currentPath.PathPoints.Count - 1], 25f, 8, FLinearColor.Black, 1f, 10f);
			if (UMathLibrary.Vector_Distance(actorLocation, LastTimePlayerLocation) < 250.0)
			{
				StuckCounter++;
			}
			else
			{
				StuckCounter = 0;
			}
			LastTimePlayerLocation = actorLocation;
			if (StuckCounter > 30)
			{
				if (!QA_Can_Blink)
				{
					BIS_AutoTestManagerV2.Get(WorldContext).CaseToRun?.HaltForReason(CaseState.Failed, "主角被卡住了！当前点为：" + actorLocation.ToString() + " 目标点为：" + TargetLocation.ToString());
					firstLocalPlayerController.StopMovement();
					return false;
				}
				AutoTestLoggerLib.QALogWarning(WorldContext, "主角卡在" + actorLocation.ToString());
				if (currentPath.PathPoints.Count > 1 && GetBestNextPoint(actorLocation, currentPath.PathPoints, 250, out var BestPoint))
				{
					AutoTestLoggerLib.QALogWarning(WorldContext, "传送至下一个寻路点 " + BestPoint.ToString());
					bGUCharacterCS.SetActorLocation(BestPoint + new FVector(0.0, 0.0, 130.0), bSweep: false, out var _, bTeleport: true);
					StuckCounter = 0;
				}
				else
				{
					QA_Blink(WorldContext, TargetLocation, bGUCharacterCS, actorLocation);
				}
			}
		}
		IBPC_PlayerPerformData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerPerformData, BPC_PlayerPerformData>(firstLocalPlayerController.PlayerState);
		if (BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(firstLocalPlayerController.GetControlledPawn()).GetTargetInfo().LockTargetActor == null && !readOnlyData.IsInPerformState())
		{
			FVector velocity = bGUCharacterCS.GetVelocity();
			velocity.Normalize();
			FVector target = actorLocation + velocity * 2000.0 - new FVector(0.0, 0.0, 200.0);
			FRotator value = UMathLibrary.FindLookAtRotation(actorLocation, target);
			BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(bGUCharacterCS).ControlData.ControllerRotation.SetValue(value);
		}
		return false;
	}

	private static void QA_Blink(UObject WorldContext, FVector TargetLocation, BGUCharacterCS PlayerCharacter, FVector PlayerLocation)
	{
		if (!QA_Can_Blink)
		{
			BIS_AutoTestManagerV2.Get(WorldContext).CaseToRun?.HaltForReason(CaseState.Failed, "主角被卡住了。当前点为：" + PlayerLocation.ToString() + " 目标点为：" + TargetLocation.ToString());
			return;
		}
		UBGUEQSObject uBGUEQSObject = UObject.NewObject<UBGUEQSObject>();
		BIS_AutoTestManagerV2.Get(WorldContext).TargetLocation = TargetLocation;
		UEnvQuery envQueryObj = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UEnvQuery>("EnvQuery'/Game/3rd/QATest/AutoTest_Blink_CapsuleTrace.AutoTest_Blink_CapsuleTrace'", ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
		UEnvQuery envQueryObj2 = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UEnvQuery>("EnvQuery'/Game/3rd/QATest/AutoTest_Blink_CrossWall.AutoTest_Blink_CrossWall'", ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
		uBGUEQSObject.EQSObjRunInstant(envQueryObj, PlayerCharacter, out var Locations, out var Scores);
		uBGUEQSObject.EQSObjRunInstant(envQueryObj2, PlayerCharacter, out var Locations2, out var Scores2);
		FHitResult SweepHitResult;
		if (Scores.Count != 0 && UMathLibrary.Vector_Distance(PlayerLocation, Locations[Scores.IndexOf(Scores.Max())]) > 250.0)
		{
			int index = Scores.IndexOf(Scores.Max());
			FVector fVector = Locations[index];
			AutoTestLoggerLib.QALogInfo(WorldContext, "通过安全传送，传送到最佳可达点 " + fVector.ToString());
			PlayerCharacter.SetActorLocation(fVector + new FVector(0.0, 0.0, 130.0), bSweep: false, out SweepHitResult, bTeleport: true);
			StuckCounter = 0;
			return;
		}
		if (Scores2.Count != 0 && UMathLibrary.Vector_Distance(PlayerLocation, Locations2[Scores2.IndexOf(Scores2.Max())]) > 250.0)
		{
			int index2 = Scores2.IndexOf(Scores2.Max());
			FVector fVector = Locations2[index2];
			AutoTestLoggerLib.QALogWarning(WorldContext, "通过保底传送，传送到最佳可达点 " + fVector.ToString());
			PlayerCharacter.SetActorLocation(fVector + new FVector(0.0, 0.0, 130.0), bSweep: false, out SweepHitResult, bTeleport: true);
			StuckCounter = 0;
			return;
		}
		AutoTestLoggerLib.QALogWarning(WorldContext, "经EQS也找不到合适的传送点。当前点为：" + PlayerLocation.ToString() + " 目标点为：" + TargetLocation.ToString());
		FVector ProjectedLocation;
		bool num = UBGUFunctionLibrary.BGUProjectPointToNavigation(WorldContext, PlayerLocation, out ProjectedLocation, null, null, new FVector(0.0, 0.0, 300.0));
		if (!num)
		{
			AutoTestLoggerLib.QALogWarning(WorldContext, "人站到了一个没有Nav的地方！");
		}
		FVector ProjectedLocation2;
		bool flag = UBGUFunctionLibrary.BGUProjectPointToNavigation(WorldContext, TargetLocation, out ProjectedLocation2, null, null, new FVector(0.0, 0.0, 300.0));
		if (!flag)
		{
			AutoTestLoggerLib.QALogWarning(WorldContext, "目标点是一个没有Nav的地方！");
		}
		if (num && flag)
		{
			AutoTestLoggerLib.QALogWarning(WorldContext, "人和目标点都在Nav上，但是不连通！");
		}
		BIS_AutoTestManagerV2.Get(WorldContext).CaseToRun?.HaltForReason(CaseState.Failed, "经EQS也找不到合适的传送点。当前点为：" + PlayerLocation.ToString() + " 目标点为：" + TargetLocation.ToString());
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:AutoMoveComplete")]
	public static void AutoMoveComplete(UObject WorldContext)
	{
		List<ICSharpTestCase> testCaseList = BIS_AutoTestManagerV2.Get(WorldContext).TestCaseList;
		if (testCaseList == null)
		{
			return;
		}
		foreach (ICSharpTestCase item in testCaseList)
		{
			if (item is b1.AutoQA.CrossLevel_AutoMove crossLevel_AutoMove)
			{
				crossLevel_AutoMove?.AutoMoveComplete();
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GetUnitAllSkillID")]
	public static List<int> GetUnitAllSkillID(AActor Unit)
	{
		return BGUFuncLibAICS.BGUGetUnitAllSkillID(Unit);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GetTamerInViewCount")]
	public static void GetTamerInViewCount(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		FVector cameraLocation = firstLocalPlayerController.PlayerCameraManager.GetCameraLocation();
		FRotator cameraRotation = firstLocalPlayerController.PlayerCameraManager.GetCameraRotation();
		string text = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
		USystemLibrary.ExecuteConsoleCommand(WorldContext, "Shot ShowUI filename=" + text + "-", null);
		using StreamWriter streamWriter = new StreamWriter(BIS_AutoTestManagerV2.Get(WorldContext).LogFolderPath + "/TamerCount.txt", append: true);
		streamWriter.WriteLine(text + "\t" + b1.BGS_TamerManagerSystem.MonsterCount + "\t" + $"({cameraLocation.X.ToString()},{cameraLocation.Y.ToString()},{cameraLocation.Z.ToString()})({cameraRotation.Roll.ToString()},{cameraRotation.Pitch.ToString()},{cameraRotation.Yaw.ToString()})");
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:GetPlayerTargetActor")]
	public static BGUCharacterCS GetPlayerTargetActor(UObject WorldContext)
	{
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn();
		if (!(aPawn == null) && !aPawn.IsPendingKill)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(aPawn);
			if (readOnlyData != null)
			{
				return readOnlyData.GetTargetInfo().LockTargetActor as BGUCharacterCS;
			}
		}
		return null;
	}

	public static void QAGCTwice()
	{
		UObject.CollectGarbage();
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
		UObject.CollectGarbage();
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QAUploadPerformanceData")]
	public static void QAUploadPerformanceData(UObject WorldContext, string Catelog, string Summary, List<string> FileList)
	{
		_ = BGW_GSSdkMgr.Get(WorldContext).Logger;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = Summary.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			dictionary.Add(array2[0], array2[1]);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QAStringArraySort")]
	public static List<string> QAStringArraySort(List<string> StringList)
	{
		StringList.Sort();
		return StringList;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QADrawSkillRange")]
	public static void QADrawSkillRange(AActor Unit, int SkillID, float Duration = 0f)
	{
		Unit = Unit as ABGUCharacter;
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		float num = 22.5f;
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Unit);
		if (skillAIDesc.AngleScoreSector0To45 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSector0To45 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(0f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSector45To90 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSector45To90 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(45f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSector90To135 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSector90To135 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(90f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSector135To180 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSector135To180 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(135f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSector180ToNeg135 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSector180ToNeg135 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(180f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSectorNeg135ToNeg90 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSectorNeg135ToNeg90 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(-135f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSectorNeg90ToNeg45 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSectorNeg90ToNeg45 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(-90f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
		if (skillAIDesc.AngleScoreSectorNeg45To0 > 0)
		{
			FColor color;
			float thickness;
			if (skillAIDesc.AngleScoreSectorNeg45To0 == 1)
			{
				color = FColor.Black;
				thickness = 1f;
			}
			else
			{
				color = FColor.Azure;
				thickness = 5f;
			}
			if (readOnlyData != null && SkillID == readOnlyData.CurrentCastingSkillID)
			{
				color = FColor.Red;
				thickness = 10f;
			}
			UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(Unit.World, Unit.GetActorLocation(), Unit.GetActorForwardVector().RotateAngleAxis(-45f + num, new FVector(0.0, 0.0, 1.0)), skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax, num, color, Duration, thickness, 16);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QAPauseBT")]
	public static void QAPauseBT(AActor Unit, bool Status)
	{
		Unit = Unit as ABGUCharacter;
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_AIPauseBT.Invoke(Status);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentSkillID")]
	public static string QAGetCurrentSkillID(AActor Target)
	{
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Target);
		if (readOnlyData == null)
		{
			return "";
		}
		return readOnlyData.CurrentCastingSkillID.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentAMName")]
	public static string QAGetCurrentAMName(AActor Target)
	{
		UAnimInstance animInstance = (Target as BGUCharacterCS).Mesh.GetAnimInstance();
		if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
		{
			return animInstance.GetCurrentActiveMontage().GetName();
		}
		return "";
	}

	static AutoTestHelperLib()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AutoTestHelperLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AutoTestHelperLib));
		StuckCounter = 0;
		QA_Can_Blink = true;
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:Jump")]
	private static void Jump__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Jump_WorldContext_Offset));
		Jump(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:Spin")]
	private static void Spin__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Spin_WorldContext_Offset));
		Spin(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:Dodge")]
	private static void Dodge__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Dodge_WorldContext_Offset));
		Dodge(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:UseItem")]
	private static void UseItem__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, UseItem_WorldContext_Offset));
		int itemPosition = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, UseItem_ItemPosition_Offset));
		UseItem(worldContext, itemPosition);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:OpenBag")]
	private static void OpenBag__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OpenBag_WorldContext_Offset));
		bool isOpen = BoolMarshaler.FromNative(IntPtr.Add(buffer, OpenBag_IsOpen_Offset), 0, OpenBag_IsOpen_PropertyAddress.Address);
		OpenBag(worldContext, isOpen);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:SetMaxHp")]
	private static void SetMaxHp__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor maxHp = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetMaxHp_Unit_Offset));
		SetMaxHp(maxHp);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:FindText")]
	private static void FindText__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, FindText_WorldContext_Offset));
		string text = FStringMarshaler.FromNative(IntPtr.Add(buffer, FindText_Text_Offset));
		bool bNeedClick = BoolMarshaler.FromNative(IntPtr.Add(buffer, FindText_bNeedClick_Offset), 0, FindText_bNeedClick_PropertyAddress.Address);
		bool value = FindText(worldContext, text, bNeedClick);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FindText_ReturnValue_Offset), 0, FindText_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:TestCode")]
	private static void TestCode__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, TestCode_WorldContext_Offset));
		TestCode(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:HasSpell")]
	private static void HasSpell__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, HasSpell_WorldContext_Offset));
		int spellID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, HasSpell_SpellID_Offset));
		bool value = HasSpell(worldContext, spellID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasSpell_ReturnValue_Offset), 0, HasSpell_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:Interact")]
	private static void Interact__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Interact_WorldContext_Offset));
		bool value = Interact(worldContext);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, Interact_ReturnValue_Offset), 0, Interact_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GenActor")]
	private static void GenActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld World = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, GenActor_World_Offset));
		TSubclassOf<AActor> actorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GenActor_ActorClass_Offset));
		GenActor(ref World, actorClass);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(buffer, GenActor_World_Offset), World);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QAPauseBT")]
	private static void QAPauseBT__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, QAPauseBT_Unit_Offset));
		bool status = BoolMarshaler.FromNative(IntPtr.Add(buffer, QAPauseBT_Status_Offset), 0, QAPauseBT_Status_PropertyAddress.Address);
		QAPauseBT(unit, status);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:KillEnemy")]
	private static void KillEnemy__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, KillEnemy_WorldContext_Offset));
		AActor KillTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, KillEnemy_KillTarget_Offset));
		KillEnemy(worldContext, ref KillTarget);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, KillEnemy_KillTarget_Offset), KillTarget);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:CastSpell")]
	private static void CastSpell__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CastSpell_WorldContext_Offset));
		SpellType skillType = EnumMarshaler<SpellType>.FromNative(IntPtr.Add(buffer, CastSpell_SkillType_Offset), 0, CastSpell_SkillType_PropertyAddress.Address);
		CastSpell(worldContext, skillType);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:RunToEnemy")]
	private static void RunToEnemy__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RunToEnemy_WorldContext_Offset));
		BGUCharacterCS enemy = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, RunToEnemy_Enemy_Offset));
		int reachRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, RunToEnemy_ReachRadius_Offset));
		bool value = RunToEnemy(worldContext, enemy, reachRadius);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, RunToEnemy_ReturnValue_Offset), 0, RunToEnemy_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:MouseGoBack")]
	private static void MouseGoBack__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, MouseGoBack_WorldContext_Offset));
		MouseGoBack(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:ClickButton")]
	private static void ClickButton__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWidget btn = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, ClickButton_Btn_Offset));
		ClickButton(btn);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:HeavyAttack")]
	private static void HeavyAttack__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, HeavyAttack_WorldContext_Offset));
		HeavyAttack(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:LightAttack")]
	private static void LightAttack__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, LightAttack_WorldContext_Offset));
		LightAttack(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:SetCurrentHp")]
	private static void SetCurrentHp__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetCurrentHp_Unit_Offset));
		int hp = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetCurrentHp_Hp_Offset));
		SetCurrentHp(unit, hp);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:MagicArtifact")]
	private static void MagicArtifact__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, MagicArtifact_WorldContext_Offset));
		MagicArtifact(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:RemoveGroupAI")]
	private static void RemoveGroupAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RemoveGroupAI_WorldContext_Offset));
		AActor ownerActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RemoveGroupAI_OwnerActor_Offset));
		RemoveGroupAI(worldContext, ownerActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:ReadDataTable")]
	private static void ReadDataTable__Invoker(IntPtr buffer, IntPtr obj)
	{
		int iD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ReadDataTable_ID_Offset));
		string value = ReadDataTable(iD);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ReadDataTable_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:HasItemNumber")]
	private static void HasItemNumber__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, HasItemNumber_WorldContext_Offset));
		int itemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, HasItemNumber_ItemID_Offset));
		int value = HasItemNumber(worldContext, itemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, HasItemNumber_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:UseVigorSkill")]
	private static void UseVigorSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, UseVigorSkill_WorldContext_Offset));
		UseVigorSkill(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:RunToPosition")]
	private static void RunToPosition__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RunToPosition_WorldContext_Offset));
		FVector targetLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, RunToPosition_TargetLocation_Offset));
		int reachRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, RunToPosition_ReachRadius_Offset));
		bool value = RunToPosition(worldContext, targetLocation, reachRadius);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, RunToPosition_ReturnValue_Offset), 0, RunToPosition_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:FindNearbyUnit")]
	private static void FindNearbyUnit__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, FindNearbyUnit_WorldContext_Offset));
		int attackRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, FindNearbyUnit_AttackRadius_Offset));
		string unitBP = FStringMarshaler.FromNative(IntPtr.Add(buffer, FindNearbyUnit_UnitBP_Offset));
		BGUCharacterCS EnemyUnit;
		bool value = FindNearbyUnit(worldContext, attackRadius, out EnemyUnit, unitBP);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FindNearbyUnit_ReturnValue_Offset), 0, FindNearbyUnit_ReturnValue_PropertyAddress.Address, value);
		UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(buffer, FindNearbyUnit_EnemyUnit_Offset), EnemyUnit);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:IsUnitInBattle")]
	private static void IsUnitInBattle__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, IsUnitInBattle_Unit_Offset));
		bool value = IsUnitInBattle(unit);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsUnitInBattle_ReturnValue_Offset), 0, IsUnitInBattle_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GenShiXianFeng")]
	private static void GenShiXianFeng__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld World = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, GenShiXianFeng_World_Offset));
		GenShiXianFeng(ref World);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(buffer, GenShiXianFeng_World_Offset), World);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:SetPlayerAttack")]
	private static void SetPlayerAttack__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetPlayerAttack_Unit_Offset));
		int attackNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetPlayerAttack_AttackNum_Offset));
		SetPlayerAttack(unit, attackNum);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:CanUnitBeTarget")]
	private static void CanUnitBeTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS enemy = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, CanUnitBeTarget_Enemy_Offset));
		bool value = CanUnitBeTarget(enemy);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUnitBeTarget_ReturnValue_Offset), 0, CanUnitBeTarget_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:DrinkBloodBottom")]
	private static void DrinkBloodBottom__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, DrinkBloodBottom_WorldContext_Offset));
		DrinkBloodBottom(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QADrawSkillRange")]
	private static void QADrawSkillRange__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, QADrawSkillRange_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, QADrawSkillRange_SkillID_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, QADrawSkillRange_Duration_Offset));
		QADrawSkillRange(unit, skillID, duration);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:CameraLockTarget")]
	private static void CameraLockTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CameraLockTarget_WorldContext_Offset));
		AActor lockTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, CameraLockTarget_LockTarget_Offset));
		CameraLockTarget(worldContext, lockTarget);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:AutoMoveComplete")]
	private static void AutoMoveComplete__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, AutoMoveComplete_WorldContext_Offset));
		AutoMoveComplete(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:IsEquippingSpell")]
	private static void IsEquippingSpell__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, IsEquippingSpell_WorldContext_Offset));
		int spellID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, IsEquippingSpell_SpellID_Offset));
		bool value = IsEquippingSpell(worldContext, spellID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsEquippingSpell_ReturnValue_Offset), 0, IsEquippingSpell_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QAStringArraySort")]
	private static void QAStringArraySort__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, QAStringArraySort_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> stringList = new TArrayCopyMarshaler<string>(1, QAStringArraySort_StringList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, QAStringArraySort_StringList_Offset));
		List<string> value = QAStringArraySort(stringList);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, QAStringArraySort_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GetUnitAllSkillID")]
	private static void GetUnitAllSkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, GetUnitAllSkillID_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetUnitAllSkillID_Unit_Offset));
		List<int> unitAllSkillID = GetUnitAllSkillID(unit);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetUnitAllSkillID_ReturnValue_Offset), unitAllSkillID);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentAMName")]
	private static void QAGetCurrentAMName__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, QAGetCurrentAMName_Target_Offset));
		string value = QAGetCurrentAMName(target);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QAGetCurrentAMName_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:JudgeWidgetVisible")]
	private static void JudgeWidgetVisible__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWidget widget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, JudgeWidgetVisible_Widget_Offset));
		bool value = JudgeWidgetVisible(widget);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, JudgeWidgetVisible_ReturnValue_Offset), 0, JudgeWidgetVisible_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentSkillID")]
	private static void QAGetCurrentSkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, QAGetCurrentSkillID_Target_Offset));
		string value = QAGetCurrentSkillID(target);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QAGetCurrentSkillID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GetTamerInViewCount")]
	private static void GetTamerInViewCount__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GetTamerInViewCount_WorldContext_Offset));
		GetTamerInViewCount(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GetPlayerTargetActor")]
	private static void GetPlayerTargetActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GetPlayerTargetActor_WorldContext_Offset));
		BGUCharacterCS playerTargetActor = GetPlayerTargetActor(worldContext);
		UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(buffer, GetPlayerTargetActor_ReturnValue_Offset), playerTargetActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:IsPlayingCameraMovie")]
	private static void IsPlayingCameraMovie__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, IsPlayingCameraMovie_WorldContext_Offset));
		bool value = IsPlayingCameraMovie(worldContext);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsPlayingCameraMovie_ReturnValue_Offset), 0, IsPlayingCameraMovie_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GetPlayingSequenceID")]
	private static void GetPlayingSequenceID__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GetPlayingSequenceID_WorldContext_Offset));
		int SequenceID;
		bool playingSequenceID = GetPlayingSequenceID(worldContext, out SequenceID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetPlayingSequenceID_ReturnValue_Offset), 0, GetPlayingSequenceID_ReturnValue_PropertyAddress.Address, playingSequenceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetPlayingSequenceID_SequenceID_Offset), SequenceID);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:GetActorLocationByName")]
	private static void GetActorLocationByName__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GetActorLocationByName_WorldContext_Offset));
		string actorName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetActorLocationByName_ActorName_Offset));
		FVector ActorLocation;
		bool actorLocationByName = GetActorLocationByName(worldContext, actorName, out ActorLocation);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorLocationByName_ReturnValue_Offset), 0, GetActorLocationByName_ReturnValue_PropertyAddress.Address, actorLocationByName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, GetActorLocationByName_ActorLocation_Offset), ActorLocation);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:QAUploadPerformanceData")]
	private static void QAUploadPerformanceData__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, QAUploadPerformanceData_WorldContext_Offset));
		string catelog = FStringMarshaler.FromNative(IntPtr.Add(buffer, QAUploadPerformanceData_Catelog_Offset));
		string summary = FStringMarshaler.FromNative(IntPtr.Add(buffer, QAUploadPerformanceData_Summary_Offset));
		List<string> fileList = new TArrayCopyMarshaler<string>(1, QAUploadPerformanceData_FileList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, QAUploadPerformanceData_FileList_Offset));
		QAUploadPerformanceData(worldContext, catelog, summary, fileList);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:RebirthPointChoiceClick")]
	private static void RebirthPointChoiceClick__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RebirthPointChoiceClick_WorldContext_Offset));
		string choice = FStringMarshaler.FromNative(IntPtr.Add(buffer, RebirthPointChoiceClick_Choice_Offset));
		bool value = RebirthPointChoiceClick(worldContext, choice);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, RebirthPointChoiceClick_ReturnValue_Offset), 0, RebirthPointChoiceClick_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTestHelperLib:AutoTestInjectInputEvent")]
	private static void AutoTestInjectInputEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, AutoTestInjectInputEvent_WorldContext_Offset));
		string actionName = FStringMarshaler.FromNative(IntPtr.Add(buffer, AutoTestInjectInputEvent_ActionName_Offset));
		ETriggerEvent triggerEvent = EnumMarshaler<ETriggerEvent>.FromNative(IntPtr.Add(buffer, AutoTestInjectInputEvent_TriggerEvent_Offset), 0, AutoTestInjectInputEvent_TriggerEvent_PropertyAddress.Address);
		AutoTestInjectInputEvent(worldContext, actionName, triggerEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.AutoTestHelperLib");
		Jump_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Jump");
		Jump_ParamsSize = NativeReflection.GetFunctionParamsSize(Jump_FunctionAddress);
		Jump_WorldContext_Offset = NativeReflection.GetPropertyOffset(Jump_FunctionAddress, "WorldContext");
		Jump_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(Jump_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		Jump_IsValid = Jump_FunctionAddress != IntPtr.Zero && Jump_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:Jump", Jump_IsValid);
		Spin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Spin");
		Spin_ParamsSize = NativeReflection.GetFunctionParamsSize(Spin_FunctionAddress);
		Spin_WorldContext_Offset = NativeReflection.GetPropertyOffset(Spin_FunctionAddress, "WorldContext");
		Spin_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(Spin_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		Spin_IsValid = Spin_FunctionAddress != IntPtr.Zero && Spin_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:Spin", Spin_IsValid);
		Dodge_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Dodge");
		Dodge_ParamsSize = NativeReflection.GetFunctionParamsSize(Dodge_FunctionAddress);
		Dodge_WorldContext_Offset = NativeReflection.GetPropertyOffset(Dodge_FunctionAddress, "WorldContext");
		Dodge_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(Dodge_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		Dodge_IsValid = Dodge_FunctionAddress != IntPtr.Zero && Dodge_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:Dodge", Dodge_IsValid);
		UseItem_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UseItem");
		UseItem_ParamsSize = NativeReflection.GetFunctionParamsSize(UseItem_FunctionAddress);
		UseItem_WorldContext_Offset = NativeReflection.GetPropertyOffset(UseItem_FunctionAddress, "WorldContext");
		UseItem_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(UseItem_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		UseItem_ItemPosition_Offset = NativeReflection.GetPropertyOffset(UseItem_FunctionAddress, "ItemPosition");
		UseItem_ItemPosition_IsValid = NativeReflection.ValidatePropertyClass(UseItem_FunctionAddress, "ItemPosition", Classes.FIntProperty);
		UseItem_IsValid = UseItem_FunctionAddress != IntPtr.Zero && UseItem_WorldContext_IsValid && UseItem_ItemPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:UseItem", UseItem_IsValid);
		OpenBag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OpenBag");
		OpenBag_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenBag_FunctionAddress);
		OpenBag_WorldContext_Offset = NativeReflection.GetPropertyOffset(OpenBag_FunctionAddress, "WorldContext");
		OpenBag_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(OpenBag_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OpenBag_IsOpen_PropertyAddress, OpenBag_FunctionAddress, "IsOpen");
		OpenBag_IsOpen_Offset = NativeReflection.GetPropertyOffset(OpenBag_FunctionAddress, "IsOpen");
		OpenBag_IsOpen_IsValid = NativeReflection.ValidatePropertyClass(OpenBag_FunctionAddress, "IsOpen", Classes.FBoolProperty);
		OpenBag_IsValid = OpenBag_FunctionAddress != IntPtr.Zero && OpenBag_WorldContext_IsValid && OpenBag_IsOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:OpenBag", OpenBag_IsValid);
		SetMaxHp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaxHp");
		SetMaxHp_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxHp_FunctionAddress);
		SetMaxHp_Unit_Offset = NativeReflection.GetPropertyOffset(SetMaxHp_FunctionAddress, "Unit");
		SetMaxHp_Unit_IsValid = NativeReflection.ValidatePropertyClass(SetMaxHp_FunctionAddress, "Unit", Classes.FObjectProperty);
		SetMaxHp_IsValid = SetMaxHp_FunctionAddress != IntPtr.Zero && SetMaxHp_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:SetMaxHp", SetMaxHp_IsValid);
		FindText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindText");
		FindText_ParamsSize = NativeReflection.GetFunctionParamsSize(FindText_FunctionAddress);
		FindText_WorldContext_Offset = NativeReflection.GetPropertyOffset(FindText_FunctionAddress, "WorldContext");
		FindText_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(FindText_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FindText_Text_PropertyAddress, FindText_FunctionAddress, "Text");
		FindText_Text_Offset = NativeReflection.GetPropertyOffset(FindText_FunctionAddress, "Text");
		FindText_Text_IsValid = NativeReflection.ValidatePropertyClass(FindText_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref FindText_bNeedClick_PropertyAddress, FindText_FunctionAddress, "bNeedClick");
		FindText_bNeedClick_Offset = NativeReflection.GetPropertyOffset(FindText_FunctionAddress, "bNeedClick");
		FindText_bNeedClick_IsValid = NativeReflection.ValidatePropertyClass(FindText_FunctionAddress, "bNeedClick", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FindText_ReturnValue_PropertyAddress, FindText_FunctionAddress, "ReturnValue");
		FindText_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindText_FunctionAddress, "ReturnValue");
		FindText_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindText_IsValid = FindText_FunctionAddress != IntPtr.Zero && FindText_WorldContext_IsValid && FindText_Text_IsValid && FindText_bNeedClick_IsValid && FindText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:FindText", FindText_IsValid);
		TestCode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestCode");
		TestCode_ParamsSize = NativeReflection.GetFunctionParamsSize(TestCode_FunctionAddress);
		TestCode_WorldContext_Offset = NativeReflection.GetPropertyOffset(TestCode_FunctionAddress, "WorldContext");
		TestCode_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(TestCode_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		TestCode_IsValid = TestCode_FunctionAddress != IntPtr.Zero && TestCode_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:TestCode", TestCode_IsValid);
		HasSpell_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasSpell");
		HasSpell_ParamsSize = NativeReflection.GetFunctionParamsSize(HasSpell_FunctionAddress);
		HasSpell_WorldContext_Offset = NativeReflection.GetPropertyOffset(HasSpell_FunctionAddress, "WorldContext");
		HasSpell_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(HasSpell_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		HasSpell_SpellID_Offset = NativeReflection.GetPropertyOffset(HasSpell_FunctionAddress, "SpellID");
		HasSpell_SpellID_IsValid = NativeReflection.ValidatePropertyClass(HasSpell_FunctionAddress, "SpellID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref HasSpell_ReturnValue_PropertyAddress, HasSpell_FunctionAddress, "ReturnValue");
		HasSpell_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasSpell_FunctionAddress, "ReturnValue");
		HasSpell_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasSpell_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasSpell_IsValid = HasSpell_FunctionAddress != IntPtr.Zero && HasSpell_WorldContext_IsValid && HasSpell_SpellID_IsValid && HasSpell_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:HasSpell", HasSpell_IsValid);
		Interact_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Interact");
		Interact_ParamsSize = NativeReflection.GetFunctionParamsSize(Interact_FunctionAddress);
		Interact_WorldContext_Offset = NativeReflection.GetPropertyOffset(Interact_FunctionAddress, "WorldContext");
		Interact_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(Interact_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Interact_ReturnValue_PropertyAddress, Interact_FunctionAddress, "ReturnValue");
		Interact_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Interact_FunctionAddress, "ReturnValue");
		Interact_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Interact_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Interact_IsValid = Interact_FunctionAddress != IntPtr.Zero && Interact_WorldContext_IsValid && Interact_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:Interact", Interact_IsValid);
		GenActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenActor");
		GenActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GenActor_FunctionAddress);
		GenActor_World_Offset = NativeReflection.GetPropertyOffset(GenActor_FunctionAddress, "World");
		GenActor_World_IsValid = NativeReflection.ValidatePropertyClass(GenActor_FunctionAddress, "World", Classes.FObjectProperty);
		GenActor_ActorClass_Offset = NativeReflection.GetPropertyOffset(GenActor_FunctionAddress, "ActorClass");
		GenActor_ActorClass_IsValid = NativeReflection.ValidatePropertyClass(GenActor_FunctionAddress, "ActorClass", Classes.FClassProperty);
		GenActor_IsValid = GenActor_FunctionAddress != IntPtr.Zero && GenActor_World_IsValid && GenActor_ActorClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GenActor", GenActor_IsValid);
		QAPauseBT_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAPauseBT");
		QAPauseBT_ParamsSize = NativeReflection.GetFunctionParamsSize(QAPauseBT_FunctionAddress);
		QAPauseBT_Unit_Offset = NativeReflection.GetPropertyOffset(QAPauseBT_FunctionAddress, "Unit");
		QAPauseBT_Unit_IsValid = NativeReflection.ValidatePropertyClass(QAPauseBT_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QAPauseBT_Status_PropertyAddress, QAPauseBT_FunctionAddress, "Status");
		QAPauseBT_Status_Offset = NativeReflection.GetPropertyOffset(QAPauseBT_FunctionAddress, "Status");
		QAPauseBT_Status_IsValid = NativeReflection.ValidatePropertyClass(QAPauseBT_FunctionAddress, "Status", Classes.FBoolProperty);
		QAPauseBT_IsValid = QAPauseBT_FunctionAddress != IntPtr.Zero && QAPauseBT_Unit_IsValid && QAPauseBT_Status_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QAPauseBT", QAPauseBT_IsValid);
		KillEnemy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "KillEnemy");
		KillEnemy_ParamsSize = NativeReflection.GetFunctionParamsSize(KillEnemy_FunctionAddress);
		KillEnemy_WorldContext_Offset = NativeReflection.GetPropertyOffset(KillEnemy_FunctionAddress, "WorldContext");
		KillEnemy_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(KillEnemy_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		KillEnemy_KillTarget_Offset = NativeReflection.GetPropertyOffset(KillEnemy_FunctionAddress, "KillTarget");
		KillEnemy_KillTarget_IsValid = NativeReflection.ValidatePropertyClass(KillEnemy_FunctionAddress, "KillTarget", Classes.FObjectProperty);
		KillEnemy_IsValid = KillEnemy_FunctionAddress != IntPtr.Zero && KillEnemy_WorldContext_IsValid && KillEnemy_KillTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:KillEnemy", KillEnemy_IsValid);
		CastSpell_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CastSpell");
		CastSpell_ParamsSize = NativeReflection.GetFunctionParamsSize(CastSpell_FunctionAddress);
		CastSpell_WorldContext_Offset = NativeReflection.GetPropertyOffset(CastSpell_FunctionAddress, "WorldContext");
		CastSpell_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CastSpell_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CastSpell_SkillType_PropertyAddress, CastSpell_FunctionAddress, "SkillType");
		CastSpell_SkillType_Offset = NativeReflection.GetPropertyOffset(CastSpell_FunctionAddress, "SkillType");
		CastSpell_SkillType_IsValid = NativeReflection.ValidatePropertyClass(CastSpell_FunctionAddress, "SkillType", Classes.FEnumProperty);
		CastSpell_IsValid = CastSpell_FunctionAddress != IntPtr.Zero && CastSpell_WorldContext_IsValid && CastSpell_SkillType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:CastSpell", CastSpell_IsValid);
		RunToEnemy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunToEnemy");
		RunToEnemy_ParamsSize = NativeReflection.GetFunctionParamsSize(RunToEnemy_FunctionAddress);
		RunToEnemy_WorldContext_Offset = NativeReflection.GetPropertyOffset(RunToEnemy_FunctionAddress, "WorldContext");
		RunToEnemy_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RunToEnemy_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RunToEnemy_Enemy_Offset = NativeReflection.GetPropertyOffset(RunToEnemy_FunctionAddress, "Enemy");
		RunToEnemy_Enemy_IsValid = NativeReflection.ValidatePropertyClass(RunToEnemy_FunctionAddress, "Enemy", Classes.FObjectProperty);
		RunToEnemy_ReachRadius_Offset = NativeReflection.GetPropertyOffset(RunToEnemy_FunctionAddress, "ReachRadius");
		RunToEnemy_ReachRadius_IsValid = NativeReflection.ValidatePropertyClass(RunToEnemy_FunctionAddress, "ReachRadius", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref RunToEnemy_ReturnValue_PropertyAddress, RunToEnemy_FunctionAddress, "ReturnValue");
		RunToEnemy_ReturnValue_Offset = NativeReflection.GetPropertyOffset(RunToEnemy_FunctionAddress, "ReturnValue");
		RunToEnemy_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(RunToEnemy_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunToEnemy_IsValid = RunToEnemy_FunctionAddress != IntPtr.Zero && RunToEnemy_WorldContext_IsValid && RunToEnemy_Enemy_IsValid && RunToEnemy_ReachRadius_IsValid && RunToEnemy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:RunToEnemy", RunToEnemy_IsValid);
		MouseGoBack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MouseGoBack");
		MouseGoBack_ParamsSize = NativeReflection.GetFunctionParamsSize(MouseGoBack_FunctionAddress);
		MouseGoBack_WorldContext_Offset = NativeReflection.GetPropertyOffset(MouseGoBack_FunctionAddress, "WorldContext");
		MouseGoBack_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(MouseGoBack_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		MouseGoBack_IsValid = MouseGoBack_FunctionAddress != IntPtr.Zero && MouseGoBack_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:MouseGoBack", MouseGoBack_IsValid);
		ClickButton_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClickButton");
		ClickButton_ParamsSize = NativeReflection.GetFunctionParamsSize(ClickButton_FunctionAddress);
		ClickButton_Btn_Offset = NativeReflection.GetPropertyOffset(ClickButton_FunctionAddress, "Btn");
		ClickButton_Btn_IsValid = NativeReflection.ValidatePropertyClass(ClickButton_FunctionAddress, "Btn", Classes.FObjectProperty);
		ClickButton_IsValid = ClickButton_FunctionAddress != IntPtr.Zero && ClickButton_Btn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:ClickButton", ClickButton_IsValid);
		HeavyAttack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HeavyAttack");
		HeavyAttack_ParamsSize = NativeReflection.GetFunctionParamsSize(HeavyAttack_FunctionAddress);
		HeavyAttack_WorldContext_Offset = NativeReflection.GetPropertyOffset(HeavyAttack_FunctionAddress, "WorldContext");
		HeavyAttack_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(HeavyAttack_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		HeavyAttack_IsValid = HeavyAttack_FunctionAddress != IntPtr.Zero && HeavyAttack_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:HeavyAttack", HeavyAttack_IsValid);
		LightAttack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LightAttack");
		LightAttack_ParamsSize = NativeReflection.GetFunctionParamsSize(LightAttack_FunctionAddress);
		LightAttack_WorldContext_Offset = NativeReflection.GetPropertyOffset(LightAttack_FunctionAddress, "WorldContext");
		LightAttack_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(LightAttack_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		LightAttack_IsValid = LightAttack_FunctionAddress != IntPtr.Zero && LightAttack_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:LightAttack", LightAttack_IsValid);
		SetCurrentHp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurrentHp");
		SetCurrentHp_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentHp_FunctionAddress);
		SetCurrentHp_Unit_Offset = NativeReflection.GetPropertyOffset(SetCurrentHp_FunctionAddress, "Unit");
		SetCurrentHp_Unit_IsValid = NativeReflection.ValidatePropertyClass(SetCurrentHp_FunctionAddress, "Unit", Classes.FObjectProperty);
		SetCurrentHp_Hp_Offset = NativeReflection.GetPropertyOffset(SetCurrentHp_FunctionAddress, "Hp");
		SetCurrentHp_Hp_IsValid = NativeReflection.ValidatePropertyClass(SetCurrentHp_FunctionAddress, "Hp", Classes.FIntProperty);
		SetCurrentHp_IsValid = SetCurrentHp_FunctionAddress != IntPtr.Zero && SetCurrentHp_Unit_IsValid && SetCurrentHp_Hp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:SetCurrentHp", SetCurrentHp_IsValid);
		MagicArtifact_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MagicArtifact");
		MagicArtifact_ParamsSize = NativeReflection.GetFunctionParamsSize(MagicArtifact_FunctionAddress);
		MagicArtifact_WorldContext_Offset = NativeReflection.GetPropertyOffset(MagicArtifact_FunctionAddress, "WorldContext");
		MagicArtifact_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(MagicArtifact_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		MagicArtifact_IsValid = MagicArtifact_FunctionAddress != IntPtr.Zero && MagicArtifact_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:MagicArtifact", MagicArtifact_IsValid);
		RemoveGroupAI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveGroupAI");
		RemoveGroupAI_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGroupAI_FunctionAddress);
		RemoveGroupAI_WorldContext_Offset = NativeReflection.GetPropertyOffset(RemoveGroupAI_FunctionAddress, "WorldContext");
		RemoveGroupAI_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RemoveGroupAI_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RemoveGroupAI_OwnerActor_Offset = NativeReflection.GetPropertyOffset(RemoveGroupAI_FunctionAddress, "OwnerActor");
		RemoveGroupAI_OwnerActor_IsValid = NativeReflection.ValidatePropertyClass(RemoveGroupAI_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		RemoveGroupAI_IsValid = RemoveGroupAI_FunctionAddress != IntPtr.Zero && RemoveGroupAI_WorldContext_IsValid && RemoveGroupAI_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:RemoveGroupAI", RemoveGroupAI_IsValid);
		ReadDataTable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadDataTable");
		ReadDataTable_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadDataTable_FunctionAddress);
		ReadDataTable_ID_Offset = NativeReflection.GetPropertyOffset(ReadDataTable_FunctionAddress, "ID");
		ReadDataTable_ID_IsValid = NativeReflection.ValidatePropertyClass(ReadDataTable_FunctionAddress, "ID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ReadDataTable_ReturnValue_PropertyAddress, ReadDataTable_FunctionAddress, "ReturnValue");
		ReadDataTable_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ReadDataTable_FunctionAddress, "ReturnValue");
		ReadDataTable_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ReadDataTable_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ReadDataTable_IsValid = ReadDataTable_FunctionAddress != IntPtr.Zero && ReadDataTable_ID_IsValid && ReadDataTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:ReadDataTable", ReadDataTable_IsValid);
		HasItemNumber_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasItemNumber");
		HasItemNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(HasItemNumber_FunctionAddress);
		HasItemNumber_WorldContext_Offset = NativeReflection.GetPropertyOffset(HasItemNumber_FunctionAddress, "WorldContext");
		HasItemNumber_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(HasItemNumber_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		HasItemNumber_ItemID_Offset = NativeReflection.GetPropertyOffset(HasItemNumber_FunctionAddress, "ItemID");
		HasItemNumber_ItemID_IsValid = NativeReflection.ValidatePropertyClass(HasItemNumber_FunctionAddress, "ItemID", Classes.FIntProperty);
		HasItemNumber_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasItemNumber_FunctionAddress, "ReturnValue");
		HasItemNumber_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasItemNumber_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		HasItemNumber_IsValid = HasItemNumber_FunctionAddress != IntPtr.Zero && HasItemNumber_WorldContext_IsValid && HasItemNumber_ItemID_IsValid && HasItemNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:HasItemNumber", HasItemNumber_IsValid);
		UseVigorSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UseVigorSkill");
		UseVigorSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(UseVigorSkill_FunctionAddress);
		UseVigorSkill_WorldContext_Offset = NativeReflection.GetPropertyOffset(UseVigorSkill_FunctionAddress, "WorldContext");
		UseVigorSkill_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(UseVigorSkill_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		UseVigorSkill_IsValid = UseVigorSkill_FunctionAddress != IntPtr.Zero && UseVigorSkill_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:UseVigorSkill", UseVigorSkill_IsValid);
		RunToPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunToPosition");
		RunToPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(RunToPosition_FunctionAddress);
		RunToPosition_WorldContext_Offset = NativeReflection.GetPropertyOffset(RunToPosition_FunctionAddress, "WorldContext");
		RunToPosition_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RunToPosition_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref RunToPosition_TargetLocation_PropertyAddress, RunToPosition_FunctionAddress, "TargetLocation");
		RunToPosition_TargetLocation_Offset = NativeReflection.GetPropertyOffset(RunToPosition_FunctionAddress, "TargetLocation");
		RunToPosition_TargetLocation_IsValid = NativeReflection.ValidatePropertyClass(RunToPosition_FunctionAddress, "TargetLocation", Classes.FStructProperty);
		RunToPosition_ReachRadius_Offset = NativeReflection.GetPropertyOffset(RunToPosition_FunctionAddress, "ReachRadius");
		RunToPosition_ReachRadius_IsValid = NativeReflection.ValidatePropertyClass(RunToPosition_FunctionAddress, "ReachRadius", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref RunToPosition_ReturnValue_PropertyAddress, RunToPosition_FunctionAddress, "ReturnValue");
		RunToPosition_ReturnValue_Offset = NativeReflection.GetPropertyOffset(RunToPosition_FunctionAddress, "ReturnValue");
		RunToPosition_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(RunToPosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunToPosition_IsValid = RunToPosition_FunctionAddress != IntPtr.Zero && RunToPosition_WorldContext_IsValid && RunToPosition_TargetLocation_IsValid && RunToPosition_ReachRadius_IsValid && RunToPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:RunToPosition", RunToPosition_IsValid);
		FindNearbyUnit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindNearbyUnit");
		FindNearbyUnit_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNearbyUnit_FunctionAddress);
		FindNearbyUnit_WorldContext_Offset = NativeReflection.GetPropertyOffset(FindNearbyUnit_FunctionAddress, "WorldContext");
		FindNearbyUnit_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(FindNearbyUnit_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		FindNearbyUnit_AttackRadius_Offset = NativeReflection.GetPropertyOffset(FindNearbyUnit_FunctionAddress, "AttackRadius");
		FindNearbyUnit_AttackRadius_IsValid = NativeReflection.ValidatePropertyClass(FindNearbyUnit_FunctionAddress, "AttackRadius", Classes.FIntProperty);
		FindNearbyUnit_EnemyUnit_Offset = NativeReflection.GetPropertyOffset(FindNearbyUnit_FunctionAddress, "EnemyUnit");
		FindNearbyUnit_EnemyUnit_IsValid = NativeReflection.ValidatePropertyClass(FindNearbyUnit_FunctionAddress, "EnemyUnit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FindNearbyUnit_UnitBP_PropertyAddress, FindNearbyUnit_FunctionAddress, "UnitBP");
		FindNearbyUnit_UnitBP_Offset = NativeReflection.GetPropertyOffset(FindNearbyUnit_FunctionAddress, "UnitBP");
		FindNearbyUnit_UnitBP_IsValid = NativeReflection.ValidatePropertyClass(FindNearbyUnit_FunctionAddress, "UnitBP", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref FindNearbyUnit_ReturnValue_PropertyAddress, FindNearbyUnit_FunctionAddress, "ReturnValue");
		FindNearbyUnit_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindNearbyUnit_FunctionAddress, "ReturnValue");
		FindNearbyUnit_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindNearbyUnit_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindNearbyUnit_IsValid = FindNearbyUnit_FunctionAddress != IntPtr.Zero && FindNearbyUnit_WorldContext_IsValid && FindNearbyUnit_AttackRadius_IsValid && FindNearbyUnit_EnemyUnit_IsValid && FindNearbyUnit_UnitBP_IsValid && FindNearbyUnit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:FindNearbyUnit", FindNearbyUnit_IsValid);
		IsUnitInBattle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsUnitInBattle");
		IsUnitInBattle_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUnitInBattle_FunctionAddress);
		IsUnitInBattle_Unit_Offset = NativeReflection.GetPropertyOffset(IsUnitInBattle_FunctionAddress, "Unit");
		IsUnitInBattle_Unit_IsValid = NativeReflection.ValidatePropertyClass(IsUnitInBattle_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsUnitInBattle_ReturnValue_PropertyAddress, IsUnitInBattle_FunctionAddress, "ReturnValue");
		IsUnitInBattle_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsUnitInBattle_FunctionAddress, "ReturnValue");
		IsUnitInBattle_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsUnitInBattle_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUnitInBattle_IsValid = IsUnitInBattle_FunctionAddress != IntPtr.Zero && IsUnitInBattle_Unit_IsValid && IsUnitInBattle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:IsUnitInBattle", IsUnitInBattle_IsValid);
		GenShiXianFeng_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenShiXianFeng");
		GenShiXianFeng_ParamsSize = NativeReflection.GetFunctionParamsSize(GenShiXianFeng_FunctionAddress);
		GenShiXianFeng_World_Offset = NativeReflection.GetPropertyOffset(GenShiXianFeng_FunctionAddress, "World");
		GenShiXianFeng_World_IsValid = NativeReflection.ValidatePropertyClass(GenShiXianFeng_FunctionAddress, "World", Classes.FObjectProperty);
		GenShiXianFeng_IsValid = GenShiXianFeng_FunctionAddress != IntPtr.Zero && GenShiXianFeng_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GenShiXianFeng", GenShiXianFeng_IsValid);
		SetPlayerAttack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlayerAttack");
		SetPlayerAttack_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayerAttack_FunctionAddress);
		SetPlayerAttack_Unit_Offset = NativeReflection.GetPropertyOffset(SetPlayerAttack_FunctionAddress, "Unit");
		SetPlayerAttack_Unit_IsValid = NativeReflection.ValidatePropertyClass(SetPlayerAttack_FunctionAddress, "Unit", Classes.FObjectProperty);
		SetPlayerAttack_AttackNum_Offset = NativeReflection.GetPropertyOffset(SetPlayerAttack_FunctionAddress, "AttackNum");
		SetPlayerAttack_AttackNum_IsValid = NativeReflection.ValidatePropertyClass(SetPlayerAttack_FunctionAddress, "AttackNum", Classes.FIntProperty);
		SetPlayerAttack_IsValid = SetPlayerAttack_FunctionAddress != IntPtr.Zero && SetPlayerAttack_Unit_IsValid && SetPlayerAttack_AttackNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:SetPlayerAttack", SetPlayerAttack_IsValid);
		CanUnitBeTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUnitBeTarget");
		CanUnitBeTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUnitBeTarget_FunctionAddress);
		CanUnitBeTarget_Enemy_Offset = NativeReflection.GetPropertyOffset(CanUnitBeTarget_FunctionAddress, "Enemy");
		CanUnitBeTarget_Enemy_IsValid = NativeReflection.ValidatePropertyClass(CanUnitBeTarget_FunctionAddress, "Enemy", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CanUnitBeTarget_ReturnValue_PropertyAddress, CanUnitBeTarget_FunctionAddress, "ReturnValue");
		CanUnitBeTarget_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUnitBeTarget_FunctionAddress, "ReturnValue");
		CanUnitBeTarget_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUnitBeTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUnitBeTarget_IsValid = CanUnitBeTarget_FunctionAddress != IntPtr.Zero && CanUnitBeTarget_Enemy_IsValid && CanUnitBeTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:CanUnitBeTarget", CanUnitBeTarget_IsValid);
		DrinkBloodBottom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DrinkBloodBottom");
		DrinkBloodBottom_ParamsSize = NativeReflection.GetFunctionParamsSize(DrinkBloodBottom_FunctionAddress);
		DrinkBloodBottom_WorldContext_Offset = NativeReflection.GetPropertyOffset(DrinkBloodBottom_FunctionAddress, "WorldContext");
		DrinkBloodBottom_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(DrinkBloodBottom_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		DrinkBloodBottom_IsValid = DrinkBloodBottom_FunctionAddress != IntPtr.Zero && DrinkBloodBottom_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:DrinkBloodBottom", DrinkBloodBottom_IsValid);
		QADrawSkillRange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADrawSkillRange");
		QADrawSkillRange_ParamsSize = NativeReflection.GetFunctionParamsSize(QADrawSkillRange_FunctionAddress);
		QADrawSkillRange_Unit_Offset = NativeReflection.GetPropertyOffset(QADrawSkillRange_FunctionAddress, "Unit");
		QADrawSkillRange_Unit_IsValid = NativeReflection.ValidatePropertyClass(QADrawSkillRange_FunctionAddress, "Unit", Classes.FObjectProperty);
		QADrawSkillRange_SkillID_Offset = NativeReflection.GetPropertyOffset(QADrawSkillRange_FunctionAddress, "SkillID");
		QADrawSkillRange_SkillID_IsValid = NativeReflection.ValidatePropertyClass(QADrawSkillRange_FunctionAddress, "SkillID", Classes.FIntProperty);
		QADrawSkillRange_Duration_Offset = NativeReflection.GetPropertyOffset(QADrawSkillRange_FunctionAddress, "Duration");
		QADrawSkillRange_Duration_IsValid = NativeReflection.ValidatePropertyClass(QADrawSkillRange_FunctionAddress, "Duration", Classes.FFloatProperty);
		QADrawSkillRange_IsValid = QADrawSkillRange_FunctionAddress != IntPtr.Zero && QADrawSkillRange_Unit_IsValid && QADrawSkillRange_SkillID_IsValid && QADrawSkillRange_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QADrawSkillRange", QADrawSkillRange_IsValid);
		CameraLockTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraLockTarget");
		CameraLockTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraLockTarget_FunctionAddress);
		CameraLockTarget_WorldContext_Offset = NativeReflection.GetPropertyOffset(CameraLockTarget_FunctionAddress, "WorldContext");
		CameraLockTarget_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CameraLockTarget_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		CameraLockTarget_LockTarget_Offset = NativeReflection.GetPropertyOffset(CameraLockTarget_FunctionAddress, "LockTarget");
		CameraLockTarget_LockTarget_IsValid = NativeReflection.ValidatePropertyClass(CameraLockTarget_FunctionAddress, "LockTarget", Classes.FObjectProperty);
		CameraLockTarget_IsValid = CameraLockTarget_FunctionAddress != IntPtr.Zero && CameraLockTarget_WorldContext_IsValid && CameraLockTarget_LockTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:CameraLockTarget", CameraLockTarget_IsValid);
		AutoMoveComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AutoMoveComplete");
		AutoMoveComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoMoveComplete_FunctionAddress);
		AutoMoveComplete_WorldContext_Offset = NativeReflection.GetPropertyOffset(AutoMoveComplete_FunctionAddress, "WorldContext");
		AutoMoveComplete_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(AutoMoveComplete_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		AutoMoveComplete_IsValid = AutoMoveComplete_FunctionAddress != IntPtr.Zero && AutoMoveComplete_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:AutoMoveComplete", AutoMoveComplete_IsValid);
		IsEquippingSpell_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEquippingSpell");
		IsEquippingSpell_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEquippingSpell_FunctionAddress);
		IsEquippingSpell_WorldContext_Offset = NativeReflection.GetPropertyOffset(IsEquippingSpell_FunctionAddress, "WorldContext");
		IsEquippingSpell_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(IsEquippingSpell_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		IsEquippingSpell_SpellID_Offset = NativeReflection.GetPropertyOffset(IsEquippingSpell_FunctionAddress, "SpellID");
		IsEquippingSpell_SpellID_IsValid = NativeReflection.ValidatePropertyClass(IsEquippingSpell_FunctionAddress, "SpellID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsEquippingSpell_ReturnValue_PropertyAddress, IsEquippingSpell_FunctionAddress, "ReturnValue");
		IsEquippingSpell_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsEquippingSpell_FunctionAddress, "ReturnValue");
		IsEquippingSpell_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsEquippingSpell_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEquippingSpell_IsValid = IsEquippingSpell_FunctionAddress != IntPtr.Zero && IsEquippingSpell_WorldContext_IsValid && IsEquippingSpell_SpellID_IsValid && IsEquippingSpell_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:IsEquippingSpell", IsEquippingSpell_IsValid);
		QAStringArraySort_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAStringArraySort");
		QAStringArraySort_ParamsSize = NativeReflection.GetFunctionParamsSize(QAStringArraySort_FunctionAddress);
		NativeReflection.GetPropertyRef(ref QAStringArraySort_StringList_PropertyAddress, QAStringArraySort_FunctionAddress, "StringList");
		QAStringArraySort_StringList_Offset = NativeReflection.GetPropertyOffset(QAStringArraySort_FunctionAddress, "StringList");
		QAStringArraySort_StringList_IsValid = NativeReflection.ValidatePropertyClass(QAStringArraySort_FunctionAddress, "StringList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref QAStringArraySort_ReturnValue_PropertyAddress, QAStringArraySort_FunctionAddress, "ReturnValue");
		QAStringArraySort_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QAStringArraySort_FunctionAddress, "ReturnValue");
		QAStringArraySort_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QAStringArraySort_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		QAStringArraySort_IsValid = QAStringArraySort_FunctionAddress != IntPtr.Zero && QAStringArraySort_StringList_IsValid && QAStringArraySort_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QAStringArraySort", QAStringArraySort_IsValid);
		GetUnitAllSkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUnitAllSkillID");
		GetUnitAllSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnitAllSkillID_FunctionAddress);
		GetUnitAllSkillID_Unit_Offset = NativeReflection.GetPropertyOffset(GetUnitAllSkillID_FunctionAddress, "Unit");
		GetUnitAllSkillID_Unit_IsValid = NativeReflection.ValidatePropertyClass(GetUnitAllSkillID_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetUnitAllSkillID_ReturnValue_PropertyAddress, GetUnitAllSkillID_FunctionAddress, "ReturnValue");
		GetUnitAllSkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetUnitAllSkillID_FunctionAddress, "ReturnValue");
		GetUnitAllSkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetUnitAllSkillID_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetUnitAllSkillID_IsValid = GetUnitAllSkillID_FunctionAddress != IntPtr.Zero && GetUnitAllSkillID_Unit_IsValid && GetUnitAllSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GetUnitAllSkillID", GetUnitAllSkillID_IsValid);
		QAGetCurrentAMName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAGetCurrentAMName");
		QAGetCurrentAMName_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetCurrentAMName_FunctionAddress);
		QAGetCurrentAMName_Target_Offset = NativeReflection.GetPropertyOffset(QAGetCurrentAMName_FunctionAddress, "Target");
		QAGetCurrentAMName_Target_IsValid = NativeReflection.ValidatePropertyClass(QAGetCurrentAMName_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QAGetCurrentAMName_ReturnValue_PropertyAddress, QAGetCurrentAMName_FunctionAddress, "ReturnValue");
		QAGetCurrentAMName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QAGetCurrentAMName_FunctionAddress, "ReturnValue");
		QAGetCurrentAMName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QAGetCurrentAMName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QAGetCurrentAMName_IsValid = QAGetCurrentAMName_FunctionAddress != IntPtr.Zero && QAGetCurrentAMName_Target_IsValid && QAGetCurrentAMName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentAMName", QAGetCurrentAMName_IsValid);
		JudgeWidgetVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "JudgeWidgetVisible");
		JudgeWidgetVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(JudgeWidgetVisible_FunctionAddress);
		JudgeWidgetVisible_Widget_Offset = NativeReflection.GetPropertyOffset(JudgeWidgetVisible_FunctionAddress, "Widget");
		JudgeWidgetVisible_Widget_IsValid = NativeReflection.ValidatePropertyClass(JudgeWidgetVisible_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref JudgeWidgetVisible_ReturnValue_PropertyAddress, JudgeWidgetVisible_FunctionAddress, "ReturnValue");
		JudgeWidgetVisible_ReturnValue_Offset = NativeReflection.GetPropertyOffset(JudgeWidgetVisible_FunctionAddress, "ReturnValue");
		JudgeWidgetVisible_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(JudgeWidgetVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		JudgeWidgetVisible_IsValid = JudgeWidgetVisible_FunctionAddress != IntPtr.Zero && JudgeWidgetVisible_Widget_IsValid && JudgeWidgetVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:JudgeWidgetVisible", JudgeWidgetVisible_IsValid);
		QAGetCurrentSkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAGetCurrentSkillID");
		QAGetCurrentSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetCurrentSkillID_FunctionAddress);
		QAGetCurrentSkillID_Target_Offset = NativeReflection.GetPropertyOffset(QAGetCurrentSkillID_FunctionAddress, "Target");
		QAGetCurrentSkillID_Target_IsValid = NativeReflection.ValidatePropertyClass(QAGetCurrentSkillID_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QAGetCurrentSkillID_ReturnValue_PropertyAddress, QAGetCurrentSkillID_FunctionAddress, "ReturnValue");
		QAGetCurrentSkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QAGetCurrentSkillID_FunctionAddress, "ReturnValue");
		QAGetCurrentSkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QAGetCurrentSkillID_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QAGetCurrentSkillID_IsValid = QAGetCurrentSkillID_FunctionAddress != IntPtr.Zero && QAGetCurrentSkillID_Target_IsValid && QAGetCurrentSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QAGetCurrentSkillID", QAGetCurrentSkillID_IsValid);
		GetTamerInViewCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTamerInViewCount");
		GetTamerInViewCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTamerInViewCount_FunctionAddress);
		GetTamerInViewCount_WorldContext_Offset = NativeReflection.GetPropertyOffset(GetTamerInViewCount_FunctionAddress, "WorldContext");
		GetTamerInViewCount_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(GetTamerInViewCount_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		GetTamerInViewCount_IsValid = GetTamerInViewCount_FunctionAddress != IntPtr.Zero && GetTamerInViewCount_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GetTamerInViewCount", GetTamerInViewCount_IsValid);
		GetPlayerTargetActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerTargetActor");
		GetPlayerTargetActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerTargetActor_FunctionAddress);
		GetPlayerTargetActor_WorldContext_Offset = NativeReflection.GetPropertyOffset(GetPlayerTargetActor_FunctionAddress, "WorldContext");
		GetPlayerTargetActor_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(GetPlayerTargetActor_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		GetPlayerTargetActor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetPlayerTargetActor_FunctionAddress, "ReturnValue");
		GetPlayerTargetActor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetPlayerTargetActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerTargetActor_IsValid = GetPlayerTargetActor_FunctionAddress != IntPtr.Zero && GetPlayerTargetActor_WorldContext_IsValid && GetPlayerTargetActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GetPlayerTargetActor", GetPlayerTargetActor_IsValid);
		IsPlayingCameraMovie_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPlayingCameraMovie");
		IsPlayingCameraMovie_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingCameraMovie_FunctionAddress);
		IsPlayingCameraMovie_WorldContext_Offset = NativeReflection.GetPropertyOffset(IsPlayingCameraMovie_FunctionAddress, "WorldContext");
		IsPlayingCameraMovie_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(IsPlayingCameraMovie_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsPlayingCameraMovie_ReturnValue_PropertyAddress, IsPlayingCameraMovie_FunctionAddress, "ReturnValue");
		IsPlayingCameraMovie_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsPlayingCameraMovie_FunctionAddress, "ReturnValue");
		IsPlayingCameraMovie_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsPlayingCameraMovie_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingCameraMovie_IsValid = IsPlayingCameraMovie_FunctionAddress != IntPtr.Zero && IsPlayingCameraMovie_WorldContext_IsValid && IsPlayingCameraMovie_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:IsPlayingCameraMovie", IsPlayingCameraMovie_IsValid);
		GetPlayingSequenceID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayingSequenceID");
		GetPlayingSequenceID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayingSequenceID_FunctionAddress);
		GetPlayingSequenceID_WorldContext_Offset = NativeReflection.GetPropertyOffset(GetPlayingSequenceID_FunctionAddress, "WorldContext");
		GetPlayingSequenceID_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(GetPlayingSequenceID_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		GetPlayingSequenceID_SequenceID_Offset = NativeReflection.GetPropertyOffset(GetPlayingSequenceID_FunctionAddress, "SequenceID");
		GetPlayingSequenceID_SequenceID_IsValid = NativeReflection.ValidatePropertyClass(GetPlayingSequenceID_FunctionAddress, "SequenceID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GetPlayingSequenceID_ReturnValue_PropertyAddress, GetPlayingSequenceID_FunctionAddress, "ReturnValue");
		GetPlayingSequenceID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetPlayingSequenceID_FunctionAddress, "ReturnValue");
		GetPlayingSequenceID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetPlayingSequenceID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPlayingSequenceID_IsValid = GetPlayingSequenceID_FunctionAddress != IntPtr.Zero && GetPlayingSequenceID_WorldContext_IsValid && GetPlayingSequenceID_SequenceID_IsValid && GetPlayingSequenceID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GetPlayingSequenceID", GetPlayingSequenceID_IsValid);
		GetActorLocationByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorLocationByName");
		GetActorLocationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLocationByName_FunctionAddress);
		GetActorLocationByName_WorldContext_Offset = NativeReflection.GetPropertyOffset(GetActorLocationByName_FunctionAddress, "WorldContext");
		GetActorLocationByName_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(GetActorLocationByName_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetActorLocationByName_ActorName_PropertyAddress, GetActorLocationByName_FunctionAddress, "ActorName");
		GetActorLocationByName_ActorName_Offset = NativeReflection.GetPropertyOffset(GetActorLocationByName_FunctionAddress, "ActorName");
		GetActorLocationByName_ActorName_IsValid = NativeReflection.ValidatePropertyClass(GetActorLocationByName_FunctionAddress, "ActorName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorLocationByName_ActorLocation_PropertyAddress, GetActorLocationByName_FunctionAddress, "ActorLocation");
		GetActorLocationByName_ActorLocation_Offset = NativeReflection.GetPropertyOffset(GetActorLocationByName_FunctionAddress, "ActorLocation");
		GetActorLocationByName_ActorLocation_IsValid = NativeReflection.ValidatePropertyClass(GetActorLocationByName_FunctionAddress, "ActorLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetActorLocationByName_ReturnValue_PropertyAddress, GetActorLocationByName_FunctionAddress, "ReturnValue");
		GetActorLocationByName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorLocationByName_FunctionAddress, "ReturnValue");
		GetActorLocationByName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorLocationByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorLocationByName_IsValid = GetActorLocationByName_FunctionAddress != IntPtr.Zero && GetActorLocationByName_WorldContext_IsValid && GetActorLocationByName_ActorName_IsValid && GetActorLocationByName_ActorLocation_IsValid && GetActorLocationByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:GetActorLocationByName", GetActorLocationByName_IsValid);
		QAUploadPerformanceData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAUploadPerformanceData");
		QAUploadPerformanceData_ParamsSize = NativeReflection.GetFunctionParamsSize(QAUploadPerformanceData_FunctionAddress);
		QAUploadPerformanceData_WorldContext_Offset = NativeReflection.GetPropertyOffset(QAUploadPerformanceData_FunctionAddress, "WorldContext");
		QAUploadPerformanceData_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(QAUploadPerformanceData_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QAUploadPerformanceData_Catelog_PropertyAddress, QAUploadPerformanceData_FunctionAddress, "Catelog");
		QAUploadPerformanceData_Catelog_Offset = NativeReflection.GetPropertyOffset(QAUploadPerformanceData_FunctionAddress, "Catelog");
		QAUploadPerformanceData_Catelog_IsValid = NativeReflection.ValidatePropertyClass(QAUploadPerformanceData_FunctionAddress, "Catelog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref QAUploadPerformanceData_Summary_PropertyAddress, QAUploadPerformanceData_FunctionAddress, "Summary");
		QAUploadPerformanceData_Summary_Offset = NativeReflection.GetPropertyOffset(QAUploadPerformanceData_FunctionAddress, "Summary");
		QAUploadPerformanceData_Summary_IsValid = NativeReflection.ValidatePropertyClass(QAUploadPerformanceData_FunctionAddress, "Summary", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref QAUploadPerformanceData_FileList_PropertyAddress, QAUploadPerformanceData_FunctionAddress, "FileList");
		QAUploadPerformanceData_FileList_Offset = NativeReflection.GetPropertyOffset(QAUploadPerformanceData_FunctionAddress, "FileList");
		QAUploadPerformanceData_FileList_IsValid = NativeReflection.ValidatePropertyClass(QAUploadPerformanceData_FunctionAddress, "FileList", Classes.FArrayProperty);
		QAUploadPerformanceData_IsValid = QAUploadPerformanceData_FunctionAddress != IntPtr.Zero && QAUploadPerformanceData_WorldContext_IsValid && QAUploadPerformanceData_Catelog_IsValid && QAUploadPerformanceData_Summary_IsValid && QAUploadPerformanceData_FileList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:QAUploadPerformanceData", QAUploadPerformanceData_IsValid);
		RebirthPointChoiceClick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RebirthPointChoiceClick");
		RebirthPointChoiceClick_ParamsSize = NativeReflection.GetFunctionParamsSize(RebirthPointChoiceClick_FunctionAddress);
		RebirthPointChoiceClick_WorldContext_Offset = NativeReflection.GetPropertyOffset(RebirthPointChoiceClick_FunctionAddress, "WorldContext");
		RebirthPointChoiceClick_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RebirthPointChoiceClick_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref RebirthPointChoiceClick_Choice_PropertyAddress, RebirthPointChoiceClick_FunctionAddress, "Choice");
		RebirthPointChoiceClick_Choice_Offset = NativeReflection.GetPropertyOffset(RebirthPointChoiceClick_FunctionAddress, "Choice");
		RebirthPointChoiceClick_Choice_IsValid = NativeReflection.ValidatePropertyClass(RebirthPointChoiceClick_FunctionAddress, "Choice", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref RebirthPointChoiceClick_ReturnValue_PropertyAddress, RebirthPointChoiceClick_FunctionAddress, "ReturnValue");
		RebirthPointChoiceClick_ReturnValue_Offset = NativeReflection.GetPropertyOffset(RebirthPointChoiceClick_FunctionAddress, "ReturnValue");
		RebirthPointChoiceClick_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(RebirthPointChoiceClick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RebirthPointChoiceClick_IsValid = RebirthPointChoiceClick_FunctionAddress != IntPtr.Zero && RebirthPointChoiceClick_WorldContext_IsValid && RebirthPointChoiceClick_Choice_IsValid && RebirthPointChoiceClick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:RebirthPointChoiceClick", RebirthPointChoiceClick_IsValid);
		AutoTestInjectInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AutoTestInjectInputEvent");
		AutoTestInjectInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoTestInjectInputEvent_FunctionAddress);
		AutoTestInjectInputEvent_WorldContext_Offset = NativeReflection.GetPropertyOffset(AutoTestInjectInputEvent_FunctionAddress, "WorldContext");
		AutoTestInjectInputEvent_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(AutoTestInjectInputEvent_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AutoTestInjectInputEvent_ActionName_PropertyAddress, AutoTestInjectInputEvent_FunctionAddress, "ActionName");
		AutoTestInjectInputEvent_ActionName_Offset = NativeReflection.GetPropertyOffset(AutoTestInjectInputEvent_FunctionAddress, "ActionName");
		AutoTestInjectInputEvent_ActionName_IsValid = NativeReflection.ValidatePropertyClass(AutoTestInjectInputEvent_FunctionAddress, "ActionName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref AutoTestInjectInputEvent_TriggerEvent_PropertyAddress, AutoTestInjectInputEvent_FunctionAddress, "TriggerEvent");
		AutoTestInjectInputEvent_TriggerEvent_Offset = NativeReflection.GetPropertyOffset(AutoTestInjectInputEvent_FunctionAddress, "TriggerEvent");
		AutoTestInjectInputEvent_TriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(AutoTestInjectInputEvent_FunctionAddress, "TriggerEvent", Classes.FEnumProperty);
		AutoTestInjectInputEvent_IsValid = AutoTestInjectInputEvent_FunctionAddress != IntPtr.Zero && AutoTestInjectInputEvent_WorldContext_IsValid && AutoTestInjectInputEvent_ActionName_IsValid && AutoTestInjectInputEvent_TriggerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTestHelperLib:AutoTestInjectInputEvent", AutoTestInjectInputEvent_IsValid);
	}
}
