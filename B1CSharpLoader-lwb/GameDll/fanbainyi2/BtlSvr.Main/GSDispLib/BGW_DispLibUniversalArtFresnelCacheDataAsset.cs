using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DispLibUniversalArtFresnelCacheDataAsset")]
public class BGW_DispLibUniversalArtFresnelCacheDataAsset : UBGWDataAsset
{
	private static bool UnitArtFresnelUniversalData_IsValid;

	private static int UnitArtFresnelUniversalData_Offset;

	private static FFieldAddress UnitArtFresnelUniversalData_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUnitArtFresnelDataAsset> UnitArtFresnelUniversalData_Marshaler;

	[UMeta(MD.DisplayName, "通用单位边缘光效果数据")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibUniversalArtFresnelCacheDataAsset:UnitArtFresnelUniversalData")]
	public TArrayReadWrite<BUC_DispLibUnitArtFresnelDataAsset> UnitArtFresnelUniversalData
	{
		get
		{
			CheckDestroyed();
			if (!UnitArtFresnelUniversalData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibUniversalArtFresnelCacheDataAsset:UnitArtFresnelUniversalData");
				return null;
			}
			if (UnitArtFresnelUniversalData_Marshaler == null)
			{
				UnitArtFresnelUniversalData_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUnitArtFresnelDataAsset>(1, UnitArtFresnelUniversalData_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUnitArtFresnelDataAsset, UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUnitArtFresnelDataAsset, UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>>.ToNative);
			}
			return UnitArtFresnelUniversalData_Marshaler.FromNative(IntPtr.Add(base.Address, UnitArtFresnelUniversalData_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibUniversalArtFresnelCacheDataAsset");
		NativeReflection.GetPropertyRef(ref UnitArtFresnelUniversalData_PropertyAddress, unrealStruct, "UnitArtFresnelUniversalData");
		UnitArtFresnelUniversalData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitArtFresnelUniversalData");
		UnitArtFresnelUniversalData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitArtFresnelUniversalData", Classes.FArrayProperty);
	}

	static BGW_DispLibUniversalArtFresnelCacheDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibUniversalArtFresnelCacheDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibUniversalArtFresnelCacheDataAsset));
	}
}
