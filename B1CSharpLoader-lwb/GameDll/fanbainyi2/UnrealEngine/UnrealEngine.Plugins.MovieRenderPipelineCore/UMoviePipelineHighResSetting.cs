using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineHighResSetting : UMoviePipelineSetting
{
	private static bool TileCount_IsValid;

	private static int TileCount_Offset;

	private static bool TextureSharpnessBias_IsValid;

	private static int TextureSharpnessBias_Offset;

	private static bool OverlapRatio_IsValid;

	private static int OverlapRatio_Offset;

	private static bool OverrideSubSurfaceScattering_IsValid;

	private static FFieldAddress OverrideSubSurfaceScattering_PropertyAddress;

	private static int OverrideSubSurfaceScattering_Offset;

	private static bool BurleySampleCount_IsValid;

	private static int BurleySampleCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TileCount")]
	public int TileCount
	{
		get
		{
			CheckDestroyed();
			if (!TileCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TileCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TileCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TextureSharpnessBias")]
	public float TextureSharpnessBias
	{
		get
		{
			CheckDestroyed();
			if (!TextureSharpnessBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TextureSharpnessBias");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TextureSharpnessBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureSharpnessBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:TextureSharpnessBias");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TextureSharpnessBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:OverlapRatio")]
	public float OverlapRatio
	{
		get
		{
			CheckDestroyed();
			if (!OverlapRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:OverlapRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverlapRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverlapRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:OverlapRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverlapRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:bOverrideSubSurfaceScattering")]
	public bool OverrideSubSurfaceScattering
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSubSurfaceScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:bOverrideSubSurfaceScattering");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideSubSurfaceScattering_Offset), 0, OverrideSubSurfaceScattering_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSubSurfaceScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:bOverrideSubSurfaceScattering");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideSubSurfaceScattering_Offset), 0, OverrideSubSurfaceScattering_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:BurleySampleCount")]
	public int BurleySampleCount
	{
		get
		{
			CheckDestroyed();
			if (!BurleySampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:BurleySampleCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BurleySampleCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurleySampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting:BurleySampleCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BurleySampleCount_Offset), value);
			}
		}
	}

	static UMoviePipelineHighResSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineHighResSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineHighResSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineHighResSetting");
		TileCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileCount");
		TileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileCount", Classes.FIntProperty);
		TextureSharpnessBias_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureSharpnessBias");
		TextureSharpnessBias_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureSharpnessBias", Classes.FFloatProperty);
		OverlapRatio_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverlapRatio");
		OverlapRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverlapRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSubSurfaceScattering_PropertyAddress, unrealStruct, "bOverrideSubSurfaceScattering");
		OverrideSubSurfaceScattering_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideSubSurfaceScattering");
		OverrideSubSurfaceScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideSubSurfaceScattering", Classes.FBoolProperty);
		BurleySampleCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BurleySampleCount");
		BurleySampleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BurleySampleCount", Classes.FIntProperty);
	}
}
