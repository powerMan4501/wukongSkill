using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskConfig")]
public class BGWDataAsset_EnvironmentMaskConfig : UBGWDataAsset
{
	private static bool EnvironmentMaskDataList_IsValid;

	private static int EnvironmentMaskDataList_Offset;

	private static FFieldAddress EnvironmentMaskDataList_PropertyAddress;

	private TArrayReadWriteMarshaler<EnvironmentMaskData> EnvironmentMaskDataList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskConfig:EnvironmentMaskDataList")]
	public TArrayReadWrite<EnvironmentMaskData> EnvironmentMaskDataList
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentMaskDataList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskConfig:EnvironmentMaskDataList");
				return null;
			}
			if (EnvironmentMaskDataList_Marshaler == null)
			{
				EnvironmentMaskDataList_Marshaler = new TArrayReadWriteMarshaler<EnvironmentMaskData>(1, EnvironmentMaskDataList_PropertyAddress, CachedMarshalingDelegates<EnvironmentMaskData, EnvironmentMaskData>.FromNative, CachedMarshalingDelegates<EnvironmentMaskData, EnvironmentMaskData>.ToNative);
			}
			return EnvironmentMaskDataList_Marshaler.FromNative(IntPtr.Add(base.Address, EnvironmentMaskDataList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskConfig");
		NativeReflection.GetPropertyRef(ref EnvironmentMaskDataList_PropertyAddress, unrealStruct, "EnvironmentMaskDataList");
		EnvironmentMaskDataList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentMaskDataList");
		EnvironmentMaskDataList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentMaskDataList", Classes.FArrayProperty);
	}

	static BGWDataAsset_EnvironmentMaskConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_EnvironmentMaskConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_EnvironmentMaskConfig));
	}
}
