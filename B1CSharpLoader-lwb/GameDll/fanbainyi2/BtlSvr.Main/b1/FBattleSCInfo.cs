using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BattleSCInfo")]
public struct FBattleSCInfo
{
	[UProperty]
	[DisplayName("消息转义表")]
	[Tooltip("若不填则收到消息直接进行转发")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BattleSCInfo:BattleEventMap")]
	public Dictionary<FGameplayTag, FGameplayTag> BattleEventMap;

	private static int BattleSCInfo_StructSize;

	private static int BattleSCInfo_IsValid;

	private static bool BattleEventMap_IsValid;

	private static int BattleEventMap_Offset;

	private static FFieldAddress BattleEventMap_PropertyAddress;

	public FBattleSCInfo Copy()
	{
		FBattleSCInfo result = this;
		if (BattleEventMap != null)
		{
			result.BattleEventMap = new Dictionary<FGameplayTag, FGameplayTag>(BattleEventMap);
		}
		return result;
	}

	public static FBattleSCInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBattleSCInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBattleSCInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBattleSCInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBattleSCInfo(IntPtr.Add(nativeBuffer, arrayIndex * BattleSCInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBattleSCInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BattleSCInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BattleSCInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleSCInfo");
		}
		else
		{
			new TMapCopyMarshaler<FGameplayTag, FGameplayTag>(1, BattleEventMap_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BattleEventMap_Offset), BattleEventMap);
		}
	}

	public FBattleSCInfo(IntPtr nativeStruct)
	{
		if (BattleSCInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleSCInfo");
			BattleEventMap = null;
		}
		else
		{
			BattleEventMap = new TMapCopyMarshaler<FGameplayTag, FGameplayTag>(1, BattleEventMap_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BattleEventMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BattleSCInfo");
		BattleSCInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BattleEventMap_PropertyAddress, intPtr, "BattleEventMap");
		BattleEventMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleEventMap");
		BattleEventMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleEventMap", Classes.FMapProperty);
		BattleSCInfo_IsValid = ((intPtr != IntPtr.Zero && BattleEventMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BattleSCInfo", (byte)BattleSCInfo_IsValid != 0);
	}

	static FBattleSCInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBattleSCInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBattleSCInfo));
	}
}
