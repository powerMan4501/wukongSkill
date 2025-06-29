using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGTextureSamplerSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGTextureSamplerSettings : UPCGSettings
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	private static bool UseAbsoluteTransform_IsValid;

	private static FFieldAddress UseAbsoluteTransform_PropertyAddress;

	private static int UseAbsoluteTransform_Offset;

	private static bool Texture_IsValid;

	private static int Texture_Offset;

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

	private static bool TileBoundsMin_IsValid;

	private static int TileBoundsMin_Offset;

	private static bool TileBoundsMax_IsValid;

	private static int TileBoundsMax_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:Transform")]
	public FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:bUseAbsoluteTransform")]
	public bool UseAbsoluteTransform
	{
		get
		{
			CheckDestroyed();
			if (!UseAbsoluteTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseAbsoluteTransform");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAbsoluteTransform_Offset), 0, UseAbsoluteTransform_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAbsoluteTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseAbsoluteTransform");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAbsoluteTransform_Offset), 0, UseAbsoluteTransform_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:Texture")]
	public TSoftObject<UTexture2D> Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Texture");
				return default(TSoftObject<UTexture2D>);
			}
			return TSoftObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Texture");
			}
			else
			{
				TSoftObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:DensityFunction")]
	public EPCGTextureDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:DensityFunction");
				return EPCGTextureDensityFunction.Ignore;
			}
			return EnumMarshaler<EPCGTextureDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGTextureDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:ColorChannel")]
	public EPCGTextureColorChannel ColorChannel
	{
		get
		{
			CheckDestroyed();
			if (!ColorChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:ColorChannel");
				return EPCGTextureColorChannel.Red;
			}
			return EnumMarshaler<EPCGTextureColorChannel>.FromNative(IntPtr.Add(base.Address, ColorChannel_Offset), 0, ColorChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ColorChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:ColorChannel");
			}
			else
			{
				EnumMarshaler<EPCGTextureColorChannel>.ToNative(IntPtr.Add(base.Address, ColorChannel_Offset), 0, ColorChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:TexelSize")]
	public float TexelSize
	{
		get
		{
			CheckDestroyed();
			if (!TexelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TexelSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TexelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TexelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TexelSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TexelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:bUseAdvancedTiling")]
	public bool UseAdvancedTiling
	{
		get
		{
			CheckDestroyed();
			if (!UseAdvancedTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseAdvancedTiling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAdvancedTiling_Offset), 0, UseAdvancedTiling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAdvancedTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseAdvancedTiling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAdvancedTiling_Offset), 0, UseAdvancedTiling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:Tiling")]
	public FVector2D Tiling
	{
		get
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Tiling");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Tiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Tiling");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Tiling_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:CenterOffset")]
	public FVector2D CenterOffset
	{
		get
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:CenterOffset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, CenterOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:CenterOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, CenterOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:Rotation")]
	public float Rotation
	{
		get
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Rotation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Rotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:Rotation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Rotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:bUseTileBounds")]
	public bool UseTileBounds
	{
		get
		{
			CheckDestroyed();
			if (!UseTileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseTileBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTileBounds_Offset), 0, UseTileBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTileBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:bUseTileBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTileBounds_Offset), 0, UseTileBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMin")]
	public FVector2D TileBoundsMin
	{
		get
		{
			CheckDestroyed();
			if (!TileBoundsMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMin");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, TileBoundsMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileBoundsMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, TileBoundsMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMax")]
	public FVector2D TileBoundsMax
	{
		get
		{
			CheckDestroyed();
			if (!TileBoundsMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMax");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, TileBoundsMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileBoundsMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureSamplerSettings:TileBoundsMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, TileBoundsMax_Offset), value);
			}
		}
	}

	static UPCGTextureSamplerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGTextureSamplerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGTextureSamplerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGTextureSamplerSettings");
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAbsoluteTransform_PropertyAddress, unrealStruct, "bUseAbsoluteTransform");
		UseAbsoluteTransform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAbsoluteTransform");
		UseAbsoluteTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAbsoluteTransform", Classes.FBoolProperty);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Texture", Classes.FSoftObjectProperty);
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
		TileBoundsMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileBoundsMin");
		TileBoundsMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileBoundsMin", Classes.FStructProperty);
		TileBoundsMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileBoundsMax");
		TileBoundsMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileBoundsMax", Classes.FStructProperty);
	}
}
