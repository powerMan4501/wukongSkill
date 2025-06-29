using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using GUR.Runtime;

namespace b1;

public class BPC_TransData : IBPC_TransData, IPersistentECSData
{
	private bool __IsTrans_Raw;

	private int __CurActorResId_Raw;

	public SpellType DefaultSpellType { get; set; }

	public Dictionary<int, SpellType> DefaultSpellTypeDict { get; set; }

	public int LastControlUnitResID { get; set; }

	public int PlayerBirthPoint { get; set; }

	[NeedToUI]
	public bool IsTrans
	{
		get
		{
			return __IsTrans_Raw;
		}
		set
		{
			bool _IsTrans_Raw = __IsTrans_Raw;
			__IsTrans_Raw = value;
			OnIsTransChg_Invoke(_IsTrans_Raw, value);
		}
	}

	public EPlayerTransType TransType { get; set; }

	[GSPersistent]
	public int CurActorResId
	{
		get
		{
			return __CurActorResId_Raw;
		}
		set
		{
			int _CurActorResId_Raw = __CurActorResId_Raw;
			__CurActorResId_Raw = value;
			OnCurActorResIdChg_Invoke(_CurActorResId_Raw, value);
		}
	}

	public EPlayerTransBeginType CurEnterTransReason { get; set; }

	public event Action<bool, bool> OnIsTransChg;

	public event Action<int, int> OnCurActorResIdChg;

	private void OnIsTransChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnIsTransChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCurActorResIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCurActorResIdChg?.Invoke(OldValue, NewValue);
		}
	}

	public BPC_TransData()
	{
		DefaultSpellTypeDict = new Dictionary<int, SpellType>();
	}

	public int GetBirthPoint()
	{
		return PlayerBirthPoint;
	}

	public int GetLastControlUnitResID()
	{
		return LastControlUnitResID;
	}

	public bool GetIsTrans()
	{
		return IsTrans;
	}

	public void SetCurActorResId(int ResId)
	{
		CurActorResId = ResId;
	}

	public int GetCurActorResId()
	{
		return CurActorResId;
	}

	public EPlayerTransBeginType GetCurEnterTransReason()
	{
		return CurEnterTransReason;
	}

	public bool IsPlotTrans()
	{
		if (GetCurEnterTransReason() == EPlayerTransBeginType.Plot || GetCurEnterTransReason() == EPlayerTransBeginType.RebirthPoint)
		{
			return true;
		}
		return false;
	}
}
