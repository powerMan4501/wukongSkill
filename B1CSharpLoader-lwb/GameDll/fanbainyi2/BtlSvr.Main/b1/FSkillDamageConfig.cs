using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SkillDamageConfig")]
public struct FSkillDamageConfig
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:DmgReason")]
	public EDamageReason DmgReason;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:DmgReasonEffectID")]
	public int DmgReasonEffectID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:DmgReasonEffectIdx")]
	public int DmgReasonEffectIdx;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:BuffOwner")]
	public AActor BuffOwner;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:DamageCalcType")]
	public EDamageCalcType DamageCalcType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:DamageImmueLevel")]
	public int DamageImmueLevel;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:HPMaxINV10000Damage_Abs")]
	public float HPMaxINV10000Damage_Abs;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillDamageConfig:CameraShakeDA")]
	public string CameraShakeDA;

	private static int SkillDamageConfig_StructSize;

	private static int SkillDamageConfig_IsValid;

	private static bool DmgReason_IsValid;

	private static int DmgReason_Offset;

	private static FFieldAddress DmgReason_PropertyAddress;

	private static bool DmgReasonEffectID_IsValid;

	private static int DmgReasonEffectID_Offset;

	private static bool DmgReasonEffectIdx_IsValid;

	private static int DmgReasonEffectIdx_Offset;

	private static bool BuffOwner_IsValid;

	private static int BuffOwner_Offset;

	private static bool DamageCalcType_IsValid;

	private static int DamageCalcType_Offset;

	private static FFieldAddress DamageCalcType_PropertyAddress;

	private static bool DamageImmueLevel_IsValid;

	private static int DamageImmueLevel_Offset;

	private static bool HPMaxINV10000Damage_Abs_IsValid;

	private static int HPMaxINV10000Damage_Abs_Offset;

	private static bool CameraShakeDA_IsValid;

	private static int CameraShakeDA_Offset;

	public FSkillDamageConfig Copy()
	{
		return this;
	}

	public static FSkillDamageConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSkillDamageConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkillDamageConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkillDamageConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkillDamageConfig(IntPtr.Add(nativeBuffer, arrayIndex * SkillDamageConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkillDamageConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SkillDamageConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SkillDamageConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillDamageConfig");
			return;
		}
		EnumMarshaler<EDamageReason>.ToNative(IntPtr.Add(nativeStruct, DmgReason_Offset), 0, DmgReason_PropertyAddress.Address, DmgReason);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DmgReasonEffectID_Offset), DmgReasonEffectID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DmgReasonEffectIdx_Offset), DmgReasonEffectIdx);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, BuffOwner_Offset), BuffOwner);
		EnumMarshaler<EDamageCalcType>.ToNative(IntPtr.Add(nativeStruct, DamageCalcType_Offset), 0, DamageCalcType_PropertyAddress.Address, DamageCalcType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DamageImmueLevel_Offset), DamageImmueLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HPMaxINV10000Damage_Abs_Offset), HPMaxINV10000Damage_Abs);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CameraShakeDA_Offset), CameraShakeDA);
	}

	public FSkillDamageConfig(IntPtr nativeStruct)
	{
		if (SkillDamageConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillDamageConfig");
			DmgReason = EDamageReason.None;
			DmgReasonEffectID = 0;
			DmgReasonEffectIdx = 0;
			BuffOwner = null;
			DamageCalcType = EDamageCalcType.Normal;
			DamageImmueLevel = 0;
			HPMaxINV10000Damage_Abs = 0f;
			CameraShakeDA = null;
		}
		else
		{
			DmgReason = EnumMarshaler<EDamageReason>.FromNative(IntPtr.Add(nativeStruct, DmgReason_Offset), 0, DmgReason_PropertyAddress.Address);
			DmgReasonEffectID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DmgReasonEffectID_Offset));
			DmgReasonEffectIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DmgReasonEffectIdx_Offset));
			BuffOwner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, BuffOwner_Offset));
			DamageCalcType = EnumMarshaler<EDamageCalcType>.FromNative(IntPtr.Add(nativeStruct, DamageCalcType_Offset), 0, DamageCalcType_PropertyAddress.Address);
			DamageImmueLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DamageImmueLevel_Offset));
			HPMaxINV10000Damage_Abs = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HPMaxINV10000Damage_Abs_Offset));
			CameraShakeDA = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CameraShakeDA_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SkillDamageConfig");
		SkillDamageConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DmgReason_PropertyAddress, intPtr, "DmgReason");
		DmgReason_Offset = NativeReflection.GetPropertyOffset(intPtr, "DmgReason");
		DmgReason_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DmgReason", Classes.FEnumProperty);
		DmgReasonEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DmgReasonEffectID");
		DmgReasonEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DmgReasonEffectID", Classes.FIntProperty);
		DmgReasonEffectIdx_Offset = NativeReflection.GetPropertyOffset(intPtr, "DmgReasonEffectIdx");
		DmgReasonEffectIdx_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DmgReasonEffectIdx", Classes.FIntProperty);
		BuffOwner_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffOwner");
		BuffOwner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffOwner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DamageCalcType_PropertyAddress, intPtr, "DamageCalcType");
		DamageCalcType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamageCalcType");
		DamageCalcType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamageCalcType", Classes.FEnumProperty);
		DamageImmueLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamageImmueLevel");
		DamageImmueLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamageImmueLevel", Classes.FIntProperty);
		HPMaxINV10000Damage_Abs_Offset = NativeReflection.GetPropertyOffset(intPtr, "HPMaxINV10000Damage_Abs");
		HPMaxINV10000Damage_Abs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HPMaxINV10000Damage_Abs", Classes.FFloatProperty);
		CameraShakeDA_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShakeDA");
		CameraShakeDA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShakeDA", Classes.FStrProperty);
		SkillDamageConfig_IsValid = ((intPtr != IntPtr.Zero && DmgReason_IsValid && DmgReasonEffectID_IsValid && DmgReasonEffectIdx_IsValid && BuffOwner_IsValid && DamageCalcType_IsValid && DamageImmueLevel_IsValid && HPMaxINV10000Damage_Abs_IsValid && CameraShakeDA_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SkillDamageConfig", (byte)SkillDamageConfig_IsValid != 0);
	}

	static FSkillDamageConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSkillDamageConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkillDamageConfig));
	}
}
