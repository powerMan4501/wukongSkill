using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitCDesc")]
public struct FUnitCDesc
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitCDesc:Weapons")]
	public List<FUnitWeapon> Weapons;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCDesc:ResID")]
	public int ResID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("覆盖战斗信息扩展ID")]
	[Tooltip("默认为0，读取的是UnitC表里配置的值（ResID*100+1）；ID规则，ResID * 100 + [1 ~ 99]")]
	[USharpPath("/Script/b1-Managed.UnitCDesc:OverrideID")]
	public int OverrideID;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitCDesc:BirthBuffs")]
	public List<int> BirthBuffs;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitCDesc:StealthSkillIDPair")]
	public FUnitSealthSkillIDPair StealthSkillIDPair;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCDesc:PhysicBlendInfos")]
	public List<FPhysicBlendInfo> PhysicBlendInfos;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCDesc:PhysicBlendWeight")]
	public float PhysicBlendWeight;

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[Category("BeAttackedConfig")]
	[UMeta(MDProp.ClampMin, "-180")]
	[USharpPath("/Script/b1-Managed.UnitCDesc:BeAttackedDirForwardRight")]
	public float BeAttackedDirForwardRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BeAttackedConfig")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[USharpPath("/Script/b1-Managed.UnitCDesc:BeAttackedDirForwardLeft")]
	public float BeAttackedDirForwardLeft;

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[Category("BeAttackedConfig")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitCDesc:BeAttackedDirBackwardLeft")]
	public float BeAttackedDirBackwardLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BeAttackedConfig")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[USharpPath("/Script/b1-Managed.UnitCDesc:BeAttackedDirBackwardRight")]
	public float BeAttackedDirBackwardRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCDesc:bSurfaceTypeTraceFromPelvis")]
	public bool bSurfaceTypeTraceFromPelvis;

	private static int UnitCDesc_StructSize;

	private static int UnitCDesc_IsValid;

	private static bool Weapons_IsValid;

	private static int Weapons_Offset;

	private static FFieldAddress Weapons_PropertyAddress;

	private static bool ResID_IsValid;

	private static int ResID_Offset;

	private static bool OverrideID_IsValid;

	private static int OverrideID_Offset;

	private static bool BirthBuffs_IsValid;

	private static int BirthBuffs_Offset;

	private static FFieldAddress BirthBuffs_PropertyAddress;

	private static bool StealthSkillIDPair_IsValid;

	private static int StealthSkillIDPair_Offset;

	private static bool PhysicBlendInfos_IsValid;

	private static int PhysicBlendInfos_Offset;

	private static FFieldAddress PhysicBlendInfos_PropertyAddress;

	private static bool PhysicBlendWeight_IsValid;

	private static int PhysicBlendWeight_Offset;

	private static bool BeAttackedDirForwardRight_IsValid;

	private static int BeAttackedDirForwardRight_Offset;

	private static bool BeAttackedDirForwardLeft_IsValid;

	private static int BeAttackedDirForwardLeft_Offset;

	private static bool BeAttackedDirBackwardLeft_IsValid;

	private static int BeAttackedDirBackwardLeft_Offset;

	private static bool BeAttackedDirBackwardRight_IsValid;

	private static int BeAttackedDirBackwardRight_Offset;

	private static bool bSurfaceTypeTraceFromPelvis_IsValid;

	private static int bSurfaceTypeTraceFromPelvis_Offset;

	private static FFieldAddress bSurfaceTypeTraceFromPelvis_PropertyAddress;

	public FUnitCDesc Copy()
	{
		FUnitCDesc result = this;
		if (Weapons != null)
		{
			result.Weapons = new List<FUnitWeapon>(Weapons);
		}
		if (BirthBuffs != null)
		{
			result.BirthBuffs = new List<int>(BirthBuffs);
		}
		if (PhysicBlendInfos != null)
		{
			result.PhysicBlendInfos = new List<FPhysicBlendInfo>(PhysicBlendInfos);
		}
		return result;
	}

	public static FUnitCDesc FromNative(IntPtr nativeBuffer)
	{
		return new FUnitCDesc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitCDesc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitCDesc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitCDesc(IntPtr.Add(nativeBuffer, arrayIndex * UnitCDesc_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitCDesc value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitCDesc_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitCDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitCDesc");
			return;
		}
		new TArrayCopyMarshaler<FUnitWeapon>(1, Weapons_PropertyAddress, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.FromNative, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.ToNative).ToNative(IntPtr.Add(nativeStruct, Weapons_Offset), Weapons);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResID_Offset), ResID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OverrideID_Offset), OverrideID);
		new TArrayCopyMarshaler<int>(1, BirthBuffs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BirthBuffs_Offset), BirthBuffs);
		BlittableTypeMarshaler<FUnitSealthSkillIDPair>.ToNative(IntPtr.Add(nativeStruct, StealthSkillIDPair_Offset), StealthSkillIDPair);
		new TArrayCopyMarshaler<FPhysicBlendInfo>(1, PhysicBlendInfos_PropertyAddress, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.FromNative, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, PhysicBlendInfos_Offset), PhysicBlendInfos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PhysicBlendWeight_Offset), PhysicBlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeAttackedDirForwardRight_Offset), BeAttackedDirForwardRight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeAttackedDirForwardLeft_Offset), BeAttackedDirForwardLeft);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeAttackedDirBackwardLeft_Offset), BeAttackedDirBackwardLeft);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeAttackedDirBackwardRight_Offset), BeAttackedDirBackwardRight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSurfaceTypeTraceFromPelvis_Offset), 0, bSurfaceTypeTraceFromPelvis_PropertyAddress.Address, bSurfaceTypeTraceFromPelvis);
	}

	public FUnitCDesc(IntPtr nativeStruct)
	{
		if (UnitCDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitCDesc");
			Weapons = null;
			ResID = 0;
			OverrideID = 0;
			BirthBuffs = null;
			StealthSkillIDPair = default(FUnitSealthSkillIDPair);
			PhysicBlendInfos = null;
			PhysicBlendWeight = 0f;
			BeAttackedDirForwardRight = 0f;
			BeAttackedDirForwardLeft = 0f;
			BeAttackedDirBackwardLeft = 0f;
			BeAttackedDirBackwardRight = 0f;
			bSurfaceTypeTraceFromPelvis = false;
		}
		else
		{
			Weapons = new TArrayCopyMarshaler<FUnitWeapon>(1, Weapons_PropertyAddress, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.FromNative, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.ToNative).FromNative(IntPtr.Add(nativeStruct, Weapons_Offset));
			ResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResID_Offset));
			OverrideID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OverrideID_Offset));
			BirthBuffs = new TArrayCopyMarshaler<int>(1, BirthBuffs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BirthBuffs_Offset));
			StealthSkillIDPair = BlittableTypeMarshaler<FUnitSealthSkillIDPair>.FromNative(IntPtr.Add(nativeStruct, StealthSkillIDPair_Offset));
			PhysicBlendInfos = new TArrayCopyMarshaler<FPhysicBlendInfo>(1, PhysicBlendInfos_PropertyAddress, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.FromNative, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, PhysicBlendInfos_Offset));
			PhysicBlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PhysicBlendWeight_Offset));
			BeAttackedDirForwardRight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeAttackedDirForwardRight_Offset));
			BeAttackedDirForwardLeft = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeAttackedDirForwardLeft_Offset));
			BeAttackedDirBackwardLeft = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeAttackedDirBackwardLeft_Offset));
			BeAttackedDirBackwardRight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeAttackedDirBackwardRight_Offset));
			bSurfaceTypeTraceFromPelvis = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSurfaceTypeTraceFromPelvis_Offset), 0, bSurfaceTypeTraceFromPelvis_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitCDesc");
		UnitCDesc_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Weapons_PropertyAddress, intPtr, "Weapons");
		Weapons_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weapons");
		Weapons_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weapons", Classes.FArrayProperty);
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
		OverrideID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideID");
		OverrideID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BirthBuffs_PropertyAddress, intPtr, "BirthBuffs");
		BirthBuffs_Offset = NativeReflection.GetPropertyOffset(intPtr, "BirthBuffs");
		BirthBuffs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BirthBuffs", Classes.FArrayProperty);
		StealthSkillIDPair_Offset = NativeReflection.GetPropertyOffset(intPtr, "StealthSkillIDPair");
		StealthSkillIDPair_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StealthSkillIDPair", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PhysicBlendInfos_PropertyAddress, intPtr, "PhysicBlendInfos");
		PhysicBlendInfos_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendInfos");
		PhysicBlendInfos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendInfos", Classes.FArrayProperty);
		PhysicBlendWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendWeight");
		PhysicBlendWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendWeight", Classes.FFloatProperty);
		BeAttackedDirForwardRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedDirForwardRight");
		BeAttackedDirForwardRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedDirForwardRight", Classes.FFloatProperty);
		BeAttackedDirForwardLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedDirForwardLeft");
		BeAttackedDirForwardLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedDirForwardLeft", Classes.FFloatProperty);
		BeAttackedDirBackwardLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedDirBackwardLeft");
		BeAttackedDirBackwardLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedDirBackwardLeft", Classes.FFloatProperty);
		BeAttackedDirBackwardRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedDirBackwardRight");
		BeAttackedDirBackwardRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedDirBackwardRight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bSurfaceTypeTraceFromPelvis_PropertyAddress, intPtr, "bSurfaceTypeTraceFromPelvis");
		bSurfaceTypeTraceFromPelvis_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSurfaceTypeTraceFromPelvis");
		bSurfaceTypeTraceFromPelvis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSurfaceTypeTraceFromPelvis", Classes.FBoolProperty);
		UnitCDesc_IsValid = ((intPtr != IntPtr.Zero && Weapons_IsValid && ResID_IsValid && OverrideID_IsValid && BirthBuffs_IsValid && StealthSkillIDPair_IsValid && PhysicBlendInfos_IsValid && PhysicBlendWeight_IsValid && BeAttackedDirForwardRight_IsValid && BeAttackedDirForwardLeft_IsValid && BeAttackedDirBackwardLeft_IsValid && BeAttackedDirBackwardRight_IsValid && bSurfaceTypeTraceFromPelvis_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitCDesc", (byte)UnitCDesc_IsValid != 0);
	}

	static FUnitCDesc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitCDesc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitCDesc));
	}
}
