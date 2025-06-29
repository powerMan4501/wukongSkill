using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MaterialLayerParamData")]
public struct MaterialLayerParamData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:LayerKeyData")]
	public MaterialLayerKeyData LayerKeyData;

	[UProperty]
	[EditAnywhere]
	[DisplayName("参数类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:ParamType")]
	public EMaterialLayerParamType ParamType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Scalar值")]
	[UMeta(MDProp.EditCondition, "ParamType == EMaterialLayerParamType::Scalar")]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:ScalarValue")]
	public float ScalarValue;

	[UMeta(MDProp.EditCondition, "ParamType == EMaterialLayerParamType::Color")]
	[DisplayName("Color值")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:ColorValue")]
	public FLinearColor ColorValue;

	[UMeta(MDProp.EditCondition, "ParamType == EMaterialLayerParamType::ScalarCurve")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Scalar曲线")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:ScalarCurve")]
	public UCurveFloat ScalarCurve;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Color曲线")]
	[UMeta(MDProp.EditCondition, "ParamType == EMaterialLayerParamType::ColorCurve")]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:ColorCurve")]
	public UCurveLinearColor ColorCurve;

	[DisplayName("是否自动BlendOut")]
	[UMeta(MDProp.EditCondition, "ParamType == EMaterialLayerParamType::ScalarCurve || ParamType == EMaterialLayerParamType::ColorCurve")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:bEnableAutoBlendOut")]
	public bool bEnableAutoBlendOut;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("自动BlendOut目标Scalar值")]
	[UMeta(MDProp.EditCondition, "bEnableAutoBlendOut && ParamType == EMaterialLayerParamType::ScalarCurve")]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:AutoBlendOutScalarValue")]
	public float AutoBlendOutScalarValue;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("自动BlendOut目标Color值")]
	[UMeta(MDProp.EditCondition, "bEnableAutoBlendOut && ParamType == EMaterialLayerParamType::ColorCurve")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamData:AutoBlendOutColorValue")]
	public FLinearColor AutoBlendOutColorValue;

	private static int MaterialLayerParamData_StructSize;

	private static int MaterialLayerParamData_IsValid;

	private static bool LayerKeyData_IsValid;

	private static int LayerKeyData_Offset;

	private static bool ParamType_IsValid;

	private static int ParamType_Offset;

	private static FFieldAddress ParamType_PropertyAddress;

	private static bool ScalarValue_IsValid;

	private static int ScalarValue_Offset;

	private static bool ColorValue_IsValid;

	private static int ColorValue_Offset;

	private static bool ScalarCurve_IsValid;

	private static int ScalarCurve_Offset;

	private static bool ColorCurve_IsValid;

	private static int ColorCurve_Offset;

	private static bool bEnableAutoBlendOut_IsValid;

	private static int bEnableAutoBlendOut_Offset;

	private static FFieldAddress bEnableAutoBlendOut_PropertyAddress;

	private static bool AutoBlendOutScalarValue_IsValid;

	private static int AutoBlendOutScalarValue_Offset;

	private static bool AutoBlendOutColorValue_IsValid;

	private static int AutoBlendOutColorValue_Offset;

	public MaterialLayerParamData Copy()
	{
		return this;
	}

	public static MaterialLayerParamData FromNative(IntPtr nativeBuffer)
	{
		return new MaterialLayerParamData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MaterialLayerParamData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MaterialLayerParamData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MaterialLayerParamData(IntPtr.Add(nativeBuffer, arrayIndex * MaterialLayerParamData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MaterialLayerParamData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MaterialLayerParamData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MaterialLayerParamData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialLayerParamData");
			return;
		}
		BlittableTypeMarshaler<MaterialLayerKeyData>.ToNative(IntPtr.Add(nativeStruct, LayerKeyData_Offset), LayerKeyData);
		EnumMarshaler<EMaterialLayerParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScalarValue_Offset), ScalarValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ColorValue_Offset), ColorValue);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, ScalarCurve_Offset), ScalarCurve);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, ColorCurve_Offset), ColorCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableAutoBlendOut_Offset), 0, bEnableAutoBlendOut_PropertyAddress.Address, bEnableAutoBlendOut);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AutoBlendOutScalarValue_Offset), AutoBlendOutScalarValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, AutoBlendOutColorValue_Offset), AutoBlendOutColorValue);
	}

	public MaterialLayerParamData(IntPtr nativeStruct)
	{
		if (MaterialLayerParamData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialLayerParamData");
			LayerKeyData = default(MaterialLayerKeyData);
			ParamType = EMaterialLayerParamType.None;
			ScalarValue = 0f;
			ColorValue = default(FLinearColor);
			ScalarCurve = null;
			ColorCurve = null;
			bEnableAutoBlendOut = false;
			AutoBlendOutScalarValue = 0f;
			AutoBlendOutColorValue = default(FLinearColor);
		}
		else
		{
			LayerKeyData = BlittableTypeMarshaler<MaterialLayerKeyData>.FromNative(IntPtr.Add(nativeStruct, LayerKeyData_Offset));
			ParamType = EnumMarshaler<EMaterialLayerParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ScalarValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScalarValue_Offset));
			ColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ColorValue_Offset));
			ScalarCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, ScalarCurve_Offset));
			ColorCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, ColorCurve_Offset));
			bEnableAutoBlendOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableAutoBlendOut_Offset), 0, bEnableAutoBlendOut_PropertyAddress.Address);
			AutoBlendOutScalarValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AutoBlendOutScalarValue_Offset));
			AutoBlendOutColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, AutoBlendOutColorValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MaterialLayerParamData");
		MaterialLayerParamData_StructSize = NativeReflection.GetStructSize(intPtr);
		LayerKeyData_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerKeyData");
		LayerKeyData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerKeyData", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ScalarValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarValue");
		ScalarValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarValue", Classes.FFloatProperty);
		ColorValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorValue");
		ColorValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorValue", Classes.FStructProperty);
		ScalarCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarCurve");
		ScalarCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarCurve", Classes.FObjectProperty);
		ColorCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorCurve");
		ColorCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bEnableAutoBlendOut_PropertyAddress, intPtr, "bEnableAutoBlendOut");
		bEnableAutoBlendOut_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableAutoBlendOut");
		bEnableAutoBlendOut_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableAutoBlendOut", Classes.FBoolProperty);
		AutoBlendOutScalarValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoBlendOutScalarValue");
		AutoBlendOutScalarValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoBlendOutScalarValue", Classes.FFloatProperty);
		AutoBlendOutColorValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoBlendOutColorValue");
		AutoBlendOutColorValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoBlendOutColorValue", Classes.FStructProperty);
		MaterialLayerParamData_IsValid = ((intPtr != IntPtr.Zero && LayerKeyData_IsValid && ParamType_IsValid && ScalarValue_IsValid && ColorValue_IsValid && ScalarCurve_IsValid && ColorCurve_IsValid && bEnableAutoBlendOut_IsValid && AutoBlendOutScalarValue_IsValid && AutoBlendOutColorValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MaterialLayerParamData", (byte)MaterialLayerParamData_IsValid != 0);
	}

	static MaterialLayerParamData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MaterialLayerParamData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MaterialLayerParamData));
	}
}
