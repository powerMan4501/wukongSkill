using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScript3DGridParameters", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScript3DGridParameters
{
	private static bool SizeMethod_IsValid;

	private static FFieldAddress SizeMethod_PropertyAddress;

	private static int SizeMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScript3DGridParameters:SizeMethod")]
	public EGeometryScriptGridSizingMethod SizeMethod;

	private static bool GridCellSize_IsValid;

	private static int GridCellSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScript3DGridParameters:GridCellSize")]
	public float GridCellSize;

	private static bool GridResolution_IsValid;

	private static int GridResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScript3DGridParameters:GridResolution")]
	public int GridResolution;

	private static bool FGeometryScript3DGridParameters_IsValid;

	private static int FGeometryScript3DGridParameters_StructSize;

	public FGeometryScript3DGridParameters Copy()
	{
		return this;
	}

	public static FGeometryScript3DGridParameters FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScript3DGridParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScript3DGridParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScript3DGridParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScript3DGridParameters(nativeBuffer + arrayIndex * FGeometryScript3DGridParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScript3DGridParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScript3DGridParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScript3DGridParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScript3DGridParameters");
			return;
		}
		EnumMarshaler<EGeometryScriptGridSizingMethod>.ToNative(IntPtr.Add(nativeStruct, SizeMethod_Offset), 0, SizeMethod_PropertyAddress.Address, SizeMethod);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GridCellSize_Offset), GridCellSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GridResolution_Offset), GridResolution);
	}

	public FGeometryScript3DGridParameters(IntPtr nativeStruct)
	{
		if (!FGeometryScript3DGridParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScript3DGridParameters");
			SizeMethod = EGeometryScriptGridSizingMethod.GridCellSize;
			GridCellSize = 0f;
			GridResolution = 0;
		}
		else
		{
			SizeMethod = EnumMarshaler<EGeometryScriptGridSizingMethod>.FromNative(IntPtr.Add(nativeStruct, SizeMethod_Offset), 0, SizeMethod_PropertyAddress.Address);
			GridCellSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GridCellSize_Offset));
			GridResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GridResolution_Offset));
		}
	}

	static FGeometryScript3DGridParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScript3DGridParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScript3DGridParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScript3DGridParameters");
		FGeometryScript3DGridParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SizeMethod_PropertyAddress, intPtr, "SizeMethod");
		SizeMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SizeMethod");
		SizeMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SizeMethod", Classes.FEnumProperty);
		GridCellSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridCellSize");
		GridCellSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridCellSize", Classes.FFloatProperty);
		GridResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridResolution");
		GridResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridResolution", Classes.FIntProperty);
		FGeometryScript3DGridParameters_IsValid = intPtr != IntPtr.Zero && SizeMethod_IsValid && GridCellSize_IsValid && GridResolution_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScript3DGridParameters", FGeometryScript3DGridParameters_IsValid);
	}
}
