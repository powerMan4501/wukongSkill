using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Protobuf.DataAPI;

public class BG_ProtobufDataLoader
{
	private static string _protoDataFolder;

	private static string _protoRuntimeDataFolder;

	private static string _excelTableRootPath;

	private static string _montageDataPath;

	private static string _mapDataPath;

	private static string _behaviacPath;

	private static string _voiceSplitTimePath;

	private static BG_ProtobufDataLoader _instance;

	private static List<string> _protoNameSpaces;

	private static string[] _tableFolders;

	private static string _tableCSVFolder;

	private static string _localOneDriveTableFolder;

	private static string _localModeTableFolder;

	private static string[] _foundFiles;

	private static Dictionary<string, string> _redirectorMap = new Dictionary<string, string>();

	private static Dictionary<string, List<string>> _ignoreFieldsMap = new Dictionary<string, List<string>>();

	public readonly string DataGuard = "Guard";

	private static Assembly _scriptDLL;

	public static bool _UseCDNFile = false;

	private static string _CDNFilePath;

	private static bool _IsPrintToScreen = false;

	public string ProjName { get; private set; }

	public static bool IsPrintToScreen => _IsPrintToScreen;

	private BG_ProtobufDataLoader()
	{
	}

	public static void SetIsPrintToScreen(bool PrintToScreen)
	{
		_IsPrintToScreen = true;
	}

	public void SetUseCDNFile(string CDNPath)
	{
		_UseCDNFile = true;
		_CDNFilePath = CDNPath + "/";
	}

	public void LoadProjectDataSettings(string proj_name)
	{
		InitializeConfig(proj_name);
		InitializeFolderPaths();
		LoadRedirectorCSV();
		LoadIgnoreFieldsCsvFile();
	}

	public static BG_ProtobufDataLoader Get()
	{
		if (_instance == null)
		{
			_instance = new BG_ProtobufDataLoader();
		}
		return _instance;
	}

	public void LoadProtobufData(in string fileName)
	{
		char[] separator = new char[4] { ' ', '\\', '.', '-' };
		string[] array = fileName.Split(separator);
		string stringType = ((array.Length > 2) ? array[array.Length - 2] : array[0]);
		Type databaseType = Get().GetDatabaseType(stringType);
		Type type = typeof(BG_ProtobufDataAPI<>).MakeGenericType(databaseType);
		MethodInfo method = type.GetMethod("Get");
		MethodInfo method2 = type.GetMethod("LoadDataFromFilesRecursively", new Type[2]
		{
			typeof(string),
			typeof(bool)
		});
		object obj = method.Invoke(type, new object[1] { Type.Missing });
		method2.Invoke(obj, new object[2] { databaseType.Name, false });
	}

	public string GetDataFolderFullPath()
	{
		if (_UseCDNFile)
		{
			return _CDNFilePath;
		}
		if (!Directory.Exists(FPaths.ProjectContentDir + _protoDataFolder) && UGSE_EngineFuncLib.IsEditor())
		{
			Directory.CreateDirectory(FPaths.ProjectContentDir + _protoDataFolder);
		}
		return FPaths.ProjectContentDir + _protoDataFolder + "/";
	}

	public string[] GetFiles()
	{
		if (_foundFiles == null)
		{
			UGSFileHelper.FindFiles(GetDataFolderGSPath(), out var FoundFiles, ".data");
			_foundFiles = FoundFiles.ToArray();
		}
		return _foundFiles;
	}

	public Dictionary<string, string> GetRedirectorMap()
	{
		return _redirectorMap;
	}

	public Dictionary<string, List<string>> GetIgnoreFieldsMap()
	{
		return _ignoreFieldsMap;
	}

	public string GetDataFolderGSPath()
	{
		return "/Game/" + _protoDataFolder + "/";
	}

	public string GetMontageDataFullPath()
	{
		_montageDataPath = "/01_U3Main/PBTable/Montage";
		if (!Directory.Exists(FPaths.ProjectContentDir + _montageDataPath) && UGSE_EngineFuncLib.IsEditor())
		{
			return FPaths.ProjectContentDir + _montageDataPath;
		}
		return FPlatformProperties.GetPlatform() switch
		{
			EPlatform.Android => FPaths.ProjectContentDir + "Montage/", 
			EPlatform.IOS => FPaths.ProjectContentDir + "Montage/", 
			EPlatform.PS5 => FPaths.ProjectContentDir + "montage/", 
			EPlatform.XSX => FPaths.ProjectContentDir + "montage/", 
			_ => FPaths.ProjectContentDir + _montageDataPath + "/", 
		};
	}

