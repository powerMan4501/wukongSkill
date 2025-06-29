using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GamepadCustomizedInputDetailConfig")]
public struct FGamepadCustomizedInputDetailConfig
{
	[UProperty]
	[DisplayName("Detail的UIWord")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GamepadCustomizedInputDetailConfig:DetailUIWord")]
	public int DetailUIWord;

	[EditAnywhere]
	[DisplayName("动画名字")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GamepadCustomizedInputDetailConfig:AnimationName")]
	public FName AnimationName;

	[UProperty]
	[DisplayName("第一组MappableNames")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GamepadCustomizedInputDetailConfig:FirstMappableNames")]
	public List<FName> FirstMappableNames;

	[DisplayName("第二组MappableNames")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GamepadCustomizedInputDetailConfig:SecondMappableNames")]
	public List<FName> SecondMappableNames;

	private static int GamepadCustomizedInputDetailConfig_StructSize;

	private static int GamepadCustomizedInputDetailConfig_IsValid;

	private static bool DetailUIWord_IsValid;

	private static int DetailUIWord_Offset;

	private static bool AnimationName_IsValid;

	private static int AnimationName_Offset;

	private static bool FirstMappableNames_IsValid;

	private static int FirstMappableNames_Offset;

	private static FFieldAddress FirstMappableNames_PropertyAddress;

	private static bool SecondMappableNames_IsValid;

	private static int SecondMappableNames_Offset;

	private static FFieldAddress SecondMappableNames_PropertyAddress;

	public FGamepadCustomizedInputDetailConfig Copy()
	{
		FGamepadCustomizedInputDetailConfig result = this;
		if (FirstMappableNames != null)
		{
			result.FirstMappableNames = new List<FName>(FirstMappableNames);
		}
		if (SecondMappableNames != null)
		{
			result.SecondMappableNames = new List<FName>(SecondMappableNames);
		}
		return result;
	}

	public static FGamepadCustomizedInputDetailConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGamepadCustomizedInputDetailConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGamepadCustomizedInputDetailConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGamepadCustomizedInputDetailConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGamepadCustomizedInputDetailConfig(IntPtr.Add(nativeBuffer, arrayIndex * GamepadCustomizedInputDetailConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGamepadCustomizedInputDetailConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GamepadCustomizedInputDetailConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GamepadCustomizedInputDetailConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamepadCustomizedInputDetailConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DetailUIWord_Offset), DetailUIWord);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AnimationName_Offset), AnimationName);
		new TArrayCopyMarshaler<FName>(1, FirstMappableNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FirstMappableNames_Offset), FirstMappableNames);
		new TArrayCopyMarshaler<FName>(1, SecondMappableNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SecondMappableNames_Offset), SecondMappableNames);
	}

	public FGamepadCustomizedInputDetailConfig(IntPtr nativeStruct)
	{
		if (GamepadCustomizedInputDetailConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamepadCustomizedInputDetailConfig");
			DetailUIWord = 0;
			AnimationName = default(FName);
			FirstMappableNames = null;
			SecondMappableNames = null;
		}
		else
		{
			DetailUIWord = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DetailUIWord_Offset));
			AnimationName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AnimationName_Offset));
			FirstMappableNames = new TArrayCopyMarshaler<FName>(1, FirstMappableNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FirstMappableNames_Offset));
			SecondMappableNames = new TArrayCopyMarshaler<FName>(1, SecondMappableNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SecondMappableNames_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GamepadCustomizedInputDetailConfig");
		GamepadCustomizedInputDetailConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		DetailUIWord_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetailUIWord");
		DetailUIWord_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetailUIWord", Classes.FIntProperty);
		AnimationName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationName");
		AnimationName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref FirstMappableNames_PropertyAddress, intPtr, "FirstMappableNames");
		FirstMappableNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstMappableNames");
		FirstMappableNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstMappableNames", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SecondMappableNames_PropertyAddress, intPtr, "SecondMappableNames");
		SecondMappableNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "SecondMappableNames");
		SecondMappableNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SecondMappableNames", Classes.FArrayProperty);
		GamepadCustomizedInputDetailConfig_IsValid = ((intPtr != IntPtr.Zero && DetailUIWord_IsValid && AnimationName_IsValid && FirstMappableNames_IsValid && SecondMappableNames_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GamepadCustomizedInputDetailConfig", (byte)GamepadCustomizedInputDetailConfig_IsValid != 0);
	}

	static FGamepadCustomizedInputDetailConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGamepadCustomizedInputDetailConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGamepadCustomizedInputDetailConfig));
	}
}
