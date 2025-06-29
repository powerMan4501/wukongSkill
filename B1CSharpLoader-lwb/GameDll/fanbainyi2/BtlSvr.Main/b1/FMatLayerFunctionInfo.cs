using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MatLayerFunctionInfo")]
public struct FMatLayerFunctionInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatLayerFunctionInfo:Association")]
	public EMaterialParameterAssociation Association;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatLayerFunctionInfo:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	private static int MatLayerFunctionInfo_StructSize;

	private static int MatLayerFunctionInfo_IsValid;

	private static bool Association_IsValid;

	private static int Association_Offset;

	private static FFieldAddress Association_PropertyAddress;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

	public FMatLayerFunctionInfo Copy()
	{
		return this;
	}

	public static FMatLayerFunctionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMatLayerFunctionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMatLayerFunctionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMatLayerFunctionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMatLayerFunctionInfo(IntPtr.Add(nativeBuffer, arrayIndex * MatLayerFunctionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMatLayerFunctionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MatLayerFunctionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MatLayerFunctionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatLayerFunctionInfo");
			return;
		}
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
	}

	public FMatLayerFunctionInfo(IntPtr nativeStruct)
	{
		if (MatLayerFunctionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatLayerFunctionInfo");
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
		}
		else
		{
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MatLayerFunctionInfo");
		MatLayerFunctionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflection.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Association", Classes.FEnumProperty);
		LayerFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		MatLayerFunctionInfo_IsValid = ((intPtr != IntPtr.Zero && Association_IsValid && LayerFunction_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MatLayerFunctionInfo", (byte)MatLayerFunctionInfo_IsValid != 0);
	}

	static FMatLayerFunctionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMatLayerFunctionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatLayerFunctionInfo));
	}
}
