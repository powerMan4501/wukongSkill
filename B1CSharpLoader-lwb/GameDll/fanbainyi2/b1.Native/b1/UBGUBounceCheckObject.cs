using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUBounceCheckObject", "b1", UnrealModuleType.Game)]
public class UBGUBounceCheckObject : UObject
{
	private static bool OnBounceCheck_IsValid;

	private static IntPtr OnBounceCheck_FunctionAddress;

	private static int OnBounceCheck_ParamsSize;

	private static bool OnBounceCheck_Hit_IsValid;

	private static FFieldAddress OnBounceCheck_Hit_PropertyAddress;

	private static int OnBounceCheck_Hit_Offset;

	private static bool OnBounceCheck_OldVelocity_IsValid;

	private static FFieldAddress OnBounceCheck_OldVelocity_PropertyAddress;

	private static int OnBounceCheck_OldVelocity_Offset;

	private static bool BindBounceEvent_IsValid;

	private static IntPtr BindBounceEvent_FunctionAddress;

	private static int BindBounceEvent_ParamsSize;

	private static bool BindBounceEvent_ProjectileMovementComp_IsValid;

	private static FFieldAddress BindBounceEvent_ProjectileMovementComp_PropertyAddress;

	private static int BindBounceEvent_ProjectileMovementComp_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGUBounceCheckObject:OnBounceCheck")]
	public unsafe void OnBounceCheck(FHitResult Hit, FVector OldVelocity)
	{
		CheckDestroyed();
		if (!OnBounceCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUBounceCheckObject:OnBounceCheck");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBounceCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBounceCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnBounceCheck_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, OnBounceCheck_Hit_Offset), 0, OnBounceCheck_Hit_PropertyAddress.Address, Hit);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnBounceCheck_OldVelocity_Offset), 0, OnBounceCheck_OldVelocity_PropertyAddress.Address, OldVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnBounceCheck_FunctionAddress, intPtr, OnBounceCheck_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUBounceCheckObject:BindBounceEvent")]
	public unsafe void BindBounceEvent(UProjectileMovementComponent ProjectileMovementComp)
	{
		CheckDestroyed();
		if (!BindBounceEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUBounceCheckObject:BindBounceEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindBounceEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindBounceEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProjectileMovementComponent>.ToNative(IntPtr.Add(intPtr, BindBounceEvent_ProjectileMovementComp_Offset), 0, BindBounceEvent_ProjectileMovementComp_PropertyAddress.Address, ProjectileMovementComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindBounceEvent_FunctionAddress, intPtr, BindBounceEvent_ParamsSize);
	}

	static UBGUBounceCheckObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUBounceCheckObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUBounceCheckObject));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGUBounceCheckObject");
		OnBounceCheck_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBounceCheck");
		OnBounceCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBounceCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnBounceCheck_Hit_PropertyAddress, OnBounceCheck_FunctionAddress, "Hit");
		OnBounceCheck_Hit_Offset = NativeReflectionCached.GetPropertyOffset(OnBounceCheck_FunctionAddress, "Hit");
		OnBounceCheck_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBounceCheck_FunctionAddress, "Hit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnBounceCheck_OldVelocity_PropertyAddress, OnBounceCheck_FunctionAddress, "OldVelocity");
		OnBounceCheck_OldVelocity_Offset = NativeReflectionCached.GetPropertyOffset(OnBounceCheck_FunctionAddress, "OldVelocity");
		OnBounceCheck_OldVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBounceCheck_FunctionAddress, "OldVelocity", Classes.FStructProperty);
		OnBounceCheck_IsValid = OnBounceCheck_FunctionAddress != IntPtr.Zero && OnBounceCheck_Hit_IsValid && OnBounceCheck_OldVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUBounceCheckObject:OnBounceCheck", OnBounceCheck_IsValid);
		BindBounceEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindBounceEvent");
		BindBounceEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BindBounceEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindBounceEvent_ProjectileMovementComp_PropertyAddress, BindBounceEvent_FunctionAddress, "ProjectileMovementComp");
		BindBounceEvent_ProjectileMovementComp_Offset = NativeReflectionCached.GetPropertyOffset(BindBounceEvent_FunctionAddress, "ProjectileMovementComp");
		BindBounceEvent_ProjectileMovementComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BindBounceEvent_FunctionAddress, "ProjectileMovementComp", Classes.FObjectProperty);
		BindBounceEvent_IsValid = BindBounceEvent_FunctionAddress != IntPtr.Zero && BindBounceEvent_ProjectileMovementComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUBounceCheckObject:BindBounceEvent", BindBounceEvent_IsValid);
	}
}
