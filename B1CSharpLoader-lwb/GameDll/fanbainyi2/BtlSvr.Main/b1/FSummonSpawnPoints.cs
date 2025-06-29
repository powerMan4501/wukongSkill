using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SummonSpawnPoints")]
public struct FSummonSpawnPoints
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SummonSpawnPoints:SpawnPoints")]
	public List<FTransform> SpawnPoints;

	private static int SummonSpawnPoints_StructSize;

	private static int SummonSpawnPoints_IsValid;

	private static bool SpawnPoints_IsValid;

	private static int SpawnPoints_Offset;

	private static FFieldAddress SpawnPoints_PropertyAddress;

	public FSummonSpawnPoints Copy()
	{
		FSummonSpawnPoints result = this;
		if (SpawnPoints != null)
		{
			result.SpawnPoints = new List<FTransform>(SpawnPoints);
		}
		return result;
	}

	public static FSummonSpawnPoints FromNative(IntPtr nativeBuffer)
	{
		return new FSummonSpawnPoints(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSummonSpawnPoints value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSummonSpawnPoints FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSummonSpawnPoints(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnPoints_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSummonSpawnPoints value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnPoints_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SummonSpawnPoints_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnPoints");
		}
		else
		{
			new TArrayCopyMarshaler<FTransform>(1, SpawnPoints_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnPoints_Offset), SpawnPoints);
		}
	}

	public FSummonSpawnPoints(IntPtr nativeStruct)
	{
		if (SummonSpawnPoints_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnPoints");
			SpawnPoints = null;
		}
		else
		{
			SpawnPoints = new TArrayCopyMarshaler<FTransform>(1, SpawnPoints_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnPoints_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SummonSpawnPoints");
		SummonSpawnPoints_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnPoints_PropertyAddress, intPtr, "SpawnPoints");
		SpawnPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPoints");
		SpawnPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPoints", Classes.FArrayProperty);
		SummonSpawnPoints_IsValid = ((intPtr != IntPtr.Zero && SpawnPoints_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SummonSpawnPoints", (byte)SummonSpawnPoints_IsValid != 0);
	}

	static FSummonSpawnPoints()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSummonSpawnPoints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSummonSpawnPoints));
	}
}
