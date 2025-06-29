using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SectorParam")]
public struct FSectorParam
{
	[DisplayName("内径")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SectorParam:MinR")]
	public float MinR;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("外径")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SectorParam:MaxR")]
	public float MaxR;

	[UProperty]
	[DisplayName("左角度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SectorParam:LeftAngle")]
	public float LeftAngle;

	[UProperty]
	[EditAnywhere]
	[DisplayName("外角度")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SectorParam:RightAngle")]
	public float RightAngle;

	public FVector BaseDir;

	private static int SectorParam_StructSize;

	private static int SectorParam_IsValid;

	private static bool MinR_IsValid;

	private static int MinR_Offset;

	private static bool MaxR_IsValid;

	private static int MaxR_Offset;

	private static bool LeftAngle_IsValid;

	private static int LeftAngle_Offset;

	private static bool RightAngle_IsValid;

	private static int RightAngle_Offset;

	public FSectorParam Copy()
	{
		return this;
	}

	public static FSectorParam FromNative(IntPtr nativeBuffer)
	{
		return new FSectorParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSectorParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSectorParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSectorParam(IntPtr.Add(nativeBuffer, arrayIndex * SectorParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSectorParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SectorParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SectorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SectorParam");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinR_Offset), MinR);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxR_Offset), MaxR);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeftAngle_Offset), LeftAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RightAngle_Offset), RightAngle);
	}

	public FSectorParam(IntPtr nativeStruct)
	{
		if (SectorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SectorParam");
			MinR = 0f;
			MaxR = 0f;
			LeftAngle = 0f;
			RightAngle = 0f;
		}
		else
		{
			MinR = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinR_Offset));
			MaxR = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxR_Offset));
			LeftAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeftAngle_Offset));
			RightAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RightAngle_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SectorParam");
		SectorParam_StructSize = NativeReflection.GetStructSize(intPtr);
		MinR_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinR");
		MinR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinR", Classes.FFloatProperty);
		MaxR_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxR");
		MaxR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxR", Classes.FFloatProperty);
		LeftAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftAngle");
		LeftAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftAngle", Classes.FFloatProperty);
		RightAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightAngle");
		RightAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightAngle", Classes.FFloatProperty);
		SectorParam_IsValid = ((intPtr != IntPtr.Zero && MinR_IsValid && MaxR_IsValid && LeftAngle_IsValid && RightAngle_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SectorParam", (byte)SectorParam_IsValid != 0);
	}

	static FSectorParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSectorParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSectorParam));
	}
}
