using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineSettings;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting", "MovieRenderPipelineSettings", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineBurnInSetting : UMoviePipelineRenderPass
{
	private static bool BurnInClass_IsValid;

	private static int BurnInClass_Offset;

	private static bool CompositeOntoFinalImage_IsValid;

	private static FFieldAddress CompositeOntoFinalImage_PropertyAddress;

	private static int CompositeOntoFinalImage_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:BurnInClass")]
	public FSoftClassPath BurnInClass
	{
		get
		{
			CheckDestroyed();
			if (!BurnInClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:BurnInClass");
				return default(FSoftClassPath);
			}
			return FSoftClassPath.FromNative(IntPtr.Add(base.Address, BurnInClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurnInClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:BurnInClass");
			}
			else
			{
				FSoftClassPath.ToNative(IntPtr.Add(base.Address, BurnInClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:bCompositeOntoFinalImage")]
	public bool CompositeOntoFinalImage
	{
		get
		{
			CheckDestroyed();
			if (!CompositeOntoFinalImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:bCompositeOntoFinalImage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CompositeOntoFinalImage_Offset), 0, CompositeOntoFinalImage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompositeOntoFinalImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting:bCompositeOntoFinalImage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CompositeOntoFinalImage_Offset), 0, CompositeOntoFinalImage_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineBurnInSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineBurnInSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineBurnInSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInSetting");
		BurnInClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BurnInClass");
		BurnInClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BurnInClass", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CompositeOntoFinalImage_PropertyAddress, unrealStruct, "bCompositeOntoFinalImage");
		CompositeOntoFinalImage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCompositeOntoFinalImage");
		CompositeOntoFinalImage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCompositeOntoFinalImage", Classes.FBoolProperty);
	}
}
