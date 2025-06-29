using System;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BGC_CollectionGroupData : IPersistentECSData
{
	private BindDictInt_CollectionGroupDataInfo __CollectionGroupDataInfo_Raw;

	[GSPersistent]
	public BindDictInt_CollectionGroupDataInfo CollectionGroupDataInfo
	{
		get
		{
			return __CollectionGroupDataInfo_Raw;
		}
		set
		{
			BindDictInt_CollectionGroupDataInfo _CollectionGroupDataInfo_Raw = __CollectionGroupDataInfo_Raw;
			__CollectionGroupDataInfo_Raw = value;
			OnCollectionGroupDataInfoChg_Invoke(_CollectionGroupDataInfo_Raw, value);
		}
	}

	public event Action<BindDictInt_CollectionGroupDataInfo, BindDictInt_CollectionGroupDataInfo> OnCollectionGroupDataInfoChg;

	public BGC_CollectionGroupData()
	{
		CollectionGroupDataInfo = new BindDictInt_CollectionGroupDataInfo();
	}

	private void OnCollectionGroupDataInfoChg_Invoke(BindDictInt_CollectionGroupDataInfo OldValue, BindDictInt_CollectionGroupDataInfo NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnCollectionGroupDataInfoChg?.Invoke(OldValue, NewValue);
		}
	}
}
