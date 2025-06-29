using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureRenderTarget2DArray", "Engine", UnrealModuleType.Engine)]
public class UTextureRenderTarget2DArray : UTextureRenderTarget
{
	private static bool SizeX_IsValid;

	private static int SizeX_Offset;

	private static bool SizeY_IsValid;

	private static int SizeY_Offset;

	private static bool Slices_IsValid;

	private static int Slices_Offset;

	private static bool HDR_IsValid;

	private static FFieldAddress HDR_PropertyAddress;

	private static int HDR_Offset;

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2DArray:SizeX")]
	public int SizeX
	{
		get
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:SizeX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:SizeX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2DArray:SizeY")]
	public int SizeY
	{
		get
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:SizeY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SizeY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SizeY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:SizeY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SizeY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2DArray:Slices")]
	public int Slices
	{
		get
		{
			CheckDestroyed();
			if (!Slices_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:Slices");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Slices_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Slices_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:Slices");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Slices_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget2DArray:bHDR")]
	public bool HDR
	{
		get
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:bHDR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HDR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget2DArray:bHDR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HDR_Offset), 0, HDR_PropertyAddress.Address, value);
			}
		}
	}

	static UTextureRenderTarget2DArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextureRenderTarget2DArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextureRenderTarget2DArray));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextureRenderTarget2DArray");
		SizeX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeX");
		SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeX", Classes.FIntProperty);
		SizeY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SizeY");
		SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SizeY", Classes.FIntProperty);
		Slices_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Slices");
		Slices_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Slices", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HDR_PropertyAddress, unrealStruct, "bHDR");
		HDR_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bHDR");
		HDR_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bHDR", Classes.FBoolProperty);
	}
}
