using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPolygroupSimplifyOptions
{
	private static bool AngleThreshold_IsValid;

	private static int AngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions:AngleThreshold")]
	public float AngleThreshold;

	private static bool FGeometryScriptPolygroupSimplifyOptions_IsValid;

	private static int FGeometryScriptPolygroupSimplifyOptions_StructSize;

	public FGeometryScriptPolygroupSimplifyOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPolygroupSimplifyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPolygroupSimplifyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPolygroupSimplifyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPolygroupSimplifyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPolygroupSimplifyOptions(nativeBuffer + arrayIndex * FGeometryScriptPolygroupSimplifyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPolygroupSimplifyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPolygroupSimplifyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPolygroupSimplifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions");
		}
		else
		{
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngleThreshold_Offset), AngleThreshold);
		}
	}

	public FGeometryScriptPolygroupSimplifyOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPolygroupSimplifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions");
			AngleThreshold = 0f;
		}
		else
		{
			AngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngleThreshold_Offset));
		}
	}

	static FGeometryScriptPolygroupSimplifyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPolygroupSimplifyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPolygroupSimplifyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions");
		FGeometryScriptPolygroupSimplifyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		AngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngleThreshold");
		AngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngleThreshold", Classes.FFloatProperty);
		FGeometryScriptPolygroupSimplifyOptions_IsValid = intPtr != IntPtr.Zero && AngleThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPolygroupSimplifyOptions", FGeometryScriptPolygroupSimplifyOptions_IsValid);
	}
}
