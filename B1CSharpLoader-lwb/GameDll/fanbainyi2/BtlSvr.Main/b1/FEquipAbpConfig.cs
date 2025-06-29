using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EquipAbpConfig")]
public struct FEquipAbpConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("头冠")]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:Head")]
	public TSubclassOf<UAnimInstance> Head;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("上衣")]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:UpWear")]
	public TSubclassOf<UAnimInstance> UpWear;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("手甲")]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:Arm")]
	public TSubclassOf<UAnimInstance> Arm;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("腿甲")]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:Foot")]
	public TSubclassOf<UAnimInstance> Foot;

	[DisplayName("葫芦")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:Hulu")]
	public TSubclassOf<UAnimInstance> Hulu;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("武器")]
	[USharpPath("/Script/b1-Managed.EquipAbpConfig:Weapon")]
	public TSubclassOf<UAnimInstance> Weapon;

	private static int EquipAbpConfig_StructSize;

	private static int EquipAbpConfig_IsValid;

	private static bool Head_IsValid;

	private static int Head_Offset;

	private static bool UpWear_IsValid;

	private static int UpWear_Offset;

	private static bool Arm_IsValid;

	private static int Arm_Offset;

	private static bool Foot_IsValid;

	private static int Foot_Offset;

	private static bool Hulu_IsValid;

	private static int Hulu_Offset;

	private static bool Weapon_IsValid;

	private static int Weapon_Offset;

	public FEquipAbpConfig Copy()
	{
		return this;
	}

	public static FEquipAbpConfig FromNative(IntPtr nativeBuffer)
	{
		return new FEquipAbpConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEquipAbpConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEquipAbpConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEquipAbpConfig(IntPtr.Add(nativeBuffer, arrayIndex * EquipAbpConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEquipAbpConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EquipAbpConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EquipAbpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipAbpConfig");
			return;
		}
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, Head_Offset), Head);
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, UpWear_Offset), UpWear);
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, Arm_Offset), Arm);
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, Foot_Offset), Foot);
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, Hulu_Offset), Hulu);
		TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(nativeStruct, Weapon_Offset), Weapon);
	}

	public FEquipAbpConfig(IntPtr nativeStruct)
	{
		if (EquipAbpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipAbpConfig");
			Head = default(TSubclassOf<UAnimInstance>);
			UpWear = default(TSubclassOf<UAnimInstance>);
			Arm = default(TSubclassOf<UAnimInstance>);
			Foot = default(TSubclassOf<UAnimInstance>);
			Hulu = default(TSubclassOf<UAnimInstance>);
			Weapon = default(TSubclassOf<UAnimInstance>);
		}
		else
		{
			Head = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, Head_Offset));
			UpWear = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, UpWear_Offset));
			Arm = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, Arm_Offset));
			Foot = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, Foot_Offset));
			Hulu = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, Hulu_Offset));
			Weapon = TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(nativeStruct, Weapon_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EquipAbpConfig");
		EquipAbpConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Head_Offset = NativeReflection.GetPropertyOffset(intPtr, "Head");
		Head_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Head", Classes.FClassProperty);
		UpWear_Offset = NativeReflection.GetPropertyOffset(intPtr, "UpWear");
		UpWear_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UpWear", Classes.FClassProperty);
		Arm_Offset = NativeReflection.GetPropertyOffset(intPtr, "Arm");
		Arm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Arm", Classes.FClassProperty);
		Foot_Offset = NativeReflection.GetPropertyOffset(intPtr, "Foot");
		Foot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Foot", Classes.FClassProperty);
		Hulu_Offset = NativeReflection.GetPropertyOffset(intPtr, "Hulu");
		Hulu_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Hulu", Classes.FClassProperty);
		Weapon_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weapon");
		Weapon_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weapon", Classes.FClassProperty);
		EquipAbpConfig_IsValid = ((intPtr != IntPtr.Zero && Head_IsValid && UpWear_IsValid && Arm_IsValid && Foot_IsValid && Hulu_IsValid && Weapon_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EquipAbpConfig", (byte)EquipAbpConfig_IsValid != 0);
	}

	static FEquipAbpConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEquipAbpConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEquipAbpConfig));
	}
}
