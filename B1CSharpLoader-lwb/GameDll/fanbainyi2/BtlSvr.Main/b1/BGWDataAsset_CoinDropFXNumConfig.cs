using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CoinDropFXNumConfig")]
public class BGWDataAsset_CoinDropFXNumConfig : UBGWDataAsset
{
	private static bool CoinDropFXNumArray_IsValid;

	private static int CoinDropFXNumArray_Offset;

	private static FFieldAddress CoinDropFXNumArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FCoinFXNum> CoinDropFXNumArray_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CoinDropFXNumConfig:CoinDropFXNumArray")]
	public TArrayReadWrite<FCoinFXNum> CoinDropFXNumArray
	{
		get
		{
			CheckDestroyed();
			if (!CoinDropFXNumArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CoinDropFXNumConfig:CoinDropFXNumArray");
				return null;
			}
			if (CoinDropFXNumArray_Marshaler == null)
			{
				CoinDropFXNumArray_Marshaler = new TArrayReadWriteMarshaler<FCoinFXNum>(1, CoinDropFXNumArray_PropertyAddress, CachedMarshalingDelegates<FCoinFXNum, BlittableTypeMarshaler<FCoinFXNum>>.FromNative, CachedMarshalingDelegates<FCoinFXNum, BlittableTypeMarshaler<FCoinFXNum>>.ToNative);
			}
			return CoinDropFXNumArray_Marshaler.FromNative(IntPtr.Add(base.Address, CoinDropFXNumArray_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CoinDropFXNumConfig");
		NativeReflection.GetPropertyRef(ref CoinDropFXNumArray_PropertyAddress, unrealStruct, "CoinDropFXNumArray");
		CoinDropFXNumArray_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CoinDropFXNumArray");
		CoinDropFXNumArray_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CoinDropFXNumArray", Classes.FArrayProperty);
	}

	static BGWDataAsset_CoinDropFXNumConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CoinDropFXNumConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CoinDropFXNumConfig));
	}
}
