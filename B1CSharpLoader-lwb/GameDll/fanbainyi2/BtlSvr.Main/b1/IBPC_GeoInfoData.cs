using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_GeoInfoData
{
	int CurMapSpriteId { get; set; }

	List<GeoInfoStruct> GetRebirthPointGeoInfoList();

	BindListGeoInfoAreaData GetAreaPointGeoInfoList();

	BindListGeoInfoCustomData GetCustomGeoInfoList();
}
