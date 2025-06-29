using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4199441)]
[BlueprintType]
[UMetaPath("/Script/Engine.Vector_NetQuantize10", "Engine", UnrealModuleType.Engine)]
public struct FVector_NetQuantize10
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:X")]
	public double X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Y")]
	public double Y;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Z")]
	public double Z;

	private static bool FVector_NetQuantize10_IsValid;

	private static int FVector_NetQuantize10_StructSize;

	public FVector_NetQuantize10 Copy()
	{
		return this;
	}

	public static FVector_NetQuantize10 FromNative(IntPtr nativeBuffer)
	{
		return new FVector_NetQuantize10(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVector_NetQuantize10 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVector_NetQuantize10 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVector_NetQuantize10(nativeBuffer + arrayIndex * FVector_NetQuantize10_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVector_NetQuantize10 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVector_NetQuantize10_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVector_NetQuantize10_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.Vector_NetQuantize10");
			return;
		}
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, X_Offset), X);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, Y_Offset), Y);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, Z_Offset), Z);
	}

	public FVector_NetQuantize10(IntPtr nativeStruct)
	{
		if (!FVector_NetQuantize10_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.Vector_NetQuantize10");
			X = 0.0;
			Y = 0.0;
			Z = 0.0;
		}
		else
		{
			X = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, X_Offset));
			Y = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, Y_Offset));
			Z = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, Z_Offset));
		}
	}

	static FVector_NetQuantize10()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector_NetQuantize10)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector_NetQuantize10));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.Vector_NetQuantize10");
		FVector_NetQuantize10_StructSize = NativeReflection.GetStructSize(intPtr);
		X_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "X", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Y", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Z", Classes.FDoubleProperty);
		FVector_NetQuantize10_IsValid = intPtr != IntPtr.Zero && X_IsValid && Y_IsValid && Z_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.Vector_NetQuantize10", FVector_NetQuantize10_IsValid);
	}
}
