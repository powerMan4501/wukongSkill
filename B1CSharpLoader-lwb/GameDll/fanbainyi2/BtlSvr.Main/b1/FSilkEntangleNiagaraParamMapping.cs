using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SilkEntangleNiagaraParamMapping")]
public struct FSilkEntangleNiagaraParamMapping
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("key是Niagara参数名，曲线x轴是计数总数, y轴是NiagaraParam值")]
	[USharpPath("/Script/b1-Managed.SilkEntangleNiagaraParamMapping:NiagaraParamName")]
	public FName NiagaraParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("配了曲线优先用曲线, 值 = 计数总数 * 比率")]
	[DisplayName("比率")]
	[USharpPath("/Script/b1-Managed.SilkEntangleNiagaraParamMapping:Ratio")]
	public float Ratio;

	[BlueprintReadWrite]
	[Tooltip("曲线x轴是计数总数, y轴是NiagaraParam值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SilkEntangleNiagaraParamMapping:MappingCurve_CountTotal")]
	public UCurveFloat MappingCurve_CountTotal;

	private static int SilkEntangleNiagaraParamMapping_StructSize;

	private static int SilkEntangleNiagaraParamMapping_IsValid;

	private static bool NiagaraParamName_IsValid;

	private static int NiagaraParamName_Offset;

	private static bool Ratio_IsValid;

	private static int Ratio_Offset;

	private static bool MappingCurve_CountTotal_IsValid;

	private static int MappingCurve_CountTotal_Offset;

	public FSilkEntangleNiagaraParamMapping Copy()
	{
		return this;
	}

	public static FSilkEntangleNiagaraParamMapping FromNative(IntPtr nativeBuffer)
	{
		return new FSilkEntangleNiagaraParamMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSilkEntangleNiagaraParamMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSilkEntangleNiagaraParamMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSilkEntangleNiagaraParamMapping(IntPtr.Add(nativeBuffer, arrayIndex * SilkEntangleNiagaraParamMapping_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSilkEntangleNiagaraParamMapping value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SilkEntangleNiagaraParamMapping_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SilkEntangleNiagaraParamMapping_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SilkEntangleNiagaraParamMapping");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, NiagaraParamName_Offset), NiagaraParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Ratio_Offset), Ratio);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, MappingCurve_CountTotal_Offset), MappingCurve_CountTotal);
	}

	public FSilkEntangleNiagaraParamMapping(IntPtr nativeStruct)
	{
		if (SilkEntangleNiagaraParamMapping_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SilkEntangleNiagaraParamMapping");
			NiagaraParamName = default(FName);
			Ratio = 0f;
			MappingCurve_CountTotal = null;
		}
		else
		{
			NiagaraParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, NiagaraParamName_Offset));
			Ratio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Ratio_Offset));
			MappingCurve_CountTotal = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, MappingCurve_CountTotal_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SilkEntangleNiagaraParamMapping");
		SilkEntangleNiagaraParamMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		NiagaraParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NiagaraParamName");
		NiagaraParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NiagaraParamName", Classes.FNameProperty);
		Ratio_Offset = NativeReflection.GetPropertyOffset(intPtr, "Ratio");
		Ratio_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Ratio", Classes.FFloatProperty);
		MappingCurve_CountTotal_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappingCurve_CountTotal");
		MappingCurve_CountTotal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappingCurve_CountTotal", Classes.FObjectProperty);
		SilkEntangleNiagaraParamMapping_IsValid = ((intPtr != IntPtr.Zero && NiagaraParamName_IsValid && Ratio_IsValid && MappingCurve_CountTotal_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SilkEntangleNiagaraParamMapping", (byte)SilkEntangleNiagaraParamMapping_IsValid != 0);
	}

	static FSilkEntangleNiagaraParamMapping()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSilkEntangleNiagaraParamMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSilkEntangleNiagaraParamMapping));
	}
}
