using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPNTessellateOptions
{
	private static bool RecomputeNormals_IsValid;

	private static FFieldAddress RecomputeNormals_PropertyAddress;

	private static int RecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions:bRecomputeNormals")]
	public bool RecomputeNormals;

	private static bool FGeometryScriptPNTessellateOptions_IsValid;

	private static int FGeometryScriptPNTessellateOptions_StructSize;

	public FGeometryScriptPNTessellateOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPNTessellateOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPNTessellateOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPNTessellateOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPNTessellateOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPNTessellateOptions(nativeBuffer + arrayIndex * FGeometryScriptPNTessellateOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPNTessellateOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPNTessellateOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPNTessellateOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address, RecomputeNormals);
		}
	}

	public FGeometryScriptPNTessellateOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPNTessellateOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions");
			RecomputeNormals = false;
		}
		else
		{
			RecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address);
		}
	}

	static FGeometryScriptPNTessellateOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPNTessellateOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPNTessellateOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions");
		FGeometryScriptPNTessellateOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_PropertyAddress, intPtr, "bRecomputeNormals");
		RecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeNormals");
		RecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeNormals", Classes.FBoolProperty);
		FGeometryScriptPNTessellateOptions_IsValid = intPtr != IntPtr.Zero && RecomputeNormals_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPNTessellateOptions", FGeometryScriptPNTessellateOptions_IsValid);
	}
}
