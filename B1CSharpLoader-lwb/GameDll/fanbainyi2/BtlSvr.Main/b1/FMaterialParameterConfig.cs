using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MaterialParameterConfig")]
public struct FMaterialParameterConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialParameterConfig:InterpSpeed")]
	public float InterpSpeed;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialParameterConfig:AttrValueMapCurve")]
	public UCurveFloat AttrValueMapCurve;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialParameterConfig:ParameterAssociation")]
	public EMaterialParameterAssociation ParameterAssociation;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialParameterConfig:ParameterName")]
	public FName ParameterName;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialParameterConfig:ParameterLayerFunction")]
	public UMaterialFunctionInterface ParameterLayerFunction;

	private static int MaterialParameterConfig_StructSize;

	private static int MaterialParameterConfig_IsValid;

	private static bool InterpSpeed_IsValid;

	private static int InterpSpeed_Offset;

	private static bool AttrValueMapCurve_IsValid;

	private static int AttrValueMapCurve_Offset;

	private static bool ParameterAssociation_IsValid;

	private static int ParameterAssociation_Offset;

	private static FFieldAddress ParameterAssociation_PropertyAddress;

	private static bool ParameterName_IsValid;

	private static int ParameterName_Offset;

	private static bool ParameterLayerFunction_IsValid;

	private static int ParameterLayerFunction_Offset;

	public FMaterialParameterConfig Copy()
	{
		return this;
	}

	public static FMaterialParameterConfig FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialParameterConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialParameterConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialParameterConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialParameterConfig(IntPtr.Add(nativeBuffer, arrayIndex * MaterialParameterConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialParameterConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MaterialParameterConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MaterialParameterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialParameterConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpSpeed_Offset), InterpSpeed);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, AttrValueMapCurve_Offset), AttrValueMapCurve);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, ParameterAssociation_Offset), 0, ParameterAssociation_PropertyAddress.Address, ParameterAssociation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParameterName_Offset), ParameterName);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, ParameterLayerFunction_Offset), ParameterLayerFunction);
	}

	public FMaterialParameterConfig(IntPtr nativeStruct)
	{
		if (MaterialParameterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialParameterConfig");
			InterpSpeed = 0f;
			AttrValueMapCurve = null;
			ParameterAssociation = EMaterialParameterAssociation.LayerParameter;
			ParameterName = default(FName);
			ParameterLayerFunction = null;
		}
		else
		{
			InterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpSpeed_Offset));
			AttrValueMapCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, AttrValueMapCurve_Offset));
			ParameterAssociation = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, ParameterAssociation_Offset), 0, ParameterAssociation_PropertyAddress.Address);
			ParameterName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParameterName_Offset));
			ParameterLayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, ParameterLayerFunction_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MaterialParameterConfig");
		MaterialParameterConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		InterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InterpSpeed");
		InterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InterpSpeed", Classes.FFloatProperty);
		AttrValueMapCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrValueMapCurve");
		AttrValueMapCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrValueMapCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ParameterAssociation_PropertyAddress, intPtr, "ParameterAssociation");
		ParameterAssociation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParameterAssociation");
		ParameterAssociation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParameterAssociation", Classes.FEnumProperty);
		ParameterName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParameterName");
		ParameterName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParameterName", Classes.FNameProperty);
		ParameterLayerFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParameterLayerFunction");
		ParameterLayerFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParameterLayerFunction", Classes.FObjectProperty);
		MaterialParameterConfig_IsValid = ((intPtr != IntPtr.Zero && InterpSpeed_IsValid && AttrValueMapCurve_IsValid && ParameterAssociation_IsValid && ParameterName_IsValid && ParameterLayerFunction_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MaterialParameterConfig", (byte)MaterialParameterConfig_IsValid != 0);
	}

	static FMaterialParameterConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMaterialParameterConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialParameterConfig));
	}
}
