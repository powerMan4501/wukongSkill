using System;
using UnrealEngine.DeveloperSettings;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineCommandLineEncoderSettings : UDeveloperSettings
{
	private static bool ExecutablePath_IsValid;

	private static int ExecutablePath_Offset;

	private static bool VideoCodec_IsValid;

	private static int VideoCodec_Offset;

	private static bool AudioCodec_IsValid;

	private static int AudioCodec_Offset;

	private static bool OutputFileExtension_IsValid;

	private static int OutputFileExtension_Offset;

	private static bool CommandLineFormat_IsValid;

	private static int CommandLineFormat_Offset;

	private static bool VideoInputStringFormat_IsValid;

	private static int VideoInputStringFormat_Offset;

	private static bool AudioInputStringFormat_IsValid;

	private static int AudioInputStringFormat_Offset;

	private static bool EncodeSettings_Low_IsValid;

	private static int EncodeSettings_Low_Offset;

	private static bool EncodeSettings_Med_IsValid;

	private static int EncodeSettings_Med_Offset;

	private static bool EncodeSettings_High_IsValid;

	private static int EncodeSettings_High_Offset;

	private static bool EncodeSettings_Epic_IsValid;

	private static int EncodeSettings_Epic_Offset;

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:ExecutablePath")]
	public string ExecutablePath
	{
		get
		{
			CheckDestroyed();
			if (!ExecutablePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:ExecutablePath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ExecutablePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExecutablePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:ExecutablePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ExecutablePath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoCodec")]
	public string VideoCodec
	{
		get
		{
			CheckDestroyed();
			if (!VideoCodec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoCodec");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, VideoCodec_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VideoCodec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoCodec");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, VideoCodec_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioCodec")]
	public string AudioCodec
	{
		get
		{
			CheckDestroyed();
			if (!AudioCodec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioCodec");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AudioCodec_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioCodec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioCodec");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AudioCodec_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:OutputFileExtension")]
	public string OutputFileExtension
	{
		get
		{
			CheckDestroyed();
			if (!OutputFileExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:OutputFileExtension");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OutputFileExtension_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputFileExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:OutputFileExtension");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OutputFileExtension_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:CommandLineFormat")]
	public string CommandLineFormat
	{
		get
		{
			CheckDestroyed();
			if (!CommandLineFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:CommandLineFormat");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CommandLineFormat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommandLineFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:CommandLineFormat");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CommandLineFormat_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoInputStringFormat")]
	public string VideoInputStringFormat
	{
		get
		{
			CheckDestroyed();
			if (!VideoInputStringFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoInputStringFormat");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, VideoInputStringFormat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VideoInputStringFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:VideoInputStringFormat");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, VideoInputStringFormat_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioInputStringFormat")]
	public string AudioInputStringFormat
	{
		get
		{
			CheckDestroyed();
			if (!AudioInputStringFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioInputStringFormat");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AudioInputStringFormat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioInputStringFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:AudioInputStringFormat");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AudioInputStringFormat_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Low")]
	public string EncodeSettings_Low
	{
		get
		{
			CheckDestroyed();
			if (!EncodeSettings_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Low");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EncodeSettings_Low_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EncodeSettings_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Low");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EncodeSettings_Low_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Med")]
	public string EncodeSettings_Med
	{
		get
		{
			CheckDestroyed();
			if (!EncodeSettings_Med_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Med");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EncodeSettings_Med_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EncodeSettings_Med_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Med");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EncodeSettings_Med_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_High")]
	public string EncodeSettings_High
	{
		get
		{
			CheckDestroyed();
			if (!EncodeSettings_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_High");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EncodeSettings_High_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EncodeSettings_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_High");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EncodeSettings_High_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Epic")]
	public string EncodeSettings_Epic
	{
		get
		{
			CheckDestroyed();
			if (!EncodeSettings_Epic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Epic");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EncodeSettings_Epic_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EncodeSettings_Epic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings:EncodeSettings_Epic");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EncodeSettings_Epic_Offset), value);
			}
		}
	}

	static UMoviePipelineCommandLineEncoderSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineCommandLineEncoderSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineCommandLineEncoderSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoderSettings");
		ExecutablePath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExecutablePath");
		ExecutablePath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExecutablePath", Classes.FStrProperty);
		VideoCodec_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VideoCodec");
		VideoCodec_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VideoCodec", Classes.FStrProperty);
		AudioCodec_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AudioCodec");
		AudioCodec_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AudioCodec", Classes.FStrProperty);
		OutputFileExtension_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputFileExtension");
		OutputFileExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputFileExtension", Classes.FStrProperty);
		CommandLineFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CommandLineFormat");
		CommandLineFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CommandLineFormat", Classes.FStrProperty);
		VideoInputStringFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VideoInputStringFormat");
		VideoInputStringFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VideoInputStringFormat", Classes.FStrProperty);
		AudioInputStringFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AudioInputStringFormat");
		AudioInputStringFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AudioInputStringFormat", Classes.FStrProperty);
		EncodeSettings_Low_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EncodeSettings_Low");
		EncodeSettings_Low_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EncodeSettings_Low", Classes.FStrProperty);
		EncodeSettings_Med_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EncodeSettings_Med");
		EncodeSettings_Med_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EncodeSettings_Med", Classes.FStrProperty);
		EncodeSettings_High_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EncodeSettings_High");
		EncodeSettings_High_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EncodeSettings_High", Classes.FStrProperty);
		EncodeSettings_Epic_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EncodeSettings_Epic");
		EncodeSettings_Epic_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EncodeSettings_Epic", Classes.FStrProperty);
	}
}
