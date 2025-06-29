using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineEditor;

[UClass(Flags = (ClassFlags)810025126uL, Config = "Editor")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings", "MovieRenderPipelineEditor", UnrealModuleType.EnginePlugin)]
public class UMovieRenderPipelineProjectSettings : UObject
{
	private static bool PresetSaveDir_IsValid;

	private static int PresetSaveDir_Offset;

	private static bool LastPresetOrigin_IsValid;

	private static int LastPresetOrigin_Offset;

	private static bool DefaultLocalExecutor_IsValid;

	private static int DefaultLocalExecutor_Offset;

	private static bool DefaultRemoteExecutor_IsValid;

	private static int DefaultRemoteExecutor_Offset;

	private static bool DefaultExecutorJob_IsValid;

	private static int DefaultExecutorJob_Offset;

	private static bool DefaultPipeline_IsValid;

	private static int DefaultPipeline_Offset;

	private static bool DefaultClasses_IsValid;

	private static FFieldAddress DefaultClasses_PropertyAddress;

	private static int DefaultClasses_Offset;

	private TArrayReadWriteMarshaler<TSubclassOf<UMoviePipelineSetting>> DefaultClasses_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:PresetSaveDir")]
	public FDirectoryPath PresetSaveDir
	{
		get
		{
			CheckDestroyed();
			if (!PresetSaveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:PresetSaveDir");
				return default(FDirectoryPath);
			}
			return FDirectoryPath.FromNative(IntPtr.Add(base.Address, PresetSaveDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetSaveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:PresetSaveDir");
			}
			else
			{
				FDirectoryPath.ToNative(IntPtr.Add(base.Address, PresetSaveDir_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881299347906565uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:LastPresetOrigin")]
	public TSoftObject<UMoviePipelineMasterConfig> LastPresetOrigin
	{
		get
		{
			CheckDestroyed();
			if (!LastPresetOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:LastPresetOrigin");
				return default(TSoftObject<UMoviePipelineMasterConfig>);
			}
			return TSoftObjectMarshaler<UMoviePipelineMasterConfig>.FromNative(IntPtr.Add(base.Address, LastPresetOrigin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastPresetOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:LastPresetOrigin");
			}
			else
			{
				TSoftObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(base.Address, LastPresetOrigin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141133829uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultLocalExecutor")]
	public TSubclassOf<UMoviePipelineExecutorBase> DefaultLocalExecutor
	{
		get
		{
			CheckDestroyed();
			if (!DefaultLocalExecutor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultLocalExecutor");
				return default(TSubclassOf<UMoviePipelineExecutorBase>);
			}
			return TSubclassOfMarshaler<UMoviePipelineExecutorBase>.FromNative(IntPtr.Add(base.Address, DefaultLocalExecutor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultLocalExecutor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultLocalExecutor");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipelineExecutorBase>.ToNative(IntPtr.Add(base.Address, DefaultLocalExecutor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141133829uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultRemoteExecutor")]
	public TSubclassOf<UMoviePipelineExecutorBase> DefaultRemoteExecutor
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRemoteExecutor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultRemoteExecutor");
				return default(TSubclassOf<UMoviePipelineExecutorBase>);
			}
			return TSubclassOfMarshaler<UMoviePipelineExecutorBase>.FromNative(IntPtr.Add(base.Address, DefaultRemoteExecutor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRemoteExecutor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultRemoteExecutor");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipelineExecutorBase>.ToNative(IntPtr.Add(base.Address, DefaultRemoteExecutor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141133829uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultExecutorJob")]
	public TSubclassOf<UMoviePipelineExecutorJob> DefaultExecutorJob
	{
		get
		{
			CheckDestroyed();
			if (!DefaultExecutorJob_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultExecutorJob");
				return default(TSubclassOf<UMoviePipelineExecutorJob>);
			}
			return TSubclassOfMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(base.Address, DefaultExecutorJob_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultExecutorJob_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultExecutorJob");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(base.Address, DefaultExecutorJob_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141133829uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultPipeline")]
	public TSubclassOf<UMoviePipeline> DefaultPipeline
	{
		get
		{
			CheckDestroyed();
			if (!DefaultPipeline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultPipeline");
				return default(TSubclassOf<UMoviePipeline>);
			}
			return TSubclassOfMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(base.Address, DefaultPipeline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultPipeline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultPipeline");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(base.Address, DefaultPipeline_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534230021uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultClasses")]
	public TArrayReadWrite<TSubclassOf<UMoviePipelineSetting>> DefaultClasses
	{
		get
		{
			CheckDestroyed();
			if (!DefaultClasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings:DefaultClasses");
				return null;
			}
			if (DefaultClasses_MarshalerCached == null)
			{
				DefaultClasses_MarshalerCached = new TArrayReadWriteMarshaler<TSubclassOf<UMoviePipelineSetting>>(1, DefaultClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UMoviePipelineSetting>, TSubclassOfMarshaler<UMoviePipelineSetting>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UMoviePipelineSetting>, TSubclassOfMarshaler<UMoviePipelineSetting>>.ToNative);
			}
			return DefaultClasses_MarshalerCached.FromNative(IntPtr.Add(base.Address, DefaultClasses_Offset));
		}
	}

	static UMovieRenderPipelineProjectSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieRenderPipelineProjectSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieRenderPipelineProjectSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineEditor.MovieRenderPipelineProjectSettings");
		PresetSaveDir_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PresetSaveDir");
		PresetSaveDir_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PresetSaveDir", Classes.FStructProperty);
		LastPresetOrigin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LastPresetOrigin");
		LastPresetOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LastPresetOrigin", Classes.FSoftObjectProperty);
		DefaultLocalExecutor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultLocalExecutor");
		DefaultLocalExecutor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultLocalExecutor", Classes.FClassProperty);
		DefaultRemoteExecutor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultRemoteExecutor");
		DefaultRemoteExecutor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultRemoteExecutor", Classes.FClassProperty);
		DefaultExecutorJob_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultExecutorJob");
		DefaultExecutorJob_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultExecutorJob", Classes.FClassProperty);
		DefaultPipeline_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultPipeline");
		DefaultPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultPipeline", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultClasses_PropertyAddress, unrealStruct, "DefaultClasses");
		DefaultClasses_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultClasses");
		DefaultClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultClasses", Classes.FArrayProperty);
	}
}
