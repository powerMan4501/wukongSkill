using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptTwistWarpOptions
{
	private static bool SymmetricExtents_IsValid;

	private static FFieldAddress SymmetricExtents_PropertyAddress;

	private static int SymmetricExtents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions:bSymmetricExtents")]
	public bool SymmetricExtents;

	private static bool LowerExtent_IsValid;

	private static int LowerExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions:LowerExtent")]
	public float LowerExtent;

	private static bool Bidirectional_IsValid;

	private static FFieldAddress Bidirectional_PropertyAddress;

	private static int Bidirectional_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions:bBidirectional")]
	public bool Bidirectional;

	private static bool FGeometryScriptTwistWarpOptions_IsValid;

	private static int FGeometryScriptTwistWarpOptions_StructSize;

	public FGeometryScriptTwistWarpOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptTwistWarpOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptTwistWarpOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptTwistWarpOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptTwistWarpOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptTwistWarpOptions(nativeBuffer + arrayIndex * FGeometryScriptTwistWarpOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptTwistWarpOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptTwistWarpOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTwistWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SymmetricExtents_Offset), 0, SymmetricExtents_PropertyAddress.Address, SymmetricExtents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowerExtent_Offset), LowerExtent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bidirectional_Offset), 0, Bidirectional_PropertyAddress.Address, Bidirectional);
	}

	public FGeometryScriptTwistWarpOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTwistWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions");
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

	static FGeometryScriptTwistWarpOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptTwistWarpOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptTwistWarpOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions");
		FGeometryScriptTwistWarpOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SymmetricExtents_PropertyAddress, intPtr, "bSymmetricExtents");
		SymmetricExtents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSymmetricExtents");
		SymmetricExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSymmetricExtents", Classes.FBoolProperty);
		LowerExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerExtent");
		LowerExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Bidirectional_PropertyAddress, intPtr, "bBidirectional");
		Bidirectional_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBidirectional");
		Bidirectional_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBidirectional", Classes.FBoolProperty);
		FGeometryScriptTwistWarpOptions_IsValid = intPtr != IntPtr.Zero && SymmetricExtents_IsValid && LowerExtent_IsValid && Bidirectional_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptTwistWarpOptions", FGeometryScriptTwistWarpOptions_IsValid);
	}
}
