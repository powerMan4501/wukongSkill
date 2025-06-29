using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCreateNewVolumeFromMeshOptions
{
	private static bool VolumeType_IsValid;

	private static int VolumeType_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions:VolumeType")]
	public TSubclassOf<AVolume> VolumeType;

	private static bool AutoSimplify_IsValid;

	private static FFieldAddress AutoSimplify_PropertyAddress;

	private static int AutoSimplify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions:bAutoSimplify")]
	public bool AutoSimplify;

	private static bool MaxTriangles_IsValid;

	private static int MaxTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions:MaxTriangles")]
	public int MaxTriangles;

	private static bool FGeometryScriptCreateNewVolumeFromMeshOptions_IsValid;

	private static int FGeometryScriptCreateNewVolumeFromMeshOptions_StructSize;

	public FGeometryScriptCreateNewVolumeFromMeshOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCreateNewVolumeFromMeshOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCreateNewVolumeFromMeshOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCreateNewVolumeFromMeshOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCreateNewVolumeFromMeshOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCreateNewVolumeFromMeshOptions(nativeBuffer + arrayIndex * FGeometryScriptCreateNewVolumeFromMeshOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCreateNewVolumeFromMeshOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCreateNewVolumeFromMeshOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCreateNewVolumeFromMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions");
			return;
		}
		TSubclassOfMarshaler<AVolume>.ToNative(IntPtr.Add(nativeStruct, VolumeType_Offset), VolumeType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoSimplify_Offset), 0, AutoSimplify_PropertyAddress.Address, AutoSimplify);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxTriangles_Offset), MaxTriangles);
	}

	public FGeometryScriptCreateNewVolumeFromMeshOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCreateNewVolumeFromMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions");
			VolumeType = default(TSubclassOf<AVolume>);
			AutoSimplify = false;
			MaxTriangles = 0;
		}
		else
		{
			VolumeType = TSubclassOfMarshaler<AVolume>.FromNative(IntPtr.Add(nativeStruct, VolumeType_Offset));
			AutoSimplify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoSimplify_Offset), 0, AutoSimplify_PropertyAddress.Address);
			MaxTriangles = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxTriangles_Offset));
		}
	}

	static FGeometryScriptCreateNewVolumeFromMeshOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCreateNewVolumeFromMeshOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCreateNewVolumeFromMeshOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions");
		FGeometryScriptCreateNewVolumeFromMeshOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		VolumeType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeType");
		VolumeType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoSimplify_PropertyAddress, intPtr, "bAutoSimplify");
		AutoSimplify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoSimplify");
		AutoSimplify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoSimplify", Classes.FBoolProperty);
		MaxTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxTriangles");
		MaxTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxTriangles", Classes.FIntProperty);
		FGeometryScriptCreateNewVolumeFromMeshOptions_IsValid = intPtr != IntPtr.Zero && VolumeType_IsValid && AutoSimplify_IsValid && MaxTriangles_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingEditor.GeometryScriptCreateNewVolumeFromMeshOptions", FGeometryScriptCreateNewVolumeFromMeshOptions_IsValid);
	}
}
