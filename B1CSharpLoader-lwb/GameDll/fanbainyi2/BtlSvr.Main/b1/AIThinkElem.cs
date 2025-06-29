using BtlShare;

namespace b1;

public class AIThinkElem : AIElement
{
	public int ThinkID;

	public EThinkType ThinkType;

	public AIElement CurElem;

	public AIThinkElem(int ID)
	{
		ThinkID = ID;
	}
}
