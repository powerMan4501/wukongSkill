using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSMontageAndNotifiesWarp", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSMontageAndNotifiesWarp
{
	private static bool AM_IsValid;

	private static int AM_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSMontageAndNotifiesWarp:AM")]
	public UAnimMontage AM;

	private static bool ANEArr_IsValid;

	private static FFieldAddress ANEArr_PropertyAddress;

	private static int ANEArr_Offset;

	[UProperty(Flags = (PropFlags)4504149383184901uL)]
	[UMetaPath("/Script/UnrealExtent.GSMontageAndNotifiesWarp:ANEArr")]
	public List<FAnimNotifyEvent> ANEArr;

	private static bool FGSMontageAndNotifiesWarp_IsValid;

	private static int FGSMontageAndNotifiesWarp_StructSize;

	public FGSMontageAndNotifiesWarp Copy()
	{
		FGSMontageAndNotifiesWarp result = this;
		if (ANEArr != null)
		{
			result.ANEArr = new List<FAnimNotifyEvent>(ANEArr);
		}
		return result;
	}

	public static FGSMontageAndNotifiesWarp FromNative(IntPtr nativeBuffer)
	{
		return new FGSMontageAndNotifiesWarp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMontageAndNotifiesWarp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMontageAndNotifiesWarp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMontageAndNotifiesWarp(nativeBuffer + arrayIndex * FGSMontageAndNotifiesWarp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMontageAndNotifiesWarp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSMontageAndNotifiesWarp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSMontageAndNotifiesWarp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSMontageAndNotifiesWarp");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AM_Offset), AM);
		new TArrayCopyMarshaler<FAnimNotifyEvent>(1, ANEArr_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ANEArr_Offset), ANEArr);
	}

	public FGSMontageAndNotifiesWarp(IntPtr nativeStruct)
	{
		if (!FGSMontageAndNotifiesWarp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSMontageAndNotifiesWarp");
			AM = null;
			ANEArr = null;
		}
		else
		{
			AM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AM_Offset));
			ANEArr = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, ANEArr_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ANEArr_Offset));
		}
	}

	static FGSMontageAndNotifiesWarp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSMontageAndNotifiesWarp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMontageAndNotifiesWarp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSMontageAndNotifiesWarp");
		FGSMontageAndNotifiesWarp_StructSize = NativeReflection.GetStructSize(intPtr);
		AM_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AM");
		AM_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ANEArr_PropertyAddress, intPtr, "ANEArr");
		ANEArr_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ANEArr");
		ANEArr_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ANEArr", Classes.FArrayProperty);
		FGSMontageAndNotifiesWarp_IsValid = intPtr != IntPtr.Zero && AM_IsValid && ANEArr_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSMontageAndNotifiesWarp", FGSMontageAndNotifiesWarp_IsValid);
	}
}
