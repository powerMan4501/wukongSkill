using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using b1.Localization;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class PS5UsbStorageMgr
{
	public delegate void Del_OnExportTaskCompleted(ExportTaskCompletedStatus bWasCompleted);

	public delegate void Del_OnTermTaskCompleted();

	public delegate void Del_OnFileWriteCompleted(EPS5UsbWriteErrorCode ErrCode, string FileName);

	private enum CoverType
	{
		zh_hans,
		zh_hant,
		en
	}

	private static readonly string B1SoundTrackExportDir = "BLACK MYTH WUKONG SOUNDTRACK SELECTION";

	private static readonly Dictionary<int, string> B1OstNameDict = new Dictionary<int, string>
	{
		{ 9005, "Black Myth Wukong Main Title" },
		{ 1001, "Unyielding Valor" },
		{ 1002, "Transcendent Beauty" },
		{ 9002, "A World Unseen" },
		{ 1003, "Mischievous As Ever" },
		{ 1006, "Seek Not Afar" },
		{ 1007, "Smoke Rises High" },
		{ 1008, "The Backyard Beast" },
		{ 1009, "Face What I Truly Am!" },
		{ 1010, "Two Hundred and Seventy Years in Vain" },
		{ 1011, "The Black Wind King's Pride" },
		{ 1004, "Black Cloud, Red Fire" },
		{ 1012, "See These Flames" },
		{ 1005, "I See" },
		{ 9001, "Tranquil Retreat" },
		{ 2001, "Rats in the Village" },
		{ 2004, "Son, I Hear You Loud and Clear" },
		{ 2002, "Monkey Brain Can Be a Proper Treat" },
		{ 2005, "Rock Guai" },
		{ 2006, "Stone Vanguard" },
		{ 2003, "Resonant Waves Profound" },
		{ 2007, "Such Wind! Powerful Indeed!" },
		{ 3005, "Macaque Chief" },
		{ 3001, "Merits In Vain" },
		{ 3006, "Long Trails They Did Go" },
		{ 3007, "Wise Voice" },
		{ 3008, "In Revel, We Find Pain" },
		{ 3009, "Evening Light on Snow" },
		{ 9003, "Zodiac Deities" },
		{ 3010, "Endeavors Wasted" },
		{ 3002, "It Will Fit Me Just As Well" },
		{ 3003, "Mahavira Hall" },
		{ 3011, "Gentleness Endears" },
		{ 3012, "Idol, Obstacle" },
		{ 3004, "Nonsense!" },
		{ 3013, "Cleave to Soar" },
		{ 4001, "Village of Lanxi" },
		{ 4005, "Even Pests Plague Our Path" },
		{ 4006, "Yaoguai or Bodhisattva" },
		{ 4007, "For What Deed, Must Mercy's Hand Sow Woe Upon Thee" },
		{ 4008, "If Good and Evil Gain No Due" },
		{ 4002, "Rank, Dank, Muck-Impelled" },
		{ 4009, "Who Said Women Are Soft-Hearted" },
		{ 4010, "Amidst the Furnace's Blaze, Purple Clouds Emerge" },
		{ 4011, "Self-Torment" },
		{ 4012, "My Chance to Ascend" },
		{ 4013, "The Last Crow" },
		{ 4003, "Entanglement, Evil" },
		{ 4004, "Listen Not" },
		{ 5001, "Perilous Path" },
		{ 5005, "Five Elements Disturbed" },
		{ 5002, "Sear the Fur For a Better Bite" },
		{ 5006, "Keep the Fun Going" },
		{ 5007, "Yin-Yang Adrift" },
		{ 5008, "Karma Is a Hero" },
		{ 5009, "Monkey in Haste, Sure to Go Waste" },
		{ 5010, "Loyalty Amid Fire and Frost" },
		{ 5011, "Samadhi Fire" },
		{ 5003, "Flames Have Paved My Way" },
		{ 5004, "Destiny" },
		{ 6004, "Mount Huaguo" },
		{ 6005, "Sky-Shrouding Stone" },
		{ 6001, "Detached from Rise and Fall" },
		{ 6008, "Mighty Descent" },
		{ 6009, "Cosmo Resonance" },
		{ 9004, "There Is a Way" },
		{ 6099, "Unfinished" }
	};

	private static Task AsyncTaskThreadHandler;

	private static CancellationTokenSource TaskCancellation;

	private static Dictionary<string, EPS5UsbWriteErrorCode> WriteResultDict = new Dictionary<string, EPS5UsbWriteErrorCode>();

	private static Del_OnTermTaskCompleted TermTaskCompletedCallBack = null;

	private static Dictionary<string, string> ExportFileNameDict = new Dictionary<string, string>();

	public static bool GetAllPS5UsbStorageDeviceId(out List<string> OutIds)
	{
		return UGSE_SDKFuncLib.GetAllPS5UsbStorageDeviceId(out OutIds);
	}

	public static bool GetPS5UsbStorageDeviceInfo(string DeviceId, out FUsbStorageDeviceInfo OutDeviceInfo)
	{
		return UGSE_SDKFuncLib.GetPS5UsbStorageDeviceInfo(DeviceId, out OutDeviceInfo);
	}

	public static EPS5UsbSelectErrorCode PS5UsbSelect(string UsrDir, out string OutDeviceId)
	{
		return UGSE_SDKFuncLib.PS5UsbSelectDevice(UsrDir, out OutDeviceId);
	}

	public static EPS5RequestMapUsbErrorCode RequestMapUsb(string DeviceId, string UsrDir, string SubDir, out string OutTargetDir)
	{
		OutTargetDir = "";
		string OutMountPoint;
		EPS5RequestMapUsbErrorCode ePS5RequestMapUsbErrorCode = UGSE_SDKFuncLib.PS5RequestMapUsb(DeviceId, UsrDir, out OutMountPoint);
		if (ePS5RequestMapUsbErrorCode != EPS5RequestMapUsbErrorCode.Success)
		{
			return ePS5RequestMapUsbErrorCode;
		}
		if (!UGSE_SDKFuncLib.PS5UsbMkSubDir(DeviceId, OutMountPoint, UsrDir, SubDir, out OutTargetDir))
		{
			return EPS5RequestMapUsbErrorCode.MkSubDirFailed;
		}
		return EPS5RequestMapUsbErrorCode.Success;
	}

	public static EPS5RequestUnMapUsbErrorCode RequestUnMapUsb(string DeviceId, string UsrDir)
	{
		return UGSE_SDKFuncLib.PS5RequestUnMapUsb(DeviceId, UsrDir);
	}

	public static void OnFileWrittenCompleted(EPS5UsbWriteErrorCode ErrCode, string FileName)
	{
		WriteResultDict[FileName] = ErrCode;
		SysLogUtil.AARON_DEBUG.LogInfo($"OnFileWrittenCompleted FileName:{FileName} ErrCode:{ErrCode}");
	}

	public static void PrintWriteResultDict()
	{
		foreach (string key in WriteResultDict.Keys)
		{
			SysLogUtil.AARON_DEBUG.LogInfo($"FileName:{key} ErrCode:{WriteResultDict[key]}");
		}
	}

	public static Dictionary<string, EPS5UsbWriteErrorCode> GetWriteResultDict()
	{
		return WriteResultDict;
	}

	private static bool IsChineseSystem(string SystemLang)
	{
		return SystemLang.Contains("zh");
	}

	private static bool IsChineseLangSetting(string UseLangSetting)
	{
		if (UseLangSetting == GSLocalization.Culture_zh_Hans || UseLangSetting == GSLocalization.Culture_zh_Hant || UseLangSetting == GSLocalization.Culture_zh_Hans_CN)
		{
			return true;
		}
		return false;
	}

	private static bool UseLocalization(out string UserLanguageSetting)
	{
		string defaultLanguage = UGSE_GSGameSettingsFuncLib.GetDefaultLanguage();
		UserLanguageSetting = GSLocalization.GetCurrentCulture();
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("PS5SystemLanguage:" + defaultLanguage);
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("UserLanguageSetting:" + UserLanguageSetting);
		if (IsChineseSystem(defaultLanguage) && IsChineseLangSetting(UserLanguageSetting))
		{
			return true;
		}
		return false;
	}

	private static string CapitalizeFirstLetter(string FileName)
	{
		string[] array = FileName.Split(' ');
		StringBuilder stringBuilder = new StringBuilder();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!string.IsNullOrEmpty(text))
			{
				stringBuilder.Append(text.Substring(0, 1).ToUpper()).Append(text.Substring(1)).Append(" ");
			}
		}
		return stringBuilder.ToString().TrimEnd();
	}

	private static string GetB1OstNameBySoundTrackId(int SoundTrackId)
	{
		if (B1OstNameDict.TryGetValue(SoundTrackId, out var value))
		{
			return value;
		}
		return null;
	}

	private static string GetMusicExportFileName(string FileName)
	{
		string[] array = FileName.Split('.');
		string input = array[0];
		string text = array[1];
		Match match = Regex.Match(input, "^(.*)_(\\d+)_(\\d+)$");
		if (match.Success)
		{
			string text2 = match.Groups[1].Value.Replace('_', ' ');
			string value = match.Groups[2].Value;
			string value2 = match.Groups[3].Value;
			int result;
			bool flag = int.TryParse(value, out result);
			if (UseLocalization(out var _) && flag)
			{
				SoundTrackDesc soundTrackDesc = GameDBRuntime.GetSoundTrackDesc(result);
				if (soundTrackDesc != null)
				{
					text2 = soundTrackDesc.Name.ToFText().ToString();
				}
			}
			else
			{
				text2 = GetB1OstNameBySoundTrackId(result);
			}
			SysLogUtil.AARON_DEBUG.LogInfo("Name:" + text2);
			return value2 + " " + text2 + "." + text;
		}
		return FileName;
	}

	private static string GetCoverExportFileName(out CoverType OutCoverType)
	{
		string result = "《黑神话：悟空》游戏音乐精选集封面.jpg";
		string result2 = "《黑神話：悟空》游戲音樂精選集封面.jpg";
		string result3 = "Black Myth Wukong Soundtrack Selection Cover.jpg";
		if (UseLocalization(out var UserLanguageSetting))
		{
			if (UserLanguageSetting == GSLocalization.Culture_zh_Hans || UserLanguageSetting == GSLocalization.Culture_zh_Hans_CN)
			{
				OutCoverType = CoverType.zh_hans;
				return result;
			}
			if (UserLanguageSetting == GSLocalization.Culture_zh_Hant)
			{
				OutCoverType = CoverType.zh_hant;
				return result2;
			}
		}
		OutCoverType = CoverType.en;
		return result3;
	}

	public static void CheckMusicFileNameGM(string MusicPath, string Suffix)
	{
		UGSFileHelper.FindFiles(MusicPath, out var FoundFiles, Suffix);
		foreach (string item in FoundFiles)
		{
			string fileName = Path.GetFileName(item);
			SysLogUtil.AARON_DEBUG.LogInfo("OriginStr:" + fileName);
			SysLogUtil.AARON_DEBUG.LogInfo("Process Res:" + GetMusicExportFileName(fileName));
		}
	}

	private static void OnExportDataToUsbCompleted(string DeviceId, Del_OnExportTaskCompleted OnExportTaskCompleted, ExportTaskCompletedStatus ExportTaskCompletedStatus)
	{
		OnExportTaskCompleted?.Invoke(ExportTaskCompletedStatus);
		AsyncTaskThreadHandler = null;
		TaskCancellation = null;
		ExportFileNameDict.Clear();
		EPS5RequestUnMapUsbErrorCode ePS5RequestUnMapUsbErrorCode = RequestUnMapUsb(DeviceId, "/MUSIC");
		SysLogUtil.AARON_DEBUG.LogInfo($"PS5RequestUnMapUsb :{ePS5RequestUnMapUsbErrorCode}");
	}

	private static EPS5UsbWriteErrorCode WriteFileToTargetDir(string OutTargetBaseDir, string FileName, List<byte> BytesData)
	{
		string text = OutTargetBaseDir;
		if (FileName.EndsWith(".mp3"))
		{
			text = FPaths.Combine(text, "mp3", FileName);
		}
		if (FileName.EndsWith(".flac"))
		{
			text = FPaths.Combine(text, "flac", FileName);
		}
		if (FileName.EndsWith(".jpg"))
		{
			text = FPaths.Combine(text, FileName);
		}
		EPS5UsbWriteErrorCode ePS5UsbWriteErrorCode = UGSE_SDKFuncLib.PS5ExportDataToUsb(text, BytesData);
		SysLogUtil.AARON_DEBUG.LogInfo($"PS5ExportDataToUsb:{ePS5UsbWriteErrorCode}");
		OnFileWrittenCompleted(ePS5UsbWriteErrorCode, FileName);
		return ePS5UsbWriteErrorCode;
	}

	private static string GetExportFileName(string FileName)
	{
		if (FileName.EndsWith(".mp3") || FileName.EndsWith(".flac"))
		{
			return GetMusicExportFileName(FileName);
		}
		CoverType OutCoverType;
		if (FileName.EndsWith(".jpg"))
		{
			return GetCoverExportFileName(out OutCoverType);
		}
		return "Error";
	}

	private static void ExportDataToUsb(string DeviceId, List<string> FilePathList, Del_OnExportTaskCompleted OnExportTaskCompleted)
	{
		string OutTargetDir;
		EPS5RequestMapUsbErrorCode ePS5RequestMapUsbErrorCode = RequestMapUsb(DeviceId, "/MUSIC", B1SoundTrackExportDir, out OutTargetDir);
		if (ePS5RequestMapUsbErrorCode != EPS5RequestMapUsbErrorCode.Success)
		{
			SysLogUtil.AARON_DEBUG.LogInfo($"MountRes :{ePS5RequestMapUsbErrorCode}");
			OnExportDataToUsbCompleted(DeviceId, OnExportTaskCompleted, ExportTaskCompletedStatus.Failed);
			return;
		}
		foreach (string FilePath in FilePathList)
		{
			if (TaskCancellation.IsCancellationRequested)
			{
				TermTaskCompletedCallBack?.Invoke();
				TermTaskCompletedCallBack = null;
				break;
			}
			List<byte> BytesToRead;
			bool flag = UGSFileHelper.ReadFile(FilePath, out BytesToRead, IsStandardPath: true);
			SysLogUtil.AARON_DEBUG.LogInfo($"ReadFile :{flag}");
			string fileName = ExportFileNameDict[Path.GetFileName(FilePath)];
			if (WriteFileToTargetDir(OutTargetDir, fileName, BytesToRead) != EPS5UsbWriteErrorCode.Success)
			{
				OnExportDataToUsbCompleted(DeviceId, OnExportTaskCompleted, ExportTaskCompletedStatus.Failed);
				return;
			}
		}
		OnExportDataToUsbCompleted(DeviceId, OnExportTaskCompleted, ExportTaskCompletedStatus.Completed);
	}

	private static void BuildExportFileNameDict(List<string> FilePathList)
	{
		ExportFileNameDict.Clear();
		foreach (string FilePath in FilePathList)
		{
			string fileName = Path.GetFileName(FilePath);
			string exportFileName = GetExportFileName(fileName);
			if (ExportFileNameDict.TryGetValue(fileName, out var _))
			{
				ExportFileNameDict[fileName] = exportFileName;
			}
			else
			{
				ExportFileNameDict.Add(fileName, exportFileName);
			}
		}
	}

	public static bool RequestExportDataToUsb(string DeviceId, List<string> FilePathList, Del_OnExportTaskCompleted OnExportTaskCompleted)
	{
		if (AsyncTaskThreadHandler != null)
		{
			SysLogUtil.AARON_DEBUG.LogInfo("AsyncTaskThreadHandler != null");
			OnExportTaskCompleted?.Invoke(ExportTaskCompletedStatus.Exporting);
			return false;
		}
		BuildExportFileNameDict(FilePathList);
		WriteResultDict.Clear();
		TaskCancellation = new CancellationTokenSource();
		AsyncTaskThreadHandler = Task.Run(delegate
		{
			ExportDataToUsb(DeviceId, FilePathList, OnExportTaskCompleted);
		});
		return true;
	}

	public static void TerminateDataExport(Del_OnTermTaskCompleted OnTermTaskCompleted)
	{
		if (AsyncTaskThreadHandler != null && TaskCancellation != null && TermTaskCompletedCallBack == null)
		{
			TermTaskCompletedCallBack = OnTermTaskCompleted;
			TaskCancellation.Cancel();
		}
		else
		{
			OnTermTaskCompleted?.Invoke();
		}
	}

	public static void InitUsbDevice()
	{
		GetAllPS5UsbStorageDeviceId(out var OutIds);
		foreach (string item in OutIds)
		{
			UGSE_SDKFuncLib.PS5RequestMapUsb(item, "/MUSIC", out var _);
			UGSE_SDKFuncLib.PS5RequestUnMapUsb(item, "/MUSIC");
		}
	}

	private static bool ShouldRemoveFile(string FileName)
	{
		GetCoverExportFileName(out var OutCoverType);
		if ((!FileName.Contains("cover_en") || OutCoverType == CoverType.en) && (!FileName.Contains("cover_zh_hans") || OutCoverType == CoverType.zh_hans))
		{
			if (FileName.Contains("cover_zh_hant"))
			{
				return OutCoverType != CoverType.zh_hant;
			}
			return false;
		}
		return true;
	}

	public static List<string> GetNeedExportFileList()
	{
		UGSFileHelper.FindFilesRecursively("/Game/Movies/PS5OST/", out var FoundFiles, "");
		for (int num = FoundFiles.Count - 1; num >= 0; num--)
		{
			if (ShouldRemoveFile(FoundFiles[num]))
			{
				FoundFiles.RemoveAt(num);
			}
		}
		return FoundFiles;
	}

	private static string GetUsbSearchPath(string FileName)
	{
		string text = FPaths.Combine("/MUSIC", B1SoundTrackExportDir);
		if (FileName.EndsWith(".mp3"))
		{
			return FPaths.Combine(text, "mp3", FileName);
		}
		if (FileName.EndsWith(".flac"))
		{
			return FPaths.Combine(text, "flac", FileName);
		}
		if (FileName.EndsWith(".jpg"))
		{
			return FPaths.Combine(text, FileName);
		}
		return "";
	}

	public static long GetUsbDeviceOverridableSpace(string DeviceId)
	{
		long num = 0L;
		foreach (string needExportFile in GetNeedExportFileList())
		{
			string usbSearchPath = GetUsbSearchPath(GetExportFileName(Path.GetFileName(needExportFile)));
			if (IsUsbStorageExists(DeviceId, usbSearchPath))
			{
				long num2 = UGSFileHelper.FileSize(needExportFile, IsStandardPath: true);
				num += num2;
			}
		}
		return num;
	}

	public static bool IsUsbStorageExists(string DeviceId, string Path)
	{
		bool IsFile;
		return UGSE_SDKFuncLib.UsbStorageIsExist(DeviceId, Path, out IsFile);
	}
}
