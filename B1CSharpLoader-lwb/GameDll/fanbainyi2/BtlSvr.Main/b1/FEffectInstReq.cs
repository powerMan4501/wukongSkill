using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EffectInstReq")]
public struct FEffectInstReq
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:ObjectID")]
	public int ObjectID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitLocation")]
	public FVector HitLocation;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitPointNormalDir")]
	public FRotator HitPointNormalDir;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitActionDir")]
	public EHitActionDir HitActionDir;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:SweepCheckBegin")]
	public FVector SweepCheckBegin;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:SweepCheckEnd")]
	public FVector SweepCheckEnd;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitDiretionRealDir")]
	public FVector HitDiretionRealDir;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitBoneName")]
	public FName HitBoneName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitComp")]
	public UPrimitiveComponent HitComp;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:Attacker")]
	public AActor Attacker;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:AudioID_HitChr")]
	public int AudioID_HitChr;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:FXWeight_HitChr")]
	public int FXWeight_HitChr;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:TriggerSkillId")]
	public int TriggerSkillId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:bFromBullet")]
	public bool bFromBullet;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:LaserStiffDir")]
	public FRotator LaserStiffDir;

	[UProperty]
	[USharpPath("/Script/b1-Managed.EffectInstReq:HitPartID")]
	public int HitPartID;

	private static int EffectInstReq_StructSize;

	private static int EffectInstReq_IsValid;

	private static bool ObjectID_IsValid;

	private static int ObjectID_Offset;

	private static bool HitLocation_IsValid;

	private static int HitLocation_Offset;

	private static bool HitPointNormalDir_IsValid;

	private static int HitPointNormalDir_Offset;

	private static bool HitActionDir_IsValid;

	private static int HitActionDir_Offset;

	private static FFieldAddress HitActionDir_PropertyAddress;

	private static bool SweepCheckBegin_IsValid;

	private static int SweepCheckBegin_Offset;

	private static bool SweepCheckEnd_IsValid;

	private static int SweepCheckEnd_Offset;

	private static bool HitDiretionRealDir_IsValid;

	private static int HitDiretionRealDir_Offset;

	private static bool HitBoneName_IsValid;

	private static int HitBoneName_Offset;

	private static bool HitComp_IsValid;

	private static int HitComp_Offset;

	private static bool Attacker_IsValid;

	private static int Attacker_Offset;

	private static bool AudioID_HitChr_IsValid;

	private static int AudioID_HitChr_Offset;

	private static bool FXWeight_HitChr_IsValid;

	private static int FXWeight_HitChr_Offset;

	private static bool TriggerSkillId_IsValid;

	private static int TriggerSkillId_Offset;

	private static bool bFromBullet_IsValid;

	private static int bFromBullet_Offset;

	private static FFieldAddress bFromBullet_PropertyAddress;

	private static bool LaserStiffDir_IsValid;

	private static int LaserStiffDir_Offset;

	private static bool HitPartID_IsValid;

	private static int HitPartID_Offset;

	public FEffectInstReq(AActor iAttacker)
	{
		this = default(FEffectInstReq);
		Attacker = iAttacker;
	}

	public FEffectInstReq Copy()
	{
		return this;
	}

	public static FEffectInstReq FromNative(IntPtr nativeBuffer)
	{
		return new FEffectInstReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEffectInstReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEffectInstReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEffectInstReq(IntPtr.Add(nativeBuffer, arrayIndex * EffectInstReq_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEffectInstReq value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EffectInstReq_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EffectInstReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EffectInstReq");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ObjectID_Offset), ObjectID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitLocation_Offset), HitLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, HitPointNormalDir_Offset), HitPointNormalDir);
		EnumMarshaler<EHitActionDir>.ToNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address, HitActionDir);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SweepCheckBegin_Offset), SweepCheckBegin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SweepCheckEnd_Offset), SweepCheckEnd);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitDiretionRealDir_Offset), HitDiretionRealDir);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, HitBoneName_Offset), HitBoneName);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, HitComp_Offset), HitComp);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Attacker_Offset), Attacker);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AudioID_HitChr_Offset), AudioID_HitChr);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FXWeight_HitChr_Offset), FXWeight_HitChr);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerSkillId_Offset), TriggerSkillId);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFromBullet_Offset), 0, bFromBullet_PropertyAddress.Address, bFromBullet);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, LaserStiffDir_Offset), LaserStiffDir);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HitPartID_Offset), HitPartID);
	}

	public FEffectInstReq(IntPtr nativeStruct)
	{
		if (EffectInstReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EffectInstReq");
			ObjectID = 0;
			HitLocation = default(FVector);
			HitPointNormalDir = default(FRotator);
			HitActionDir = EHitActionDir.Default;
			SweepCheckBegin = default(FVector);
			SweepCheckEnd = default(FVector);
			HitDiretionRealDir = default(FVector);
			HitBoneName = default(FName);
			HitComp = null;
			Attacker = null;
			AudioID_HitChr = 0;
			FXWeight_HitChr = 0;
			TriggerSkillId = 0;
			bFromBullet = false;
			LaserStiffDir = default(FRotator);
			HitPartID = 0;
		}
		else
		{
			ObjectID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ObjectID_Offset));
			HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitLocation_Offset));
			HitPointNormalDir = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, HitPointNormalDir_Offset));
			HitActionDir = EnumMarshaler<EHitActionDir>.FromNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address);
			SweepCheckBegin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SweepCheckBegin_Offset));
			SweepCheckEnd = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SweepCheckEnd_Offset));
			HitDiretionRealDir = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitDiretionRealDir_Offset));
			HitBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, HitBoneName_Offset));
			HitComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, HitComp_Offset));
			Attacker = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Attacker_Offset));
			AudioID_HitChr = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AudioID_HitChr_Offset));
			FXWeight_HitChr = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FXWeight_HitChr_Offset));
			TriggerSkillId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerSkillId_Offset));
			bFromBullet = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFromBullet_Offset), 0, bFromBullet_PropertyAddress.Address);
			LaserStiffDir = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, LaserStiffDir_Offset));
			HitPartID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HitPartID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EffectInstReq");
		EffectInstReq_StructSize = NativeReflection.GetStructSize(intPtr);
		ObjectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObjectID");
		ObjectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObjectID", Classes.FIntProperty);
		HitLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitLocation");
		HitLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitLocation", Classes.FStructProperty);
		HitPointNormalDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitPointNormalDir");
		HitPointNormalDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitPointNormalDir", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref HitActionDir_PropertyAddress, intPtr, "HitActionDir");
		HitActionDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitActionDir");
		HitActionDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitActionDir", Classes.FEnumProperty);
		SweepCheckBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckBegin");
		SweepCheckBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckBegin", Classes.FStructProperty);
		SweepCheckEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckEnd");
		SweepCheckEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckEnd", Classes.FStructProperty);
		HitDiretionRealDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitDiretionRealDir");
		HitDiretionRealDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitDiretionRealDir", Classes.FStructProperty);
		HitBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitBoneName");
		HitBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitBoneName", Classes.FNameProperty);
		HitComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitComp");
		HitComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitComp", Classes.FObjectProperty);
		Attacker_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attacker");
		Attacker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attacker", Classes.FObjectProperty);
		AudioID_HitChr_Offset = NativeReflection.GetPropertyOffset(intPtr, "AudioID_HitChr");
		AudioID_HitChr_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AudioID_HitChr", Classes.FIntProperty);
		FXWeight_HitChr_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXWeight_HitChr");
		FXWeight_HitChr_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXWeight_HitChr", Classes.FIntProperty);
		TriggerSkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerSkillId");
		TriggerSkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerSkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bFromBullet_PropertyAddress, intPtr, "bFromBullet");
		bFromBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFromBullet");
		bFromBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFromBullet", Classes.FBoolProperty);
		LaserStiffDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "LaserStiffDir");
		LaserStiffDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LaserStiffDir", Classes.FStructProperty);
		HitPartID_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitPartID");
		HitPartID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitPartID", Classes.FIntProperty);
		EffectInstReq_IsValid = ((intPtr != IntPtr.Zero && ObjectID_IsValid && HitLocation_IsValid && HitPointNormalDir_IsValid && HitActionDir_IsValid && SweepCheckBegin_IsValid && SweepCheckEnd_IsValid && HitDiretionRealDir_IsValid && HitBoneName_IsValid && HitComp_IsValid && Attacker_IsValid && AudioID_HitChr_IsValid && FXWeight_HitChr_IsValid && TriggerSkillId_IsValid && bFromBullet_IsValid && LaserStiffDir_IsValid && HitPartID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EffectInstReq", (byte)EffectInstReq_IsValid != 0);
	}

	static FEffectInstReq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEffectInstReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEffectInstReq));
	}
}
