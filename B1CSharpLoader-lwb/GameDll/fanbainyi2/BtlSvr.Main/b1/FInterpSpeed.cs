using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InterpSpeed")]
public struct FInterpSpeed
{
	[Category("速度单位")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.InterpSpeed:InterpMode")]
	public ESpeedInterpMode InterpMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("速度值")]
	[USharpPath("/Script/b1-Managed.InterpSpeed:Speed")]
	public float Speed;

	private static int InterpSpeed_StructSize;

	private static int InterpSpeed_IsValid;

	private static bool InterpMode_IsValid;

	private static int InterpMode_Offset;

	private static FFieldAddress InterpMode_PropertyAddress;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	public FInterpSpeed Copy()
	{
		return this;
	}

	public static FInterpSpeed FromNative(IntPtr nativeBuffer)
	{
		return new FInterpSpeed(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpSpeed value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpSpeed FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpSpeed(IntPtr.Add(nativeBuffer, arrayIndex * InterpSpeed_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpSpeed value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InterpSpeed_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InterpSpeed_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InterpSpeed");
			return;
		}
		EnumMarshaler<ESpeedInterpMode>.ToNative(IntPtr.Add(nativeStruct, InterpMode_Offset), 0, InterpMode_PropertyAddress.Address, InterpMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Speed_Offset), Speed);
	}

	public FInterpSpeed(IntPtr nativeStruct)
	{
		if (InterpSpeed_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InterpSpeed");
			InterpMode = ESpeedInterpMode.ByPercentage;
			Speed = 0f;
		}
		else
		{
			InterpMode = EnumMarshaler<ESpeedInterpMode>.FromNative(IntPtr.Add(nativeStruct, InterpMode_Offset), 0, InterpMode_PropertyAddress.Address);
			Speed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Speed_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InterpSpeed");
		InterpSpeed_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref InterpMode_PropertyAddress, intPtr, "InterpMode");
		InterpMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "InterpMode");
		InterpMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InterpMode", Classes.FEnumProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		InterpSpeed_IsValid = ((intPtr != IntPtr.Zero && InterpMode_IsValid && Speed_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InterpSpeed", (byte)InterpSpeed_IsValid != 0);
	}

	static FInterpSpeed()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInterpSpeed)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpSpeed));
	}
}
