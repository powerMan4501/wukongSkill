using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptBendWarpOptions
{
	private static bool SymmetricExtents_IsValid;

	private static FFieldAddress SymmetricExtents_PropertyAddress;

	private static int SymmetricExtents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions:bSymmetricExtents")]
	public bool SymmetricExtents;

	private static bool LowerExtent_IsValid;

	private static int LowerExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions:LowerExtent")]
	public float LowerExtent;

	private static bool Bidirectional_IsValid;

	private static FFieldAddress Bidirectional_PropertyAddress;

	private static int Bidirectional_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions:bBidirectional")]
	public bool Bidirectional;

	private static bool FGeometryScriptBendWarpOptions_IsValid;

	private static int FGeometryScriptBendWarpOptions_StructSize;

	public FGeometryScriptBendWarpOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptBendWarpOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptBendWarpOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptBendWarpOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptBendWarpOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptBendWarpOptions(nativeBuffer + arrayIndex * FGeometryScriptBendWarpOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptBendWarpOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptBendWarpOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptBendWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SymmetricExtents_Offset), 0, SymmetricExtents_PropertyAddress.Address, SymmetricExtents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowerExtent_Offset), LowerExtent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bidirectional_Offset), 0, Bidirectional_PropertyAddress.Address, Bidirectional);
	}

	public FGeometryScriptBendWarpOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptBendWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions");
			SymmetricExtents = false;
			LowerExtent = 0f;
			Bidirectional = false;
		}
		else
		{
			SymmetricExtents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SymmetricExtents_Offset), 0, SymmetricExtents_PropertyAddress.Address);
			LowerExtent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LowerExtent_Offset));
			Bidirectional = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bidirectional_Offset), 0, Bidirectional_PropertyAddress.Address);
		}
	}

	static FGeometryScriptBendWarpOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptBendWarpOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptBendWarpOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions");
		FGeometryScriptBendWarpOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SymmetricExtents_PropertyAddress, intPtr, "bSymmetricExtents");
		SymmetricExtents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSymmetricExtents");
		SymmetricExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSymmetricExtents", Classes.FBoolProperty);
		LowerExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerExtent");
		LowerExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Bidirectional_PropertyAddress, intPtr, "bBidirectional");
		Bidirectional_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBidirectional");
		Bidirectional_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBidirectional", Classes.FBoolProperty);
		FGeometryScriptBendWarpOptions_IsValid = intPtr != IntPtr.Zero && SymmetricExtents_IsValid && LowerExtent_IsValid && Bidirectional_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptBendWarpOptions", FGeometryScriptBendWarpOptions_IsValid);
	}
}
