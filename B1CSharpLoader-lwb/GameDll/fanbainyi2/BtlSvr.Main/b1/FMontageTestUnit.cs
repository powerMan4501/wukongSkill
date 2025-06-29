using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MontageTestUnit")]
public struct FMontageTestUnit
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MontageTestUnit:Montage")]
	public UAnimMontage Montage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MontageTestUnit:describe")]
	public string describe;

	private static int MontageTestUnit_StructSize;

	private static int MontageTestUnit_IsValid;

	private static bool Montage_IsValid;

	private static int Montage_Offset;

	private static bool describe_IsValid;

	private static int describe_Offset;

	public FMontageTestUnit Copy()
	{
		return this;
	}

	public static FMontageTestUnit FromNative(IntPtr nativeBuffer)
	{
		return new FMontageTestUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMontageTestUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMontageTestUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMontageTestUnit(IntPtr.Add(nativeBuffer, arrayIndex * MontageTestUnit_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMontageTestUnit value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MontageTestUnit_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MontageTestUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MontageTestUnit");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, Montage_Offset), Montage);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, describe_Offset), describe);
	}

	public FMontageTestUnit(IntPtr nativeStruct)
	{
		if (MontageTestUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MontageTestUnit");
			Montage = null;
			describe = null;
		}
		else
		{
			Montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, Montage_Offset));
			describe = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, describe_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MontageTestUnit");
		MontageTestUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		Montage_Offset = NativeReflection.GetPropertyOffset(intPtr, "Montage");
		Montage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Montage", Classes.FObjectProperty);
		describe_Offset = NativeReflection.GetPropertyOffset(intPtr, "describe");
		describe_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "describe", Classes.FStrProperty);
		MontageTestUnit_IsValid = ((intPtr != IntPtr.Zero && Montage_IsValid && describe_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MontageTestUnit", (byte)MontageTestUnit_IsValid != 0);
	}

	static FMontageTestUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMontageTestUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMontageTestUnit));
	}
}
