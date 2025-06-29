using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGBaseTextureData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBaseTextureData : UPCGSurfaceData
{
	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool ColorChannel_IsValid;

	private static FFieldAddress ColorChannel_PropertyAddress;

	private static int ColorChannel_Offset;

	private static bool TexelSize_IsValid;

	private static int TexelSize_Offset;

	private static bool UseAdvancedTiling_IsValid;

	private static FFieldAddress UseAdvancedTiling_PropertyAddress;

	private static int UseAdvancedTiling_Offset;

	private static bool Tiling_IsValid;

	private static int Tiling_Offset;

	private static bool CenterOffset_IsValid;

	private static int CenterOffset_Offset;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	private static bool UseTileBounds_IsValid;

	private static FFieldAddress UseTileBounds_PropertyAddress;

	private static int UseTileBounds_Offset;

	private static bool TileBounds_IsValid;

	private static int TileBounds_Offset;

	private static bool Bounds_IsValid;

	private static int Bounds_Offset;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool Width_IsValid;

	private static int Width_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:DensityFunction")]
	public EPCGTextureDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:DensityFunction");
				return EPCGTextureDensityFunction.Ignore;
			}
			return EnumMarshaler<EPCGTextureDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGTextureDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:ColorChannel")]
	public EPCGTextureColorChannel ColorChannel
	{
		get
		{
			CheckDestroyed();
			if (!ColorChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:ColorChannel");
				return EPCGTextureColorChannel.Red;
			}
			return EnumMarshaler<EPCGTextureColorChannel>.FromNative(IntPtr.Add(base.Address, ColorChannel_Offset), 0, ColorChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ColorChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:ColorChannel");
			}
			else
			{
				EnumMarshaler<EPCGTextureColorChannel>.ToNative(IntPtr.Add(base.Address, ColorChannel_Offset), 0, ColorChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:TexelSize")]
	public float TexelSize
	{
		get
		{
			CheckDestroyed();
			if (!TexelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:TexelSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TexelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TexelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:TexelSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TexelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:bUseAdvancedTiling")]
	public bool UseAdvancedTiling
	{
		get
		{
			CheckDestroyed();
			if (!UseAdvancedTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:bUseAdvancedTiling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAdvancedTiling_Offset), 0, UseAdvancedTiling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAdvancedTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:bUseAdvancedTiling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAdvancedTiling_Offset), 0, UseAdvancedTiling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:Tiling")]
	public FVector2D Tiling
	{
		get
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Tiling");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Tiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Tiling");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Tiling_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:CenterOffset")]
	public FVector2D CenterOffset
	{
		get
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:CenterOffset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, CenterOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:CenterOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, CenterOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:Rotation")]
	public float Rotation
	{
		get
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Rotation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Rotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Rotation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Rotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:bUseTileBounds")]
	public bool UseTileBounds
	{
		get
		{
			CheckDestroyed();
			if (!UseTileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:bUseTileBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTileBounds_Offset), 0, UseTileBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:bUseTileBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTileBounds_Offset), 0, UseTileBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:TileBounds")]
	public FBox2D TileBounds
	{
		get
		{
			CheckDestroyed();
			if (!TileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:TileBounds");
				return default(FBox2D);
			}
			return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(base.Address, TileBounds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:TileBounds");
			}
			else
			{
				BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(base.Address, TileBounds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9016065141113365uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:Bounds")]
	protected FBox Bounds
	{
		get
		{
			CheckDestroyed();
			if (!Bounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Bounds");
				return default(FBox);
			}
			return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(base.Address, Bounds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Bounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Bounds");
			}
			else
			{
				BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(base.Address, Bounds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954798613uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:Height")]
	protected int Height
	{
		get
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Height");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Height_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Height");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Height_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954798613uL)]
	[UMetaPath("/Script/PCG.PCGBaseTextureData:Width")]
	protected int Width
	{
		get
		{
			CheckDestroyed();
			if (!Width_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Width");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Width_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Width_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBaseTextureData:Width");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Width_Offset), value);
			}
		}
	}

	static UPCGBaseTextureData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBaseTextureData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBaseTextureData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGBaseTextureData");
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, unrealStruct, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DensityFunction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ColorChannel_PropertyAddress, unrealStruct, "ColorChannel");
		ColorChannel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ColorChannel");
		ColorChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ColorChannel", Classes.FEnumProperty);
		TexelSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TexelSize");
		TexelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TexelSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAdvancedTiling_PropertyAddress, unrealStruct, "bUseAdvancedTiling");
		UseAdvancedTiling_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAdvancedTiling");
		UseAdvancedTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAdvancedTiling", Classes.FBoolProperty);
		Tiling_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Tiling");
		Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Tiling", Classes.FStructProperty);
		CenterOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CenterOffset");
		CenterOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CenterOffset", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseTileBounds_PropertyAddress, unrealStruct, "bUseTileBounds");
		UseTileBounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseTileBounds");
		UseTileBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseTileBounds", Classes.FBoolProperty);
		TileBounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileBounds");
		TileBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileBounds", Classes.FStructProperty);
		Bounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Bounds");
		Bounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Bounds", Classes.FStructProperty);
		Height_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Height");
		Height_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Height", Classes.FIntProperty);
		Width_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Width");
		Width_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Width", Classes.FIntProperty);
	}
}
