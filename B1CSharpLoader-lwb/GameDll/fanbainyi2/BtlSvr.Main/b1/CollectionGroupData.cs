using System.Collections.Generic;
using GurGsPersistent;

namespace b1;

public class CollectionGroupData
{
	public int GroupId { get; set; }

	public GurGsPersistent.CollectionGroupDataInfo CollectionGroupDataInfo { get; set; }

	public Dictionary<string, GurGsPersistent.BUC_CollectionData> CollectionDataGuidDict { get; set; } = new Dictionary<string, GurGsPersistent.BUC_CollectionData>();
}
