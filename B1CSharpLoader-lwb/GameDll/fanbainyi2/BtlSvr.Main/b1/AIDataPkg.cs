using System.Collections.Generic;

namespace b1;

public class AIDataPkg
{
	public List<AIDataBase> DataList;

	public AIDataPkg()
	{
		DataList = new List<AIDataBase>();
	}

	public void AddData(AIDataBase Data)
	{
		DataList.Add(Data);
	}

	public void AddDataPkg(AIDataPkg Pkg)
	{
		DataList.AddRange(Pkg.DataList);
	}

	public bool IsPkgValid()
	{
		if (DataList.Count == 0)
		{
			return false;
		}
		return true;
	}
}
