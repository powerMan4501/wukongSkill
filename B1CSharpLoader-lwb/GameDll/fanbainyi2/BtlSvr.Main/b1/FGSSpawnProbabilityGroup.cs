using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityGroup")]
public struct FGSSpawnProbabilityGroup
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityGroup:SpawnProbabilityGroup")]
	public Dictionary<int, FGSSpawnProbabilityConfig> SpawnProbabilityGroup;

	private static int FGSSpawnProbabilityGroup_StructSize;

	private static int FGSSpawnProbabilityGroup_IsValid;

	private static bool SpawnProbabilityGroup_IsValid;

	private static int SpawnProbabilityGroup_Offset;

	private static FFieldAddress SpawnProbabilityGroup_PropertyAddress;

	public FGSSpawnProbabilityGroup Copy()
	{
		FGSSpawnProbabilityGroup result = this;
		if (SpawnProbabilityGroup != null)
		{
			result.SpawnProbabilityGroup = new Dictionary<int, FGSSpawnProbabilityConfig>(SpawnProbabilityGroup);
		}
		return result;
	}

	public static FGSSpawnProbabilityGroup FromNative(IntPtr nativeBuffer)
	{
		return new FGSSpawnProbabilityGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSpawnProbabilityGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSpawnProbabilityGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSpawnProbabilityGroup(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnProbabilityGroup_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSpawnProbabilityGroup value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnProbabilityGroup_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSpawnProbabilityGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnProbabilityGroup");
		}
		else
		{
			new TMapCopyMarshaler<int, FGSSpawnProbabilityConfig>(1, SpawnProbabilityGroup_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSpawnProbabilityConfig, FGSSpawnProbabilityConfig>.FromNative, CachedMarshalingDelegates<FGSSpawnProbabilityConfig, FGSSpawnProbabilityConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnProbabilityGroup_Offset), SpawnProbabilityGroup);
		}
	}

	public FGSSpawnProbabilityGroup(IntPtr nativeStruct)
	{
		if (FGSSpawnProbabilityGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnProbabilityGroup");
			SpawnProbabilityGroup = null;
		}
		else
		{
			SpawnProbabilityGroup = new TMapCopyMarshaler<int, FGSSpawnProbabilityConfig>(1, SpawnProbabilityGroup_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSpawnProbabilityConfig, FGSSpawnProbabilityConfig>.FromNative, CachedMarshalingDelegates<FGSSpawnProbabilityConfig, FGSSpawnProbabilityConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnProbabilityGroup_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSpawnProbabilityGroup");
		FGSSpawnProbabilityGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnProbabilityGroup_PropertyAddress, intPtr, "SpawnProbabilityGroup");
		SpawnProbabilityGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnProbabilityGroup");
		SpawnProbabilityGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnProbabilityGroup", Classes.FMapProperty);
		FGSSpawnProbabilityGroup_IsValid = ((intPtr != IntPtr.Zero && SpawnProbabilityGroup_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSpawnProbabilityGroup", (byte)FGSSpawnProbabilityGroup_IsValid != 0);
	}

	static FGSSpawnProbabilityGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSpawnProbabilityGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSpawnProbabilityGroup));
	}
}
