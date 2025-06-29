using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BossRushBattleConfigForGroup")]
public struct FBossRushBattleConfigForGroup
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("关卡数值强度")]
	[USharpPath("/Script/b1-Managed.BossRushBattleConfigForGroup:OverrideLevelNumericalStrength")]
	public int OverrideLevelNumericalStrength;

	[DisplayName("Tamer覆写信息")]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushBattleConfigForGroup:OverridePropertyCollections")]
	public List<FTamerOverridePropertyCollection> OverridePropertyCollections;

	[UProperty]
	[DisplayName("召唤物覆写信息")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushBattleConfigForGroup:OverrideServantExtendID")]
	public List<FServantOverridePropertyCollection> OverrideServantExtendID;

	private static int BossRushBattleConfigForGroup_StructSize;

	private static int BossRushBattleConfigForGroup_IsValid;

	private static bool OverrideLevelNumericalStrength_IsValid;

	private static int OverrideLevelNumericalStrength_Offset;

	private static bool OverridePropertyCollections_IsValid;

	private static int OverridePropertyCollections_Offset;

	private static FFieldAddress OverridePropertyCollections_PropertyAddress;

	private static bool OverrideServantExtendID_IsValid;

	private static int OverrideServantExtendID_Offset;

	private static FFieldAddress OverrideServantExtendID_PropertyAddress;

	public FBossRushBattleConfigForGroup Copy()
	{
		FBossRushBattleConfigForGroup result = this;
		if (OverridePropertyCollections != null)
		{
			result.OverridePropertyCollections = new List<FTamerOverridePropertyCollection>(OverridePropertyCollections);
		}
		if (OverrideServantExtendID != null)
		{
			result.OverrideServantExtendID = new List<FServantOverridePropertyCollection>(OverrideServantExtendID);
		}
		return result;
	}

	public static FBossRushBattleConfigForGroup FromNative(IntPtr nativeBuffer)
	{
		return new FBossRushBattleConfigForGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBossRushBattleConfigForGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBossRushBattleConfigForGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBossRushBattleConfigForGroup(IntPtr.Add(nativeBuffer, arrayIndex * BossRushBattleConfigForGroup_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBossRushBattleConfigForGroup value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BossRushBattleConfigForGroup_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BossRushBattleConfigForGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossRushBattleConfigForGroup");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OverrideLevelNumericalStrength_Offset), OverrideLevelNumericalStrength);
		new TArrayCopyMarshaler<FTamerOverridePropertyCollection>(1, OverridePropertyCollections_PropertyAddress, CachedMarshalingDelegates<FTamerOverridePropertyCollection, FTamerOverridePropertyCollection>.FromNative, CachedMarshalingDelegates<FTamerOverridePropertyCollection, FTamerOverridePropertyCollection>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverridePropertyCollections_Offset), OverridePropertyCollections);
		new TArrayCopyMarshaler<FServantOverridePropertyCollection>(1, OverrideServantExtendID_PropertyAddress, CachedMarshalingDelegates<FServantOverridePropertyCollection, BlittableTypeMarshaler<FServantOverridePropertyCollection>>.FromNative, CachedMarshalingDelegates<FServantOverridePropertyCollection, BlittableTypeMarshaler<FServantOverridePropertyCollection>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverrideServantExtendID_Offset), OverrideServantExtendID);
	}

	public FBossRushBattleConfigForGroup(IntPtr nativeStruct)
	{
		if (BossRushBattleConfigForGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossRushBattleConfigForGroup");
			OverrideLevelNumericalStrength = 0;
			OverridePropertyCollections = null;
			OverrideServantExtendID = null;
		}
		else
		{
			OverrideLevelNumericalStrength = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OverrideLevelNumericalStrength_Offset));
			OverridePropertyCollections = new TArrayCopyMarshaler<FTamerOverridePropertyCollection>(1, OverridePropertyCollections_PropertyAddress, CachedMarshalingDelegates<FTamerOverridePropertyCollection, FTamerOverridePropertyCollection>.FromNative, CachedMarshalingDelegates<FTamerOverridePropertyCollection, FTamerOverridePropertyCollection>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverridePropertyCollections_Offset));
			OverrideServantExtendID = new TArrayCopyMarshaler<FServantOverridePropertyCollection>(1, OverrideServantExtendID_PropertyAddress, CachedMarshalingDelegates<FServantOverridePropertyCollection, BlittableTypeMarshaler<FServantOverridePropertyCollection>>.FromNative, CachedMarshalingDelegates<FServantOverridePropertyCollection, BlittableTypeMarshaler<FServantOverridePropertyCollection>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverrideServantExtendID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BossRushBattleConfigForGroup");
		BossRushBattleConfigForGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		OverrideLevelNumericalStrength_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideLevelNumericalStrength");
		OverrideLevelNumericalStrength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideLevelNumericalStrength", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OverridePropertyCollections_PropertyAddress, intPtr, "OverridePropertyCollections");
		OverridePropertyCollections_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverridePropertyCollections");
		OverridePropertyCollections_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverridePropertyCollections", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideServantExtendID_PropertyAddress, intPtr, "OverrideServantExtendID");
		OverrideServantExtendID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideServantExtendID");
		OverrideServantExtendID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideServantExtendID", Classes.FArrayProperty);
		BossRushBattleConfigForGroup_IsValid = ((intPtr != IntPtr.Zero && OverrideLevelNumericalStrength_IsValid && OverridePropertyCollections_IsValid && OverrideServantExtendID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BossRushBattleConfigForGroup", (byte)BossRushBattleConfigForGroup_IsValid != 0);
	}

	static FBossRushBattleConfigForGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBossRushBattleConfigForGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBossRushBattleConfigForGroup));
	}
}
