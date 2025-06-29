using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BPC_RoleBaseData : IBPC_RoleBaseData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public RoleBaseData[] _RepData = new RoleBaseData[64];

	private string __RoleName_Raw;

	private ulong __RoleId_Raw;

	private int __RoleLevel_Raw;

	private int __SoulSkillID_Raw;

	private BindDictEquipPosition_Int __EquipList_Raw;

	private BindDictInt_Int __TalenList_Raw;

	[NeedToUI]
	[GSReplicated]
	public string RoleName
	{
		get
		{
			return __RoleName_Raw;
		}
		set
		{
			string _RoleName_Raw = __RoleName_Raw;
			__RoleName_Raw = value;
			OnRoleNameChg_Invoke(_RoleName_Raw, value);
		}
	}

	[NeedToUI]
	[GSReplicated]
	public ulong RoleId
	{
		get
		{
			return __RoleId_Raw;
		}
		set
		{
			ulong _RoleId_Raw = __RoleId_Raw;
			__RoleId_Raw = value;
			OnRoleIdChg_Invoke(_RoleId_Raw, value);
		}
	}

	[NeedToUI]
	[GSReplicated]
	public int RoleLevel
	{
		get
		{
			return __RoleLevel_Raw;
		}
		set
		{
			int _RoleLevel_Raw = __RoleLevel_Raw;
			__RoleLevel_Raw = value;
			OnRoleLevelChg_Invoke(_RoleLevel_Raw, value);
		}
	}

	[GSReplicated]
	public int SoulSkillID
	{
		get
		{
			return __SoulSkillID_Raw;
		}
		set
		{
			int _SoulSkillID_Raw = __SoulSkillID_Raw;
			__SoulSkillID_Raw = value;
			OnSoulSkillIDChg_Invoke(_SoulSkillID_Raw, value);
		}
	}

	[GSReplicated]
	public BindDictEquipPosition_Int EquipList
	{
		get
		{
			return __EquipList_Raw;
		}
		set
		{
			BindDictEquipPosition_Int _EquipList_Raw = __EquipList_Raw;
			__EquipList_Raw = value;
			OnEquipListChg_Invoke(_EquipList_Raw, value);
		}
	}

	[GSReplicated]
	public BindDictInt_Int TalenList
	{
		get
		{
			return __TalenList_Raw;
		}
		set
		{
			BindDictInt_Int _TalenList_Raw = __TalenList_Raw;
			__TalenList_Raw = value;
			OnTalenListChg_Invoke(_TalenList_Raw, value);
		}
	}

	public event Action<string, string> OnRoleNameChg;

	public event Action<ulong, ulong> OnRoleIdChg;

	public event Action<int, int> OnRoleLevelChg;

	public event Action<int, int> OnSoulSkillIDChg;

	public event Action<BindDictEquipPosition_Int, BindDictEquipPosition_Int> OnEquipListChg;

	public event Action<BindDictInt_Int, BindDictInt_Int> OnTalenListChg;

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
		if (IsActive)
		{
			EquipList?.RegGetDeltaDataFunc(AllocRepDataForEquipList);
			TalenList?.RegGetDeltaDataFunc(AllocRepDataForTalenList);
		}
		else
		{
			EquipList?.RegGetDeltaDataFunc(null);
			TalenList?.RegGetDeltaDataFunc(null);
		}
		EquipList?.RefreshGetDeltaDataFunc(IsActive);
		TalenList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<DictDeltaMsgEquipPosition_Int> AllocRepDataForEquipList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().EquipList;
		}
		return null;
	}

	private RepeatedField<DictDeltaMsgInt_Int> AllocRepDataForTalenList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TalenList;
		}
		return null;
	}

	public RoleBaseData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		RoleBaseData roleBaseData = _RepData[__LocalRepVersion % 64];
		if (roleBaseData == null)
		{
			roleBaseData = new RoleBaseData();
			EquipList?.ClearDeltaData();
			TalenList?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = roleBaseData;
		}
		else if (flag)
		{
			roleBaseData.ClearRoleName();
			roleBaseData.ClearRoleId();
			roleBaseData.ClearRoleLevel();
			roleBaseData.ClearSoulSkillID();
			roleBaseData.EquipList.Clear();
			EquipList?.ClearDeltaData();
			roleBaseData.TalenList.Clear();
			TalenList?.ClearDeltaData();
		}
		return roleBaseData;
	}

	public RoleBaseData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			EquipList?.ClearDeltaData();
			TalenList?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		RoleBaseData roleBaseData = new RoleBaseData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"RoleBaseData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			roleBaseData.RoleName = ((RoleName == null) ? string.Empty : RoleName);
			roleBaseData.RoleId = RoleId;
			roleBaseData.RoleLevel = RoleLevel;
			roleBaseData.SoulSkillID = SoulSkillID;
			if (EquipList == null)
			{
				roleBaseData.EquipList.Add(new DictDeltaMsgEquipPosition_Int
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				EquipList.DumpFull(roleBaseData.EquipList);
			}
			if (TalenList == null)
			{
				roleBaseData.TalenList.Add(new DictDeltaMsgInt_Int
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TalenList.DumpFull(roleBaseData.TalenList);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					RoleBaseData other = _RepData[i % 64];
					roleBaseData.MergeFrom(other);
				}
			}
		}
		return roleBaseData;
	}

	private void OnRoleNameChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().RoleName = ((NewValue == null) ? string.Empty : NewValue);
			}
			this.OnRoleNameChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnRoleIdChg_Invoke(ulong OldValue, ulong NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().RoleId = NewValue;
			}
			this.OnRoleIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnRoleLevelChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().RoleLevel = NewValue;
			}
			this.OnRoleLevelChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnSoulSkillIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().SoulSkillID = NewValue;
			}
			this.OnSoulSkillIDChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnEquipListChg_Invoke(BindDictEquipPosition_Int OldValue, BindDictEquipPosition_Int NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			RoleBaseData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.EquipList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.EquipList.Add(new DictDeltaMsgEquipPosition_Int
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.EquipList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForEquipList);
		this.OnEquipListChg?.Invoke(OldValue, NewValue);
	}

	private void OnTalenListChg_Invoke(BindDictInt_Int OldValue, BindDictInt_Int NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			RoleBaseData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TalenList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TalenList.Add(new DictDeltaMsgInt_Int
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TalenList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTalenList);
		this.OnTalenListChg?.Invoke(OldValue, NewValue);
	}

	public BPC_RoleBaseData()
	{
		EquipList = new BindDictEquipPosition_Int();
		TalenList = new BindDictInt_Int();
	}

	public void Init(string _RoleName, ulong _RoleId, int _RoleLevel)
	{
		RoleName = _RoleName;
		RoleId = _RoleId;
		RoleLevel = _RoleLevel;
	}
}
