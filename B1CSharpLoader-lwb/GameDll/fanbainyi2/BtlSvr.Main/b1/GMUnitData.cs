using System.Collections.Generic;

namespace b1;

public class GMUnitData
{
	public int ResID;

	public string Name;

	public Dictionary<string, Dictionary<string, string>> DictBuff = new Dictionary<string, Dictionary<string, string>>();

	public List<string> HasStateList = new List<string>();

	public List<string> HasSimpleStateList = new List<string>();

	public Dictionary<string, string> DictAttr = new Dictionary<string, string>();

	public void ClearData()
	{
		ResID = 0;
		Name = "";
		DictBuff.Clear();
		HasStateList.Clear();
		HasSimpleStateList.Clear();
		DictAttr.Clear();
	}
}
