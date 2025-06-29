using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4199441)]
[BlueprintType]
[UMetaPath("/Script/Engine.Vector_NetQuantizeNormal", "Engine", UnrealModuleType.Engine)]
public struct FVector_NetQuantizeNormal
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

	private static bool FVector_NetQuantizeNormal_IsValid;

	private static int FVector_NetQuantizeNormal_StructSize;

	public FVector_NetQuantizeNormal Copy()
	{
		return this;
	}

	public static FVector_NetQuantizeNormal FromNative(IntPtr nativeBuffer)
	{
		return new FVector_NetQuantizeNormal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVector_NetQuantizeNormal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVector_NetQuantizeNormal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVector_NetQuantizeNormal(nativeBuffer + arrayIndex * FVector_NetQuantizeNormal_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVector_NetQuantizeNormal value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVector_NetQuantizeNormal_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVector_NetQuantizeNormal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.Vector_NetQuantizeNormal");
			return;
		}
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, X_Offset), X);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, Y_Offset), Y);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, Z_Offset), Z);
	}

	public FVector_NetQuantizeNormal(IntPtr nativeStruct)
	{
		if (!FVector_NetQuantizeNormal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.Vector_NetQuantizeNormal");
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

	static FVector_NetQuantizeNormal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector_NetQuantizeNormal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector_NetQuantizeNormal));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.Vector_NetQuantizeNormal");
		FVector_NetQuantizeNormal_StructSize = NativeReflection.GetStructSize(intPtr);
		X_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "X", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Y", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Z", Classes.FDoubleProperty);
		FVector_NetQuantizeNormal_IsValid = intPtr != IntPtr.Zero && X_IsValid && Y_IsValid && Z_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.Vector_NetQuantizeNormal", FVector_NetQuantizeNormal_IsValid);
	}
}
