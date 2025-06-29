using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineOutputSetting : UMoviePipelineSetting
{
	private static bool OutputDirectory_IsValid;

	private static int OutputDirectory_Offset;

	private static bool FileNameFormat_IsValid;

	private static int FileNameFormat_Offset;

	private static bool OutputResolution_IsValid;

	private static int OutputResolution_Offset;

	private static bool UseCustomFrameRate_IsValid;

	private static FFieldAddress UseCustomFrameRate_PropertyAddress;

	private static int UseCustomFrameRate_Offset;

	private static bool OutputFrameRate_IsValid;

	private static int OutputFrameRate_Offset;

	private static bool OverrideExistingOutput_IsValid;

	private static FFieldAddress OverrideExistingOutput_PropertyAddress;

	private static int OverrideExistingOutput_Offset;

	private static bool HandleFrameCount_IsValid;

	private static int HandleFrameCount_Offset;

	private static bool OutputFrameStep_IsValid;

	private static int OutputFrameStep_Offset;

	private static bool UseCustomPlaybackRange_IsValid;

	private static FFieldAddress UseCustomPlaybackRange_PropertyAddress;

	private static int UseCustomPlaybackRange_Offset;

	private static bool CustomStartFrame_IsValid;

	private static int CustomStartFrame_Offset;

	private static bool CustomEndFrame_IsValid;

	private static int CustomEndFrame_Offset;

	private static bool VersionNumber_IsValid;

	private static int VersionNumber_Offset;

	private static bool AutoVersion_IsValid;

	private static FFieldAddress AutoVersion_PropertyAddress;

	private static int AutoVersion_Offset;

	private static bool ZeroPadFrameNumbers_IsValid;

	private static int ZeroPadFrameNumbers_Offset;

	private static bool FrameNumberOffset_IsValid;

	private static int FrameNumberOffset_Offset;

	private static bool FlushDiskWritesPerShot_IsValid;

	private static FFieldAddress FlushDiskWritesPerShot_PropertyAddress;

	private static int FlushDiskWritesPerShot_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputDirectory")]
	public FDirectoryPath OutputDirectory
	{
		get
		{
			CheckDestroyed();
			if (!OutputDirectory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputDirectory");
				return default(FDirectoryPath);
			}
			return FDirectoryPath.FromNative(IntPtr.Add(base.Address, OutputDirectory_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputDirectory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputDirectory");
			}
			else
			{
				FDirectoryPath.ToNative(IntPtr.Add(base.Address, OutputDirectory_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FileNameFormat")]
	public string FileNameFormat
	{
		get
		{
			CheckDestroyed();
			if (!FileNameFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FileNameFormat");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileNameFormat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileNameFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FileNameFormat");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileNameFormat_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputResolution")]
	public FIntPoint OutputResolution
	{
		get
		{
			CheckDestroyed();
			if (!OutputResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputResolution");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, OutputResolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputResolution");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, OutputResolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomFrameRate")]
	public bool UseCustomFrameRate
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomFrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomFrameRate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomFrameRate_Offset), 0, UseCustomFrameRate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomFrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomFrameRate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomFrameRate_Offset), 0, UseCustomFrameRate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameRate")]
	public FFrameRate OutputFrameRate
	{
		get
		{
			CheckDestroyed();
			if (!OutputFrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameRate");
				return default(FFrameRate);
			}
			return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(base.Address, OutputFrameRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputFrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameRate");
			}
			else
			{
				BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(base.Address, OutputFrameRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bOverrideExistingOutput")]
	public bool OverrideExistingOutput
	{
		get
		{
			CheckDestroyed();
			if (!OverrideExistingOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bOverrideExistingOutput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideExistingOutput_Offset), 0, OverrideExistingOutput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideExistingOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bOverrideExistingOutput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideExistingOutput_Offset), 0, OverrideExistingOutput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:HandleFrameCount")]
	public int HandleFrameCount
	{
		get
		{
			CheckDestroyed();
			if (!HandleFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:HandleFrameCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HandleFrameCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HandleFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:HandleFrameCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HandleFrameCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameStep")]
	public int OutputFrameStep
	{
		get
		{
			CheckDestroyed();
			if (!OutputFrameStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameStep");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OutputFrameStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputFrameStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:OutputFrameStep");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OutputFrameStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomPlaybackRange")]
	public bool UseCustomPlaybackRange
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomPlaybackRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomPlaybackRange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomPlaybackRange_Offset), 0, UseCustomPlaybackRange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomPlaybackRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bUseCustomPlaybackRange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomPlaybackRange_Offset), 0, UseCustomPlaybackRange_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomStartFrame")]
	public int CustomStartFrame
	{
		get
		{
			CheckDestroyed();
			if (!CustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomStartFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomStartFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomStartFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomStartFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomEndFrame")]
	public int CustomEndFrame
	{
		get
		{
			CheckDestroyed();
			if (!CustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomEndFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomEndFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:CustomEndFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomEndFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:VersionNumber")]
	public int VersionNumber
	{
		get
		{
			CheckDestroyed();
			if (!VersionNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:VersionNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VersionNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VersionNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:VersionNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VersionNumber_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bAutoVersion")]
	public bool AutoVersion
	{
		get
		{
			CheckDestroyed();
			if (!AutoVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bAutoVersion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoVersion_Offset), 0, AutoVersion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bAutoVersion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoVersion_Offset), 0, AutoVersion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:ZeroPadFrameNumbers")]
	public int ZeroPadFrameNumbers
	{
		get
		{
			CheckDestroyed();
			if (!ZeroPadFrameNumbers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:ZeroPadFrameNumbers");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ZeroPadFrameNumbers_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZeroPadFrameNumbers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:ZeroPadFrameNumbers");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ZeroPadFrameNumbers_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FrameNumberOffset")]
	public int FrameNumberOffset
	{
		get
		{
			CheckDestroyed();
			if (!FrameNumberOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FrameNumberOffset");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FrameNumberOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameNumberOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:FrameNumberOffset");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FrameNumberOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bFlushDiskWritesPerShot")]
	public bool FlushDiskWritesPerShot
	{
		get
		{
			CheckDestroyed();
			if (!FlushDiskWritesPerShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bFlushDiskWritesPerShot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FlushDiskWritesPerShot_Offset), 0, FlushDiskWritesPerShot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FlushDiskWritesPerShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting:bFlushDiskWritesPerShot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FlushDiskWritesPerShot_Offset), 0, FlushDiskWritesPerShot_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineOutputSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineOutputSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineOutputSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineOutputSetting");
		OutputDirectory_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputDirectory");
		OutputDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputDirectory", Classes.FStructProperty);
		FileNameFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FileNameFormat");
		FileNameFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FileNameFormat", Classes.FStrProperty);
		OutputResolution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputResolution");
		OutputResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputResolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomFrameRate_PropertyAddress, unrealStruct, "bUseCustomFrameRate");
		UseCustomFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCustomFrameRate");
		UseCustomFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCustomFrameRate", Classes.FBoolProperty);
		OutputFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputFrameRate");
		OutputFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputFrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideExistingOutput_PropertyAddress, unrealStruct, "bOverrideExistingOutput");
		OverrideExistingOutput_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideExistingOutput");
		OverrideExistingOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideExistingOutput", Classes.FBoolProperty);
		HandleFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HandleFrameCount");
		HandleFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HandleFrameCount", Classes.FIntProperty);
		OutputFrameStep_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputFrameStep");
		OutputFrameStep_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputFrameStep", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomPlaybackRange_PropertyAddress, unrealStruct, "bUseCustomPlaybackRange");
		UseCustomPlaybackRange_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCustomPlaybackRange");
		UseCustomPlaybackRange_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCustomPlaybackRange", Classes.FBoolProperty);
		CustomStartFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomStartFrame");
		CustomStartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomStartFrame", Classes.FIntProperty);
		CustomEndFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomEndFrame");
		CustomEndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomEndFrame", Classes.FIntProperty);
		VersionNumber_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VersionNumber");
		VersionNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VersionNumber", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoVersion_PropertyAddress, unrealStruct, "bAutoVersion");
		AutoVersion_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoVersion");
		AutoVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoVersion", Classes.FBoolProperty);
		ZeroPadFrameNumbers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ZeroPadFrameNumbers");
		ZeroPadFrameNumbers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ZeroPadFrameNumbers", Classes.FIntProperty);
		FrameNumberOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrameNumberOffset");
		FrameNumberOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrameNumberOffset", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FlushDiskWritesPerShot_PropertyAddress, unrealStruct, "bFlushDiskWritesPerShot");
		FlushDiskWritesPerShot_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFlushDiskWritesPerShot");
		FlushDiskWritesPerShot_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFlushDiskWritesPerShot", Classes.FBoolProperty);
	}
}
