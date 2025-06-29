using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUAnimationSyncComponent", "b1", UnrealModuleType.Game)]
public class UBGUAnimationSyncComponent : UActorComponent
{
	private static bool DrivingComp_IsValid;

	private static int DrivingComp_Offset;

	private static bool OnSwitchSyncGuestTarget_IsValid;

	private static IntPtr OnSwitchSyncGuestTarget_FunctionAddress;

	private static int OnSwitchSyncGuestTarget_ParamsSize;

	private static bool OnSwitchSyncGuestTarget_NewGuest_IsValid;

	private static FFieldAddress OnSwitchSyncGuestTarget_NewGuest_PropertyAddress;

	private static int OnSwitchSyncGuestTarget_NewGuest_Offset;

	private static bool OnRespectCollisionInASS_IsValid;

	private static IntPtr OnRespectCollisionInASS_FunctionAddress;

	private static int OnRespectCollisionInASS_ParamsSize;

	private static bool OnRespectCollisionInASS_bRespect_IsValid;

	private static FFieldAddress OnRespectCollisionInASS_bRespect_PropertyAddress;

	private static int OnRespectCollisionInASS_bRespect_Offset;

	private static bool OnEndSyncAnimationOnGuest_IsValid;

	private static IntPtr OnEndSyncAnimationOnGuest_FunctionAddress;

	private static int OnEndSyncAnimationOnGuest_ParamsSize;

	private static bool OnEndSyncAnimationOnGuest_bStopGuestMontage_IsValid;

	private static FFieldAddress OnEndSyncAnimationOnGuest_bStopGuestMontage_PropertyAddress;

	private static int OnEndSyncAnimationOnGuest_bStopGuestMontage_Offset;

	private static bool OnBeginSyncAnimationOnGuest_IsValid;

	private static IntPtr OnBeginSyncAnimationOnGuest_FunctionAddress;

	private static int OnBeginSyncAnimationOnGuest_ParamsSize;

	private static bool OnBeginSyncAnimationOnGuest_InGuestMontage_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_InGuestMontage_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_InGuestMontage_Offset;

	private static bool OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_Offset;

	private static bool OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_Offset;

	private static bool OnBeginSyncAnimationOnGuest_bEnableDebugDraw_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_bEnableDebugDraw_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_bEnableDebugDraw_Offset;

	private static bool OnBeginSyncAnimationOnGuest_NotifyBeginTime_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_NotifyBeginTime_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_NotifyBeginTime_Offset;

	private static bool OnBeginSyncAnimationOnGuest_DummyMesh_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_DummyMesh_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_DummyMesh_Offset;

	private static bool OnBeginSyncAnimationOnGuest_InGuestActor_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_InGuestActor_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_InGuestActor_Offset;

	private static bool OnBeginSyncAnimationOnGuest_InBlendInTime_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_InBlendInTime_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_InBlendInTime_Offset;

	private static bool OnBeginSyncAnimationOnGuest_PlayRate_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_PlayRate_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_PlayRate_Offset;

	private static bool OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_IsValid;

	private static FFieldAddress OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_PropertyAddress;

	private static int OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_Offset;

