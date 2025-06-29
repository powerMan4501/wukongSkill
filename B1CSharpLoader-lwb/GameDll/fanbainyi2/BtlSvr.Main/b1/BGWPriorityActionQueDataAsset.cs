using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWPriorityActionQueDataAsset")]
public class BGWPriorityActionQueDataAsset : UBGWDataAsset
{
	private static bool PriorityActionMap_IsValid;

	private static int PriorityActionMap_Offset;

	private static FFieldAddress PriorityActionMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FPriorityActionQueInfo> PriorityActionMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWPriorityActionQueDataAsset:PriorityActionMap")]
	public TMapReadWrite<int, FPriorityActionQueInfo> PriorityActionMap
	{
		get
		{
			CheckDestroyed();
			if (!PriorityActionMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWPriorityActionQueDataAsset:PriorityActionMap");
				return null;
			}
			if (PriorityActionMap_Marshaler == null)
			{
				PriorityActionMap_Marshaler = new TMapReadWriteMarshaler<int, FPriorityActionQueInfo>(1, PriorityActionMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FPriorityActionQueInfo, FPriorityActionQueInfo>.FromNative, CachedMarshalingDelegates<FPriorityActionQueInfo, FPriorityActionQueInfo>.ToNative);
			}
			return PriorityActionMap_Marshaler.FromNative(IntPtr.Add(base.Address, PriorityActionMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWPriorityActionQueDataAsset");
		NativeReflection.GetPropertyRef(ref PriorityActionMap_PropertyAddress, unrealStruct, "PriorityActionMap");
		PriorityActionMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PriorityActionMap");
		PriorityActionMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PriorityActionMap", Classes.FMapProperty);
	}

	static BGWPriorityActionQueDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWPriorityActionQueDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWPriorityActionQueDataAsset));
	}
}
