using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_MaterialLayerParamGlobalConfig")]
public class BGWDataAsset_MaterialLayerParamGlobalConfig : UBGWDataAsset
{
	private static bool ConfigList_IsValid;

	private static int ConfigList_Offset;

	private static FFieldAddress ConfigList_PropertyAddress;

	private TMapReadWriteMarshaler<MaterialLayerKeyData, MaterialLayerParamGlobalConfigData> ConfigList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("全局配置列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MaterialLayerParamGlobalConfig:ConfigList")]
	public TMapReadWrite<MaterialLayerKeyData, MaterialLayerParamGlobalConfigData> ConfigList
	{
		get
		{
			CheckDestroyed();
			if (!ConfigList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MaterialLayerParamGlobalConfig:ConfigList");
				return null;
			}
			if (ConfigList_Marshaler == null)
			{
				ConfigList_Marshaler = new TMapReadWriteMarshaler<MaterialLayerKeyData, MaterialLayerParamGlobalConfigData>(1, ConfigList_PropertyAddress, CachedMarshalingDelegates<MaterialLayerKeyData, BlittableTypeMarshaler<MaterialLayerKeyData>>.FromNative, CachedMarshalingDelegates<MaterialLayerKeyData, BlittableTypeMarshaler<MaterialLayerKeyData>>.ToNative, CachedMarshalingDelegates<MaterialLayerParamGlobalConfigData, MaterialLayerParamGlobalConfigData>.FromNative, CachedMarshalingDelegates<MaterialLayerParamGlobalConfigData, MaterialLayerParamGlobalConfigData>.ToNative);
			}
			return ConfigList_Marshaler.FromNative(IntPtr.Add(base.Address, ConfigList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_MaterialLayerParamGlobalConfig");
		NativeReflection.GetPropertyRef(ref ConfigList_PropertyAddress, unrealStruct, "ConfigList");
		ConfigList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigList");
		ConfigList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigList", Classes.FMapProperty);
	}

	static BGWDataAsset_MaterialLayerParamGlobalConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_MaterialLayerParamGlobalConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_MaterialLayerParamGlobalConfig));
	}
}
