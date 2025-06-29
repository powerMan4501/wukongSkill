using System;
using UnrealEngine.Plugins.ActorLayerUtilities;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineRenderPasses;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase", "MovieRenderPipelineRenderPasses", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineDeferredPassBase : UMoviePipelineImagePassBase
{
	private static bool AccumulatorIncludesAlpha_IsValid;

	private static FFieldAddress AccumulatorIncludesAlpha_PropertyAddress;

	private static int AccumulatorIncludesAlpha_Offset;

	private static bool DisableMultisampleEffects_IsValid;

	private static FFieldAddress DisableMultisampleEffects_PropertyAddress;

	private static int DisableMultisampleEffects_Offset;

	private static bool Use32BitPostProcessMaterials_IsValid;

	private static FFieldAddress Use32BitPostProcessMaterials_PropertyAddress;

	private static int Use32BitPostProcessMaterials_Offset;

	private static bool AdditionalPostProcessMaterials_IsValid;

	private static FFieldAddress AdditionalPostProcessMaterials_PropertyAddress;

	private static int AdditionalPostProcessMaterials_Offset;

	private TArrayReadWriteMarshaler<FMoviePipelinePostProcessPass> AdditionalPostProcessMaterials_MarshalerCached;

	private static bool AddDefaultLayer_IsValid;

	private static FFieldAddress AddDefaultLayer_PropertyAddress;

	private static int AddDefaultLayer_Offset;

	private static bool StencilLayers_IsValid;

	private static FFieldAddress StencilLayers_PropertyAddress;

	private static int StencilLayers_Offset;

	private TArrayReadWriteMarshaler<FActorLayer> StencilLayers_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAccumulatorIncludesAlpha")]
	public bool AccumulatorIncludesAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AccumulatorIncludesAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAccumulatorIncludesAlpha");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AccumulatorIncludesAlpha_Offset), 0, AccumulatorIncludesAlpha_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AccumulatorIncludesAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAccumulatorIncludesAlpha");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AccumulatorIncludesAlpha_Offset), 0, AccumulatorIncludesAlpha_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bDisableMultisampleEffects")]
	public bool DisableMultisampleEffects
	{
		get
		{
			CheckDestroyed();
			if (!DisableMultisampleEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bDisableMultisampleEffects");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableMultisampleEffects_Offset), 0, DisableMultisampleEffects_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableMultisampleEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bDisableMultisampleEffects");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableMultisampleEffects_Offset), 0, DisableMultisampleEffects_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bUse32BitPostProcessMaterials")]
	public bool Use32BitPostProcessMaterials
	{
		get
		{
			CheckDestroyed();
			if (!Use32BitPostProcessMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bUse32BitPostProcessMaterials");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Use32BitPostProcessMaterials_Offset), 0, Use32BitPostProcessMaterials_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Use32BitPostProcessMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bUse32BitPostProcessMaterials");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Use32BitPostProcessMaterials_Offset), 0, Use32BitPostProcessMaterials_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:AdditionalPostProcessMaterials")]
	public TArrayReadWrite<FMoviePipelinePostProcessPass> AdditionalPostProcessMaterials
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalPostProcessMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:AdditionalPostProcessMaterials");
				return null;
			}
			if (AdditionalPostProcessMaterials_MarshalerCached == null)
			{
				AdditionalPostProcessMaterials_MarshalerCached = new TArrayReadWriteMarshaler<FMoviePipelinePostProcessPass>(1, AdditionalPostProcessMaterials_PropertyAddress, CachedMarshalingDelegates<FMoviePipelinePostProcessPass, FMoviePipelinePostProcessPass>.FromNative, CachedMarshalingDelegates<FMoviePipelinePostProcessPass, FMoviePipelinePostProcessPass>.ToNative);
			}
			return AdditionalPostProcessMaterials_MarshalerCached.FromNative(IntPtr.Add(base.Address, AdditionalPostProcessMaterials_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAddDefaultLayer")]
	public bool AddDefaultLayer
	{
		get
		{
			CheckDestroyed();
			if (!AddDefaultLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAddDefaultLayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AddDefaultLayer_Offset), 0, AddDefaultLayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddDefaultLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:bAddDefaultLayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AddDefaultLayer_Offset), 0, AddDefaultLayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:StencilLayers")]
	public TArrayReadWrite<FActorLayer> StencilLayers
	{
		get
		{
			CheckDestroyed();
			if (!StencilLayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase:StencilLayers");
				return null;
			}
			if (StencilLayers_MarshalerCached == null)
			{
				StencilLayers_MarshalerCached = new TArrayReadWriteMarshaler<FActorLayer>(1, StencilLayers_PropertyAddress, CachedMarshalingDelegates<FActorLayer, FActorLayer>.FromNative, CachedMarshalingDelegates<FActorLayer, FActorLayer>.ToNative);
			}
			return StencilLayers_MarshalerCached.FromNative(IntPtr.Add(base.Address, StencilLayers_Offset));
		}
	}

	static UMoviePipelineDeferredPassBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineDeferredPassBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineDeferredPassBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineRenderPasses.MoviePipelineDeferredPassBase");
		NativeReflectionCached.GetPropertyRef(ref AccumulatorIncludesAlpha_PropertyAddress, unrealStruct, "bAccumulatorIncludesAlpha");
		AccumulatorIncludesAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAccumulatorIncludesAlpha");
		AccumulatorIncludesAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAccumulatorIncludesAlpha", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMultisampleEffects_PropertyAddress, unrealStruct, "bDisableMultisampleEffects");
		DisableMultisampleEffects_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisableMultisampleEffects");
		DisableMultisampleEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisableMultisampleEffects", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Use32BitPostProcessMaterials_PropertyAddress, unrealStruct, "bUse32BitPostProcessMaterials");
		Use32BitPostProcessMaterials_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUse32BitPostProcessMaterials");
		Use32BitPostProcessMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUse32BitPostProcessMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AdditionalPostProcessMaterials_PropertyAddress, unrealStruct, "AdditionalPostProcessMaterials");
		AdditionalPostProcessMaterials_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdditionalPostProcessMaterials");
		AdditionalPostProcessMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdditionalPostProcessMaterials", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddDefaultLayer_PropertyAddress, unrealStruct, "bAddDefaultLayer");
		AddDefaultLayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAddDefaultLayer");
		AddDefaultLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAddDefaultLayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StencilLayers_PropertyAddress, unrealStruct, "StencilLayers");
		StencilLayers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StencilLayers");
		StencilLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StencilLayers", Classes.FArrayProperty);
	}
}
