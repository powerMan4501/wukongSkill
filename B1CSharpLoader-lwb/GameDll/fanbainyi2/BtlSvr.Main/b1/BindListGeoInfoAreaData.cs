using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListGeoInfoAreaData : GSBindList<GeoInfoAreaData>
{
	public delegate RepeatedField<ListDeltaMsgGeoInfoAreaData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgGeoInfoAreaData> DeltaDataCache;

	private RepeatedField<ListDeltaMsgGeoInfoAreaData> DeltaData
	{
		get
		{
			if (GetDeltaDataFunc != null && DeltaDataCache == null)
			{
				DeltaDataCache = GetDeltaDataFunc();
			}
			return DeltaDataCache;
		}
	}

	public void RefreshGetDeltaDataFunc(bool IsActive)
	{
		for (int i = 0; i < base.Count; i++)
		{
			uint ItemIdx = (uint)i;
			if (IsActive)
			{
				base[i].RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgGeoInfoAreaData);
						return listDeltaMsgGeoInfoAreaData.Value;
					}
					return (RepeatedField<ClassDeltaMsgGeoInfoAreaData>)null;
				});
			}
			else
			{
				base[i].RegGetDeltaDataFunc(null);
			}
		}
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
		BindDataChangeFunc(Func != null);
	}

	private void BindDataChangeFunc(bool IsBind)
	{
		if (IsBind != IsBindDataChangeFunc)
		{
			if (IsBind)
			{
				base.OnAdd += OnAddImpl;
				base.OnRemove += OnRemoveImpl;
				base.OnSetIdxValue += OnSetIdxValueImpl;
				OnClear = (Action)Delegate.Combine(OnClear, new Action(OnClearImpl));
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				base.OnRemove -= OnRemoveImpl;
				base.OnSetIdxValue -= OnSetIdxValueImpl;
				OnClear = (Action)Delegate.Remove(OnClear, new Action(OnClearImpl));
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindListGeoInfoAreaData()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(GeoInfoAreaData Value)
	{
		if (DeltaData == null)
		{
			return;
		}
		Value?.ClearDeltaData();
		int Idx = base.Count - 1;
		Value?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData2 = new ListDeltaMsgGeoInfoAreaData
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgGeoInfoAreaData2);
				return listDeltaMsgGeoInfoAreaData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGeoInfoAreaData>)null;
		});
		ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData();
		DeltaData.Add(listDeltaMsgGeoInfoAreaData);
		Value?.DumpFull(listDeltaMsgGeoInfoAreaData.Value);
		listDeltaMsgGeoInfoAreaData.Op = OPType.Add;
		listDeltaMsgGeoInfoAreaData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, GeoInfoAreaData Value)
	{
		if (DeltaData == null)
		{
			return;
		}
		for (int i = 0; i < base.Count; i++)
		{
			if (i <= Idx)
			{
				continue;
			}
			uint ItemIdx = (uint)(i - 1);
			base[i].RegGetDeltaDataFunc(delegate
			{
				if (DeltaData != null)
				{
					ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData2 = new ListDeltaMsgGeoInfoAreaData
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgGeoInfoAreaData2);
					return listDeltaMsgGeoInfoAreaData2.Value;
				}
				return (RepeatedField<ClassDeltaMsgGeoInfoAreaData>)null;
			});
		}
		ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData();
		DeltaData.Add(listDeltaMsgGeoInfoAreaData);
		listDeltaMsgGeoInfoAreaData.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgGeoInfoAreaData.Op = OPType.Remove;
		listDeltaMsgGeoInfoAreaData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, GeoInfoAreaData OldValue, GeoInfoAreaData NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData();
		DeltaData.Add(listDeltaMsgGeoInfoAreaData);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData2 = new ListDeltaMsgGeoInfoAreaData
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgGeoInfoAreaData2);
				return listDeltaMsgGeoInfoAreaData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGeoInfoAreaData>)null;
		});
		NewValue?.DumpFull(listDeltaMsgGeoInfoAreaData.Value);
		listDeltaMsgGeoInfoAreaData.Idx = (uint)Idx;
		listDeltaMsgGeoInfoAreaData.Op = OPType.Modify;
		listDeltaMsgGeoInfoAreaData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<GeoInfoAreaData> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GeoInfoAreaData current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData();
		DeltaData.Add(listDeltaMsgGeoInfoAreaData);
		listDeltaMsgGeoInfoAreaData.Op = OPType.Clear;
		listDeltaMsgGeoInfoAreaData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgGeoInfoAreaData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgGeoInfoAreaData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			GeoInfoAreaData geoInfoAreaData = base[i];
			ListDeltaMsgGeoInfoAreaData listDeltaMsgGeoInfoAreaData = new ListDeltaMsgGeoInfoAreaData();
			geoInfoAreaData.DumpFull(listDeltaMsgGeoInfoAreaData.Value);
			listDeltaMsgGeoInfoAreaData.Version = version;
			listDeltaMsgGeoInfoAreaData.Op = OPType.Add;
			Data.Add(listDeltaMsgGeoInfoAreaData);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<GeoInfoAreaData> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
