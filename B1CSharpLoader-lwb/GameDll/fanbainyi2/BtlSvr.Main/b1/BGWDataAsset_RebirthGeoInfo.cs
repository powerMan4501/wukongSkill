using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthGeoInfo")]
public class BGWDataAsset_RebirthGeoInfo : UBGWDataAsset
{
	private static bool RebirthAreaConfig_IsValid;

	private static int RebirthAreaConfig_Offset;

	private static FFieldAddress RebirthAreaConfig_PropertyAddress;

	private TMapReadWriteMarshaler<int, FGeoAreaIdListInfo> RebirthAreaConfig_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("土地庙区域配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthGeoInfo:RebirthAreaConfig")]
	public TMapReadWrite<int, FGeoAreaIdListInfo> RebirthAreaConfig
	{
		get
		{
			CheckDestroyed();
			if (!RebirthAreaConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthGeoInfo:RebirthAreaConfig");
				return null;
			}
			if (RebirthAreaConfig_Marshaler == null)
			{
				RebirthAreaConfig_Marshaler = new TMapReadWriteMarshaler<int, FGeoAreaIdListInfo>(1, RebirthAreaConfig_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGeoAreaIdListInfo, FGeoAreaIdListInfo>.FromNative, CachedMarshalingDelegates<FGeoAreaIdListInfo, FGeoAreaIdListInfo>.ToNative);
			}
			return RebirthAreaConfig_Marshaler.FromNative(IntPtr.Add(base.Address, RebirthAreaConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_RebirthGeoInfo");
		NativeReflection.GetPropertyRef(ref RebirthAreaConfig_PropertyAddress, unrealStruct, "RebirthAreaConfig");
		RebirthAreaConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthAreaConfig");
		RebirthAreaConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthAreaConfig", Classes.FMapProperty);
	}

	static BGWDataAsset_RebirthGeoInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_RebirthGeoInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_RebirthGeoInfo));
	}
}
