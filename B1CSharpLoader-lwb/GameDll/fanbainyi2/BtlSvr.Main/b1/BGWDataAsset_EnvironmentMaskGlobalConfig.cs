using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskGlobalConfig")]
public class BGWDataAsset_EnvironmentMaskGlobalConfig : UBGWDataAsset
{
	private static bool EnvironmentMaskMappingList_IsValid;

	private static int EnvironmentMaskMappingList_Offset;

	private static FFieldAddress EnvironmentMaskMappingList_PropertyAddress;

	private TMapReadWriteMarshaler<ESceneItemSurfaceType, EnvironmentMaskMappingData> EnvironmentMaskMappingList_Marshaler;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskGlobalConfig:EnvironmentMaskMappingList")]
	public TMapReadWrite<ESceneItemSurfaceType, EnvironmentMaskMappingData> EnvironmentMaskMappingList
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentMaskMappingList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskGlobalConfig:EnvironmentMaskMappingList");
				return null;
			}
			if (EnvironmentMaskMappingList_Marshaler == null)
			{
				EnvironmentMaskMappingList_Marshaler = new TMapReadWriteMarshaler<ESceneItemSurfaceType, EnvironmentMaskMappingData>(1, EnvironmentMaskMappingList_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<EnvironmentMaskMappingData, EnvironmentMaskMappingData>.FromNative, CachedMarshalingDelegates<EnvironmentMaskMappingData, EnvironmentMaskMappingData>.ToNative);
			}
			return EnvironmentMaskMappingList_Marshaler.FromNative(IntPtr.Add(base.Address, EnvironmentMaskMappingList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_EnvironmentMaskGlobalConfig");
		NativeReflection.GetPropertyRef(ref EnvironmentMaskMappingList_PropertyAddress, unrealStruct, "EnvironmentMaskMappingList");
		EnvironmentMaskMappingList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentMaskMappingList");
		EnvironmentMaskMappingList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentMaskMappingList", Classes.FMapProperty);
	}

	static BGWDataAsset_EnvironmentMaskGlobalConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_EnvironmentMaskGlobalConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_EnvironmentMaskGlobalConfig));
	}
}
