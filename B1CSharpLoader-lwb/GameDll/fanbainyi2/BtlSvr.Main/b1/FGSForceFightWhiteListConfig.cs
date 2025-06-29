using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSForceFightWhiteListConfig")]
public struct FGSForceFightWhiteListConfig
{
	[BlueprintReadWrite]
	[DisplayName("不影响玩家")]
	[EditAnywhere]
	[Tooltip("若勾选，则玩家不会作为被触发单位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightWhiteListConfig:IgnorePlayer")]
	public bool IgnorePlayer;

	[VisibleAnywhere]
	[DisplayName("白名单触发单位")]
	[Tooltip("不会被触发的单位列表")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightWhiteListConfig:IgnoreUnits")]
	public List<TSoftObject<BGUCharacterCS>> IgnoreUnits;

	[VisibleAnywhere]
	[UProperty]
	[Tooltip("不会被触发的单位列表")]
	[DisplayName("白名单触发单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightWhiteListConfig:IgnoreTamers")]
	public List<TSoftObject<BUTamerActor>> IgnoreTamers;

	[UProperty]
	[DisplayName("白名单触发单位")]
	[Tooltip("不会被触发的单位列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSForceFightWhiteListConfig:IgnoreTamerRefs")]
	public List<FGsActorGuidReference> IgnoreTamerRefs;

	private static int FGSForceFightWhiteListConfig_StructSize;

	private static int FGSForceFightWhiteListConfig_IsValid;

	private static bool IgnorePlayer_IsValid;

	private static int IgnorePlayer_Offset;

	private static FFieldAddress IgnorePlayer_PropertyAddress;

	private static bool IgnoreUnits_IsValid;

	private static int IgnoreUnits_Offset;

	private static FFieldAddress IgnoreUnits_PropertyAddress;

	private static bool IgnoreTamers_IsValid;

	private static int IgnoreTamers_Offset;

	private static FFieldAddress IgnoreTamers_PropertyAddress;

	private static bool IgnoreTamerRefs_IsValid;

	private static int IgnoreTamerRefs_Offset;

	private static FFieldAddress IgnoreTamerRefs_PropertyAddress;

	public FGSForceFightWhiteListConfig Copy()
	{
		FGSForceFightWhiteListConfig result = this;
		if (IgnoreUnits != null)
		{
			result.IgnoreUnits = new List<TSoftObject<BGUCharacterCS>>(IgnoreUnits);
		}
		if (IgnoreTamers != null)
		{
			result.IgnoreTamers = new List<TSoftObject<BUTamerActor>>(IgnoreTamers);
		}
		if (IgnoreTamerRefs != null)
		{
			result.IgnoreTamerRefs = new List<FGsActorGuidReference>(IgnoreTamerRefs);
		}
		return result;
	}

	public static FGSForceFightWhiteListConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSForceFightWhiteListConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSForceFightWhiteListConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSForceFightWhiteListConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSForceFightWhiteListConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightWhiteListConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSForceFightWhiteListConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightWhiteListConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSForceFightWhiteListConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightWhiteListConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnorePlayer_Offset), 0, IgnorePlayer_PropertyAddress.Address, IgnorePlayer);
		new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, IgnoreUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, IgnoreUnits_Offset), IgnoreUnits);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, IgnoreTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, IgnoreTamers_Offset), IgnoreTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, IgnoreTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, IgnoreTamerRefs_Offset), IgnoreTamerRefs);
	}

	public FGSForceFightWhiteListConfig(IntPtr nativeStruct)
	{
		if (FGSForceFightWhiteListConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightWhiteListConfig");
			IgnorePlayer = false;
			IgnoreUnits = null;
			IgnoreTamers = null;
			IgnoreTamerRefs = null;
		}
		else
		{
			IgnorePlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnorePlayer_Offset), 0, IgnorePlayer_PropertyAddress.Address);
			IgnoreUnits = new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, IgnoreUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, IgnoreUnits_Offset));
			IgnoreTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, IgnoreTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, IgnoreTamers_Offset));
			IgnoreTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, IgnoreTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, IgnoreTamerRefs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSForceFightWhiteListConfig");
		FGSForceFightWhiteListConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref IgnorePlayer_PropertyAddress, intPtr, "IgnorePlayer");
		IgnorePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnorePlayer");
		IgnorePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnorePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IgnoreUnits_PropertyAddress, intPtr, "IgnoreUnits");
		IgnoreUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreUnits");
		IgnoreUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoreTamers_PropertyAddress, intPtr, "IgnoreTamers");
		IgnoreTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreTamers");
		IgnoreTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoreTamerRefs_PropertyAddress, intPtr, "IgnoreTamerRefs");
		IgnoreTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreTamerRefs");
		IgnoreTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreTamerRefs", Classes.FArrayProperty);
		FGSForceFightWhiteListConfig_IsValid = ((intPtr != IntPtr.Zero && IgnorePlayer_IsValid && IgnoreUnits_IsValid && IgnoreTamers_IsValid && IgnoreTamerRefs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSForceFightWhiteListConfig", (byte)FGSForceFightWhiteListConfig_IsValid != 0);
	}

	static FGSForceFightWhiteListConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSForceFightWhiteListConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSForceFightWhiteListConfig));
	}
}
