using System;
using System.Collections.Generic;

namespace b1;

internal class BIC_CalliopeAssetData
{
	public Dictionary<Guid, FCalliopeAssetInfo> CalliopeAssetDictionary { get; } = new Dictionary<Guid, FCalliopeAssetInfo>();

	public List<Guid> WaitForClearAssetList { get; } = new List<Guid>();
}
