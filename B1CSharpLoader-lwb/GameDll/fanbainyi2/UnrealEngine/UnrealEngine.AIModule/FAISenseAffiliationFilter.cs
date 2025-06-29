using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AISenseAffiliationFilter", "AIModule", UnrealModuleType.Engine)]
public struct FAISenseAffiliationFilter
{
	private static bool DetectEnemies_IsValid;

	private static FFieldAddress DetectEnemies_PropertyAddress;

	private static int DetectEnemies_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/AIModule.AISenseAffiliationFilter:bDetectEnemies")]
	public bool DetectEnemies;

	private static bool DetectNeutrals_IsValid;

	private static FFieldAddress DetectNeutrals_PropertyAddress;

	private static int DetectNeutrals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/AIModule.AISenseAffiliationFilter:bDetectNeutrals")]
	public bool DetectNeutrals;

	private static bool DetectFriendlies_IsValid;

	private static FFieldAddress DetectFriendlies_PropertyAddress;

	private static int DetectFriendlies_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/AIModule.AISenseAffiliationFilter:bDetectFriendlies")]
	public bool DetectFriendlies;

	private static bool FAISenseAffiliationFilter_IsValid;

	private static int FAISenseAffiliationFilter_StructSize;

	public FAISenseAffiliationFilter Copy()
	{
		return this;
	}

	public static FAISenseAffiliationFilter FromNative(IntPtr nativeBuffer)
	{
		return new FAISenseAffiliationFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAISenseAffiliationFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAISenseAffiliationFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAISenseAffiliationFilter(nativeBuffer + arrayIndex * FAISenseAffiliationFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAISenseAffiliationFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAISenseAffiliationFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAISenseAffiliationFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AISenseAffiliationFilter");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetectEnemies_Offset), 0, DetectEnemies_PropertyAddress.Address, DetectEnemies);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetectNeutrals_Offset), 0, DetectNeutrals_PropertyAddress.Address, DetectNeutrals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetectFriendlies_Offset), 0, DetectFriendlies_PropertyAddress.Address, DetectFriendlies);
	}

	public FAISenseAffiliationFilter(IntPtr nativeStruct)
	{
		if (!FAISenseAffiliationFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AISenseAffiliationFilter");
			DetectEnemies = false;
			DetectNeutrals = false;
			DetectFriendlies = false;
		}
		else
		{
			DetectEnemies = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetectEnemies_Offset), 0, DetectEnemies_PropertyAddress.Address);
			DetectNeutrals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetectNeutrals_Offset), 0, DetectNeutrals_PropertyAddress.Address);
			DetectFriendlies = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetectFriendlies_Offset), 0, DetectFriendlies_PropertyAddress.Address);
		}
	}

	static FAISenseAffiliationFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAISenseAffiliationFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAISenseAffiliationFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AISenseAffiliationFilter");
		FAISenseAffiliationFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DetectEnemies_PropertyAddress, intPtr, "bDetectEnemies");
		DetectEnemies_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDetectEnemies");
		DetectEnemies_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDetectEnemies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectNeutrals_PropertyAddress, intPtr, "bDetectNeutrals");
		DetectNeutrals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDetectNeutrals");
		DetectNeutrals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDetectNeutrals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectFriendlies_PropertyAddress, intPtr, "bDetectFriendlies");
		DetectFriendlies_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDetectFriendlies");
		DetectFriendlies_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDetectFriendlies", Classes.FBoolProperty);
		FAISenseAffiliationFilter_IsValid = intPtr != IntPtr.Zero && DetectEnemies_IsValid && DetectNeutrals_IsValid && DetectFriendlies_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.AISenseAffiliationFilter", FAISenseAffiliationFilter_IsValid);
	}
}
