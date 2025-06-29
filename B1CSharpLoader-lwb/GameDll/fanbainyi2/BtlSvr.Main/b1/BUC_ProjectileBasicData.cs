using System;
using b1.ECS;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using GurGsReplicate;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectileBasicData : IPersistentECSData, IBUC_ProjectileBasicData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public ProjectileBasicData[] _RepData = new ProjectileBasicData[64];

	private int __ProjectileID_Raw;

	public int SkillID;

	public bool UseSocket_Spawn;

	public FName SpawnPointName;

	public int ProjectileSpecificFlags;

	public EBGUProjectileStatus BulletStatus;

	public bool isFacingTarget;

	public AActor FacingTarget;

	public bool bNotify_SpawnFinished;

	public EProjectileCheckShapeType CheckShapeType;

	[GSReplicated]
	public int ProjectileID
	{
		get
		{
			return __ProjectileID_Raw;
		}
		set
		{
			int _ProjectileID_Raw = __ProjectileID_Raw;
			__ProjectileID_Raw = value;
			OnProjectileIDChg_Invoke(_ProjectileID_Raw, value);
		}
	}

	public EBGUBulletType ProjectileType { get; set; }

	public event Action<int, int> OnProjectileIDChg;

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

	public ProjectileBasicData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		ProjectileBasicData projectileBasicData = _RepData[__LocalRepVersion % 64];
		if (projectileBasicData == null)
		{
			projectileBasicData = new ProjectileBasicData();
			_RepData[__LocalRepVersion % 64] = projectileBasicData;
		}
		else if (flag)
		{
			projectileBasicData.ClearProjectileID();
		}
		return projectileBasicData;
	}

	public ProjectileBasicData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		ProjectileBasicData projectileBasicData = new ProjectileBasicData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"ProjectileBasicData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			projectileBasicData.ProjectileID = ProjectileID;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					ProjectileBasicData other = _RepData[i % 64];
					projectileBasicData.MergeFrom(other);
				}
			}
		}
		return projectileBasicData;
	}

	private void OnProjectileIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().ProjectileID = NewValue;
			}
			this.OnProjectileIDChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_ProjectileBasicData()
	{
		ProjectileID = -1;
		SkillID = -1;
		UseSocket_Spawn = false;
		ProjectileType = EBGUBulletType.NormalSpawn;
		BulletStatus = EBGUProjectileStatus.Active;
		isFacingTarget = false;
		FacingTarget = null;
		bNotify_SpawnFinished = false;
		CheckShapeType = EProjectileCheckShapeType.DefaultShape;
	}
}
