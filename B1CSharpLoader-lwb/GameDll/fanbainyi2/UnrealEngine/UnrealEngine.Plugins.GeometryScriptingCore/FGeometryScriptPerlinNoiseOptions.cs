using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPerlinNoiseOptions
{
	private static bool BaseLayer_IsValid;

	private static int BaseLayer_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions:BaseLayer")]
	public FGeometryScriptPerlinNoiseLayerOptions BaseLayer;

	private static bool ApplyAlongNormal_IsValid;

	private static FFieldAddress ApplyAlongNormal_PropertyAddress;

	private static int ApplyAlongNormal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions:bApplyAlongNormal")]
	public bool ApplyAlongNormal;

	private static bool FGeometryScriptPerlinNoiseOptions_IsValid;

	private static int FGeometryScriptPerlinNoiseOptions_StructSize;

	public FGeometryScriptPerlinNoiseOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPerlinNoiseOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPerlinNoiseOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPerlinNoiseOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPerlinNoiseOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPerlinNoiseOptions(nativeBuffer + arrayIndex * FGeometryScriptPerlinNoiseOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPerlinNoiseOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPerlinNoiseOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPerlinNoiseOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions");
			return;
		}
		FGeometryScriptPerlinNoiseLayerOptions.ToNative(IntPtr.Add(nativeStruct, BaseLayer_Offset), BaseLayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyAlongNormal_Offset), 0, ApplyAlongNormal_PropertyAddress.Address, ApplyAlongNormal);
	}

	public FGeometryScriptPerlinNoiseOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPerlinNoiseOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions");
			BaseLayer = default(FGeometryScriptPerlinNoiseLayerOptions);
			ApplyAlongNormal = false;
		}
		else
		{
			BaseLayer = FGeometryScriptPerlinNoiseLayerOptions.FromNative(IntPtr.Add(nativeStruct, BaseLayer_Offset));
			ApplyAlongNormal = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyAlongNormal_Offset), 0, ApplyAlongNormal_PropertyAddress.Address);
		}
	}

	static FGeometryScriptPerlinNoiseOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPerlinNoiseOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPerlinNoiseOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions");
		FGeometryScriptPerlinNoiseOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		BaseLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseLayer");
		BaseLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyAlongNormal_PropertyAddress, intPtr, "bApplyAlongNormal");
		ApplyAlongNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyAlongNormal");
		ApplyAlongNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyAlongNormal", Classes.FBoolProperty);
		FGeometryScriptPerlinNoiseOptions_IsValid = intPtr != IntPtr.Zero && BaseLayer_IsValid && ApplyAlongNormal_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseOptions", FGeometryScriptPerlinNoiseOptions_IsValid);
	}
}
