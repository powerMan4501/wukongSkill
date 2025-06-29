using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPlanarSimplifyOptions
{
	private static bool AngleThreshold_IsValid;

	private static int AngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions:AngleThreshold")]
	public float AngleThreshold;

	private static bool FGeometryScriptPlanarSimplifyOptions_IsValid;

	private static int FGeometryScriptPlanarSimplifyOptions_StructSize;

	public FGeometryScriptPlanarSimplifyOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPlanarSimplifyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPlanarSimplifyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPlanarSimplifyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPlanarSimplifyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPlanarSimplifyOptions(nativeBuffer + arrayIndex * FGeometryScriptPlanarSimplifyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPlanarSimplifyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPlanarSimplifyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPlanarSimplifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions");
		}
		else
		{
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngleThreshold_Offset), AngleThreshold);
		}
	}

	public FGeometryScriptPlanarSimplifyOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPlanarSimplifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions");
			AngleThreshold = 0f;
		}
		else
		{
			AngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngleThreshold_Offset));
		}
	}

	static FGeometryScriptPlanarSimplifyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPlanarSimplifyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPlanarSimplifyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions");
		FGeometryScriptPlanarSimplifyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		AngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngleThreshold");
		AngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngleThreshold", Classes.FFloatProperty);
		FGeometryScriptPlanarSimplifyOptions_IsValid = intPtr != IntPtr.Zero && AngleThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPlanarSimplifyOptions", FGeometryScriptPlanarSimplifyOptions_IsValid);
	}
}
