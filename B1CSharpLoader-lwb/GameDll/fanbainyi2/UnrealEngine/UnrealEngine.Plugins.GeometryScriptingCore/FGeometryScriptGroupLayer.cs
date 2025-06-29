using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptGroupLayer", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptGroupLayer
{
	private static bool DefaultLayer_IsValid;

	private static FFieldAddress DefaultLayer_PropertyAddress;

	private static int DefaultLayer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptGroupLayer:bDefaultLayer")]
	public bool DefaultLayer;

	private static bool ExtendedLayerIndex_IsValid;

	private static int ExtendedLayerIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptGroupLayer:ExtendedLayerIndex")]
	public int ExtendedLayerIndex;

	private static bool FGeometryScriptGroupLayer_IsValid;

	private static int FGeometryScriptGroupLayer_StructSize;

	public FGeometryScriptGroupLayer Copy()
	{
		return this;
	}

	public static FGeometryScriptGroupLayer FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptGroupLayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptGroupLayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptGroupLayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptGroupLayer(nativeBuffer + arrayIndex * FGeometryScriptGroupLayer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptGroupLayer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptGroupLayer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptGroupLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptGroupLayer");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultLayer_Offset), 0, DefaultLayer_PropertyAddress.Address, DefaultLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExtendedLayerIndex_Offset), ExtendedLayerIndex);
	}

	public FGeometryScriptGroupLayer(IntPtr nativeStruct)
	{
		if (!FGeometryScriptGroupLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptGroupLayer");
			DefaultLayer = false;
			ExtendedLayerIndex = 0;
		}
		else
		{
			DefaultLayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultLayer_Offset), 0, DefaultLayer_PropertyAddress.Address);
			ExtendedLayerIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExtendedLayerIndex_Offset));
		}
	}

	static FGeometryScriptGroupLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptGroupLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptGroupLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptGroupLayer");
		FGeometryScriptGroupLayer_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DefaultLayer_PropertyAddress, intPtr, "bDefaultLayer");
		DefaultLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDefaultLayer");
		DefaultLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDefaultLayer", Classes.FBoolProperty);
		ExtendedLayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtendedLayerIndex");
		ExtendedLayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtendedLayerIndex", Classes.FIntProperty);
		FGeometryScriptGroupLayer_IsValid = intPtr != IntPtr.Zero && DefaultLayer_IsValid && ExtendedLayerIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptGroupLayer", FGeometryScriptGroupLayer_IsValid);
	}
}
