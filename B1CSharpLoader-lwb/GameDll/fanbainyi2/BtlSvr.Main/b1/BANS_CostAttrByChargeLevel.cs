using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS CastAttr by CharheLevel")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_CostAttrByChargeLevel")]
public class BANS_CostAttrByChargeLevel : BANS_GSBase
{
	private static bool Config_IsValid;

	private static int Config_Offset;

	private static FFieldAddress Config_PropertyAddress;

	private TMapReadWriteMarshaler<int, BGUCostAttrInfo> Config_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("属性消耗配置")]
	[USharpPath("/Script/b1-Managed.BANS_CostAttrByChargeLevel:Config")]
	public TMapReadWrite<int, BGUCostAttrInfo> Config
	{
		get
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_CostAttrByChargeLevel:Config");
				return null;
			}
			if (Config_Marshaler == null)
			{
				Config_Marshaler = new TMapReadWriteMarshaler<int, BGUCostAttrInfo>(1, Config_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<BGUCostAttrInfo, BGUCostAttrInfo>.FromNative, CachedMarshalingDelegates<BGUCostAttrInfo, BGUCostAttrInfo>.ToNative);
			}
			return Config_Marshaler.FromNative(IntPtr.Add(base.Address, Config_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_CostAttrByChargeLevel:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		foreach (KeyValuePair<int, BGUCostAttrInfo> item in Config)
		{
			_ = item.Key;
			bUS_GSEventCollection?.Evt_IncreaseAttrFloat.Invoke(item.Value.Attr, item.Value.CostValue);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_CostAttrByChargeLevel:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_CostAttrByChargeLevel bANS_CostAttrByChargeLevel = GCHelper.Find<BANS_CostAttrByChargeLevel>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_CostAttrByChargeLevel.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_CostAttrByChargeLevel");
		NativeReflection.GetPropertyRef(ref Config_PropertyAddress, intPtr, "Config");
		Config_Offset = NativeReflection.GetPropertyOffset(intPtr, "Config");
		Config_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Config", Classes.FMapProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_CostAttrByChargeLevel:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_CostAttrByChargeLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_CostAttrByChargeLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_CostAttrByChargeLevel));
	}
}
