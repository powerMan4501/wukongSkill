using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineAntiAliasingSetting : UMoviePipelineSetting
{
	private static bool SpatialSampleCount_IsValid;

	private static int SpatialSampleCount_Offset;

	private static bool TemporalSampleCount_IsValid;

	private static int TemporalSampleCount_Offset;

	private static bool OverrideAntiAliasing_IsValid;

	private static FFieldAddress OverrideAntiAliasing_PropertyAddress;

	private static int OverrideAntiAliasing_Offset;

	private static bool AntiAliasingMethod_IsValid;

	private static FFieldAddress AntiAliasingMethod_PropertyAddress;

	private static int AntiAliasingMethod_Offset;

	private static bool RenderWarmUpCount_IsValid;

	private static int RenderWarmUpCount_Offset;

	private static bool UseCameraCutForWarmUp_IsValid;

	private static FFieldAddress UseCameraCutForWarmUp_PropertyAddress;

	private static int UseCameraCutForWarmUp_Offset;

	private static bool EngineWarmUpCount_IsValid;

	private static int EngineWarmUpCount_Offset;

	private static bool RenderWarmUpFrames_IsValid;

	private static FFieldAddress RenderWarmUpFrames_PropertyAddress;

	private static int RenderWarmUpFrames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:SpatialSampleCount")]
	public int SpatialSampleCount
	{
		get
		{
			CheckDestroyed();
			if (!SpatialSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:SpatialSampleCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpatialSampleCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpatialSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:SpatialSampleCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpatialSampleCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:TemporalSampleCount")]
	public int TemporalSampleCount
	{
		get
		{
			CheckDestroyed();
			if (!TemporalSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:TemporalSampleCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TemporalSampleCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemporalSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:TemporalSampleCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TemporalSampleCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bOverrideAntiAliasing")]
	public bool OverrideAntiAliasing
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAntiAliasing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bOverrideAntiAliasing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideAntiAliasing_Offset), 0, OverrideAntiAliasing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAntiAliasing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bOverrideAntiAliasing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideAntiAliasing_Offset), 0, OverrideAntiAliasing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:AntiAliasingMethod")]
	public EAntiAliasingMethod AntiAliasingMethod
	{
		get
		{
			CheckDestroyed();
			if (!AntiAliasingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:AntiAliasingMethod");
				return EAntiAliasingMethod.AAM_None;
			}
			return EnumMarshaler<EAntiAliasingMethod>.FromNative(IntPtr.Add(base.Address, AntiAliasingMethod_Offset), 0, AntiAliasingMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AntiAliasingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:AntiAliasingMethod");
			}
			else
			{
				EnumMarshaler<EAntiAliasingMethod>.ToNative(IntPtr.Add(base.Address, AntiAliasingMethod_Offset), 0, AntiAliasingMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:RenderWarmUpCount")]
	public int RenderWarmUpCount
	{
		get
		{
			CheckDestroyed();
			if (!RenderWarmUpCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:RenderWarmUpCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RenderWarmUpCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderWarmUpCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:RenderWarmUpCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RenderWarmUpCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bUseCameraCutForWarmUp")]
	public bool UseCameraCutForWarmUp
	{
		get
		{
			CheckDestroyed();
			if (!UseCameraCutForWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bUseCameraCutForWarmUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCameraCutForWarmUp_Offset), 0, UseCameraCutForWarmUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCameraCutForWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bUseCameraCutForWarmUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCameraCutForWarmUp_Offset), 0, UseCameraCutForWarmUp_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:EngineWarmUpCount")]
	public int EngineWarmUpCount
	{
		get
		{
			CheckDestroyed();
			if (!EngineWarmUpCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:EngineWarmUpCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EngineWarmUpCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EngineWarmUpCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:EngineWarmUpCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EngineWarmUpCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bRenderWarmUpFrames")]
	public bool RenderWarmUpFrames
	{
		get
		{
			CheckDestroyed();
			if (!RenderWarmUpFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bRenderWarmUpFrames");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderWarmUpFrames_Offset), 0, RenderWarmUpFrames_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderWarmUpFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting:bRenderWarmUpFrames");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderWarmUpFrames_Offset), 0, RenderWarmUpFrames_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineAntiAliasingSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineAntiAliasingSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineAntiAliasingSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineAntiAliasingSetting");
		SpatialSampleCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpatialSampleCount");
		SpatialSampleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpatialSampleCount", Classes.FIntProperty);
		TemporalSampleCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TemporalSampleCount");
		TemporalSampleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TemporalSampleCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideAntiAliasing_PropertyAddress, unrealStruct, "bOverrideAntiAliasing");
		OverrideAntiAliasing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideAntiAliasing");
		OverrideAntiAliasing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideAntiAliasing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AntiAliasingMethod_PropertyAddress, unrealStruct, "AntiAliasingMethod");
		AntiAliasingMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AntiAliasingMethod");
		AntiAliasingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AntiAliasingMethod", Classes.FByteProperty);
		RenderWarmUpCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderWarmUpCount");
		RenderWarmUpCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderWarmUpCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCameraCutForWarmUp_PropertyAddress, unrealStruct, "bUseCameraCutForWarmUp");
		UseCameraCutForWarmUp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCameraCutForWarmUp");
		UseCameraCutForWarmUp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCameraCutForWarmUp", Classes.FBoolProperty);
		EngineWarmUpCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EngineWarmUpCount");
		EngineWarmUpCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EngineWarmUpCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderWarmUpFrames_PropertyAddress, unrealStruct, "bRenderWarmUpFrames");
		RenderWarmUpFrames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRenderWarmUpFrames");
		RenderWarmUpFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRenderWarmUpFrames", Classes.FBoolProperty);
	}
}
