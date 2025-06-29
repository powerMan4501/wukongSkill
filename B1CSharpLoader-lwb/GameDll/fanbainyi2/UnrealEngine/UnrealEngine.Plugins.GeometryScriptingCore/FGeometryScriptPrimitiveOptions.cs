using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPrimitiveOptions
{
	private static bool PolygroupMode_IsValid;

	private static FFieldAddress PolygroupMode_PropertyAddress;

	private static int PolygroupMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions:PolygroupMode")]
	public EGeometryScriptPrimitivePolygroupMode PolygroupMode;

	private static bool FlipOrientation_IsValid;

	private static FFieldAddress FlipOrientation_PropertyAddress;

	private static int FlipOrientation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions:bFlipOrientation")]
	public bool FlipOrientation;

	private static bool UVMode_IsValid;

	private static FFieldAddress UVMode_PropertyAddress;

	private static int UVMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions:UVMode")]
	public EGeometryScriptPrimitiveUVMode UVMode;

	private static bool FGeometryScriptPrimitiveOptions_IsValid;

	private static int FGeometryScriptPrimitiveOptions_StructSize;

	public FGeometryScriptPrimitiveOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPrimitiveOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPrimitiveOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPrimitiveOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPrimitiveOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPrimitiveOptions(nativeBuffer + arrayIndex * FGeometryScriptPrimitiveOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPrimitiveOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPrimitiveOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPrimitiveOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions");
			return;
		}
		EnumMarshaler<EGeometryScriptPrimitivePolygroupMode>.ToNative(IntPtr.Add(nativeStruct, PolygroupMode_Offset), 0, PolygroupMode_PropertyAddress.Address, PolygroupMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipOrientation_Offset), 0, FlipOrientation_PropertyAddress.Address, FlipOrientation);
		EnumMarshaler<EGeometryScriptPrimitiveUVMode>.ToNative(IntPtr.Add(nativeStruct, UVMode_Offset), 0, UVMode_PropertyAddress.Address, UVMode);
	}

	public FGeometryScriptPrimitiveOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPrimitiveOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions");
			PolygroupMode = EGeometryScriptPrimitivePolygroupMode.SingleGroup;
			FlipOrientation = false;
			UVMode = EGeometryScriptPrimitiveUVMode.Uniform;
		}
		else
		{
			PolygroupMode = EnumMarshaler<EGeometryScriptPrimitivePolygroupMode>.FromNative(IntPtr.Add(nativeStruct, PolygroupMode_Offset), 0, PolygroupMode_PropertyAddress.Address);
			FlipOrientation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipOrientation_Offset), 0, FlipOrientation_PropertyAddress.Address);
			UVMode = EnumMarshaler<EGeometryScriptPrimitiveUVMode>.FromNative(IntPtr.Add(nativeStruct, UVMode_Offset), 0, UVMode_PropertyAddress.Address);
		}
	}

	static FGeometryScriptPrimitiveOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPrimitiveOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPrimitiveOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions");
		FGeometryScriptPrimitiveOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PolygroupMode_PropertyAddress, intPtr, "PolygroupMode");
		PolygroupMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PolygroupMode");
		PolygroupMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PolygroupMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipOrientation_PropertyAddress, intPtr, "bFlipOrientation");
		FlipOrientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipOrientation");
		FlipOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipOrientation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UVMode_PropertyAddress, intPtr, "UVMode");
		UVMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVMode");
		UVMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVMode", Classes.FEnumProperty);
		FGeometryScriptPrimitiveOptions_IsValid = intPtr != IntPtr.Zero && PolygroupMode_IsValid && FlipOrientation_IsValid && UVMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPrimitiveOptions", FGeometryScriptPrimitiveOptions_IsValid);
	}
}
