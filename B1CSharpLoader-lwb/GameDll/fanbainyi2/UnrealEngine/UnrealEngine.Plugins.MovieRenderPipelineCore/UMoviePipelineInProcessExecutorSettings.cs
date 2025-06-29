using System;
using UnrealEngine.DeveloperSettings;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineInProcessExecutorSettings : UDeveloperSettings
{
	private static bool CloseEditor_IsValid;

	private static FFieldAddress CloseEditor_PropertyAddress;

	private static int CloseEditor_Offset;

	private static bool AdditionalCommandLineArguments_IsValid;

	private static int AdditionalCommandLineArguments_Offset;

	private static bool InheritedCommandLineArguments_IsValid;

	private static int InheritedCommandLineArguments_Offset;

	private static bool InitialDelayFrameCount_IsValid;

	private static int InitialDelayFrameCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:bCloseEditor")]
	public bool CloseEditor
	{
		get
		{
			CheckDestroyed();
			if (!CloseEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:bCloseEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CloseEditor_Offset), 0, CloseEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CloseEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:bCloseEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CloseEditor_Offset), 0, CloseEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:AdditionalCommandLineArguments")]
	public string AdditionalCommandLineArguments
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:AdditionalCommandLineArguments");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AdditionalCommandLineArguments_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:AdditionalCommandLineArguments");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AdditionalCommandLineArguments_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441211925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InheritedCommandLineArguments")]
	public string InheritedCommandLineArguments
	{
		get
		{
			CheckDestroyed();
			if (!InheritedCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InheritedCommandLineArguments");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, InheritedCommandLineArguments_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InheritedCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InheritedCommandLineArguments");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, InheritedCommandLineArguments_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InitialDelayFrameCount")]
	public int InitialDelayFrameCount
	{
		get
		{
			CheckDestroyed();
			if (!InitialDelayFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InitialDelayFrameCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InitialDelayFrameCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialDelayFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings:InitialDelayFrameCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InitialDelayFrameCount_Offset), value);
			}
		}
	}

	static UMoviePipelineInProcessExecutorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineInProcessExecutorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineInProcessExecutorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutorSettings");
		NativeReflectionCached.GetPropertyRef(ref CloseEditor_PropertyAddress, unrealStruct, "bCloseEditor");
		CloseEditor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCloseEditor");
		CloseEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCloseEditor", Classes.FBoolProperty);
		AdditionalCommandLineArguments_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdditionalCommandLineArguments");
		AdditionalCommandLineArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdditionalCommandLineArguments", Classes.FStrProperty);
		InheritedCommandLineArguments_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InheritedCommandLineArguments");
		InheritedCommandLineArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InheritedCommandLineArguments", Classes.FStrProperty);
		InitialDelayFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InitialDelayFrameCount");
		InitialDelayFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InitialDelayFrameCount", Classes.FIntProperty);
	}
}
