using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.RangePointSetRule")]
public struct FRangePointSetRule
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围点类型")]
	[USharpPath("/Script/b1-Managed.RangePointSetRule:RangePointSetType")]
	public ERangePointSetType RangePointSetType;

	[Tooltip("以矩阵边长上点的个数来标记")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("矩阵密度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RangePointSetRule:MatrixDensity")]
	public int MatrixDensity;

	[DisplayName("圆半径, 甜甜圈外径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RangePointSetRule:CircleRadius")]
	public float CircleRadius;

	[UProperty]
	[DisplayName("甜甜圈内径")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.RangePointSetRule:InnerCircleRadius")]
	public float InnerCircleRadius;

	[EditAnywhere]
	[UProperty]
	[DisplayName("扰动")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.RangePointSetRule:Noise")]
	public FVector Noise;

	private static int RangePointSetRule_StructSize;

	private static int RangePointSetRule_IsValid;

	private static bool RangePointSetType_IsValid;

	private static int RangePointSetType_Offset;

	private static FFieldAddress RangePointSetType_PropertyAddress;

	private static bool MatrixDensity_IsValid;

	private static int MatrixDensity_Offset;

	private static bool CircleRadius_IsValid;

	private static int CircleRadius_Offset;

	private static bool InnerCircleRadius_IsValid;

	private static int InnerCircleRadius_Offset;

	private static bool Noise_IsValid;

	private static int Noise_Offset;

	public FRangePointSetRule Copy()
	{
		return this;
	}

	public static FRangePointSetRule FromNative(IntPtr nativeBuffer)
	{
		return new FRangePointSetRule(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRangePointSetRule value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRangePointSetRule FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRangePointSetRule(IntPtr.Add(nativeBuffer, arrayIndex * RangePointSetRule_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRangePointSetRule value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RangePointSetRule_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RangePointSetRule_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RangePointSetRule");
			return;
		}
		EnumMarshaler<ERangePointSetType>.ToNative(IntPtr.Add(nativeStruct, RangePointSetType_Offset), 0, RangePointSetType_PropertyAddress.Address, RangePointSetType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MatrixDensity_Offset), MatrixDensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CircleRadius_Offset), CircleRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerCircleRadius_Offset), InnerCircleRadius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Noise_Offset), Noise);
	}

	public FRangePointSetRule(IntPtr nativeStruct)
	{
		if (RangePointSetRule_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RangePointSetRule");
			RangePointSetType = ERangePointSetType.CircleRandom;
			MatrixDensity = 0;
			CircleRadius = 0f;
			InnerCircleRadius = 0f;
			Noise = default(FVector);
		}
		else
		{
			RangePointSetType = EnumMarshaler<ERangePointSetType>.FromNative(IntPtr.Add(nativeStruct, RangePointSetType_Offset), 0, RangePointSetType_PropertyAddress.Address);
			MatrixDensity = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MatrixDensity_Offset));
			CircleRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CircleRadius_Offset));
			InnerCircleRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerCircleRadius_Offset));
			Noise = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Noise_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RangePointSetRule");
		RangePointSetRule_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref RangePointSetType_PropertyAddress, intPtr, "RangePointSetType");
		RangePointSetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangePointSetType");
		RangePointSetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangePointSetType", Classes.FEnumProperty);
		MatrixDensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatrixDensity");
		MatrixDensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatrixDensity", Classes.FIntProperty);
		CircleRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircleRadius");
		CircleRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircleRadius", Classes.FFloatProperty);
		InnerCircleRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "InnerCircleRadius");
		InnerCircleRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InnerCircleRadius", Classes.FFloatProperty);
		Noise_Offset = NativeReflection.GetPropertyOffset(intPtr, "Noise");
		Noise_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Noise", Classes.FStructProperty);
		RangePointSetRule_IsValid = ((intPtr != IntPtr.Zero && RangePointSetType_IsValid && MatrixDensity_IsValid && CircleRadius_IsValid && InnerCircleRadius_IsValid && Noise_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RangePointSetRule", (byte)RangePointSetRule_IsValid != 0);
	}

	static FRangePointSetRule()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRangePointSetRule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRangePointSetRule));
	}
}
