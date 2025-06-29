using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CharacterAssetConfig")]
public struct CharacterAssetConfig
{
	[Category("Character Spawn Asset Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("选定角色类型库")]
	[USharpPath("/Script/b1-Managed.CharacterAssetConfig:MobAttackTypeList")]
	public List<EMobAttackType> MobAttackTypeList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Character Spawn Asset Config")]
	[DisplayName("角色最小生成数量")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.CharacterAssetConfig:MinSpawnNum")]
	public int MinSpawnNum;

	[DisplayName("角色最大生成数量")]
	[Category("Character Spawn Asset Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.CharacterAssetConfig:MaxSpawnNum")]
	public int MaxSpawnNum;

	private static int CharacterAssetConfig_StructSize;

	private static int CharacterAssetConfig_IsValid;

	private static bool MobAttackTypeList_IsValid;

	private static int MobAttackTypeList_Offset;

	private static FFieldAddress MobAttackTypeList_PropertyAddress;

	private static bool MinSpawnNum_IsValid;

	private static int MinSpawnNum_Offset;

	private static bool MaxSpawnNum_IsValid;

	private static int MaxSpawnNum_Offset;

	public CharacterAssetConfig Copy()
	{
		CharacterAssetConfig result = this;
		if (MobAttackTypeList != null)
		{
			result.MobAttackTypeList = new List<EMobAttackType>(MobAttackTypeList);
		}
		return result;
	}

	public static CharacterAssetConfig FromNative(IntPtr nativeBuffer)
	{
		return new CharacterAssetConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, CharacterAssetConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static CharacterAssetConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new CharacterAssetConfig(IntPtr.Add(nativeBuffer, arrayIndex * CharacterAssetConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, CharacterAssetConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CharacterAssetConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CharacterAssetConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CharacterAssetConfig");
			return;
		}
		new TArrayCopyMarshaler<EMobAttackType>(1, MobAttackTypeList_PropertyAddress, CachedMarshalingDelegates<EMobAttackType, EnumMarshaler<EMobAttackType>>.FromNative, CachedMarshalingDelegates<EMobAttackType, EnumMarshaler<EMobAttackType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MobAttackTypeList_Offset), MobAttackTypeList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinSpawnNum_Offset), MinSpawnNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxSpawnNum_Offset), MaxSpawnNum);
	}

	public CharacterAssetConfig(IntPtr nativeStruct)
	{
		if (CharacterAssetConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CharacterAssetConfig");
			MobAttackTypeList = null;
			MinSpawnNum = 0;
			MaxSpawnNum = 0;
		}
		else
		{
			MobAttackTypeList = new TArrayCopyMarshaler<EMobAttackType>(1, MobAttackTypeList_PropertyAddress, CachedMarshalingDelegates<EMobAttackType, EnumMarshaler<EMobAttackType>>.FromNative, CachedMarshalingDelegates<EMobAttackType, EnumMarshaler<EMobAttackType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MobAttackTypeList_Offset));
			MinSpawnNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinSpawnNum_Offset));
			MaxSpawnNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxSpawnNum_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CharacterAssetConfig");
		CharacterAssetConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref MobAttackTypeList_PropertyAddress, intPtr, "MobAttackTypeList");
		MobAttackTypeList_Offset = NativeReflection.GetPropertyOffset(intPtr, "MobAttackTypeList");
		MobAttackTypeList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MobAttackTypeList", Classes.FArrayProperty);
		MinSpawnNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinSpawnNum");
		MinSpawnNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinSpawnNum", Classes.FIntProperty);
		MaxSpawnNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSpawnNum");
		MaxSpawnNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSpawnNum", Classes.FIntProperty);
		CharacterAssetConfig_IsValid = ((intPtr != IntPtr.Zero && MobAttackTypeList_IsValid && MinSpawnNum_IsValid && MaxSpawnNum_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CharacterAssetConfig", (byte)CharacterAssetConfig_IsValid != 0);
	}

	static CharacterAssetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CharacterAssetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CharacterAssetConfig));
	}
}
