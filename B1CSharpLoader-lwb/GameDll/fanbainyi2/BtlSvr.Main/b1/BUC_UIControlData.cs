using System;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BUC_UIControlData : IBUC_UIControlData, IPersistentECSData
{
	private bool __ActiveDeathUI_Raw;

	public bool HasCacheActor;

	private bool OnlyShowByPlayer { get; set; }

	[NeedToUI]
	public bool ActiveDeathUI
	{
		get
		{
			return __ActiveDeathUI_Raw;
		}
		set
		{
			bool _ActiveDeathUI_Raw = __ActiveDeathUI_Raw;
			__ActiveDeathUI_Raw = value;
			OnActiveDeathUIChg_Invoke(_ActiveDeathUI_Raw, value);
		}
	}

	public bool HasLateBeginPlay { get; set; }

	public event Action<bool, bool> OnActiveDeathUIChg;

	private void OnActiveDeathUIChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnActiveDeathUIChg?.Invoke(OldValue, NewValue);
		}
	}

	public bool GetOnlyShowByPlayer()
	{
		return OnlyShowByPlayer;
	}

	public bool GetActiveDeathUI()
	{
		return ActiveDeathUI;
	}

	public void SetOnlyShowByPlayer(bool NewValue)
	{
		OnlyShowByPlayer = NewValue;
	}

	public void SetActiveDeathUI(bool NewValue)
	{
		ActiveDeathUI = NewValue;
	}
}
