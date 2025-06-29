using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListPlayerMagicSkillCd : GSBindList<PlayerMagicSkillCd>
{
	public delegate RepeatedField<ListDeltaMsgPlayerMagicSkillCd> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgPlayerMagicSkillCd> DeltaDataCache;

	private RepeatedField<ListDeltaMsgPlayerMagicSkillCd> DeltaData
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
						ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgPlayerMagicSkillCd);
						return listDeltaMsgPlayerMagicSkillCd.Value;
					}
					return (RepeatedField<ClassDeltaMsgPlayerMagicSkillCd>)null;
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

	public BindListPlayerMagicSkillCd()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(PlayerMagicSkillCd Value)
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
				ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd2 = new ListDeltaMsgPlayerMagicSkillCd
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerMagicSkillCd2);
				return listDeltaMsgPlayerMagicSkillCd2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerMagicSkillCd>)null;
		});
		ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd();
		DeltaData.Add(listDeltaMsgPlayerMagicSkillCd);
		Value?.DumpFull(listDeltaMsgPlayerMagicSkillCd.Value);
		listDeltaMsgPlayerMagicSkillCd.Op = OPType.Add;
		listDeltaMsgPlayerMagicSkillCd.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, PlayerMagicSkillCd Value)
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
					ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd2 = new ListDeltaMsgPlayerMagicSkillCd
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgPlayerMagicSkillCd2);
					return listDeltaMsgPlayerMagicSkillCd2.Value;
				}
				return (RepeatedField<ClassDeltaMsgPlayerMagicSkillCd>)null;
			});
		}
		ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd();
		DeltaData.Add(listDeltaMsgPlayerMagicSkillCd);
		listDeltaMsgPlayerMagicSkillCd.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgPlayerMagicSkillCd.Op = OPType.Remove;
		listDeltaMsgPlayerMagicSkillCd.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, PlayerMagicSkillCd OldValue, PlayerMagicSkillCd NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd();
		DeltaData.Add(listDeltaMsgPlayerMagicSkillCd);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd2 = new ListDeltaMsgPlayerMagicSkillCd
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerMagicSkillCd2);
				return listDeltaMsgPlayerMagicSkillCd2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerMagicSkillCd>)null;
		});
		NewValue?.DumpFull(listDeltaMsgPlayerMagicSkillCd.Value);
		listDeltaMsgPlayerMagicSkillCd.Idx = (uint)Idx;
		listDeltaMsgPlayerMagicSkillCd.Op = OPType.Modify;
		listDeltaMsgPlayerMagicSkillCd.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<PlayerMagicSkillCd> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				PlayerMagicSkillCd current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd();
		DeltaData.Add(listDeltaMsgPlayerMagicSkillCd);
		listDeltaMsgPlayerMagicSkillCd.Op = OPType.Clear;
		listDeltaMsgPlayerMagicSkillCd.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgPlayerMagicSkillCd> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgPlayerMagicSkillCd
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			PlayerMagicSkillCd playerMagicSkillCd = base[i];
			ListDeltaMsgPlayerMagicSkillCd listDeltaMsgPlayerMagicSkillCd = new ListDeltaMsgPlayerMagicSkillCd();
			playerMagicSkillCd.DumpFull(listDeltaMsgPlayerMagicSkillCd.Value);
			listDeltaMsgPlayerMagicSkillCd.Version = version;
			listDeltaMsgPlayerMagicSkillCd.Op = OPType.Add;
			Data.Add(listDeltaMsgPlayerMagicSkillCd);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<PlayerMagicSkillCd> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
