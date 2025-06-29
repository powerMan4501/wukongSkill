using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSMultiSplinePatrolConfig")]
public struct FGSMultiSplinePatrolConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMultiSplinePatrolConfig:SplineList")]
	public List<TSoftObject<AActor>> SplineList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMultiSplinePatrolConfig:TriggerBox")]
	public ATriggerBase TriggerBox;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMultiSplinePatrolConfig:WaitPointConfig")]
	public Dictionary<int, FGSSplinePatrolWaitPoint> WaitPointConfig;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMultiSplinePatrolConfig:JumpPointConfig")]
	public Dictionary<int, FGSSplinePatrolJumpPoint> JumpPointConfig;

	private static int FGSMultiSplinePatrolConfig_StructSize;

	private static int FGSMultiSplinePatrolConfig_IsValid;

	private static bool SplineList_IsValid;

	private static int SplineList_Offset;

	private static FFieldAddress SplineList_PropertyAddress;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool WaitPointConfig_IsValid;

	private static int WaitPointConfig_Offset;

	private static FFieldAddress WaitPointConfig_PropertyAddress;

	private static bool JumpPointConfig_IsValid;

	private static int JumpPointConfig_Offset;

	private static FFieldAddress JumpPointConfig_PropertyAddress;

	public FGSMultiSplinePatrolConfig Copy()
	{
		FGSMultiSplinePatrolConfig result = this;
		if (SplineList != null)
		{
			result.SplineList = new List<TSoftObject<AActor>>(SplineList);
		}
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

	public static FGSMultiSplinePatrolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSMultiSplinePatrolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMultiSplinePatrolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMultiSplinePatrolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMultiSplinePatrolConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSMultiSplinePatrolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMultiSplinePatrolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSMultiSplinePatrolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSMultiSplinePatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMultiSplinePatrolConfig");
			return;
		}
		new TArrayCopyMarshaler<TSoftObject<AActor>>(1, SplineList_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SplineList_Offset), SplineList);
		UObjectMarshaler<ATriggerBase>.ToNative(IntPtr.Add(nativeStruct, TriggerBox_Offset), TriggerBox);
		new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, WaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, WaitPointConfig_Offset), WaitPointConfig);
		new TMapCopyMarshaler<int, FGSSplinePatrolJumpPoint>(1, JumpPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, JumpPointConfig_Offset), JumpPointConfig);
	}

	public FGSMultiSplinePatrolConfig(IntPtr nativeStruct)
	{
		if (FGSMultiSplinePatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMultiSplinePatrolConfig");
			SplineList = null;
			TriggerBox = null;
			WaitPointConfig = null;
			JumpPointConfig = null;
		}
		else
		{
			SplineList = new TArrayCopyMarshaler<TSoftObject<AActor>>(1, SplineList_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SplineList_Offset));
			TriggerBox = UObjectMarshaler<ATriggerBase>.FromNative(IntPtr.Add(nativeStruct, TriggerBox_Offset));
			WaitPointConfig = new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, WaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, WaitPointConfig_Offset));
			JumpPointConfig = new TMapCopyMarshaler<int, FGSSplinePatrolJumpPoint>(1, JumpPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolJumpPoint, FGSSplinePatrolJumpPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, JumpPointConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSMultiSplinePatrolConfig");
		FGSMultiSplinePatrolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SplineList_PropertyAddress, intPtr, "SplineList");
		SplineList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineList");
		SplineList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineList", Classes.FArrayProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerBox", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WaitPointConfig_PropertyAddress, intPtr, "WaitPointConfig");
		WaitPointConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitPointConfig");
		WaitPointConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitPointConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref JumpPointConfig_PropertyAddress, intPtr, "JumpPointConfig");
		JumpPointConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpPointConfig");
		JumpPointConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpPointConfig", Classes.FMapProperty);
		FGSMultiSplinePatrolConfig_IsValid = ((intPtr != IntPtr.Zero && SplineList_IsValid && TriggerBox_IsValid && WaitPointConfig_IsValid && JumpPointConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSMultiSplinePatrolConfig", (byte)FGSMultiSplinePatrolConfig_IsValid != 0);
	}

	static FGSMultiSplinePatrolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSMultiSplinePatrolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMultiSplinePatrolConfig));
	}
}
