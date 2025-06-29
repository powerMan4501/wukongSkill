using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptNaniteOptions
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions:bEnabled")]
	public bool Enabled;

	private static bool FallbackPercentTriangles_IsValid;

	private static int FallbackPercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions:FallbackPercentTriangles")]
	public float FallbackPercentTriangles;

	private static bool FallbackRelativeError_IsValid;

	private static int FallbackRelativeError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions:FallbackRelativeError")]
	public float FallbackRelativeError;

	private static bool FGeometryScriptNaniteOptions_IsValid;

	private static int FGeometryScriptNaniteOptions_StructSize;

	public FGeometryScriptNaniteOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptNaniteOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptNaniteOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptNaniteOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptNaniteOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptNaniteOptions(nativeBuffer + arrayIndex * FGeometryScriptNaniteOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptNaniteOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptNaniteOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptNaniteOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FallbackPercentTriangles_Offset), FallbackPercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FallbackRelativeError_Offset), FallbackRelativeError);
	}

	public FGeometryScriptNaniteOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptNaniteOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions");
			Enabled = false;
			FallbackPercentTriangles = 0f;
			FallbackRelativeError = 0f;
		}
		else
		{
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			FallbackPercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FallbackPercentTriangles_Offset));
			FallbackRelativeError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FallbackRelativeError_Offset));
		}
	}

	static FGeometryScriptNaniteOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptNaniteOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptNaniteOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions");
		FGeometryScriptNaniteOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FallbackPercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackPercentTriangles");
		FallbackPercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackPercentTriangles", Classes.FFloatProperty);
		FallbackRelativeError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackRelativeError");
		FallbackRelativeError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackRelativeError", Classes.FFloatProperty);
		FGeometryScriptNaniteOptions_IsValid = intPtr != IntPtr.Zero && Enabled_IsValid && FallbackPercentTriangles_IsValid && FallbackRelativeError_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptNaniteOptions", FGeometryScriptNaniteOptions_IsValid);
	}
}
