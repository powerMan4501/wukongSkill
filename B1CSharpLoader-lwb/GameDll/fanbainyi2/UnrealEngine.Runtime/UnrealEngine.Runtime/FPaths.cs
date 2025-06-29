using System;
using System.IO;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FPaths
{
	public static bool ShouldSaveToUserDir => Native_FPaths.ShouldSaveToUserDir();

	public static string LaunchDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.LaunchDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineUserDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineUserDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineVersionAgnosticUserDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineVersionAgnosticUserDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineContentDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineContentDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineConfigDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineConfigDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineIntermediateDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineIntermediateDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineSavedDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineSavedDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EnginePluginsDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EnginePluginsDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string RootDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.RootDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectUserDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectUserDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectContentDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectContentDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectConfigDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectConfigDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectSavedDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectSavedDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectIntermediateDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectIntermediateDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectPluginsDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectPluginsDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectPersistentDownloadDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectPersistentDownloadDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string SourceConfigDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.SourceConfigDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GeneratedConfigDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GeneratedConfigDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string SandboxesDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.SandboxesDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProfilingDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProfilingDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ScreenShotDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ScreenShotDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string BugItDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.BugItDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string VideoCaptureDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.VideoCaptureDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ProjectLogDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.ProjectLogDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string AutomationDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.AutomationDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string AutomationTransientDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.AutomationTransientDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string AutomationLogDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.AutomationLogDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string CloudDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.CloudDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameDevelopersDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GameDevelopersDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameUserDeveloperDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GameUserDeveloperDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string DiffDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.DiffDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameAgnosticSavedDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GameAgnosticSavedDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EngineSourceDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.EngineSourceDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameSourceDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GameSourceDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string FeaturePackDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.FeaturePackDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static bool IsProjectFilePathSet => Native_FPaths.IsProjectFilePathSet();

	public static string ProjectFilePath
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FPaths.GetProjectFilePath(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string[] GetEngineLocalizationPaths()
	{
		return GetStringArray(Native_FPaths.GetEngineLocalizationPaths());
	}

	public static string[] GetEditorLocalizationPaths()
	{
		return GetStringArray(Native_FPaths.GetEditorLocalizationPaths());
	}

	public static string[] GetPropertyNameLocalizationPaths()
	{
		return GetStringArray(Native_FPaths.GetPropertyNameLocalizationPaths());
	}

	public static string[] GetToolTipLocalizationPaths()
	{
		return GetStringArray(Native_FPaths.GetToolTipLocalizationPaths());
	}

	public static string[] GetGameLocalizationPaths()
	{
		return GetStringArray(Native_FPaths.GetGameLocalizationPaths());
	}

	public static void SetProjectFilePath(string newGameProjectFilePath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(newGameProjectFilePath);
		Native_FPaths.SetProjectFilePath(ref fStringUnsafe.Array);
	}

	public static string GetExtension(string inPath, bool includeDot = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPaths.GetExtension(ref fStringUnsafe.Array, includeDot, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetCleanFilename(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPaths.GetCleanFilename(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetBaseFilename(string inPath, bool removePath = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPaths.GetBaseFilename(ref fStringUnsafe.Array, removePath, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetPath(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPaths.GetPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string ChangeExtension(string inPath, string inNewExtension)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inNewExtension);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPaths.ChangeExtension(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static bool FileExists(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		return Native_FPaths.FileExists(ref fStringUnsafe.Array);
	}

	public static bool DirectoryExists(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		return Native_FPaths.DirectoryExists(ref fStringUnsafe.Array);
	}

	public static void MakeDirectory(string inPath)
	{
		Directory.CreateDirectory(inPath);
	}

	public static bool IsDrive(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		return Native_FPaths.IsDrive(ref fStringUnsafe.Array);
	}

	public static bool IsRelative(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		return Native_FPaths.IsRelative(ref fStringUnsafe.Array);
	}

	public static string NormalizeFilename(string inPath)
	{
		NormalizeFilename(ref inPath);
		return inPath;
	}

	public static void NormalizeFilename(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		Native_FPaths.NormalizeFilename(ref fStringUnsafe.Array);
		inPath = fStringUnsafe.Value;
	}

	public static bool IsSamePath(string pathA, string pathB)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(pathA);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(pathB);
		return Native_FPaths.IsSamePath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static void NormalizeDirectoryName(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		Native_FPaths.NormalizeDirectoryName(ref fStringUnsafe.Array);
		fStringUnsafe.Value = inPath;
	}

	public static bool CollapseRelativeDirectories(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		bool result = Native_FPaths.CollapseRelativeDirectories(ref fStringUnsafe.Array);
		fStringUnsafe.Value = inPath;
		return result;
	}

	public static void RemoveDuplicateSlashes(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		Native_FPaths.RemoveDuplicateSlashes(ref fStringUnsafe.Array);
		fStringUnsafe.Value = inPath;
	}

	public static void MakeStandardFilename(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		Native_FPaths.MakeStandardFilename(ref fStringUnsafe.Array);
		fStringUnsafe.Value = inPath;
	}

	public static void MakePlatformFilename(ref string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		Native_FPaths.MakePlatformFilename(ref fStringUnsafe.Array);
		fStringUnsafe.Value = inPath;
	}

	public static string MakePathRelativeTo(string inPath, string inRelativeTo)
	{
		string inPath2 = inPath;
		if (MakePathRelativeTo(ref inPath2, inRelativeTo))
		{
			return inPath2;
		}
		return inPath;
	}

	public static bool MakePathRelativeTo(ref string inPath, string inRelativeTo)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inRelativeTo);
		bool result = Native_FPaths.MakePathRelativeTo(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		inPath = fStringUnsafe.Value;
		return result;
	}

	public static string ConvertRelativePathToFull(string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPaths.ConvertRelativePathToFull(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string ConvertRelativePathToFull(string basePath, string inPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(basePath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPaths.ConvertRelativePathToFullBase(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static string ConvertToSandboxPath(string inPath, string inSandboxName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inSandboxName);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPaths.ConvertFromSandboxPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static string ConvertFromSandboxPath(string inPath, string inSandboxName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inSandboxName);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPaths.ConvertFromSandboxPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static string CreateTempFilename(string path, string prefix = "", string extension = ".tmp")
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(path);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(prefix);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe(extension);
		using FStringUnsafe fStringUnsafe4 = new FStringUnsafe();
		Native_FPaths.CreateTempFilename(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array, ref fStringUnsafe4.Array);
		return fStringUnsafe4.Value;
	}

	public static bool ValidatePath(string inPath, out string reason)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(inPath);
		bool result = Native_FPaths.ValidatePath(ref fStringUnsafe2.Array, ref fStringUnsafe.Array);
		reason = fStringUnsafe.Value;
		return result;
	}

	public static void Split(string inPath, ref string pathPart, ref string filenamePart, ref string extensionPart)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(pathPart);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe(filenamePart);
		using FStringUnsafe fStringUnsafe4 = new FStringUnsafe(extensionPart);
		Native_FPaths.Split(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array, ref fStringUnsafe4.Array);
	}

	public static string GetRelativePathToRoot()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPaths.GetRelativePathToRoot(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string Combine(params string[] paths)
	{
		if (paths != null && paths.Length != 0)
		{
			string text = paths[0];
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
			using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
			for (int i = 1; i < paths.Length; i++)
			{
				fStringUnsafe.Value = text;
				fStringUnsafe2.Value = paths[i];
				Native_FPaths.Combine(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
				text = fStringUnsafe3.Value;
			}
			return text;
		}
		return null;
	}

	private static string[] GetStringArray(IntPtr stringArray)
	{
		return new TArrayUnsafeRef<string>(stringArray).ToArray();
	}

	public static bool IsFileInDirectoryOrSubDirectory(string filePath, string directory)
	{
		return IsSameOrSubDirectory(directory, Path.GetDirectoryName(filePath));
	}

	public static bool IsSameOrSubDirectory(string basePath, string path)
	{
		string subDirectory;
		return IsSameOrSubDirectory(basePath, path, out subDirectory);
	}

	public static bool IsSameOrSubDirectory(string basePath, string path, out string subDirectory)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetFullPath(path).TrimEnd('\\', '/'));
		DirectoryInfo directoryInfo2 = new DirectoryInfo(Path.GetFullPath(basePath).TrimEnd('\\', '/'));
		subDirectory = null;
		while (directoryInfo != null)
		{
			if (directoryInfo.FullName.Equals(directoryInfo2.FullName, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			if (string.IsNullOrEmpty(subDirectory))
			{
				subDirectory = directoryInfo.Name;
			}
			else
			{
				subDirectory = Path.Combine(directoryInfo.Name, subDirectory);
			}
			directoryInfo = directoryInfo.Parent;
		}
		return false;
	}
}
