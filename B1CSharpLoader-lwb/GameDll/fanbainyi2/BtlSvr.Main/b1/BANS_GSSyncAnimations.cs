using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Sync Animations")]
[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations")]
internal class BANS_GSSyncAnimations : BANS_GSBase
{
	private static bool bFoundHostSyncPointOnDummyMesh_IsValid;

	private static int bFoundHostSyncPointOnDummyMesh_Offset;

	private static FFieldAddress bFoundHostSyncPointOnDummyMesh_PropertyAddress;

	private static bool SelfSyncPointOnHost_IsValid;

	private static int SelfSyncPointOnHost_Offset;

	private static bool TargetSyncPointOnHost_IsValid;

	private static int TargetSyncPointOnHost_Offset;

	private static bool SelfSyncPointOnGuest_IsValid;

	private static int SelfSyncPointOnGuest_Offset;

	private static bool TargetSyncPointOnGuest_IsValid;

	private static int TargetSyncPointOnGuest_Offset;

	private static bool GuestMontage_IsValid;

	private static int GuestMontage_Offset;

	private static bool bForceSyncDummyMeshAnimation_IsValid;

	private static int bForceSyncDummyMeshAnimation_Offset;

	private static FFieldAddress bForceSyncDummyMeshAnimation_PropertyAddress;

	private static bool bEnableDebugDraw_IsValid;

	private static int bEnableDebugDraw_Offset;

	private static FFieldAddress bEnableDebugDraw_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[DisplayName("是否在DummyMesh上搜寻Host标记点")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:bFoundHostSyncPointOnDummyMesh")]
	public bool bFoundHostSyncPointOnDummyMesh
	{
		get
		{
			CheckDestroyed();
			if (!bFoundHostSyncPointOnDummyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bFoundHostSyncPointOnDummyMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFoundHostSyncPointOnDummyMesh_Offset), 0, bFoundHostSyncPointOnDummyMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFoundHostSyncPointOnDummyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bFoundHostSyncPointOnDummyMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFoundHostSyncPointOnDummyMesh_Offset), 0, bFoundHostSyncPointOnDummyMesh_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Host身上自身的标记点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnHost")]
	public FName SelfSyncPointOnHost
	{
		get
		{
			CheckDestroyed();
			if (!SelfSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnHost");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SelfSyncPointOnHost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelfSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnHost");
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
	[DisplayName("Host身上对方的标记点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnHost")]
	public FName TargetSyncPointOnHost
	{
		get
		{
			CheckDestroyed();
			if (!TargetSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnHost");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetSyncPointOnHost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSyncPointOnHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnHost");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetSyncPointOnHost_Offset), value);
			}
		}
	}

	[DisplayName("Guest身上自身的标记点")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnGuest")]
	public FName SelfSyncPointOnGuest
	{
		get
		{
			CheckDestroyed();
			if (!SelfSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnGuest");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SelfSyncPointOnGuest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelfSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:SelfSyncPointOnGuest");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SelfSyncPointOnGuest_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Guest身上对方的标记点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnGuest")]
	public FName TargetSyncPointOnGuest
	{
		get
		{
			CheckDestroyed();
			if (!TargetSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnGuest");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetSyncPointOnGuest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSyncPointOnGuest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:TargetSyncPointOnGuest");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetSyncPointOnGuest_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Guset播放的Montage")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:GuestMontage")]
	public UAnimMontage GuestMontage
	{
		get
		{
			CheckDestroyed();
			if (!GuestMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:GuestMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, GuestMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuestMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:GuestMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, GuestMontage_Offset), value);
			}
		}
	}

	[Tooltip("默认勾选，只适用于同步动画和ibm动画同时播的情形，不适用于动画同步期间有多个ibm动画情形")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("强制同步IBM动画")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:bForceSyncDummyMeshAnimation")]
	public bool bForceSyncDummyMeshAnimation
	{
		get
		{
			CheckDestroyed();
			if (!bForceSyncDummyMeshAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bForceSyncDummyMeshAnimation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceSyncDummyMeshAnimation_Offset), 0, bForceSyncDummyMeshAnimation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceSyncDummyMeshAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bForceSyncDummyMeshAnimation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceSyncDummyMeshAnimation_Offset), 0, bForceSyncDummyMeshAnimation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("绘制同步点")]
	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:bEnableDebugDraw")]
	public bool bEnableDebugDraw
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bEnableDebugDraw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugDraw_Offset), 0, bEnableDebugDraw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSyncAnimations:bEnableDebugDraw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugDraw_Offset), 0, bEnableDebugDraw_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SelfSyncPointOnHost = B1GlobalFNames.root;
		SelfSyncPointOnGuest = B1GlobalFNames.root;
		bEnableDebugDraw = true;
		base.AnimNSType = EGsEnAnimNS.SyncAnimation;
		bForceSyncDummyMeshAnimation = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.SyncAnimation;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			AActor owner = NotifyParam.owner;
			BGS_GSEventCollection.Get(owner)?.Evt_BGS_BeginSyncAnimation.Invoke(owner, GuestMontage, bFoundHostSyncPointOnDummyMesh, SelfSyncPointOnHost, TargetSyncPointOnHost, SelfSyncPointOnGuest, bForceSyncDummyMeshAnimation, bEnableDebugDraw, NotifyParam.NotifyBeginTime, TotalDuration, NotifyParam.CurInstanceID);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			return;
		}
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		USceneComponent SocketOwnerComp;
		FTransform fTransform = (bFoundHostSyncPointOnDummyMesh ? BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, meshComp.GetOwner(), SelfSyncPointOnHost, out SocketOwnerComp) : meshComp.GetSocketTransform(SelfSyncPointOnHost));
		USceneComponent SocketOwnerComp2;
		FTransform fTransform2 = (bFoundHostSyncPointOnDummyMesh ? BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, meshComp.GetOwner(), TargetSyncPointOnHost, out SocketOwnerComp2) : meshComp.GetSocketTransform(TargetSyncPointOnHost));
		if (bEnableDebugDraw)
		{
			if (SelfSyncPointOnHost != FName.None)
			{
				DrawSyncPointDebug(NotifyParam.World, fTransform.GetLocation(), meshComp.GetForwardVector(), meshComp.GetRightVector(), meshComp.GetUpVector(), FLinearColor.Yellow);
			}
			if (TargetSyncPointOnHost != FName.None)
			{
				DrawSyncPointDebug(NotifyParam.World, fTransform2.GetLocation(), meshComp.GetForwardVector(), meshComp.GetRightVector(), meshComp.GetUpVector(), FLinearColor.White);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			AActor owner = NotifyParam.owner;
			BGS_GSEventCollection.Get(owner)?.Evt_BGS_EndSyncAnimation.Invoke(owner);
		}
	}

	private void DrawSyncPointDebug(UWorld World, FVector SyncPointLocation, FVector ForwardVector, FVector RightVector, FVector UpVector, FLinearColor SphereColor)
	{
		USystemLibrary.DrawDebugSphere(World, SyncPointLocation, 10f, 8, SphereColor, 0f, 0f);
		FVector lineEnd = SyncPointLocation + ForwardVector * 100.0;
		FVector lineEnd2 = SyncPointLocation + RightVector * 100.0;
		FVector lineEnd3 = SyncPointLocation + UpVector * 100.0;
		USystemLibrary.DrawDebugLine(World, SyncPointLocation, lineEnd, FLinearColor.Red, 0f, 3f);
		USystemLibrary.DrawDebugLine(World, SyncPointLocation, lineEnd2, FLinearColor.Green, 0f, 3f);
		USystemLibrary.DrawDebugLine(World, SyncPointLocation, lineEnd3, FLinearColor.Blue, 0f, 3f);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimations bANS_GSSyncAnimations = GCHelper.Find<b1.BANS_GSSyncAnimations>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSyncAnimations.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimations:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimations bANS_GSSyncAnimations = GCHelper.Find<b1.BANS_GSSyncAnimations>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSSyncAnimations.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimations bANS_GSSyncAnimations = GCHelper.Find<b1.BANS_GSSyncAnimations>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSyncAnimations.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimations bANS_GSSyncAnimations = GCHelper.Find<b1.BANS_GSSyncAnimations>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSyncAnimations.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSyncAnimations");
		NativeReflection.GetPropertyRef(ref bFoundHostSyncPointOnDummyMesh_PropertyAddress, intPtr, "bFoundHostSyncPointOnDummyMesh");
		bFoundHostSyncPointOnDummyMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFoundHostSyncPointOnDummyMesh");
		bFoundHostSyncPointOnDummyMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFoundHostSyncPointOnDummyMesh", Classes.FBoolProperty);
		SelfSyncPointOnHost_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelfSyncPointOnHost");
		SelfSyncPointOnHost_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelfSyncPointOnHost", Classes.FNameProperty);
		TargetSyncPointOnHost_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSyncPointOnHost");
		TargetSyncPointOnHost_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSyncPointOnHost", Classes.FNameProperty);
		SelfSyncPointOnGuest_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelfSyncPointOnGuest");
		SelfSyncPointOnGuest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelfSyncPointOnGuest", Classes.FNameProperty);
		TargetSyncPointOnGuest_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSyncPointOnGuest");
		TargetSyncPointOnGuest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSyncPointOnGuest", Classes.FNameProperty);
		GuestMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuestMontage");
		GuestMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuestMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bForceSyncDummyMeshAnimation_PropertyAddress, intPtr, "bForceSyncDummyMeshAnimation");
		bForceSyncDummyMeshAnimation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bForceSyncDummyMeshAnimation");
		bForceSyncDummyMeshAnimation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bForceSyncDummyMeshAnimation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugDraw_PropertyAddress, intPtr, "bEnableDebugDraw");
		bEnableDebugDraw_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDebugDraw");
		bEnableDebugDraw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDebugDraw", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimations:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimations:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSyncAnimations()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSyncAnimations)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSyncAnimations));
	}
}
