using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSplitNormalsOptions
{
	private static bool SplitByOpeningAngle_IsValid;

	private static FFieldAddress SplitByOpeningAngle_PropertyAddress;

	private static int SplitByOpeningAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions:bSplitByOpeningAngle")]
	public bool SplitByOpeningAngle;

	private static bool OpeningAngleDeg_IsValid;

	private static int OpeningAngleDeg_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions:OpeningAngleDeg")]
	public float OpeningAngleDeg;

	private static bool SplitByFaceGroup_IsValid;

	private static FFieldAddress SplitByFaceGroup_PropertyAddress;

	private static int SplitByFaceGroup_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions:bSplitByFaceGroup")]
	public bool SplitByFaceGroup;

	private static bool GroupLayer_IsValid;

	private static int GroupLayer_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions:GroupLayer")]
	public FGeometryScriptGroupLayer GroupLayer;

	private static bool FGeometryScriptSplitNormalsOptions_IsValid;

	private static int FGeometryScriptSplitNormalsOptions_StructSize;

	public FGeometryScriptSplitNormalsOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSplitNormalsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSplitNormalsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSplitNormalsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSplitNormalsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSplitNormalsOptions(nativeBuffer + arrayIndex * FGeometryScriptSplitNormalsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSplitNormalsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSplitNormalsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSplitNormalsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SplitByOpeningAngle_Offset), 0, SplitByOpeningAngle_PropertyAddress.Address, SplitByOpeningAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OpeningAngleDeg_Offset), OpeningAngleDeg);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SplitByFaceGroup_Offset), 0, SplitByFaceGroup_PropertyAddress.Address, SplitByFaceGroup);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(nativeStruct, GroupLayer_Offset), GroupLayer);
	}

	public FGeometryScriptSplitNormalsOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSplitNormalsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions");
			SplitByOpeningAngle = false;
			OpeningAngleDeg = 0f;
			SplitByFaceGroup = false;
			GroupLayer = default(FGeometryScriptGroupLayer);
		}
		else
		{
			SplitByOpeningAngle = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SplitByOpeningAngle_Offset), 0, SplitByOpeningAngle_PropertyAddress.Address);
			OpeningAngleDeg = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OpeningAngleDeg_Offset));
			SplitByFaceGroup = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SplitByFaceGroup_Offset), 0, SplitByFaceGroup_PropertyAddress.Address);
			GroupLayer = FGeometryScriptGroupLayer.FromNative(IntPtr.Add(nativeStruct, GroupLayer_Offset));
		}
	}

	static FGeometryScriptSplitNormalsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSplitNormalsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSplitNormalsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions");
		FGeometryScriptSplitNormalsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SplitByOpeningAngle_PropertyAddress, intPtr, "bSplitByOpeningAngle");
		SplitByOpeningAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSplitByOpeningAngle");
		SplitByOpeningAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSplitByOpeningAngle", Classes.FBoolProperty);
		OpeningAngleDeg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpeningAngleDeg");
		OpeningAngleDeg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpeningAngleDeg", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitByFaceGroup_PropertyAddress, intPtr, "bSplitByFaceGroup");
		SplitByFaceGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSplitByFaceGroup");
		SplitByFaceGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSplitByFaceGroup", Classes.FBoolProperty);
		GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupLayer");
		GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupLayer", Classes.FStructProperty);
		FGeometryScriptSplitNormalsOptions_IsValid = intPtr != IntPtr.Zero && SplitByOpeningAngle_IsValid && OpeningAngleDeg_IsValid && SplitByFaceGroup_IsValid && GroupLayer_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSplitNormalsOptions", FGeometryScriptSplitNormalsOptions_IsValid);
	}
}
