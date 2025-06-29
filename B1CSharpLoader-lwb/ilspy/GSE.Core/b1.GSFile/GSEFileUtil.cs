using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnrealEngine.Runtime;

namespace b1.GSFile;

public class GSEFileUtil
{
	public static string ProjectPersistentDownloadDir { get; protected set; }

	public static string TemporaryCachePath { get; protected set; }

	public static string PatchPath { get; protected set; }

	public static string ExtractPath { get; protected set; }

	public static string IOSSpecialPatchPath { get; protected set; }

	public static void DeleteFolder(string dir)
	{
		if (!Directory.Exists(dir))
		{
			return;
		}
		string[] fileSystemEntries = Directory.GetFileSystemEntries(dir);
		foreach (string text in fileSystemEntries)
		{
			if (File.Exists(text))
			{
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Attributes.ToString().IndexOf("ReadOnly") != -1)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				File.Delete(text);
			}
			else if (Directory.GetFileSystemEntries(text).Length != 0)
			{
				DeleteFolder(text);
			}
			else
			{
				Directory.Delete(text);
			}
		}
		Directory.Delete(dir);
	}

	public static string CombinePath(params string[] paths)
	{
		return FPaths.Combine(paths);
	}

	public static int GetFileSize(string filepath)
	{
		try
		{
			filepath = GSEFileSystem.GetInstance().GetFileFullPath(filepath);
			if (File.Exists(filepath))
			{
				return (int)new FileInfo(filepath).Length;
			}
			return 0;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message);
			return 0;
		}
	}

	public static bool CheckFileMD5(string path, string md5str)
	{
		if (md5str.Equals("md5"))
		{
			return true;
		}
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] buffer = File.ReadAllBytes(path);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(buffer);
			buffer = null;
			mD5CryptoServiceProvider.Clear();
			GC.Collect();
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("X").PadLeft(2, '0');
			}
			text = StringParseHelper.SafeToLower(text);
			if (text.Equals(md5str))
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
			return false;
		}
		return false;
	}

	public static string GetWritablePath()
	{
		return ProjectPersistentDownloadDir;
	}

	public static string GetTmpPath()
	{
		return TemporaryCachePath;
	}

	public static string GetFileMD5(string filepath)
	{
		if (!File.Exists(filepath))
		{
			return "";
		}
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] buffer = File.ReadAllBytes(filepath);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(buffer);
			buffer = null;
			mD5CryptoServiceProvider.Clear();
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("X").PadLeft(2, '0');
			}
			return StringParseHelper.SafeToLower(text);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message);
			return "";
		}
	}

	public static bool IsDirectoryExist(string filePath)
	{
		return Directory.Exists(filePath);
	}

	public static bool IsFileExist(string filepath)
	{
		return File.Exists(filepath);
	}

	public static void RemoveFile(string path)
	{
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	public static void CreateDirectory(string directoryName)
	{
		Directory.CreateDirectory(directoryName);
	}

	public static bool EnsureFileWritable(string path)
	{
		try
		{
			string text = FormalizePath(path);
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			new FileInfo(text).IsReadOnly = false;
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void CreateFolder(string path)
	{
		Directory.CreateDirectory(path);
	}

	public static string GetPatchPath()
	{
		return PatchPath;
	}

	public static string FormalizePath(string path)
	{
		string text = path;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		text = ((directorySeparatorChar != '\\') ? text.Replace('\\', directorySeparatorChar) : text.Replace('/', directorySeparatorChar));
		return Path.GetFullPath(text);
	}

	public static string GetFileStringData(string filepath)
	{
		try
		{
			byte[] bytes = File.ReadAllBytes(filepath);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message);
			return "";
		}
	}

	static GSEFileUtil()
	{
		ProjectPersistentDownloadDir = FPaths.ProjectPersistentDownloadDir;
		IOSSpecialPatchPath = FPaths.Combine(FPaths.ProjectPersistentDownloadDir, "Patch");
		if (FPlatformProperties.GetPlatform() == EPlatform.IOS)
		{
			ProjectPersistentDownloadDir = FPaths.ConvertRelativePathToFull(FPaths.Combine(UGSE_SDKFuncLib.GetIOSDocumentPath(), "PersistentDownloadDir"));
		}
		TemporaryCachePath = FPaths.Combine(ProjectPersistentDownloadDir, "Temp");
		PatchPath = FPaths.Combine(ProjectPersistentDownloadDir, "Patch");
		ExtractPath = FPaths.Combine(ProjectPersistentDownloadDir, "Extract");
	}

	public static bool ReadBytesFromFile(string FileName, out byte[] FileData)
	{
		FileData = null;
		if (File.Exists(FileName))
		{
			try
			{
				FileData = File.ReadAllBytes(FileName);
				return true;
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("ReadAllBytes Failed, FileName:" + FileName + ", Message:" + ex.ToString());
				return false;
			}
		}
		BGW_LogUtil.LogError("File:" + FileName + " not found!");
		return false;
	}

	public static bool WriteBytesToFile(string FileName, byte[] FileData)
	{
		try
		{
			File.WriteAllBytes(FileName, FileData);
			return true;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("File.WriteAllBytes Failed, FileName:" + FileName + " Message:" + ex.ToString());
			return false;
		}
	}

	public static bool SafeWriteBytesToFile(string FileName, byte[] FileData)
	{
		try
		{
			string text = FileName + ".temp";
			using (FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough))
			{
				fileStream.Write(FileData, 0, FileData.Length);
			}
			if (File.Exists(FileName))
			{
				File.Replace(text, FileName, null);
			}
			else
			{
				File.Move(text, FileName);
			}
			return true;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("File.WriteAllBytes Failed, FileName:" + FileName + " Message:" + ex.ToString());
			return false;
		}
	}
}
