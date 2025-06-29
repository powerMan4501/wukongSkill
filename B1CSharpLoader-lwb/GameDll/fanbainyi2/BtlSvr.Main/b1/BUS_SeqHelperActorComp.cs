using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp")]
public class BUS_SeqHelperActorComp : UBaseActorComp
{
	private AActor OwnerActor;

	private static bool AddBuff_IsValid;

	private static IntPtr AddBuff_FunctionAddress;

	private static int AddBuff_ParamsSize;

	private static bool AddBuff_Tag_IsValid;

	private static int AddBuff_Tag_Offset;

	private static bool AddBuff_IsRemoving_IsValid;

	private static int AddBuff_IsRemoving_Offset;

	private static FFieldAddress AddBuff_IsRemoving_PropertyAddress;

	private static bool AddBuff_BuffID_IsValid;

	private static int AddBuff_BuffID_Offset;

	private static bool AddBuff_Duration_IsValid;

	private static int AddBuff_Duration_Offset;

	private static bool EnableAI_IsValid;

	private static IntPtr EnableAI_FunctionAddress;

	private static int EnableAI_ParamsSize;

	private static bool EnableAI_Tag_IsValid;

	private static int EnableAI_Tag_Offset;

	private static bool DisableAI_IsValid;

	private static IntPtr DisableAI_FunctionAddress;

	private static int DisableAI_ParamsSize;

	private static bool DisableAI_Tag_IsValid;

	private static int DisableAI_Tag_Offset;

	private static bool ExitStealth_IsValid;

	private static IntPtr ExitStealth_FunctionAddress;

	private static int ExitStealth_ParamsSize;

	private static bool PlayMontage_IsValid;

	private static IntPtr PlayMontage_FunctionAddress;

	private static int PlayMontage_ParamsSize;

	private static bool PlayMontage_Tag_IsValid;

	private static int PlayMontage_Tag_Offset;

	private static bool PlayMontage_MontageToPlay_IsValid;

	private static int PlayMontage_MontageToPlay_Offset;

	private static bool PerformPatrol_IsValid;

	private static IntPtr PerformPatrol_FunctionAddress;

	private static int PerformPatrol_ParamsSize;

	private static bool PerformPatrol_Tag_IsValid;

	private static int PerformPatrol_Tag_Offset;

	private static bool CatchAsTarget_IsValid;

	private static IntPtr CatchAsTarget_FunctionAddress;

	private static int CatchAsTarget_ParamsSize;

	private static bool CatchAsTarget_SelfTag_IsValid;

	private static int CatchAsTarget_SelfTag_Offset;

	private static bool CatchAsTarget_TargetTag_IsValid;

	private static int CatchAsTarget_TargetTag_Offset;

	private static bool SetVisibility_IsValid;

	private static IntPtr SetVisibility_FunctionAddress;

	private static int SetVisibility_ParamsSize;

	private static bool SetVisibility_Tag_IsValid;

	private static int SetVisibility_Tag_Offset;

	private static bool SetVisibility_IsHidden_IsValid;

	private static int SetVisibility_IsHidden_Offset;

	private static FFieldAddress SetVisibility_IsHidden_PropertyAddress;

	private static bool SetVisibility_EnableCollision_IsValid;

	private static int SetVisibility_EnableCollision_Offset;

	private static FFieldAddress SetVisibility_EnableCollision_PropertyAddress;

	private static bool NotifyUnitDead_IsValid;

	private static IntPtr NotifyUnitDead_FunctionAddress;

	private static int NotifyUnitDead_ParamsSize;

	private static bool NotifyUnitDead_Tag_IsValid;

	private static int NotifyUnitDead_Tag_Offset;

	private static bool UpdateSimpleStates_IsValid;

	private static IntPtr UpdateSimpleStates_FunctionAddress;

	private static int UpdateSimpleStates_ParamsSize;

	private static bool UpdateSimpleStates_Tag_IsValid;

	private static int UpdateSimpleStates_Tag_Offset;

	private static bool UpdateSimpleStates_SimpleState_IsValid;

	private static int UpdateSimpleStates_SimpleState_Offset;

