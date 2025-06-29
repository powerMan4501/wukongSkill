using System;
using UnrealEngine.Plugins.OpenColorIO;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineColorSetting : UMoviePipelineSetting
{
	private static bool OCIOConfiguration_IsValid;

	private static int OCIOConfiguration_Offset;

	private static bool DisableToneCurve_IsValid;

	private static FFieldAddress DisableToneCurve_PropertyAddress;

	private static int DisableToneCurve_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:OCIOConfiguration")]
	public FOpenColorIODisplayConfiguration OCIOConfiguration
	{
		get
		{
			CheckDestroyed();
			if (!OCIOConfiguration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:OCIOConfiguration");
				return default(FOpenColorIODisplayConfiguration);
			}
			return FOpenColorIODisplayConfiguration.FromNative(IntPtr.Add(base.Address, OCIOConfiguration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OCIOConfiguration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:OCIOConfiguration");
			}
			else
			{
				FOpenColorIODisplayConfiguration.ToNative(IntPtr.Add(base.Address, OCIOConfiguration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:bDisableToneCurve")]
	public bool DisableToneCurve
	{
		get
		{
			CheckDestroyed();
			if (!DisableToneCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:bDisableToneCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableToneCurve_Offset), 0, DisableToneCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableToneCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting:bDisableToneCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableToneCurve_Offset), 0, DisableToneCurve_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineColorSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineColorSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineColorSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineColorSetting");
		OCIOConfiguration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OCIOConfiguration");
		OCIOConfiguration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OCIOConfiguration", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableToneCurve_PropertyAddress, unrealStruct, "bDisableToneCurve");
		DisableToneCurve_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisableToneCurve");
		DisableToneCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisableToneCurve", Classes.FBoolProperty);
	}
}
