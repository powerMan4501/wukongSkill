using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.PostProcessMatInfo")]
public class UPostProcessMatInfo : UObject
{
	private static bool Materials_IsValid;

	private static int Materials_Offset;

	private static FFieldAddress Materials_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInstanceDynamic> Materials_Marshaler;

	private static bool PostProcessMatSetting_IsValid;

	private static int PostProcessMatSetting_Offset;

	private static bool OwnerActor_IsValid;

	private static int OwnerActor_Offset;

	private static bool LastFrameDataCache_IsValid;

	private static int LastFrameDataCache_Offset;

	private static FFieldAddress LastFrameDataCache_PropertyAddress;

	private TMapReadWriteMarshaler<int, FVector> LastFrameDataCache_Marshaler;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PostProcessMatInfo:Materials")]
	public TArrayReadWrite<UMaterialInstanceDynamic> Materials
	{
		get
		{
			CheckDestroyed();
			if (!Materials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:Materials");
				return null;
			}
			if (Materials_Marshaler == null)
			{
				Materials_Marshaler = new TArrayReadWriteMarshaler<UMaterialInstanceDynamic>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.FromNative, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.ToNative);
			}
			return Materials_Marshaler.FromNative(IntPtr.Add(base.Address, Materials_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.PostProcessMatInfo:PostProcessMatSetting")]
	public BGWDataAsset_PostProcessMatSetting PostProcessMatSetting
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:PostProcessMatSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.FromNative(IntPtr.Add(base.Address, PostProcessMatSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessMatSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:PostProcessMatSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.ToNative(IntPtr.Add(base.Address, PostProcessMatSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.PostProcessMatInfo:OwnerActor")]
	public BGUCharacterCS OwnerActor
	{
		get
		{
			CheckDestroyed();
			if (!OwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:OwnerActor");
				return null;
			}
			return UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, OwnerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:OwnerActor");
			}
			else
			{
				UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, OwnerActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.PostProcessMatInfo:LastFrameDataCache")]
	public TMapReadWrite<int, FVector> LastFrameDataCache
	{
		get
		{
			CheckDestroyed();
			if (!LastFrameDataCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PostProcessMatInfo:LastFrameDataCache");
				return null;
			}
			if (LastFrameDataCache_Marshaler == null)
			{
				LastFrameDataCache_Marshaler = new TMapReadWriteMarshaler<int, FVector>(1, LastFrameDataCache_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LastFrameDataCache_Marshaler.FromNative(IntPtr.Add(base.Address, LastFrameDataCache_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PostProcessMatInfo");
		NativeReflection.GetPropertyRef(ref Materials_PropertyAddress, unrealStruct, "Materials");
		Materials_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Materials");
		Materials_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Materials", Classes.FArrayProperty);
		PostProcessMatSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatSetting");
		PostProcessMatSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatSetting", Classes.FObjectProperty);
		OwnerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnerActor");
		OwnerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnerActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref LastFrameDataCache_PropertyAddress, unrealStruct, "LastFrameDataCache");
		LastFrameDataCache_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LastFrameDataCache");
		LastFrameDataCache_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LastFrameDataCache", Classes.FMapProperty);
	}

	static UPostProcessMatInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPostProcessMatInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPostProcessMatInfo));
	}
}
