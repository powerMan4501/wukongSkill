using System;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.CacheAssetReference")]
public class CacheAssetReference : UObject
{
	[UEnum]
	[USharpPath("/Script/b1-Managed.CacheAssetState")]
	public enum CacheAssetState : byte
	{
		FileNotFound = byte.MaxValue,
		Unloaded = 0,
		Loading = 1,
		Loaded = 2
	}

	private static bool refCount_IsValid;

	private static int refCount_Offset;

	private static bool AssetState_IsValid;

	private static int AssetState_Offset;

	private static FFieldAddress AssetState_PropertyAddress;

	private static bool refObj_IsValid;

	private static int refObj_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CacheAssetReference:refCount")]
	public int refCount
	{
		get
		{
			CheckDestroyed();
			if (!refCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:refCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, refCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!refCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:refCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, refCount_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.CacheAssetReference:AssetState")]
	public CacheAssetState AssetState
	{
		get
		{
			CheckDestroyed();
			if (!AssetState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:AssetState");
				return CacheAssetState.Unloaded;
			}
			return EnumMarshaler<CacheAssetState>.FromNative(IntPtr.Add(base.Address, AssetState_Offset), 0, AssetState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AssetState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:AssetState");
			}
			else
			{
				EnumMarshaler<CacheAssetState>.ToNative(IntPtr.Add(base.Address, AssetState_Offset), 0, AssetState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.CacheAssetReference:refObj")]
	public UObject refObj
	{
		get
		{
			CheckDestroyed();
			if (!refObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:refObj");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, refObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!refObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CacheAssetReference:refObj");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, refObj_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.CacheAssetReference");
		refCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "refCount");
		refCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "refCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AssetState_PropertyAddress, unrealStruct, "AssetState");
		AssetState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssetState");
		AssetState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssetState", Classes.FEnumProperty);
		refObj_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "refObj");
		refObj_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "refObj", Classes.FObjectProperty);
	}

	static CacheAssetReference()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CacheAssetReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CacheAssetReference));
	}
}