	public string GetBehaviacDataFullPath()
	{
		if (!Directory.Exists(FPaths.ProjectContentDir + _behaviacPath) && UGSE_EngineFuncLib.IsEditor())
		{
			return FPaths.ProjectContentDir + _behaviacPath;
		}
		return FPlatformProperties.GetPlatform() switch
		{
			EPlatform.Android => FPaths.ProjectContentDir + _behaviacPath + "/", 
			EPlatform.IOS => FPaths.ProjectContentDir + _behaviacPath + "/", 
			_ => FPaths.ProjectContentDir + _behaviacPath, 
		};
	}

	public string GetMapDataFullPath()
	{
		_mapDataPath = "01_U3Main/PBTable/Map";
		if (!Directory.Exists(FPaths.ProjectContentDir + _mapDataPath) && UGSE_EngineFuncLib.IsEditor())
		{
			return FPaths.ProjectContentDir + _mapDataPath;
		}
		return FPlatformProperties.GetPlatform() switch
		{
			EPlatform.Android => FPaths.ProjectContentDir + "Map/", 
			EPlatform.IOS => FPaths.ProjectContentDir + "Map/", 
			_ => FPaths.ProjectContentDir + _mapDataPath + "/", 
		};
	}

	public string GetRunTimeDataFolderFullPath()
	{
		if (_UseCDNFile)
		{
			return _CDNFilePath;
		}
		if (!Directory.Exists(FPaths.ProjectContentDir + _protoRuntimeDataFolder) && UGSE_EngineFuncLib.IsEditor())
		{
			Directory.CreateDirectory(FPaths.ProjectContentDir + _protoRuntimeDataFolder);
		}
		return FPaths.ProjectContentDir + _protoRuntimeDataFolder + "/";
	}

	public string GetVoiceSplitTimeFullPath()
	{
		if (!Directory.Exists(FPaths.ProjectContentDir + _voiceSplitTimePath) && UGSE_EngineFuncLib.IsEditor())
		{
			Directory.CreateDirectory(FPaths.ProjectContentDir + _voiceSplitTimePath);
		}
		return FPaths.ProjectContentDir + _voiceSplitTimePath + "/";
	}

	public string[] GetTableFolders()
	{
		return _tableFolders;
	}

	public string GetTableCSVFolder()
	{
		CreateDirectoryRecursively(_tableCSVFolder);
		return _tableCSVFolder;
	}

	public string GetLocalOneDriveTableFolder()
	{
		return _localOneDriveTableFolder;
	}

	public string GetLocalModeTableFolder()
	{
		return _localModeTableFolder;
	}

	public string GetTableRootPath()
	{
		if (UGSE_EngineFuncLib.IsEditor())
		{
			string text = USystemLibrary.GetProjectDirectory().Replace("/", "\\");
			if (!Directory.Exists(text + _excelTableRootPath))
			{
				Directory.CreateDirectory(text + _excelTableRootPath);
			}
			return text + _excelTableRootPath;
		}
		return string.Empty;
	}

	private string GetRedirectorCSVPath()
	{
		return GetTableRootPath() + "\\redirectors.csv";
	}

	private string GetIgnoreFieldsCSVPath()
	{
		return USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "Tools\\Misc\\IgnoreTableFieldsInShippingMode.csv";
	}

