using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class PlayerMagicSkillCd
{
	public delegate RepeatedField<ClassDeltaMsgPlayerMagicSkillCd> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgPlayerMagicSkillCd> DeltaDataCache;

	private int __SkillId_Raw;

	private float __CoolDown_Raw;

	protected RepeatedField<ClassDeltaMsgPlayerMagicSkillCd> DeltaData
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

	[GSPersistent]
	public int SkillId
	{
		get
		{
			return __SkillId_Raw;
		}
		set
		{
			int _SkillId_Raw = __SkillId_Raw;
			__SkillId_Raw = value;
			OnSkillIdChg_Invoke(_SkillId_Raw, value);
		}
	}

	[GSPersistent]
	public float CoolDown
	{
		get
		{
			return __CoolDown_Raw;
		}
		set
		{
			float _CoolDown_Raw = __CoolDown_Raw;
			__CoolDown_Raw = value;
			OnCoolDownChg_Invoke(_CoolDown_Raw, value);
		}
	}

	public event Action<int, int> OnSkillIdChg;

	public event Action<float, float> OnCoolDownChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgPlayerMagicSkillCd> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgPlayerMagicSkillCd
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgPlayerMagicSkillCd classDeltaMsgPlayerMagicSkillCd = new ClassDeltaMsgPlayerMagicSkillCd();
		classDeltaMsgPlayerMagicSkillCd.Op = OPType.Modify;
		classDeltaMsgPlayerMagicSkillCd.Version = version;
		classDeltaMsgPlayerMagicSkillCd.Value = new GurGsStruct.PlayerMagicSkillCd();
		Data.Add(classDeltaMsgPlayerMagicSkillCd);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnSkillIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnSkillIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCoolDownChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCoolDownChg?.Invoke(OldValue, NewValue);
		}
	}
}
