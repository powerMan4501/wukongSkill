using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using GUR.Runtime;

namespace b1;

public class BUC_PlayerSpellConfData : IBUC_PlayerSpellConfData, IPersistentECSData
{
	private int __CurrentTransFormID_Raw;

	public SpellType DefaultSpellType { get; set; }

	public List<FUStMagicConfInfo> MagicConfInfo { get; set; }

	[NeedToUI]
	public int CurrentTransFormID
	{
		get
		{
			return __CurrentTransFormID_Raw;
		}
		set
		{
			int _CurrentTransFormID_Raw = __CurrentTransFormID_Raw;
			__CurrentTransFormID_Raw = value;
			OnCurrentTransFormIDChg_Invoke(_CurrentTransFormID_Raw, value);
		}
	}

	public event Action<int, int> OnCurrentTransFormIDChg;

	private void OnCurrentTransFormIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCurrentTransFormIDChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_PlayerSpellConfData()
	{
		MagicConfInfo = new List<FUStMagicConfInfo>();
	}
}
