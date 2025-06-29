using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.RectParam")]
public struct FRectParam
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RectParam:Height")]
	public float Height;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RectParam:Width")]
	public float Width;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RectParam:RotateAngle")]
	public float RotateAngle;

	public float Yaw;

	private static int RectParam_StructSize;

	private static int RectParam_IsValid;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool Width_IsValid;

	private static int Width_Offset;

	private static bool RotateAngle_IsValid;

	private static int RotateAngle_Offset;

	public FRectParam Copy()
	{
		return this;
	}

	public static FRectParam FromNative(IntPtr nativeBuffer)
	{
		return new FRectParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRectParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRectParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRectParam(IntPtr.Add(nativeBuffer, arrayIndex * RectParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRectParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RectParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RectParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RectParam");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Height_Offset), Height);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Width_Offset), Width);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotateAngle_Offset), RotateAngle);
	}

	public FRectParam(IntPtr nativeStruct)
	{
		if (RectParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RectParam");
			Height = 0f;
			Width = 0f;
			RotateAngle = 0f;
		}
		else
		{
			Height = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Height_Offset));
			Width = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Width_Offset));
			RotateAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotateAngle_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RectParam");
		RectParam_StructSize = NativeReflection.GetStructSize(intPtr);
		Height_Offset = NativeReflection.GetPropertyOffset(intPtr, "Height");
		Height_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Height", Classes.FFloatProperty);
		Width_Offset = NativeReflection.GetPropertyOffset(intPtr, "Width");
		Width_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Width", Classes.FFloatProperty);
		RotateAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateAngle");
		RotateAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateAngle", Classes.FFloatProperty);
		RectParam_IsValid = ((intPtr != IntPtr.Zero && Height_IsValid && Width_IsValid && RotateAngle_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RectParam", (byte)RectParam_IsValid != 0);
	}

	static FRectParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRectParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRectParam));
	}
}
