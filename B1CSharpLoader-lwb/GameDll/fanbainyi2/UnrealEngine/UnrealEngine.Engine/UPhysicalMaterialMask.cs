using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818946208uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PhysicalMaterialMask", "Engine", UnrealModuleType.Engine)]
public class UPhysicalMaterialMask : UObject
{
	private static bool MaskTexture_IsValid;

	private static int MaskTexture_Offset;

	private static bool UVChannelIndex_IsValid;

	private static int UVChannelIndex_Offset;

	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	[UProperty(Flags = (PropFlags)7881403500986901uL)]
	[UMetaPath("/Script/Engine.PhysicalMaterialMask:MaskTexture")]
	public UTexture MaskTexture
	{
		get
		{
			CheckDestroyed();
			if (!MaskTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:MaskTexture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, MaskTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaskTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:MaskTexture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, MaskTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalMaterialMask:UVChannelIndex")]
	public int UVChannelIndex
	{
		get
		{
			CheckDestroyed();
			if (!UVChannelIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:UVChannelIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UVChannelIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UVChannelIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:UVChannelIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UVChannelIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalMaterialMask:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalMaterialMask:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalMaterialMask:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	static UPhysicalMaterialMask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicalMaterialMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicalMaterialMask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicalMaterialMask");
		MaskTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaskTexture");
		MaskTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaskTexture", Classes.FObjectProperty);
		UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UVChannelIndex");
		UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, unrealStruct, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, unrealStruct, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressY", Classes.FByteProperty);
	}
}