	private static FFieldAddress UpdateSimpleStates_SimpleState_PropertyAddress;

	private static bool UpdateSimpleStates_IsRemoving_IsValid;

	private static int UpdateSimpleStates_IsRemoving_Offset;

	private static FFieldAddress UpdateSimpleStates_IsRemoving_PropertyAddress;

	private static bool SpawnPlayerPartner_IsValid;

	private static IntPtr SpawnPlayerPartner_FunctionAddress;

	private static int SpawnPlayerPartner_ParamsSize;

	private static bool SpawnPlayerPartner_Class_IsValid;

	private static int SpawnPlayerPartner_Class_Offset;

	private static bool SpawnPlayerPartner_Transform_IsValid;

	private static int SpawnPlayerPartner_Transform_Offset;

	private static FFieldAddress SpawnPlayerPartner_Transform_PropertyAddress;

	private static bool SpawnPlayerPartner_Tag_IsValid;

	private static int SpawnPlayerPartner_Tag_Offset;

	private static bool SpawnPlayerPartner_PauseAI_IsValid;

	private static int SpawnPlayerPartner_PauseAI_Offset;

	private static FFieldAddress SpawnPlayerPartner_PauseAI_PropertyAddress;

	private static bool PerformMoveToPlayer_IsValid;

	private static IntPtr PerformMoveToPlayer_FunctionAddress;

	private static int PerformMoveToPlayer_ParamsSize;

	private static bool PerformMoveToPlayer_Tag_IsValid;

	private static int PerformMoveToPlayer_Tag_Offset;

	private static bool PerformMoveToPlayer_SpeedRateType_IsValid;

	private static int PerformMoveToPlayer_SpeedRateType_Offset;

	private static FFieldAddress PerformMoveToPlayer_SpeedRateType_PropertyAddress;

	private static bool PerformMoveToPlayer_AcceptableRadius_IsValid;

	private static int PerformMoveToPlayer_AcceptableRadius_Offset;

	private static bool PerformMoveToPlayer_MoveAIType_IsValid;

	private static int PerformMoveToPlayer_MoveAIType_Offset;

	private static FFieldAddress PerformMoveToPlayer_MoveAIType_PropertyAddress;

	private static bool PerformMoveToPlayer_IncludeSelfRadius_IsValid;

	private static int PerformMoveToPlayer_IncludeSelfRadius_Offset;

	private static FFieldAddress PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress;

	private static bool PerformMoveToPlayer_IncludeTargetRadius_IsValid;

	private static int PerformMoveToPlayer_IncludeTargetRadius_Offset;

	private static FFieldAddress PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress;

	private static bool PerformMoveToLocation_IsValid;

	private static IntPtr PerformMoveToLocation_FunctionAddress;

	private static int PerformMoveToLocation_ParamsSize;

	private static bool PerformMoveToLocation_Tag_IsValid;

	private static int PerformMoveToLocation_Tag_Offset;

	private static bool PerformMoveToLocation_Position_IsValid;

	private static int PerformMoveToLocation_Position_Offset;

	private static FFieldAddress PerformMoveToLocation_Position_PropertyAddress;

	private static bool PerformMoveToLocation_SpeedRateType_IsValid;

	private static int PerformMoveToLocation_SpeedRateType_Offset;

	private static FFieldAddress PerformMoveToLocation_SpeedRateType_PropertyAddress;

	private static bool PerformMoveToLocation_AcceptableRadius_IsValid;

	private static int PerformMoveToLocation_AcceptableRadius_Offset;

	private static bool PerformMoveToLocation_MoveAIType_IsValid;

	private static int PerformMoveToLocation_MoveAIType_Offset;

	private static FFieldAddress PerformMoveToLocation_MoveAIType_PropertyAddress;

	private static bool PerformMoveToLocation_IncludeSelfRadius_IsValid;

	private static int PerformMoveToLocation_IncludeSelfRadius_Offset;

	private static FFieldAddress PerformMoveToLocation_IncludeSelfRadius_PropertyAddress;

