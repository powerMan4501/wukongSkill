using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureRenderTargetVolume", "Engine", UnrealModuleType.Engine)]
public class UTextureRenderTargetVolume : UTextureRenderTarget
{
	private static bool SizeX_IsValid;

	private static int SizeX_Offset;

	private static bool SizeY_IsValid;

	private static int SizeY_Offset;

	private static bool SizeZ_IsValid;

	private static int SizeZ_Offset;

	private static bool HDR_IsValid;

	private static FFieldAddress HDR_PropertyAddress;

	private static int HDR_Offset;

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetVolume:SizeX")]
	public int SizeX
	{
		get
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetVolume:SizeY")]
	public int SizeY
	{
		get
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetVolume:SizeZ")]
	public int SizeZ
	{
		get
		{
			CheckDestroyed();
			if (!SizeZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeZ");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:SizeZ");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeZ_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetVolume:bHDR")]
	public bool HDR
	{
		get
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:bHDR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetVolume:bHDR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address, value);
			}
		}
	}

	static UTextureRenderTargetVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextureRenderTargetVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextureRenderTargetVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextureRenderTargetVolume");
		SizeX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeX");
		SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeX", Classes.FIntProperty);
		SizeY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeY");
		SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeY", Classes.FIntProperty);
		SizeZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeZ");
		SizeZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeZ", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HDR_PropertyAddress, unrealStruct, "bHDR");
		HDR_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bHDR");
		HDR_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bHDR", Classes.FBoolProperty);
	}
}
