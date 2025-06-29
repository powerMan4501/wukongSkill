using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using GUR.Runtime;

namespace b1;

public class BUC_ActorInitData : b1.IBUC_ActorInitData, IPersistentECSData
{
	private bool __PersistentDataDontResetOnNewGamePlus_Raw;

	public Dictionary<EInitDataModuleType, GSInitDataModuleBase> InitData { get; set; } = new Dictionary<EInitDataModuleType, GSInitDataModuleBase>();

	public bool HasInitialized { get; set; }

	public bool bSaveInitData { get; set; }

	public EBGUResetType ActorResetType { get; set; }

	public bool PersistentDataDontResetOnNewGamePlusFromConfig { get; set; }

	[GSPersistent]
	public bool PersistentDataDontResetOnNewGamePlus
	{
		get
		{
			return __PersistentDataDontResetOnNewGamePlus_Raw;
		}
		set
		{
			bool _PersistentDataDontResetOnNewGamePlus_Raw = __PersistentDataDontResetOnNewGamePlus_Raw;
			__PersistentDataDontResetOnNewGamePlus_Raw = value;
			OnPersistentDataDontResetOnNewGamePlusChg_Invoke(_PersistentDataDontResetOnNewGamePlus_Raw, value);
		}
	}

	public event Action<bool, bool> OnPersistentDataDontResetOnNewGamePlusChg;

	private void OnPersistentDataDontResetOnNewGamePlusChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPersistentDataDontResetOnNewGamePlusChg?.Invoke(OldValue, NewValue);
		}
	}

	public GSInitDataModuleBase GetInitDataModule(EInitDataModuleType Type)
	{
		if (InitData.ContainsKey(Type))
		{
			return InitData[Type];
		}
		return null;
	}
}
