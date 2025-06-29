namespace b1;

public class FSpiderNavPointLinkInfo
{
	public int LinkPointIndex;

	public float Cost;

	public FSpiderNavPointLinkInfo()
	{
	}

	public FSpiderNavPointLinkInfo(FSpiderNavPointLinkInfo NavPointLinkInfo)
	{
		LinkPointIndex = NavPointLinkInfo.LinkPointIndex;
		Cost = NavPointLinkInfo.Cost;
	}

	public FSpiderNavPointLinkInfo(FGsSpiderNavPointLinkInfo NavPointLink)
	{
		LinkPointIndex = NavPointLink.LinkPointIndex;
		Cost = NavPointLink.Cost;
	}
}