	private void CreateDirectoryRecursively(string fileFullPath)
	{
		if (File.Exists(fileFullPath))
		{
			return;
		}
		string[] array = fileFullPath.Split('\\');
		if (array.Length <= 1)
		{
			return;
		}
		string text = array[0];
		for (int i = 1; i < array.Length; i++)
		{
			text = text + "\\" + array[i];
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
	}

	public void InitializeFolderPaths()
	{
		if (!UGSE_EngineFuncLib.IsEditor())
		{
			return;
		}
		_tableFolders = _protoNameSpaces.ToArray();
		for (int i = 0; i < _tableFolders.Length; i++)
		{
			_tableFolders[i] = GetTableRootPath() + "\\Table_" + _tableFolders[i];
			if (!Directory.Exists(_tableFolders[i] + "\\CSV"))
			{
				Directory.CreateDirectory(_tableFolders[i] + "\\CSV");
			}
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		string text = "";
		try
		{
			text = File.ReadAllText(FPaths.ProjectDir + "Config_Proj/B1/ProjBranch.txt");
		}
		catch (Exception)
		{
			text = "develop";
		}
		_tableCSVFolder = "C:\\GSDataTable\\CSV\\" + text;
		_localOneDriveTableFolder = folderPath + "\\OneDrive - GameScience\\" + text + "\\";
		_localModeTableFolder = "C:\\GSDataTable\\LocalTable\\" + text;
	}

	private void LoadRedirectorCSV()
	{
		if (_redirectorMap.Count > 0)
		{
			return;
		}
		string redirectorCSVPath = GetRedirectorCSVPath();
		if (File.Exists(redirectorCSVPath))
		{
			string[] array = File.ReadAllLines(redirectorCSVPath);
			if (array.Length == 0)
			{
				return;
			}
			string[] array2 = array;
			foreach (string obj in array2)
			{
				int num = obj.IndexOf(',');
				string key = obj.Substring(0, num);
				string text = obj.Substring(num + 1);
				int length = text.IndexOf(',');
				string text2 = text.Substring(0, length);
				if (!(text2 == "None"))
				{
					_redirectorMap[key] = text2;
				}
			}
		}
		else
		{
			USystemLibrary.PrintString(null, "转表工具获取Redirector失败，路径不存在：" + redirectorCSVPath, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
		}
	}

	private void LoadIgnoreFieldsCsvFile()
	{
		if (_ignoreFieldsMap.Count > 0)
		{
			return;
		}
		string ignoreFieldsCSVPath = GetIgnoreFieldsCSVPath();
		if (File.Exists(ignoreFieldsCSVPath))
		{
			string[] array = File.ReadAllLines(ignoreFieldsCSVPath);
			if (array.Length != 0)
			{
				string[] array2 = array;
				foreach (string obj in array2)
				{
					int num = obj.IndexOf(',');
					string key = obj.Substring(0, num);
					string[] source = obj.Substring(num + 1).Split(',');
					_ignoreFieldsMap[key] = source.ToList();
				}
			}
		}
		else
		{
			USystemLibrary.PrintString(null, "转表工具获取IgnoreFields失败，路径不存在：" + ignoreFieldsCSVPath, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
		}
	}

	public bool IsRuntimeData(string fileName)
	{
		return fileName.Contains("_Hot_");
	}

	public Type GetDatabaseType(string stringType, bool isFullName = false)
	{
		Type type = null;
		type = Type.GetType(stringType);
		if (type != null)
		{
			return type;
		}
		foreach (string protoNameSpace in _protoNameSpaces)
		{
			string text = (isFullName ? stringType : (protoNameSpace + "." + stringType));
			type = ((FPlatformProperties.GetPlatform() != EPlatform.PS5) ? Type.GetType(text) : Type.GetType(text, throwOnError: true, ignoreCase: true));
			if (type != null)
			{
				return type;
			}
			if (UGSE_EngineFuncLib.IsEditor() && _scriptDLL != null)
			{
				type = _scriptDLL.GetType(text);
				if (type != null)
				{
					return type;
				}
			}
		}
		return type;
	}

	public void LoadDLLForTableTool(in string fileFullPath)
	{
		if (!UGSE_EngineFuncLib.IsEditor())
		{
			return;
		}
		ushort num = 0;
		while (num < 3)
		{
			try
			{
				using (new StreamReader(fileFullPath))
				{
				}
				_scriptDLL = null;
				_scriptDLL = Assembly.Load(File.ReadAllBytes(fileFullPath));
				USystemLibrary.PrintString(null, "转表工具加载热更数据：" + fileFullPath, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Blue, 10f, FName.None);
				break;
			}
			catch
			{
				Thread.Sleep(500);
				num++;
			}
		}
	}

	public void InitializeConfig(string projName)
	{
		ProjName = projName;
		if (_protoNameSpaces != null)
		{
			return;
		}
		_excelTableRootPath = "GSDataTable";
		_behaviacPath = "01_U3Main/PBTable/Behaviac";
		_voiceSplitTimePath = "01_U3Main/PBTable/VoiceSplitTime";
		_protoNameSpaces = new List<string>();
		if (ProjName == "B1")
		{
			_protoNameSpaces.Add("BtlB1");
			_protoNameSpaces.Add("BtlShare");
			_protoNameSpaces.Add("ResB1");
			_protoDataFolder = "00Main/PBTable/NoneRuntime";
			_protoRuntimeDataFolder = "00Main/PBTable/Runtime";
		}
		else if (ProjName == "X2")
		{
			_protoNameSpaces.Add("BtlB1");
			_protoNameSpaces.Add("BtlShare");
			_protoDataFolder = "02_X2Main/PBTable/NoneRuntime";
			_protoRuntimeDataFolder = "02_X2Main/PBTable/Runtime";
		}
		else if (ProjName == "U3")
		{
			_protoNameSpaces.Add("BaseU3");
			_protoNameSpaces.Add("BtlU3");
			_protoNameSpaces.Add("ResU3");
			_protoNameSpaces.Add("BtlB1");
			_protoNameSpaces.Add("L18NU3");
			_protoNameSpaces.Add("BtlShare");
			_protoDataFolder = "01_U3Main/PBTable/NoneRuntime";
			_protoRuntimeDataFolder = "01_U3Main/PBTable/Runtime";
			if (FPlatformProperties.GetPlatform() == EPlatform.Android || FPlatformProperties.GetPlatform() == EPlatform.IOS)
			{
				_behaviacPath = "Behaviac";
				_protoDataFolder = "NoneRuntime";
				_protoRuntimeDataFolder = "Runtime";
				_voiceSplitTimePath = "VoiceSplitTime";
			}
		}
	}
}
