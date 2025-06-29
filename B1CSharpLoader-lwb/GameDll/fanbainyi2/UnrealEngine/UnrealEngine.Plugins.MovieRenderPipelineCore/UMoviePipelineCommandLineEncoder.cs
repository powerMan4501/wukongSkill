using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineCommandLineEncoder : UMoviePipelineSetting
{
	private static bool FileNameFormatOverride_IsValid;

	private static int FileNameFormatOverride_Offset;

	private static bool Quality_IsValid;

	private static FFieldAddress Quality_PropertyAddress;

	private static int Quality_Offset;

	private static bool AdditionalCommandLineArgs_IsValid;

	private static int AdditionalCommandLineArgs_Offset;

	private static bool DeleteSourceFiles_IsValid;

	private static FFieldAddress DeleteSourceFiles_PropertyAddress;

	private static int DeleteSourceFiles_Offset;

	private static bool SkipEncodeOnRenderCanceled_IsValid;

	private static FFieldAddress SkipEncodeOnRenderCanceled_PropertyAddress;

	private static int SkipEncodeOnRenderCanceled_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:FileNameFormatOverride")]
	public string FileNameFormatOverride
	{
		get
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:FileNameFormatOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:FileNameFormatOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:Quality")]
	public EMoviePipelineEncodeQuality Quality
	{
		get
		{
			CheckDestroyed();
			if (!Quality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:Quality");
				return EMoviePipelineEncodeQuality.Low;
			}
			return EnumMarshaler<EMoviePipelineEncodeQuality>.FromNative(IntPtr.Add(base.Address, Quality_Offset), 0, Quality_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Quality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:Quality");
			}
			else
			{
				EnumMarshaler<EMoviePipelineEncodeQuality>.ToNative(IntPtr.Add(base.Address, Quality_Offset), 0, Quality_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:AdditionalCommandLineArgs")]
	public string AdditionalCommandLineArgs
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArgs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:AdditionalCommandLineArgs");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AdditionalCommandLineArgs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArgs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:AdditionalCommandLineArgs");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AdditionalCommandLineArgs_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bDeleteSourceFiles")]
	public bool DeleteSourceFiles
	{
		get
		{
			CheckDestroyed();
			if (!DeleteSourceFiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bDeleteSourceFiles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DeleteSourceFiles_Offset), 0, DeleteSourceFiles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeleteSourceFiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bDeleteSourceFiles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DeleteSourceFiles_Offset), 0, DeleteSourceFiles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bSkipEncodeOnRenderCanceled")]
	public bool SkipEncodeOnRenderCanceled
	{
		get
		{
			CheckDestroyed();
			if (!SkipEncodeOnRenderCanceled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bSkipEncodeOnRenderCanceled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipEncodeOnRenderCanceled_Offset), 0, SkipEncodeOnRenderCanceled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipEncodeOnRenderCanceled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder:bSkipEncodeOnRenderCanceled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipEncodeOnRenderCanceled_Offset), 0, SkipEncodeOnRenderCanceled_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineCommandLineEncoder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineCommandLineEncoder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineCommandLineEncoder));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineCommandLineEncoder");
		FileNameFormatOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FileNameFormatOverride");
		FileNameFormatOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FileNameFormatOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Quality_PropertyAddress, unrealStruct, "Quality");
		Quality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Quality");
		Quality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Quality", Classes.FEnumProperty);
		AdditionalCommandLineArgs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdditionalCommandLineArgs");
		AdditionalCommandLineArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdditionalCommandLineArgs", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteSourceFiles_PropertyAddress, unrealStruct, "bDeleteSourceFiles");
		DeleteSourceFiles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDeleteSourceFiles");
		DeleteSourceFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDeleteSourceFiles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipEncodeOnRenderCanceled_PropertyAddress, unrealStruct, "bSkipEncodeOnRenderCanceled");
		SkipEncodeOnRenderCanceled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSkipEncodeOnRenderCanceled");
		SkipEncodeOnRenderCanceled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSkipEncodeOnRenderCanceled", Classes.FBoolProperty);
	}
}
