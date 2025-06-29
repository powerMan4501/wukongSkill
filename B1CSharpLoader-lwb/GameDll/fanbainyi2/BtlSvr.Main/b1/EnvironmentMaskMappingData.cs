using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData")]
public struct EnvironmentMaskMappingData
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData:ParamName")]
	public string ParamName;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData:LayerMappingName_Layer")]
	public string LayerMappingName_Layer;

	[Tooltip("每秒累积量，用于下雪/下雨等天气")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0.0f")]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData:AccumulateSpeed")]
	public float AccumulateSpeed;

	[BlueprintReadOnly]
	[Tooltip("累积量最大值")]
	[UMeta(MDProp.ClampMin, "0.0f")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData:AccumulateMaxValue")]
	public float AccumulateMaxValue;

	[UProperty]
	[EditAnywhere]
	[Tooltip("每秒衰减量")]
	[UMeta(MDProp.ClampMin, "0.0f")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskMappingData:FadeSpeed")]
	public float FadeSpeed;

	private static int EnvironmentMaskMappingData_StructSize;

	private static int EnvironmentMaskMappingData_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool LayerMappingName_Layer_IsValid;

	private static int LayerMappingName_Layer_Offset;

	private static bool AccumulateSpeed_IsValid;

	private static int AccumulateSpeed_Offset;

	private static bool AccumulateMaxValue_IsValid;

	private static int AccumulateMaxValue_Offset;

	private static bool FadeSpeed_IsValid;

	private static int FadeSpeed_Offset;

	public EnvironmentMaskMappingData Copy()
	{
		return this;
	}

	public static EnvironmentMaskMappingData FromNative(IntPtr nativeBuffer)
	{
		return new EnvironmentMaskMappingData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, EnvironmentMaskMappingData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static EnvironmentMaskMappingData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new EnvironmentMaskMappingData(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentMaskMappingData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, EnvironmentMaskMappingData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentMaskMappingData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvironmentMaskMappingData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentMaskMappingData");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LayerMappingName_Layer_Offset), LayerMappingName_Layer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AccumulateSpeed_Offset), AccumulateSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AccumulateMaxValue_Offset), AccumulateMaxValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FadeSpeed_Offset), FadeSpeed);
	}

	public EnvironmentMaskMappingData(IntPtr nativeStruct)
	{
		if (EnvironmentMaskMappingData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentMaskMappingData");
			ParamName = null;
			LayerMappingName_Layer = null;
			AccumulateSpeed = 0f;
			AccumulateMaxValue = 0f;
			FadeSpeed = 0f;
		}
		else
		{
			ParamName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			LayerMappingName_Layer = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LayerMappingName_Layer_Offset));
			AccumulateSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AccumulateSpeed_Offset));
			AccumulateMaxValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AccumulateMaxValue_Offset));
			FadeSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FadeSpeed_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentMaskMappingData");
		EnvironmentMaskMappingData_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FStrProperty);
		LayerMappingName_Layer_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerMappingName_Layer");
		LayerMappingName_Layer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerMappingName_Layer", Classes.FStrProperty);
		AccumulateSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccumulateSpeed");
		AccumulateSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccumulateSpeed", Classes.FFloatProperty);
		AccumulateMaxValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccumulateMaxValue");
		AccumulateMaxValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccumulateMaxValue", Classes.FFloatProperty);
		FadeSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "FadeSpeed");
		FadeSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FadeSpeed", Classes.FFloatProperty);
		EnvironmentMaskMappingData_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && LayerMappingName_Layer_IsValid && AccumulateSpeed_IsValid && AccumulateMaxValue_IsValid && FadeSpeed_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvironmentMaskMappingData", (byte)EnvironmentMaskMappingData_IsValid != 0);
	}

	static EnvironmentMaskMappingData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(EnvironmentMaskMappingData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(EnvironmentMaskMappingData));
	}
}
