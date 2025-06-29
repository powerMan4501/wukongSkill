using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerEntry", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGStaticMeshSpawnerEntry
{
	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerEntry:Weight")]
	public int Weight;

	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerEntry:Mesh")]
	public TSoftObject<UStaticMesh> Mesh;

	private static bool OverrideCollisionProfile_IsValid;

	private static FFieldAddress OverrideCollisionProfile_PropertyAddress;

	private static int OverrideCollisionProfile_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerEntry:bOverrideCollisionProfile")]
	public bool OverrideCollisionProfile;

	private static bool CollisionProfile_IsValid;

	private static int CollisionProfile_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerEntry:CollisionProfile")]
	public FCollisionProfileName CollisionProfile;

	private static bool FPCGStaticMeshSpawnerEntry_IsValid;

	private static int FPCGStaticMeshSpawnerEntry_StructSize;

	public FPCGStaticMeshSpawnerEntry Copy()
	{
		return this;
	}

	public static FPCGStaticMeshSpawnerEntry FromNative(IntPtr nativeBuffer)
	{
		return new FPCGStaticMeshSpawnerEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGStaticMeshSpawnerEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGStaticMeshSpawnerEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGStaticMeshSpawnerEntry(nativeBuffer + arrayIndex * FPCGStaticMeshSpawnerEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGStaticMeshSpawnerEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGStaticMeshSpawnerEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGStaticMeshSpawnerEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGStaticMeshSpawnerEntry");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		TSoftObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, Mesh_Offset), Mesh);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideCollisionProfile_Offset), 0, OverrideCollisionProfile_PropertyAddress.Address, OverrideCollisionProfile);
		FCollisionProfileName.ToNative(IntPtr.Add(nativeStruct, CollisionProfile_Offset), CollisionProfile);
	}

	public FPCGStaticMeshSpawnerEntry(IntPtr nativeStruct)
	{
		if (!FPCGStaticMeshSpawnerEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGStaticMeshSpawnerEntry");
			Weight = 0;
			Mesh = default(TSoftObject<UStaticMesh>);
			OverrideCollisionProfile = false;
			CollisionProfile = default(FCollisionProfileName);
		}
		else
		{
			Weight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
			Mesh = TSoftObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, Mesh_Offset));
			OverrideCollisionProfile = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideCollisionProfile_Offset), 0, OverrideCollisionProfile_PropertyAddress.Address);
			CollisionProfile = FCollisionProfileName.FromNative(IntPtr.Add(nativeStruct, CollisionProfile_Offset));
		}
	}

	static FPCGStaticMeshSpawnerEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGStaticMeshSpawnerEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGStaticMeshSpawnerEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGStaticMeshSpawnerEntry");
		FPCGStaticMeshSpawnerEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FIntProperty);
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideCollisionProfile_PropertyAddress, intPtr, "bOverrideCollisionProfile");
		OverrideCollisionProfile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideCollisionProfile");
		OverrideCollisionProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideCollisionProfile", Classes.FBoolProperty);
		CollisionProfile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionProfile");
		CollisionProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionProfile", Classes.FStructProperty);
		FPCGStaticMeshSpawnerEntry_IsValid = intPtr != IntPtr.Zero && Weight_IsValid && Mesh_IsValid && OverrideCollisionProfile_IsValid && CollisionProfile_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGStaticMeshSpawnerEntry", FPCGStaticMeshSpawnerEntry_IsValid);
	}
}
