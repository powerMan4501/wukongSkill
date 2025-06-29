using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptXAtlasOptions
{
	private static bool MaxIterations_IsValid;

	private static int MaxIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions:MaxIterations")]
	public int MaxIterations;

	private static bool FGeometryScriptXAtlasOptions_IsValid;

	private static int FGeometryScriptXAtlasOptions_StructSize;

	public FGeometryScriptXAtlasOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptXAtlasOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptXAtlasOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptXAtlasOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptXAtlasOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptXAtlasOptions(nativeBuffer + arrayIndex * FGeometryScriptXAtlasOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptXAtlasOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptXAtlasOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptXAtlasOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxIterations_Offset), MaxIterations);
		}
	}

	public FGeometryScriptXAtlasOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptXAtlasOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions");
			MaxIterations = 0;
		}
		else
		{
			MaxIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxIterations_Offset));
		}
	}

	static FGeometryScriptXAtlasOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptXAtlasOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptXAtlasOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions");
		FGeometryScriptXAtlasOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxIterations");
		MaxIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxIterations", Classes.FIntProperty);
		FGeometryScriptXAtlasOptions_IsValid = intPtr != IntPtr.Zero && MaxIterations_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptXAtlasOptions", FGeometryScriptXAtlasOptions_IsValid);
	}
}
