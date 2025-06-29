using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptTangentsOptions
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions:Type")]
	public EGeometryScriptTangentTypes Type;

	private static bool UVLayer_IsValid;

	private static int UVLayer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions:UVLayer")]
	public int UVLayer;

	private static bool FGeometryScriptTangentsOptions_IsValid;

	private static int FGeometryScriptTangentsOptions_StructSize;

	public FGeometryScriptTangentsOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptTangentsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptTangentsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptTangentsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptTangentsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptTangentsOptions(nativeBuffer + arrayIndex * FGeometryScriptTangentsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptTangentsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptTangentsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTangentsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions");
			return;
		}
		EnumMarshaler<EGeometryScriptTangentTypes>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UVLayer_Offset), UVLayer);
	}

	public FGeometryScriptTangentsOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTangentsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions");
			Type = EGeometryScriptTangentTypes.FastMikkT;
			UVLayer = 0;
		}
		else
		{
			Type = EnumMarshaler<EGeometryScriptTangentTypes>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			UVLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UVLayer_Offset));
		}
	}

	static FGeometryScriptTangentsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptTangentsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptTangentsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions");
		FGeometryScriptTangentsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		UVLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVLayer");
		UVLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVLayer", Classes.FIntProperty);
		FGeometryScriptTangentsOptions_IsValid = intPtr != IntPtr.Zero && Type_IsValid && UVLayer_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptTangentsOptions", FGeometryScriptTangentsOptions_IsValid);
	}
}
