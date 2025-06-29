using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.StaticMeshSpawnInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FStaticMeshSpawnInfo
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/FuncLibEditor.StaticMeshSpawnInfo:Location")]
	public FTransform Location;

	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.StaticMeshSpawnInfo:Mesh")]
	public UStaticMesh Mesh;

	private static bool FStaticMeshSpawnInfo_IsValid;

	private static int FStaticMeshSpawnInfo_StructSize;

	public FStaticMeshSpawnInfo Copy()
	{
		return this;
	}

	public static FStaticMeshSpawnInfo FromNative(IntPtr nativeBuffer)
	{
		return new FStaticMeshSpawnInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStaticMeshSpawnInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStaticMeshSpawnInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStaticMeshSpawnInfo(nativeBuffer + arrayIndex * FStaticMeshSpawnInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStaticMeshSpawnInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStaticMeshSpawnInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStaticMeshSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.StaticMeshSpawnInfo");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, Mesh_Offset), Mesh);
	}

	public FStaticMeshSpawnInfo(IntPtr nativeStruct)
	{
		if (!FStaticMeshSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.StaticMeshSpawnInfo");
			Location = default(FTransform);
			Mesh = null;
		}
		else
		{
			Location = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Mesh = UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, Mesh_Offset));
		}
	}

	static FStaticMeshSpawnInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStaticMeshSpawnInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStaticMeshSpawnInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.StaticMeshSpawnInfo");
		FStaticMeshSpawnInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		FStaticMeshSpawnInfo_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Mesh_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.StaticMeshSpawnInfo", FStaticMeshSpawnInfo_IsValid);
	}
}
