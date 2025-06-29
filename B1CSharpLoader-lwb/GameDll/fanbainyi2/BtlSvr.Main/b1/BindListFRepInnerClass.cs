using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListFRepInnerClass : GSBindList<FRepInnerClass>
{
	public delegate RepeatedField<ListDeltaMsgFRepInnerClass> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgFRepInnerClass> DeltaDataCache;

	private RepeatedField<ListDeltaMsgFRepInnerClass> DeltaData
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
						ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgFRepInnerClass);
						return listDeltaMsgFRepInnerClass.Value;
					}
					return (RepeatedField<ClassDeltaMsgFRepInnerClass>)null;
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

	public BindListFRepInnerClass()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(FRepInnerClass Value)
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
				ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass2 = new ListDeltaMsgFRepInnerClass
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgFRepInnerClass2);
				return listDeltaMsgFRepInnerClass2.Value;
			}
			return (RepeatedField<ClassDeltaMsgFRepInnerClass>)null;
		});
		ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
		DeltaData.Add(listDeltaMsgFRepInnerClass);
		Value?.DumpFull(listDeltaMsgFRepInnerClass.Value);
		listDeltaMsgFRepInnerClass.Op = OPType.Add;
		listDeltaMsgFRepInnerClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, FRepInnerClass Value)
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
					ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass2 = new ListDeltaMsgFRepInnerClass
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgFRepInnerClass2);
					return listDeltaMsgFRepInnerClass2.Value;
				}
				return (RepeatedField<ClassDeltaMsgFRepInnerClass>)null;
			});
		}
		ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
		DeltaData.Add(listDeltaMsgFRepInnerClass);
		listDeltaMsgFRepInnerClass.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgFRepInnerClass.Op = OPType.Remove;
		listDeltaMsgFRepInnerClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, FRepInnerClass OldValue, FRepInnerClass NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
		DeltaData.Add(listDeltaMsgFRepInnerClass);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass2 = new ListDeltaMsgFRepInnerClass
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgFRepInnerClass2);
				return listDeltaMsgFRepInnerClass2.Value;
			}
			return (RepeatedField<ClassDeltaMsgFRepInnerClass>)null;
		});
		NewValue?.DumpFull(listDeltaMsgFRepInnerClass.Value);
		listDeltaMsgFRepInnerClass.Idx = (uint)Idx;
		listDeltaMsgFRepInnerClass.Op = OPType.Modify;
		listDeltaMsgFRepInnerClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<FRepInnerClass> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				FRepInnerClass current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
		DeltaData.Add(listDeltaMsgFRepInnerClass);
		listDeltaMsgFRepInnerClass.Op = OPType.Clear;
		listDeltaMsgFRepInnerClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgFRepInnerClass> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgFRepInnerClass
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			FRepInnerClass fRepInnerClass = base[i];
			ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
			fRepInnerClass.DumpFull(listDeltaMsgFRepInnerClass.Value);
			listDeltaMsgFRepInnerClass.Version = version;
			listDeltaMsgFRepInnerClass.Op = OPType.Add;
			Data.Add(listDeltaMsgFRepInnerClass);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<FRepInnerClass> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
