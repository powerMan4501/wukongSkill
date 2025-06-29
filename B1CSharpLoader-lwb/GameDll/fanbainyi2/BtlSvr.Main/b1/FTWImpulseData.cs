using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FTWImpulseData")]
public struct FTWImpulseData
{
	[BlueprintReadWrite]
	[Category("TigerWoods Impulse Data")]
	[DisplayName("向量使用类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:VectorUseType")]
	public TWVectorUseType VectorUseType;

	[AllowPrivateAccess]
	[DisplayName("是否启用范围随机向量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("TigerWoods Impulse Data")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:bUseRandomVector")]
	private bool bUseRandomVector;

	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[DisplayName("基准向量-低值")]
	[Category("TigerWoods Impulse Data")]
	[UMeta(MDProp.EditCondition, "VectorUseType == TWVectorUseType::UseVectorBase")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:VectorBaseLow")]
	private FVector VectorBaseLow;

	[AllowPrivateAccess]
	[UProperty]
	[Category("TigerWoods Impulse Data")]
	[DisplayName("基准向量-高值")]
	[UMeta(MDProp.EditCondition, "VectorUseType == TWVectorUseType::UseVectorBase && bUseRandomVector")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:VectorBaseHigh")]
	private FVector VectorBaseHigh;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("TigerWoods Impulse Data")]
	[DisplayName("Z轴振幅倍率")]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:ZAmplitudeRatio")]
	public float ZAmplitudeRatio;

	[Category("TigerWoods Impulse Data")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("向量混合曲线（距离-向量缩放倍率）")]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:BlendCurve")]
	public UCurveFloat BlendCurve;

	[Category("TigerWoods Impulse Data")]
	[DisplayName("标量乘数")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FTWImpulseData:ScalarMultiplier")]
	public float ScalarMultiplier;

	private static int FTWImpulseData_StructSize;

	private static int FTWImpulseData_IsValid;

	private static bool VectorUseType_IsValid;

	private static int VectorUseType_Offset;

	private static FFieldAddress VectorUseType_PropertyAddress;

	private static bool bUseRandomVector_IsValid;

	private static int bUseRandomVector_Offset;

	private static FFieldAddress bUseRandomVector_PropertyAddress;

	private static bool VectorBaseLow_IsValid;

	private static int VectorBaseLow_Offset;

	private static bool VectorBaseHigh_IsValid;

	private static int VectorBaseHigh_Offset;

	private static bool ZAmplitudeRatio_IsValid;

	private static int ZAmplitudeRatio_Offset;

	private static bool BlendCurve_IsValid;

	private static int BlendCurve_Offset;

	private static bool ScalarMultiplier_IsValid;

	private static int ScalarMultiplier_Offset;

	private FVector EvaluateVector()
	{
		if (bUseRandomVector)
		{
			float num = (float)UMathLibrary.RandomFloatInRange(VectorBaseLow.X, VectorBaseHigh.X);
			float num2 = (float)UMathLibrary.RandomFloatInRange(VectorBaseLow.Y, VectorBaseHigh.Y);
			float num3 = (float)UMathLibrary.RandomFloatInRange(VectorBaseLow.Z, VectorBaseHigh.Z);
			return new FVector(num, num2, num3);
		}
		return VectorBaseLow;
	}

	public float CalculateAggregatedMultiplier(float Distance, bool bIsFrameSwitched)
	{
		return (bIsFrameSwitched ? (0f - ZAmplitudeRatio) : 1f) * BlendCurve.GetFloatValue(Distance) * ScalarMultiplier;
	}

	public FVector GetBlendedVector(float Distance, bool bIsFrameSwitched)
	{
		return EvaluateVector() * CalculateAggregatedMultiplier(Distance, bIsFrameSwitched);
	}

	public FTWImpulseData Copy()
	{
		return this;
	}

	public static FTWImpulseData FromNative(IntPtr nativeBuffer)
	{
		return new FTWImpulseData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTWImpulseData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTWImpulseData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTWImpulseData(IntPtr.Add(nativeBuffer, arrayIndex * FTWImpulseData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTWImpulseData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTWImpulseData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTWImpulseData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTWImpulseData");
			return;
		}
		EnumMarshaler<TWVectorUseType>.ToNative(IntPtr.Add(nativeStruct, VectorUseType_Offset), 0, VectorUseType_PropertyAddress.Address, VectorUseType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseRandomVector_Offset), 0, bUseRandomVector_PropertyAddress.Address, bUseRandomVector);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorBaseLow_Offset), VectorBaseLow);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorBaseHigh_Offset), VectorBaseHigh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZAmplitudeRatio_Offset), ZAmplitudeRatio);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, BlendCurve_Offset), BlendCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScalarMultiplier_Offset), ScalarMultiplier);
	}

	public FTWImpulseData(IntPtr nativeStruct)
	{
		if (FTWImpulseData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTWImpulseData");
			VectorUseType = TWVectorUseType.UsePredefinedVectorSlot0;
			bUseRandomVector = false;
			VectorBaseLow = default(FVector);
			VectorBaseHigh = default(FVector);
			ZAmplitudeRatio = 0f;
			BlendCurve = null;
			ScalarMultiplier = 0f;
		}
		else
		{
			VectorUseType = EnumMarshaler<TWVectorUseType>.FromNative(IntPtr.Add(nativeStruct, VectorUseType_Offset), 0, VectorUseType_PropertyAddress.Address);
			bUseRandomVector = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseRandomVector_Offset), 0, bUseRandomVector_PropertyAddress.Address);
			VectorBaseLow = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorBaseLow_Offset));
			VectorBaseHigh = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorBaseHigh_Offset));
			ZAmplitudeRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZAmplitudeRatio_Offset));
			BlendCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, BlendCurve_Offset));
			ScalarMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScalarMultiplier_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTWImpulseData");
		FTWImpulseData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref VectorUseType_PropertyAddress, intPtr, "VectorUseType");
		VectorUseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorUseType");
		VectorUseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorUseType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bUseRandomVector_PropertyAddress, intPtr, "bUseRandomVector");
		bUseRandomVector_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRandomVector");
		bUseRandomVector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRandomVector", Classes.FBoolProperty);
		VectorBaseLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorBaseLow");
		VectorBaseLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorBaseLow", Classes.FStructProperty);
		VectorBaseHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorBaseHigh");
		VectorBaseHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorBaseHigh", Classes.FStructProperty);
		ZAmplitudeRatio_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZAmplitudeRatio");
		ZAmplitudeRatio_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZAmplitudeRatio", Classes.FFloatProperty);
		BlendCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendCurve");
		BlendCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendCurve", Classes.FObjectProperty);
		ScalarMultiplier_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarMultiplier");
		ScalarMultiplier_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarMultiplier", Classes.FFloatProperty);
		FTWImpulseData_IsValid = ((intPtr != IntPtr.Zero && VectorUseType_IsValid && bUseRandomVector_IsValid && VectorBaseLow_IsValid && VectorBaseHigh_IsValid && ZAmplitudeRatio_IsValid && BlendCurve_IsValid && ScalarMultiplier_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTWImpulseData", (byte)FTWImpulseData_IsValid != 0);
	}

	static FTWImpulseData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTWImpulseData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTWImpulseData));
	}
}
