using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FPaths
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldSaveToUserDir();

	[MonoNativeFunctionWrapper]
	public delegate void Del_LaunchDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineUserDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineVersionAgnosticUserDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineContentDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineConfigDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineIntermediateDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineSavedDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EnginePluginsDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RootDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectUserDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectContentDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectConfigDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectSavedDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectIntermediateDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectPluginsDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectPersistentDownloadDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SourceConfigDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GeneratedConfigDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SandboxesDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProfilingDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ScreenShotDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BugItDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_VideoCaptureDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProjectLogDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AutomationDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AutomationTransientDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AutomationLogDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CloudDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameDevelopersDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameUserDeveloperDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DiffDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetEngineLocalizationPaths();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetEditorLocalizationPaths();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetPropertyNameLocalizationPaths();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetToolTipLocalizationPaths();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetGameLocalizationPaths();

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameAgnosticSavedDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EngineSourceDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameSourceDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FeaturePackDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsProjectFilePathSet();

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetProjectFilePath(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetProjectFilePath(ref FScriptArray newGameProjectFilePath);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetExtension(ref FScriptArray inPath, csbool includeDot, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCleanFilename(ref FScriptArray inPath, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetBaseFilename(ref FScriptArray inPath, csbool removePath, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPath(ref FScriptArray inPath, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ChangeExtension(ref FScriptArray inPath, ref FScriptArray inNewExtension, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_FileExists(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_DirectoryExists(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsDrive(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRelative(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate void Del_NormalizeFilename(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsSamePath(ref FScriptArray pathA, ref FScriptArray pathB);

	[MonoNativeFunctionWrapper]
	public delegate void Del_NormalizeDirectoryName(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CollapseRelativeDirectories(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveDuplicateSlashes(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeStandardFilename(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakePlatformFilename(ref FScriptArray inPath);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_MakePathRelativeTo(ref FScriptArray inPath, ref FScriptArray inRelativeTo);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConvertRelativePathToFull(ref FScriptArray inPath, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConvertRelativePathToFullBase(ref FScriptArray basePath, ref FScriptArray inPath, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConvertToSandboxPath(ref FScriptArray inPath, ref FScriptArray inSandboxName, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConvertFromSandboxPath(ref FScriptArray inPath, ref FScriptArray inSandboxName, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateTempFilename(ref FScriptArray path, ref FScriptArray prefix, ref FScriptArray extension, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ValidatePath(ref FScriptArray inPath, ref FScriptArray outReason);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Split(ref FScriptArray inPath, ref FScriptArray pathPart, ref FScriptArray filenamePart, ref FScriptArray extensionPart);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetRelativePathToRoot(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Combine(ref FScriptArray pathA, ref FScriptArray pathB, ref FScriptArray result);

	public static Del_ShouldSaveToUserDir ShouldSaveToUserDir;

	public static Del_LaunchDir LaunchDir;

	public static Del_EngineDir EngineDir;

	public static Del_EngineUserDir EngineUserDir;

	public static Del_EngineVersionAgnosticUserDir EngineVersionAgnosticUserDir;

	public static Del_EngineContentDir EngineContentDir;

	public static Del_EngineConfigDir EngineConfigDir;

	public static Del_EngineIntermediateDir EngineIntermediateDir;

	public static Del_EngineSavedDir EngineSavedDir;

	public static Del_EnginePluginsDir EnginePluginsDir;

	public static Del_RootDir RootDir;

	public static Del_ProjectDir ProjectDir;

	public static Del_ProjectUserDir ProjectUserDir;

	public static Del_ProjectContentDir ProjectContentDir;

	public static Del_ProjectConfigDir ProjectConfigDir;

	public static Del_ProjectSavedDir ProjectSavedDir;

	public static Del_ProjectIntermediateDir ProjectIntermediateDir;

	public static Del_ProjectPluginsDir ProjectPluginsDir;

	public static Del_ProjectPersistentDownloadDir ProjectPersistentDownloadDir;

	public static Del_SourceConfigDir SourceConfigDir;

	public static Del_GeneratedConfigDir GeneratedConfigDir;

	public static Del_SandboxesDir SandboxesDir;

	public static Del_ProfilingDir ProfilingDir;

	public static Del_ScreenShotDir ScreenShotDir;

	public static Del_BugItDir BugItDir;

	public static Del_VideoCaptureDir VideoCaptureDir;

	public static Del_ProjectLogDir ProjectLogDir;

	public static Del_AutomationDir AutomationDir;

	public static Del_AutomationTransientDir AutomationTransientDir;

	public static Del_AutomationLogDir AutomationLogDir;

	public static Del_CloudDir CloudDir;

	public static Del_GameDevelopersDir GameDevelopersDir;

	public static Del_GameUserDeveloperDir GameUserDeveloperDir;

	public static Del_DiffDir DiffDir;

	public static Del_GetEngineLocalizationPaths GetEngineLocalizationPaths;

	public static Del_GetEditorLocalizationPaths GetEditorLocalizationPaths;

	public static Del_GetPropertyNameLocalizationPaths GetPropertyNameLocalizationPaths;

	public static Del_GetToolTipLocalizationPaths GetToolTipLocalizationPaths;

	public static Del_GetGameLocalizationPaths GetGameLocalizationPaths;

	public static Del_GameAgnosticSavedDir GameAgnosticSavedDir;

	public static Del_EngineSourceDir EngineSourceDir;

	public static Del_GameSourceDir GameSourceDir;

	public static Del_FeaturePackDir FeaturePackDir;

	public static Del_IsProjectFilePathSet IsProjectFilePathSet;

	public static Del_GetProjectFilePath GetProjectFilePath;

	public static Del_SetProjectFilePath SetProjectFilePath;

	public static Del_GetExtension GetExtension;

	public static Del_GetCleanFilename GetCleanFilename;

	public static Del_GetBaseFilename GetBaseFilename;

	public static Del_GetPath GetPath;

	public static Del_ChangeExtension ChangeExtension;

	public static Del_FileExists FileExists;

	public static Del_DirectoryExists DirectoryExists;

	public static Del_IsDrive IsDrive;

	public static Del_IsRelative IsRelative;

	public static Del_NormalizeFilename NormalizeFilename;

	public static Del_IsSamePath IsSamePath;

	public static Del_NormalizeDirectoryName NormalizeDirectoryName;

	public static Del_CollapseRelativeDirectories CollapseRelativeDirectories;

	public static Del_RemoveDuplicateSlashes RemoveDuplicateSlashes;

	public static Del_MakeStandardFilename MakeStandardFilename;

	public static Del_MakePlatformFilename MakePlatformFilename;

	public static Del_MakePathRelativeTo MakePathRelativeTo;

	public static Del_ConvertRelativePathToFull ConvertRelativePathToFull;

	public static Del_ConvertRelativePathToFullBase ConvertRelativePathToFullBase;

	public static Del_ConvertToSandboxPath ConvertToSandboxPath;

	public static Del_ConvertFromSandboxPath ConvertFromSandboxPath;

	public static Del_CreateTempFilename CreateTempFilename;

	public static Del_ValidatePath ValidatePath;

	public static Del_Split Split;

	public static Del_GetRelativePathToRoot GetRelativePathToRoot;

	public static Del_Combine Combine;
}