	private static bool PerformMoveToLocation_IncludeTargetRadius_IsValid;

	private static int PerformMoveToLocation_IncludeTargetRadius_Offset;

	private static FFieldAddress PerformMoveToLocation_IncludeTargetRadius_PropertyAddress;

	private static bool PerformPerceivePlayer_IsValid;

	private static IntPtr PerformPerceivePlayer_FunctionAddress;

	private static int PerformPerceivePlayer_ParamsSize;

	private static bool PerformPerceivePlayer_Tag_IsValid;

	private static int PerformPerceivePlayer_Tag_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		OwnerActor = GetOwner();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:DisableAI")]
	public void DisableAI(FName Tag)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_AIPerceptionSetting.Invoke(P1: false);
			BUS_EventCollectionCS.Get(item).Evt_AIPauseBT.Invoke(P1: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:EnableAI")]
	public void EnableAI(FName Tag)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_AIPerceptionSetting.Invoke(P1: true);
			BUS_EventCollectionCS.Get(item).Evt_AIPauseBT.Invoke(P1: false);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPatrol")]
	public void PerformPatrol(FName Tag)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_StartPatrolAndLeisure.Invoke();
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToLocation")]
	public void PerformMoveToLocation(FName Tag, FVector Position, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BGUFuncLibAICS.BGURequestAIMoveToLocation(item, Position, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToPlayer")]
	public void PerformMoveToPlayer(FName Tag, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
		foreach (AActor item in OutActors)
		{
			BGUFuncLibAICS.BGURequestAIMoveToTarget(controlledPawn, item, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPerceivePlayer")]
	public void PerformPerceivePlayer(FName Tag)
	{
		EnableAI(Tag);
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_AICatchTarget.Invoke(controlledPawn, ETargetSourceType.Target_SeqAssignTarget, SkipWakeUp: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:UpdateSimpleStates")]
	public void UpdateSimpleStates(FName Tag, EBGUSimpleState SimpleState, bool IsRemoving)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_UnitSetSimpleState.Invoke(SimpleState, IsRemoving);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:NotifyUnitDead")]
	public void NotifyUnitDead(FName Tag)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BUS_EventCollectionCS.Get(item).Evt_UnitDead.Invoke(null, EDeadReason.None);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:SpawnPlayerPartner")]
	public void SpawnPlayerPartner(TSubclassOf<BGUCharacterCS> Class, FTransform Transform, FName Tag, bool PauseAI)
	{
		FVector Location = Transform.GetLocation();
		FRotator Rotation = Transform.GetRotation().Rotator();
		BGUCharacterCS bGUCharacterCS = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(OwnerActor.World, Class.Value, in Location, in Rotation) as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			bGUCharacterCS.Tags.Add(Tag);
			if (PauseAI)
			{
				DisableAI(Tag);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:CatchAsTarget")]
	public void CatchAsTarget(FName SelfTag, FName TargetTag)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), SelfTag, out var OutActors);
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), TargetTag, out var OutActors2);
		foreach (AActor item in OutActors)
		{
			if (OutActors2.Count > 0)
			{
				BUS_EventCollectionCS.Get(item).Evt_AICatchTarget.Invoke(OutActors2[0], ETargetSourceType.Target_SeqAssignTarget);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:SetVisibility")]
	public void SetVisibility(FName Tag, bool IsHidden, bool EnableCollision)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<AActor>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			item.SetActorHiddenInGame(IsHidden);
			item.SetActorEnableCollision(EnableCollision);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:ExitStealth")]
	public void ExitStealth()
	{
		BGUFunctionLibraryCS.BGUTriggerLeaveStealthMode(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn());
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:AddBuff")]
	public void AddBuff(FName Tag, bool IsRemoving, int BuffID, float Duration = -1f)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				if (!IsRemoving)
				{
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BuffAdd.Invoke(BuffID, bGUCharacterCS, bGUCharacterCS, Duration);
				}
				else
				{
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BuffRemove.Invoke(BuffID, EBuffEffectTriggerType.None, 1);
				}
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorComp:PlayMontage")]
	public void PlayMontage(FName Tag, UAnimMontage MontageToPlay)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<BGUCharacterCS>(), Tag, out var OutActors);
		foreach (AActor item in OutActors)
		{
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, MontageToPlay, FName.None);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:AddBuff")]
	private static void AddBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, AddBuff_Tag_Offset));
		bool isRemoving = BoolMarshaler.FromNative(IntPtr.Add(buffer, AddBuff_IsRemoving_Offset), 0, AddBuff_IsRemoving_PropertyAddress.Address);
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddBuff_BuffID_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddBuff_Duration_Offset));
		bUS_SeqHelperActorComp.AddBuff(tag, isRemoving, buffID, duration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:EnableAI")]
	private static void EnableAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, EnableAI_Tag_Offset));
		bUS_SeqHelperActorComp.EnableAI(tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:DisableAI")]
	private static void DisableAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, DisableAI_Tag_Offset));
		bUS_SeqHelperActorComp.DisableAI(tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:ExitStealth")]
	private static void ExitStealth__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		bUS_SeqHelperActorComp.ExitStealth();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:PlayMontage")]
	private static void PlayMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, PlayMontage_Tag_Offset));
		UAnimMontage montageToPlay = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, PlayMontage_MontageToPlay_Offset));
		bUS_SeqHelperActorComp.PlayMontage(tag, montageToPlay);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPatrol")]
	private static void PerformPatrol__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, PerformPatrol_Tag_Offset));
		bUS_SeqHelperActorComp.PerformPatrol(tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:CatchAsTarget")]
	private static void CatchAsTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName selfTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, CatchAsTarget_SelfTag_Offset));
		FName targetTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, CatchAsTarget_TargetTag_Offset));
		bUS_SeqHelperActorComp.CatchAsTarget(selfTag, targetTag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:SetVisibility")]
	private static void SetVisibility__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, SetVisibility_Tag_Offset));
		bool isHidden = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetVisibility_IsHidden_Offset), 0, SetVisibility_IsHidden_PropertyAddress.Address);
		bool enableCollision = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetVisibility_EnableCollision_Offset), 0, SetVisibility_EnableCollision_PropertyAddress.Address);
		bUS_SeqHelperActorComp.SetVisibility(tag, isHidden, enableCollision);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:NotifyUnitDead")]
	private static void NotifyUnitDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, NotifyUnitDead_Tag_Offset));
		bUS_SeqHelperActorComp.NotifyUnitDead(tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:UpdateSimpleStates")]
	private static void UpdateSimpleStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, UpdateSimpleStates_Tag_Offset));
		EBGUSimpleState simpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(buffer, UpdateSimpleStates_SimpleState_Offset), 0, UpdateSimpleStates_SimpleState_PropertyAddress.Address);
		bool isRemoving = BoolMarshaler.FromNative(IntPtr.Add(buffer, UpdateSimpleStates_IsRemoving_Offset), 0, UpdateSimpleStates_IsRemoving_PropertyAddress.Address);
		bUS_SeqHelperActorComp.UpdateSimpleStates(tag, simpleState, isRemoving);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:SpawnPlayerPartner")]
	private static void SpawnPlayerPartner__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		TSubclassOf<BGUCharacterCS> tSubclassOf = TSubclassOfMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, SpawnPlayerPartner_Class_Offset));
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, SpawnPlayerPartner_Transform_Offset));
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, SpawnPlayerPartner_Tag_Offset));
		bool pauseAI = BoolMarshaler.FromNative(IntPtr.Add(buffer, SpawnPlayerPartner_PauseAI_Offset), 0, SpawnPlayerPartner_PauseAI_PropertyAddress.Address);
		bUS_SeqHelperActorComp.SpawnPlayerPartner(tSubclassOf, transform, tag, pauseAI);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToPlayer")]
	private static void PerformMoveToPlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_Tag_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_SpeedRateType_Offset), 0, PerformMoveToPlayer_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_MoveAIType_Offset), 0, PerformMoveToPlayer_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_IncludeSelfRadius_Offset), 0, PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_IncludeTargetRadius_Offset), 0, PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress.Address);
		bUS_SeqHelperActorComp.PerformMoveToPlayer(tag, speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToLocation")]
	private static void PerformMoveToLocation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_Tag_Offset));
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_Position_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_SpeedRateType_Offset), 0, PerformMoveToLocation_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_MoveAIType_Offset), 0, PerformMoveToLocation_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_IncludeSelfRadius_Offset), 0, PerformMoveToLocation_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_IncludeTargetRadius_Offset), 0, PerformMoveToLocation_IncludeTargetRadius_PropertyAddress.Address);
		bUS_SeqHelperActorComp.PerformMoveToLocation(tag, position, speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPerceivePlayer")]
	private static void PerformPerceivePlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, PerformPerceivePlayer_Tag_Offset));
		bUS_SeqHelperActorComp.PerformPerceivePlayer(tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperActorComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperActorComp bUS_SeqHelperActorComp = GCHelper.Find<BUS_SeqHelperActorComp>(obj);
		bUS_SeqHelperActorComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqHelperActorComp");
		AddBuff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBuff");
		AddBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBuff_FunctionAddress);
		AddBuff_Tag_Offset = NativeReflection.GetPropertyOffset(AddBuff_FunctionAddress, "Tag");
		AddBuff_Tag_IsValid = NativeReflection.ValidatePropertyClass(AddBuff_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref AddBuff_IsRemoving_PropertyAddress, AddBuff_FunctionAddress, "IsRemoving");
		AddBuff_IsRemoving_Offset = NativeReflection.GetPropertyOffset(AddBuff_FunctionAddress, "IsRemoving");
		AddBuff_IsRemoving_IsValid = NativeReflection.ValidatePropertyClass(AddBuff_FunctionAddress, "IsRemoving", Classes.FBoolProperty);
		AddBuff_BuffID_Offset = NativeReflection.GetPropertyOffset(AddBuff_FunctionAddress, "BuffID");
		AddBuff_BuffID_IsValid = NativeReflection.ValidatePropertyClass(AddBuff_FunctionAddress, "BuffID", Classes.FIntProperty);
		AddBuff_Duration_Offset = NativeReflection.GetPropertyOffset(AddBuff_FunctionAddress, "Duration");
		AddBuff_Duration_IsValid = NativeReflection.ValidatePropertyClass(AddBuff_FunctionAddress, "Duration", Classes.FFloatProperty);
		AddBuff_IsValid = AddBuff_FunctionAddress != IntPtr.Zero && AddBuff_Tag_IsValid && AddBuff_IsRemoving_IsValid && AddBuff_BuffID_IsValid && AddBuff_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:AddBuff", AddBuff_IsValid);
		EnableAI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableAI");
		EnableAI_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableAI_FunctionAddress);
		EnableAI_Tag_Offset = NativeReflection.GetPropertyOffset(EnableAI_FunctionAddress, "Tag");
		EnableAI_Tag_IsValid = NativeReflection.ValidatePropertyClass(EnableAI_FunctionAddress, "Tag", Classes.FNameProperty);
		EnableAI_IsValid = EnableAI_FunctionAddress != IntPtr.Zero && EnableAI_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:EnableAI", EnableAI_IsValid);
		DisableAI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisableAI");
		DisableAI_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAI_FunctionAddress);
		DisableAI_Tag_Offset = NativeReflection.GetPropertyOffset(DisableAI_FunctionAddress, "Tag");
		DisableAI_Tag_IsValid = NativeReflection.ValidatePropertyClass(DisableAI_FunctionAddress, "Tag", Classes.FNameProperty);
		DisableAI_IsValid = DisableAI_FunctionAddress != IntPtr.Zero && DisableAI_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:DisableAI", DisableAI_IsValid);
		ExitStealth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExitStealth");
		ExitStealth_ParamsSize = NativeReflection.GetFunctionParamsSize(ExitStealth_FunctionAddress);
		ExitStealth_IsValid = ExitStealth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:ExitStealth", ExitStealth_IsValid);
		PlayMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayMontage");
		PlayMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayMontage_FunctionAddress);
		PlayMontage_Tag_Offset = NativeReflection.GetPropertyOffset(PlayMontage_FunctionAddress, "Tag");
		PlayMontage_Tag_IsValid = NativeReflection.ValidatePropertyClass(PlayMontage_FunctionAddress, "Tag", Classes.FNameProperty);
		PlayMontage_MontageToPlay_Offset = NativeReflection.GetPropertyOffset(PlayMontage_FunctionAddress, "MontageToPlay");
		PlayMontage_MontageToPlay_IsValid = NativeReflection.ValidatePropertyClass(PlayMontage_FunctionAddress, "MontageToPlay", Classes.FObjectProperty);
		PlayMontage_IsValid = PlayMontage_FunctionAddress != IntPtr.Zero && PlayMontage_Tag_IsValid && PlayMontage_MontageToPlay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:PlayMontage", PlayMontage_IsValid);
		PerformPatrol_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PerformPatrol");
		PerformPatrol_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformPatrol_FunctionAddress);
		PerformPatrol_Tag_Offset = NativeReflection.GetPropertyOffset(PerformPatrol_FunctionAddress, "Tag");
		PerformPatrol_Tag_IsValid = NativeReflection.ValidatePropertyClass(PerformPatrol_FunctionAddress, "Tag", Classes.FNameProperty);
		PerformPatrol_IsValid = PerformPatrol_FunctionAddress != IntPtr.Zero && PerformPatrol_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPatrol", PerformPatrol_IsValid);
		CatchAsTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CatchAsTarget");
		CatchAsTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(CatchAsTarget_FunctionAddress);
		CatchAsTarget_SelfTag_Offset = NativeReflection.GetPropertyOffset(CatchAsTarget_FunctionAddress, "SelfTag");
		CatchAsTarget_SelfTag_IsValid = NativeReflection.ValidatePropertyClass(CatchAsTarget_FunctionAddress, "SelfTag", Classes.FNameProperty);
		CatchAsTarget_TargetTag_Offset = NativeReflection.GetPropertyOffset(CatchAsTarget_FunctionAddress, "TargetTag");
		CatchAsTarget_TargetTag_IsValid = NativeReflection.ValidatePropertyClass(CatchAsTarget_FunctionAddress, "TargetTag", Classes.FNameProperty);
		CatchAsTarget_IsValid = CatchAsTarget_FunctionAddress != IntPtr.Zero && CatchAsTarget_SelfTag_IsValid && CatchAsTarget_TargetTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:CatchAsTarget", CatchAsTarget_IsValid);
		SetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVisibility");
		SetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibility_FunctionAddress);
		SetVisibility_Tag_Offset = NativeReflection.GetPropertyOffset(SetVisibility_FunctionAddress, "Tag");
		SetVisibility_Tag_IsValid = NativeReflection.ValidatePropertyClass(SetVisibility_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SetVisibility_IsHidden_PropertyAddress, SetVisibility_FunctionAddress, "IsHidden");
		SetVisibility_IsHidden_Offset = NativeReflection.GetPropertyOffset(SetVisibility_FunctionAddress, "IsHidden");
		SetVisibility_IsHidden_IsValid = NativeReflection.ValidatePropertyClass(SetVisibility_FunctionAddress, "IsHidden", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetVisibility_EnableCollision_PropertyAddress, SetVisibility_FunctionAddress, "EnableCollision");
		SetVisibility_EnableCollision_Offset = NativeReflection.GetPropertyOffset(SetVisibility_FunctionAddress, "EnableCollision");
		SetVisibility_EnableCollision_IsValid = NativeReflection.ValidatePropertyClass(SetVisibility_FunctionAddress, "EnableCollision", Classes.FBoolProperty);
		SetVisibility_IsValid = SetVisibility_FunctionAddress != IntPtr.Zero && SetVisibility_Tag_IsValid && SetVisibility_IsHidden_IsValid && SetVisibility_EnableCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:SetVisibility", SetVisibility_IsValid);
		NotifyUnitDead_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyUnitDead");
		NotifyUnitDead_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyUnitDead_FunctionAddress);
		NotifyUnitDead_Tag_Offset = NativeReflection.GetPropertyOffset(NotifyUnitDead_FunctionAddress, "Tag");
		NotifyUnitDead_Tag_IsValid = NativeReflection.ValidatePropertyClass(NotifyUnitDead_FunctionAddress, "Tag", Classes.FNameProperty);
		NotifyUnitDead_IsValid = NotifyUnitDead_FunctionAddress != IntPtr.Zero && NotifyUnitDead_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:NotifyUnitDead", NotifyUnitDead_IsValid);
		UpdateSimpleStates_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateSimpleStates");
		UpdateSimpleStates_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSimpleStates_FunctionAddress);
		UpdateSimpleStates_Tag_Offset = NativeReflection.GetPropertyOffset(UpdateSimpleStates_FunctionAddress, "Tag");
		UpdateSimpleStates_Tag_IsValid = NativeReflection.ValidatePropertyClass(UpdateSimpleStates_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref UpdateSimpleStates_SimpleState_PropertyAddress, UpdateSimpleStates_FunctionAddress, "SimpleState");
		UpdateSimpleStates_SimpleState_Offset = NativeReflection.GetPropertyOffset(UpdateSimpleStates_FunctionAddress, "SimpleState");
		UpdateSimpleStates_SimpleState_IsValid = NativeReflection.ValidatePropertyClass(UpdateSimpleStates_FunctionAddress, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UpdateSimpleStates_IsRemoving_PropertyAddress, UpdateSimpleStates_FunctionAddress, "IsRemoving");
		UpdateSimpleStates_IsRemoving_Offset = NativeReflection.GetPropertyOffset(UpdateSimpleStates_FunctionAddress, "IsRemoving");
		UpdateSimpleStates_IsRemoving_IsValid = NativeReflection.ValidatePropertyClass(UpdateSimpleStates_FunctionAddress, "IsRemoving", Classes.FBoolProperty);
		UpdateSimpleStates_IsValid = UpdateSimpleStates_FunctionAddress != IntPtr.Zero && UpdateSimpleStates_Tag_IsValid && UpdateSimpleStates_SimpleState_IsValid && UpdateSimpleStates_IsRemoving_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:UpdateSimpleStates", UpdateSimpleStates_IsValid);
		SpawnPlayerPartner_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SpawnPlayerPartner");
		SpawnPlayerPartner_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnPlayerPartner_FunctionAddress);
		SpawnPlayerPartner_Class_Offset = NativeReflection.GetPropertyOffset(SpawnPlayerPartner_FunctionAddress, "Class");
		SpawnPlayerPartner_Class_IsValid = NativeReflection.ValidatePropertyClass(SpawnPlayerPartner_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref SpawnPlayerPartner_Transform_PropertyAddress, SpawnPlayerPartner_FunctionAddress, "Transform");
		SpawnPlayerPartner_Transform_Offset = NativeReflection.GetPropertyOffset(SpawnPlayerPartner_FunctionAddress, "Transform");
		SpawnPlayerPartner_Transform_IsValid = NativeReflection.ValidatePropertyClass(SpawnPlayerPartner_FunctionAddress, "Transform", Classes.FStructProperty);
		SpawnPlayerPartner_Tag_Offset = NativeReflection.GetPropertyOffset(SpawnPlayerPartner_FunctionAddress, "Tag");
		SpawnPlayerPartner_Tag_IsValid = NativeReflection.ValidatePropertyClass(SpawnPlayerPartner_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SpawnPlayerPartner_PauseAI_PropertyAddress, SpawnPlayerPartner_FunctionAddress, "PauseAI");
		SpawnPlayerPartner_PauseAI_Offset = NativeReflection.GetPropertyOffset(SpawnPlayerPartner_FunctionAddress, "PauseAI");
		SpawnPlayerPartner_PauseAI_IsValid = NativeReflection.ValidatePropertyClass(SpawnPlayerPartner_FunctionAddress, "PauseAI", Classes.FBoolProperty);
		SpawnPlayerPartner_IsValid = SpawnPlayerPartner_FunctionAddress != IntPtr.Zero && SpawnPlayerPartner_Class_IsValid && SpawnPlayerPartner_Transform_IsValid && SpawnPlayerPartner_Tag_IsValid && SpawnPlayerPartner_PauseAI_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:SpawnPlayerPartner", SpawnPlayerPartner_IsValid);
		PerformMoveToPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PerformMoveToPlayer");
		PerformMoveToPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformMoveToPlayer_FunctionAddress);
		PerformMoveToPlayer_Tag_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "Tag");
		PerformMoveToPlayer_Tag_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_SpeedRateType_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "SpeedRateType");
		PerformMoveToPlayer_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "SpeedRateType");
		PerformMoveToPlayer_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		PerformMoveToPlayer_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "AcceptableRadius");
		PerformMoveToPlayer_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_MoveAIType_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "MoveAIType");
		PerformMoveToPlayer_MoveAIType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "MoveAIType");
		PerformMoveToPlayer_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToPlayer_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToPlayer_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToPlayer_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToPlayer_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		PerformMoveToPlayer_IsValid = PerformMoveToPlayer_FunctionAddress != IntPtr.Zero && PerformMoveToPlayer_Tag_IsValid && PerformMoveToPlayer_SpeedRateType_IsValid && PerformMoveToPlayer_AcceptableRadius_IsValid && PerformMoveToPlayer_MoveAIType_IsValid && PerformMoveToPlayer_IncludeSelfRadius_IsValid && PerformMoveToPlayer_IncludeTargetRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToPlayer", PerformMoveToPlayer_IsValid);
		PerformMoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PerformMoveToLocation");
		PerformMoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformMoveToLocation_FunctionAddress);
		PerformMoveToLocation_Tag_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "Tag");
		PerformMoveToLocation_Tag_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_Position_PropertyAddress, PerformMoveToLocation_FunctionAddress, "Position");
		PerformMoveToLocation_Position_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "Position");
		PerformMoveToLocation_Position_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_SpeedRateType_PropertyAddress, PerformMoveToLocation_FunctionAddress, "SpeedRateType");
		PerformMoveToLocation_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "SpeedRateType");
		PerformMoveToLocation_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		PerformMoveToLocation_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "AcceptableRadius");
		PerformMoveToLocation_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_MoveAIType_PropertyAddress, PerformMoveToLocation_FunctionAddress, "MoveAIType");
		PerformMoveToLocation_MoveAIType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "MoveAIType");
		PerformMoveToLocation_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_IncludeSelfRadius_PropertyAddress, PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToLocation_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToLocation_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_IncludeTargetRadius_PropertyAddress, PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToLocation_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToLocation_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		PerformMoveToLocation_IsValid = PerformMoveToLocation_FunctionAddress != IntPtr.Zero && PerformMoveToLocation_Tag_IsValid && PerformMoveToLocation_Position_IsValid && PerformMoveToLocation_SpeedRateType_IsValid && PerformMoveToLocation_AcceptableRadius_IsValid && PerformMoveToLocation_MoveAIType_IsValid && PerformMoveToLocation_IncludeSelfRadius_IsValid && PerformMoveToLocation_IncludeTargetRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformMoveToLocation", PerformMoveToLocation_IsValid);
		PerformPerceivePlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PerformPerceivePlayer");
		PerformPerceivePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformPerceivePlayer_FunctionAddress);
		PerformPerceivePlayer_Tag_Offset = NativeReflection.GetPropertyOffset(PerformPerceivePlayer_FunctionAddress, "Tag");
		PerformPerceivePlayer_Tag_IsValid = NativeReflection.ValidatePropertyClass(PerformPerceivePlayer_FunctionAddress, "Tag", Classes.FNameProperty);
		PerformPerceivePlayer_IsValid = PerformPerceivePlayer_FunctionAddress != IntPtr.Zero && PerformPerceivePlayer_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:PerformPerceivePlayer", PerformPerceivePlayer_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperActorComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BUS_SeqHelperActorComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqHelperActorComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqHelperActorComp));
	}
}
