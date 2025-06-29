using System.Collections.Generic;

namespace b1.UI.Comm;

public class PageData
{
	public List<EndCreditsPageData> PageList = new List<EndCreditsPageData>();

	public bool IsValid()
	{
		return PageList.Count > 0;
	}
}
