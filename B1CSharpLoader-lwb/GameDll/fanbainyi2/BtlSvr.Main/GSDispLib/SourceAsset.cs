using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[USharpPath("/Script/b1-Managed.SourceAsset")]
public struct SourceAsset
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SourceAsset:AssetName")]
	public FName AssetName;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SourceAsset:MeshAsset")]
	public UStaticMesh MeshAsset;

	private static int SourceAsset_StructSize;

	private static int SourceAsset_IsValid;

	private static bool AssetName_IsValid;

	private static int AssetName_Offset;

	private static bool MeshAsset_IsValid;

	private static int MeshAsset_Offset;

	public SourceAsset Copy()
	{
		return this;
	}

	public static SourceAsset FromNative(IntPtr nativeBuffer)
	{
		return new SourceAsset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, SourceAsset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static SourceAsset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new SourceAsset(IntPtr.Add(nativeBuffer, arrayIndex * SourceAsset_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, SourceAsset value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SourceAsset_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SourceAsset_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SourceAsset");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AssetName_Offset), AssetName);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, MeshAsset_Offset), MeshAsset);
	}

	public SourceAsset(IntPtr nativeStruct)
	{
		if (SourceAsset_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SourceAsset");
			AssetName = default(FName);
			MeshAsset = null;
		}
		else
		{
			AssetName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AssetName_Offset));
			MeshAsset = UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, MeshAsset_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SourceAsset");
		SourceAsset_StructSize = NativeReflection.GetStructSize(intPtr);
		AssetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssetName");
		AssetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssetName", Classes.FNameProperty);
		MeshAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeshAsset");
		MeshAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeshAsset", Classes.FObjectProperty);
		SourceAsset_IsValid = ((intPtr != IntPtr.Zero && AssetName_IsValid && MeshAsset_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SourceAsset", (byte)SourceAsset_IsValid != 0);
	}

	static SourceAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(SourceAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(SourceAsset));
	}
}
