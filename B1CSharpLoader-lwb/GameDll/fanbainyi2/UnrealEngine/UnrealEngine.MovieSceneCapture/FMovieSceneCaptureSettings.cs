using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FMovieSceneCaptureSettings
{
	private static bool OutputDirectory_IsValid;

	private static int OutputDirectory_Offset;

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:OutputDirectory")]
	public FDirectoryPath OutputDirectory;

	private static bool GameModeOverride_IsValid;

	private static int GameModeOverride_Offset;

	[UProperty(Flags = (PropFlags)7885767187644933uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:GameModeOverride")]
	public TSubclassOf<AGameModeBase> GameModeOverride;

	private static bool OutputFormat_IsValid;

	private static int OutputFormat_Offset;

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:OutputFormat")]
	public string OutputFormat;

	private static bool OverwriteExisting_IsValid;

	private static FFieldAddress OverwriteExisting_PropertyAddress;

	private static int OverwriteExisting_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bOverwriteExisting")]
	public bool OverwriteExisting;

	private static bool UseRelativeFrameNumbers_IsValid;

	private static FFieldAddress UseRelativeFrameNumbers_PropertyAddress;

	private static int UseRelativeFrameNumbers_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bUseRelativeFrameNumbers")]
	public bool UseRelativeFrameNumbers;

	private static bool HandleFrames_IsValid;

	private static int HandleFrames_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:HandleFrames")]
	public int HandleFrames;

	private static bool MovieExtension_IsValid;

	private static int MovieExtension_Offset;

	[UProperty(Flags = (PropFlags)6759797487583749uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:MovieExtension")]
	public string MovieExtension;

	private static bool ZeroPadFrameNumbers_IsValid;

	private static int ZeroPadFrameNumbers_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:ZeroPadFrameNumbers")]
	public byte ZeroPadFrameNumbers;

	private static bool FrameRate_IsValid;

	private static int FrameRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:FrameRate")]
	public FFrameRate FrameRate;

	private static bool UseCustomFrameRate_IsValid;

	private static FFieldAddress UseCustomFrameRate_PropertyAddress;

	private static int UseCustomFrameRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bUseCustomFrameRate")]
	public bool UseCustomFrameRate;

	private static bool CustomFrameRate_IsValid;

	private static int CustomFrameRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:CustomFrameRate")]
	public FFrameRate CustomFrameRate;

	private static bool Resolution_IsValid;

	private static int Resolution_Offset;

	[UProperty(Flags = (PropFlags)4503668346863621uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:Resolution")]
	public FCaptureResolution Resolution;

	private static bool EnableTextureStreaming_IsValid;

	private static FFieldAddress EnableTextureStreaming_PropertyAddress;

	private static int EnableTextureStreaming_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bEnableTextureStreaming")]
	public bool EnableTextureStreaming;

	private static bool CinematicEngineScalability_IsValid;

	private static FFieldAddress CinematicEngineScalability_PropertyAddress;

	private static int CinematicEngineScalability_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bCinematicEngineScalability")]
	public bool CinematicEngineScalability;

	private static bool CinematicMode_IsValid;

	private static FFieldAddress CinematicMode_PropertyAddress;

	private static int CinematicMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bCinematicMode")]
	public bool CinematicMode;

	private static bool AllowMovement_IsValid;

	private static FFieldAddress AllowMovement_PropertyAddress;

	private static int AllowMovement_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bAllowMovement")]
	public bool AllowMovement;

	private static bool AllowTurning_IsValid;

	private static FFieldAddress AllowTurning_PropertyAddress;

	private static int AllowTurning_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bAllowTurning")]
	public bool AllowTurning;

	private static bool ShowPlayer_IsValid;

	private static FFieldAddress ShowPlayer_PropertyAddress;

	private static int ShowPlayer_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bShowPlayer")]
	public bool ShowPlayer;

	private static bool ShowHUD_IsValid;

	private static FFieldAddress ShowHUD_PropertyAddress;

	private static int ShowHUD_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bShowHUD")]
	public bool ShowHUD;

	private static bool UsePathTracer_IsValid;

	private static FFieldAddress UsePathTracer_PropertyAddress;

	private static int UsePathTracer_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:bUsePathTracer")]
	public bool UsePathTracer;

	private static bool PathTracerSamplePerPixel_IsValid;

	private static int PathTracerSamplePerPixel_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings:PathTracerSamplePerPixel")]
	public int PathTracerSamplePerPixel;

	private static bool FMovieSceneCaptureSettings_IsValid;

	private static int FMovieSceneCaptureSettings_StructSize;

	public FMovieSceneCaptureSettings Copy()
	{
		return this;
	}

	public static FMovieSceneCaptureSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneCaptureSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneCaptureSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneCaptureSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneCaptureSettings(nativeBuffer + arrayIndex * FMovieSceneCaptureSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneCaptureSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneCaptureSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneCaptureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.MovieSceneCaptureSettings");
			return;
		}
		FDirectoryPath.ToNative(IntPtr.Add(nativeStruct, OutputDirectory_Offset), OutputDirectory);
		TSubclassOfMarshaler<AGameModeBase>.ToNative(IntPtr.Add(nativeStruct, GameModeOverride_Offset), GameModeOverride);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OutputFormat_Offset), OutputFormat);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverwriteExisting_Offset), 0, OverwriteExisting_PropertyAddress.Address, OverwriteExisting);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseRelativeFrameNumbers_Offset), 0, UseRelativeFrameNumbers_PropertyAddress.Address, UseRelativeFrameNumbers);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HandleFrames_Offset), HandleFrames);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MovieExtension_Offset), MovieExtension);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, ZeroPadFrameNumbers_Offset), ZeroPadFrameNumbers);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(nativeStruct, FrameRate_Offset), FrameRate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCustomFrameRate_Offset), 0, UseCustomFrameRate_PropertyAddress.Address, UseCustomFrameRate);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(nativeStruct, CustomFrameRate_Offset), CustomFrameRate);
		FCaptureResolution.ToNative(IntPtr.Add(nativeStruct, Resolution_Offset), Resolution);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableTextureStreaming_Offset), 0, EnableTextureStreaming_PropertyAddress.Address, EnableTextureStreaming);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CinematicEngineScalability_Offset), 0, CinematicEngineScalability_PropertyAddress.Address, CinematicEngineScalability);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CinematicMode_Offset), 0, CinematicMode_PropertyAddress.Address, CinematicMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowMovement_Offset), 0, AllowMovement_PropertyAddress.Address, AllowMovement);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowTurning_Offset), 0, AllowTurning_PropertyAddress.Address, AllowTurning);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShowPlayer_Offset), 0, ShowPlayer_PropertyAddress.Address, ShowPlayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShowHUD_Offset), 0, ShowHUD_PropertyAddress.Address, ShowHUD);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UsePathTracer_Offset), 0, UsePathTracer_PropertyAddress.Address, UsePathTracer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PathTracerSamplePerPixel_Offset), PathTracerSamplePerPixel);
	}

	public FMovieSceneCaptureSettings(IntPtr nativeStruct)
	{
		if (!FMovieSceneCaptureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.MovieSceneCaptureSettings");
			OutputDirectory = default(FDirectoryPath);
			GameModeOverride = default(TSubclassOf<AGameModeBase>);
			OutputFormat = FStringMarshaler.DefaultString;
			OverwriteExisting = false;
			UseRelativeFrameNumbers = false;
			HandleFrames = 0;
			MovieExtension = FStringMarshaler.DefaultString;
			ZeroPadFrameNumbers = 0;
			FrameRate = default(FFrameRate);
			UseCustomFrameRate = false;
			CustomFrameRate = default(FFrameRate);
			Resolution = default(FCaptureResolution);
			EnableTextureStreaming = false;
			CinematicEngineScalability = false;
			CinematicMode = false;
			AllowMovement = false;
			AllowTurning = false;
			ShowPlayer = false;
			ShowHUD = false;
			UsePathTracer = false;
			PathTracerSamplePerPixel = 0;
		}
		else
		{
			OutputDirectory = FDirectoryPath.FromNative(IntPtr.Add(nativeStruct, OutputDirectory_Offset));
			GameModeOverride = TSubclassOfMarshaler<AGameModeBase>.FromNative(IntPtr.Add(nativeStruct, GameModeOverride_Offset));
			OutputFormat = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OutputFormat_Offset));
			OverwriteExisting = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverwriteExisting_Offset), 0, OverwriteExisting_PropertyAddress.Address);
			UseRelativeFrameNumbers = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseRelativeFrameNumbers_Offset), 0, UseRelativeFrameNumbers_PropertyAddress.Address);
			HandleFrames = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HandleFrames_Offset));
			MovieExtension = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MovieExtension_Offset));
			ZeroPadFrameNumbers = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, ZeroPadFrameNumbers_Offset));
			FrameRate = BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(nativeStruct, FrameRate_Offset));
			UseCustomFrameRate = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCustomFrameRate_Offset), 0, UseCustomFrameRate_PropertyAddress.Address);
			CustomFrameRate = BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(nativeStruct, CustomFrameRate_Offset));
			Resolution = FCaptureResolution.FromNative(IntPtr.Add(nativeStruct, Resolution_Offset));
			EnableTextureStreaming = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableTextureStreaming_Offset), 0, EnableTextureStreaming_PropertyAddress.Address);
			CinematicEngineScalability = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CinematicEngineScalability_Offset), 0, CinematicEngineScalability_PropertyAddress.Address);
			CinematicMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CinematicMode_Offset), 0, CinematicMode_PropertyAddress.Address);
			AllowMovement = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowMovement_Offset), 0, AllowMovement_PropertyAddress.Address);
			AllowTurning = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowTurning_Offset), 0, AllowTurning_PropertyAddress.Address);
			ShowPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShowPlayer_Offset), 0, ShowPlayer_PropertyAddress.Address);
			ShowHUD = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShowHUD_Offset), 0, ShowHUD_PropertyAddress.Address);
			UsePathTracer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UsePathTracer_Offset), 0, UsePathTracer_PropertyAddress.Address);
			PathTracerSamplePerPixel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PathTracerSamplePerPixel_Offset));
		}
	}

	static FMovieSceneCaptureSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneCaptureSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneCaptureSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.MovieSceneCaptureSettings");
		FMovieSceneCaptureSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		OutputDirectory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputDirectory");
		OutputDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputDirectory", Classes.FStructProperty);
		GameModeOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameModeOverride");
		GameModeOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameModeOverride", Classes.FClassProperty);
		OutputFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputFormat");
		OutputFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputFormat", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverwriteExisting_PropertyAddress, intPtr, "bOverwriteExisting");
		OverwriteExisting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverwriteExisting");
		OverwriteExisting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverwriteExisting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRelativeFrameNumbers_PropertyAddress, intPtr, "bUseRelativeFrameNumbers");
		UseRelativeFrameNumbers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseRelativeFrameNumbers");
		UseRelativeFrameNumbers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseRelativeFrameNumbers", Classes.FBoolProperty);
		HandleFrames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HandleFrames");
		HandleFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HandleFrames", Classes.FIntProperty);
		MovieExtension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MovieExtension");
		MovieExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MovieExtension", Classes.FStrProperty);
		ZeroPadFrameNumbers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZeroPadFrameNumbers");
		ZeroPadFrameNumbers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZeroPadFrameNumbers", Classes.FByteProperty);
		FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameRate");
		FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomFrameRate_PropertyAddress, intPtr, "bUseCustomFrameRate");
		UseCustomFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCustomFrameRate");
		UseCustomFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCustomFrameRate", Classes.FBoolProperty);
		CustomFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomFrameRate");
		CustomFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomFrameRate", Classes.FStructProperty);
		Resolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Resolution");
		Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Resolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableTextureStreaming_PropertyAddress, intPtr, "bEnableTextureStreaming");
		EnableTextureStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableTextureStreaming");
		EnableTextureStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableTextureStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CinematicEngineScalability_PropertyAddress, intPtr, "bCinematicEngineScalability");
		CinematicEngineScalability_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCinematicEngineScalability");
		CinematicEngineScalability_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCinematicEngineScalability", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CinematicMode_PropertyAddress, intPtr, "bCinematicMode");
		CinematicMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCinematicMode");
		CinematicMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCinematicMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowMovement_PropertyAddress, intPtr, "bAllowMovement");
		AllowMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowMovement");
		AllowMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTurning_PropertyAddress, intPtr, "bAllowTurning");
		AllowTurning_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowTurning");
		AllowTurning_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowTurning", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowPlayer_PropertyAddress, intPtr, "bShowPlayer");
		ShowPlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowPlayer");
		ShowPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowPlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowHUD_PropertyAddress, intPtr, "bShowHUD");
		ShowHUD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowHUD");
		ShowHUD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowHUD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePathTracer_PropertyAddress, intPtr, "bUsePathTracer");
		UsePathTracer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUsePathTracer");
		UsePathTracer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUsePathTracer", Classes.FBoolProperty);
		PathTracerSamplePerPixel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathTracerSamplePerPixel");
		PathTracerSamplePerPixel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathTracerSamplePerPixel", Classes.FIntProperty);
		FMovieSceneCaptureSettings_IsValid = intPtr != IntPtr.Zero && OutputDirectory_IsValid && GameModeOverride_IsValid && OutputFormat_IsValid && OverwriteExisting_IsValid && UseRelativeFrameNumbers_IsValid && HandleFrames_IsValid && MovieExtension_IsValid && ZeroPadFrameNumbers_IsValid && FrameRate_IsValid && UseCustomFrameRate_IsValid && CustomFrameRate_IsValid && Resolution_IsValid && EnableTextureStreaming_IsValid && CinematicEngineScalability_IsValid && CinematicMode_IsValid && AllowMovement_IsValid && AllowTurning_IsValid && ShowPlayer_IsValid && ShowHUD_IsValid && UsePathTracer_IsValid && PathTracerSamplePerPixel_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.MovieSceneCaptureSettings", FMovieSceneCaptureSettings_IsValid);
	}
}
