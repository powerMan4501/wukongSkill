using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Spawn Actor And Sync Animation")]
[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation")]
internal class BANS_GSSpawnActorAndSyncAnimation : BANS_GSBase
{
	private static bool SpawnActorTemplate_IsValid;

	private static int SpawnActorTemplate_Offset;

	private static bool bFoundHostSyncPointOnDummyMesh_IsValid;

	private static int bFoundHostSyncPointOnDummyMesh_Offset;

	private static FFieldAddress bFoundHostSyncPointOnDummyMesh_PropertyAddress;

	private static bool SelfSyncPointOnHost_IsValid;

	private static int SelfSyncPointOnHost_Offset;

	private static bool TargetSyncPointOnHost_IsValid;

	private static int TargetSyncPointOnHost_Offset;

	private static bool SelfSyncPointOnGuest_IsValid;

	private static int SelfSyncPointOnGuest_Offset;

	private static bool GuestMontage_IsValid;

	private static int GuestMontage_Offset;

	private static bool bActorKeepAlive_IsValid;

	private static int bActorKeepAlive_Offset;

	private static FFieldAddress bActorKeepAlive_PropertyAddress;

	private static bool DestroyDelayTime_IsValid;

	private static int DestroyDelayTime_Offset;

	private static bool bStopGuestMontageOnEnd_IsValid;

	private static int bStopGuestMontageOnEnd_Offset;

	private static FFieldAddress bStopGuestMontageOnEnd_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("创建Actor蓝图")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SpawnActorTemplate")]
	public TSubclassOf<AActor> SpawnActorTemplate
	{
		get
		{
			CheckDestroyed();
			if (!SpawnActorTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SpawnActorTemplate");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SpawnActorTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnActorTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SpawnActorTemplate");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SpawnActorTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否在DummyMesh上搜寻挂点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bFoundHostSyncPointOnDummyMesh")]
	public bool bFoundHostSyncPointOnDummyMesh
	{
		get
		{
			CheckDestroyed();
			if (!bFoundHostSyncPointOnDummyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bFoundHostSyncPointOnDummyMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFoundHostSyncPointOnDummyMesh_Offset), 0, bFoundHostSyncPointOnDummyMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFoundHostSyncPointOnDummyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bFoundHostSyncPointOnDummyMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFoundHostSyncPointOnDummyMesh_Offset), 0, bFoundHostSyncPointOnDummyMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bFoundHostSyncPointOnDummyMesh")]
	[BlueprintReadWrite]
	[DisplayName("DummyMesh挂在Owner的挂点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnHost")]
	public FName SelfSyncPointOnHost
	{
		get
		{
			CheckDestroyed();
			if (!SelfSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnHost");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SelfSyncPointOnHost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelfSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnHost");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SelfSyncPointOnHost_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Actor挂在DummyMesh或Owner的挂点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:TargetSyncPointOnHost")]
	public FName TargetSyncPointOnHost
	{
		get
		{
			CheckDestroyed();
			if (!TargetSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:TargetSyncPointOnHost");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetSyncPointOnHost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:TargetSyncPointOnHost");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetSyncPointOnHost_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Actor的挂点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnGuest")]
	public FName SelfSyncPointOnGuest
	{
		get
		{
			CheckDestroyed();
			if (!SelfSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnGuest");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SelfSyncPointOnGuest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelfSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:SelfSyncPointOnGuest");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SelfSyncPointOnGuest_Offset), value);
			}
		}
	}

	[DisplayName("Actor动画")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GuestMontage")]
	public UAnimMontage GuestMontage
	{
		get
		{
			CheckDestroyed();
			if (!GuestMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GuestMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, GuestMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuestMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GuestMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, GuestMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束后Actor是否保留")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bActorKeepAlive")]
	public bool bActorKeepAlive
	{
		get
		{
			CheckDestroyed();
			if (!bActorKeepAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bActorKeepAlive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bActorKeepAlive_Offset), 0, bActorKeepAlive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bActorKeepAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bActorKeepAlive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bActorKeepAlive_Offset), 0, bActorKeepAlive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "!bActorKeepAlive")]
	[DisplayName("延迟销毁Actor时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:DestroyDelayTime")]
	public float DestroyDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:DestroyDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:DestroyDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyDelayTime_Offset), value);
			}
		}
	}

	[DisplayName("结束后是否打断Actor动画")]
	[UMeta(MDProp.EditCondition, "bActorKeepAlive || DestroyDelayTime > 0")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bStopGuestMontageOnEnd")]
	public bool bStopGuestMontageOnEnd
	{
		get
		{
			CheckDestroyed();
			if (!bStopGuestMontageOnEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bStopGuestMontageOnEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopGuestMontageOnEnd_Offset), 0, bStopGuestMontageOnEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopGuestMontageOnEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:bStopGuestMontageOnEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopGuestMontageOnEnd_Offset), 0, bStopGuestMontageOnEnd_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SelfSyncPointOnHost = B1GlobalFNames.root;
		SelfSyncPointOnGuest = B1GlobalFNames.root;
		bActorKeepAlive = false;
		base.AnimNSType = EGsEnAnimNS.SyncAnimation;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.SyncAnimation;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			return;
		}
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UBGUAnimationSyncComponent componentByClass = owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (componentByClass == null)
		{
			BGW_LogUtil.LogError("[{0}] Try SpawnActorAndSyncAnimation, but has no BGUAnimationSyncComponent!", owner.GetName());
			return;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		if (bFoundHostSyncPointOnDummyMesh)
		{
			BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, TargetSyncPointOnHost, out var SocketOwnerComp);
			uSkeletalMeshComponent = SocketOwnerComp as USkeletalMeshComponent;
		}
		if (uSkeletalMeshComponent != null)
		{
			uSkeletalMeshComponent.AttachToComponent(uSkeletalMeshComponent.GetAttachParent(), SelfSyncPointOnHost, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: true);
		}
		IBUC_AnimationSyncHostData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AnimationSyncHostData, BUC_AnimationSyncHostData>(owner);
		if (unPersistentReadOnlyData != null)
		{
			uint uniqueID = GetUniqueID();
			BUS_EventCollectionCS.Get(owner)?.Evt_RequestSpawnSyncAnimActor.Invoke(uniqueID, SpawnActorTemplate.Value);
			IBUC_MovementData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MovementData, BUC_MovementData>(owner);
			AActor spawnedSyncAnimActor = unPersistentReadOnlyData.GetSpawnedSyncAnimActor(uniqueID);
			if (spawnedSyncAnimActor != null)
			{
				BUS_EventCollectionCS.Get(spawnedSyncAnimActor)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, TotalDuration);
				componentByClass.OnBeginSyncAnimationOnGuest(GuestMontage, TargetSyncPointOnHost, SelfSyncPointOnGuest, bEnableDebugDraw: false, NotifyParam.NotifyBeginTime, uSkeletalMeshComponent, spawnedSyncAnimActor, 0f, unPersistentReadOnlyData2.IsAMCalcSpeedRate ? unPersistentReadOnlyData2.AMSpeedRate : 1f, bIgnoreSceneCollision: true);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			return;
		}
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UBGUAnimationSyncComponent componentByClass = owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (componentByClass == null)
		{
			return;
		}
		componentByClass.OnEndSyncAnimationOnGuest(bStopGuestMontageOnEnd);
		IBUC_AnimationSyncHostData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AnimationSyncHostData, BUC_AnimationSyncHostData>(owner);
		if (unPersistentReadOnlyData != null)
		{
			uint uniqueID = GetUniqueID();
			if (!(unPersistentReadOnlyData.GetSpawnedSyncAnimActor(uniqueID) == null))
			{
				BUS_EventCollectionCS.Get(owner)?.Evt_RemoveSpawnedSyncAnimActor.Invoke(uniqueID, !bActorKeepAlive, DestroyDelayTime);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSpawnActorAndSyncAnimation bANS_GSSpawnActorAndSyncAnimation = GCHelper.Find<b1.BANS_GSSpawnActorAndSyncAnimation>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSSpawnActorAndSyncAnimation.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSpawnActorAndSyncAnimation bANS_GSSpawnActorAndSyncAnimation = GCHelper.Find<b1.BANS_GSSpawnActorAndSyncAnimation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSpawnActorAndSyncAnimation.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSpawnActorAndSyncAnimation bANS_GSSpawnActorAndSyncAnimation = GCHelper.Find<b1.BANS_GSSpawnActorAndSyncAnimation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSpawnActorAndSyncAnimation.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation");
		SpawnActorTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnActorTemplate");
		SpawnActorTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnActorTemplate", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref bFoundHostSyncPointOnDummyMesh_PropertyAddress, intPtr, "bFoundHostSyncPointOnDummyMesh");
		bFoundHostSyncPointOnDummyMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFoundHostSyncPointOnDummyMesh");
		bFoundHostSyncPointOnDummyMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFoundHostSyncPointOnDummyMesh", Classes.FBoolProperty);
		SelfSyncPointOnHost_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelfSyncPointOnHost");
		SelfSyncPointOnHost_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelfSyncPointOnHost", Classes.FNameProperty);
		TargetSyncPointOnHost_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSyncPointOnHost");
		TargetSyncPointOnHost_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSyncPointOnHost", Classes.FNameProperty);
		SelfSyncPointOnGuest_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelfSyncPointOnGuest");
		SelfSyncPointOnGuest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelfSyncPointOnGuest", Classes.FNameProperty);
		GuestMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuestMontage");
		GuestMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuestMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bActorKeepAlive_PropertyAddress, intPtr, "bActorKeepAlive");
		bActorKeepAlive_Offset = NativeReflection.GetPropertyOffset(intPtr, "bActorKeepAlive");
		bActorKeepAlive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bActorKeepAlive", Classes.FBoolProperty);
		DestroyDelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyDelayTime");
		DestroyDelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyDelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bStopGuestMontageOnEnd_PropertyAddress, intPtr, "bStopGuestMontageOnEnd");
		bStopGuestMontageOnEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStopGuestMontageOnEnd");
		bStopGuestMontageOnEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStopGuestMontageOnEnd", Classes.FBoolProperty);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnActorAndSyncAnimation:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSpawnActorAndSyncAnimation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSpawnActorAndSyncAnimation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSpawnActorAndSyncAnimation));
	}
}
