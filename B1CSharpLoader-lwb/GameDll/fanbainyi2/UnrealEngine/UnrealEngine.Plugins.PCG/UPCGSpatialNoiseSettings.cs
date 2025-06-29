using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSpatialNoiseSettings : UPCGSettings
{
	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool EdgeMask2DMode_IsValid;

	private static FFieldAddress EdgeMask2DMode_PropertyAddress;

	private static int EdgeMask2DMode_Offset;

	private static bool Iterations_IsValid;

	private static int Iterations_Offset;

	private static bool Tiling_IsValid;

	private static FFieldAddress Tiling_PropertyAddress;

	private static int Tiling_Offset;

	private static bool Brightness_IsValid;

	private static int Brightness_Offset;

	private static bool Contrast_IsValid;

	private static int Contrast_Offset;

	private static bool ValueTarget_IsValid;

	private static int ValueTarget_Offset;

	private static bool RandomOffset_IsValid;

	private static int RandomOffset_Offset;

	private static bool Transform_IsValid;

	private static int Transform_Offset;

	private static bool VoronoiCellRandomness_IsValid;

	private static int VoronoiCellRandomness_Offset;

	private static bool VoronoiCellIDTarget_IsValid;

	private static int VoronoiCellIDTarget_Offset;

	private static bool VoronoiOrientSamplesToCellEdge_IsValid;

	private static FFieldAddress VoronoiOrientSamplesToCellEdge_PropertyAddress;

	private static int VoronoiOrientSamplesToCellEdge_Offset;

	private static bool TiledVoronoiResolution_IsValid;

	private static int TiledVoronoiResolution_Offset;

	private static bool TiledVoronoiEdgeBlendCellCount_IsValid;

	private static int TiledVoronoiEdgeBlendCellCount_Offset;

	private static bool EdgeBlendDistance_IsValid;

	private static int EdgeBlendDistance_Offset;

	private static bool EdgeBlendCurveOffset_IsValid;

	private static int EdgeBlendCurveOffset_Offset;

	private static bool EdgeBlendCurveIntensity_IsValid;

	private static int EdgeBlendCurveIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:Mode")]
	public EPCGSpatialNoiseMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Mode");
				return EPCGSpatialNoiseMode.Perlin2D;
			}
			return EnumMarshaler<EPCGSpatialNoiseMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGSpatialNoiseMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:EdgeMask2DMode")]
	public EPCGSpatialNoiseMask2DMode EdgeMask2DMode
	{
		get
		{
			CheckDestroyed();
			if (!EdgeMask2DMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeMask2DMode");
				return EPCGSpatialNoiseMask2DMode.Perlin;
			}
			return EnumMarshaler<EPCGSpatialNoiseMask2DMode>.FromNative(IntPtr.Add(base.Address, EdgeMask2DMode_Offset), 0, EdgeMask2DMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EdgeMask2DMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeMask2DMode");
			}
			else
			{
				EnumMarshaler<EPCGSpatialNoiseMask2DMode>.ToNative(IntPtr.Add(base.Address, EdgeMask2DMode_Offset), 0, EdgeMask2DMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:Iterations")]
	public int Iterations
	{
		get
		{
			CheckDestroyed();
			if (!Iterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Iterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Iterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Iterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Iterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Iterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:bTiling")]
	public bool Tiling
	{
		get
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:bTiling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Tiling_Offset), 0, Tiling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:bTiling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Tiling_Offset), 0, Tiling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:Brightness")]
	public float Brightness
	{
		get
		{
			CheckDestroyed();
			if (!Brightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Brightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Brightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Brightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Brightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Brightness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:Contrast")]
	public float Contrast
	{
		get
		{
			CheckDestroyed();
			if (!Contrast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Contrast");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Contrast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Contrast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Contrast");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Contrast_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:ValueTarget")]
	public FPCGAttributePropertyOutputNoSourceSelector ValueTarget
	{
		get
		{
			CheckDestroyed();
			if (!ValueTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:ValueTarget");
				return default(FPCGAttributePropertyOutputNoSourceSelector);
			}
			return FPCGAttributePropertyOutputNoSourceSelector.FromNative(IntPtr.Add(base.Address, ValueTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValueTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:ValueTarget");
			}
			else
			{
				FPCGAttributePropertyOutputNoSourceSelector.ToNative(IntPtr.Add(base.Address, ValueTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:RandomOffset")]
	public FVector RandomOffset
	{
		get
		{
			CheckDestroyed();
			if (!RandomOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:RandomOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RandomOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:RandomOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RandomOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:Transform")]
	public FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellRandomness")]
	public double VoronoiCellRandomness
	{
		get
		{
			CheckDestroyed();
			if (!VoronoiCellRandomness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellRandomness");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, VoronoiCellRandomness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoronoiCellRandomness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellRandomness");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, VoronoiCellRandomness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellIDTarget")]
	public FPCGAttributePropertyOutputNoSourceSelector VoronoiCellIDTarget
	{
		get
		{
			CheckDestroyed();
			if (!VoronoiCellIDTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellIDTarget");
				return default(FPCGAttributePropertyOutputNoSourceSelector);
			}
			return FPCGAttributePropertyOutputNoSourceSelector.FromNative(IntPtr.Add(base.Address, VoronoiCellIDTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoronoiCellIDTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:VoronoiCellIDTarget");
			}
			else
			{
				FPCGAttributePropertyOutputNoSourceSelector.ToNative(IntPtr.Add(base.Address, VoronoiCellIDTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:bVoronoiOrientSamplesToCellEdge")]
	public bool VoronoiOrientSamplesToCellEdge
	{
		get
		{
			CheckDestroyed();
			if (!VoronoiOrientSamplesToCellEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:bVoronoiOrientSamplesToCellEdge");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VoronoiOrientSamplesToCellEdge_Offset), 0, VoronoiOrientSamplesToCellEdge_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VoronoiOrientSamplesToCellEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:bVoronoiOrientSamplesToCellEdge");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VoronoiOrientSamplesToCellEdge_Offset), 0, VoronoiOrientSamplesToCellEdge_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiResolution")]
	public int TiledVoronoiResolution
	{
		get
		{
			CheckDestroyed();
			if (!TiledVoronoiResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiResolution");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TiledVoronoiResolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TiledVoronoiResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiResolution");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TiledVoronoiResolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiEdgeBlendCellCount")]
	public int TiledVoronoiEdgeBlendCellCount
	{
		get
		{
			CheckDestroyed();
			if (!TiledVoronoiEdgeBlendCellCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiEdgeBlendCellCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TiledVoronoiEdgeBlendCellCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TiledVoronoiEdgeBlendCellCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:TiledVoronoiEdgeBlendCellCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TiledVoronoiEdgeBlendCellCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendDistance")]
	public float EdgeBlendDistance
	{
		get
		{
			CheckDestroyed();
			if (!EdgeBlendDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeBlendDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeBlendDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeBlendDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveOffset")]
	public float EdgeBlendCurveOffset
	{
		get
		{
			CheckDestroyed();
			if (!EdgeBlendCurveOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeBlendCurveOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeBlendCurveOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeBlendCurveOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveIntensity")]
	public float EdgeBlendCurveIntensity
	{
		get
		{
			CheckDestroyed();
			if (!EdgeBlendCurveIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeBlendCurveIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeBlendCurveIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialNoiseSettings:EdgeBlendCurveIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeBlendCurveIntensity_Offset), value);
			}
		}
	}

	static UPCGSpatialNoiseSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSpatialNoiseSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSpatialNoiseSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSpatialNoiseSettings");
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EdgeMask2DMode_PropertyAddress, unrealStruct, "EdgeMask2DMode");
		EdgeMask2DMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EdgeMask2DMode");
		EdgeMask2DMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EdgeMask2DMode", Classes.FEnumProperty);
		Iterations_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Iterations");
		Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Iterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Tiling_PropertyAddress, unrealStruct, "bTiling");
		Tiling_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTiling");
		Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTiling", Classes.FBoolProperty);
		Brightness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Brightness");
		Brightness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Brightness", Classes.FFloatProperty);
		Contrast_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Contrast");
		Contrast_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Contrast", Classes.FFloatProperty);
		ValueTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ValueTarget");
		ValueTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ValueTarget", Classes.FStructProperty);
		RandomOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RandomOffset");
		RandomOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RandomOffset", Classes.FStructProperty);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Transform", Classes.FStructProperty);
		VoronoiCellRandomness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VoronoiCellRandomness");
		VoronoiCellRandomness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VoronoiCellRandomness", Classes.FDoubleProperty);
		VoronoiCellIDTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VoronoiCellIDTarget");
		VoronoiCellIDTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VoronoiCellIDTarget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VoronoiOrientSamplesToCellEdge_PropertyAddress, unrealStruct, "bVoronoiOrientSamplesToCellEdge");
		VoronoiOrientSamplesToCellEdge_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bVoronoiOrientSamplesToCellEdge");
		VoronoiOrientSamplesToCellEdge_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bVoronoiOrientSamplesToCellEdge", Classes.FBoolProperty);
		TiledVoronoiResolution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TiledVoronoiResolution");
		TiledVoronoiResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TiledVoronoiResolution", Classes.FIntProperty);
		TiledVoronoiEdgeBlendCellCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TiledVoronoiEdgeBlendCellCount");
		TiledVoronoiEdgeBlendCellCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TiledVoronoiEdgeBlendCellCount", Classes.FIntProperty);
		EdgeBlendDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EdgeBlendDistance");
		EdgeBlendDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EdgeBlendDistance", Classes.FFloatProperty);
		EdgeBlendCurveOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EdgeBlendCurveOffset");
		EdgeBlendCurveOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EdgeBlendCurveOffset", Classes.FFloatProperty);
		EdgeBlendCurveIntensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EdgeBlendCurveIntensity");
		EdgeBlendCurveIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EdgeBlendCurveIntensity", Classes.FFloatProperty);
	}
}
