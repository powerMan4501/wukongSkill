using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CircusConfig")]
public struct FCircusConfig
{
	[DisplayName("默认出生")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusConfig:SpawnByDefault")]
	public bool SpawnByDefault;

	[DisplayName("别名")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusConfig:NickName")]
	public List<FGameplayTag> NickName;

	private static int CircusConfig_StructSize;

	private static int CircusConfig_IsValid;

	private static bool SpawnByDefault_IsValid;

	private static int SpawnByDefault_Offset;

	private static FFieldAddress SpawnByDefault_PropertyAddress;

	private static bool NickName_IsValid;

	private static int NickName_Offset;

	private static FFieldAddress NickName_PropertyAddress;

	public FCircusConfig Copy()
	{
		FCircusConfig result = this;
		if (NickName != null)
		{
			result.NickName = new List<FGameplayTag>(NickName);
		}
		return result;
	}

	public static FCircusConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCircusConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCircusConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCircusConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCircusConfig(IntPtr.Add(nativeBuffer, arrayIndex * CircusConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCircusConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CircusConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CircusConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnByDefault_Offset), 0, SpawnByDefault_PropertyAddress.Address, SpawnByDefault);
		new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NickName_Offset), NickName);
	}

	public FCircusConfig(IntPtr nativeStruct)
	{
		if (CircusConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusConfig");
			SpawnByDefault = false;
			NickName = null;
		}
		else
		{
			SpawnByDefault = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpawnByDefault_Offset), 0, SpawnByDefault_PropertyAddress.Address);
			NickName = new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NickName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CircusConfig");
		CircusConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnByDefault_PropertyAddress, intPtr, "SpawnByDefault");
		SpawnByDefault_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnByDefault");
		SpawnByDefault_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnByDefault", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NickName_PropertyAddress, intPtr, "NickName");
		NickName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NickName");
		NickName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NickName", Classes.FArrayProperty);
		CircusConfig_IsValid = ((intPtr != IntPtr.Zero && SpawnByDefault_IsValid && NickName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CircusConfig", (byte)CircusConfig_IsValid != 0);
	}

	static FCircusConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCircusConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCircusConfig));
	}
}
