using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_CircusControlData : IBGC_CircusControlData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public CircusControlData[] _RepData = new CircusControlData[64];

	private BindListString __AlwaysSpawnTamerGuidList_Raw;

	private BindListString __NeverSpawnTamerGuidList_Raw;

	public List<CircusMember> CircusRootMembers { get; set; }

	public Dictionary<string, CircusMember> CircusRootMemberMapping { get; set; }

	public Dictionary<string, CircusExtraData> ExtraData { get; set; }

	[GSReplicated]
	public BindListString AlwaysSpawnTamerGuidList
	{
		get
		{
			return __AlwaysSpawnTamerGuidList_Raw;
		}
		set
		{
			BindListString _AlwaysSpawnTamerGuidList_Raw = __AlwaysSpawnTamerGuidList_Raw;
			__AlwaysSpawnTamerGuidList_Raw = value;
			OnAlwaysSpawnTamerGuidListChg_Invoke(_AlwaysSpawnTamerGuidList_Raw, value);
		}
	}

	[GSReplicated]
	public BindListString NeverSpawnTamerGuidList
	{
		get
		{
			return __NeverSpawnTamerGuidList_Raw;
		}
		set
		{
			BindListString _NeverSpawnTamerGuidList_Raw = __NeverSpawnTamerGuidList_Raw;
			__NeverSpawnTamerGuidList_Raw = value;
			OnNeverSpawnTamerGuidListChg_Invoke(_NeverSpawnTamerGuidList_Raw, value);
		}
	}

	public List<string> DelayUnMarkNeverSpawn { get; set; }

	public event Action<BindListString, BindListString> OnAlwaysSpawnTamerGuidListChg;

	public event Action<BindListString, BindListString> OnNeverSpawnTamerGuidListChg;

	public BGC_CircusControlData()
	{
		CircusRootMembers = new List<CircusMember>();
		CircusRootMemberMapping = new Dictionary<string, CircusMember>();
		ExtraData = new Dictionary<string, CircusExtraData>();
		AlwaysSpawnTamerGuidList = new BindListString();
		NeverSpawnTamerGuidList = new BindListString();
		DelayUnMarkNeverSpawn = new List<string>();
	}

	public string GetLastDeadUnit(string FamilyRootNodeGuid)
	{
		string result = string.Empty;
		if (ExtraData.TryGetValue(FamilyRootNodeGuid, out var value))
		{
			result = value.LastDeadUnit;
		}
		return result;
	}

	public void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc)
	{
		CircusMember circusRootMember = GetCircusRootMember(Actor);
		if (circusRootMember != null)
		{
			TravelCircus(circusRootMember, AnalyzeNodeFunc);
		}
	}

	public void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, Predicate<CircusMember> PredicateNodeFunc)
	{
		CircusMember circusRootMember = GetCircusRootMember(Actor);
		if (circusRootMember != null)
		{
			TravelCircus(circusRootMember, AnalyzeNodeFunc, PredicateNodeFunc);
		}
	}

	public void TravelCircus(CircusMember Node, Action<CircusMember> AnalyzeNodeFunc)
	{
		TravelCircus(Node, AnalyzeNodeFunc, (CircusMember node) => true);
	}

	public void TravelCircus(CircusMember Node, Action<CircusMember> AnalyzeNodeFunc, Predicate<CircusMember> PredicateNodeFunc)
	{
		if (PredicateNodeFunc(Node))
		{
			AnalyzeNodeFunc(Node);
		}
		if (Node.ChildMembers == null)
		{
			return;
		}
		foreach (CircusMember childMember in Node.ChildMembers)
		{
			TravelCircus(childMember, AnalyzeNodeFunc, PredicateNodeFunc);
		}
	}

	public void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, ESocketMatchTamerType MatchType, string SocketName)
	{
		CircusMember circusRootMember = GetCircusRootMember(Actor);
		if (circusRootMember != null)
		{
			TravelCircus(circusRootMember, AnalyzeNodeFunc, (CircusMember Node) => MatchType switch
			{
				ESocketMatchTamerType.Prefix => Node.Socket.ToString().StartsWith(SocketName), 
				ESocketMatchTamerType.Full => Node.Socket.ToString() == SocketName, 
				_ => false, 
			});
		}
	}

	public void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, ESocketMatchTamerType MatchType, FName SocketName)
	{
		TravelCircus(Actor, AnalyzeNodeFunc, MatchType, SocketName.ToString());
	}

	public CircusMember GetCircusRootMember(string GUID)
	{
		if (CircusRootMemberMapping.TryGetValue(GUID, out var value))
		{
			return value;
		}
		return null;
	}

	public CircusMember GetCircusRootMember(AActor Actor)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Actor);
		if (!string.IsNullOrEmpty(actorGuid))
		{
			return GetCircusRootMember(actorGuid);
		}
		return null;
	}

	public List<string> GetAllMemberGUID(string GUID)
	{
		List<string> Result = new List<string>();
		if (CircusRootMemberMapping.TryGetValue(GUID, out var value))
		{
			TravelCircus(value, delegate(CircusMember ND)
			{
				Result.Add(ND.ActorGuid);
			});
		}
		return Result;
	}

	public CircusMember GetCircusMember(string GUID)
	{
		CircusMember ChildTree = null;
		if (CircusRootMemberMapping.TryGetValue(GUID, out var value))
		{
			TravelCircus(value, delegate(CircusMember ND)
			{
				if (ND.ActorGuid == GUID)
				{
					ChildTree = ND;
				}
			});
		}
		return ChildTree;
	}

	public List<string> GetChildrenGUID(string GUID, bool Recursively = true)
	{
		CircusMember circusMember = GetCircusMember(GUID);
		List<string> Result = new List<string>();
		if (circusMember != null)
		{
			if (Recursively)
			{
				TravelCircus(circusMember, delegate(CircusMember ND)
				{
					Result.Add(ND.ActorGuid);
				});
			}
			else
			{
				if (circusMember.ChildMembers == null)
				{
					return null;
				}
				foreach (CircusMember childMember in circusMember.ChildMembers)
				{
					Result.Add(childMember.ActorGuid);
				}
			}
		}
		return Result;
	}

	public bool IsInSameCircus(AActor LeftActor, AActor RightActor)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(LeftActor);
		if (string.IsNullOrEmpty(actorGuid))
		{
			return false;
		}
		string actorGuid2 = BGU_DataUtil.GetActorGuid(RightActor);
		if (string.IsNullOrEmpty(actorGuid2))
		{
			return false;
		}
		if (CircusRootMemberMapping.TryGetValue(actorGuid, out var value) && CircusRootMemberMapping.TryGetValue(actorGuid2, out var value2) && value == value2)
		{
			return true;
		}
		return false;
	}

	public bool IsRoot(AActor Actor)
	{
		string Guid = BGU_DataUtil.GetActorGuid(Actor);
		return CircusRootMembers.Any((CircusMember node) => node.ActorGuid == Guid);
	}

	public bool IsRoot(string Guid)
	{
		return CircusRootMembers.Any((CircusMember node) => node.ActorGuid == Guid);
	}

	public void PrintTamerFamilyData()
	{
		foreach (CircusMember circusRootMember in CircusRootMembers)
		{
			TravelAndPrint(circusRootMember, 0);
		}
	}

	private void TravelAndPrint(CircusMember ND, int Depth)
	{
		Depth++;
		string text = "[❀Circus]  ";
		for (int i = 0; i < Depth; i++)
		{
			text += " ";
		}
		text += "└-";
		if (ND.ChildMembers == null)
		{
			return;
		}
		foreach (CircusMember childMember in ND.ChildMembers)
		{
			TravelAndPrint(childMember, Depth);
		}
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
		if (IsActive)
		{
			AlwaysSpawnTamerGuidList?.RegGetDeltaDataFunc(AllocRepDataForAlwaysSpawnTamerGuidList);
			NeverSpawnTamerGuidList?.RegGetDeltaDataFunc(AllocRepDataForNeverSpawnTamerGuidList);
		}
		else
		{
			AlwaysSpawnTamerGuidList?.RegGetDeltaDataFunc(null);
			NeverSpawnTamerGuidList?.RegGetDeltaDataFunc(null);
		}
		AlwaysSpawnTamerGuidList?.RefreshGetDeltaDataFunc(IsActive);
		NeverSpawnTamerGuidList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgString> AllocRepDataForAlwaysSpawnTamerGuidList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().AlwaysSpawnTamerGuidList;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgString> AllocRepDataForNeverSpawnTamerGuidList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().NeverSpawnTamerGuidList;
		}
		return null;
	}

	public CircusControlData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		CircusControlData circusControlData = _RepData[__LocalRepVersion % 64];
		if (circusControlData == null)
		{
			circusControlData = new CircusControlData();
			AlwaysSpawnTamerGuidList?.ClearDeltaData();
			NeverSpawnTamerGuidList?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = circusControlData;
		}
		else if (flag)
		{
			circusControlData.AlwaysSpawnTamerGuidList.Clear();
			AlwaysSpawnTamerGuidList?.ClearDeltaData();
			circusControlData.NeverSpawnTamerGuidList.Clear();
			NeverSpawnTamerGuidList?.ClearDeltaData();
		}
		return circusControlData;
	}

	public CircusControlData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			AlwaysSpawnTamerGuidList?.ClearDeltaData();
			NeverSpawnTamerGuidList?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		CircusControlData circusControlData = new CircusControlData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"CircusControlData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (AlwaysSpawnTamerGuidList == null)
			{
				circusControlData.AlwaysSpawnTamerGuidList.Add(new ListDeltaMsgString
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				AlwaysSpawnTamerGuidList.DumpFull(circusControlData.AlwaysSpawnTamerGuidList);
			}
			if (NeverSpawnTamerGuidList == null)
			{
				circusControlData.NeverSpawnTamerGuidList.Add(new ListDeltaMsgString
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NeverSpawnTamerGuidList.DumpFull(circusControlData.NeverSpawnTamerGuidList);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					CircusControlData other = _RepData[i % 64];
					circusControlData.MergeFrom(other);
				}
			}
		}
		return circusControlData;
	}

	private void OnAlwaysSpawnTamerGuidListChg_Invoke(BindListString OldValue, BindListString NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			CircusControlData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.AlwaysSpawnTamerGuidList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.AlwaysSpawnTamerGuidList.Add(new ListDeltaMsgString
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.AlwaysSpawnTamerGuidList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForAlwaysSpawnTamerGuidList);
		this.OnAlwaysSpawnTamerGuidListChg?.Invoke(OldValue, NewValue);
	}

	private void OnNeverSpawnTamerGuidListChg_Invoke(BindListString OldValue, BindListString NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			CircusControlData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.NeverSpawnTamerGuidList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.NeverSpawnTamerGuidList.Add(new ListDeltaMsgString
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.NeverSpawnTamerGuidList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForNeverSpawnTamerGuidList);
		this.OnNeverSpawnTamerGuidListChg?.Invoke(OldValue, NewValue);
	}
}
