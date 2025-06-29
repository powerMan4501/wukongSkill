using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class CacheMIDInfo
{
	public int MaterialQuality = -1;

	public float LastSetMatQualityTime;

	public Dictionary<FMaterialLayerMappingInfo, Dictionary<FName, MaterialParamInfo>> CacheMaterialLayerParamInfoDic = new Dictionary<FMaterialLayerMappingInfo, Dictionary<FName, MaterialParamInfo>>();
}
