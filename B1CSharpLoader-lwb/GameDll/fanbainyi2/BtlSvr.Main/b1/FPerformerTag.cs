using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PerformerTag")]
public struct FPerformerTag
{
	[DisplayName("演员标记（GameplayTag)")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerTag:GameplayTagContainer")]
	public FGameplayTagContainer GameplayTagContainer;

	[DisplayName("演员标记（普通字符）")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerTag:Name")]
	public List<FName> Name;

	private static int PerformerTag_StructSize;

	private static int PerformerTag_IsValid;

	private static bool GameplayTagContainer_IsValid;

	private static int GameplayTagContainer_Offset;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static FFieldAddress Name_PropertyAddress;

	public FPerformerTag Copy()
	{
		FPerformerTag result = this;
		if (Name != null)
		{
			result.Name = new List<FName>(Name);
		}
		return result;
	}

	public static FPerformerTag FromNative(IntPtr nativeBuffer)
	{
		return new FPerformerTag(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerformerTag value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerformerTag FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerformerTag(IntPtr.Add(nativeBuffer, arrayIndex * PerformerTag_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerformerTag value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PerformerTag_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PerformerTag_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerTag");
			return;
		}
		FGameplayTagContainer.ToNative(IntPtr.Add(nativeStruct, GameplayTagContainer_Offset), GameplayTagContainer);
		new TArrayCopyMarshaler<FName>(1, Name_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FPerformerTag(IntPtr nativeStruct)
	{
		if (PerformerTag_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerTag");
			GameplayTagContainer = default(FGameplayTagContainer);
			Name = null;
		}
		else
		{
			GameplayTagContainer = FGameplayTagContainer.FromNative(IntPtr.Add(nativeStruct, GameplayTagContainer_Offset));
			Name = new TArrayCopyMarshaler<FName>(1, Name_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PerformerTag");
		PerformerTag_StructSize = NativeReflection.GetStructSize(intPtr);
		GameplayTagContainer_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameplayTagContainer");
		GameplayTagContainer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameplayTagContainer", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Name_PropertyAddress, intPtr, "Name");
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FArrayProperty);
		PerformerTag_IsValid = ((intPtr != IntPtr.Zero && GameplayTagContainer_IsValid && Name_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PerformerTag", (byte)PerformerTag_IsValid != 0);
	}

	static FPerformerTag()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPerformerTag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerformerTag));
	}
}
