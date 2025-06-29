using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStruct1")]
public struct IL2CPPUnitTestStruct1
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStruct1:CSClassProperty")]
	public UAnimMontage CSClassProperty;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStruct1:CSIntProperty")]
	public int CSIntProperty;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStruct1:CSIntProperty2")]
	public int CSIntProperty2;

	private static int IL2CPPUnitTestStruct1_StructSize;

	private static int IL2CPPUnitTestStruct1_IsValid;

	private static bool CSClassProperty_IsValid;

	private static int CSClassProperty_Offset;

	private static bool CSIntProperty_IsValid;

	private static int CSIntProperty_Offset;

	private static bool CSIntProperty2_IsValid;

	private static int CSIntProperty2_Offset;

	public IL2CPPUnitTestStruct1 Copy()
	{
		return this;
	}

	public static IL2CPPUnitTestStruct1 FromNative(IntPtr nativeBuffer)
	{
		return new IL2CPPUnitTestStruct1(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, IL2CPPUnitTestStruct1 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static IL2CPPUnitTestStruct1 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new IL2CPPUnitTestStruct1(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStruct1_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IL2CPPUnitTestStruct1 value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStruct1_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStruct1_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStruct1");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, CSClassProperty_Offset), CSClassProperty);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CSIntProperty_Offset), CSIntProperty);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CSIntProperty2_Offset), CSIntProperty2);
	}

	public IL2CPPUnitTestStruct1(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStruct1_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStruct1");
			CSClassProperty = null;
			CSIntProperty = 0;
			CSIntProperty2 = 0;
		}
		else
		{
			CSClassProperty = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, CSClassProperty_Offset));
			CSIntProperty = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CSIntProperty_Offset));
			CSIntProperty2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CSIntProperty2_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IL2CPPUnitTestStruct1");
		IL2CPPUnitTestStruct1_StructSize = NativeReflection.GetStructSize(intPtr);
		CSClassProperty_Offset = NativeReflection.GetPropertyOffset(intPtr, "CSClassProperty");
		CSClassProperty_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CSClassProperty", Classes.FObjectProperty);
		CSIntProperty_Offset = NativeReflection.GetPropertyOffset(intPtr, "CSIntProperty");
		CSIntProperty_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CSIntProperty", Classes.FIntProperty);
		CSIntProperty2_Offset = NativeReflection.GetPropertyOffset(intPtr, "CSIntProperty2");
		CSIntProperty2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CSIntProperty2", Classes.FIntProperty);
		IL2CPPUnitTestStruct1_IsValid = ((intPtr != IntPtr.Zero && CSClassProperty_IsValid && CSIntProperty_IsValid && CSIntProperty2_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IL2CPPUnitTestStruct1", (byte)IL2CPPUnitTestStruct1_IsValid != 0);
	}

	static IL2CPPUnitTestStruct1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTestStruct1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTestStruct1));
	}
}
