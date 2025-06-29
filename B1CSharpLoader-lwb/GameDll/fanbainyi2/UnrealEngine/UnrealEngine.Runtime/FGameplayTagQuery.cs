using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GameplayTags.GameplayTagQuery", "GameplayTags", UnrealModuleType.Engine)]
public struct FGameplayTagQuery
{
	private static bool FGameplayTagQuery_IsValid;

	private static int FGameplayTagQuery_StructSize;

	public FGameplayTagQuery Copy()
	{
		return this;
	}

	public static FGameplayTagQuery FromNative(IntPtr nativeBuffer)
	{
		return new FGameplayTagQuery(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGameplayTagQuery value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGameplayTagQuery FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGameplayTagQuery(nativeBuffer + arrayIndex * FGameplayTagQuery_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGameplayTagQuery value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGameplayTagQuery_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGameplayTagQuery_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagQuery");
		}
	}

	public FGameplayTagQuery(IntPtr nativeStruct)
	{
		if (!FGameplayTagQuery_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagQuery");
		}
	}

	static FGameplayTagQuery()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGameplayTagQuery)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGameplayTagQuery));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayTags.GameplayTagQuery");
		FGameplayTagQuery_StructSize = NativeReflection.GetStructSize(intPtr);
		FGameplayTagQuery_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GameplayTags.GameplayTagQuery", FGameplayTagQuery_IsValid);
	}
}
