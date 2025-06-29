using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeGuid", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopeGuid
{
	private static bool A_IsValid;

	private static int A_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeGuid:A")]
	public int A;

	private static bool B_IsValid;

	private static int B_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeGuid:B")]
	public int B;

	private static bool C_IsValid;

	private static int C_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeGuid:C")]
	public int C;

	private static bool D_IsValid;

	private static int D_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeGuid:D")]
	public int D;

	private static bool FCalliopeGuid_IsValid;

	private static int FCalliopeGuid_StructSize;

	public FCalliopeGuid Copy()
	{
		return this;
	}

	public static FCalliopeGuid FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopeGuid(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopeGuid value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopeGuid FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopeGuid(nativeBuffer + arrayIndex * FCalliopeGuid_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopeGuid value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopeGuid_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopeGuid_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeGuid");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, A_Offset), A);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, B_Offset), B);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, C_Offset), C);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, D_Offset), D);
	}

	public FCalliopeGuid(IntPtr nativeStruct)
	{
		if (!FCalliopeGuid_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeGuid");
			A = 0;
			B = 0;
			C = 0;
			D = 0;
		}
		else
		{
			A = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, A_Offset));
			B = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, B_Offset));
			C = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, C_Offset));
			D = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, D_Offset));
		}
	}

	static FCalliopeGuid()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopeGuid)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopeGuid));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopeGuid");
		FCalliopeGuid_StructSize = NativeReflection.GetStructSize(intPtr);
		A_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "A", Classes.FIntProperty);
		B_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "B", Classes.FIntProperty);
		C_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "C");
		C_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "C", Classes.FIntProperty);
		D_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "D");
		D_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "D", Classes.FIntProperty);
		FCalliopeGuid_IsValid = intPtr != IntPtr.Zero && A_IsValid && B_IsValid && C_IsValid && D_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopeGuid", FCalliopeGuid_IsValid);
	}
}
