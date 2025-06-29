using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutor", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineInProcessExecutor : UMoviePipelineLinearExecutorBase
{
	private static bool UseCurrentLevel_IsValid;

	private static FFieldAddress UseCurrentLevel_PropertyAddress;

	private static int UseCurrentLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutor:bUseCurrentLevel")]
	public bool UseCurrentLevel
	{
		get
		{
			CheckDestroyed();
			if (!UseCurrentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutor:bUseCurrentLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCurrentLevel_Offset), 0, UseCurrentLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCurrentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutor:bUseCurrentLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCurrentLevel_Offset), 0, UseCurrentLevel_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineInProcessExecutor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineInProcessExecutor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineInProcessExecutor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineInProcessExecutor");
		NativeReflectionCached.GetPropertyRef(ref UseCurrentLevel_PropertyAddress, unrealStruct, "bUseCurrentLevel");
		UseCurrentLevel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCurrentLevel");
		UseCurrentLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCurrentLevel", Classes.FBoolProperty);
	}
}
