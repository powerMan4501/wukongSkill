using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSGroupPatrolConfig")]
public struct FGSGroupPatrolConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSGroupPatrolConfig:SplineWaitPointConfig")]
	public Dictionary<int, FGSSplinePatrolWaitPoint> SplineWaitPointConfig;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSGroupPatrolConfig:GroupFollowConfig")]
	public FGSGroupFollowConfig GroupFollowConfig;

	private static int FGSGroupPatrolConfig_StructSize;

	private static int FGSGroupPatrolConfig_IsValid;

	private static bool SplineWaitPointConfig_IsValid;

	private static int SplineWaitPointConfig_Offset;

	private static FFieldAddress SplineWaitPointConfig_PropertyAddress;

	private static bool GroupFollowConfig_IsValid;

	private static int GroupFollowConfig_Offset;

	public FGSGroupPatrolConfig Copy()
	{
		FGSGroupPatrolConfig result = this;
		if (SplineWaitPointConfig != null)
		{
			result.SplineWaitPointConfig = new Dictionary<int, FGSSplinePatrolWaitPoint>(SplineWaitPointConfig);
		}
		return result;
	}

	public static FGSGroupPatrolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSGroupPatrolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSGroupPatrolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSGroupPatrolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSGroupPatrolConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSGroupPatrolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSGroupPatrolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSGroupPatrolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSGroupPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSGroupPatrolConfig");
			return;
		}
		new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, SplineWaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, SplineWaitPointConfig_Offset), SplineWaitPointConfig);
		FGSGroupFollowConfig.ToNative(IntPtr.Add(nativeStruct, GroupFollowConfig_Offset), GroupFollowConfig);
	}

	public FGSGroupPatrolConfig(IntPtr nativeStruct)
	{
		if (FGSGroupPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSGroupPatrolConfig");
			SplineWaitPointConfig = null;
			GroupFollowConfig = default(FGSGroupFollowConfig);
		}
		else
		{
			SplineWaitPointConfig = new TMapCopyMarshaler<int, FGSSplinePatrolWaitPoint>(1, SplineWaitPointConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplinePatrolWaitPoint, FGSSplinePatrolWaitPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, SplineWaitPointConfig_Offset));
			GroupFollowConfig = FGSGroupFollowConfig.FromNative(IntPtr.Add(nativeStruct, GroupFollowConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSGroupPatrolConfig");
		FGSGroupPatrolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SplineWaitPointConfig_PropertyAddress, intPtr, "SplineWaitPointConfig");
		SplineWaitPointConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineWaitPointConfig");
		SplineWaitPointConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineWaitPointConfig", Classes.FMapProperty);
		GroupFollowConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupFollowConfig");
		GroupFollowConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupFollowConfig", Classes.FStructProperty);
		FGSGroupPatrolConfig_IsValid = ((intPtr != IntPtr.Zero && SplineWaitPointConfig_IsValid && GroupFollowConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSGroupPatrolConfig", (byte)FGSGroupPatrolConfig_IsValid != 0);
	}

	static FGSGroupPatrolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSGroupPatrolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSGroupPatrolConfig));
	}
}
