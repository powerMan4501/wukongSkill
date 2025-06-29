using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset")]
public class BGWEquipPreviewConfigDataAsset : UBGWDataAsset
{
	private static bool PositionConfigMap_IsValid;

	private static int PositionConfigMap_Offset;

	private static FFieldAddress PositionConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<EquipPosition, FEquipPreviewPositionConfig> PositionConfigMap_Marshaler;

	private static bool WineDBCDAMap_IsValid;

	private static int WineDBCDAMap_Offset;

	private static FFieldAddress WineDBCDAMap_PropertyAddress;

	private TMapReadWriteMarshaler<EEquipFXType, UBGWDataAsset> WineDBCDAMap_Marshaler;

	private static bool WinePartnerDBCDAMap_IsValid;

	private static int WinePartnerDBCDAMap_Offset;

	private static FFieldAddress WinePartnerDBCDAMap_PropertyAddress;

	private TMapReadWriteMarshaler<EEquipFXType, UBGWDataAsset> WinePartnerDBCDAMap_Marshaler;

	private static bool LegacyActiveDBCDAMap_IsValid;

	private static int LegacyActiveDBCDAMap_Offset;

	private static FFieldAddress LegacyActiveDBCDAMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, UBGWDataAsset> LegacyActiveDBCDAMap_Marshaler;

	[DisplayName("装备特效配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:PositionConfigMap")]
	public TMapReadWrite<EquipPosition, FEquipPreviewPositionConfig> PositionConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!PositionConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:PositionConfigMap");
				return null;
			}
			if (PositionConfigMap_Marshaler == null)
			{
				PositionConfigMap_Marshaler = new TMapReadWriteMarshaler<EquipPosition, FEquipPreviewPositionConfig>(1, PositionConfigMap_PropertyAddress, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.FromNative, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.ToNative, CachedMarshalingDelegates<FEquipPreviewPositionConfig, FEquipPreviewPositionConfig>.FromNative, CachedMarshalingDelegates<FEquipPreviewPositionConfig, FEquipPreviewPositionConfig>.ToNative);
			}
			return PositionConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, PositionConfigMap_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("酒特效配置")]
	[USharpPath("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:WineDBCDAMap")]
	public TMapReadWrite<EEquipFXType, UBGWDataAsset> WineDBCDAMap
	{
		get
		{
			CheckDestroyed();
			if (!WineDBCDAMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:WineDBCDAMap");
				return null;
			}
			if (WineDBCDAMap_Marshaler == null)
			{
				WineDBCDAMap_Marshaler = new TMapReadWriteMarshaler<EEquipFXType, UBGWDataAsset>(1, WineDBCDAMap_PropertyAddress, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.FromNative, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return WineDBCDAMap_Marshaler.FromNative(IntPtr.Add(base.Address, WineDBCDAMap_Offset));
		}
	}

	[DisplayName("泡酒物特效配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:WinePartnerDBCDAMap")]
	public TMapReadWrite<EEquipFXType, UBGWDataAsset> WinePartnerDBCDAMap
	{
		get
		{
			CheckDestroyed();
			if (!WinePartnerDBCDAMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:WinePartnerDBCDAMap");
				return null;
			}
			if (WinePartnerDBCDAMap_Marshaler == null)
			{
				WinePartnerDBCDAMap_Marshaler = new TMapReadWriteMarshaler<EEquipFXType, UBGWDataAsset>(1, WinePartnerDBCDAMap_PropertyAddress, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.FromNative, CachedMarshalingDelegates<EEquipFXType, EnumMarshaler<EEquipFXType>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return WinePartnerDBCDAMap_Marshaler.FromNative(IntPtr.Add(base.Address, WinePartnerDBCDAMap_Offset));
		}
	}

	[DisplayName("大圣遗物激活特效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:LegacyActiveDBCDAMap")]
	public TMapReadWrite<int, UBGWDataAsset> LegacyActiveDBCDAMap
	{
		get
		{
			CheckDestroyed();
			if (!LegacyActiveDBCDAMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset:LegacyActiveDBCDAMap");
				return null;
			}
			if (LegacyActiveDBCDAMap_Marshaler == null)
			{
				LegacyActiveDBCDAMap_Marshaler = new TMapReadWriteMarshaler<int, UBGWDataAsset>(1, LegacyActiveDBCDAMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return LegacyActiveDBCDAMap_Marshaler.FromNative(IntPtr.Add(base.Address, LegacyActiveDBCDAMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWEquipPreviewConfigDataAsset");
		NativeReflection.GetPropertyRef(ref PositionConfigMap_PropertyAddress, unrealStruct, "PositionConfigMap");
		PositionConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PositionConfigMap");
		PositionConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PositionConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WineDBCDAMap_PropertyAddress, unrealStruct, "WineDBCDAMap");
		WineDBCDAMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WineDBCDAMap");
		WineDBCDAMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WineDBCDAMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WinePartnerDBCDAMap_PropertyAddress, unrealStruct, "WinePartnerDBCDAMap");
		WinePartnerDBCDAMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WinePartnerDBCDAMap");
		WinePartnerDBCDAMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WinePartnerDBCDAMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref LegacyActiveDBCDAMap_PropertyAddress, unrealStruct, "LegacyActiveDBCDAMap");
		LegacyActiveDBCDAMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LegacyActiveDBCDAMap");
		LegacyActiveDBCDAMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LegacyActiveDBCDAMap", Classes.FMapProperty);
	}

	static BGWEquipPreviewConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWEquipPreviewConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWEquipPreviewConfigDataAsset));
	}
}
