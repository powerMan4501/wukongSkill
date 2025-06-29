using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SpawnBulletSpeedGroup")]
public struct FSpawnBulletSpeedGroup
{
	[Category("GSSpawnBullets")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SpawnBulletSpeedGroup:SpdGroup")]
	public List<FSpeedGroupValue> SpdGroup;

	private static int SpawnBulletSpeedGroup_StructSize;

	private static int SpawnBulletSpeedGroup_IsValid;

	private static bool SpdGroup_IsValid;

	private static int SpdGroup_Offset;

	private static FFieldAddress SpdGroup_PropertyAddress;

	public FSpawnBulletSpeedGroup Copy()
	{
		FSpawnBulletSpeedGroup result = this;
		if (SpdGroup != null)
		{
			result.SpdGroup = new List<FSpeedGroupValue>(SpdGroup);
		}
		return result;
	}

	public static FSpawnBulletSpeedGroup FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnBulletSpeedGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnBulletSpeedGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnBulletSpeedGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnBulletSpeedGroup(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletSpeedGroup_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnBulletSpeedGroup value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletSpeedGroup_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnBulletSpeedGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletSpeedGroup");
		}
		else
		{
			new TArrayCopyMarshaler<FSpeedGroupValue>(1, SpdGroup_PropertyAddress, CachedMarshalingDelegates<FSpeedGroupValue, BlittableTypeMarshaler<FSpeedGroupValue>>.FromNative, CachedMarshalingDelegates<FSpeedGroupValue, BlittableTypeMarshaler<FSpeedGroupValue>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpdGroup_Offset), SpdGroup);
		}
	}

	public FSpawnBulletSpeedGroup(IntPtr nativeStruct)
	{
		if (SpawnBulletSpeedGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletSpeedGroup");
			SpdGroup = null;
		}
		else
		{
			SpdGroup = new TArrayCopyMarshaler<FSpeedGroupValue>(1, SpdGroup_PropertyAddress, CachedMarshalingDelegates<FSpeedGroupValue, BlittableTypeMarshaler<FSpeedGroupValue>>.FromNative, CachedMarshalingDelegates<FSpeedGroupValue, BlittableTypeMarshaler<FSpeedGroupValue>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpdGroup_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnBulletSpeedGroup");
		SpawnBulletSpeedGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpdGroup_PropertyAddress, intPtr, "SpdGroup");
		SpdGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpdGroup");
		SpdGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpdGroup", Classes.FArrayProperty);
		SpawnBulletSpeedGroup_IsValid = ((intPtr != IntPtr.Zero && SpdGroup_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnBulletSpeedGroup", (byte)SpawnBulletSpeedGroup_IsValid != 0);
	}

	static FSpawnBulletSpeedGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnBulletSpeedGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnBulletSpeedGroup));
	}
}
