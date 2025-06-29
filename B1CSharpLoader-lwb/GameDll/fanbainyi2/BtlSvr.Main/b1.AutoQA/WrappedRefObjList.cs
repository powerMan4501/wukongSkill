using System.Collections.Generic;

namespace b1.AutoQA;

public class WrappedRefObjList
{
	public string ClassType;

	public List<WrappedRefObj> RefObjList = new List<WrappedRefObj>();

	public WrappedRefObjList(string InClassType)
	{
		ClassType = InClassType;
	}
}
