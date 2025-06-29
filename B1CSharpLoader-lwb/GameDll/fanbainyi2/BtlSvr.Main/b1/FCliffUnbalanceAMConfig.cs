using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CliffUnbalanceAMConfig")]
public struct FCliffUnbalanceAMConfig
{
	[DisplayName("失衡动画_F")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CliffUnbalanceAMConfig:CliffUnbalance_F")]
	public UAnimMontage CliffUnbalance_F;

	[BlueprintReadWrite]
	[DisplayName("失衡动画_B")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CliffUnbalanceAMConfig:CliffUnbalance_B")]
	public UAnimMontage CliffUnbalance_B;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("失衡动画_L")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CliffUnbalanceAMConfig:CliffUnbalance_L")]
	public UAnimMontage CliffUnbalance_L;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("失衡动画_R")]
	[USharpPath("/Script/b1-Managed.CliffUnbalanceAMConfig:CliffUnbalance_R")]
	public UAnimMontage CliffUnbalance_R;

	private static int CliffUnbalanceAMConfig_StructSize;

	private static int CliffUnbalanceAMConfig_IsValid;

	private static bool CliffUnbalance_F_IsValid;

	private static int CliffUnbalance_F_Offset;

	private static bool CliffUnbalance_B_IsValid;

	private static int CliffUnbalance_B_Offset;

	private static bool CliffUnbalance_L_IsValid;

	private static int CliffUnbalance_L_Offset;

	private static bool CliffUnbalance_R_IsValid;

	private static int CliffUnbalance_R_Offset;

	public FCliffUnbalanceAMConfig Copy()
	{
		return this;
	}

	public static FCliffUnbalanceAMConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCliffUnbalanceAMConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCliffUnbalanceAMConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCliffUnbalanceAMConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCliffUnbalanceAMConfig(IntPtr.Add(nativeBuffer, arrayIndex * CliffUnbalanceAMConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCliffUnbalanceAMConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CliffUnbalanceAMConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CliffUnbalanceAMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CliffUnbalanceAMConfig");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, CliffUnbalance_F_Offset), CliffUnbalance_F);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, CliffUnbalance_B_Offset), CliffUnbalance_B);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, CliffUnbalance_L_Offset), CliffUnbalance_L);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, CliffUnbalance_R_Offset), CliffUnbalance_R);
	}

	public FCliffUnbalanceAMConfig(IntPtr nativeStruct)
	{
		if (CliffUnbalanceAMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CliffUnbalanceAMConfig");
			CliffUnbalance_F = null;
			CliffUnbalance_B = null;
			CliffUnbalance_L = null;
			CliffUnbalance_R = null;
		}
		else
		{
			CliffUnbalance_F = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, CliffUnbalance_F_Offset));
			CliffUnbalance_B = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, CliffUnbalance_B_Offset));
			CliffUnbalance_L = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, CliffUnbalance_L_Offset));
			CliffUnbalance_R = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, CliffUnbalance_R_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CliffUnbalanceAMConfig");
		CliffUnbalanceAMConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		CliffUnbalance_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalance_F");
		CliffUnbalance_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalance_F", Classes.FObjectProperty);
		CliffUnbalance_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalance_B");
		CliffUnbalance_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalance_B", Classes.FObjectProperty);
		CliffUnbalance_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalance_L");
		CliffUnbalance_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalance_L", Classes.FObjectProperty);
		CliffUnbalance_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalance_R");
		CliffUnbalance_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalance_R", Classes.FObjectProperty);
		CliffUnbalanceAMConfig_IsValid = ((intPtr != IntPtr.Zero && CliffUnbalance_F_IsValid && CliffUnbalance_B_IsValid && CliffUnbalance_L_IsValid && CliffUnbalance_R_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CliffUnbalanceAMConfig", (byte)CliffUnbalanceAMConfig_IsValid != 0);
	}

	static FCliffUnbalanceAMConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCliffUnbalanceAMConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCliffUnbalanceAMConfig));
	}
}
