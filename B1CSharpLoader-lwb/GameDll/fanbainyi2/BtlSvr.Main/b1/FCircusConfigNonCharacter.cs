using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CircusConfigNonCharacter")]
public struct FCircusConfigNonCharacter
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("别名")]
	[USharpPath("/Script/b1-Managed.CircusConfigNonCharacter:NickName")]
	public List<FGameplayTag> NickName;

	private static int CircusConfigNonCharacter_StructSize;

	private static int CircusConfigNonCharacter_IsValid;

	private static bool NickName_IsValid;

	private static int NickName_Offset;

	private static FFieldAddress NickName_PropertyAddress;

	public FCircusConfigNonCharacter Copy()
	{
		FCircusConfigNonCharacter result = this;
		if (NickName != null)
		{
			result.NickName = new List<FGameplayTag>(NickName);
		}
		return result;
	}

	public static FCircusConfigNonCharacter FromNative(IntPtr nativeBuffer)
	{
		return new FCircusConfigNonCharacter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCircusConfigNonCharacter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCircusConfigNonCharacter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCircusConfigNonCharacter(IntPtr.Add(nativeBuffer, arrayIndex * CircusConfigNonCharacter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCircusConfigNonCharacter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CircusConfigNonCharacter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CircusConfigNonCharacter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusConfigNonCharacter");
		}
		else
		{
			new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NickName_Offset), NickName);
		}
	}

	public FCircusConfigNonCharacter(IntPtr nativeStruct)
	{
		if (CircusConfigNonCharacter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusConfigNonCharacter");
			NickName = null;
		}
		else
		{
			NickName = new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NickName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CircusConfigNonCharacter");
		CircusConfigNonCharacter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref NickName_PropertyAddress, intPtr, "NickName");
		NickName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NickName");
		NickName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NickName", Classes.FArrayProperty);
		CircusConfigNonCharacter_IsValid = ((intPtr != IntPtr.Zero && NickName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CircusConfigNonCharacter", (byte)CircusConfigNonCharacter_IsValid != 0);
	}

	static FCircusConfigNonCharacter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCircusConfigNonCharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCircusConfigNonCharacter));
	}
}
