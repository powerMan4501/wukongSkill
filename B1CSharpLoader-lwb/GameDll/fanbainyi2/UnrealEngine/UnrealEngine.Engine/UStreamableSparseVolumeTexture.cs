using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.StreamableSparseVolumeTexture", "Engine", UnrealModuleType.Engine)]
public class UStreamableSparseVolumeTexture : USparseVolumeTexture
{
	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	private static bool AddressZ_IsValid;

	private static FFieldAddress AddressZ_PropertyAddress;

	private static int AddressZ_Offset;

	private static bool LocalDDCOnly_IsValid;

	private static FFieldAddress LocalDDCOnly_PropertyAddress;

	private static int LocalDDCOnly_Offset;

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.StreamableSparseVolumeTexture:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.StreamableSparseVolumeTexture:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.StreamableSparseVolumeTexture:AddressZ")]
	public ETextureAddress AddressZ
	{
		get
		{
			CheckDestroyed();
			if (!AddressZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressZ");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressZ_Offset), 0, AddressZ_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:AddressZ");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressZ_Offset), 0, AddressZ_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.StreamableSparseVolumeTexture:bLocalDDCOnly")]
	public bool LocalDDCOnly
	{
		get
		{
			CheckDestroyed();
			if (!LocalDDCOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:bLocalDDCOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LocalDDCOnly_Offset), 0, LocalDDCOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocalDDCOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableSparseVolumeTexture:bLocalDDCOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LocalDDCOnly_Offset), 0, LocalDDCOnly_PropertyAddress.Address, value);
			}
		}
	}

	static UStreamableSparseVolumeTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamableSparseVolumeTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamableSparseVolumeTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.StreamableSparseVolumeTexture");
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, unrealStruct, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, unrealStruct, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressY", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressZ_PropertyAddress, unrealStruct, "AddressZ");
		AddressZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressZ");
		AddressZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressZ", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalDDCOnly_PropertyAddress, unrealStruct, "bLocalDDCOnly");
		LocalDDCOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLocalDDCOnly");
		LocalDDCOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLocalDDCOnly", Classes.FBoolProperty);
	}
}
