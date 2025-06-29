using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BattleAttrSnapShot")]
public struct FBattleAttrSnapShot
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_CritRate")]
	public float Attr_CritRate;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_Atk")]
	public float Attr_Atk;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_CritMultiplier")]
	public float Attr_CritMultiplier;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_DmgAddition")]
	public float Attr_DmgAddition;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_FreezeAtk")]
	public float Attr_FreezeAtk;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_BurnAtk")]
	public float Attr_BurnAtk;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_PoisonAtk")]
	public float Attr_PoisonAtk;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_ThunderAtk")]
	public float Attr_ThunderAtk;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:Attr_IgnoreTargetElemDef")]
	public bool Attr_IgnoreTargetElemDef;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:bSettedFlag")]
	public bool bSettedFlag;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:bDmgFromAbnormal")]
	private bool bDmgFromAbnormal;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleAttrSnapShot:bAttackerIsPlayer_ForDmgNumer")]
	private bool bAttackerIsPlayer_ForDmgNumer;

	private static int BattleAttrSnapShot_StructSize;

	private static int BattleAttrSnapShot_IsValid;

	private static bool Attr_CritRate_IsValid;

	private static int Attr_CritRate_Offset;

	private static bool Attr_Atk_IsValid;

	private static int Attr_Atk_Offset;

	private static bool Attr_CritMultiplier_IsValid;

	private static int Attr_CritMultiplier_Offset;

	private static bool Attr_DmgAddition_IsValid;

	private static int Attr_DmgAddition_Offset;

	private static bool Attr_FreezeAtk_IsValid;

	private static int Attr_FreezeAtk_Offset;

	private static bool Attr_BurnAtk_IsValid;

	private static int Attr_BurnAtk_Offset;

	private static bool Attr_PoisonAtk_IsValid;

	private static int Attr_PoisonAtk_Offset;

	private static bool Attr_ThunderAtk_IsValid;

	private static int Attr_ThunderAtk_Offset;

	private static bool Attr_IgnoreTargetElemDef_IsValid;

	private static int Attr_IgnoreTargetElemDef_Offset;

	private static FFieldAddress Attr_IgnoreTargetElemDef_PropertyAddress;

	private static bool bSettedFlag_IsValid;

	private static int bSettedFlag_Offset;

	private static FFieldAddress bSettedFlag_PropertyAddress;

	private static bool bDmgFromAbnormal_IsValid;

	private static int bDmgFromAbnormal_Offset;

	private static FFieldAddress bDmgFromAbnormal_PropertyAddress;

	private static bool bAttackerIsPlayer_ForDmgNumer_IsValid;

	private static int bAttackerIsPlayer_ForDmgNumer_Offset;

	private static FFieldAddress bAttackerIsPlayer_ForDmgNumer_PropertyAddress;

	public bool AttackerIsPlayer_ForDmgNumer(AActor Attacker)
	{
		if (bDmgFromAbnormal)
		{
			return bAttackerIsPlayer_ForDmgNumer;
		}
		return Attacker is BGUPlayerCharacterCS;
	}

	public FBattleAttrSnapShot(AActor Attacker, bool _bDmgFromAbnormal = false)
	{
		bSettedFlag = true;
		Attr_CritRate = 0f;
		Attr_Atk = 0f;
		Attr_CritMultiplier = 0f;
		Attr_DmgAddition = 0f;
		Attr_FreezeAtk = 0f;
		Attr_BurnAtk = 0f;
		Attr_PoisonAtk = 0f;
		Attr_ThunderAtk = 0f;
		Attr_IgnoreTargetElemDef = false;
		bAttackerIsPlayer_ForDmgNumer = false;
		bDmgFromAbnormal = _bDmgFromAbnormal;
		if (Attacker == null)
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = Attacker as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor != null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
			if (readOnlyData != null)
			{
				Attacker = readOnlyData.GetMasterActor();
			}
		}
		bAttackerIsPlayer_ForDmgNumer = Attacker is BGUPlayerCharacterCS;
		BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Attacker);
		if (readOnlyData2 != null)
		{
			Attr_CritRate = readOnlyData2.GetFloatValue(EBGUAttrFloat.CritRate);
			Attr_Atk = readOnlyData2.GetFloatValue(EBGUAttrFloat.Atk);
			Attr_CritMultiplier = readOnlyData2.GetFloatValue(EBGUAttrFloat.CritMultiplier);
			Attr_DmgAddition = readOnlyData2.GetFloatValue(EBGUAttrFloat.DmgAddition);
			Attr_FreezeAtk = readOnlyData2.GetFloatValue(EBGUAttrFloat.FreezeAtk);
			Attr_BurnAtk = readOnlyData2.GetFloatValue(EBGUAttrFloat.BurnAtk);
			Attr_PoisonAtk = readOnlyData2.GetFloatValue(EBGUAttrFloat.PoisonAtk);
			Attr_ThunderAtk = readOnlyData2.GetFloatValue(EBGUAttrFloat.ThunderAtk);
			Attr_IgnoreTargetElemDef = BGUFunctionLibraryCS.BGUHasUnitSimpleState(Attacker, EBGUSimpleState.IgnoreTargetElemDef);
		}
	}

	public FBattleAttrSnapShot Copy()
	{
		return this;
	}

	public static FBattleAttrSnapShot FromNative(IntPtr nativeBuffer)
	{
		return new FBattleAttrSnapShot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBattleAttrSnapShot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBattleAttrSnapShot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBattleAttrSnapShot(IntPtr.Add(nativeBuffer, arrayIndex * BattleAttrSnapShot_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBattleAttrSnapShot value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BattleAttrSnapShot_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BattleAttrSnapShot_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleAttrSnapShot");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_CritRate_Offset), Attr_CritRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_Atk_Offset), Attr_Atk);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_CritMultiplier_Offset), Attr_CritMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_DmgAddition_Offset), Attr_DmgAddition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_FreezeAtk_Offset), Attr_FreezeAtk);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_BurnAtk_Offset), Attr_BurnAtk);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_PoisonAtk_Offset), Attr_PoisonAtk);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Attr_ThunderAtk_Offset), Attr_ThunderAtk);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Attr_IgnoreTargetElemDef_Offset), 0, Attr_IgnoreTargetElemDef_PropertyAddress.Address, Attr_IgnoreTargetElemDef);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSettedFlag_Offset), 0, bSettedFlag_PropertyAddress.Address, bSettedFlag);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDmgFromAbnormal_Offset), 0, bDmgFromAbnormal_PropertyAddress.Address, bDmgFromAbnormal);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bAttackerIsPlayer_ForDmgNumer_Offset), 0, bAttackerIsPlayer_ForDmgNumer_PropertyAddress.Address, bAttackerIsPlayer_ForDmgNumer);
	}

	public FBattleAttrSnapShot(IntPtr nativeStruct)
	{
		if (BattleAttrSnapShot_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleAttrSnapShot");
			Attr_CritRate = 0f;
			Attr_Atk = 0f;
			Attr_CritMultiplier = 0f;
			Attr_DmgAddition = 0f;
			Attr_FreezeAtk = 0f;
			Attr_BurnAtk = 0f;
			Attr_PoisonAtk = 0f;
			Attr_ThunderAtk = 0f;
			Attr_IgnoreTargetElemDef = false;
			bSettedFlag = false;
			bDmgFromAbnormal = false;
			bAttackerIsPlayer_ForDmgNumer = false;
		}
		else
		{
			Attr_CritRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_CritRate_Offset));
			Attr_Atk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_Atk_Offset));
			Attr_CritMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_CritMultiplier_Offset));
			Attr_DmgAddition = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_DmgAddition_Offset));
			Attr_FreezeAtk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_FreezeAtk_Offset));
			Attr_BurnAtk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_BurnAtk_Offset));
			Attr_PoisonAtk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_PoisonAtk_Offset));
			Attr_ThunderAtk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Attr_ThunderAtk_Offset));
			Attr_IgnoreTargetElemDef = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Attr_IgnoreTargetElemDef_Offset), 0, Attr_IgnoreTargetElemDef_PropertyAddress.Address);
			bSettedFlag = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSettedFlag_Offset), 0, bSettedFlag_PropertyAddress.Address);
			bDmgFromAbnormal = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDmgFromAbnormal_Offset), 0, bDmgFromAbnormal_PropertyAddress.Address);
			bAttackerIsPlayer_ForDmgNumer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bAttackerIsPlayer_ForDmgNumer_Offset), 0, bAttackerIsPlayer_ForDmgNumer_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BattleAttrSnapShot");
		BattleAttrSnapShot_StructSize = NativeReflection.GetStructSize(intPtr);
		Attr_CritRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_CritRate");
		Attr_CritRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_CritRate", Classes.FFloatProperty);
		Attr_Atk_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_Atk");
		Attr_Atk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_Atk", Classes.FFloatProperty);
		Attr_CritMultiplier_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_CritMultiplier");
		Attr_CritMultiplier_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_CritMultiplier", Classes.FFloatProperty);
		Attr_DmgAddition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_DmgAddition");
		Attr_DmgAddition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_DmgAddition", Classes.FFloatProperty);
		Attr_FreezeAtk_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_FreezeAtk");
		Attr_FreezeAtk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_FreezeAtk", Classes.FFloatProperty);
		Attr_BurnAtk_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_BurnAtk");
		Attr_BurnAtk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_BurnAtk", Classes.FFloatProperty);
		Attr_PoisonAtk_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_PoisonAtk");
		Attr_PoisonAtk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_PoisonAtk", Classes.FFloatProperty);
		Attr_ThunderAtk_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_ThunderAtk");
		Attr_ThunderAtk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_ThunderAtk", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Attr_IgnoreTargetElemDef_PropertyAddress, intPtr, "Attr_IgnoreTargetElemDef");
		Attr_IgnoreTargetElemDef_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr_IgnoreTargetElemDef");
		Attr_IgnoreTargetElemDef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr_IgnoreTargetElemDef", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSettedFlag_PropertyAddress, intPtr, "bSettedFlag");
		bSettedFlag_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSettedFlag");
		bSettedFlag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSettedFlag", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDmgFromAbnormal_PropertyAddress, intPtr, "bDmgFromAbnormal");
		bDmgFromAbnormal_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDmgFromAbnormal");
		bDmgFromAbnormal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDmgFromAbnormal", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAttackerIsPlayer_ForDmgNumer_PropertyAddress, intPtr, "bAttackerIsPlayer_ForDmgNumer");
		bAttackerIsPlayer_ForDmgNumer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttackerIsPlayer_ForDmgNumer");
		bAttackerIsPlayer_ForDmgNumer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttackerIsPlayer_ForDmgNumer", Classes.FBoolProperty);
		BattleAttrSnapShot_IsValid = ((intPtr != IntPtr.Zero && Attr_CritRate_IsValid && Attr_Atk_IsValid && Attr_CritMultiplier_IsValid && Attr_DmgAddition_IsValid && Attr_FreezeAtk_IsValid && Attr_BurnAtk_IsValid && Attr_PoisonAtk_IsValid && Attr_ThunderAtk_IsValid && Attr_IgnoreTargetElemDef_IsValid && bSettedFlag_IsValid && bDmgFromAbnormal_IsValid && bAttackerIsPlayer_ForDmgNumer_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BattleAttrSnapShot", (byte)BattleAttrSnapShot_IsValid != 0);
	}

	static FBattleAttrSnapShot()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBattleAttrSnapShot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBattleAttrSnapShot));
	}
}
