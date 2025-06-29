using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[DisplayName("异常状态动画")]
[USharpPath("/Script/b1-Managed.SpecialStateAM")]
public struct SpecialStateAM
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Loop动画")]
	[USharpPath("/Script/b1-Managed.SpecialStateAM:LoopAM")]
	public UAnimMontage LoopAM;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("End动画")]
	[USharpPath("/Script/b1-Managed.SpecialStateAM:EndAM")]
	public UAnimMontage EndAM;

	private static int SpecialStateAM_StructSize;

	private static int SpecialStateAM_IsValid;

	private static bool LoopAM_IsValid;

	private static int LoopAM_Offset;

	private static bool EndAM_IsValid;

	private static int EndAM_Offset;

	public SpecialStateAM Copy()
	{
		return this;
	}

	public static SpecialStateAM FromNative(IntPtr nativeBuffer)
	{
		return new SpecialStateAM(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, SpecialStateAM value)
	{
		value.ToNative(nativeBuffer);
	}

	public static SpecialStateAM FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new SpecialStateAM(IntPtr.Add(nativeBuffer, arrayIndex * SpecialStateAM_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, SpecialStateAM value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpecialStateAM_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpecialStateAM_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpecialStateAM");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LoopAM_Offset), LoopAM);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, EndAM_Offset), EndAM);
	}

	public SpecialStateAM(IntPtr nativeStruct)
	{
		if (SpecialStateAM_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpecialStateAM");
			LoopAM = null;
			EndAM = null;
		}
		else
		{
			LoopAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LoopAM_Offset));
			EndAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, EndAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpecialStateAM");
		SpecialStateAM_StructSize = NativeReflection.GetStructSize(intPtr);
		LoopAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopAM");
		LoopAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopAM", Classes.FObjectProperty);
		EndAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndAM");
		EndAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndAM", Classes.FObjectProperty);
		SpecialStateAM_IsValid = ((intPtr != IntPtr.Zero && LoopAM_IsValid && EndAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpecialStateAM", (byte)SpecialStateAM_IsValid != 0);
	}

	static SpecialStateAM()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(SpecialStateAM)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(SpecialStateAM));
	}
}
