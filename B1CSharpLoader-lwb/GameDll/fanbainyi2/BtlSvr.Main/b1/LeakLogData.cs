using LitJson;

namespace b1;

public class LeakLogData
{
	public override string ToString()
	{
		JsonWriter jsonWriter = new JsonWriter();
		JsonMapper.ToJson(this, jsonWriter);
		return jsonWriter.ToString();
	}
}
