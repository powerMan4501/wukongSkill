using System;
using System.Linq;
using System.Text;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FPackageName
{
	public static char SubobjectDelimiter = ':';

	public static char[] InvalidNameChars = "\"' ,\n\r\t".ToCharArray();

	public static char[] InvalidObjectNameCharacters = "\"' ,/.:|&!~\n\r\t@#(){}[]=;^%$`".ToCharArray();

	public static char[] InvalidObjectPathCharacters = "\"' ,|&!~\n\r\t@#(){}[]=;^%$`".ToCharArray();

	public static char[] InvalidLongPackageCharacters = "\\:*?\"<>|' ,.&!~\n\r\t@#".ToCharArray();

	public static char[] ValidSavedDirSuffixCharacters = "_0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

	public static string ConvertToLongScriptPackageName(string shortName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(shortName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.ConvertToLongScriptPackageName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static void RegisterShortPackageNamesForUObjectModules()
	{
		Native_FPackageName.RegisterShortPackageNamesForUObjectModules();
	}

	public static bool FindScriptPackageName(FName shortName, out FName scriptPackageName)
	{
		return Native_FPackageName.FindScriptPackageName(ref shortName, out scriptPackageName);
	}

	public static bool TryConvertFilenameToLongPackageName(string filename, out string packageName)
	{
		string failureReason;
		return TryConvertFilenameToLongPackageName(filename, out packageName, out failureReason);
	}

	public static bool TryConvertFilenameToLongPackageName(string filename, out string packageName, out string failureReason)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(filename);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FPackageName.TryConvertFilenameToLongPackageName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		packageName = fStringUnsafe2.Value;
		failureReason = fStringUnsafe3.Value;
		return result;
	}

	public static string FilenameToLongPackageName(string filename)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(filename);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.FilenameToLongPackageName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static bool TryConvertLongPackageNameToFilename(string longPackageName, out string filename, string extension = "")
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe(extension);
		bool result = Native_FPackageName.TryConvertLongPackageNameToFilename(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		filename = fStringUnsafe2.Value;
		return result;
	}

	public static string LongPackageNameToFilename(string longPackageName, string extension)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(extension);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPackageName.LongPackageNameToFilename(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static string GetLongPackagePath(string longPackageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.GetLongPackagePath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static bool SplitLongPackageName(string longPackageName, out string packageRoot, out string packagePath, out string packageName, bool stripRootLeadingSlash)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe4 = new FStringUnsafe();
		bool result = Native_FPackageName.SplitLongPackageName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array, ref fStringUnsafe4.Array, stripRootLeadingSlash);
		packageRoot = fStringUnsafe2.Value;
		packagePath = fStringUnsafe3.Value;
		packageName = fStringUnsafe4.Value;
		return result;
	}

	public static string GetLongPackageAssetName(string longPackageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.GetLongPackageAssetName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static bool IsValidLongPackageName(string longPackageName, bool includeReadOnlyRoots)
	{
		string reason;
		return IsValidLongPackageName(longPackageName, includeReadOnlyRoots, out reason);
	}

	public static bool IsValidLongPackageName(string longPackageName, bool includeReadOnlyRoots, out string reason)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		bool result = Native_FPackageName.IsValidLongPackageName(ref fStringUnsafe.Array, includeReadOnlyRoots, ref fStringUnsafe2.Array);
		reason = fStringUnsafe2.Value;
		return result;
	}

	public static bool IsShortPackageName(string possiblyLongName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(possiblyLongName);
		return Native_FPackageName.IsShortPackageName(ref fStringUnsafe.Array);
	}

	public static bool IsShortPackageName(FName possiblyLongName)
	{
		return Native_FPackageName.IsShortPackageFName(ref possiblyLongName);
	}

	public static string GetShortName(UPackage package)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPackageName.GetShortNameFromPackage((package == null) ? IntPtr.Zero : package.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetShortName(string longName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.GetShortNameFromFString(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetShortName(FName longName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPackageName.GetShortNameFromFName(ref longName, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static FName GetShortFName(string longName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longName);
		Native_FPackageName.GetShortFNameFromFString(ref fStringUnsafe.Array, out var result);
		return result;
	}

	public static FName GetShortFName(FName longName)
	{
		Native_FPackageName.GetShortFNameFromFName(ref longName, out var result);
		return result;
	}

	public static void RegisterMountPoint(string rootPath, string contentPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(rootPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(contentPath);
		Native_FPackageName.RegisterMountPoint(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static void UnRegisterMountPoint(string rootPath, string contentPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(rootPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(contentPath);
		Native_FPackageName.UnRegisterMountPoint(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static FName GetPackageMountPoint(string packagePath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packagePath);
		Native_FPackageName.GetPackageMountPoint(ref fStringUnsafe.Array, out var result);
		return result;
	}

	public static bool DoesPackageExist(string longPackageName, Guid guid, out string filename)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		bool result = Native_FPackageName.DoesPackageExist(ref fStringUnsafe.Array, ref guid, ref fStringUnsafe2.Array);
		filename = fStringUnsafe2.Value;
		return result;
	}

	public static bool SearchForPackageOnDisk(string packageName, out string longPackageName, out string filename)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FPackageName.SearchForPackageOnDisk(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		longPackageName = fStringUnsafe2.Value;
		filename = fStringUnsafe3.Value;
		return result;
	}

	public static bool TryConvertShortPackagePathToLongInObjectPath(string objectPath, out string convertedObjectPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(objectPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		bool result = Native_FPackageName.TryConvertShortPackagePathToLongInObjectPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		convertedObjectPath = fStringUnsafe2.Value;
		return result;
	}

	public static string GetNormalizedObjectPath(string objectPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(objectPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.GetNormalizedObjectPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetLocalizedPackagePath(string sourcePackagePath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(sourcePackagePath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.GetLocalizedPackagePath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string GetLocalizedPackagePath(string sourcePackagePath, string cultureName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(sourcePackagePath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(cultureName);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FPackageName.GetLocalizedPackagePathWithCulture(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static string GetAssetPackageExtension()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPackageName.GetAssetPackageExtension(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetMapPackageExtension()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPackageName.GetMapPackageExtension(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool IsPackageExtension(string extension)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(extension);
		return Native_FPackageName.IsPackageExtension(ref fStringUnsafe.Array);
	}

	public static bool IsPackageFilename(string filename)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(filename);
		return Native_FPackageName.IsPackageFilename(ref fStringUnsafe.Array);
	}

	public static bool FindPackagesInDirectory(string rootDir, out string[] packages)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(rootDir);
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		bool result = Native_FPackageName.FindPackagesInDirectory(tArrayUnsafe.Address, ref fStringUnsafe.Array);
		packages = tArrayUnsafe.ToArray();
		return result;
	}

	public static string[] QueryRootContentPaths()
	{
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		Native_FPackageName.QueryRootContentPaths(tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public static void EnsureContentPathsAreRegistered()
	{
		Native_FPackageName.EnsureContentPathsAreRegistered();
	}

	public static bool ParseExportTextPath(string exportTextPath, out string className, out string objectPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(exportTextPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FPackageName.ParseExportTextPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		className = fStringUnsafe2.Value;
		objectPath = fStringUnsafe3.Value;
		return result;
	}

	public static string ExportTextPathToObjectPath(string exportTextPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(exportTextPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.ExportTextPathToObjectPath(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string ObjectPathToPackageName(string objectPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(objectPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.ObjectPathToPackageName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static string ObjectPathToObjectName(string objectPath)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(objectPath);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FPackageName.ObjectPathToObjectName(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public static bool IsScriptPackage(string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return Native_FPackageName.IsScriptPackage(ref fStringUnsafe.Array);
	}

	public static bool IsLocalizedPackage(string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return Native_FPackageName.IsLocalizedPackage(ref fStringUnsafe.Array);
	}

	public static bool DoesPackageNameContainInvalidCharacters(string longPackageName)
	{
		string reason;
		return DoesPackageNameContainInvalidCharacters(longPackageName, out reason);
	}

	public static bool DoesPackageNameContainInvalidCharacters(string longPackageName, out string reason)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		bool result = Native_FPackageName.DoesPackageNameContainInvalidCharacters(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		reason = fStringUnsafe2.Value;
		return result;
	}

	public static bool FindPackageFileWithoutExtension(string packageFilename, out string filename)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageFilename);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		bool result = Native_FPackageName.FindPackageFileWithoutExtension(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		filename = fStringUnsafe2.Value;
		return result;
	}

	public static string SanitizePackageName(string packageName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] invalidLongPackageCharacters = InvalidLongPackageCharacters;
		foreach (char value in packageName)
		{
			if (invalidLongPackageCharacters.Contains(value))
			{
				stringBuilder.Append('_');
			}
			else
			{
				stringBuilder.Append(value);
			}
		}
		stringBuilder.Replace("//", "/");
		return stringBuilder.ToString();
	}

	public static void GetPathInfo(string path, out string pathRoot, out string directory, out string moduleName, out string objectName, out string subobjectName)
	{
		pathRoot = string.Empty;
		directory = string.Empty;
		moduleName = string.Empty;
		objectName = string.Empty;
		subobjectName = string.Empty;
		string empty = string.Empty;
		if (string.IsNullOrEmpty(path))
		{
			return;
		}
		if (path.Length > 1 && path[0] == '/')
		{
			pathRoot = path.Substring(1, path.IndexOf('/', 1) - 1);
			path = path.Substring(pathRoot.Length + 2);
		}
		int num = path.LastIndexOf('/');
		if (num >= 0)
		{
			directory = path.Substring(0, num);
			empty = path.Substring(num + 1);
		}
		else
		{
			empty = path;
		}
		num = empty.LastIndexOf('.');
		if (num < 0)
		{
			return;
		}
		if (pathRoot == "Script")
		{
			moduleName = empty.Substring(0, num);
			directory += moduleName;
			objectName = empty.Substring(num + 1);
			num = objectName.IndexOf(':');
			if (num >= 0)
			{
				subobjectName = objectName.Substring(num + 1);
				objectName = objectName.Substring(0, num);
			}
		}
		else
		{
			objectName = empty.Substring(0, num);
			num = empty.IndexOf(':');
			if (num >= 0)
			{
				subobjectName = empty.Substring(num + 1);
			}
		}
	}
}
