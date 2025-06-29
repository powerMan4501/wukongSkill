using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LitJson;

namespace b1.UI.Comm;

public class EndCreditsData
{
	private const string JsonKey_WidgetType = "WidgetType";

	private const string JsonKey_Childs = "Childs";

	private const string JsonKey_PageList = "PageList";

	public EEndCreditsItemType WidgetType;

	public string WidgetName;

	public static EndCreditsWidgetData CreateText(string InWidgetName, string InContent)
	{
		return new EndCreditsWidgetData
		{
			WidgetType = EEndCreditsItemType.Text,
			WidgetName = InWidgetName,
			Content = InContent
		};
	}

	public static EndCreditsWidgetData CreateImage(string InWidgetName, string InContent)
	{
		return new EndCreditsWidgetData
		{
			WidgetType = EEndCreditsItemType.Image,
			WidgetName = InWidgetName,
			Content = InContent
		};
	}

	public static EndCreditsItemData CreateItem(string InWidgetName)
	{
		return new EndCreditsItemData
		{
			WidgetType = EEndCreditsItemType.Item,
			WidgetName = InWidgetName,
			Childs = new List<EndCreditsData>()
		};
	}

	public static EndCreditsPageData CreatePage(string InWidgetName, EEndCreditsPageAction InPageAction, double InScrollSpeed, double InScrollEndOffset, string InPagePath)
	{
		return new EndCreditsPageData
		{
			WidgetType = EEndCreditsItemType.Page,
			WidgetName = InWidgetName,
			Childs = new List<EndCreditsData>(),
			PageAction = InPageAction,
			PagePath = InPagePath,
			ScrollSpeed = InScrollSpeed,
			ScrollEndOffset = InScrollEndOffset
		};
	}

	public static T CreateByJson<T>(string InJson)
	{
		T val = JsonMapper.ToObject<T>(new JsonReader(InJson));
		if (val is EndCreditsItemData || val is PageData)
		{
			JsonData jsonData = JsonMapper.ToObject(new JsonReader(InJson));
			if (val is EndCreditsItemData endCreditsItemData && jsonData.IsObject && jsonData.Keys.Contains("Childs"))
			{
				endCreditsItemData.Childs.Clear();
				JsonData dataChilds = jsonData["Childs"];
				if (ReInitChild(dataChilds) != null)
				{
					endCreditsItemData.Childs = ReInitChild(dataChilds);
				}
			}
			else if (val is PageData pageData && jsonData.IsObject && jsonData.Keys.Contains("PageList"))
			{
				pageData.PageList.Clear();
				List<EndCreditsData> list = ReInitChild(jsonData["PageList"]);
				if (list != null)
				{
					pageData.PageList = (from item in list
						where item is EndCreditsPageData
						select item as EndCreditsPageData).ToList();
				}
			}
		}
		return val;
	}

	private static List<EndCreditsData> ReInitChild(JsonData DataChilds)
	{
		if (DataChilds == null)
		{
			return null;
		}
		List<EndCreditsData> list = new List<EndCreditsData>();
		if (DataChilds.IsArray)
		{
			foreach (JsonData item in (IEnumerable)DataChilds)
			{
				if (!item.IsObject || !item.Keys.Contains("WidgetType"))
				{
					continue;
				}
				object obj = Enum.Parse(typeof(EEndCreditsItemType), item["WidgetType"].ToString());
				if (obj is EEndCreditsItemType)
				{
					switch ((EEndCreditsItemType)obj)
					{
					case EEndCreditsItemType.Text:
					case EEndCreditsItemType.Image:
						list.Add(CreateByJson<EndCreditsWidgetData>(item.ToJson()));
						continue;
					case EEndCreditsItemType.Item:
						list.Add(CreateByJson<EndCreditsItemData>(item.ToJson()));
						continue;
					case EEndCreditsItemType.Page:
						list.Add(CreateByJson<EndCreditsPageData>(item.ToJson()));
						continue;
					}
				}
				list.Add(CreateByJson<EndCreditsData>(item.ToJson()));
			}
		}
		return list;
	}

	public string ToJson()
	{
		JsonWriter jsonWriter = new JsonWriter();
		JsonMapper.ToJson(this, jsonWriter);
		return jsonWriter.ToString();
	}
}
