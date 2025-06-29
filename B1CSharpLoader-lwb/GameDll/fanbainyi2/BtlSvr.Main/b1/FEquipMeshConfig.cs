using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EquipMeshConfig")]
public struct FEquipMeshConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("头冠")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:Head")]
	public USkeletalMesh Head;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("上衣")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:UpWear")]
	public USkeletalMesh UpWear;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("手甲")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:Arm")]
	public USkeletalMesh Arm;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("腿甲")]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:Foot")]
	public USkeletalMesh Foot;

	[DisplayName("葫芦")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:Hulu")]
	public USkeletalMesh Hulu;

	[UProperty]
	[DisplayName("武器")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipMeshConfig:Weapon")]
	public USkeletalMesh Weapon;

	private static int EquipMeshConfig_StructSize;

	private static int EquipMeshConfig_IsValid;

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

	public FEquipMeshConfig Copy()
	{
		return this;
	}

	public static FEquipMeshConfig FromNative(IntPtr nativeBuffer)
	{
		return new FEquipMeshConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEquipMeshConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEquipMeshConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEquipMeshConfig(IntPtr.Add(nativeBuffer, arrayIndex * EquipMeshConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEquipMeshConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EquipMeshConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EquipMeshConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipMeshConfig");
			return;
		}
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Head_Offset), Head);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, UpWear_Offset), UpWear);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Arm_Offset), Arm);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Foot_Offset), Foot);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Hulu_Offset), Hulu);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Weapon_Offset), Weapon);
	}

	public FEquipMeshConfig(IntPtr nativeStruct)
	{
		if (EquipMeshConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipMeshConfig");
			Head = null;
			UpWear = null;
			Arm = null;
			Foot = null;
			Hulu = null;
			Weapon = null;
		}
		else
		{
			Head = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Head_Offset));
			UpWear = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, UpWear_Offset));
			Arm = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Arm_Offset));
			Foot = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Foot_Offset));
			Hulu = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Hulu_Offset));
			Weapon = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Weapon_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EquipMeshConfig");
		EquipMeshConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Head_Offset = NativeReflection.GetPropertyOffset(intPtr, "Head");
		Head_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Head", Classes.FObjectProperty);
		UpWear_Offset = NativeReflection.GetPropertyOffset(intPtr, "UpWear");
		UpWear_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UpWear", Classes.FObjectProperty);
		Arm_Offset = NativeReflection.GetPropertyOffset(intPtr, "Arm");
		Arm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Arm", Classes.FObjectProperty);
		Foot_Offset = NativeReflection.GetPropertyOffset(intPtr, "Foot");
		Foot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Foot", Classes.FObjectProperty);
		Hulu_Offset = NativeReflection.GetPropertyOffset(intPtr, "Hulu");
		Hulu_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Hulu", Classes.FObjectProperty);
		Weapon_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weapon");
		Weapon_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weapon", Classes.FObjectProperty);
		EquipMeshConfig_IsValid = ((intPtr != IntPtr.Zero && Head_IsValid && UpWear_IsValid && Arm_IsValid && Foot_IsValid && Hulu_IsValid && Weapon_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EquipMeshConfig", (byte)EquipMeshConfig_IsValid != 0);
	}

	static FEquipMeshConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEquipMeshConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEquipMeshConfig));
	}
}
