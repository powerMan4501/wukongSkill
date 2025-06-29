using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureRenderTargetCube", "Engine", UnrealModuleType.Engine)]
public class UTextureRenderTargetCube : UTextureRenderTarget
{
	private static bool SizeX_IsValid;

	private static int SizeX_Offset;

	private static bool HDR_IsValid;

	private static FFieldAddress HDR_PropertyAddress;

	private static int HDR_Offset;

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetCube:SizeX")]
	public int SizeX
	{
		get
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetCube:SizeX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetCube:SizeX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.TextureRenderTargetCube:bHDR")]
	public bool HDR
	{
		get
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetCube:bHDR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTargetCube:bHDR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address, value);
			}
		}
	}

	static UTextureRenderTargetCube()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextureRenderTargetCube)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextureRenderTargetCube));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextureRenderTargetCube");
		SizeX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeX");
		SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HDR_PropertyAddress, unrealStruct, "bHDR");
		HDR_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bHDR");
		HDR_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bHDR", Classes.FBoolProperty);
	}
}
