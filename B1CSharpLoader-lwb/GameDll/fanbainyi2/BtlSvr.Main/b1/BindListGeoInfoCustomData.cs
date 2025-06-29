using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListGeoInfoCustomData : GSBindList<GeoInfoCustomData>
{
	public delegate RepeatedField<ListDeltaMsgGeoInfoCustomData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgGeoInfoCustomData> DeltaDataCache;

	private RepeatedField<ListDeltaMsgGeoInfoCustomData> DeltaData
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
						ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgGeoInfoCustomData);
						return listDeltaMsgGeoInfoCustomData.Value;
					}
					return (RepeatedField<ClassDeltaMsgGeoInfoCustomData>)null;
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

	public BindListGeoInfoCustomData()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(GeoInfoCustomData Value)
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
				ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData2 = new ListDeltaMsgGeoInfoCustomData
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgGeoInfoCustomData2);
				return listDeltaMsgGeoInfoCustomData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGeoInfoCustomData>)null;
		});
		ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData();
		DeltaData.Add(listDeltaMsgGeoInfoCustomData);
		Value?.DumpFull(listDeltaMsgGeoInfoCustomData.Value);
		listDeltaMsgGeoInfoCustomData.Op = OPType.Add;
		listDeltaMsgGeoInfoCustomData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, GeoInfoCustomData Value)
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
					ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData2 = new ListDeltaMsgGeoInfoCustomData
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgGeoInfoCustomData2);
					return listDeltaMsgGeoInfoCustomData2.Value;
				}
				return (RepeatedField<ClassDeltaMsgGeoInfoCustomData>)null;
			});
		}
		ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData();
		DeltaData.Add(listDeltaMsgGeoInfoCustomData);
		listDeltaMsgGeoInfoCustomData.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgGeoInfoCustomData.Op = OPType.Remove;
		listDeltaMsgGeoInfoCustomData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, GeoInfoCustomData OldValue, GeoInfoCustomData NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData();
		DeltaData.Add(listDeltaMsgGeoInfoCustomData);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData2 = new ListDeltaMsgGeoInfoCustomData
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgGeoInfoCustomData2);
				return listDeltaMsgGeoInfoCustomData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGeoInfoCustomData>)null;
		});
		NewValue?.DumpFull(listDeltaMsgGeoInfoCustomData.Value);
		listDeltaMsgGeoInfoCustomData.Idx = (uint)Idx;
		listDeltaMsgGeoInfoCustomData.Op = OPType.Modify;
		listDeltaMsgGeoInfoCustomData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<GeoInfoCustomData> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GeoInfoCustomData current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData();
		DeltaData.Add(listDeltaMsgGeoInfoCustomData);
		listDeltaMsgGeoInfoCustomData.Op = OPType.Clear;
		listDeltaMsgGeoInfoCustomData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgGeoInfoCustomData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgGeoInfoCustomData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			GeoInfoCustomData geoInfoCustomData = base[i];
			ListDeltaMsgGeoInfoCustomData listDeltaMsgGeoInfoCustomData = new ListDeltaMsgGeoInfoCustomData();
			geoInfoCustomData.DumpFull(listDeltaMsgGeoInfoCustomData.Value);
			listDeltaMsgGeoInfoCustomData.Version = version;
			listDeltaMsgGeoInfoCustomData.Op = OPType.Add;
			Data.Add(listDeltaMsgGeoInfoCustomData);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<GeoInfoCustomData> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
