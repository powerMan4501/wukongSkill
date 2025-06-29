using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CookRef")]
public class BGWDataAsset_CookRef : UBGWDataAsset
{
	private static bool PreloadDAList_IsValid;

	private static int PreloadDAList_Offset;

	private static FFieldAddress PreloadDAList_PropertyAddress;

	private TArrayReadWriteMarshaler<UBGWPreloadDataAsset> PreloadDAList_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CookRef:PreloadDAList")]
	public TArrayReadWrite<UBGWPreloadDataAsset> PreloadDAList
	{
		get
		{
			CheckDestroyed();
			if (!PreloadDAList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CookRef:PreloadDAList");
				return null;
			}
			if (PreloadDAList_Marshaler == null)
			{
				PreloadDAList_Marshaler = new TArrayReadWriteMarshaler<UBGWPreloadDataAsset>(1, PreloadDAList_PropertyAddress, CachedMarshalingDelegates<UBGWPreloadDataAsset, UObjectMarshaler<UBGWPreloadDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWPreloadDataAsset, UObjectMarshaler<UBGWPreloadDataAsset>>.ToNative);
			}
			return PreloadDAList_Marshaler.FromNative(IntPtr.Add(base.Address, PreloadDAList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CookRef");
		NativeReflection.GetPropertyRef(ref PreloadDAList_PropertyAddress, unrealStruct, "PreloadDAList");
		PreloadDAList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreloadDAList");
		PreloadDAList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreloadDAList", Classes.FArrayProperty);
	}

	static BGWDataAsset_CookRef()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CookRef)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CookRef));
	}
}
