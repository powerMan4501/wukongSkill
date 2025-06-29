using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigShapeDefinition", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigShapeDefinition
{
	private static bool ShapeName_IsValid;

	private static int ShapeName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeDefinition:ShapeName")]
	public FName ShapeName;

	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	[UProperty(Flags = (PropFlags)7881299347898389uL)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeDefinition:StaticMesh")]
	public TSoftObject<UStaticMesh> StaticMesh;

	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589077uL)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeDefinition:Transform")]
	public FTransform Transform;

	private static bool FControlRigShapeDefinition_IsValid;

	private static int FControlRigShapeDefinition_StructSize;

	public FControlRigShapeDefinition Copy()
	{
		return this;
	}

	public static FControlRigShapeDefinition FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigShapeDefinition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigShapeDefinition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigShapeDefinition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigShapeDefinition(nativeBuffer + arrayIndex * FControlRigShapeDefinition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigShapeDefinition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigShapeDefinition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigShapeDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigShapeDefinition");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ShapeName_Offset), ShapeName);
		TSoftObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, StaticMesh_Offset), StaticMesh);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
	}

	public FControlRigShapeDefinition(IntPtr nativeStruct)
	{
		if (!FControlRigShapeDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigShapeDefinition");
			ShapeName = default(FName);
			StaticMesh = default(TSoftObject<UStaticMesh>);
			Transform = default(FTransform);
		}
		else
		{
			ShapeName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ShapeName_Offset));
			StaticMesh = TSoftObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, StaticMesh_Offset));
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
		}
	}

	static FControlRigShapeDefinition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigShapeDefinition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigShapeDefinition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigShapeDefinition");
		FControlRigShapeDefinition_StructSize = NativeReflection.GetStructSize(intPtr);
		ShapeName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeName");
		ShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeName", Classes.FNameProperty);
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMesh", Classes.FSoftObjectProperty);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		FControlRigShapeDefinition_IsValid = intPtr != IntPtr.Zero && ShapeName_IsValid && StaticMesh_IsValid && Transform_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigShapeDefinition", FControlRigShapeDefinition_IsValid);
	}
}
