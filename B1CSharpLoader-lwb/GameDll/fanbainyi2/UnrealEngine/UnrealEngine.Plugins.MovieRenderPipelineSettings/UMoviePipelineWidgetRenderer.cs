using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineSettings;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineWidgetRenderer", "MovieRenderPipelineSettings", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineWidgetRenderer : UMoviePipelineRenderPass
{
	private static bool CompositeOntoFinalImage_IsValid;

	private static FFieldAddress CompositeOntoFinalImage_PropertyAddress;

	private static int CompositeOntoFinalImage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineWidgetRenderer:bCompositeOntoFinalImage")]
	public bool CompositeOntoFinalImage
	{
		get
		{
			CheckDestroyed();
			if (!CompositeOntoFinalImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineWidgetRenderer:bCompositeOntoFinalImage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CompositeOntoFinalImage_Offset), 0, CompositeOntoFinalImage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompositeOntoFinalImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineWidgetRenderer:bCompositeOntoFinalImage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CompositeOntoFinalImage_Offset), 0, CompositeOntoFinalImage_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineWidgetRenderer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineWidgetRenderer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineWidgetRenderer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineSettings.MoviePipelineWidgetRenderer");
		NativeReflectionCached.GetPropertyRef(ref CompositeOntoFinalImage_PropertyAddress, unrealStruct, "bCompositeOntoFinalImage");
		CompositeOntoFinalImage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCompositeOntoFinalImage");
		CompositeOntoFinalImage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCompositeOntoFinalImage", Classes.FBoolProperty);
	}
}
