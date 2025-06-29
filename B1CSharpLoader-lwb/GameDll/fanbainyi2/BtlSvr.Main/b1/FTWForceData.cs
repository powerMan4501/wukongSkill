using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FTWForceData")]
public struct FTWForceData
{
	[DisplayName("向量使用类型")]
	[EditAnywhere]
	[UProperty]
	[Category("TigerWoods Force Data")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FTWForceData:VectorUseType")]
	public TWVectorUseType VectorUseType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否启用范围随机向量")]
	[AllowPrivateAccess]
	[Category("TigerWoods Force Data")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTWForceData:bUseRandomVector")]
	private bool bUseRandomVector;

	[EditAnywhere]
	[UProperty]
	[DisplayName("基准向量-低值")]
	[Category("TigerWoods Force Data")]
	[UMeta(MDProp.EditCondition, "VectorUseType == TWVectorUseType::UseVectorBase")]
	[AllowPrivateAccess]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FTWForceData:VectorBaseLow")]
	private FVector VectorBaseLow;

	[BlueprintReadWrite]
	[Category("TigerWoods Force Data")]
	[UMeta(MDProp.EditCondition, "VectorUseType == TWVectorUseType::UseVectorBase && bUseRandomVector")]
	[AllowPrivateAccess]
	[UProperty]
	[EditAnywhere]
	[DisplayName("基准向量-高值")]
	[USharpPath("/Script/b1-Managed.FTWForceData:VectorBaseHigh")]
	private FVector VectorBaseHigh;

	[Category("TigerWoods Force Data")]
	[DisplayName("向量混合曲线（距离-向量缩放倍率）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTWForceData:BlendCurve")]
	public UCurveFloat BlendCurve;

	[DisplayName("标量乘数")]
	[UProperty]
	[Category("TigerWoods Force Data")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FTWForceData:ScalarMultiplier")]
	public float ScalarMultiplier;

	private static int FTWForceData_StructSize;

	private static int FTWForceData_IsValid;

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

	public float CalculateAggregatedMultiplier(float Distance)
	{
		return BlendCurve.GetFloatValue(Distance) * ScalarMultiplier;
	}

	public FVector GetBlendedVector(float Distance)
	{
		return EvaluateVector() * CalculateAggregatedMultiplier(Distance);
	}

	public FTWForceData Copy()
	{
		return this;
	}

	public static FTWForceData FromNative(IntPtr nativeBuffer)
	{
		return new FTWForceData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTWForceData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTWForceData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTWForceData(IntPtr.Add(nativeBuffer, arrayIndex * FTWForceData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTWForceData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTWForceData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTWForceData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTWForceData");
			return;
		}
		EnumMarshaler<TWVectorUseType>.ToNative(IntPtr.Add(nativeStruct, VectorUseType_Offset), 0, VectorUseType_PropertyAddress.Address, VectorUseType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseRandomVector_Offset), 0, bUseRandomVector_PropertyAddress.Address, bUseRandomVector);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorBaseLow_Offset), VectorBaseLow);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorBaseHigh_Offset), VectorBaseHigh);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, BlendCurve_Offset), BlendCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScalarMultiplier_Offset), ScalarMultiplier);
	}

	public FTWForceData(IntPtr nativeStruct)
	{
		if (FTWForceData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTWForceData");
			VectorUseType = TWVectorUseType.UsePredefinedVectorSlot0;
			bUseRandomVector = false;
			VectorBaseLow = default(FVector);
			VectorBaseHigh = default(FVector);
			BlendCurve = null;
			ScalarMultiplier = 0f;
		}
		else
		{
			VectorUseType = EnumMarshaler<TWVectorUseType>.FromNative(IntPtr.Add(nativeStruct, VectorUseType_Offset), 0, VectorUseType_PropertyAddress.Address);
			bUseRandomVector = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseRandomVector_Offset), 0, bUseRandomVector_PropertyAddress.Address);
			VectorBaseLow = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorBaseLow_Offset));
			VectorBaseHigh = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorBaseHigh_Offset));
			BlendCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, BlendCurve_Offset));
			ScalarMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScalarMultiplier_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTWForceData");
		FTWForceData_StructSize = NativeReflection.GetStructSize(intPtr);
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
		BlendCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendCurve");
		BlendCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendCurve", Classes.FObjectProperty);
		ScalarMultiplier_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarMultiplier");
		ScalarMultiplier_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarMultiplier", Classes.FFloatProperty);
		FTWForceData_IsValid = ((intPtr != IntPtr.Zero && VectorUseType_IsValid && bUseRandomVector_IsValid && VectorBaseLow_IsValid && VectorBaseHigh_IsValid && BlendCurve_IsValid && ScalarMultiplier_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTWForceData", (byte)FTWForceData_IsValid != 0);
	}

	static FTWForceData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTWForceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTWForceData));
	}
}
