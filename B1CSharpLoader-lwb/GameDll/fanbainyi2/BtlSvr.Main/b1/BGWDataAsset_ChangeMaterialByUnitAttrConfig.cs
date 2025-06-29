using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ChangeMaterialByUnitAttrConfig")]
public class BGWDataAsset_ChangeMaterialByUnitAttrConfig : UBGWDataAsset
{
	private static bool ConfigList_IsValid;

	private static int ConfigList_Offset;

	private static FFieldAddress ConfigList_PropertyAddress;

	private TArrayReadWriteMarshaler<FChangeMaterialByUnitAttrConfig> ConfigList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ChangeMaterialByUnitAttrConfig:ConfigList")]
	public TArrayReadWrite<FChangeMaterialByUnitAttrConfig> ConfigList
	{
		get
		{
			CheckDestroyed();
			if (!ConfigList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ChangeMaterialByUnitAttrConfig:ConfigList");
				return null;
			}
			if (ConfigList_Marshaler == null)
			{
				ConfigList_Marshaler = new TArrayReadWriteMarshaler<FChangeMaterialByUnitAttrConfig>(1, ConfigList_PropertyAddress, CachedMarshalingDelegates<FChangeMaterialByUnitAttrConfig, FChangeMaterialByUnitAttrConfig>.FromNative, CachedMarshalingDelegates<FChangeMaterialByUnitAttrConfig, FChangeMaterialByUnitAttrConfig>.ToNative);
			}
			return ConfigList_Marshaler.FromNative(IntPtr.Add(base.Address, ConfigList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ChangeMaterialByUnitAttrConfig");
		NativeReflection.GetPropertyRef(ref ConfigList_PropertyAddress, unrealStruct, "ConfigList");
		ConfigList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigList");
		ConfigList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigList", Classes.FArrayProperty);
	}

	static BGWDataAsset_ChangeMaterialByUnitAttrConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ChangeMaterialByUnitAttrConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ChangeMaterialByUnitAttrConfig));
	}
}
