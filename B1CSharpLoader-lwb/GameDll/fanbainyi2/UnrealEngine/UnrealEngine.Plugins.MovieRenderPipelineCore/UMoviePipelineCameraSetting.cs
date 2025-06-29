using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineCameraSetting : UMoviePipelineSetting
{
	private static bool ShutterTiming_IsValid;

	private static FFieldAddress ShutterTiming_PropertyAddress;

	private static int ShutterTiming_Offset;

	private static bool OverscanPercentage_IsValid;

	private static int OverscanPercentage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:ShutterTiming")]
	public EMoviePipelineShutterTiming ShutterTiming
	{
		get
		{
			CheckDestroyed();
			if (!ShutterTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:ShutterTiming");
				return EMoviePipelineShutterTiming.FrameOpen;
			}
			return EnumMarshaler<EMoviePipelineShutterTiming>.FromNative(IntPtr.Add(base.Address, ShutterTiming_Offset), 0, ShutterTiming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShutterTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:ShutterTiming");
			}
			else
			{
				EnumMarshaler<EMoviePipelineShutterTiming>.ToNative(IntPtr.Add(base.Address, ShutterTiming_Offset), 0, ShutterTiming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:OverscanPercentage")]
	public float OverscanPercentage
	{
		get
		{
			CheckDestroyed();
			if (!OverscanPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:OverscanPercentage");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverscanPercentage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverscanPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting:OverscanPercentage");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverscanPercentage_Offset), value);
			}
		}
	}

	static UMoviePipelineCameraSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineCameraSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineCameraSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineCameraSetting");
		NativeReflectionCached.GetPropertyRef(ref ShutterTiming_PropertyAddress, unrealStruct, "ShutterTiming");
		ShutterTiming_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShutterTiming");
		ShutterTiming_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShutterTiming", Classes.FEnumProperty);
		OverscanPercentage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverscanPercentage");
		OverscanPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverscanPercentage", Classes.FFloatProperty);
	}
}
