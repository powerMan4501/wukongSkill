using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting
{
	private static bool GameModeOverride_IsValid;

	private static int GameModeOverride_Offset;

	private static bool CinematicQualitySettings_IsValid;

	private static FFieldAddress CinematicQualitySettings_PropertyAddress;

	private static int CinematicQualitySettings_Offset;

	private static bool TextureStreaming_IsValid;

	private static FFieldAddress TextureStreaming_PropertyAddress;

	private static int TextureStreaming_Offset;

	private static bool UseLODZero_IsValid;

	private static FFieldAddress UseLODZero_PropertyAddress;

	private static int UseLODZero_Offset;

	private static bool DisableHLODs_IsValid;

	private static FFieldAddress DisableHLODs_PropertyAddress;

	private static int DisableHLODs_Offset;

	private static bool UseHighQualityShadows_IsValid;

	private static FFieldAddress UseHighQualityShadows_PropertyAddress;

	private static int UseHighQualityShadows_Offset;

	private static bool ShadowDistanceScale_IsValid;

	private static int ShadowDistanceScale_Offset;

	private static bool ShadowRadiusThreshold_IsValid;

	private static int ShadowRadiusThreshold_Offset;

	private static bool OverrideViewDistanceScale_IsValid;

	private static FFieldAddress OverrideViewDistanceScale_PropertyAddress;

	private static int OverrideViewDistanceScale_Offset;

	private static bool ViewDistanceScale_IsValid;

	private static int ViewDistanceScale_Offset;

	private static bool FlushGrassStreaming_IsValid;

	private static FFieldAddress FlushGrassStreaming_PropertyAddress;

	private static int FlushGrassStreaming_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:GameModeOverride")]
	public TSubclassOf<AGameModeBase> GameModeOverride
	{
		get
		{
			CheckDestroyed();
			if (!GameModeOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:GameModeOverride");
				return default(TSubclassOf<AGameModeBase>);
			}
			return TSubclassOfMarshaler<AGameModeBase>.FromNative(IntPtr.Add(base.Address, GameModeOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameModeOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:GameModeOverride");
			}
			else
			{
				TSubclassOfMarshaler<AGameModeBase>.ToNative(IntPtr.Add(base.Address, GameModeOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bCinematicQualitySettings")]
	public bool CinematicQualitySettings
	{
		get
		{
			CheckDestroyed();
			if (!CinematicQualitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bCinematicQualitySettings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CinematicQualitySettings_Offset), 0, CinematicQualitySettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CinematicQualitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bCinematicQualitySettings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CinematicQualitySettings_Offset), 0, CinematicQualitySettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:TextureStreaming")]
	public EMoviePipelineTextureStreamingMethod TextureStreaming
	{
		get
		{
			CheckDestroyed();
			if (!TextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:TextureStreaming");
				return EMoviePipelineTextureStreamingMethod.None;
			}
			return EnumMarshaler<EMoviePipelineTextureStreamingMethod>.FromNative(IntPtr.Add(base.Address, TextureStreaming_Offset), 0, TextureStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:TextureStreaming");
			}
			else
			{
				EnumMarshaler<EMoviePipelineTextureStreamingMethod>.ToNative(IntPtr.Add(base.Address, TextureStreaming_Offset), 0, TextureStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseLODZero")]
	public bool UseLODZero
	{
		get
		{
			CheckDestroyed();
			if (!UseLODZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseLODZero");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLODZero_Offset), 0, UseLODZero_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseLODZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseLODZero");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLODZero_Offset), 0, UseLODZero_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bDisableHLODs")]
	public bool DisableHLODs
	{
		get
		{
			CheckDestroyed();
			if (!DisableHLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bDisableHLODs");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableHLODs_Offset), 0, DisableHLODs_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableHLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bDisableHLODs");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableHLODs_Offset), 0, DisableHLODs_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseHighQualityShadows")]
	public bool UseHighQualityShadows
	{
		get
		{
			CheckDestroyed();
			if (!UseHighQualityShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseHighQualityShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHighQualityShadows_Offset), 0, UseHighQualityShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHighQualityShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bUseHighQualityShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHighQualityShadows_Offset), 0, UseHighQualityShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowDistanceScale")]
	public int ShadowDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!ShadowDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowDistanceScale");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShadowDistanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowDistanceScale");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShadowDistanceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowRadiusThreshold")]
	public float ShadowRadiusThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ShadowRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowRadiusThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowRadiusThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ShadowRadiusThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowRadiusThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bOverrideViewDistanceScale")]
	public bool OverrideViewDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!OverrideViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bOverrideViewDistanceScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideViewDistanceScale_Offset), 0, OverrideViewDistanceScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bOverrideViewDistanceScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideViewDistanceScale_Offset), 0, OverrideViewDistanceScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ViewDistanceScale")]
	public int ViewDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!ViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ViewDistanceScale");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ViewDistanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:ViewDistanceScale");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ViewDistanceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bFlushGrassStreaming")]
	public bool FlushGrassStreaming
	{
		get
		{
			CheckDestroyed();
			if (!FlushGrassStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bFlushGrassStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FlushGrassStreaming_Offset), 0, FlushGrassStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FlushGrassStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting:bFlushGrassStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FlushGrassStreaming_Offset), 0, FlushGrassStreaming_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineGameOverrideSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineGameOverrideSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineGameOverrideSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineGameOverrideSetting");
		GameModeOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GameModeOverride");
		GameModeOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GameModeOverride", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CinematicQualitySettings_PropertyAddress, unrealStruct, "bCinematicQualitySettings");
		CinematicQualitySettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCinematicQualitySettings");
		CinematicQualitySettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCinematicQualitySettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TextureStreaming_PropertyAddress, unrealStruct, "TextureStreaming");
		TextureStreaming_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureStreaming");
		TextureStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureStreaming", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLODZero_PropertyAddress, unrealStruct, "bUseLODZero");
		UseLODZero_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseLODZero");
		UseLODZero_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseLODZero", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableHLODs_PropertyAddress, unrealStruct, "bDisableHLODs");
		DisableHLODs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisableHLODs");
		DisableHLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisableHLODs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHighQualityShadows_PropertyAddress, unrealStruct, "bUseHighQualityShadows");
		UseHighQualityShadows_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseHighQualityShadows");
		UseHighQualityShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseHighQualityShadows", Classes.FBoolProperty);
		ShadowDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShadowDistanceScale");
		ShadowDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShadowDistanceScale", Classes.FIntProperty);
		ShadowRadiusThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShadowRadiusThreshold");
		ShadowRadiusThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShadowRadiusThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideViewDistanceScale_PropertyAddress, unrealStruct, "bOverrideViewDistanceScale");
		OverrideViewDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideViewDistanceScale");
		OverrideViewDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideViewDistanceScale", Classes.FBoolProperty);
		ViewDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ViewDistanceScale");
		ViewDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ViewDistanceScale", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FlushGrassStreaming_PropertyAddress, unrealStruct, "bFlushGrassStreaming");
		FlushGrassStreaming_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFlushGrassStreaming");
		FlushGrassStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFlushGrassStreaming", Classes.FBoolProperty);
	}
}
