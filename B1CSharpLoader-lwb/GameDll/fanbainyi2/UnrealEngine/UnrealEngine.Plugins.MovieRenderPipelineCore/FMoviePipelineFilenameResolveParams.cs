using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineFilenameResolveParams
{
	private static bool FrameNumber_IsValid;

	private static int FrameNumber_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FrameNumber")]
	public int FrameNumber;

	private static bool FrameNumberShot_IsValid;

	private static int FrameNumberShot_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FrameNumberShot")]
	public int FrameNumberShot;

	private static bool FrameNumberRel_IsValid;

	private static int FrameNumberRel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FrameNumberRel")]
	public int FrameNumberRel;

	private static bool FrameNumberShotRel_IsValid;

	private static int FrameNumberShotRel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FrameNumberShotRel")]
	public int FrameNumberShotRel;

	private static bool CameraNameOverride_IsValid;

	private static int CameraNameOverride_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:CameraNameOverride")]
	public string CameraNameOverride;

	private static bool ShotNameOverride_IsValid;

	private static int ShotNameOverride_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:ShotNameOverride")]
	public string ShotNameOverride;

	private static bool ZeroPadFrameNumberCount_IsValid;

	private static int ZeroPadFrameNumberCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:ZeroPadFrameNumberCount")]
	public int ZeroPadFrameNumberCount;

	private static bool ForceRelativeFrameNumbers_IsValid;

	private static FFieldAddress ForceRelativeFrameNumbers_PropertyAddress;

	private static int ForceRelativeFrameNumbers_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:bForceRelativeFrameNumbers")]
	public bool ForceRelativeFrameNumbers;

	private static bool FileNameFormatOverrides_IsValid;

	private static FFieldAddress FileNameFormatOverrides_PropertyAddress;

	private static int FileNameFormatOverrides_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FileNameFormatOverrides")]
	public Dictionary<string, string> FileNameFormatOverrides;

	private static bool FileMetadata_IsValid;

	private static FFieldAddress FileMetadata_PropertyAddress;

	private static int FileMetadata_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:FileMetadata")]
	public Dictionary<string, string> FileMetadata;

	private static bool InitializationTime_IsValid;

	private static int InitializationTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532997uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:InitializationTime")]
	public FDateTime InitializationTime;

	private static bool InitializationVersion_IsValid;

	private static int InitializationVersion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:InitializationVersion")]
	public int InitializationVersion;

	private static bool Job_IsValid;

	private static int Job_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:Job")]
	public UMoviePipelineExecutorJob Job;

	private static bool ShotOverride_IsValid;

	private static int ShotOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:ShotOverride")]
	public UMoviePipelineExecutorShot ShotOverride;

	private static bool AdditionalFrameNumberOffset_IsValid;

	private static int AdditionalFrameNumberOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams:AdditionalFrameNumberOffset")]
	public int AdditionalFrameNumberOffset;

	private static bool FMoviePipelineFilenameResolveParams_IsValid;

	private static int FMoviePipelineFilenameResolveParams_StructSize;

	public FMoviePipelineFilenameResolveParams Copy()
	{
		FMoviePipelineFilenameResolveParams result = this;
		if (FileNameFormatOverrides != null)
		{
			result.FileNameFormatOverrides = new Dictionary<string, string>(FileNameFormatOverrides);
		}
		if (FileMetadata != null)
		{
			result.FileMetadata = new Dictionary<string, string>(FileMetadata);
		}
		return result;
	}

	public static FMoviePipelineFilenameResolveParams FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineFilenameResolveParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineFilenameResolveParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineFilenameResolveParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineFilenameResolveParams(nativeBuffer + arrayIndex * FMoviePipelineFilenameResolveParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineFilenameResolveParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineFilenameResolveParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineFilenameResolveParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameNumber_Offset), FrameNumber);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameNumberShot_Offset), FrameNumberShot);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameNumberRel_Offset), FrameNumberRel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameNumberShotRel_Offset), FrameNumberShotRel);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CameraNameOverride_Offset), CameraNameOverride);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ShotNameOverride_Offset), ShotNameOverride);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ZeroPadFrameNumberCount_Offset), ZeroPadFrameNumberCount);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceRelativeFrameNumbers_Offset), 0, ForceRelativeFrameNumbers_PropertyAddress.Address, ForceRelativeFrameNumbers);
		new TMapCopyMarshaler<string, string>(1, FileNameFormatOverrides_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, FileNameFormatOverrides_Offset), FileNameFormatOverrides);
		new TMapCopyMarshaler<string, string>(1, FileMetadata_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, FileMetadata_Offset), FileMetadata);
		FDateTime.ToNative(IntPtr.Add(nativeStruct, InitializationTime_Offset), InitializationTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InitializationVersion_Offset), InitializationVersion);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(nativeStruct, Job_Offset), Job);
		UObjectMarshaler<UMoviePipelineExecutorShot>.ToNative(IntPtr.Add(nativeStruct, ShotOverride_Offset), ShotOverride);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AdditionalFrameNumberOffset_Offset), AdditionalFrameNumberOffset);
	}

	public FMoviePipelineFilenameResolveParams(IntPtr nativeStruct)
	{
		if (!FMoviePipelineFilenameResolveParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams");
			FrameNumber = 0;
			FrameNumberShot = 0;
			FrameNumberRel = 0;
			FrameNumberShotRel = 0;
			CameraNameOverride = FStringMarshaler.DefaultString;
			ShotNameOverride = FStringMarshaler.DefaultString;
			ZeroPadFrameNumberCount = 0;
			ForceRelativeFrameNumbers = false;
			FileNameFormatOverrides = null;
			FileMetadata = null;
			InitializationTime = default(FDateTime);
			InitializationVersion = 0;
			Job = null;
			ShotOverride = null;
			AdditionalFrameNumberOffset = 0;
		}
		else
		{
			FrameNumber = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameNumber_Offset));
			FrameNumberShot = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameNumberShot_Offset));
			FrameNumberRel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameNumberRel_Offset));
			FrameNumberShotRel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameNumberShotRel_Offset));
			CameraNameOverride = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CameraNameOverride_Offset));
			ShotNameOverride = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ShotNameOverride_Offset));
			ZeroPadFrameNumberCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ZeroPadFrameNumberCount_Offset));
			ForceRelativeFrameNumbers = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceRelativeFrameNumbers_Offset), 0, ForceRelativeFrameNumbers_PropertyAddress.Address);
			FileNameFormatOverrides = new TMapCopyMarshaler<string, string>(1, FileNameFormatOverrides_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, FileNameFormatOverrides_Offset));
			FileMetadata = new TMapCopyMarshaler<string, string>(1, FileMetadata_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, FileMetadata_Offset));
			InitializationTime = FDateTime.FromNative(IntPtr.Add(nativeStruct, InitializationTime_Offset));
			InitializationVersion = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InitializationVersion_Offset));
			Job = UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(nativeStruct, Job_Offset));
			ShotOverride = UObjectMarshaler<UMoviePipelineExecutorShot>.FromNative(IntPtr.Add(nativeStruct, ShotOverride_Offset));
			AdditionalFrameNumberOffset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AdditionalFrameNumberOffset_Offset));
		}
	}

	static FMoviePipelineFilenameResolveParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineFilenameResolveParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineFilenameResolveParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams");
		FMoviePipelineFilenameResolveParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumber");
		FrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumber", Classes.FIntProperty);
		FrameNumberShot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumberShot");
		FrameNumberShot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumberShot", Classes.FIntProperty);
		FrameNumberRel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumberRel");
		FrameNumberRel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumberRel", Classes.FIntProperty);
		FrameNumberShotRel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumberShotRel");
		FrameNumberShotRel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumberShotRel", Classes.FIntProperty);
		CameraNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraNameOverride");
		CameraNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraNameOverride", Classes.FStrProperty);
		ShotNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShotNameOverride");
		ShotNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShotNameOverride", Classes.FStrProperty);
		ZeroPadFrameNumberCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZeroPadFrameNumberCount");
		ZeroPadFrameNumberCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZeroPadFrameNumberCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceRelativeFrameNumbers_PropertyAddress, intPtr, "bForceRelativeFrameNumbers");
		ForceRelativeFrameNumbers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceRelativeFrameNumbers");
		ForceRelativeFrameNumbers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceRelativeFrameNumbers", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FileNameFormatOverrides_PropertyAddress, intPtr, "FileNameFormatOverrides");
		FileNameFormatOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FileNameFormatOverrides");
		FileNameFormatOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FileNameFormatOverrides", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref FileMetadata_PropertyAddress, intPtr, "FileMetadata");
		FileMetadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FileMetadata");
		FileMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FileMetadata", Classes.FMapProperty);
		InitializationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitializationTime");
		InitializationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitializationTime", Classes.FStructProperty);
		InitializationVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitializationVersion");
		InitializationVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitializationVersion", Classes.FIntProperty);
		Job_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Job");
		Job_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Job", Classes.FObjectProperty);
		ShotOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShotOverride");
		ShotOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShotOverride", Classes.FObjectProperty);
		AdditionalFrameNumberOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdditionalFrameNumberOffset");
		AdditionalFrameNumberOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdditionalFrameNumberOffset", Classes.FIntProperty);
		FMoviePipelineFilenameResolveParams_IsValid = intPtr != IntPtr.Zero && FrameNumber_IsValid && FrameNumberShot_IsValid && FrameNumberRel_IsValid && FrameNumberShotRel_IsValid && CameraNameOverride_IsValid && ShotNameOverride_IsValid && ZeroPadFrameNumberCount_IsValid && ForceRelativeFrameNumbers_IsValid && FileNameFormatOverrides_IsValid && FileMetadata_IsValid && InitializationTime_IsValid && InitializationVersion_IsValid && Job_IsValid && ShotOverride_IsValid && AdditionalFrameNumberOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineFilenameResolveParams", FMoviePipelineFilenameResolveParams_IsValid);
	}
}
