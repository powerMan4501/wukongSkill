using System.Collections.Generic;

namespace b1;

public class AIElement
{
	public AIElement ParentElem;

	public List<AIElement> ChildElems;

	public float OriScore;

	public float CurScore;

	public AIElement()
	{
		ChildElems = new List<AIElement>();
	}
}
