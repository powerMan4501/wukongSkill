using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SummonSpawnQuene")]
public struct FSummonSpawnQuene
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnQuene:SpawnQuenes")]
	public List<FSummonSpawnPoints> SpawnQuenes;

	private static int SummonSpawnQuene_StructSize;

	private static int SummonSpawnQuene_IsValid;

	private static bool SpawnQuenes_IsValid;

	private static int SpawnQuenes_Offset;

	private static FFieldAddress SpawnQuenes_PropertyAddress;

	public FSummonSpawnQuene Copy()
	{
		FSummonSpawnQuene result = this;
		if (SpawnQuenes != null)
		{
			result.SpawnQuenes = new List<FSummonSpawnPoints>(SpawnQuenes);
		}
		return result;
	}

	public static FSummonSpawnQuene FromNative(IntPtr nativeBuffer)
	{
		return new FSummonSpawnQuene(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSummonSpawnQuene value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSummonSpawnQuene FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSummonSpawnQuene(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnQuene_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSummonSpawnQuene value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnQuene_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SummonSpawnQuene_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnQuene");
		}
		else
		{
			new TArrayCopyMarshaler<FSummonSpawnPoints>(1, SpawnQuenes_PropertyAddress, CachedMarshalingDelegates<FSummonSpawnPoints, FSummonSpawnPoints>.FromNative, CachedMarshalingDelegates<FSummonSpawnPoints, FSummonSpawnPoints>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnQuenes_Offset), SpawnQuenes);
		}
	}

	public FSummonSpawnQuene(IntPtr nativeStruct)
	{
		if (SummonSpawnQuene_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnQuene");
			SpawnQuenes = null;
		}
		else
		{
			SpawnQuenes = new TArrayCopyMarshaler<FSummonSpawnPoints>(1, SpawnQuenes_PropertyAddress, CachedMarshalingDelegates<FSummonSpawnPoints, FSummonSpawnPoints>.FromNative, CachedMarshalingDelegates<FSummonSpawnPoints, FSummonSpawnPoints>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnQuenes_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SummonSpawnQuene");
		SummonSpawnQuene_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnQuenes_PropertyAddress, intPtr, "SpawnQuenes");
		SpawnQuenes_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnQuenes");
		SpawnQuenes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnQuenes", Classes.FArrayProperty);
		SummonSpawnQuene_IsValid = ((intPtr != IntPtr.Zero && SpawnQuenes_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SummonSpawnQuene", (byte)SummonSpawnQuene_IsValid != 0);
	}

	static FSummonSpawnQuene()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSummonSpawnQuene)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSummonSpawnQuene));
	}
}
