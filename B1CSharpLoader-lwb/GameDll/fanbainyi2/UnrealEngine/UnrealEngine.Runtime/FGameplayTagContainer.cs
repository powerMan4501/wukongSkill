using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 6430211)]
[BlueprintType]
[UMetaPath("/Script/GameplayTags.GameplayTagContainer", "GameplayTags", UnrealModuleType.Engine)]
public struct FGameplayTagContainer
{
	private static bool GameplayTags_IsValid;

	private static FFieldAddress GameplayTags_PropertyAddress;

	private static int GameplayTags_Offset;

	[UProperty(Flags = (PropFlags)9015995364672005uL)]
	[UMetaPath("/Script/GameplayTags.GameplayTagContainer:GameplayTags")]
	public List<FGameplayTag> GameplayTags;

	private static bool FGameplayTagContainer_IsValid;

	private static int FGameplayTagContainer_StructSize;

	public FGameplayTagContainer Copy()
	{
		FGameplayTagContainer result = this;
		if (GameplayTags != null)
		{
			result.GameplayTags = new List<FGameplayTag>(GameplayTags);
		}
		return result;
	}

	public static FGameplayTagContainer FromNative(IntPtr nativeBuffer)
	{
		return new FGameplayTagContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGameplayTagContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGameplayTagContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGameplayTagContainer(nativeBuffer + arrayIndex * FGameplayTagContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGameplayTagContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGameplayTagContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagContainer");
		}
		else
		{
			new TArrayCopyMarshaler<FGameplayTag>(1, GameplayTags_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(nativeStruct, GameplayTags_Offset), GameplayTags);
		}
	}

	public FGameplayTagContainer(IntPtr nativeStruct)
	{
		if (!FGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagContainer");
			GameplayTags = null;
		}
		else
		{
			GameplayTags = new TArrayCopyMarshaler<FGameplayTag>(1, GameplayTags_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(nativeStruct, GameplayTags_Offset));
		}
	}

	static FGameplayTagContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGameplayTagContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGameplayTagContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayTags.GameplayTagContainer");
		FGameplayTagContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref GameplayTags_PropertyAddress, intPtr, "GameplayTags");
		GameplayTags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameplayTags");
		GameplayTags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameplayTags", Classes.FArrayProperty);
		FGameplayTagContainer_IsValid = intPtr != IntPtr.Zero && GameplayTags_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayTags.GameplayTagContainer", FGameplayTagContainer_IsValid);
	}
}
