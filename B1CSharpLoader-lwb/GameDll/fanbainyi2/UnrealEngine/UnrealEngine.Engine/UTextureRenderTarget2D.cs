using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureRenderTarget2D", "Engine", UnrealModuleType.Engine)]
public class UTextureRenderTarget2D : UTextureRenderTarget
{
	private static bool SizeX_IsValid;

	private static int SizeX_Offset;

	private static bool SizeY_IsValid;

	private static int SizeY_Offset;

	private static bool ClearColor_IsValid;

	private static int ClearColor_Offset;

	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	private static bool GPUSharedFlag_IsValid;

	private static FFieldAddress GPUSharedFlag_PropertyAddress;

	private static int GPUSharedFlag_Offset;

	private static bool RenderTargetFormat_IsValid;

	private static FFieldAddress RenderTargetFormat_PropertyAddress;

	private static int RenderTargetFormat_Offset;

	private static bool AutoGenerateMips_IsValid;

	private static FFieldAddress AutoGenerateMips_PropertyAddress;

	private static int AutoGenerateMips_Offset;

	private static bool MipsSamplerFilter_IsValid;

	private static FFieldAddress MipsSamplerFilter_PropertyAddress;

	private static int MipsSamplerFilter_Offset;

	private static bool MipsAddressU_IsValid;

	private static FFieldAddress MipsAddressU_PropertyAddress;

	private static int MipsAddressU_Offset;

	private static bool MipsAddressV_IsValid;

	private static FFieldAddress MipsAddressV_PropertyAddress;

	private static int MipsAddressV_Offset;

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:SizeX")]
	public int SizeX
	{
		get
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:SizeX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:SizeX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:SizeY")]
	public int SizeY
	{
		get
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:SizeY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:SizeY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:ClearColor")]
	public FLinearColor ClearColor
	{
		get
		{
			CheckDestroyed();
			if (!ClearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:ClearColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ClearColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:ClearColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ClearColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760965718671381uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:bGPUSharedFlag")]
	public bool GPUSharedFlag
	{
		get
		{
			CheckDestroyed();
			if (!GPUSharedFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:bGPUSharedFlag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GPUSharedFlag_Offset), 0, GPUSharedFlag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GPUSharedFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:bGPUSharedFlag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GPUSharedFlag_Offset), 0, GPUSharedFlag_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:RenderTargetFormat")]
	public ETextureRenderTargetFormat RenderTargetFormat
	{
		get
		{
			CheckDestroyed();
			if (!RenderTargetFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:RenderTargetFormat");
				return ETextureRenderTargetFormat.RTF_R8;
			}
			return EnumMarshaler<ETextureRenderTargetFormat>.FromNative(IntPtr.Add(base.Address, RenderTargetFormat_Offset), 0, RenderTargetFormat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderTargetFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:RenderTargetFormat");
			}
			else
			{
				EnumMarshaler<ETextureRenderTargetFormat>.ToNative(IntPtr.Add(base.Address, RenderTargetFormat_Offset), 0, RenderTargetFormat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:bAutoGenerateMips")]
	public bool AutoGenerateMips
	{
		get
		{
			CheckDestroyed();
			if (!AutoGenerateMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:bAutoGenerateMips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoGenerateMips_Offset), 0, AutoGenerateMips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoGenerateMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:bAutoGenerateMips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoGenerateMips_Offset), 0, AutoGenerateMips_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:MipsSamplerFilter")]
	public ETextureFilter MipsSamplerFilter
	{
		get
		{
			CheckDestroyed();
			if (!MipsSamplerFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsSamplerFilter");
				return ETextureFilter.TF_Nearest;
			}
			return EnumMarshaler<ETextureFilter>.FromNative(IntPtr.Add(base.Address, MipsSamplerFilter_Offset), 0, MipsSamplerFilter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MipsSamplerFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsSamplerFilter");
			}
			else
			{
				EnumMarshaler<ETextureFilter>.ToNative(IntPtr.Add(base.Address, MipsSamplerFilter_Offset), 0, MipsSamplerFilter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:MipsAddressU")]
	public ETextureAddress MipsAddressU
	{
		get
		{
			CheckDestroyed();
			if (!MipsAddressU_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsAddressU");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, MipsAddressU_Offset), 0, MipsAddressU_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MipsAddressU_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsAddressU");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, MipsAddressU_Offset), 0, MipsAddressU_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2D:MipsAddressV")]
	public ETextureAddress MipsAddressV
	{
		get
		{
			CheckDestroyed();
			if (!MipsAddressV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsAddressV");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, MipsAddressV_Offset), 0, MipsAddressV_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MipsAddressV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2D:MipsAddressV");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, MipsAddressV_Offset), 0, MipsAddressV_PropertyAddress.Address, value);
			}
		}
	}

	static UTextureRenderTarget2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextureRenderTarget2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextureRenderTarget2D));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextureRenderTarget2D");
		SizeX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeX");
		SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeX", Classes.FIntProperty);
		SizeY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeY");
		SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeY", Classes.FIntProperty);
		ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ClearColor");
		ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, unrealStruct, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, unrealStruct, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AddressY", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GPUSharedFlag_PropertyAddress, unrealStruct, "bGPUSharedFlag");
		GPUSharedFlag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bGPUSharedFlag");
		GPUSharedFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bGPUSharedFlag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetFormat_PropertyAddress, unrealStruct, "RenderTargetFormat");
		RenderTargetFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderTargetFormat");
		RenderTargetFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderTargetFormat", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateMips_PropertyAddress, unrealStruct, "bAutoGenerateMips");
		AutoGenerateMips_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoGenerateMips");
		AutoGenerateMips_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoGenerateMips", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MipsSamplerFilter_PropertyAddress, unrealStruct, "MipsSamplerFilter");
		MipsSamplerFilter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipsSamplerFilter");
		MipsSamplerFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipsSamplerFilter", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MipsAddressU_PropertyAddress, unrealStruct, "MipsAddressU");
		MipsAddressU_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipsAddressU");
		MipsAddressU_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipsAddressU", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MipsAddressV_PropertyAddress, unrealStruct, "MipsAddressV");
		MipsAddressV_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipsAddressV");
		MipsAddressV_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipsAddressV", Classes.FByteProperty);
	}
}
