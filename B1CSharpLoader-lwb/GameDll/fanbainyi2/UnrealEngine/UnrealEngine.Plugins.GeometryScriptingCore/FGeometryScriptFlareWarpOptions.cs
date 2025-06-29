using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptFlareWarpOptions
{
	private static bool SymmetricExtents_IsValid;

	private static FFieldAddress SymmetricExtents_PropertyAddress;

	private static int SymmetricExtents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions:bSymmetricExtents")]
	public bool SymmetricExtents;

	private static bool LowerExtent_IsValid;

	private static int LowerExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions:LowerExtent")]
	public float LowerExtent;

	private static bool FlareType_IsValid;

	private static FFieldAddress FlareType_PropertyAddress;

	private static int FlareType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions:FlareType")]
	public EGeometryScriptFlareType FlareType;

	private static bool FGeometryScriptFlareWarpOptions_IsValid;

	private static int FGeometryScriptFlareWarpOptions_StructSize;

	public FGeometryScriptFlareWarpOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptFlareWarpOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptFlareWarpOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptFlareWarpOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptFlareWarpOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptFlareWarpOptions(nativeBuffer + arrayIndex * FGeometryScriptFlareWarpOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptFlareWarpOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptFlareWarpOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptFlareWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SymmetricExtents_Offset), 0, SymmetricExtents_PropertyAddress.Address, SymmetricExtents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowerExtent_Offset), LowerExtent);
		EnumMarshaler<EGeometryScriptFlareType>.ToNative(IntPtr.Add(nativeStruct, FlareType_Offset), 0, FlareType_PropertyAddress.Address, FlareType);
	}

	public FGeometryScriptFlareWarpOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptFlareWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions");
			SymmetricExtents = false;
			LowerExtent = 0f;
			FlareType = EGeometryScriptFlareType.SinMode;
		}
		else
		{
			SymmetricExtents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SymmetricExtents_Offset), 0, SymmetricExtents_PropertyAddress.Address);
			LowerExtent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LowerExtent_Offset));
			FlareType = EnumMarshaler<EGeometryScriptFlareType>.FromNative(IntPtr.Add(nativeStruct, FlareType_Offset), 0, FlareType_PropertyAddress.Address);
		}
	}

	static FGeometryScriptFlareWarpOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptFlareWarpOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptFlareWarpOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions");
		FGeometryScriptFlareWarpOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SymmetricExtents_PropertyAddress, intPtr, "bSymmetricExtents");
		SymmetricExtents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSymmetricExtents");
		SymmetricExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSymmetricExtents", Classes.FBoolProperty);
		LowerExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerExtent");
		LowerExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FlareType_PropertyAddress, intPtr, "FlareType");
		FlareType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FlareType");
		FlareType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FlareType", Classes.FEnumProperty);
		FGeometryScriptFlareWarpOptions_IsValid = intPtr != IntPtr.Zero && SymmetricExtents_IsValid && LowerExtent_IsValid && FlareType_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptFlareWarpOptions", FGeometryScriptFlareWarpOptions_IsValid);
	}
}
