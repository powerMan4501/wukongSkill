using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.Localization;
using Google.Protobuf;
using LitJson;
using ResB1;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

public class EndCreditsDataHelper
{
	private const string FilePath = "00Main/PBTable/EndingCredits/";

	private static readonly string ReadPath = "/Game/00Main/PBTable/EndingCredits/";

	private static readonly string DirFullPath = FPaths.Combine(FPaths.ProjectContentDir, "00Main/PBTable/EndingCredits/");

	private const string DataExt = ".data";

	private const string JsonExt = ".json";

	private string FileName;

	private EEndCreditsType EndCreditsType;

	private Dictionary<EEndCreditsType, PageData> CacheDataMap = new Dictionary<EEndCreditsType, PageData>();

	private string GetCultureExt()
	{
		if (GSLocalization.IsZHCulture())
		{
			return string.Empty;
		}
		return "_Other";
	}

	private string GetFullFileName(bool UseJson)
	{
		return FileName + GetCultureExt() + (UseJson ? ".json" : ".data");
	}

	private string GetReadFullPath(bool UseJson)
	{
		return ReadPath + GetFullFileName(UseJson);
	}

	public void Preload()
	{
		CacheDataMap.Clear();
		SetEndCreditsType(EEndCreditsType.EndB);
		CacheDataMap.Add(EEndCreditsType.EndB, GetData());
		SetEndCreditsType(EEndCreditsType.EndA);
		CacheDataMap.Add(EEndCreditsType.EndA, GetData());
	}

	public EEndCreditsType GetEndCreditsType()
	{
		return EndCreditsType;
	}

	public void SetEndCreditsType(EEndCreditsType InEndCreditsType)
	{
		EndCreditsType = InEndCreditsType;
		FileName = $"EndingCredits_{EndCreditsType}";
	}

	public bool Save(PageData Data)
	{
		if (Data == null)
		{
			return false;
		}
		if (!Directory.Exists(DirFullPath))
		{
			Directory.CreateDirectory(DirFullPath);
		}
		JsonWriter jsonWriter = new JsonWriter();
		JsonMapper.ToJson(Data, jsonWriter);
		EndingCreditsData saveData = new EndingCreditsData
		{
			JsonData = jsonWriter.ToString()
		};
		string fileName = FPaths.Combine(DirFullPath, GetFullFileName(UseJson: false));
		GSE_ProtobufHelper.WriteMessageToFile(saveData, fileName);
		File.WriteAllText(FPaths.Combine(DirFullPath, GetFullFileName(UseJson: true)), jsonWriter.ToString());
		return true;
	}

	public PageData GetData()
	{
		PageData pageData = null;
		try
		{
			if (UGSFileHelper.ReadFile(GetReadFullPath(DebugConfig.EndingCreditsUseJson), out var BytesToRead))
			{
				if (DebugConfig.EndingCreditsUseJson)
				{
					pageData = EndCreditsData.CreateByJson<PageData>(Encoding.UTF8.GetString(BytesToRead.ToArray()));
				}
				else
				{
					EndingCreditsData endingCreditsData = new EndingCreditsData();
					endingCreditsData.MergeFrom(BytesToRead.ToArray());
					pageData = EndCreditsData.CreateByJson<PageData>(endingCreditsData.JsonData);
				}
			}
			else
			{
				pageData = EndCreditsData.CreateByJson<PageData>(Encoding.UTF8.GetString(BytesToRead.ToArray()));
			}
		}
		catch
		{
			if (pageData == null || !pageData.IsValid())
			{
				pageData = new PageData();
				pageData.PageList.Add(new EndCreditsPageData());
			}
			BGW_LogUtil.LogError("[EndCreditsDataHelper] GetData Fail!");
		}
		if (pageData != null && pageData.IsValid())
		{
			return pageData;
		}
		return null;
	}

	public PageData GetCacheData()
	{
		if (CacheDataMap.TryGetValue(EndCreditsType, out var value))
		{
			return value;
		}
		PageData data = GetData();
		CacheDataMap.Add(EndCreditsType, data);
		return data;
	}
}
