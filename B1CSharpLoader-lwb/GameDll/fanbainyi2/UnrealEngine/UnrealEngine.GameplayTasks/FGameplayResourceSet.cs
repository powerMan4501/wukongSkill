using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayResourceSet", "GameplayTasks", UnrealModuleType.Engine)]
public struct FGameplayResourceSet
{
	private static bool FGameplayResourceSet_IsValid;

	private static int FGameplayResourceSet_StructSize;

	public FGameplayResourceSet Copy()
	{
		return this;
	}

	public static FGameplayResourceSet FromNative(IntPtr nativeBuffer)
	{
		return new FGameplayResourceSet(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGameplayResourceSet value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGameplayResourceSet FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGameplayResourceSet(nativeBuffer + arrayIndex * FGameplayResourceSet_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGameplayResourceSet value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGameplayResourceSet_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGameplayResourceSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTasks.GameplayResourceSet");
		}
	}

	public FGameplayResourceSet(IntPtr nativeStruct)
	{
		if (!FGameplayResourceSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTasks.GameplayResourceSet");
		}
	}

	static FGameplayResourceSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGameplayResourceSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGameplayResourceSet));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayTasks.GameplayResourceSet");
		FGameplayResourceSet_StructSize = NativeReflection.GetStructSize(intPtr);
		FGameplayResourceSet_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GameplayTasks.GameplayResourceSet", FGameplayResourceSet_IsValid);
	}
}
