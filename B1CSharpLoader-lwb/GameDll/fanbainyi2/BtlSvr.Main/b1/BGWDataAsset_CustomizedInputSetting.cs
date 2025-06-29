using System;
using BtlB1;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting")]
public class BGWDataAsset_CustomizedInputSetting : UBGWDataAsset
{
	private static bool WhiteKeyList_IsValid;

	private static int WhiteKeyList_Offset;

	private static FFieldAddress WhiteKeyList_PropertyAddress;

	private TArrayReadWriteMarshaler<FKey> WhiteKeyList_Marshaler;

	private static bool Configs_IsValid;

	private static int Configs_Offset;

	private static FFieldAddress Configs_PropertyAddress;

	private TMapReadWriteMarshaler<FName, FCustomizedKeyConfig> Configs_Marshaler;

	private static bool GamepadCustomizedInputConfigs_IsValid;

	private static int GamepadCustomizedInputConfigs_Offset;

	private static FFieldAddress GamepadCustomizedInputConfigs_PropertyAddress;

	private TMapReadWriteMarshaler<ECustomizedInputType, FGamepadCustomizedInputConfig> GamepadCustomizedInputConfigs_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("键鼠按键自定义白名单")]
	[Category("Keyboard")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:WhiteKeyList")]
	public TArrayReadWrite<FKey> WhiteKeyList
	{
		get
		{
			CheckDestroyed();
			if (!WhiteKeyList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:WhiteKeyList");
				return null;
			}
			if (WhiteKeyList_Marshaler == null)
			{
				WhiteKeyList_Marshaler = new TArrayReadWriteMarshaler<FKey>(1, WhiteKeyList_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative);
			}
			return WhiteKeyList_Marshaler.FromNative(IntPtr.Add(base.Address, WhiteKeyList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Keyboard")]
	[DisplayName("Mappable配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:Configs")]
	public TMapReadWrite<FName, FCustomizedKeyConfig> Configs
	{
		get
		{
			CheckDestroyed();
			if (!Configs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:Configs");
				return null;
			}
			if (Configs_Marshaler == null)
			{
				Configs_Marshaler = new TMapReadWriteMarshaler<FName, FCustomizedKeyConfig>(1, Configs_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FCustomizedKeyConfig, FCustomizedKeyConfig>.FromNative, CachedMarshalingDelegates<FCustomizedKeyConfig, FCustomizedKeyConfig>.ToNative);
			}
			return Configs_Marshaler.FromNative(IntPtr.Add(base.Address, Configs_Offset));
		}
	}

	[Category("Gamepad")]
	[DisplayName("手柄按键自定义")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:GamepadCustomizedInputConfigs")]
	public TMapReadWrite<ECustomizedInputType, FGamepadCustomizedInputConfig> GamepadCustomizedInputConfigs
	{
		get
		{
			CheckDestroyed();
			if (!GamepadCustomizedInputConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting:GamepadCustomizedInputConfigs");
				return null;
			}
			if (GamepadCustomizedInputConfigs_Marshaler == null)
			{
				GamepadCustomizedInputConfigs_Marshaler = new TMapReadWriteMarshaler<ECustomizedInputType, FGamepadCustomizedInputConfig>(1, GamepadCustomizedInputConfigs_PropertyAddress, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.FromNative, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.ToNative, CachedMarshalingDelegates<FGamepadCustomizedInputConfig, FGamepadCustomizedInputConfig>.FromNative, CachedMarshalingDelegates<FGamepadCustomizedInputConfig, FGamepadCustomizedInputConfig>.ToNative);
			}
			return GamepadCustomizedInputConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, GamepadCustomizedInputConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CustomizedInputSetting");
		NativeReflection.GetPropertyRef(ref WhiteKeyList_PropertyAddress, unrealStruct, "WhiteKeyList");
		WhiteKeyList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WhiteKeyList");
		WhiteKeyList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WhiteKeyList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Configs_PropertyAddress, unrealStruct, "Configs");
		Configs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Configs");
		Configs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Configs", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref GamepadCustomizedInputConfigs_PropertyAddress, unrealStruct, "GamepadCustomizedInputConfigs");
		GamepadCustomizedInputConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamepadCustomizedInputConfigs");
		GamepadCustomizedInputConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamepadCustomizedInputConfigs", Classes.FMapProperty);
	}

	static BGWDataAsset_CustomizedInputSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CustomizedInputSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CustomizedInputSetting));
	}
}
