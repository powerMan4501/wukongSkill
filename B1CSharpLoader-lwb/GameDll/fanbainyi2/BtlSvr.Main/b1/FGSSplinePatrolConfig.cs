using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig")]
public struct FGSSplinePatrolConfig
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig:SplineActor")]
	public AActor SplineActor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig:SingleDirection")]
	public bool SingleDirection;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig:TriggerBox")]
	public ATriggerBase TriggerBox;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig:WaitPointConfig")]
	public Dictionary<int, FGSSplinePatrolWaitPoint> WaitPointConfig;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolConfig:JumpPointConfig")]
	public Dictionary<int, FGSSplinePatrolJumpPoint> JumpPointConfig;

	private static int FGSSplinePatrolConfig_StructSize;

	private static int FGSSplinePatrolConfig_IsValid;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool SingleDirection_IsValid;

	private static int SingleDirection_Offset;

	private static FFieldAddress SingleDirection_PropertyAddress;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool WaitPointConfig_IsValid;

	private static int WaitPointConfig_Offset;

	private static FFieldAddress WaitPointConfig_PropertyAddress;

	private static bool JumpPointConfig_IsValid;

	private static int JumpPointConfig_Offset;

	private static FFieldAddress JumpPointConfig_PropertyAddress;

	public FGSSplinePatrolConfig Copy()
	{
		FGSSplinePatrolConfig result = this;
		if (WaitPointConfig != null)
		{
			result.WaitPointConfig = new Dictionary<int, FGSSplinePatrolWaitPoint>(WaitPointConfig);
		}
		if (JumpPointConfig != null)
		{
			result.JumpPointConfig = new Dictionary<int, FGSSplinePatrolJumpPoint>(JumpPointConfig);
		}
		return result;
	}

	public static FGSSplinePatrolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSSplinePatrolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSplinePatrolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSplinePatrolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSplinePatrolConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSplinePatrolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolConfig");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SingleDirection_Offset), 0, SingleDirection_PropertyAddress.Address, SingleDirection);
		UObjectMarshaler<ATriggerBase>.ToNative(IntPtr.Add(nativeStruct, TriggerBox_Offset), TriggerBox);
		new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, WaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, WaitPointConfig_Offset), WaitPointConfig);
		new TMapCopyMarshaler<int, FGSSplinePatrolJumpPoint>(1, JumpPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, JumpPointConfig_Offset), JumpPointConfig);
	}

	public FGSSplinePatrolConfig(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolConfig");
			SplineActor = null;
			SingleDirection = false;
			TriggerBox = null;
			WaitPointConfig = null;
			JumpPointConfig = null;
		}
		else
		{
			SplineActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			SingleDirection = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SingleDirection_Offset), 0, SingleDirection_PropertyAddress.Address);
			TriggerBox = UObjectMarshaler<ATriggerBase>.FromNative(IntPtr.Add(nativeStruct, TriggerBox_Offset));
			WaitPointConfig = new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, WaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, WaitPointConfig_Offset));
			JumpPointConfig = new TMapCopyMarshaler<int, FGSSplinePatrolJumpPoint>(1, JumpPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, JumpPointConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSplinePatrolConfig");
		FGSSplinePatrolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SingleDirection_PropertyAddress, intPtr, "SingleDirection");
		SingleDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "SingleDirection");
		SingleDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SingleDirection", Classes.FBoolProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerBox", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WaitPointConfig_PropertyAddress, intPtr, "WaitPointConfig");
		WaitPointConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitPointConfig");
		WaitPointConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitPointConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref JumpPointConfig_PropertyAddress, intPtr, "JumpPointConfig");
		JumpPointConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpPointConfig");
		JumpPointConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpPointConfig", Classes.FMapProperty);
		FGSSplinePatrolConfig_IsValid = ((intPtr != IntPtr.Zero && SplineActor_IsValid && SingleDirection_IsValid && TriggerBox_IsValid && WaitPointConfig_IsValid && JumpPointConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSplinePatrolConfig", (byte)FGSSplinePatrolConfig_IsValid != 0);
	}

	static FGSSplinePatrolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSplinePatrolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSplinePatrolConfig));
	}
}
