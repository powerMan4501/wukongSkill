using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineFCPXMLExporter : UMoviePipelineOutputBase
{
	private static bool FileNameFormatOverride_IsValid;

	private static int FileNameFormatOverride_Offset;

	private static bool DataSource_IsValid;

	private static FFieldAddress DataSource_PropertyAddress;

	private static int DataSource_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:FileNameFormatOverride")]
	public string FileNameFormatOverride
	{
		get
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:FileNameFormatOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:FileNameFormatOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:DataSource")]
	public EFCPXMLExportDataSource DataSource
	{
		get
		{
			CheckDestroyed();
			if (!DataSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:DataSource");
				return EFCPXMLExportDataSource.OutputMetadata;
			}
			return EnumMarshaler<EFCPXMLExportDataSource>.FromNative(IntPtr.Add(base.Address, DataSource_Offset), 0, DataSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DataSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter:DataSource");
			}
			else
			{
				EnumMarshaler<EFCPXMLExportDataSource>.ToNative(IntPtr.Add(base.Address, DataSource_Offset), 0, DataSource_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineFCPXMLExporter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineFCPXMLExporter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineFCPXMLExporter));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineFCPXMLExporter");
		FileNameFormatOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FileNameFormatOverride");
		FileNameFormatOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FileNameFormatOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DataSource_PropertyAddress, unrealStruct, "DataSource");
		DataSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DataSource");
		DataSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DataSource", Classes.FEnumProperty);
	}
}
