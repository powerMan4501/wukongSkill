using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig")]
public struct FEquipPreviewPositionConfig
{
	[DisplayName("特效DA")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:DBCDAMap")]
	public Dictionary<EEquipFXType, UBGWDataAsset> DBCDAMap;

	[DisplayName("动画-In")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:AnimIn")]
	public UAnimMontage AnimIn;

	[DisplayName("表情动画-In")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:HeadAnimIn")]
	public UAnimMontage HeadAnimIn;

	[EditAnywhere]
	[UProperty]
	[DisplayName("动画-Out穿戴成功")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:AnimOutSuccess")]
	public UAnimMontage AnimOutSuccess;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("表情动画-Out穿戴成功")]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:HeadAnimOutSuccess")]
	public UAnimMontage HeadAnimOutSuccess;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("动画-Out返回")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:AnimOutBack")]
	public UAnimMontage AnimOutBack;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("表情动画-Out返回")]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:HeadAnimOutBack")]
	public UAnimMontage HeadAnimOutBack;

	[DisplayName("部位标识图")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EquipPreviewPositionConfig:MarkIcon")]
	public UTexture2D MarkIcon;

	private static int EquipPreviewPositionConfig_StructSize;

	private static int EquipPreviewPositionConfig_IsValid;

	private static bool DBCDAMap_IsValid;

	private static int DBCDAMap_Offset;

	private static FFieldAddress DBCDAMap_PropertyAddress;

	private static bool AnimIn_IsValid;

	private static int AnimIn_Offset;

	private static bool HeadAnimIn_IsValid;

	private static int HeadAnimIn_Offset;

	private static bool AnimOutSuccess_IsValid;

	private static int AnimOutSuccess_Offset;

	private static bool HeadAnimOutSuccess_IsValid;

	private static int HeadAnimOutSuccess_Offset;

	private static bool AnimOutBack_IsValid;

	private static int AnimOutBack_Offset;

	private static bool HeadAnimOutBack_IsValid;

	private static int HeadAnimOutBack_Offset;

	private static bool MarkIcon_IsValid;

	private static int MarkIcon_Offset;

	public FEquipPreviewPositionConfig Copy()
	{
		FEquipPreviewPositionConfig result = this;
		if (DBCDAMap != null)
		{
			result.DBCDAMap = new Dictionary<EEquipFXType, UBGWDataAsset>(DBCDAMap);
		}
		return result;
	}

	public static FEquipPreviewPositionConfig FromNative(IntPtr nativeBuffer)
	{
		return new FEquipPreviewPositionConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEquipPreviewPositionConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEquipPreviewPositionConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEquipPreviewPositionConfig(IntPtr.Add(nativeBuffer, arrayIndex * EquipPreviewPositionConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEquipPreviewPositionConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EquipPreviewPositionConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EquipPreviewPositionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipPreviewPositionConfig");
			return;
		}
		new TMapCopyMarshaler<EEquipFXType, UBGWDataAsset>(1, DBCDAMap_PropertyAddress, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.FromNative, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative).ToNative(IntPtr.Add(nativeStruct, DBCDAMap_Offset), DBCDAMap);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AnimIn_Offset), AnimIn);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, HeadAnimIn_Offset), HeadAnimIn);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AnimOutSuccess_Offset), AnimOutSuccess);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, HeadAnimOutSuccess_Offset), HeadAnimOutSuccess);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AnimOutBack_Offset), AnimOutBack);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, HeadAnimOutBack_Offset), HeadAnimOutBack);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, MarkIcon_Offset), MarkIcon);
	}

	public FEquipPreviewPositionConfig(IntPtr nativeStruct)
	{
		if (EquipPreviewPositionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EquipPreviewPositionConfig");
			DBCDAMap = null;
			AnimIn = null;
			HeadAnimIn = null;
			AnimOutSuccess = null;
			HeadAnimOutSuccess = null;
			AnimOutBack = null;
			HeadAnimOutBack = null;
			MarkIcon = null;
		}
		else
		{
			DBCDAMap = new TMapCopyMarshaler<EEquipFXType, UBGWDataAsset>(1, DBCDAMap_PropertyAddress, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.FromNative, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative).FromNative(IntPtr.Add(nativeStruct, DBCDAMap_Offset));
			AnimIn = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AnimIn_Offset));
			HeadAnimIn = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, HeadAnimIn_Offset));
			AnimOutSuccess = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AnimOutSuccess_Offset));
			HeadAnimOutSuccess = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, HeadAnimOutSuccess_Offset));
			AnimOutBack = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AnimOutBack_Offset));
			HeadAnimOutBack = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, HeadAnimOutBack_Offset));
			MarkIcon = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, MarkIcon_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EquipPreviewPositionConfig");
		EquipPreviewPositionConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DBCDAMap_PropertyAddress, intPtr, "DBCDAMap");
		DBCDAMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBCDAMap");
		DBCDAMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBCDAMap", Classes.FMapProperty);
		AnimIn_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIn");
		AnimIn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIn", Classes.FObjectProperty);
		HeadAnimIn_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAnimIn");
		HeadAnimIn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAnimIn", Classes.FObjectProperty);
		AnimOutSuccess_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimOutSuccess");
		AnimOutSuccess_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimOutSuccess", Classes.FObjectProperty);
		HeadAnimOutSuccess_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAnimOutSuccess");
		HeadAnimOutSuccess_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAnimOutSuccess", Classes.FObjectProperty);
		AnimOutBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimOutBack");
		AnimOutBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimOutBack", Classes.FObjectProperty);
		HeadAnimOutBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAnimOutBack");
		HeadAnimOutBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAnimOutBack", Classes.FObjectProperty);
		MarkIcon_Offset = NativeReflection.GetPropertyOffset(intPtr, "MarkIcon");
		MarkIcon_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MarkIcon", Classes.FObjectProperty);
		EquipPreviewPositionConfig_IsValid = ((intPtr != IntPtr.Zero && DBCDAMap_IsValid && AnimIn_IsValid && HeadAnimIn_IsValid && AnimOutSuccess_IsValid && HeadAnimOutSuccess_IsValid && AnimOutBack_IsValid && HeadAnimOutBack_IsValid && MarkIcon_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EquipPreviewPositionConfig", (byte)EquipPreviewPositionConfig_IsValid != 0);
	}

	static FEquipPreviewPositionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEquipPreviewPositionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEquipPreviewPositionConfig));
	}
}
