using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.BlueprintPathsLibrary", "Engine", UnrealModuleType.Engine)]
public class UPaths : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool VideoCaptureDir_IsValid;

	private static IntPtr VideoCaptureDir_FunctionAddress;

	private static int VideoCaptureDir_ParamsSize;

	private static bool VideoCaptureDir_ReturnValue_IsValid;

	private static FFieldAddress VideoCaptureDir_ReturnValue_PropertyAddress;

	private static int VideoCaptureDir_ReturnValue_Offset;

	private static bool ValidatePath_IsValid;

	private static IntPtr ValidatePath_FunctionAddress;

	private static int ValidatePath_ParamsSize;

	private static bool ValidatePath_InPath_IsValid;

	private static FFieldAddress ValidatePath_InPath_PropertyAddress;

	private static int ValidatePath_InPath_Offset;

	private static bool ValidatePath_bDidSucceed_IsValid;

	private static FFieldAddress ValidatePath_bDidSucceed_PropertyAddress;

	private static int ValidatePath_bDidSucceed_Offset;

	private static bool ValidatePath_OutReason_IsValid;

	private static FFieldAddress ValidatePath_OutReason_PropertyAddress;

	private static int ValidatePath_OutReason_Offset;

	private static bool Split_IsValid;

	private static IntPtr Split_FunctionAddress;

	private static int Split_ParamsSize;

	private static bool Split_InPath_IsValid;

	private static FFieldAddress Split_InPath_PropertyAddress;

	private static int Split_InPath_Offset;

	private static bool Split_PathPart_IsValid;

	private static FFieldAddress Split_PathPart_PropertyAddress;

	private static int Split_PathPart_Offset;

	private static bool Split_FilenamePart_IsValid;

	private static FFieldAddress Split_FilenamePart_PropertyAddress;

	private static int Split_FilenamePart_Offset;

	private static bool Split_ExtensionPart_IsValid;

	private static FFieldAddress Split_ExtensionPart_PropertyAddress;

	private static int Split_ExtensionPart_Offset;

	private static bool SourceConfigDir_IsValid;

	private static IntPtr SourceConfigDir_FunctionAddress;

	private static int SourceConfigDir_ParamsSize;

	private static bool SourceConfigDir_ReturnValue_IsValid;

	private static FFieldAddress SourceConfigDir_ReturnValue_PropertyAddress;

	private static int SourceConfigDir_ReturnValue_Offset;

	private static bool ShouldSaveToUserDir_IsValid;

	private static IntPtr ShouldSaveToUserDir_FunctionAddress;

	private static int ShouldSaveToUserDir_ParamsSize;

	private static bool ShouldSaveToUserDir_ReturnValue_IsValid;

	private static FFieldAddress ShouldSaveToUserDir_ReturnValue_PropertyAddress;

	private static int ShouldSaveToUserDir_ReturnValue_Offset;

	private static bool ShaderWorkingDir_IsValid;

	private static IntPtr ShaderWorkingDir_FunctionAddress;

	private static int ShaderWorkingDir_ParamsSize;

	private static bool ShaderWorkingDir_ReturnValue_IsValid;

	private static FFieldAddress ShaderWorkingDir_ReturnValue_PropertyAddress;

	private static int ShaderWorkingDir_ReturnValue_Offset;

	private static bool SetProjectFilePath_IsValid;

	private static IntPtr SetProjectFilePath_FunctionAddress;

	private static int SetProjectFilePath_ParamsSize;

	private static bool SetProjectFilePath_NewGameProjectFilePath_IsValid;

	private static FFieldAddress SetProjectFilePath_NewGameProjectFilePath_PropertyAddress;

	private static int SetProjectFilePath_NewGameProjectFilePath_Offset;

	private static bool SetExtension_IsValid;

	private static IntPtr SetExtension_FunctionAddress;

	private static int SetExtension_ParamsSize;

	private static bool SetExtension_InPath_IsValid;

	private static FFieldAddress SetExtension_InPath_PropertyAddress;

	private static int SetExtension_InPath_Offset;

	private static bool SetExtension_InNewExtension_IsValid;

	private static FFieldAddress SetExtension_InNewExtension_PropertyAddress;

	private static int SetExtension_InNewExtension_Offset;

	private static bool SetExtension_ReturnValue_IsValid;

	private static FFieldAddress SetExtension_ReturnValue_PropertyAddress;

	private static int SetExtension_ReturnValue_Offset;

	private static bool ScreenShotDir_IsValid;

	private static IntPtr ScreenShotDir_FunctionAddress;

	private static int ScreenShotDir_ParamsSize;

	private static bool ScreenShotDir_ReturnValue_IsValid;

	private static FFieldAddress ScreenShotDir_ReturnValue_PropertyAddress;

	private static int ScreenShotDir_ReturnValue_Offset;

	private static bool SandboxesDir_IsValid;

	private static IntPtr SandboxesDir_FunctionAddress;

	private static int SandboxesDir_ParamsSize;

	private static bool SandboxesDir_ReturnValue_IsValid;

	private static FFieldAddress SandboxesDir_ReturnValue_PropertyAddress;

	private static int SandboxesDir_ReturnValue_Offset;

	private static bool RootDir_IsValid;

	private static IntPtr RootDir_FunctionAddress;

	private static int RootDir_ParamsSize;

	private static bool RootDir_ReturnValue_IsValid;

	private static FFieldAddress RootDir_ReturnValue_PropertyAddress;

	private static int RootDir_ReturnValue_Offset;

	private static bool RemoveDuplicateSlashes_IsValid;

	private static IntPtr RemoveDuplicateSlashes_FunctionAddress;

	private static int RemoveDuplicateSlashes_ParamsSize;

	private static bool RemoveDuplicateSlashes_InPath_IsValid;

	private static FFieldAddress RemoveDuplicateSlashes_InPath_PropertyAddress;

	private static int RemoveDuplicateSlashes_InPath_Offset;

	private static bool RemoveDuplicateSlashes_OutPath_IsValid;

	private static FFieldAddress RemoveDuplicateSlashes_OutPath_PropertyAddress;

	private static int RemoveDuplicateSlashes_OutPath_Offset;

	private static bool ProjectUserDir_IsValid;

	private static IntPtr ProjectUserDir_FunctionAddress;

	private static int ProjectUserDir_ParamsSize;

	private static bool ProjectUserDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectUserDir_ReturnValue_PropertyAddress;

	private static int ProjectUserDir_ReturnValue_Offset;

	private static bool ProjectSavedDir_IsValid;

	private static IntPtr ProjectSavedDir_FunctionAddress;

	private static int ProjectSavedDir_ParamsSize;

	private static bool ProjectSavedDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectSavedDir_ReturnValue_PropertyAddress;

	private static int ProjectSavedDir_ReturnValue_Offset;

	private static bool ProjectPluginsDir_IsValid;

	private static IntPtr ProjectPluginsDir_FunctionAddress;

	private static int ProjectPluginsDir_ParamsSize;

	private static bool ProjectPluginsDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectPluginsDir_ReturnValue_PropertyAddress;

	private static int ProjectPluginsDir_ReturnValue_Offset;

	private static bool ProjectPersistentDownloadDir_IsValid;

	private static IntPtr ProjectPersistentDownloadDir_FunctionAddress;

	private static int ProjectPersistentDownloadDir_ParamsSize;

	private static bool ProjectPersistentDownloadDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectPersistentDownloadDir_ReturnValue_PropertyAddress;

	private static int ProjectPersistentDownloadDir_ReturnValue_Offset;

	private static bool ProjectModsDir_IsValid;

	private static IntPtr ProjectModsDir_FunctionAddress;

	private static int ProjectModsDir_ParamsSize;

	private static bool ProjectModsDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectModsDir_ReturnValue_PropertyAddress;

	private static int ProjectModsDir_ReturnValue_Offset;

	private static bool ProjectLogDir_IsValid;

	private static IntPtr ProjectLogDir_FunctionAddress;

	private static int ProjectLogDir_ParamsSize;

	private static bool ProjectLogDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectLogDir_ReturnValue_PropertyAddress;

	private static int ProjectLogDir_ReturnValue_Offset;

	private static bool ProjectIntermediateDir_IsValid;

	private static IntPtr ProjectIntermediateDir_FunctionAddress;

	private static int ProjectIntermediateDir_ParamsSize;

	private static bool ProjectIntermediateDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectIntermediateDir_ReturnValue_PropertyAddress;

	private static int ProjectIntermediateDir_ReturnValue_Offset;

	private static bool ProjectDir_IsValid;

	private static IntPtr ProjectDir_FunctionAddress;

	private static int ProjectDir_ParamsSize;

	private static bool ProjectDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectDir_ReturnValue_PropertyAddress;

	private static int ProjectDir_ReturnValue_Offset;

	private static bool ProjectContentDir_IsValid;

	private static IntPtr ProjectContentDir_FunctionAddress;

	private static int ProjectContentDir_ParamsSize;

	private static bool ProjectContentDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectContentDir_ReturnValue_PropertyAddress;

	private static int ProjectContentDir_ReturnValue_Offset;

	private static bool ProjectConfigDir_IsValid;

	private static IntPtr ProjectConfigDir_FunctionAddress;

	private static int ProjectConfigDir_ParamsSize;

	private static bool ProjectConfigDir_ReturnValue_IsValid;

	private static FFieldAddress ProjectConfigDir_ReturnValue_PropertyAddress;

	private static int ProjectConfigDir_ReturnValue_Offset;

	private static bool ProfilingDir_IsValid;

	private static IntPtr ProfilingDir_FunctionAddress;

	private static int ProfilingDir_ParamsSize;

	private static bool ProfilingDir_ReturnValue_IsValid;

	private static FFieldAddress ProfilingDir_ReturnValue_PropertyAddress;

	private static int ProfilingDir_ReturnValue_Offset;

	private static bool NormalizeFilename_IsValid;

	private static IntPtr NormalizeFilename_FunctionAddress;

	private static int NormalizeFilename_ParamsSize;

	private static bool NormalizeFilename_InPath_IsValid;

	private static FFieldAddress NormalizeFilename_InPath_PropertyAddress;

	private static int NormalizeFilename_InPath_Offset;

	private static bool NormalizeFilename_OutPath_IsValid;

	private static FFieldAddress NormalizeFilename_OutPath_PropertyAddress;

	private static int NormalizeFilename_OutPath_Offset;

	private static bool NormalizeDirectoryName_IsValid;

	private static IntPtr NormalizeDirectoryName_FunctionAddress;

	private static int NormalizeDirectoryName_ParamsSize;

	private static bool NormalizeDirectoryName_InPath_IsValid;

	private static FFieldAddress NormalizeDirectoryName_InPath_PropertyAddress;

	private static int NormalizeDirectoryName_InPath_Offset;

	private static bool NormalizeDirectoryName_OutPath_IsValid;

	private static FFieldAddress NormalizeDirectoryName_OutPath_PropertyAddress;

	private static int NormalizeDirectoryName_OutPath_Offset;

	private static bool MakeValidFileName_IsValid;

	private static IntPtr MakeValidFileName_FunctionAddress;

	private static int MakeValidFileName_ParamsSize;

	private static bool MakeValidFileName_InString_IsValid;

	private static FFieldAddress MakeValidFileName_InString_PropertyAddress;

	private static int MakeValidFileName_InString_Offset;

	private static bool MakeValidFileName_InReplacementChar_IsValid;

	private static FFieldAddress MakeValidFileName_InReplacementChar_PropertyAddress;

	private static int MakeValidFileName_InReplacementChar_Offset;

	private static bool MakeValidFileName_ReturnValue_IsValid;

	private static FFieldAddress MakeValidFileName_ReturnValue_PropertyAddress;

	private static int MakeValidFileName_ReturnValue_Offset;

	private static bool MakeStandardFilename_IsValid;

	private static IntPtr MakeStandardFilename_FunctionAddress;

	private static int MakeStandardFilename_ParamsSize;

	private static bool MakeStandardFilename_InPath_IsValid;

	private static FFieldAddress MakeStandardFilename_InPath_PropertyAddress;

	private static int MakeStandardFilename_InPath_Offset;

	private static bool MakeStandardFilename_OutPath_IsValid;

	private static FFieldAddress MakeStandardFilename_OutPath_PropertyAddress;

	private static int MakeStandardFilename_OutPath_Offset;

	private static bool MakePlatformFilename_IsValid;

	private static IntPtr MakePlatformFilename_FunctionAddress;

	private static int MakePlatformFilename_ParamsSize;

	private static bool MakePlatformFilename_InPath_IsValid;

	private static FFieldAddress MakePlatformFilename_InPath_PropertyAddress;

	private static int MakePlatformFilename_InPath_Offset;

	private static bool MakePlatformFilename_OutPath_IsValid;

	private static FFieldAddress MakePlatformFilename_OutPath_PropertyAddress;

	private static int MakePlatformFilename_OutPath_Offset;

	private static bool MakePathRelativeTo_IsValid;

	private static IntPtr MakePathRelativeTo_FunctionAddress;

	private static int MakePathRelativeTo_ParamsSize;

	private static bool MakePathRelativeTo_InPath_IsValid;

	private static FFieldAddress MakePathRelativeTo_InPath_PropertyAddress;

	private static int MakePathRelativeTo_InPath_Offset;

	private static bool MakePathRelativeTo_InRelativeTo_IsValid;

	private static FFieldAddress MakePathRelativeTo_InRelativeTo_PropertyAddress;

	private static int MakePathRelativeTo_InRelativeTo_Offset;

	private static bool MakePathRelativeTo_OutPath_IsValid;

	private static FFieldAddress MakePathRelativeTo_OutPath_PropertyAddress;

	private static int MakePathRelativeTo_OutPath_Offset;

	private static bool MakePathRelativeTo_ReturnValue_IsValid;

	private static FFieldAddress MakePathRelativeTo_ReturnValue_PropertyAddress;

	private static int MakePathRelativeTo_ReturnValue_Offset;

	private static bool LaunchDir_IsValid;

	private static IntPtr LaunchDir_FunctionAddress;

	private static int LaunchDir_ParamsSize;

	private static bool LaunchDir_ReturnValue_IsValid;

	private static FFieldAddress LaunchDir_ReturnValue_PropertyAddress;

	private static int LaunchDir_ReturnValue_Offset;

	private static bool IsSamePath_IsValid;

	private static IntPtr IsSamePath_FunctionAddress;

	private static int IsSamePath_ParamsSize;

	private static bool IsSamePath_PathA_IsValid;

	private static FFieldAddress IsSamePath_PathA_PropertyAddress;

	private static int IsSamePath_PathA_Offset;

	private static bool IsSamePath_PathB_IsValid;

	private static FFieldAddress IsSamePath_PathB_PropertyAddress;

	private static int IsSamePath_PathB_Offset;

	private static bool IsSamePath_ReturnValue_IsValid;

	private static FFieldAddress IsSamePath_ReturnValue_PropertyAddress;

	private static int IsSamePath_ReturnValue_Offset;

	private static bool IsRestrictedPath_IsValid;

	private static IntPtr IsRestrictedPath_FunctionAddress;

	private static int IsRestrictedPath_ParamsSize;

	private static bool IsRestrictedPath_InPath_IsValid;

	private static FFieldAddress IsRestrictedPath_InPath_PropertyAddress;

	private static int IsRestrictedPath_InPath_Offset;

	private static bool IsRestrictedPath_ReturnValue_IsValid;

	private static FFieldAddress IsRestrictedPath_ReturnValue_PropertyAddress;

	private static int IsRestrictedPath_ReturnValue_Offset;

	private static bool IsRelative_IsValid;

	private static IntPtr IsRelative_FunctionAddress;

	private static int IsRelative_ParamsSize;

	private static bool IsRelative_InPath_IsValid;

	private static FFieldAddress IsRelative_InPath_PropertyAddress;

	private static int IsRelative_InPath_Offset;

	private static bool IsRelative_ReturnValue_IsValid;

	private static FFieldAddress IsRelative_ReturnValue_PropertyAddress;

	private static int IsRelative_ReturnValue_Offset;

	private static bool IsProjectFilePathSet_IsValid;

	private static IntPtr IsProjectFilePathSet_FunctionAddress;

	private static int IsProjectFilePathSet_ParamsSize;

	private static bool IsProjectFilePathSet_ReturnValue_IsValid;

	private static FFieldAddress IsProjectFilePathSet_ReturnValue_PropertyAddress;

	private static int IsProjectFilePathSet_ReturnValue_Offset;

	private static bool IsDrive_IsValid;

	private static IntPtr IsDrive_FunctionAddress;

	private static int IsDrive_ParamsSize;

	private static bool IsDrive_InPath_IsValid;

	private static FFieldAddress IsDrive_InPath_PropertyAddress;

	private static int IsDrive_InPath_Offset;

	private static bool IsDrive_ReturnValue_IsValid;

	private static FFieldAddress IsDrive_ReturnValue_PropertyAddress;

	private static int IsDrive_ReturnValue_Offset;

	private static bool HasProjectPersistentDownloadDir_IsValid;

	private static IntPtr HasProjectPersistentDownloadDir_FunctionAddress;

	private static int HasProjectPersistentDownloadDir_ParamsSize;

	private static bool HasProjectPersistentDownloadDir_ReturnValue_IsValid;

	private static FFieldAddress HasProjectPersistentDownloadDir_ReturnValue_PropertyAddress;

	private static int HasProjectPersistentDownloadDir_ReturnValue_Offset;

	private static bool GetToolTipLocalizationPaths_IsValid;

	private static IntPtr GetToolTipLocalizationPaths_FunctionAddress;

	private static int GetToolTipLocalizationPaths_ParamsSize;

	private static bool GetToolTipLocalizationPaths_ReturnValue_IsValid;

	private static FFieldAddress GetToolTipLocalizationPaths_ReturnValue_PropertyAddress;

	private static int GetToolTipLocalizationPaths_ReturnValue_Offset;

	private static bool GetRestrictedFolderNames_IsValid;

	private static IntPtr GetRestrictedFolderNames_FunctionAddress;

	private static int GetRestrictedFolderNames_ParamsSize;

	private static bool GetRestrictedFolderNames_ReturnValue_IsValid;

	private static FFieldAddress GetRestrictedFolderNames_ReturnValue_PropertyAddress;

	private static int GetRestrictedFolderNames_ReturnValue_Offset;

	private static bool GetRelativePathToRoot_IsValid;

	private static IntPtr GetRelativePathToRoot_FunctionAddress;

	private static int GetRelativePathToRoot_ParamsSize;

	private static bool GetRelativePathToRoot_ReturnValue_IsValid;

	private static FFieldAddress GetRelativePathToRoot_ReturnValue_PropertyAddress;

	private static int GetRelativePathToRoot_ReturnValue_Offset;

	private static bool GetPropertyNameLocalizationPaths_IsValid;

	private static IntPtr GetPropertyNameLocalizationPaths_FunctionAddress;

	private static int GetPropertyNameLocalizationPaths_ParamsSize;

	private static bool GetPropertyNameLocalizationPaths_ReturnValue_IsValid;

	private static FFieldAddress GetPropertyNameLocalizationPaths_ReturnValue_PropertyAddress;

	private static int GetPropertyNameLocalizationPaths_ReturnValue_Offset;

	private static bool GetProjectFilePath_IsValid;

	private static IntPtr GetProjectFilePath_FunctionAddress;

	private static int GetProjectFilePath_ParamsSize;

	private static bool GetProjectFilePath_ReturnValue_IsValid;

	private static FFieldAddress GetProjectFilePath_ReturnValue_PropertyAddress;

	private static int GetProjectFilePath_ReturnValue_Offset;

	private static bool GetPath_IsValid;

	private static IntPtr GetPath_FunctionAddress;

	private static int GetPath_ParamsSize;

	private static bool GetPath_InPath_IsValid;

	private static FFieldAddress GetPath_InPath_PropertyAddress;

	private static int GetPath_InPath_Offset;

	private static bool GetPath_ReturnValue_IsValid;

	private static FFieldAddress GetPath_ReturnValue_PropertyAddress;

	private static int GetPath_ReturnValue_Offset;

	private static bool GetInvalidFileSystemChars_IsValid;

	private static IntPtr GetInvalidFileSystemChars_FunctionAddress;

	private static int GetInvalidFileSystemChars_ParamsSize;

	private static bool GetInvalidFileSystemChars_ReturnValue_IsValid;

	private static FFieldAddress GetInvalidFileSystemChars_ReturnValue_PropertyAddress;

	private static int GetInvalidFileSystemChars_ReturnValue_Offset;

	private static bool GetGameLocalizationPaths_IsValid;

	private static IntPtr GetGameLocalizationPaths_FunctionAddress;

	private static int GetGameLocalizationPaths_ParamsSize;

	private static bool GetGameLocalizationPaths_ReturnValue_IsValid;

	private static FFieldAddress GetGameLocalizationPaths_ReturnValue_PropertyAddress;

	private static int GetGameLocalizationPaths_ReturnValue_Offset;

	private static bool GetExtension_IsValid;

	private static IntPtr GetExtension_FunctionAddress;

	private static int GetExtension_ParamsSize;

	private static bool GetExtension_InPath_IsValid;

	private static FFieldAddress GetExtension_InPath_PropertyAddress;

	private static int GetExtension_InPath_Offset;

	private static bool GetExtension_bIncludeDot_IsValid;

	private static FFieldAddress GetExtension_bIncludeDot_PropertyAddress;

	private static int GetExtension_bIncludeDot_Offset;

	private static bool GetExtension_ReturnValue_IsValid;

	private static FFieldAddress GetExtension_ReturnValue_PropertyAddress;

	private static int GetExtension_ReturnValue_Offset;

	private static bool GetEngineLocalizationPaths_IsValid;

	private static IntPtr GetEngineLocalizationPaths_FunctionAddress;

	private static int GetEngineLocalizationPaths_ParamsSize;

	private static bool GetEngineLocalizationPaths_ReturnValue_IsValid;

	private static FFieldAddress GetEngineLocalizationPaths_ReturnValue_PropertyAddress;

	private static int GetEngineLocalizationPaths_ReturnValue_Offset;

	private static bool GetEditorLocalizationPaths_IsValid;

	private static IntPtr GetEditorLocalizationPaths_FunctionAddress;

	private static int GetEditorLocalizationPaths_ParamsSize;

	private static bool GetEditorLocalizationPaths_ReturnValue_IsValid;

	private static FFieldAddress GetEditorLocalizationPaths_ReturnValue_PropertyAddress;

	private static int GetEditorLocalizationPaths_ReturnValue_Offset;

	private static bool GetCleanFilename_IsValid;

	private static IntPtr GetCleanFilename_FunctionAddress;

	private static int GetCleanFilename_ParamsSize;

	private static bool GetCleanFilename_InPath_IsValid;

	private static FFieldAddress GetCleanFilename_InPath_PropertyAddress;

	private static int GetCleanFilename_InPath_Offset;

	private static bool GetCleanFilename_ReturnValue_IsValid;

	private static FFieldAddress GetCleanFilename_ReturnValue_PropertyAddress;

	private static int GetCleanFilename_ReturnValue_Offset;

	private static bool GetBaseFilename_IsValid;

	private static IntPtr GetBaseFilename_FunctionAddress;

	private static int GetBaseFilename_ParamsSize;

	private static bool GetBaseFilename_InPath_IsValid;

	private static FFieldAddress GetBaseFilename_InPath_PropertyAddress;

	private static int GetBaseFilename_InPath_Offset;

	private static bool GetBaseFilename_bRemovePath_IsValid;

	private static FFieldAddress GetBaseFilename_bRemovePath_PropertyAddress;

	private static int GetBaseFilename_bRemovePath_Offset;

	private static bool GetBaseFilename_ReturnValue_IsValid;

	private static FFieldAddress GetBaseFilename_ReturnValue_PropertyAddress;

	private static int GetBaseFilename_ReturnValue_Offset;

	private static bool GeneratedConfigDir_IsValid;

	private static IntPtr GeneratedConfigDir_FunctionAddress;

	private static int GeneratedConfigDir_ParamsSize;

	private static bool GeneratedConfigDir_ReturnValue_IsValid;

	private static FFieldAddress GeneratedConfigDir_ReturnValue_PropertyAddress;

	private static int GeneratedConfigDir_ReturnValue_Offset;

	private static bool GameUserDeveloperDir_IsValid;

	private static IntPtr GameUserDeveloperDir_FunctionAddress;

	private static int GameUserDeveloperDir_ParamsSize;

	private static bool GameUserDeveloperDir_ReturnValue_IsValid;

	private static FFieldAddress GameUserDeveloperDir_ReturnValue_PropertyAddress;

	private static int GameUserDeveloperDir_ReturnValue_Offset;

	private static bool GameSourceDir_IsValid;

	private static IntPtr GameSourceDir_FunctionAddress;

	private static int GameSourceDir_ParamsSize;

	private static bool GameSourceDir_ReturnValue_IsValid;

	private static FFieldAddress GameSourceDir_ReturnValue_PropertyAddress;

	private static int GameSourceDir_ReturnValue_Offset;

	private static bool GameDevelopersDir_IsValid;

	private static IntPtr GameDevelopersDir_FunctionAddress;

	private static int GameDevelopersDir_ParamsSize;

	private static bool GameDevelopersDir_ReturnValue_IsValid;

	private static FFieldAddress GameDevelopersDir_ReturnValue_PropertyAddress;

	private static int GameDevelopersDir_ReturnValue_Offset;

	private static bool GameAgnosticSavedDir_IsValid;

	private static IntPtr GameAgnosticSavedDir_FunctionAddress;

	private static int GameAgnosticSavedDir_ParamsSize;

	private static bool GameAgnosticSavedDir_ReturnValue_IsValid;

	private static FFieldAddress GameAgnosticSavedDir_ReturnValue_PropertyAddress;

	private static int GameAgnosticSavedDir_ReturnValue_Offset;

	private static bool FileExists_IsValid;

	private static IntPtr FileExists_FunctionAddress;

	private static int FileExists_ParamsSize;

	private static bool FileExists_InPath_IsValid;

	private static FFieldAddress FileExists_InPath_PropertyAddress;

	private static int FileExists_InPath_Offset;

	private static bool FileExists_ReturnValue_IsValid;

	private static FFieldAddress FileExists_ReturnValue_PropertyAddress;

	private static int FileExists_ReturnValue_Offset;

	private static bool FeaturePackDir_IsValid;

	private static IntPtr FeaturePackDir_FunctionAddress;

	private static int FeaturePackDir_ParamsSize;

	private static bool FeaturePackDir_ReturnValue_IsValid;

	private static FFieldAddress FeaturePackDir_ReturnValue_PropertyAddress;

	private static int FeaturePackDir_ReturnValue_Offset;

	private static bool EnterprisePluginsDir_IsValid;

	private static IntPtr EnterprisePluginsDir_FunctionAddress;

	private static int EnterprisePluginsDir_ParamsSize;

	private static bool EnterprisePluginsDir_ReturnValue_IsValid;

	private static FFieldAddress EnterprisePluginsDir_ReturnValue_PropertyAddress;

	private static int EnterprisePluginsDir_ReturnValue_Offset;

	private static bool EnterpriseFeaturePackDir_IsValid;

	private static IntPtr EnterpriseFeaturePackDir_FunctionAddress;

	private static int EnterpriseFeaturePackDir_ParamsSize;

	private static bool EnterpriseFeaturePackDir_ReturnValue_IsValid;

	private static FFieldAddress EnterpriseFeaturePackDir_ReturnValue_PropertyAddress;

	private static int EnterpriseFeaturePackDir_ReturnValue_Offset;

	private static bool EnterpriseDir_IsValid;

	private static IntPtr EnterpriseDir_FunctionAddress;

	private static int EnterpriseDir_ParamsSize;

	private static bool EnterpriseDir_ReturnValue_IsValid;

	private static FFieldAddress EnterpriseDir_ReturnValue_PropertyAddress;

	private static int EnterpriseDir_ReturnValue_Offset;

	private static bool EngineVersionAgnosticUserDir_IsValid;

	private static IntPtr EngineVersionAgnosticUserDir_FunctionAddress;

	private static int EngineVersionAgnosticUserDir_ParamsSize;

	private static bool EngineVersionAgnosticUserDir_ReturnValue_IsValid;

	private static FFieldAddress EngineVersionAgnosticUserDir_ReturnValue_PropertyAddress;

	private static int EngineVersionAgnosticUserDir_ReturnValue_Offset;

	private static bool EngineUserDir_IsValid;

	private static IntPtr EngineUserDir_FunctionAddress;

	private static int EngineUserDir_ParamsSize;

	private static bool EngineUserDir_ReturnValue_IsValid;

	private static FFieldAddress EngineUserDir_ReturnValue_PropertyAddress;

	private static int EngineUserDir_ReturnValue_Offset;

	private static bool EngineSourceDir_IsValid;

	private static IntPtr EngineSourceDir_FunctionAddress;

	private static int EngineSourceDir_ParamsSize;

	private static bool EngineSourceDir_ReturnValue_IsValid;

	private static FFieldAddress EngineSourceDir_ReturnValue_PropertyAddress;

	private static int EngineSourceDir_ReturnValue_Offset;

	private static bool EngineSavedDir_IsValid;

	private static IntPtr EngineSavedDir_FunctionAddress;

	private static int EngineSavedDir_ParamsSize;

	private static bool EngineSavedDir_ReturnValue_IsValid;

	private static FFieldAddress EngineSavedDir_ReturnValue_PropertyAddress;

	private static int EngineSavedDir_ReturnValue_Offset;

	private static bool EnginePluginsDir_IsValid;

	private static IntPtr EnginePluginsDir_FunctionAddress;

	private static int EnginePluginsDir_ParamsSize;

	private static bool EnginePluginsDir_ReturnValue_IsValid;

	private static FFieldAddress EnginePluginsDir_ReturnValue_PropertyAddress;

	private static int EnginePluginsDir_ReturnValue_Offset;

	private static bool EngineIntermediateDir_IsValid;

	private static IntPtr EngineIntermediateDir_FunctionAddress;

	private static int EngineIntermediateDir_ParamsSize;

	private static bool EngineIntermediateDir_ReturnValue_IsValid;

	private static FFieldAddress EngineIntermediateDir_ReturnValue_PropertyAddress;

	private static int EngineIntermediateDir_ReturnValue_Offset;

	private static bool EngineDir_IsValid;

	private static IntPtr EngineDir_FunctionAddress;

	private static int EngineDir_ParamsSize;

	private static bool EngineDir_ReturnValue_IsValid;

	private static FFieldAddress EngineDir_ReturnValue_PropertyAddress;

	private static int EngineDir_ReturnValue_Offset;

	private static bool EngineContentDir_IsValid;

	private static IntPtr EngineContentDir_FunctionAddress;

	private static int EngineContentDir_ParamsSize;

	private static bool EngineContentDir_ReturnValue_IsValid;

	private static FFieldAddress EngineContentDir_ReturnValue_PropertyAddress;

	private static int EngineContentDir_ReturnValue_Offset;

	private static bool EngineConfigDir_IsValid;

	private static IntPtr EngineConfigDir_FunctionAddress;

	private static int EngineConfigDir_ParamsSize;

	private static bool EngineConfigDir_ReturnValue_IsValid;

	private static FFieldAddress EngineConfigDir_ReturnValue_PropertyAddress;

	private static int EngineConfigDir_ReturnValue_Offset;

	private static bool DirectoryExists_IsValid;

	private static IntPtr DirectoryExists_FunctionAddress;

	private static int DirectoryExists_ParamsSize;

	private static bool DirectoryExists_InPath_IsValid;

	private static FFieldAddress DirectoryExists_InPath_PropertyAddress;

	private static int DirectoryExists_InPath_Offset;

	private static bool DirectoryExists_ReturnValue_IsValid;

	private static FFieldAddress DirectoryExists_ReturnValue_PropertyAddress;

	private static int DirectoryExists_ReturnValue_Offset;

	private static bool DiffDir_IsValid;

	private static IntPtr DiffDir_FunctionAddress;

	private static int DiffDir_ParamsSize;

	private static bool DiffDir_ReturnValue_IsValid;

	private static FFieldAddress DiffDir_ReturnValue_PropertyAddress;

	private static int DiffDir_ReturnValue_Offset;

	private static bool CreateTempFilename_IsValid;

	private static IntPtr CreateTempFilename_FunctionAddress;

	private static int CreateTempFilename_ParamsSize;

	private static bool CreateTempFilename_Path_IsValid;

	private static FFieldAddress CreateTempFilename_Path_PropertyAddress;

	private static int CreateTempFilename_Path_Offset;

	private static bool CreateTempFilename_Prefix_IsValid;

	private static FFieldAddress CreateTempFilename_Prefix_PropertyAddress;

	private static int CreateTempFilename_Prefix_Offset;

	private static bool CreateTempFilename_Extension_IsValid;

	private static FFieldAddress CreateTempFilename_Extension_PropertyAddress;

	private static int CreateTempFilename_Extension_Offset;

	private static bool CreateTempFilename_ReturnValue_IsValid;

	private static FFieldAddress CreateTempFilename_ReturnValue_PropertyAddress;

	private static int CreateTempFilename_ReturnValue_Offset;

	private static bool ConvertToSandboxPath_IsValid;

	private static IntPtr ConvertToSandboxPath_FunctionAddress;

	private static int ConvertToSandboxPath_ParamsSize;

	private static bool ConvertToSandboxPath_InPath_IsValid;

	private static FFieldAddress ConvertToSandboxPath_InPath_PropertyAddress;

	private static int ConvertToSandboxPath_InPath_Offset;

	private static bool ConvertToSandboxPath_InSandboxName_IsValid;

	private static FFieldAddress ConvertToSandboxPath_InSandboxName_PropertyAddress;

	private static int ConvertToSandboxPath_InSandboxName_Offset;

	private static bool ConvertToSandboxPath_ReturnValue_IsValid;

	private static FFieldAddress ConvertToSandboxPath_ReturnValue_PropertyAddress;

	private static int ConvertToSandboxPath_ReturnValue_Offset;

	private static bool ConvertRelativePathToFull_IsValid;

	private static IntPtr ConvertRelativePathToFull_FunctionAddress;

	private static int ConvertRelativePathToFull_ParamsSize;

	private static bool ConvertRelativePathToFull_InPath_IsValid;

	private static FFieldAddress ConvertRelativePathToFull_InPath_PropertyAddress;

	private static int ConvertRelativePathToFull_InPath_Offset;

	private static bool ConvertRelativePathToFull_InBasePath_IsValid;

	private static FFieldAddress ConvertRelativePathToFull_InBasePath_PropertyAddress;

	private static int ConvertRelativePathToFull_InBasePath_Offset;

	private static bool ConvertRelativePathToFull_ReturnValue_IsValid;

	private static FFieldAddress ConvertRelativePathToFull_ReturnValue_PropertyAddress;

	private static int ConvertRelativePathToFull_ReturnValue_Offset;

	private static bool ConvertFromSandboxPath_IsValid;

	private static IntPtr ConvertFromSandboxPath_FunctionAddress;

	private static int ConvertFromSandboxPath_ParamsSize;

	private static bool ConvertFromSandboxPath_InPath_IsValid;

	private static FFieldAddress ConvertFromSandboxPath_InPath_PropertyAddress;

	private static int ConvertFromSandboxPath_InPath_Offset;

	private static bool ConvertFromSandboxPath_InSandboxName_IsValid;

	private static FFieldAddress ConvertFromSandboxPath_InSandboxName_PropertyAddress;

	private static int ConvertFromSandboxPath_InSandboxName_Offset;

	private static bool ConvertFromSandboxPath_ReturnValue_IsValid;

	private static FFieldAddress ConvertFromSandboxPath_ReturnValue_PropertyAddress;

	private static int ConvertFromSandboxPath_ReturnValue_Offset;

	private static bool Combine_IsValid;

	private static IntPtr Combine_FunctionAddress;

	private static int Combine_ParamsSize;

	private static bool Combine_InPaths_IsValid;

	private static FFieldAddress Combine_InPaths_PropertyAddress;

	private static int Combine_InPaths_Offset;

	private static bool Combine_ReturnValue_IsValid;

	private static FFieldAddress Combine_ReturnValue_PropertyAddress;

	private static int Combine_ReturnValue_Offset;

	private static bool CollapseRelativeDirectories_IsValid;

	private static IntPtr CollapseRelativeDirectories_FunctionAddress;

	private static int CollapseRelativeDirectories_ParamsSize;

	private static bool CollapseRelativeDirectories_InPath_IsValid;

	private static FFieldAddress CollapseRelativeDirectories_InPath_PropertyAddress;

	private static int CollapseRelativeDirectories_InPath_Offset;

	private static bool CollapseRelativeDirectories_OutPath_IsValid;

	private static FFieldAddress CollapseRelativeDirectories_OutPath_PropertyAddress;

	private static int CollapseRelativeDirectories_OutPath_Offset;

	private static bool CollapseRelativeDirectories_ReturnValue_IsValid;

	private static FFieldAddress CollapseRelativeDirectories_ReturnValue_PropertyAddress;

	private static int CollapseRelativeDirectories_ReturnValue_Offset;

	private static bool CloudDir_IsValid;

	private static IntPtr CloudDir_FunctionAddress;

	private static int CloudDir_ParamsSize;

	private static bool CloudDir_ReturnValue_IsValid;

	private static FFieldAddress CloudDir_ReturnValue_PropertyAddress;

	private static int CloudDir_ReturnValue_Offset;

	private static bool ChangeExtension_IsValid;

	private static IntPtr ChangeExtension_FunctionAddress;

	private static int ChangeExtension_ParamsSize;

	private static bool ChangeExtension_InPath_IsValid;

	private static FFieldAddress ChangeExtension_InPath_PropertyAddress;

	private static int ChangeExtension_InPath_Offset;

	private static bool ChangeExtension_InNewExtension_IsValid;

	private static FFieldAddress ChangeExtension_InNewExtension_PropertyAddress;

	private static int ChangeExtension_InNewExtension_Offset;

	private static bool ChangeExtension_ReturnValue_IsValid;

	private static FFieldAddress ChangeExtension_ReturnValue_PropertyAddress;

	private static int ChangeExtension_ReturnValue_Offset;

	private static bool BugItDir_IsValid;

	private static IntPtr BugItDir_FunctionAddress;

	private static int BugItDir_ParamsSize;

	private static bool BugItDir_ReturnValue_IsValid;

	private static FFieldAddress BugItDir_ReturnValue_PropertyAddress;

	private static int BugItDir_ReturnValue_Offset;

	private static bool AutomationTransientDir_IsValid;

	private static IntPtr AutomationTransientDir_FunctionAddress;

	private static int AutomationTransientDir_ParamsSize;

	private static bool AutomationTransientDir_ReturnValue_IsValid;

	private static FFieldAddress AutomationTransientDir_ReturnValue_PropertyAddress;

	private static int AutomationTransientDir_ReturnValue_Offset;

	private static bool AutomationLogDir_IsValid;

	private static IntPtr AutomationLogDir_FunctionAddress;

	private static int AutomationLogDir_ParamsSize;

	private static bool AutomationLogDir_ReturnValue_IsValid;

	private static FFieldAddress AutomationLogDir_ReturnValue_PropertyAddress;

	private static int AutomationLogDir_ReturnValue_Offset;

	private static bool AutomationDir_IsValid;

	private static IntPtr AutomationDir_FunctionAddress;

	private static int AutomationDir_ParamsSize;

	private static bool AutomationDir_ReturnValue_IsValid;

	private static FFieldAddress AutomationDir_ReturnValue_PropertyAddress;

	private static int AutomationDir_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:VideoCaptureDir")]
	public unsafe static string VideoCaptureDir()
	{
		if (!VideoCaptureDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:VideoCaptureDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VideoCaptureDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VideoCaptureDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VideoCaptureDir_FunctionAddress, intPtr, VideoCaptureDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, VideoCaptureDir_ReturnValue_Offset), 0, VideoCaptureDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(VideoCaptureDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ValidatePath")]
	public unsafe static void ValidatePath(string InPath, out bool bDidSucceed, out FText OutReason)
	{
		if (!ValidatePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ValidatePath");
			bDidSucceed = false;
			OutReason = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidatePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidatePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ValidatePath_InPath_Offset), 0, ValidatePath_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InitializeValue_InContainer(ValidatePath_OutReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ValidatePath_FunctionAddress, intPtr, ValidatePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ValidatePath_InPath_PropertyAddress.Address, intPtr);
		bDidSucceed = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ValidatePath_bDidSucceed_Offset), 0, ValidatePath_bDidSucceed_PropertyAddress.Address);
		OutReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ValidatePath_OutReason_Offset), 0, ValidatePath_OutReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ValidatePath_OutReason_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:Split")]
	public unsafe static void Split(string InPath, out string PathPart, out string FilenamePart, out string ExtensionPart)
	{
		if (!Split_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:Split");
			PathPart = FStringMarshaler.DefaultString;
			FilenamePart = FStringMarshaler.DefaultString;
			ExtensionPart = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Split_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Split_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Split_InPath_Offset), 0, Split_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Split_FunctionAddress, intPtr, Split_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Split_InPath_PropertyAddress.Address, intPtr);
		PathPart = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Split_PathPart_Offset), 0, Split_PathPart_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Split_PathPart_PropertyAddress.Address, intPtr);
		FilenamePart = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Split_FilenamePart_Offset), 0, Split_FilenamePart_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Split_FilenamePart_PropertyAddress.Address, intPtr);
		ExtensionPart = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Split_ExtensionPart_Offset), 0, Split_ExtensionPart_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Split_ExtensionPart_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:SourceConfigDir")]
	public unsafe static string SourceConfigDir()
	{
		if (!SourceConfigDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:SourceConfigDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SourceConfigDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SourceConfigDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SourceConfigDir_FunctionAddress, intPtr, SourceConfigDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SourceConfigDir_ReturnValue_Offset), 0, SourceConfigDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SourceConfigDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ShouldSaveToUserDir")]
	public unsafe static bool ShouldSaveToUserDir()
	{
		if (!ShouldSaveToUserDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ShouldSaveToUserDir");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldSaveToUserDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldSaveToUserDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShouldSaveToUserDir_FunctionAddress, intPtr, ShouldSaveToUserDir_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldSaveToUserDir_ReturnValue_Offset), 0, ShouldSaveToUserDir_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ShaderWorkingDir")]
	public unsafe static string ShaderWorkingDir()
	{
		if (!ShaderWorkingDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ShaderWorkingDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShaderWorkingDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShaderWorkingDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShaderWorkingDir_FunctionAddress, intPtr, ShaderWorkingDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ShaderWorkingDir_ReturnValue_Offset), 0, ShaderWorkingDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ShaderWorkingDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:SetProjectFilePath")]
	public unsafe static void SetProjectFilePath(string NewGameProjectFilePath)
	{
		if (!SetProjectFilePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:SetProjectFilePath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetProjectFilePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetProjectFilePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetProjectFilePath_NewGameProjectFilePath_Offset), 0, SetProjectFilePath_NewGameProjectFilePath_PropertyAddress.Address, NewGameProjectFilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetProjectFilePath_FunctionAddress, intPtr, SetProjectFilePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetProjectFilePath_NewGameProjectFilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:SetExtension")]
	public unsafe static string SetExtension(string InPath, string InNewExtension)
	{
		if (!SetExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:SetExtension");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetExtension_InPath_Offset), 0, SetExtension_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetExtension_InNewExtension_Offset), 0, SetExtension_InNewExtension_PropertyAddress.Address, InNewExtension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetExtension_FunctionAddress, intPtr, SetExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetExtension_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetExtension_InNewExtension_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SetExtension_ReturnValue_Offset), 0, SetExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ScreenShotDir")]
	public unsafe static string ScreenShotDir()
	{
		if (!ScreenShotDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ScreenShotDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScreenShotDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScreenShotDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScreenShotDir_FunctionAddress, intPtr, ScreenShotDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ScreenShotDir_ReturnValue_Offset), 0, ScreenShotDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ScreenShotDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:SandboxesDir")]
	public unsafe static string SandboxesDir()
	{
		if (!SandboxesDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:SandboxesDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SandboxesDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SandboxesDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SandboxesDir_FunctionAddress, intPtr, SandboxesDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SandboxesDir_ReturnValue_Offset), 0, SandboxesDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SandboxesDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:RootDir")]
	public unsafe static string RootDir()
	{
		if (!RootDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:RootDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RootDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RootDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RootDir_FunctionAddress, intPtr, RootDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RootDir_ReturnValue_Offset), 0, RootDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RootDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:RemoveDuplicateSlashes")]
	public unsafe static void RemoveDuplicateSlashes(string InPath, out string OutPath)
	{
		if (!RemoveDuplicateSlashes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:RemoveDuplicateSlashes");
			OutPath = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveDuplicateSlashes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveDuplicateSlashes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveDuplicateSlashes_InPath_Offset), 0, RemoveDuplicateSlashes_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveDuplicateSlashes_FunctionAddress, intPtr, RemoveDuplicateSlashes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveDuplicateSlashes_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RemoveDuplicateSlashes_OutPath_Offset), 0, RemoveDuplicateSlashes_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RemoveDuplicateSlashes_OutPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectUserDir")]
	public unsafe static string ProjectUserDir()
	{
		if (!ProjectUserDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectUserDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectUserDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectUserDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectUserDir_FunctionAddress, intPtr, ProjectUserDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectUserDir_ReturnValue_Offset), 0, ProjectUserDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectUserDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectSavedDir")]
	public unsafe static string ProjectSavedDir()
	{
		if (!ProjectSavedDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectSavedDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectSavedDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectSavedDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectSavedDir_FunctionAddress, intPtr, ProjectSavedDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectSavedDir_ReturnValue_Offset), 0, ProjectSavedDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectSavedDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectPluginsDir")]
	public unsafe static string ProjectPluginsDir()
	{
		if (!ProjectPluginsDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectPluginsDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectPluginsDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectPluginsDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectPluginsDir_FunctionAddress, intPtr, ProjectPluginsDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectPluginsDir_ReturnValue_Offset), 0, ProjectPluginsDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectPluginsDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectPersistentDownloadDir")]
	public unsafe static string ProjectPersistentDownloadDir()
	{
		if (!ProjectPersistentDownloadDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectPersistentDownloadDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectPersistentDownloadDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectPersistentDownloadDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectPersistentDownloadDir_FunctionAddress, intPtr, ProjectPersistentDownloadDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectPersistentDownloadDir_ReturnValue_Offset), 0, ProjectPersistentDownloadDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectPersistentDownloadDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectModsDir")]
	public unsafe static string ProjectModsDir()
	{
		if (!ProjectModsDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectModsDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectModsDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectModsDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectModsDir_FunctionAddress, intPtr, ProjectModsDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectModsDir_ReturnValue_Offset), 0, ProjectModsDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectModsDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectLogDir")]
	public unsafe static string ProjectLogDir()
	{
		if (!ProjectLogDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectLogDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectLogDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectLogDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectLogDir_FunctionAddress, intPtr, ProjectLogDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectLogDir_ReturnValue_Offset), 0, ProjectLogDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectLogDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectIntermediateDir")]
	public unsafe static string ProjectIntermediateDir()
	{
		if (!ProjectIntermediateDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectIntermediateDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectIntermediateDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectIntermediateDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectIntermediateDir_FunctionAddress, intPtr, ProjectIntermediateDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectIntermediateDir_ReturnValue_Offset), 0, ProjectIntermediateDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectIntermediateDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectDir")]
	public unsafe static string ProjectDir()
	{
		if (!ProjectDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectDir_FunctionAddress, intPtr, ProjectDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectDir_ReturnValue_Offset), 0, ProjectDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectContentDir")]
	public unsafe static string ProjectContentDir()
	{
		if (!ProjectContentDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectContentDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectContentDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectContentDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectContentDir_FunctionAddress, intPtr, ProjectContentDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectContentDir_ReturnValue_Offset), 0, ProjectContentDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectContentDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProjectConfigDir")]
	public unsafe static string ProjectConfigDir()
	{
		if (!ProjectConfigDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProjectConfigDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectConfigDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectConfigDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectConfigDir_FunctionAddress, intPtr, ProjectConfigDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProjectConfigDir_ReturnValue_Offset), 0, ProjectConfigDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProjectConfigDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ProfilingDir")]
	public unsafe static string ProfilingDir()
	{
		if (!ProfilingDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ProfilingDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProfilingDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProfilingDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProfilingDir_FunctionAddress, intPtr, ProfilingDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProfilingDir_ReturnValue_Offset), 0, ProfilingDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProfilingDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:NormalizeFilename")]
	public unsafe static void NormalizeFilename(string InPath, out string OutPath)
	{
		if (!NormalizeFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:NormalizeFilename");
			OutPath = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NormalizeFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NormalizeFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NormalizeFilename_InPath_Offset), 0, NormalizeFilename_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NormalizeFilename_FunctionAddress, intPtr, NormalizeFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NormalizeFilename_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, NormalizeFilename_OutPath_Offset), 0, NormalizeFilename_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NormalizeFilename_OutPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:NormalizeDirectoryName")]
	public unsafe static void NormalizeDirectoryName(string InPath, out string OutPath)
	{
		if (!NormalizeDirectoryName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:NormalizeDirectoryName");
			OutPath = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NormalizeDirectoryName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NormalizeDirectoryName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NormalizeDirectoryName_InPath_Offset), 0, NormalizeDirectoryName_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NormalizeDirectoryName_FunctionAddress, intPtr, NormalizeDirectoryName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NormalizeDirectoryName_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, NormalizeDirectoryName_OutPath_Offset), 0, NormalizeDirectoryName_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NormalizeDirectoryName_OutPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:MakeValidFileName")]
	public unsafe static string MakeValidFileName(string InString, string InReplacementChar)
	{
		if (!MakeValidFileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:MakeValidFileName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeValidFileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeValidFileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeValidFileName_InString_Offset), 0, MakeValidFileName_InString_PropertyAddress.Address, InString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeValidFileName_InReplacementChar_Offset), 0, MakeValidFileName_InReplacementChar_PropertyAddress.Address, InReplacementChar);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeValidFileName_FunctionAddress, intPtr, MakeValidFileName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeValidFileName_InString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MakeValidFileName_InReplacementChar_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, MakeValidFileName_ReturnValue_Offset), 0, MakeValidFileName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeValidFileName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:MakeStandardFilename")]
	public unsafe static void MakeStandardFilename(string InPath, out string OutPath)
	{
		if (!MakeStandardFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:MakeStandardFilename");
			OutPath = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeStandardFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeStandardFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeStandardFilename_InPath_Offset), 0, MakeStandardFilename_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeStandardFilename_FunctionAddress, intPtr, MakeStandardFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeStandardFilename_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, MakeStandardFilename_OutPath_Offset), 0, MakeStandardFilename_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeStandardFilename_OutPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:MakePlatformFilename")]
	public unsafe static void MakePlatformFilename(string InPath, out string OutPath)
	{
		if (!MakePlatformFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:MakePlatformFilename");
			OutPath = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakePlatformFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakePlatformFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakePlatformFilename_InPath_Offset), 0, MakePlatformFilename_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakePlatformFilename_FunctionAddress, intPtr, MakePlatformFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakePlatformFilename_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, MakePlatformFilename_OutPath_Offset), 0, MakePlatformFilename_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakePlatformFilename_OutPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:MakePathRelativeTo")]
	public unsafe static bool MakePathRelativeTo(string InPath, string InRelativeTo, out string OutPath)
	{
		if (!MakePathRelativeTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:MakePathRelativeTo");
			OutPath = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakePathRelativeTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakePathRelativeTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakePathRelativeTo_InPath_Offset), 0, MakePathRelativeTo_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakePathRelativeTo_InRelativeTo_Offset), 0, MakePathRelativeTo_InRelativeTo_PropertyAddress.Address, InRelativeTo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakePathRelativeTo_FunctionAddress, intPtr, MakePathRelativeTo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakePathRelativeTo_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MakePathRelativeTo_InRelativeTo_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, MakePathRelativeTo_OutPath_Offset), 0, MakePathRelativeTo_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakePathRelativeTo_OutPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakePathRelativeTo_ReturnValue_Offset), 0, MakePathRelativeTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:LaunchDir")]
	public unsafe static string LaunchDir()
	{
		if (!LaunchDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:LaunchDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LaunchDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LaunchDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LaunchDir_FunctionAddress, intPtr, LaunchDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LaunchDir_ReturnValue_Offset), 0, LaunchDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LaunchDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:IsSamePath")]
	public unsafe static bool IsSamePath(string PathA, string PathB)
	{
		if (!IsSamePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:IsSamePath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSamePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSamePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsSamePath_PathA_Offset), 0, IsSamePath_PathA_PropertyAddress.Address, PathA);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsSamePath_PathB_Offset), 0, IsSamePath_PathB_PropertyAddress.Address, PathB);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSamePath_FunctionAddress, intPtr, IsSamePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsSamePath_PathA_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsSamePath_PathB_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSamePath_ReturnValue_Offset), 0, IsSamePath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:IsRestrictedPath")]
	public unsafe static bool IsRestrictedPath(string InPath)
	{
		if (!IsRestrictedPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:IsRestrictedPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRestrictedPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRestrictedPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsRestrictedPath_InPath_Offset), 0, IsRestrictedPath_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRestrictedPath_FunctionAddress, intPtr, IsRestrictedPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRestrictedPath_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRestrictedPath_ReturnValue_Offset), 0, IsRestrictedPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:IsRelative")]
	public unsafe static bool IsRelative(string InPath)
	{
		if (!IsRelative_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:IsRelative");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRelative_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRelative_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsRelative_InPath_Offset), 0, IsRelative_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRelative_FunctionAddress, intPtr, IsRelative_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRelative_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRelative_ReturnValue_Offset), 0, IsRelative_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:IsProjectFilePathSet")]
	public unsafe static bool IsProjectFilePathSet()
	{
		if (!IsProjectFilePathSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:IsProjectFilePathSet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsProjectFilePathSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsProjectFilePathSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsProjectFilePathSet_FunctionAddress, intPtr, IsProjectFilePathSet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsProjectFilePathSet_ReturnValue_Offset), 0, IsProjectFilePathSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:IsDrive")]
	public unsafe static bool IsDrive(string InPath)
	{
		if (!IsDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:IsDrive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsDrive_InPath_Offset), 0, IsDrive_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDrive_FunctionAddress, intPtr, IsDrive_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsDrive_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDrive_ReturnValue_Offset), 0, IsDrive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:HasProjectPersistentDownloadDir")]
	public unsafe static bool HasProjectPersistentDownloadDir()
	{
		if (!HasProjectPersistentDownloadDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:HasProjectPersistentDownloadDir");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasProjectPersistentDownloadDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasProjectPersistentDownloadDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasProjectPersistentDownloadDir_FunctionAddress, intPtr, HasProjectPersistentDownloadDir_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasProjectPersistentDownloadDir_ReturnValue_Offset), 0, HasProjectPersistentDownloadDir_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetToolTipLocalizationPaths")]
	public unsafe static List<string> GetToolTipLocalizationPaths()
	{
		if (!GetToolTipLocalizationPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetToolTipLocalizationPaths");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetToolTipLocalizationPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetToolTipLocalizationPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetToolTipLocalizationPaths_FunctionAddress, intPtr, GetToolTipLocalizationPaths_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetToolTipLocalizationPaths_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetToolTipLocalizationPaths_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetToolTipLocalizationPaths_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetRestrictedFolderNames")]
	public unsafe static List<string> GetRestrictedFolderNames()
	{
		if (!GetRestrictedFolderNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetRestrictedFolderNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRestrictedFolderNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRestrictedFolderNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRestrictedFolderNames_FunctionAddress, intPtr, GetRestrictedFolderNames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetRestrictedFolderNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetRestrictedFolderNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRestrictedFolderNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetRelativePathToRoot")]
	public unsafe static string GetRelativePathToRoot()
	{
		if (!GetRelativePathToRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetRelativePathToRoot");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRelativePathToRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRelativePathToRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRelativePathToRoot_FunctionAddress, intPtr, GetRelativePathToRoot_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetRelativePathToRoot_ReturnValue_Offset), 0, GetRelativePathToRoot_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRelativePathToRoot_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetPropertyNameLocalizationPaths")]
	public unsafe static List<string> GetPropertyNameLocalizationPaths()
	{
		if (!GetPropertyNameLocalizationPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetPropertyNameLocalizationPaths");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPropertyNameLocalizationPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPropertyNameLocalizationPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPropertyNameLocalizationPaths_FunctionAddress, intPtr, GetPropertyNameLocalizationPaths_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetPropertyNameLocalizationPaths_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetPropertyNameLocalizationPaths_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPropertyNameLocalizationPaths_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetProjectFilePath")]
	public unsafe static string GetProjectFilePath()
	{
		if (!GetProjectFilePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetProjectFilePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProjectFilePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProjectFilePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProjectFilePath_FunctionAddress, intPtr, GetProjectFilePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetProjectFilePath_ReturnValue_Offset), 0, GetProjectFilePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetProjectFilePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetPath")]
	public unsafe static string GetPath(string InPath)
	{
		if (!GetPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPath_InPath_Offset), 0, GetPath_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPath_FunctionAddress, intPtr, GetPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPath_InPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPath_ReturnValue_Offset), 0, GetPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetInvalidFileSystemChars")]
	public unsafe static string GetInvalidFileSystemChars()
	{
		if (!GetInvalidFileSystemChars_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetInvalidFileSystemChars");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInvalidFileSystemChars_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInvalidFileSystemChars_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInvalidFileSystemChars_FunctionAddress, intPtr, GetInvalidFileSystemChars_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetInvalidFileSystemChars_ReturnValue_Offset), 0, GetInvalidFileSystemChars_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInvalidFileSystemChars_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetGameLocalizationPaths")]
	public unsafe static List<string> GetGameLocalizationPaths()
	{
		if (!GetGameLocalizationPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetGameLocalizationPaths");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameLocalizationPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameLocalizationPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameLocalizationPaths_FunctionAddress, intPtr, GetGameLocalizationPaths_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetGameLocalizationPaths_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetGameLocalizationPaths_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetGameLocalizationPaths_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetExtension")]
	public unsafe static string GetExtension(string InPath, bool bIncludeDot = false)
	{
		if (!GetExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetExtension");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetExtension_InPath_Offset), 0, GetExtension_InPath_PropertyAddress.Address, InPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetExtension_bIncludeDot_Offset), 0, GetExtension_bIncludeDot_PropertyAddress.Address, bIncludeDot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExtension_FunctionAddress, intPtr, GetExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetExtension_InPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetExtension_ReturnValue_Offset), 0, GetExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetEngineLocalizationPaths")]
	public unsafe static List<string> GetEngineLocalizationPaths()
	{
		if (!GetEngineLocalizationPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetEngineLocalizationPaths");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngineLocalizationPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngineLocalizationPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEngineLocalizationPaths_FunctionAddress, intPtr, GetEngineLocalizationPaths_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetEngineLocalizationPaths_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetEngineLocalizationPaths_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetEngineLocalizationPaths_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetEditorLocalizationPaths")]
	public unsafe static List<string> GetEditorLocalizationPaths()
	{
		if (!GetEditorLocalizationPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetEditorLocalizationPaths");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorLocalizationPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorLocalizationPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditorLocalizationPaths_FunctionAddress, intPtr, GetEditorLocalizationPaths_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetEditorLocalizationPaths_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetEditorLocalizationPaths_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetEditorLocalizationPaths_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetCleanFilename")]
	public unsafe static string GetCleanFilename(string InPath)
	{
		if (!GetCleanFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetCleanFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCleanFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCleanFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetCleanFilename_InPath_Offset), 0, GetCleanFilename_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCleanFilename_FunctionAddress, intPtr, GetCleanFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCleanFilename_InPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCleanFilename_ReturnValue_Offset), 0, GetCleanFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCleanFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GetBaseFilename")]
	public unsafe static string GetBaseFilename(string InPath, bool bRemovePath = true)
	{
		if (!GetBaseFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GetBaseFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBaseFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBaseFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetBaseFilename_InPath_Offset), 0, GetBaseFilename_InPath_PropertyAddress.Address, InPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBaseFilename_bRemovePath_Offset), 0, GetBaseFilename_bRemovePath_PropertyAddress.Address, bRemovePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBaseFilename_FunctionAddress, intPtr, GetBaseFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBaseFilename_InPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetBaseFilename_ReturnValue_Offset), 0, GetBaseFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBaseFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GeneratedConfigDir")]
	public unsafe static string GeneratedConfigDir()
	{
		if (!GeneratedConfigDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GeneratedConfigDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratedConfigDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratedConfigDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GeneratedConfigDir_FunctionAddress, intPtr, GeneratedConfigDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GeneratedConfigDir_ReturnValue_Offset), 0, GeneratedConfigDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GeneratedConfigDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GameUserDeveloperDir")]
	public unsafe static string GameUserDeveloperDir()
	{
		if (!GameUserDeveloperDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GameUserDeveloperDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GameUserDeveloperDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameUserDeveloperDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GameUserDeveloperDir_FunctionAddress, intPtr, GameUserDeveloperDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GameUserDeveloperDir_ReturnValue_Offset), 0, GameUserDeveloperDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GameUserDeveloperDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GameSourceDir")]
	public unsafe static string GameSourceDir()
	{
		if (!GameSourceDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GameSourceDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GameSourceDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameSourceDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GameSourceDir_FunctionAddress, intPtr, GameSourceDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GameSourceDir_ReturnValue_Offset), 0, GameSourceDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GameSourceDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GameDevelopersDir")]
	public unsafe static string GameDevelopersDir()
	{
		if (!GameDevelopersDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GameDevelopersDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GameDevelopersDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameDevelopersDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GameDevelopersDir_FunctionAddress, intPtr, GameDevelopersDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GameDevelopersDir_ReturnValue_Offset), 0, GameDevelopersDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GameDevelopersDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:GameAgnosticSavedDir")]
	public unsafe static string GameAgnosticSavedDir()
	{
		if (!GameAgnosticSavedDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:GameAgnosticSavedDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GameAgnosticSavedDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameAgnosticSavedDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GameAgnosticSavedDir_FunctionAddress, intPtr, GameAgnosticSavedDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GameAgnosticSavedDir_ReturnValue_Offset), 0, GameAgnosticSavedDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GameAgnosticSavedDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:FileExists")]
	public unsafe static bool FileExists(string InPath)
	{
		if (!FileExists_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:FileExists");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FileExists_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FileExists_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FileExists_InPath_Offset), 0, FileExists_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FileExists_FunctionAddress, intPtr, FileExists_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FileExists_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FileExists_ReturnValue_Offset), 0, FileExists_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:FeaturePackDir")]
	public unsafe static string FeaturePackDir()
	{
		if (!FeaturePackDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:FeaturePackDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FeaturePackDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FeaturePackDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FeaturePackDir_FunctionAddress, intPtr, FeaturePackDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FeaturePackDir_ReturnValue_Offset), 0, FeaturePackDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FeaturePackDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EnterprisePluginsDir")]
	public unsafe static string EnterprisePluginsDir()
	{
		if (!EnterprisePluginsDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EnterprisePluginsDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnterprisePluginsDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnterprisePluginsDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnterprisePluginsDir_FunctionAddress, intPtr, EnterprisePluginsDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EnterprisePluginsDir_ReturnValue_Offset), 0, EnterprisePluginsDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EnterprisePluginsDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EnterpriseFeaturePackDir")]
	public unsafe static string EnterpriseFeaturePackDir()
	{
		if (!EnterpriseFeaturePackDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EnterpriseFeaturePackDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnterpriseFeaturePackDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnterpriseFeaturePackDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnterpriseFeaturePackDir_FunctionAddress, intPtr, EnterpriseFeaturePackDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EnterpriseFeaturePackDir_ReturnValue_Offset), 0, EnterpriseFeaturePackDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EnterpriseFeaturePackDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EnterpriseDir")]
	public unsafe static string EnterpriseDir()
	{
		if (!EnterpriseDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EnterpriseDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnterpriseDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnterpriseDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnterpriseDir_FunctionAddress, intPtr, EnterpriseDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EnterpriseDir_ReturnValue_Offset), 0, EnterpriseDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EnterpriseDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineVersionAgnosticUserDir")]
	public unsafe static string EngineVersionAgnosticUserDir()
	{
		if (!EngineVersionAgnosticUserDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineVersionAgnosticUserDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineVersionAgnosticUserDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineVersionAgnosticUserDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineVersionAgnosticUserDir_FunctionAddress, intPtr, EngineVersionAgnosticUserDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineVersionAgnosticUserDir_ReturnValue_Offset), 0, EngineVersionAgnosticUserDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineVersionAgnosticUserDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineUserDir")]
	public unsafe static string EngineUserDir()
	{
		if (!EngineUserDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineUserDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineUserDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineUserDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineUserDir_FunctionAddress, intPtr, EngineUserDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineUserDir_ReturnValue_Offset), 0, EngineUserDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineUserDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineSourceDir")]
	public unsafe static string EngineSourceDir()
	{
		if (!EngineSourceDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineSourceDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineSourceDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineSourceDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineSourceDir_FunctionAddress, intPtr, EngineSourceDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineSourceDir_ReturnValue_Offset), 0, EngineSourceDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineSourceDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineSavedDir")]
	public unsafe static string EngineSavedDir()
	{
		if (!EngineSavedDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineSavedDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineSavedDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineSavedDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineSavedDir_FunctionAddress, intPtr, EngineSavedDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineSavedDir_ReturnValue_Offset), 0, EngineSavedDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineSavedDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EnginePluginsDir")]
	public unsafe static string EnginePluginsDir()
	{
		if (!EnginePluginsDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EnginePluginsDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnginePluginsDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnginePluginsDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnginePluginsDir_FunctionAddress, intPtr, EnginePluginsDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EnginePluginsDir_ReturnValue_Offset), 0, EnginePluginsDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EnginePluginsDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineIntermediateDir")]
	public unsafe static string EngineIntermediateDir()
	{
		if (!EngineIntermediateDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineIntermediateDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineIntermediateDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineIntermediateDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineIntermediateDir_FunctionAddress, intPtr, EngineIntermediateDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineIntermediateDir_ReturnValue_Offset), 0, EngineIntermediateDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineIntermediateDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineDir")]
	public unsafe static string EngineDir()
	{
		if (!EngineDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineDir_FunctionAddress, intPtr, EngineDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineDir_ReturnValue_Offset), 0, EngineDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineContentDir")]
	public unsafe static string EngineContentDir()
	{
		if (!EngineContentDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineContentDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineContentDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineContentDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineContentDir_FunctionAddress, intPtr, EngineContentDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineContentDir_ReturnValue_Offset), 0, EngineContentDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineContentDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:EngineConfigDir")]
	public unsafe static string EngineConfigDir()
	{
		if (!EngineConfigDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:EngineConfigDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineConfigDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineConfigDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineConfigDir_FunctionAddress, intPtr, EngineConfigDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineConfigDir_ReturnValue_Offset), 0, EngineConfigDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineConfigDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:DirectoryExists")]
	public unsafe static bool DirectoryExists(string InPath)
	{
		if (!DirectoryExists_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:DirectoryExists");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DirectoryExists_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DirectoryExists_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DirectoryExists_InPath_Offset), 0, DirectoryExists_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DirectoryExists_FunctionAddress, intPtr, DirectoryExists_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DirectoryExists_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DirectoryExists_ReturnValue_Offset), 0, DirectoryExists_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:DiffDir")]
	public unsafe static string DiffDir()
	{
		if (!DiffDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:DiffDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DiffDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DiffDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DiffDir_FunctionAddress, intPtr, DiffDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, DiffDir_ReturnValue_Offset), 0, DiffDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DiffDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:CreateTempFilename")]
	public unsafe static string CreateTempFilename(string Path, string Prefix, string Extension = ".tmp")
	{
		if (!CreateTempFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:CreateTempFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTempFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTempFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTempFilename_Path_Offset), 0, CreateTempFilename_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTempFilename_Prefix_Offset), 0, CreateTempFilename_Prefix_PropertyAddress.Address, Prefix);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTempFilename_Extension_Offset), 0, CreateTempFilename_Extension_PropertyAddress.Address, Extension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTempFilename_FunctionAddress, intPtr, CreateTempFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTempFilename_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTempFilename_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTempFilename_Extension_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CreateTempFilename_ReturnValue_Offset), 0, CreateTempFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateTempFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ConvertToSandboxPath")]
	public unsafe static string ConvertToSandboxPath(string InPath, string InSandboxName)
	{
		if (!ConvertToSandboxPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ConvertToSandboxPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSandboxPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSandboxPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertToSandboxPath_InPath_Offset), 0, ConvertToSandboxPath_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertToSandboxPath_InSandboxName_Offset), 0, ConvertToSandboxPath_InSandboxName_PropertyAddress.Address, InSandboxName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSandboxPath_FunctionAddress, intPtr, ConvertToSandboxPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToSandboxPath_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertToSandboxPath_InSandboxName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToSandboxPath_ReturnValue_Offset), 0, ConvertToSandboxPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertToSandboxPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ConvertRelativePathToFull")]
	public unsafe static string ConvertRelativePathToFull(string InPath, string InBasePath)
	{
		if (!ConvertRelativePathToFull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ConvertRelativePathToFull");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertRelativePathToFull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertRelativePathToFull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertRelativePathToFull_InPath_Offset), 0, ConvertRelativePathToFull_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertRelativePathToFull_InBasePath_Offset), 0, ConvertRelativePathToFull_InBasePath_PropertyAddress.Address, InBasePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertRelativePathToFull_FunctionAddress, intPtr, ConvertRelativePathToFull_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertRelativePathToFull_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertRelativePathToFull_InBasePath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ConvertRelativePathToFull_ReturnValue_Offset), 0, ConvertRelativePathToFull_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertRelativePathToFull_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ConvertFromSandboxPath")]
	public unsafe static string ConvertFromSandboxPath(string InPath, string InSandboxName)
	{
		if (!ConvertFromSandboxPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ConvertFromSandboxPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertFromSandboxPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertFromSandboxPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertFromSandboxPath_InPath_Offset), 0, ConvertFromSandboxPath_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertFromSandboxPath_InSandboxName_Offset), 0, ConvertFromSandboxPath_InSandboxName_PropertyAddress.Address, InSandboxName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertFromSandboxPath_FunctionAddress, intPtr, ConvertFromSandboxPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertFromSandboxPath_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertFromSandboxPath_InSandboxName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ConvertFromSandboxPath_ReturnValue_Offset), 0, ConvertFromSandboxPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertFromSandboxPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:Combine")]
	public unsafe static string Combine(List<string> InPaths)
	{
		if (!Combine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:Combine");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Combine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Combine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, Combine_InPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, Combine_InPaths_Offset), InPaths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Combine_FunctionAddress, intPtr, Combine_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Combine_InPaths_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Combine_ReturnValue_Offset), 0, Combine_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Combine_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:CollapseRelativeDirectories")]
	public unsafe static bool CollapseRelativeDirectories(string InPath, out string OutPath)
	{
		if (!CollapseRelativeDirectories_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:CollapseRelativeDirectories");
			OutPath = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollapseRelativeDirectories_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollapseRelativeDirectories_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CollapseRelativeDirectories_InPath_Offset), 0, CollapseRelativeDirectories_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CollapseRelativeDirectories_FunctionAddress, intPtr, CollapseRelativeDirectories_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CollapseRelativeDirectories_InPath_PropertyAddress.Address, intPtr);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CollapseRelativeDirectories_OutPath_Offset), 0, CollapseRelativeDirectories_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CollapseRelativeDirectories_OutPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CollapseRelativeDirectories_ReturnValue_Offset), 0, CollapseRelativeDirectories_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:CloudDir")]
	public unsafe static string CloudDir()
	{
		if (!CloudDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:CloudDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloudDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloudDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloudDir_FunctionAddress, intPtr, CloudDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CloudDir_ReturnValue_Offset), 0, CloudDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CloudDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:ChangeExtension")]
	public unsafe static string ChangeExtension(string InPath, string InNewExtension)
	{
		if (!ChangeExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:ChangeExtension");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExtension_InPath_Offset), 0, ChangeExtension_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExtension_InNewExtension_Offset), 0, ChangeExtension_InNewExtension_PropertyAddress.Address, InNewExtension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ChangeExtension_FunctionAddress, intPtr, ChangeExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ChangeExtension_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ChangeExtension_InNewExtension_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ChangeExtension_ReturnValue_Offset), 0, ChangeExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ChangeExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:BugItDir")]
	public unsafe static string BugItDir()
	{
		if (!BugItDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:BugItDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BugItDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BugItDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BugItDir_FunctionAddress, intPtr, BugItDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BugItDir_ReturnValue_Offset), 0, BugItDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BugItDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:AutomationTransientDir")]
	public unsafe static string AutomationTransientDir()
	{
		if (!AutomationTransientDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:AutomationTransientDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutomationTransientDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutomationTransientDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutomationTransientDir_FunctionAddress, intPtr, AutomationTransientDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AutomationTransientDir_ReturnValue_Offset), 0, AutomationTransientDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AutomationTransientDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:AutomationLogDir")]
	public unsafe static string AutomationLogDir()
	{
		if (!AutomationLogDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:AutomationLogDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutomationLogDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutomationLogDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutomationLogDir_FunctionAddress, intPtr, AutomationLogDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AutomationLogDir_ReturnValue_Offset), 0, AutomationLogDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AutomationLogDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPathsLibrary:AutomationDir")]
	public unsafe static string AutomationDir()
	{
		if (!AutomationDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPathsLibrary:AutomationDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutomationDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutomationDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutomationDir_FunctionAddress, intPtr, AutomationDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AutomationDir_ReturnValue_Offset), 0, AutomationDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AutomationDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPaths()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaths)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaths));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.BlueprintPathsLibrary");
		VideoCaptureDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VideoCaptureDir");
		VideoCaptureDir_ParamsSize = NativeReflection.GetFunctionParamsSize(VideoCaptureDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VideoCaptureDir_ReturnValue_PropertyAddress, VideoCaptureDir_FunctionAddress, "ReturnValue");
		VideoCaptureDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(VideoCaptureDir_FunctionAddress, "ReturnValue");
		VideoCaptureDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(VideoCaptureDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		VideoCaptureDir_IsValid = VideoCaptureDir_FunctionAddress != IntPtr.Zero && VideoCaptureDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:VideoCaptureDir", VideoCaptureDir_IsValid);
		ValidatePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ValidatePath");
		ValidatePath_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidatePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ValidatePath_InPath_PropertyAddress, ValidatePath_FunctionAddress, "InPath");
		ValidatePath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ValidatePath_FunctionAddress, "InPath");
		ValidatePath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidatePath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidatePath_bDidSucceed_PropertyAddress, ValidatePath_FunctionAddress, "bDidSucceed");
		ValidatePath_bDidSucceed_Offset = NativeReflectionCached.GetPropertyOffset(ValidatePath_FunctionAddress, "bDidSucceed");
		ValidatePath_bDidSucceed_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidatePath_FunctionAddress, "bDidSucceed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidatePath_OutReason_PropertyAddress, ValidatePath_FunctionAddress, "OutReason");
		ValidatePath_OutReason_Offset = NativeReflectionCached.GetPropertyOffset(ValidatePath_FunctionAddress, "OutReason");
		ValidatePath_OutReason_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidatePath_FunctionAddress, "OutReason", Classes.FTextProperty);
		ValidatePath_IsValid = ValidatePath_FunctionAddress != IntPtr.Zero && ValidatePath_InPath_IsValid && ValidatePath_bDidSucceed_IsValid && ValidatePath_OutReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ValidatePath", ValidatePath_IsValid);
		Split_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Split");
		Split_ParamsSize = NativeReflection.GetFunctionParamsSize(Split_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Split_InPath_PropertyAddress, Split_FunctionAddress, "InPath");
		Split_InPath_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "InPath");
		Split_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_PathPart_PropertyAddress, Split_FunctionAddress, "PathPart");
		Split_PathPart_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "PathPart");
		Split_PathPart_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "PathPart", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_FilenamePart_PropertyAddress, Split_FunctionAddress, "FilenamePart");
		Split_FilenamePart_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "FilenamePart");
		Split_FilenamePart_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "FilenamePart", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_ExtensionPart_PropertyAddress, Split_FunctionAddress, "ExtensionPart");
		Split_ExtensionPart_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "ExtensionPart");
		Split_ExtensionPart_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "ExtensionPart", Classes.FStrProperty);
		Split_IsValid = Split_FunctionAddress != IntPtr.Zero && Split_InPath_IsValid && Split_PathPart_IsValid && Split_FilenamePart_IsValid && Split_ExtensionPart_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:Split", Split_IsValid);
		SourceConfigDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SourceConfigDir");
		SourceConfigDir_ParamsSize = NativeReflection.GetFunctionParamsSize(SourceConfigDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SourceConfigDir_ReturnValue_PropertyAddress, SourceConfigDir_FunctionAddress, "ReturnValue");
		SourceConfigDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SourceConfigDir_FunctionAddress, "ReturnValue");
		SourceConfigDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SourceConfigDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		SourceConfigDir_IsValid = SourceConfigDir_FunctionAddress != IntPtr.Zero && SourceConfigDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:SourceConfigDir", SourceConfigDir_IsValid);
		ShouldSaveToUserDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShouldSaveToUserDir");
		ShouldSaveToUserDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldSaveToUserDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldSaveToUserDir_ReturnValue_PropertyAddress, ShouldSaveToUserDir_FunctionAddress, "ReturnValue");
		ShouldSaveToUserDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldSaveToUserDir_FunctionAddress, "ReturnValue");
		ShouldSaveToUserDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldSaveToUserDir_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldSaveToUserDir_IsValid = ShouldSaveToUserDir_FunctionAddress != IntPtr.Zero && ShouldSaveToUserDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ShouldSaveToUserDir", ShouldSaveToUserDir_IsValid);
		ShaderWorkingDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShaderWorkingDir");
		ShaderWorkingDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ShaderWorkingDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShaderWorkingDir_ReturnValue_PropertyAddress, ShaderWorkingDir_FunctionAddress, "ReturnValue");
		ShaderWorkingDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShaderWorkingDir_FunctionAddress, "ReturnValue");
		ShaderWorkingDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShaderWorkingDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ShaderWorkingDir_IsValid = ShaderWorkingDir_FunctionAddress != IntPtr.Zero && ShaderWorkingDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ShaderWorkingDir", ShaderWorkingDir_IsValid);
		SetProjectFilePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetProjectFilePath");
		SetProjectFilePath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetProjectFilePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetProjectFilePath_NewGameProjectFilePath_PropertyAddress, SetProjectFilePath_FunctionAddress, "NewGameProjectFilePath");
		SetProjectFilePath_NewGameProjectFilePath_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectFilePath_FunctionAddress, "NewGameProjectFilePath");
		SetProjectFilePath_NewGameProjectFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectFilePath_FunctionAddress, "NewGameProjectFilePath", Classes.FStrProperty);
		SetProjectFilePath_IsValid = SetProjectFilePath_FunctionAddress != IntPtr.Zero && SetProjectFilePath_NewGameProjectFilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:SetProjectFilePath", SetProjectFilePath_IsValid);
		SetExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetExtension");
		SetExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExtension_InPath_PropertyAddress, SetExtension_FunctionAddress, "InPath");
		SetExtension_InPath_Offset = NativeReflectionCached.GetPropertyOffset(SetExtension_FunctionAddress, "InPath");
		SetExtension_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtension_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExtension_InNewExtension_PropertyAddress, SetExtension_FunctionAddress, "InNewExtension");
		SetExtension_InNewExtension_Offset = NativeReflectionCached.GetPropertyOffset(SetExtension_FunctionAddress, "InNewExtension");
		SetExtension_InNewExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtension_FunctionAddress, "InNewExtension", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExtension_ReturnValue_PropertyAddress, SetExtension_FunctionAddress, "ReturnValue");
		SetExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetExtension_FunctionAddress, "ReturnValue");
		SetExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtension_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		SetExtension_IsValid = SetExtension_FunctionAddress != IntPtr.Zero && SetExtension_InPath_IsValid && SetExtension_InNewExtension_IsValid && SetExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:SetExtension", SetExtension_IsValid);
		ScreenShotDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScreenShotDir");
		ScreenShotDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ScreenShotDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScreenShotDir_ReturnValue_PropertyAddress, ScreenShotDir_FunctionAddress, "ReturnValue");
		ScreenShotDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScreenShotDir_FunctionAddress, "ReturnValue");
		ScreenShotDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenShotDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ScreenShotDir_IsValid = ScreenShotDir_FunctionAddress != IntPtr.Zero && ScreenShotDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ScreenShotDir", ScreenShotDir_IsValid);
		SandboxesDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SandboxesDir");
		SandboxesDir_ParamsSize = NativeReflection.GetFunctionParamsSize(SandboxesDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SandboxesDir_ReturnValue_PropertyAddress, SandboxesDir_FunctionAddress, "ReturnValue");
		SandboxesDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SandboxesDir_FunctionAddress, "ReturnValue");
		SandboxesDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SandboxesDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		SandboxesDir_IsValid = SandboxesDir_FunctionAddress != IntPtr.Zero && SandboxesDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:SandboxesDir", SandboxesDir_IsValid);
		RootDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RootDir");
		RootDir_ParamsSize = NativeReflection.GetFunctionParamsSize(RootDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RootDir_ReturnValue_PropertyAddress, RootDir_FunctionAddress, "ReturnValue");
		RootDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RootDir_FunctionAddress, "ReturnValue");
		RootDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RootDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RootDir_IsValid = RootDir_FunctionAddress != IntPtr.Zero && RootDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:RootDir", RootDir_IsValid);
		RemoveDuplicateSlashes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveDuplicateSlashes");
		RemoveDuplicateSlashes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveDuplicateSlashes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveDuplicateSlashes_InPath_PropertyAddress, RemoveDuplicateSlashes_FunctionAddress, "InPath");
		RemoveDuplicateSlashes_InPath_Offset = NativeReflectionCached.GetPropertyOffset(RemoveDuplicateSlashes_FunctionAddress, "InPath");
		RemoveDuplicateSlashes_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveDuplicateSlashes_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveDuplicateSlashes_OutPath_PropertyAddress, RemoveDuplicateSlashes_FunctionAddress, "OutPath");
		RemoveDuplicateSlashes_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(RemoveDuplicateSlashes_FunctionAddress, "OutPath");
		RemoveDuplicateSlashes_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveDuplicateSlashes_FunctionAddress, "OutPath", Classes.FStrProperty);
		RemoveDuplicateSlashes_IsValid = RemoveDuplicateSlashes_FunctionAddress != IntPtr.Zero && RemoveDuplicateSlashes_InPath_IsValid && RemoveDuplicateSlashes_OutPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:RemoveDuplicateSlashes", RemoveDuplicateSlashes_IsValid);
		ProjectUserDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectUserDir");
		ProjectUserDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectUserDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectUserDir_ReturnValue_PropertyAddress, ProjectUserDir_FunctionAddress, "ReturnValue");
		ProjectUserDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectUserDir_FunctionAddress, "ReturnValue");
		ProjectUserDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectUserDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectUserDir_IsValid = ProjectUserDir_FunctionAddress != IntPtr.Zero && ProjectUserDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectUserDir", ProjectUserDir_IsValid);
		ProjectSavedDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectSavedDir");
		ProjectSavedDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectSavedDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectSavedDir_ReturnValue_PropertyAddress, ProjectSavedDir_FunctionAddress, "ReturnValue");
		ProjectSavedDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectSavedDir_FunctionAddress, "ReturnValue");
		ProjectSavedDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectSavedDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectSavedDir_IsValid = ProjectSavedDir_FunctionAddress != IntPtr.Zero && ProjectSavedDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectSavedDir", ProjectSavedDir_IsValid);
		ProjectPluginsDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectPluginsDir");
		ProjectPluginsDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectPluginsDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectPluginsDir_ReturnValue_PropertyAddress, ProjectPluginsDir_FunctionAddress, "ReturnValue");
		ProjectPluginsDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPluginsDir_FunctionAddress, "ReturnValue");
		ProjectPluginsDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPluginsDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectPluginsDir_IsValid = ProjectPluginsDir_FunctionAddress != IntPtr.Zero && ProjectPluginsDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectPluginsDir", ProjectPluginsDir_IsValid);
		ProjectPersistentDownloadDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectPersistentDownloadDir");
		ProjectPersistentDownloadDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectPersistentDownloadDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectPersistentDownloadDir_ReturnValue_PropertyAddress, ProjectPersistentDownloadDir_FunctionAddress, "ReturnValue");
		ProjectPersistentDownloadDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPersistentDownloadDir_FunctionAddress, "ReturnValue");
		ProjectPersistentDownloadDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPersistentDownloadDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectPersistentDownloadDir_IsValid = ProjectPersistentDownloadDir_FunctionAddress != IntPtr.Zero && ProjectPersistentDownloadDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectPersistentDownloadDir", ProjectPersistentDownloadDir_IsValid);
		ProjectModsDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectModsDir");
		ProjectModsDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectModsDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectModsDir_ReturnValue_PropertyAddress, ProjectModsDir_FunctionAddress, "ReturnValue");
		ProjectModsDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectModsDir_FunctionAddress, "ReturnValue");
		ProjectModsDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectModsDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectModsDir_IsValid = ProjectModsDir_FunctionAddress != IntPtr.Zero && ProjectModsDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectModsDir", ProjectModsDir_IsValid);
		ProjectLogDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectLogDir");
		ProjectLogDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectLogDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectLogDir_ReturnValue_PropertyAddress, ProjectLogDir_FunctionAddress, "ReturnValue");
		ProjectLogDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectLogDir_FunctionAddress, "ReturnValue");
		ProjectLogDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectLogDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectLogDir_IsValid = ProjectLogDir_FunctionAddress != IntPtr.Zero && ProjectLogDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectLogDir", ProjectLogDir_IsValid);
		ProjectIntermediateDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectIntermediateDir");
		ProjectIntermediateDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectIntermediateDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectIntermediateDir_ReturnValue_PropertyAddress, ProjectIntermediateDir_FunctionAddress, "ReturnValue");
		ProjectIntermediateDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectIntermediateDir_FunctionAddress, "ReturnValue");
		ProjectIntermediateDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectIntermediateDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectIntermediateDir_IsValid = ProjectIntermediateDir_FunctionAddress != IntPtr.Zero && ProjectIntermediateDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectIntermediateDir", ProjectIntermediateDir_IsValid);
		ProjectDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectDir");
		ProjectDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectDir_ReturnValue_PropertyAddress, ProjectDir_FunctionAddress, "ReturnValue");
		ProjectDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectDir_FunctionAddress, "ReturnValue");
		ProjectDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectDir_IsValid = ProjectDir_FunctionAddress != IntPtr.Zero && ProjectDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectDir", ProjectDir_IsValid);
		ProjectContentDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectContentDir");
		ProjectContentDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectContentDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectContentDir_ReturnValue_PropertyAddress, ProjectContentDir_FunctionAddress, "ReturnValue");
		ProjectContentDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectContentDir_FunctionAddress, "ReturnValue");
		ProjectContentDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectContentDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectContentDir_IsValid = ProjectContentDir_FunctionAddress != IntPtr.Zero && ProjectContentDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectContentDir", ProjectContentDir_IsValid);
		ProjectConfigDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectConfigDir");
		ProjectConfigDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectConfigDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectConfigDir_ReturnValue_PropertyAddress, ProjectConfigDir_FunctionAddress, "ReturnValue");
		ProjectConfigDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectConfigDir_FunctionAddress, "ReturnValue");
		ProjectConfigDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectConfigDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProjectConfigDir_IsValid = ProjectConfigDir_FunctionAddress != IntPtr.Zero && ProjectConfigDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProjectConfigDir", ProjectConfigDir_IsValid);
		ProfilingDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProfilingDir");
		ProfilingDir_ParamsSize = NativeReflection.GetFunctionParamsSize(ProfilingDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProfilingDir_ReturnValue_PropertyAddress, ProfilingDir_FunctionAddress, "ReturnValue");
		ProfilingDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProfilingDir_FunctionAddress, "ReturnValue");
		ProfilingDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProfilingDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ProfilingDir_IsValid = ProfilingDir_FunctionAddress != IntPtr.Zero && ProfilingDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ProfilingDir", ProfilingDir_IsValid);
		NormalizeFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NormalizeFilename");
		NormalizeFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(NormalizeFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NormalizeFilename_InPath_PropertyAddress, NormalizeFilename_FunctionAddress, "InPath");
		NormalizeFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(NormalizeFilename_FunctionAddress, "InPath");
		NormalizeFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NormalizeFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalizeFilename_OutPath_PropertyAddress, NormalizeFilename_FunctionAddress, "OutPath");
		NormalizeFilename_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(NormalizeFilename_FunctionAddress, "OutPath");
		NormalizeFilename_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NormalizeFilename_FunctionAddress, "OutPath", Classes.FStrProperty);
		NormalizeFilename_IsValid = NormalizeFilename_FunctionAddress != IntPtr.Zero && NormalizeFilename_InPath_IsValid && NormalizeFilename_OutPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:NormalizeFilename", NormalizeFilename_IsValid);
		NormalizeDirectoryName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NormalizeDirectoryName");
		NormalizeDirectoryName_ParamsSize = NativeReflection.GetFunctionParamsSize(NormalizeDirectoryName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NormalizeDirectoryName_InPath_PropertyAddress, NormalizeDirectoryName_FunctionAddress, "InPath");
		NormalizeDirectoryName_InPath_Offset = NativeReflectionCached.GetPropertyOffset(NormalizeDirectoryName_FunctionAddress, "InPath");
		NormalizeDirectoryName_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NormalizeDirectoryName_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalizeDirectoryName_OutPath_PropertyAddress, NormalizeDirectoryName_FunctionAddress, "OutPath");
		NormalizeDirectoryName_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(NormalizeDirectoryName_FunctionAddress, "OutPath");
		NormalizeDirectoryName_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NormalizeDirectoryName_FunctionAddress, "OutPath", Classes.FStrProperty);
		NormalizeDirectoryName_IsValid = NormalizeDirectoryName_FunctionAddress != IntPtr.Zero && NormalizeDirectoryName_InPath_IsValid && NormalizeDirectoryName_OutPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:NormalizeDirectoryName", NormalizeDirectoryName_IsValid);
		MakeValidFileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeValidFileName");
		MakeValidFileName_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeValidFileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeValidFileName_InString_PropertyAddress, MakeValidFileName_FunctionAddress, "InString");
		MakeValidFileName_InString_Offset = NativeReflectionCached.GetPropertyOffset(MakeValidFileName_FunctionAddress, "InString");
		MakeValidFileName_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeValidFileName_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeValidFileName_InReplacementChar_PropertyAddress, MakeValidFileName_FunctionAddress, "InReplacementChar");
		MakeValidFileName_InReplacementChar_Offset = NativeReflectionCached.GetPropertyOffset(MakeValidFileName_FunctionAddress, "InReplacementChar");
		MakeValidFileName_InReplacementChar_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeValidFileName_FunctionAddress, "InReplacementChar", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeValidFileName_ReturnValue_PropertyAddress, MakeValidFileName_FunctionAddress, "ReturnValue");
		MakeValidFileName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeValidFileName_FunctionAddress, "ReturnValue");
		MakeValidFileName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeValidFileName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		MakeValidFileName_IsValid = MakeValidFileName_FunctionAddress != IntPtr.Zero && MakeValidFileName_InString_IsValid && MakeValidFileName_InReplacementChar_IsValid && MakeValidFileName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:MakeValidFileName", MakeValidFileName_IsValid);
		MakeStandardFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeStandardFilename");
		MakeStandardFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeStandardFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeStandardFilename_InPath_PropertyAddress, MakeStandardFilename_FunctionAddress, "InPath");
		MakeStandardFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(MakeStandardFilename_FunctionAddress, "InPath");
		MakeStandardFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeStandardFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeStandardFilename_OutPath_PropertyAddress, MakeStandardFilename_FunctionAddress, "OutPath");
		MakeStandardFilename_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(MakeStandardFilename_FunctionAddress, "OutPath");
		MakeStandardFilename_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeStandardFilename_FunctionAddress, "OutPath", Classes.FStrProperty);
		MakeStandardFilename_IsValid = MakeStandardFilename_FunctionAddress != IntPtr.Zero && MakeStandardFilename_InPath_IsValid && MakeStandardFilename_OutPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:MakeStandardFilename", MakeStandardFilename_IsValid);
		MakePlatformFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakePlatformFilename");
		MakePlatformFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(MakePlatformFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakePlatformFilename_InPath_PropertyAddress, MakePlatformFilename_FunctionAddress, "InPath");
		MakePlatformFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(MakePlatformFilename_FunctionAddress, "InPath");
		MakePlatformFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePlatformFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePlatformFilename_OutPath_PropertyAddress, MakePlatformFilename_FunctionAddress, "OutPath");
		MakePlatformFilename_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(MakePlatformFilename_FunctionAddress, "OutPath");
		MakePlatformFilename_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePlatformFilename_FunctionAddress, "OutPath", Classes.FStrProperty);
		MakePlatformFilename_IsValid = MakePlatformFilename_FunctionAddress != IntPtr.Zero && MakePlatformFilename_InPath_IsValid && MakePlatformFilename_OutPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:MakePlatformFilename", MakePlatformFilename_IsValid);
		MakePathRelativeTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakePathRelativeTo");
		MakePathRelativeTo_ParamsSize = NativeReflection.GetFunctionParamsSize(MakePathRelativeTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakePathRelativeTo_InPath_PropertyAddress, MakePathRelativeTo_FunctionAddress, "InPath");
		MakePathRelativeTo_InPath_Offset = NativeReflectionCached.GetPropertyOffset(MakePathRelativeTo_FunctionAddress, "InPath");
		MakePathRelativeTo_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePathRelativeTo_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePathRelativeTo_InRelativeTo_PropertyAddress, MakePathRelativeTo_FunctionAddress, "InRelativeTo");
		MakePathRelativeTo_InRelativeTo_Offset = NativeReflectionCached.GetPropertyOffset(MakePathRelativeTo_FunctionAddress, "InRelativeTo");
		MakePathRelativeTo_InRelativeTo_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePathRelativeTo_FunctionAddress, "InRelativeTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePathRelativeTo_OutPath_PropertyAddress, MakePathRelativeTo_FunctionAddress, "OutPath");
		MakePathRelativeTo_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(MakePathRelativeTo_FunctionAddress, "OutPath");
		MakePathRelativeTo_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePathRelativeTo_FunctionAddress, "OutPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePathRelativeTo_ReturnValue_PropertyAddress, MakePathRelativeTo_FunctionAddress, "ReturnValue");
		MakePathRelativeTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakePathRelativeTo_FunctionAddress, "ReturnValue");
		MakePathRelativeTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePathRelativeTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakePathRelativeTo_IsValid = MakePathRelativeTo_FunctionAddress != IntPtr.Zero && MakePathRelativeTo_InPath_IsValid && MakePathRelativeTo_InRelativeTo_IsValid && MakePathRelativeTo_OutPath_IsValid && MakePathRelativeTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:MakePathRelativeTo", MakePathRelativeTo_IsValid);
		LaunchDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LaunchDir");
		LaunchDir_ParamsSize = NativeReflection.GetFunctionParamsSize(LaunchDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LaunchDir_ReturnValue_PropertyAddress, LaunchDir_FunctionAddress, "ReturnValue");
		LaunchDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LaunchDir_FunctionAddress, "ReturnValue");
		LaunchDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		LaunchDir_IsValid = LaunchDir_FunctionAddress != IntPtr.Zero && LaunchDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:LaunchDir", LaunchDir_IsValid);
		IsSamePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSamePath");
		IsSamePath_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSamePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSamePath_PathA_PropertyAddress, IsSamePath_FunctionAddress, "PathA");
		IsSamePath_PathA_Offset = NativeReflectionCached.GetPropertyOffset(IsSamePath_FunctionAddress, "PathA");
		IsSamePath_PathA_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSamePath_FunctionAddress, "PathA", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSamePath_PathB_PropertyAddress, IsSamePath_FunctionAddress, "PathB");
		IsSamePath_PathB_Offset = NativeReflectionCached.GetPropertyOffset(IsSamePath_FunctionAddress, "PathB");
		IsSamePath_PathB_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSamePath_FunctionAddress, "PathB", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSamePath_ReturnValue_PropertyAddress, IsSamePath_FunctionAddress, "ReturnValue");
		IsSamePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSamePath_FunctionAddress, "ReturnValue");
		IsSamePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSamePath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSamePath_IsValid = IsSamePath_FunctionAddress != IntPtr.Zero && IsSamePath_PathA_IsValid && IsSamePath_PathB_IsValid && IsSamePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:IsSamePath", IsSamePath_IsValid);
		IsRestrictedPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRestrictedPath");
		IsRestrictedPath_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRestrictedPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRestrictedPath_InPath_PropertyAddress, IsRestrictedPath_FunctionAddress, "InPath");
		IsRestrictedPath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(IsRestrictedPath_FunctionAddress, "InPath");
		IsRestrictedPath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRestrictedPath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRestrictedPath_ReturnValue_PropertyAddress, IsRestrictedPath_FunctionAddress, "ReturnValue");
		IsRestrictedPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRestrictedPath_FunctionAddress, "ReturnValue");
		IsRestrictedPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRestrictedPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRestrictedPath_IsValid = IsRestrictedPath_FunctionAddress != IntPtr.Zero && IsRestrictedPath_InPath_IsValid && IsRestrictedPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:IsRestrictedPath", IsRestrictedPath_IsValid);
		IsRelative_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRelative");
		IsRelative_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRelative_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRelative_InPath_PropertyAddress, IsRelative_FunctionAddress, "InPath");
		IsRelative_InPath_Offset = NativeReflectionCached.GetPropertyOffset(IsRelative_FunctionAddress, "InPath");
		IsRelative_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRelative_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRelative_ReturnValue_PropertyAddress, IsRelative_FunctionAddress, "ReturnValue");
		IsRelative_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRelative_FunctionAddress, "ReturnValue");
		IsRelative_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRelative_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRelative_IsValid = IsRelative_FunctionAddress != IntPtr.Zero && IsRelative_InPath_IsValid && IsRelative_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:IsRelative", IsRelative_IsValid);
		IsProjectFilePathSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsProjectFilePathSet");
		IsProjectFilePathSet_ParamsSize = NativeReflection.GetFunctionParamsSize(IsProjectFilePathSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsProjectFilePathSet_ReturnValue_PropertyAddress, IsProjectFilePathSet_FunctionAddress, "ReturnValue");
		IsProjectFilePathSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsProjectFilePathSet_FunctionAddress, "ReturnValue");
		IsProjectFilePathSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsProjectFilePathSet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsProjectFilePathSet_IsValid = IsProjectFilePathSet_FunctionAddress != IntPtr.Zero && IsProjectFilePathSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:IsProjectFilePathSet", IsProjectFilePathSet_IsValid);
		IsDrive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDrive");
		IsDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDrive_InPath_PropertyAddress, IsDrive_FunctionAddress, "InPath");
		IsDrive_InPath_Offset = NativeReflectionCached.GetPropertyOffset(IsDrive_FunctionAddress, "InPath");
		IsDrive_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDrive_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDrive_ReturnValue_PropertyAddress, IsDrive_FunctionAddress, "ReturnValue");
		IsDrive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDrive_FunctionAddress, "ReturnValue");
		IsDrive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDrive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDrive_IsValid = IsDrive_FunctionAddress != IntPtr.Zero && IsDrive_InPath_IsValid && IsDrive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:IsDrive", IsDrive_IsValid);
		HasProjectPersistentDownloadDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasProjectPersistentDownloadDir");
		HasProjectPersistentDownloadDir_ParamsSize = NativeReflection.GetFunctionParamsSize(HasProjectPersistentDownloadDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasProjectPersistentDownloadDir_ReturnValue_PropertyAddress, HasProjectPersistentDownloadDir_FunctionAddress, "ReturnValue");
		HasProjectPersistentDownloadDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasProjectPersistentDownloadDir_FunctionAddress, "ReturnValue");
		HasProjectPersistentDownloadDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasProjectPersistentDownloadDir_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasProjectPersistentDownloadDir_IsValid = HasProjectPersistentDownloadDir_FunctionAddress != IntPtr.Zero && HasProjectPersistentDownloadDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:HasProjectPersistentDownloadDir", HasProjectPersistentDownloadDir_IsValid);
		GetToolTipLocalizationPaths_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetToolTipLocalizationPaths");
		GetToolTipLocalizationPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetToolTipLocalizationPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetToolTipLocalizationPaths_ReturnValue_PropertyAddress, GetToolTipLocalizationPaths_FunctionAddress, "ReturnValue");
		GetToolTipLocalizationPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetToolTipLocalizationPaths_FunctionAddress, "ReturnValue");
		GetToolTipLocalizationPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolTipLocalizationPaths_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetToolTipLocalizationPaths_IsValid = GetToolTipLocalizationPaths_FunctionAddress != IntPtr.Zero && GetToolTipLocalizationPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetToolTipLocalizationPaths", GetToolTipLocalizationPaths_IsValid);
		GetRestrictedFolderNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRestrictedFolderNames");
		GetRestrictedFolderNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRestrictedFolderNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRestrictedFolderNames_ReturnValue_PropertyAddress, GetRestrictedFolderNames_FunctionAddress, "ReturnValue");
		GetRestrictedFolderNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRestrictedFolderNames_FunctionAddress, "ReturnValue");
		GetRestrictedFolderNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRestrictedFolderNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetRestrictedFolderNames_IsValid = GetRestrictedFolderNames_FunctionAddress != IntPtr.Zero && GetRestrictedFolderNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetRestrictedFolderNames", GetRestrictedFolderNames_IsValid);
		GetRelativePathToRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRelativePathToRoot");
		GetRelativePathToRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRelativePathToRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRelativePathToRoot_ReturnValue_PropertyAddress, GetRelativePathToRoot_FunctionAddress, "ReturnValue");
		GetRelativePathToRoot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativePathToRoot_FunctionAddress, "ReturnValue");
		GetRelativePathToRoot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativePathToRoot_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetRelativePathToRoot_IsValid = GetRelativePathToRoot_FunctionAddress != IntPtr.Zero && GetRelativePathToRoot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetRelativePathToRoot", GetRelativePathToRoot_IsValid);
		GetPropertyNameLocalizationPaths_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPropertyNameLocalizationPaths");
		GetPropertyNameLocalizationPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPropertyNameLocalizationPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyNameLocalizationPaths_ReturnValue_PropertyAddress, GetPropertyNameLocalizationPaths_FunctionAddress, "ReturnValue");
		GetPropertyNameLocalizationPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyNameLocalizationPaths_FunctionAddress, "ReturnValue");
		GetPropertyNameLocalizationPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyNameLocalizationPaths_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPropertyNameLocalizationPaths_IsValid = GetPropertyNameLocalizationPaths_FunctionAddress != IntPtr.Zero && GetPropertyNameLocalizationPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetPropertyNameLocalizationPaths", GetPropertyNameLocalizationPaths_IsValid);
		GetProjectFilePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProjectFilePath");
		GetProjectFilePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectFilePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProjectFilePath_ReturnValue_PropertyAddress, GetProjectFilePath_FunctionAddress, "ReturnValue");
		GetProjectFilePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectFilePath_FunctionAddress, "ReturnValue");
		GetProjectFilePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectFilePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetProjectFilePath_IsValid = GetProjectFilePath_FunctionAddress != IntPtr.Zero && GetProjectFilePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetProjectFilePath", GetProjectFilePath_IsValid);
		GetPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPath");
		GetPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPath_InPath_PropertyAddress, GetPath_FunctionAddress, "InPath");
		GetPath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(GetPath_FunctionAddress, "InPath");
		GetPath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPath_ReturnValue_PropertyAddress, GetPath_FunctionAddress, "ReturnValue");
		GetPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPath_FunctionAddress, "ReturnValue");
		GetPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPath_IsValid = GetPath_FunctionAddress != IntPtr.Zero && GetPath_InPath_IsValid && GetPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetPath", GetPath_IsValid);
		GetInvalidFileSystemChars_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInvalidFileSystemChars");
		GetInvalidFileSystemChars_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInvalidFileSystemChars_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInvalidFileSystemChars_ReturnValue_PropertyAddress, GetInvalidFileSystemChars_FunctionAddress, "ReturnValue");
		GetInvalidFileSystemChars_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInvalidFileSystemChars_FunctionAddress, "ReturnValue");
		GetInvalidFileSystemChars_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInvalidFileSystemChars_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetInvalidFileSystemChars_IsValid = GetInvalidFileSystemChars_FunctionAddress != IntPtr.Zero && GetInvalidFileSystemChars_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetInvalidFileSystemChars", GetInvalidFileSystemChars_IsValid);
		GetGameLocalizationPaths_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameLocalizationPaths");
		GetGameLocalizationPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameLocalizationPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameLocalizationPaths_ReturnValue_PropertyAddress, GetGameLocalizationPaths_FunctionAddress, "ReturnValue");
		GetGameLocalizationPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameLocalizationPaths_FunctionAddress, "ReturnValue");
		GetGameLocalizationPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameLocalizationPaths_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetGameLocalizationPaths_IsValid = GetGameLocalizationPaths_FunctionAddress != IntPtr.Zero && GetGameLocalizationPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetGameLocalizationPaths", GetGameLocalizationPaths_IsValid);
		GetExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtension");
		GetExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtension_InPath_PropertyAddress, GetExtension_FunctionAddress, "InPath");
		GetExtension_InPath_Offset = NativeReflectionCached.GetPropertyOffset(GetExtension_FunctionAddress, "InPath");
		GetExtension_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtension_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtension_bIncludeDot_PropertyAddress, GetExtension_FunctionAddress, "bIncludeDot");
		GetExtension_bIncludeDot_Offset = NativeReflectionCached.GetPropertyOffset(GetExtension_FunctionAddress, "bIncludeDot");
		GetExtension_bIncludeDot_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtension_FunctionAddress, "bIncludeDot", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtension_ReturnValue_PropertyAddress, GetExtension_FunctionAddress, "ReturnValue");
		GetExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtension_FunctionAddress, "ReturnValue");
		GetExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtension_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetExtension_IsValid = GetExtension_FunctionAddress != IntPtr.Zero && GetExtension_InPath_IsValid && GetExtension_bIncludeDot_IsValid && GetExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetExtension", GetExtension_IsValid);
		GetEngineLocalizationPaths_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEngineLocalizationPaths");
		GetEngineLocalizationPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngineLocalizationPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngineLocalizationPaths_ReturnValue_PropertyAddress, GetEngineLocalizationPaths_FunctionAddress, "ReturnValue");
		GetEngineLocalizationPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineLocalizationPaths_FunctionAddress, "ReturnValue");
		GetEngineLocalizationPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineLocalizationPaths_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetEngineLocalizationPaths_IsValid = GetEngineLocalizationPaths_FunctionAddress != IntPtr.Zero && GetEngineLocalizationPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetEngineLocalizationPaths", GetEngineLocalizationPaths_IsValid);
		GetEditorLocalizationPaths_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorLocalizationPaths");
		GetEditorLocalizationPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorLocalizationPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorLocalizationPaths_ReturnValue_PropertyAddress, GetEditorLocalizationPaths_FunctionAddress, "ReturnValue");
		GetEditorLocalizationPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorLocalizationPaths_FunctionAddress, "ReturnValue");
		GetEditorLocalizationPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorLocalizationPaths_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetEditorLocalizationPaths_IsValid = GetEditorLocalizationPaths_FunctionAddress != IntPtr.Zero && GetEditorLocalizationPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetEditorLocalizationPaths", GetEditorLocalizationPaths_IsValid);
		GetCleanFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCleanFilename");
		GetCleanFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCleanFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCleanFilename_InPath_PropertyAddress, GetCleanFilename_FunctionAddress, "InPath");
		GetCleanFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(GetCleanFilename_FunctionAddress, "InPath");
		GetCleanFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCleanFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCleanFilename_ReturnValue_PropertyAddress, GetCleanFilename_FunctionAddress, "ReturnValue");
		GetCleanFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCleanFilename_FunctionAddress, "ReturnValue");
		GetCleanFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCleanFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCleanFilename_IsValid = GetCleanFilename_FunctionAddress != IntPtr.Zero && GetCleanFilename_InPath_IsValid && GetCleanFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetCleanFilename", GetCleanFilename_IsValid);
		GetBaseFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBaseFilename");
		GetBaseFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBaseFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBaseFilename_InPath_PropertyAddress, GetBaseFilename_FunctionAddress, "InPath");
		GetBaseFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseFilename_FunctionAddress, "InPath");
		GetBaseFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBaseFilename_bRemovePath_PropertyAddress, GetBaseFilename_FunctionAddress, "bRemovePath");
		GetBaseFilename_bRemovePath_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseFilename_FunctionAddress, "bRemovePath");
		GetBaseFilename_bRemovePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseFilename_FunctionAddress, "bRemovePath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBaseFilename_ReturnValue_PropertyAddress, GetBaseFilename_FunctionAddress, "ReturnValue");
		GetBaseFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseFilename_FunctionAddress, "ReturnValue");
		GetBaseFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetBaseFilename_IsValid = GetBaseFilename_FunctionAddress != IntPtr.Zero && GetBaseFilename_InPath_IsValid && GetBaseFilename_bRemovePath_IsValid && GetBaseFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GetBaseFilename", GetBaseFilename_IsValid);
		GeneratedConfigDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GeneratedConfigDir");
		GeneratedConfigDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratedConfigDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratedConfigDir_ReturnValue_PropertyAddress, GeneratedConfigDir_FunctionAddress, "ReturnValue");
		GeneratedConfigDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratedConfigDir_FunctionAddress, "ReturnValue");
		GeneratedConfigDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratedConfigDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GeneratedConfigDir_IsValid = GeneratedConfigDir_FunctionAddress != IntPtr.Zero && GeneratedConfigDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GeneratedConfigDir", GeneratedConfigDir_IsValid);
		GameUserDeveloperDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GameUserDeveloperDir");
		GameUserDeveloperDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GameUserDeveloperDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameUserDeveloperDir_ReturnValue_PropertyAddress, GameUserDeveloperDir_FunctionAddress, "ReturnValue");
		GameUserDeveloperDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GameUserDeveloperDir_FunctionAddress, "ReturnValue");
		GameUserDeveloperDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GameUserDeveloperDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GameUserDeveloperDir_IsValid = GameUserDeveloperDir_FunctionAddress != IntPtr.Zero && GameUserDeveloperDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GameUserDeveloperDir", GameUserDeveloperDir_IsValid);
		GameSourceDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GameSourceDir");
		GameSourceDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GameSourceDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameSourceDir_ReturnValue_PropertyAddress, GameSourceDir_FunctionAddress, "ReturnValue");
		GameSourceDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GameSourceDir_FunctionAddress, "ReturnValue");
		GameSourceDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GameSourceDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GameSourceDir_IsValid = GameSourceDir_FunctionAddress != IntPtr.Zero && GameSourceDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GameSourceDir", GameSourceDir_IsValid);
		GameDevelopersDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GameDevelopersDir");
		GameDevelopersDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GameDevelopersDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameDevelopersDir_ReturnValue_PropertyAddress, GameDevelopersDir_FunctionAddress, "ReturnValue");
		GameDevelopersDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GameDevelopersDir_FunctionAddress, "ReturnValue");
		GameDevelopersDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GameDevelopersDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GameDevelopersDir_IsValid = GameDevelopersDir_FunctionAddress != IntPtr.Zero && GameDevelopersDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GameDevelopersDir", GameDevelopersDir_IsValid);
		GameAgnosticSavedDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GameAgnosticSavedDir");
		GameAgnosticSavedDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GameAgnosticSavedDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameAgnosticSavedDir_ReturnValue_PropertyAddress, GameAgnosticSavedDir_FunctionAddress, "ReturnValue");
		GameAgnosticSavedDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GameAgnosticSavedDir_FunctionAddress, "ReturnValue");
		GameAgnosticSavedDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GameAgnosticSavedDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GameAgnosticSavedDir_IsValid = GameAgnosticSavedDir_FunctionAddress != IntPtr.Zero && GameAgnosticSavedDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:GameAgnosticSavedDir", GameAgnosticSavedDir_IsValid);
		FileExists_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FileExists");
		FileExists_ParamsSize = NativeReflection.GetFunctionParamsSize(FileExists_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FileExists_InPath_PropertyAddress, FileExists_FunctionAddress, "InPath");
		FileExists_InPath_Offset = NativeReflectionCached.GetPropertyOffset(FileExists_FunctionAddress, "InPath");
		FileExists_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FileExists_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FileExists_ReturnValue_PropertyAddress, FileExists_FunctionAddress, "ReturnValue");
		FileExists_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FileExists_FunctionAddress, "ReturnValue");
		FileExists_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FileExists_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FileExists_IsValid = FileExists_FunctionAddress != IntPtr.Zero && FileExists_InPath_IsValid && FileExists_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:FileExists", FileExists_IsValid);
		FeaturePackDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FeaturePackDir");
		FeaturePackDir_ParamsSize = NativeReflection.GetFunctionParamsSize(FeaturePackDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FeaturePackDir_ReturnValue_PropertyAddress, FeaturePackDir_FunctionAddress, "ReturnValue");
		FeaturePackDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FeaturePackDir_FunctionAddress, "ReturnValue");
		FeaturePackDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FeaturePackDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FeaturePackDir_IsValid = FeaturePackDir_FunctionAddress != IntPtr.Zero && FeaturePackDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:FeaturePackDir", FeaturePackDir_IsValid);
		EnterprisePluginsDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnterprisePluginsDir");
		EnterprisePluginsDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterprisePluginsDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnterprisePluginsDir_ReturnValue_PropertyAddress, EnterprisePluginsDir_FunctionAddress, "ReturnValue");
		EnterprisePluginsDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnterprisePluginsDir_FunctionAddress, "ReturnValue");
		EnterprisePluginsDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnterprisePluginsDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EnterprisePluginsDir_IsValid = EnterprisePluginsDir_FunctionAddress != IntPtr.Zero && EnterprisePluginsDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EnterprisePluginsDir", EnterprisePluginsDir_IsValid);
		EnterpriseFeaturePackDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnterpriseFeaturePackDir");
		EnterpriseFeaturePackDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterpriseFeaturePackDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnterpriseFeaturePackDir_ReturnValue_PropertyAddress, EnterpriseFeaturePackDir_FunctionAddress, "ReturnValue");
		EnterpriseFeaturePackDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnterpriseFeaturePackDir_FunctionAddress, "ReturnValue");
		EnterpriseFeaturePackDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnterpriseFeaturePackDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EnterpriseFeaturePackDir_IsValid = EnterpriseFeaturePackDir_FunctionAddress != IntPtr.Zero && EnterpriseFeaturePackDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EnterpriseFeaturePackDir", EnterpriseFeaturePackDir_IsValid);
		EnterpriseDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnterpriseDir");
		EnterpriseDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterpriseDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnterpriseDir_ReturnValue_PropertyAddress, EnterpriseDir_FunctionAddress, "ReturnValue");
		EnterpriseDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnterpriseDir_FunctionAddress, "ReturnValue");
		EnterpriseDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnterpriseDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EnterpriseDir_IsValid = EnterpriseDir_FunctionAddress != IntPtr.Zero && EnterpriseDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EnterpriseDir", EnterpriseDir_IsValid);
		EngineVersionAgnosticUserDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineVersionAgnosticUserDir");
		EngineVersionAgnosticUserDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineVersionAgnosticUserDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineVersionAgnosticUserDir_ReturnValue_PropertyAddress, EngineVersionAgnosticUserDir_FunctionAddress, "ReturnValue");
		EngineVersionAgnosticUserDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineVersionAgnosticUserDir_FunctionAddress, "ReturnValue");
		EngineVersionAgnosticUserDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineVersionAgnosticUserDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineVersionAgnosticUserDir_IsValid = EngineVersionAgnosticUserDir_FunctionAddress != IntPtr.Zero && EngineVersionAgnosticUserDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineVersionAgnosticUserDir", EngineVersionAgnosticUserDir_IsValid);
		EngineUserDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineUserDir");
		EngineUserDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineUserDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineUserDir_ReturnValue_PropertyAddress, EngineUserDir_FunctionAddress, "ReturnValue");
		EngineUserDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineUserDir_FunctionAddress, "ReturnValue");
		EngineUserDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineUserDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineUserDir_IsValid = EngineUserDir_FunctionAddress != IntPtr.Zero && EngineUserDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineUserDir", EngineUserDir_IsValid);
		EngineSourceDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineSourceDir");
		EngineSourceDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineSourceDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineSourceDir_ReturnValue_PropertyAddress, EngineSourceDir_FunctionAddress, "ReturnValue");
		EngineSourceDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineSourceDir_FunctionAddress, "ReturnValue");
		EngineSourceDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineSourceDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineSourceDir_IsValid = EngineSourceDir_FunctionAddress != IntPtr.Zero && EngineSourceDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineSourceDir", EngineSourceDir_IsValid);
		EngineSavedDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineSavedDir");
		EngineSavedDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineSavedDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineSavedDir_ReturnValue_PropertyAddress, EngineSavedDir_FunctionAddress, "ReturnValue");
		EngineSavedDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineSavedDir_FunctionAddress, "ReturnValue");
		EngineSavedDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineSavedDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineSavedDir_IsValid = EngineSavedDir_FunctionAddress != IntPtr.Zero && EngineSavedDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineSavedDir", EngineSavedDir_IsValid);
		EnginePluginsDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnginePluginsDir");
		EnginePluginsDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EnginePluginsDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnginePluginsDir_ReturnValue_PropertyAddress, EnginePluginsDir_FunctionAddress, "ReturnValue");
		EnginePluginsDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnginePluginsDir_FunctionAddress, "ReturnValue");
		EnginePluginsDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnginePluginsDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EnginePluginsDir_IsValid = EnginePluginsDir_FunctionAddress != IntPtr.Zero && EnginePluginsDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EnginePluginsDir", EnginePluginsDir_IsValid);
		EngineIntermediateDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineIntermediateDir");
		EngineIntermediateDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineIntermediateDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineIntermediateDir_ReturnValue_PropertyAddress, EngineIntermediateDir_FunctionAddress, "ReturnValue");
		EngineIntermediateDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineIntermediateDir_FunctionAddress, "ReturnValue");
		EngineIntermediateDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineIntermediateDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineIntermediateDir_IsValid = EngineIntermediateDir_FunctionAddress != IntPtr.Zero && EngineIntermediateDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineIntermediateDir", EngineIntermediateDir_IsValid);
		EngineDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineDir");
		EngineDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineDir_ReturnValue_PropertyAddress, EngineDir_FunctionAddress, "ReturnValue");
		EngineDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineDir_FunctionAddress, "ReturnValue");
		EngineDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineDir_IsValid = EngineDir_FunctionAddress != IntPtr.Zero && EngineDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineDir", EngineDir_IsValid);
		EngineContentDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineContentDir");
		EngineContentDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineContentDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineContentDir_ReturnValue_PropertyAddress, EngineContentDir_FunctionAddress, "ReturnValue");
		EngineContentDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineContentDir_FunctionAddress, "ReturnValue");
		EngineContentDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineContentDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineContentDir_IsValid = EngineContentDir_FunctionAddress != IntPtr.Zero && EngineContentDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineContentDir", EngineContentDir_IsValid);
		EngineConfigDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineConfigDir");
		EngineConfigDir_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineConfigDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineConfigDir_ReturnValue_PropertyAddress, EngineConfigDir_FunctionAddress, "ReturnValue");
		EngineConfigDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineConfigDir_FunctionAddress, "ReturnValue");
		EngineConfigDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineConfigDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineConfigDir_IsValid = EngineConfigDir_FunctionAddress != IntPtr.Zero && EngineConfigDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:EngineConfigDir", EngineConfigDir_IsValid);
		DirectoryExists_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DirectoryExists");
		DirectoryExists_ParamsSize = NativeReflection.GetFunctionParamsSize(DirectoryExists_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DirectoryExists_InPath_PropertyAddress, DirectoryExists_FunctionAddress, "InPath");
		DirectoryExists_InPath_Offset = NativeReflectionCached.GetPropertyOffset(DirectoryExists_FunctionAddress, "InPath");
		DirectoryExists_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectoryExists_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DirectoryExists_ReturnValue_PropertyAddress, DirectoryExists_FunctionAddress, "ReturnValue");
		DirectoryExists_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DirectoryExists_FunctionAddress, "ReturnValue");
		DirectoryExists_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectoryExists_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DirectoryExists_IsValid = DirectoryExists_FunctionAddress != IntPtr.Zero && DirectoryExists_InPath_IsValid && DirectoryExists_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:DirectoryExists", DirectoryExists_IsValid);
		DiffDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DiffDir");
		DiffDir_ParamsSize = NativeReflection.GetFunctionParamsSize(DiffDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DiffDir_ReturnValue_PropertyAddress, DiffDir_FunctionAddress, "ReturnValue");
		DiffDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DiffDir_FunctionAddress, "ReturnValue");
		DiffDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DiffDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		DiffDir_IsValid = DiffDir_FunctionAddress != IntPtr.Zero && DiffDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:DiffDir", DiffDir_IsValid);
		CreateTempFilename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTempFilename");
		CreateTempFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTempFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTempFilename_Path_PropertyAddress, CreateTempFilename_FunctionAddress, "Path");
		CreateTempFilename_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateTempFilename_FunctionAddress, "Path");
		CreateTempFilename_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTempFilename_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTempFilename_Prefix_PropertyAddress, CreateTempFilename_FunctionAddress, "Prefix");
		CreateTempFilename_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(CreateTempFilename_FunctionAddress, "Prefix");
		CreateTempFilename_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTempFilename_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTempFilename_Extension_PropertyAddress, CreateTempFilename_FunctionAddress, "Extension");
		CreateTempFilename_Extension_Offset = NativeReflectionCached.GetPropertyOffset(CreateTempFilename_FunctionAddress, "Extension");
		CreateTempFilename_Extension_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTempFilename_FunctionAddress, "Extension", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTempFilename_ReturnValue_PropertyAddress, CreateTempFilename_FunctionAddress, "ReturnValue");
		CreateTempFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTempFilename_FunctionAddress, "ReturnValue");
		CreateTempFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTempFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CreateTempFilename_IsValid = CreateTempFilename_FunctionAddress != IntPtr.Zero && CreateTempFilename_Path_IsValid && CreateTempFilename_Prefix_IsValid && CreateTempFilename_Extension_IsValid && CreateTempFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:CreateTempFilename", CreateTempFilename_IsValid);
		ConvertToSandboxPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSandboxPath");
		ConvertToSandboxPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSandboxPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSandboxPath_InPath_PropertyAddress, ConvertToSandboxPath_FunctionAddress, "InPath");
		ConvertToSandboxPath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSandboxPath_FunctionAddress, "InPath");
		ConvertToSandboxPath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSandboxPath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSandboxPath_InSandboxName_PropertyAddress, ConvertToSandboxPath_FunctionAddress, "InSandboxName");
		ConvertToSandboxPath_InSandboxName_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSandboxPath_FunctionAddress, "InSandboxName");
		ConvertToSandboxPath_InSandboxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSandboxPath_FunctionAddress, "InSandboxName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSandboxPath_ReturnValue_PropertyAddress, ConvertToSandboxPath_FunctionAddress, "ReturnValue");
		ConvertToSandboxPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSandboxPath_FunctionAddress, "ReturnValue");
		ConvertToSandboxPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSandboxPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ConvertToSandboxPath_IsValid = ConvertToSandboxPath_FunctionAddress != IntPtr.Zero && ConvertToSandboxPath_InPath_IsValid && ConvertToSandboxPath_InSandboxName_IsValid && ConvertToSandboxPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ConvertToSandboxPath", ConvertToSandboxPath_IsValid);
		ConvertRelativePathToFull_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertRelativePathToFull");
		ConvertRelativePathToFull_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertRelativePathToFull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertRelativePathToFull_InPath_PropertyAddress, ConvertRelativePathToFull_FunctionAddress, "InPath");
		ConvertRelativePathToFull_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRelativePathToFull_FunctionAddress, "InPath");
		ConvertRelativePathToFull_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRelativePathToFull_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertRelativePathToFull_InBasePath_PropertyAddress, ConvertRelativePathToFull_FunctionAddress, "InBasePath");
		ConvertRelativePathToFull_InBasePath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRelativePathToFull_FunctionAddress, "InBasePath");
		ConvertRelativePathToFull_InBasePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRelativePathToFull_FunctionAddress, "InBasePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertRelativePathToFull_ReturnValue_PropertyAddress, ConvertRelativePathToFull_FunctionAddress, "ReturnValue");
		ConvertRelativePathToFull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRelativePathToFull_FunctionAddress, "ReturnValue");
		ConvertRelativePathToFull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRelativePathToFull_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ConvertRelativePathToFull_IsValid = ConvertRelativePathToFull_FunctionAddress != IntPtr.Zero && ConvertRelativePathToFull_InPath_IsValid && ConvertRelativePathToFull_InBasePath_IsValid && ConvertRelativePathToFull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ConvertRelativePathToFull", ConvertRelativePathToFull_IsValid);
		ConvertFromSandboxPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertFromSandboxPath");
		ConvertFromSandboxPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertFromSandboxPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertFromSandboxPath_InPath_PropertyAddress, ConvertFromSandboxPath_FunctionAddress, "InPath");
		ConvertFromSandboxPath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertFromSandboxPath_FunctionAddress, "InPath");
		ConvertFromSandboxPath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertFromSandboxPath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertFromSandboxPath_InSandboxName_PropertyAddress, ConvertFromSandboxPath_FunctionAddress, "InSandboxName");
		ConvertFromSandboxPath_InSandboxName_Offset = NativeReflectionCached.GetPropertyOffset(ConvertFromSandboxPath_FunctionAddress, "InSandboxName");
		ConvertFromSandboxPath_InSandboxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertFromSandboxPath_FunctionAddress, "InSandboxName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertFromSandboxPath_ReturnValue_PropertyAddress, ConvertFromSandboxPath_FunctionAddress, "ReturnValue");
		ConvertFromSandboxPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertFromSandboxPath_FunctionAddress, "ReturnValue");
		ConvertFromSandboxPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertFromSandboxPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ConvertFromSandboxPath_IsValid = ConvertFromSandboxPath_FunctionAddress != IntPtr.Zero && ConvertFromSandboxPath_InPath_IsValid && ConvertFromSandboxPath_InSandboxName_IsValid && ConvertFromSandboxPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ConvertFromSandboxPath", ConvertFromSandboxPath_IsValid);
		Combine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Combine");
		Combine_ParamsSize = NativeReflection.GetFunctionParamsSize(Combine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Combine_InPaths_PropertyAddress, Combine_FunctionAddress, "InPaths");
		Combine_InPaths_Offset = NativeReflectionCached.GetPropertyOffset(Combine_FunctionAddress, "InPaths");
		Combine_InPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(Combine_FunctionAddress, "InPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Combine_ReturnValue_PropertyAddress, Combine_FunctionAddress, "ReturnValue");
		Combine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Combine_FunctionAddress, "ReturnValue");
		Combine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Combine_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Combine_IsValid = Combine_FunctionAddress != IntPtr.Zero && Combine_InPaths_IsValid && Combine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:Combine", Combine_IsValid);
		CollapseRelativeDirectories_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CollapseRelativeDirectories");
		CollapseRelativeDirectories_ParamsSize = NativeReflection.GetFunctionParamsSize(CollapseRelativeDirectories_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CollapseRelativeDirectories_InPath_PropertyAddress, CollapseRelativeDirectories_FunctionAddress, "InPath");
		CollapseRelativeDirectories_InPath_Offset = NativeReflectionCached.GetPropertyOffset(CollapseRelativeDirectories_FunctionAddress, "InPath");
		CollapseRelativeDirectories_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseRelativeDirectories_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseRelativeDirectories_OutPath_PropertyAddress, CollapseRelativeDirectories_FunctionAddress, "OutPath");
		CollapseRelativeDirectories_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(CollapseRelativeDirectories_FunctionAddress, "OutPath");
		CollapseRelativeDirectories_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseRelativeDirectories_FunctionAddress, "OutPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseRelativeDirectories_ReturnValue_PropertyAddress, CollapseRelativeDirectories_FunctionAddress, "ReturnValue");
		CollapseRelativeDirectories_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CollapseRelativeDirectories_FunctionAddress, "ReturnValue");
		CollapseRelativeDirectories_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseRelativeDirectories_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CollapseRelativeDirectories_IsValid = CollapseRelativeDirectories_FunctionAddress != IntPtr.Zero && CollapseRelativeDirectories_InPath_IsValid && CollapseRelativeDirectories_OutPath_IsValid && CollapseRelativeDirectories_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:CollapseRelativeDirectories", CollapseRelativeDirectories_IsValid);
		CloudDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloudDir");
		CloudDir_ParamsSize = NativeReflection.GetFunctionParamsSize(CloudDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloudDir_ReturnValue_PropertyAddress, CloudDir_FunctionAddress, "ReturnValue");
		CloudDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloudDir_FunctionAddress, "ReturnValue");
		CloudDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloudDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CloudDir_IsValid = CloudDir_FunctionAddress != IntPtr.Zero && CloudDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:CloudDir", CloudDir_IsValid);
		ChangeExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ChangeExtension");
		ChangeExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeExtension_InPath_PropertyAddress, ChangeExtension_FunctionAddress, "InPath");
		ChangeExtension_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExtension_FunctionAddress, "InPath");
		ChangeExtension_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExtension_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExtension_InNewExtension_PropertyAddress, ChangeExtension_FunctionAddress, "InNewExtension");
		ChangeExtension_InNewExtension_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExtension_FunctionAddress, "InNewExtension");
		ChangeExtension_InNewExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExtension_FunctionAddress, "InNewExtension", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExtension_ReturnValue_PropertyAddress, ChangeExtension_FunctionAddress, "ReturnValue");
		ChangeExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExtension_FunctionAddress, "ReturnValue");
		ChangeExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExtension_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ChangeExtension_IsValid = ChangeExtension_FunctionAddress != IntPtr.Zero && ChangeExtension_InPath_IsValid && ChangeExtension_InNewExtension_IsValid && ChangeExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:ChangeExtension", ChangeExtension_IsValid);
		BugItDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BugItDir");
		BugItDir_ParamsSize = NativeReflection.GetFunctionParamsSize(BugItDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BugItDir_ReturnValue_PropertyAddress, BugItDir_FunctionAddress, "ReturnValue");
		BugItDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BugItDir_FunctionAddress, "ReturnValue");
		BugItDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BugItDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BugItDir_IsValid = BugItDir_FunctionAddress != IntPtr.Zero && BugItDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:BugItDir", BugItDir_IsValid);
		AutomationTransientDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutomationTransientDir");
		AutomationTransientDir_ParamsSize = NativeReflection.GetFunctionParamsSize(AutomationTransientDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutomationTransientDir_ReturnValue_PropertyAddress, AutomationTransientDir_FunctionAddress, "ReturnValue");
		AutomationTransientDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutomationTransientDir_FunctionAddress, "ReturnValue");
		AutomationTransientDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationTransientDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AutomationTransientDir_IsValid = AutomationTransientDir_FunctionAddress != IntPtr.Zero && AutomationTransientDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:AutomationTransientDir", AutomationTransientDir_IsValid);
		AutomationLogDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutomationLogDir");
		AutomationLogDir_ParamsSize = NativeReflection.GetFunctionParamsSize(AutomationLogDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutomationLogDir_ReturnValue_PropertyAddress, AutomationLogDir_FunctionAddress, "ReturnValue");
		AutomationLogDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutomationLogDir_FunctionAddress, "ReturnValue");
		AutomationLogDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationLogDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AutomationLogDir_IsValid = AutomationLogDir_FunctionAddress != IntPtr.Zero && AutomationLogDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:AutomationLogDir", AutomationLogDir_IsValid);
		AutomationDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutomationDir");
		AutomationDir_ParamsSize = NativeReflection.GetFunctionParamsSize(AutomationDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutomationDir_ReturnValue_PropertyAddress, AutomationDir_FunctionAddress, "ReturnValue");
		AutomationDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutomationDir_FunctionAddress, "ReturnValue");
		AutomationDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AutomationDir_IsValid = AutomationDir_FunctionAddress != IntPtr.Zero && AutomationDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPathsLibrary:AutomationDir", AutomationDir_IsValid);
	}
}
