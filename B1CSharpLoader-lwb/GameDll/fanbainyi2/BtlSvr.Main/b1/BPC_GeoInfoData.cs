using System;
using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BPC_GeoInfoData : IPersistentECSData, IBPC_GeoInfoData
{
	private BindListGeoInfoAreaData __AreaPointGeoInfoList_Raw;

	private BindListGeoInfoCustomData __CustomGeoInfoList_Raw;

	private int __CurMapSpriteId_Raw;

	public List<GeoInfoStruct> RebirthPointGeoInfoList { get; set; } = new List<GeoInfoStruct>();

	[GSPersistent]
	public BindListGeoInfoAreaData AreaPointGeoInfoList
	{
		get
		{
			return __AreaPointGeoInfoList_Raw;
		}
		set
		{
			BindListGeoInfoAreaData _AreaPointGeoInfoList_Raw = __AreaPointGeoInfoList_Raw;
			__AreaPointGeoInfoList_Raw = value;
			OnAreaPointGeoInfoListChg_Invoke(_AreaPointGeoInfoList_Raw, value);
		}
	}

	[GSPersistent]
	public BindListGeoInfoCustomData CustomGeoInfoList
	{
		get
		{
			return __CustomGeoInfoList_Raw;
		}
		set
		{
			BindListGeoInfoCustomData _CustomGeoInfoList_Raw = __CustomGeoInfoList_Raw;
			__CustomGeoInfoList_Raw = value;
			OnCustomGeoInfoListChg_Invoke(_CustomGeoInfoList_Raw, value);
		}
	}

	[GSPersistent]
	public int CurMapSpriteId
	{
		get
		{
			return __CurMapSpriteId_Raw;
		}
		set
		{
			int _CurMapSpriteId_Raw = __CurMapSpriteId_Raw;
			__CurMapSpriteId_Raw = value;
			OnCurMapSpriteIdChg_Invoke(_CurMapSpriteId_Raw, value);
		}
	}

	public event Action<BindListGeoInfoAreaData, BindListGeoInfoAreaData> OnAreaPointGeoInfoListChg;

	public event Action<BindListGeoInfoCustomData, BindListGeoInfoCustomData> OnCustomGeoInfoListChg;

	public event Action<int, int> OnCurMapSpriteIdChg;

	public BPC_GeoInfoData()
	{
		AreaPointGeoInfoList = new BindListGeoInfoAreaData();
		CustomGeoInfoList = new BindListGeoInfoCustomData();
	}

	public List<GeoInfoStruct> GetRebirthPointGeoInfoList()
	{
		return RebirthPointGeoInfoList;
	}

	public BindListGeoInfoAreaData GetAreaPointGeoInfoList()
	{
		return AreaPointGeoInfoList;
	}

	public BindListGeoInfoCustomData GetCustomGeoInfoList()
	{
		return CustomGeoInfoList;
	}

	private void OnAreaPointGeoInfoListChg_Invoke(BindListGeoInfoAreaData OldValue, BindListGeoInfoAreaData NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnAreaPointGeoInfoListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCustomGeoInfoListChg_Invoke(BindListGeoInfoCustomData OldValue, BindListGeoInfoCustomData NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnCustomGeoInfoListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCurMapSpriteIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCurMapSpriteIdChg?.Invoke(OldValue, NewValue);
		}
	}
}
