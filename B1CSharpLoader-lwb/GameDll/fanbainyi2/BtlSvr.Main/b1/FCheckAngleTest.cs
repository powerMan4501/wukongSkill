using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CheckAngleTest")]
public struct FCheckAngleTest
{
	[Category("CheckAngleTest")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CheckAngleTest:LeftAngle")]
	public float LeftAngle;

	[UProperty]
	[BlueprintReadWrite]
	[Category("CheckAngleTest")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CheckAngleTest:RightAngle")]
	public float RightAngle;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("CheckAngleTest")]
	[DisplayName("正方向基准")]
	[USharpPath("/Script/b1-Managed.CheckAngleTest:AngleBaseType")]
	public EAngleBaseType AngleBaseType;

	private static int CheckAngleTest_StructSize;

	private static int CheckAngleTest_IsValid;

	private static bool LeftAngle_IsValid;

	private static int LeftAngle_Offset;

	private static bool RightAngle_IsValid;

	private static int RightAngle_Offset;

	private static bool AngleBaseType_IsValid;

	private static int AngleBaseType_Offset;

	private static FFieldAddress AngleBaseType_PropertyAddress;

	public FCheckAngleTest Copy()
	{
		return this;
	}

	public static FCheckAngleTest FromNative(IntPtr nativeBuffer)
	{
		return new FCheckAngleTest(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCheckAngleTest value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCheckAngleTest FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCheckAngleTest(IntPtr.Add(nativeBuffer, arrayIndex * CheckAngleTest_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCheckAngleTest value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CheckAngleTest_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CheckAngleTest_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CheckAngleTest");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeftAngle_Offset), LeftAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RightAngle_Offset), RightAngle);
		EnumMarshaler<EAngleBaseType>.ToNative(IntPtr.Add(nativeStruct, AngleBaseType_Offset), 0, AngleBaseType_PropertyAddress.Address, AngleBaseType);
	}

	public FCheckAngleTest(IntPtr nativeStruct)
	{
		if (CheckAngleTest_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CheckAngleTest");
			LeftAngle = 0f;
			RightAngle = 0f;
			AngleBaseType = EAngleBaseType.Self2Target;
		}
		else
		{
			LeftAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeftAngle_Offset));
			RightAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RightAngle_Offset));
			AngleBaseType = EnumMarshaler<EAngleBaseType>.FromNative(IntPtr.Add(nativeStruct, AngleBaseType_Offset), 0, AngleBaseType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CheckAngleTest");
		CheckAngleTest_StructSize = NativeReflection.GetStructSize(intPtr);
		LeftAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftAngle");
		LeftAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftAngle", Classes.FFloatProperty);
		RightAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightAngle");
		RightAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AngleBaseType_PropertyAddress, intPtr, "AngleBaseType");
		AngleBaseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleBaseType");
		AngleBaseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleBaseType", Classes.FEnumProperty);
		CheckAngleTest_IsValid = ((intPtr != IntPtr.Zero && LeftAngle_IsValid && RightAngle_IsValid && AngleBaseType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CheckAngleTest", (byte)CheckAngleTest_IsValid != 0);
	}

	static FCheckAngleTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCheckAngleTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCheckAngleTest));
	}
}
