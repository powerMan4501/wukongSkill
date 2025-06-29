using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_InputIconConfig")]
public class BGWDataAsset_InputIconConfig : UBGWDataAsset
{
	private static bool IconInfo_IsValid;

	private static int IconInfo_Offset;

	private static FFieldAddress IconInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FKeyIconInfo> IconInfo_Marshaler;

	[DisplayName("部分按键图标信息设置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_InputIconConfig:IconInfo")]
	public TArrayReadWrite<FKeyIconInfo> IconInfo
	{
		get
		{
			CheckDestroyed();
			if (!IconInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputIconConfig:IconInfo");
				return null;
			}
			if (IconInfo_Marshaler == null)
			{
				IconInfo_Marshaler = new TArrayReadWriteMarshaler<FKeyIconInfo>(1, IconInfo_PropertyAddress, CachedMarshalingDelegates<FKeyIconInfo, FKeyIconInfo>.FromNative, CachedMarshalingDelegates<FKeyIconInfo, FKeyIconInfo>.ToNative);
			}
			return IconInfo_Marshaler.FromNative(IntPtr.Add(base.Address, IconInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_InputIconConfig");
		NativeReflection.GetPropertyRef(ref IconInfo_PropertyAddress, unrealStruct, "IconInfo");
		IconInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IconInfo");
		IconInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IconInfo", Classes.FArrayProperty);
	}

	static BGWDataAsset_InputIconConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_InputIconConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_InputIconConfig));
	}
}
