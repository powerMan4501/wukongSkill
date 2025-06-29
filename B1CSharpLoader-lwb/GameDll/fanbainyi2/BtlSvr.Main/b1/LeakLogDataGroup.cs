using System.Collections.Generic;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class LeakLogDataGroup
{
	public string Key;

	public List<LeakLogData> DataList;

	public LeakLogDataGroup(UObject InWorld)
	{
		Key = ((InWorld != null) ? InWorld.GetFullName() : "None");
		DataList = new List<LeakLogData>();
	}

	public LeakLogDataGroup(string InKey)
	{
		Key = InKey;
		DataList = new List<LeakLogData>();
	}

	public void AddData(LeakLogData Data)
	{
		DataList.Add(Data);
	}

	public override string ToString()
	{
		JsonWriter jsonWriter = new JsonWriter();
		JsonMapper.ToJson(this, jsonWriter);
		return jsonWriter.ToString();
	}
}
