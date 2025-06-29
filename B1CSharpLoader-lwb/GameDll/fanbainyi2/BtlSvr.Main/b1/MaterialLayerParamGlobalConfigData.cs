using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MaterialLayerParamGlobalConfigData")]
public struct MaterialLayerParamGlobalConfigData
{
	[DisplayName("参数评估类型")]
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamGlobalConfigData:ParamEvaluateType")]
	public EMaterialLayerParamEvaluateType ParamEvaluateType;

	[DisplayName("float类型参数ClampMin")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamGlobalConfigData:ClampMin")]
	public float ClampMin;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("float类型参数ClampMax")]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamGlobalConfigData:ClampMax")]
	public float ClampMax;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("AutoBlendOut速度曲线")]
	[USharpPath("/Script/b1-Managed.MaterialLayerParamGlobalConfigData:AutoBlendOutSpeedCurve")]
	public UCurveFloat AutoBlendOutSpeedCurve;

	private static int MaterialLayerParamGlobalConfigData_StructSize;

	private static int MaterialLayerParamGlobalConfigData_IsValid;

	private static bool ParamEvaluateType_IsValid;

	private static int ParamEvaluateType_Offset;

	private static FFieldAddress ParamEvaluateType_PropertyAddress;

	private static bool ClampMin_IsValid;

	private static int ClampMin_Offset;

	private static bool ClampMax_IsValid;

	private static int ClampMax_Offset;

	private static bool AutoBlendOutSpeedCurve_IsValid;

	private static int AutoBlendOutSpeedCurve_Offset;

	public MaterialLayerParamGlobalConfigData Copy()
	{
		return this;
	}

	public static MaterialLayerParamGlobalConfigData FromNative(IntPtr nativeBuffer)
	{
		return new MaterialLayerParamGlobalConfigData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MaterialLayerParamGlobalConfigData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MaterialLayerParamGlobalConfigData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MaterialLayerParamGlobalConfigData(IntPtr.Add(nativeBuffer, arrayIndex * MaterialLayerParamGlobalConfigData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MaterialLayerParamGlobalConfigData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MaterialLayerParamGlobalConfigData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MaterialLayerParamGlobalConfigData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialLayerParamGlobalConfigData");
			return;
		}
		EnumMarshaler<EMaterialLayerParamEvaluateType>.ToNative(IntPtr.Add(nativeStruct, ParamEvaluateType_Offset), 0, ParamEvaluateType_PropertyAddress.Address, ParamEvaluateType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMin_Offset), ClampMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMax_Offset), ClampMax);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, AutoBlendOutSpeedCurve_Offset), AutoBlendOutSpeedCurve);
	}

	public MaterialLayerParamGlobalConfigData(IntPtr nativeStruct)
	{
		if (MaterialLayerParamGlobalConfigData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MaterialLayerParamGlobalConfigData");
			ParamEvaluateType = EMaterialLayerParamEvaluateType.None;
			ClampMin = 0f;
			ClampMax = 0f;
			AutoBlendOutSpeedCurve = null;
		}
		else
		{
			ParamEvaluateType = EnumMarshaler<EMaterialLayerParamEvaluateType>.FromNative(IntPtr.Add(nativeStruct, ParamEvaluateType_Offset), 0, ParamEvaluateType_PropertyAddress.Address);
			ClampMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMin_Offset));
			ClampMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMax_Offset));
			AutoBlendOutSpeedCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, AutoBlendOutSpeedCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MaterialLayerParamGlobalConfigData");
		MaterialLayerParamGlobalConfigData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ParamEvaluateType_PropertyAddress, intPtr, "ParamEvaluateType");
		ParamEvaluateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamEvaluateType");
		ParamEvaluateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamEvaluateType", Classes.FEnumProperty);
		ClampMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ClampMin");
		ClampMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ClampMin", Classes.FFloatProperty);
		ClampMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ClampMax");
		ClampMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ClampMax", Classes.FFloatProperty);
		AutoBlendOutSpeedCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoBlendOutSpeedCurve");
		AutoBlendOutSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoBlendOutSpeedCurve", Classes.FObjectProperty);
		MaterialLayerParamGlobalConfigData_IsValid = ((intPtr != IntPtr.Zero && ParamEvaluateType_IsValid && ClampMin_IsValid && ClampMax_IsValid && AutoBlendOutSpeedCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MaterialLayerParamGlobalConfigData", (byte)MaterialLayerParamGlobalConfigData_IsValid != 0);
	}

	static MaterialLayerParamGlobalConfigData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MaterialLayerParamGlobalConfigData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MaterialLayerParamGlobalConfigData));
	}
}
