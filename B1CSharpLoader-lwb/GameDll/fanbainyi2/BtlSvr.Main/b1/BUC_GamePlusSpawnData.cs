using System;
using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

public class BUC_GamePlusSpawnData : b1.IBUC_GamePlusSpawnData, IPersistentECSData
{
	private bool __DestoryForever_Raw;

	private double __LastCollectTime_Raw;

	private int __CurCD_Raw;

	private int __LastCollectGamePlayCount_Raw;

	private int __CollectionCount_Raw;

	public List<GamePlusSpawnConfig> GamePlusSpawnConfigList { get; set; }

	public int TargetSpawnActorIndex { get; set; }

	public AActor CurSpawnActor { get; set; }

	[GSPersistent]
	public bool DestoryForever
	{
		get
		{
			return __DestoryForever_Raw;
		}
		set
		{
			bool _DestoryForever_Raw = __DestoryForever_Raw;
			__DestoryForever_Raw = value;
			OnDestoryForeverChg_Invoke(_DestoryForever_Raw, value);
		}
	}

	[GSPersistent]
	public double LastCollectTime
	{
		get
		{
			return __LastCollectTime_Raw;
		}
		set
		{
			double _LastCollectTime_Raw = __LastCollectTime_Raw;
			__LastCollectTime_Raw = value;
			OnLastCollectTimeChg_Invoke(_LastCollectTime_Raw, value);
		}
	}

	[GSPersistent]
	public int CurCD
	{
		get
		{
			return __CurCD_Raw;
		}
		set
		{
			int _CurCD_Raw = __CurCD_Raw;
			__CurCD_Raw = value;
			OnCurCDChg_Invoke(_CurCD_Raw, value);
		}
	}

	[GSPersistent]
	public int LastCollectGamePlayCount
	{
		get
		{
			return __LastCollectGamePlayCount_Raw;
		}
		set
		{
			int _LastCollectGamePlayCount_Raw = __LastCollectGamePlayCount_Raw;
			__LastCollectGamePlayCount_Raw = value;
			OnLastCollectGamePlayCountChg_Invoke(_LastCollectGamePlayCount_Raw, value);
		}
	}

	[GSPersistent]
	public int CollectionCount
	{
		get
		{
			return __CollectionCount_Raw;
		}
		set
		{
			int _CollectionCount_Raw = __CollectionCount_Raw;
			__CollectionCount_Raw = value;
			OnCollectionCountChg_Invoke(_CollectionCount_Raw, value);
		}
	}

	public int CollectionCountMax { get; set; }

	public int TaskStageId { get; set; }

	public int TaskStageStage { get; set; }

	public bool TaskStageFinish { get; set; }

	public event Action<bool, bool> OnDestoryForeverChg;

	public event Action<double, double> OnLastCollectTimeChg;

	public event Action<int, int> OnCurCDChg;

	public event Action<int, int> OnLastCollectGamePlayCountChg;

	public event Action<int, int> OnCollectionCountChg;

	private void OnDestoryForeverChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnDestoryForeverChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastCollectTimeChg_Invoke(double OldValue, double NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLastCollectTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCurCDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCurCDChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastCollectGamePlayCountChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLastCollectGamePlayCountChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCollectionCountChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCollectionCountChg?.Invoke(OldValue, NewValue);
		}
	}
}
