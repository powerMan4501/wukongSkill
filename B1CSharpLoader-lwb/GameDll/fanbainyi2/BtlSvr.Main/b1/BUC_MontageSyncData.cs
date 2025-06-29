using System;
using b1.ECS;
using GUR.Runtime;
using GurGsReplicate;
using UnrealEngine.Engine;

namespace b1;

public class BUC_MontageSyncData : IPersistentECSData
{
	public USkeletalMeshComponent SkeletalMesh;

	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public MontageSyncData[] _RepData = new MontageSyncData[64];

	private bool __IsPlayingMontage_Raw;

	private string __MontagePath_Raw;

	private float __Position_Raw;

	[GSReplicated]
	public bool IsPlayingMontage
	{
		get
		{
			return __IsPlayingMontage_Raw;
		}
		set
		{
			bool _IsPlayingMontage_Raw = __IsPlayingMontage_Raw;
			__IsPlayingMontage_Raw = value;
			OnIsPlayingMontageChg_Invoke(_IsPlayingMontage_Raw, value);
		}
	}

	[GSReplicated]
	public string MontagePath
	{
		get
		{
			return __MontagePath_Raw;
		}
		set
		{
			string _MontagePath_Raw = __MontagePath_Raw;
			__MontagePath_Raw = value;
			OnMontagePathChg_Invoke(_MontagePath_Raw, value);
		}
	}

	[GSReplicated]
	public float Position
	{
		get
		{
			return __Position_Raw;
		}
		set
		{
			float _Position_Raw = __Position_Raw;
			__Position_Raw = value;
			OnPositionChg_Invoke(_Position_Raw, value);
		}
	}

	public event Action<bool, bool> OnIsPlayingMontageChg;

	public event Action<string, string> OnMontagePathChg;

	public event Action<float, float> OnPositionChg;

	public BUC_MontageSyncData()
	{
		IsPlayingMontage = false;
		MontagePath = "";
		Position = 0f;
	}

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public MontageSyncData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		MontageSyncData montageSyncData = _RepData[__LocalRepVersion % 64];
		if (montageSyncData == null)
		{
			montageSyncData = new MontageSyncData();
			_RepData[__LocalRepVersion % 64] = montageSyncData;
		}
		else if (flag)
		{
			montageSyncData.ClearIsPlayingMontage();
			montageSyncData.ClearMontagePath();
			montageSyncData.ClearPosition();
		}
		return montageSyncData;
	}

	public MontageSyncData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		MontageSyncData montageSyncData = new MontageSyncData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"MontageSyncData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			montageSyncData.IsPlayingMontage = IsPlayingMontage;
			montageSyncData.MontagePath = ((MontagePath == null) ? string.Empty : MontagePath);
			montageSyncData.Position = Position;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					MontageSyncData other = _RepData[i % 64];
					montageSyncData.MergeFrom(other);
				}
			}
		}
		return montageSyncData;
	}

	private void OnIsPlayingMontageChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().IsPlayingMontage = NewValue;
			}
			this.OnIsPlayingMontageChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMontagePathChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().MontagePath = ((NewValue == null) ? string.Empty : NewValue);
			}
			this.OnMontagePathChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPositionChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().Position = NewValue;
			}
			this.OnPositionChg?.Invoke(OldValue, NewValue);
		}
	}
}