	[UProperty(Flags = (PropFlags)20266268116910620uL)]
	[UMetaPath("/Script/b1.BGUAnimationSyncComponent:DrivingComp")]
	public USceneComponent DrivingComp
	{
		get
		{
			CheckDestroyed();
			if (!DrivingComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUAnimationSyncComponent:DrivingComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DrivingComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrivingComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUAnimationSyncComponent:DrivingComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DrivingComp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUAnimationSyncComponent:OnSwitchSyncGuestTarget")]
	public unsafe void OnSwitchSyncGuestTarget(AActor NewGuest)
	{
		CheckDestroyed();
		if (!OnSwitchSyncGuestTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUAnimationSyncComponent:OnSwitchSyncGuestTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSwitchSyncGuestTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSwitchSyncGuestTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnSwitchSyncGuestTarget_NewGuest_Offset), 0, OnSwitchSyncGuestTarget_NewGuest_PropertyAddress.Address, NewGuest);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSwitchSyncGuestTarget_FunctionAddress, intPtr, OnSwitchSyncGuestTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUAnimationSyncComponent:OnRespectCollisionInASS")]
	public unsafe void OnRespectCollisionInASS(bool bRespect)
	{
		CheckDestroyed();
		if (!OnRespectCollisionInASS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUAnimationSyncComponent:OnRespectCollisionInASS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRespectCollisionInASS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRespectCollisionInASS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnRespectCollisionInASS_bRespect_Offset), 0, OnRespectCollisionInASS_bRespect_PropertyAddress.Address, bRespect);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRespectCollisionInASS_FunctionAddress, intPtr, OnRespectCollisionInASS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUAnimationSyncComponent:OnEndSyncAnimationOnGuest")]
	public unsafe void OnEndSyncAnimationOnGuest(bool bStopGuestMontage = false)
	{
		CheckDestroyed();
		if (!OnEndSyncAnimationOnGuest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUAnimationSyncComponent:OnEndSyncAnimationOnGuest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndSyncAnimationOnGuest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndSyncAnimationOnGuest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEndSyncAnimationOnGuest_bStopGuestMontage_Offset), 0, OnEndSyncAnimationOnGuest_bStopGuestMontage_PropertyAddress.Address, bStopGuestMontage);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndSyncAnimationOnGuest_FunctionAddress, intPtr, OnEndSyncAnimationOnGuest_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUAnimationSyncComponent:OnBeginSyncAnimationOnGuest")]
	public unsafe void OnBeginSyncAnimationOnGuest(UAnimMontage InGuestMontage, FName InTargetSyncPointOnHost, FName InSelfSyncPointOnGuest, bool bEnableDebugDraw, float NotifyBeginTime, USkeletalMeshComponent DummyMesh, AActor InGuestActor, float InBlendInTime, float PlayRate = 1f, bool bIgnoreSceneCollision = false)
	{
		CheckDestroyed();
		if (!OnBeginSyncAnimationOnGuest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUAnimationSyncComponent:OnBeginSyncAnimationOnGuest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginSyncAnimationOnGuest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginSyncAnimationOnGuest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_InGuestMontage_Offset), 0, OnBeginSyncAnimationOnGuest_InGuestMontage_PropertyAddress.Address, InGuestMontage);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_Offset), 0, OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_PropertyAddress.Address, InTargetSyncPointOnHost);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_Offset), 0, OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_PropertyAddress.Address, InSelfSyncPointOnGuest);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_bEnableDebugDraw_Offset), 0, OnBeginSyncAnimationOnGuest_bEnableDebugDraw_PropertyAddress.Address, bEnableDebugDraw);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_NotifyBeginTime_Offset), 0, OnBeginSyncAnimationOnGuest_NotifyBeginTime_PropertyAddress.Address, NotifyBeginTime);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_DummyMesh_Offset), 0, OnBeginSyncAnimationOnGuest_DummyMesh_PropertyAddress.Address, DummyMesh);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_InGuestActor_Offset), 0, OnBeginSyncAnimationOnGuest_InGuestActor_PropertyAddress.Address, InGuestActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_InBlendInTime_Offset), 0, OnBeginSyncAnimationOnGuest_InBlendInTime_PropertyAddress.Address, InBlendInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_PlayRate_Offset), 0, OnBeginSyncAnimationOnGuest_PlayRate_PropertyAddress.Address, PlayRate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_Offset), 0, OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_PropertyAddress.Address, bIgnoreSceneCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnBeginSyncAnimationOnGuest_FunctionAddress, intPtr, OnBeginSyncAnimationOnGuest_ParamsSize);
	}

	static UBGUAnimationSyncComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUAnimationSyncComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUAnimationSyncComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUAnimationSyncComponent");
		DrivingComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrivingComp");
		DrivingComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrivingComp", Classes.FObjectProperty);
		OnSwitchSyncGuestTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSwitchSyncGuestTarget");
		OnSwitchSyncGuestTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSwitchSyncGuestTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSwitchSyncGuestTarget_NewGuest_PropertyAddress, OnSwitchSyncGuestTarget_FunctionAddress, "NewGuest");
		OnSwitchSyncGuestTarget_NewGuest_Offset = NativeReflectionCached.GetPropertyOffset(OnSwitchSyncGuestTarget_FunctionAddress, "NewGuest");
		OnSwitchSyncGuestTarget_NewGuest_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwitchSyncGuestTarget_FunctionAddress, "NewGuest", Classes.FObjectProperty);
		OnSwitchSyncGuestTarget_IsValid = OnSwitchSyncGuestTarget_FunctionAddress != IntPtr.Zero && OnSwitchSyncGuestTarget_NewGuest_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUAnimationSyncComponent:OnSwitchSyncGuestTarget", OnSwitchSyncGuestTarget_IsValid);
		OnRespectCollisionInASS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRespectCollisionInASS");
		OnRespectCollisionInASS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRespectCollisionInASS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRespectCollisionInASS_bRespect_PropertyAddress, OnRespectCollisionInASS_FunctionAddress, "bRespect");
		OnRespectCollisionInASS_bRespect_Offset = NativeReflectionCached.GetPropertyOffset(OnRespectCollisionInASS_FunctionAddress, "bRespect");
		OnRespectCollisionInASS_bRespect_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRespectCollisionInASS_FunctionAddress, "bRespect", Classes.FBoolProperty);
		OnRespectCollisionInASS_IsValid = OnRespectCollisionInASS_FunctionAddress != IntPtr.Zero && OnRespectCollisionInASS_bRespect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUAnimationSyncComponent:OnRespectCollisionInASS", OnRespectCollisionInASS_IsValid);
		OnEndSyncAnimationOnGuest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndSyncAnimationOnGuest");
		OnEndSyncAnimationOnGuest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndSyncAnimationOnGuest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEndSyncAnimationOnGuest_bStopGuestMontage_PropertyAddress, OnEndSyncAnimationOnGuest_FunctionAddress, "bStopGuestMontage");
		OnEndSyncAnimationOnGuest_bStopGuestMontage_Offset = NativeReflectionCached.GetPropertyOffset(OnEndSyncAnimationOnGuest_FunctionAddress, "bStopGuestMontage");
		OnEndSyncAnimationOnGuest_bStopGuestMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndSyncAnimationOnGuest_FunctionAddress, "bStopGuestMontage", Classes.FBoolProperty);
		OnEndSyncAnimationOnGuest_IsValid = OnEndSyncAnimationOnGuest_FunctionAddress != IntPtr.Zero && OnEndSyncAnimationOnGuest_bStopGuestMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUAnimationSyncComponent:OnEndSyncAnimationOnGuest", OnEndSyncAnimationOnGuest_IsValid);
		OnBeginSyncAnimationOnGuest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnBeginSyncAnimationOnGuest");
		OnBeginSyncAnimationOnGuest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeginSyncAnimationOnGuest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_InGuestMontage_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestMontage");
		OnBeginSyncAnimationOnGuest_InGuestMontage_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestMontage");
		OnBeginSyncAnimationOnGuest_InGuestMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "InTargetSyncPointOnHost");
		OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "InTargetSyncPointOnHost");
		OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "InTargetSyncPointOnHost", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "InSelfSyncPointOnGuest");
		OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "InSelfSyncPointOnGuest");
		OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "InSelfSyncPointOnGuest", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_bEnableDebugDraw_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "bEnableDebugDraw");
		OnBeginSyncAnimationOnGuest_bEnableDebugDraw_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "bEnableDebugDraw");
		OnBeginSyncAnimationOnGuest_bEnableDebugDraw_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "bEnableDebugDraw", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_NotifyBeginTime_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "NotifyBeginTime");
		OnBeginSyncAnimationOnGuest_NotifyBeginTime_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "NotifyBeginTime");
		OnBeginSyncAnimationOnGuest_NotifyBeginTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "NotifyBeginTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_DummyMesh_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "DummyMesh");
		OnBeginSyncAnimationOnGuest_DummyMesh_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "DummyMesh");
		OnBeginSyncAnimationOnGuest_DummyMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "DummyMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_InGuestActor_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestActor");
		OnBeginSyncAnimationOnGuest_InGuestActor_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestActor");
		OnBeginSyncAnimationOnGuest_InGuestActor_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "InGuestActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_InBlendInTime_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "InBlendInTime");
		OnBeginSyncAnimationOnGuest_InBlendInTime_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "InBlendInTime");
		OnBeginSyncAnimationOnGuest_InBlendInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "InBlendInTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_PlayRate_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "PlayRate");
		OnBeginSyncAnimationOnGuest_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "PlayRate");
		OnBeginSyncAnimationOnGuest_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_PropertyAddress, OnBeginSyncAnimationOnGuest_FunctionAddress, "bIgnoreSceneCollision");
		OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_Offset = NativeReflectionCached.GetPropertyOffset(OnBeginSyncAnimationOnGuest_FunctionAddress, "bIgnoreSceneCollision");
		OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeginSyncAnimationOnGuest_FunctionAddress, "bIgnoreSceneCollision", Classes.FBoolProperty);
		OnBeginSyncAnimationOnGuest_IsValid = OnBeginSyncAnimationOnGuest_FunctionAddress != IntPtr.Zero && OnBeginSyncAnimationOnGuest_InGuestMontage_IsValid && OnBeginSyncAnimationOnGuest_InTargetSyncPointOnHost_IsValid && OnBeginSyncAnimationOnGuest_InSelfSyncPointOnGuest_IsValid && OnBeginSyncAnimationOnGuest_bEnableDebugDraw_IsValid && OnBeginSyncAnimationOnGuest_NotifyBeginTime_IsValid && OnBeginSyncAnimationOnGuest_DummyMesh_IsValid && OnBeginSyncAnimationOnGuest_InGuestActor_IsValid && OnBeginSyncAnimationOnGuest_InBlendInTime_IsValid && OnBeginSyncAnimationOnGuest_PlayRate_IsValid && OnBeginSyncAnimationOnGuest_bIgnoreSceneCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUAnimationSyncComponent:OnBeginSyncAnimationOnGuest", OnBeginSyncAnimationOnGuest_IsValid);
	}
}
