using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_CircusControlSystem : GameStateSystemBase
{
	private BGC_CircusControlData CircusControlData;

	private BGC_TamerData TamerData;

	public override void OnAttach()
	{
		CircusControlData = RequireWritableData<BGC_CircusControlData>();
		TamerData = RequireWritableData<BGC_TamerData>();
		base.BGSEventCollection.Evt_RegisterFamilyTree += new Del_RegisterFamilyTree(OnRegisterCircus);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnNotifyTamerSpawnUnit);
		base.BGSEventCollection.Evt_UnMarkSocketTamerNeverSpawn += new Del_UnMarkSocketTamerNeverSpawn(OnUnMarkSocketTamerNeverSpawn);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_OnTriggerWakeBroadCastToFamily += new Del_String_Actor(OnTriggerWakeBroadCastToFamily);
	}

	public override void OnBeginPlay()
	{
		CircusControlData.AlwaysSpawnTamerGuidList.OnAdd += MarkTamerAlwaysSpawn;
		CircusControlData.AlwaysSpawnTamerGuidList.OnRemove += UnMarkTamerAlwaysSpawn;
		CircusControlData.NeverSpawnTamerGuidList.OnAdd += MarkTamerNeverSpawn;
		CircusControlData.NeverSpawnTamerGuidList.OnRemove += UnMarkTamerNeverSpawn;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		CircusControlData.AlwaysSpawnTamerGuidList.OnAdd -= MarkTamerAlwaysSpawn;
		CircusControlData.AlwaysSpawnTamerGuidList.OnRemove -= UnMarkTamerAlwaysSpawn;
		CircusControlData.NeverSpawnTamerGuidList.OnAdd -= MarkTamerNeverSpawn;
		CircusControlData.NeverSpawnTamerGuidList.OnRemove -= UnMarkTamerNeverSpawn;
	}

	private void OnRegisterCircus(BUCircusBase CircusActor, bool IsReg)
	{
		BGW_LogUtil.LogError($"[ResetActor]=============OnRegisterCircus=={IsReg}=======================================");
		if (IsReg)
		{
			Dictionary<string, CircusCollector> dictionary = new Dictionary<string, CircusCollector>();
			CircusCollector circusCollector = CircusActor.FamilyTree.First();
			foreach (CircusCollector item in CircusActor.FamilyTree)
			{
				string circusMemberGuid = item.GetCircusMemberGuid();
				if (string.IsNullOrEmpty(circusMemberGuid))
				{
					BGW_LogUtil.LogError("OnRegisterCircus GUID Null Actor不存在");
					continue;
				}
				dictionary.Add(circusMemberGuid, item);
				if (item.IsRootMember)
				{
					circusCollector = item;
				}
			}
			if (circusCollector.IsRootMember)
			{
				CircusMember circusMember = new CircusMember(circusCollector.GetCircusMemberGuid());
				circusMember.Parent = null;
				circusMember.AwakeSync = CircusActor.AwakeSync;
				circusMember.SpawnByDefault = true;
				circusMember.NickName = new List<string>();
				foreach (FGameplayTag item2 in circusCollector.NickName)
				{
					List<string> nickName = circusMember.NickName;
					FName tagName = item2.TagName;
					nickName.Add(tagName.ToString());
				}
				FillChildNode(circusMember, dictionary, circusMember.AwakeSync);
				CircusControlData.CircusRootMembers.Add(circusMember);
				foreach (CircusCollector item3 in CircusActor.FamilyTree)
				{
					CircusControlData.CircusRootMemberMapping.Add(item3.GetCircusMemberGuid(), circusMember);
					CircusControlData.ExtraData.Add(item3.GetCircusMemberGuid(), new CircusExtraData());
				}
			}
		}
		else
		{
			foreach (CircusCollector item4 in CircusActor.FamilyTree)
			{
				string circusMemberGuid2 = item4.GetCircusMemberGuid();
				if (CircusControlData.CircusRootMemberMapping.TryGetValue(circusMemberGuid2, out var value))
				{
					CircusControlData.CircusRootMemberMapping.Remove(circusMemberGuid2);
					CircusControlData.CircusRootMembers.Remove(value);
				}
				if (CircusControlData.ExtraData.TryGetValue(circusMemberGuid2, out var _))
				{
					CircusControlData.ExtraData.Remove(circusMemberGuid2);
				}
			}
		}
		CircusControlData.PrintTamerFamilyData();
	}

	private void FillChildNode(CircusMember Node, Dictionary<string, CircusCollector> RawData, bool MarkUnity)
	{
		if (!RawData.TryGetValue(Node.ActorGuid, out var value))
		{
			return;
		}
		Node.Socket = value.Socket;
		Node.SpawnByDefault = value.SpawnByDefault;
		Node.AwakeSync = MarkUnity;
		Node.ResId = value.ResId;
		Node.NickName = new List<string>();
		foreach (FGameplayTag item in value.NickName)
		{
			List<string> nickName = Node.NickName;
			FName tagName = item.TagName;
			nickName.Add(tagName.ToString());
		}
		Node.MemberType = value.MemberType;
		if (value.ChildMembers.Count == 0)
		{
			return;
		}
		Node.ChildMembers = new List<CircusMember>();
		foreach (AActor childMember in value.ChildMembers)
		{
			if (childMember is BUTamerActor bUTamerActor)
			{
				MarkNeverSpawnTamer(bUTamerActor.CurrentRef.TamerGuid);
			}
			CircusMember circusMember = new CircusMember(childMember);
			circusMember.Parent = Node;
			FillChildNode(circusMember, RawData, MarkUnity);
			Node.ChildMembers.Add(circusMember);
		}
	}

	private void OnNotifyTamerSpawnUnit(string UnitGuid)
	{
		if (!CircusControlData.CircusRootMemberMapping.ContainsKey(UnitGuid))
		{
			return;
		}
		CircusMember TreeNode = CircusControlData.GetCircusMember(UnitGuid);
		if (TreeNode == null)
		{
			return;
		}
		if (TreeNode.Parent == null)
		{
			foreach (CircusMember childMember in TreeNode.ChildMembers)
			{
				base.BGWEventCollection.Evt_SetActorAliveState(childMember.ActorGuid, P2: true);
				base.BGWEventCollection.Evt_SetActorResetTypeOverride(childMember.ActorGuid, EBGUResetType.Spawn);
			}
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid);
			BUS_EventCollectionCS.Get(actorByGuid).Evt_TryRunDefaultCBG.Invoke();
			BUS_EventCollectionCS.Get(actorByGuid).Evt_UnitTriggerDead += (Del_UnitTriggerDead)delegate
			{
				if (TreeNode.ChildMembers == null)
				{
					return;
				}
				foreach (CircusMember childMember2 in TreeNode.ChildMembers)
				{
					MarkNeverSpawnTamer(childMember2.ActorGuid);
				}
			};
		}
		if (TreeNode.ChildMembers == null)
		{
			return;
		}
		foreach (CircusMember childMember3 in TreeNode.ChildMembers)
		{
			if (childMember3.SpawnByDefault)
			{
				MarkNeverSpawnTamer(childMember3.ActorGuid, IsUnMark: true);
				MarkAlwaysSpawnTamer(childMember3.ActorGuid);
			}
		}
	}

	private void MarkNeverSpawnTamer(string Guid, bool IsUnMark = false)
	{
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
		{
			if (IsUnMark)
			{
				CircusControlData.NeverSpawnTamerGuidList.Remove(Guid);
			}
			else
			{
				CircusControlData.NeverSpawnTamerGuidList.Add(Guid);
			}
		}
	}

	private void MarkAlwaysSpawnTamer(string Guid, bool IsUnMark = false)
	{
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
		{
			if (IsUnMark)
			{
				CircusControlData.AlwaysSpawnTamerGuidList.Remove(Guid);
			}
			else
			{
				CircusControlData.AlwaysSpawnTamerGuidList.Add(Guid);
			}
		}
	}

	private void MarkTamerAlwaysSpawn(string Guid)
	{
		base.BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(Guid);
	}

	private void UnMarkTamerAlwaysSpawn(int Idx, string Guid)
	{
		base.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(Guid);
	}

	private void MarkTamerNeverSpawn(string Guid)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(Guid, out var value))
		{
			base.BGSEventCollection.Evt_MarkTamerNeverSpawn.Invoke(value);
		}
	}

	private void UnMarkTamerNeverSpawn(int Idx, string Guid)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(Guid, out var value))
		{
			if (value.Phase == ETamerPhase.Spawned)
			{
				CircusControlData.DelayUnMarkNeverSpawn.Add(Guid);
			}
			else
			{
				base.BGSEventCollection.Evt_UnMarkTamerNeverSpawn.Invoke(value);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		for (int num = CircusControlData.DelayUnMarkNeverSpawn.Count - 1; num >= 0; num--)
		{
			string key = CircusControlData.DelayUnMarkNeverSpawn[num];
			if (TamerData.UnitGuid2Tamer.TryGetValue(key, out var value) && value.Phase != ETamerPhase.Spawned && value.Phase == ETamerPhase.Loaded)
			{
				base.BGSEventCollection.Evt_UnMarkTamerNeverSpawn.Invoke(value);
				CircusControlData.DelayUnMarkNeverSpawn.RemoveAt(num);
			}
		}
	}

	private void OnUnMarkSocketTamerNeverSpawn(AActor RootActor, FTamerFamilyMatchChildInfo MatchInfo)
	{
		foreach (string item in BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(RootActor, MatchInfo))
		{
			MarkNeverSpawnTamer(item, IsUnMark: true);
			MarkAlwaysSpawnTamer(item);
		}
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		CircusMember circusRootMember = CircusControlData.GetCircusRootMember(InUnitGuid);
		if (circusRootMember == null)
		{
			return;
		}
		if (CircusControlData.ExtraData.TryGetValue(circusRootMember.ActorGuid, out var value))
		{
			value.LastDeadUnit = InUnitGuid;
		}
		if (!CircusControlData.IsRoot(InUnitGuid))
		{
			return;
		}
		CircusControlData.TravelCircus(circusRootMember, delegate(CircusMember Node)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, Node.ActorGuid);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_CircusRootDead.Invoke();
				if (!CircusControlData.IsRoot(Node.ActorGuid))
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(actorByGuid, InDeadReason);
				}
			}
		});
	}

	private void OnTriggerWakeBroadCastToFamily(string Guid, AActor CatchedTarget)
	{
		CircusMember circusRootMember = CircusControlData.GetCircusRootMember(Guid);
		if (circusRootMember == null)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, circusRootMember.ActorGuid);
		if (actorByGuid == null)
		{
			return;
		}
		if (BGUFunctionLibraryCS.BGUGetTarget(actorByGuid) == null)
		{
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_AICatchTarget.Invoke(CatchedTarget, ETargetSourceType.Target_FamilyAssignTarget);
		}
		if (!circusRootMember.AwakeSync)
		{
			return;
		}
		CircusControlData.TravelCircus(circusRootMember, delegate(CircusMember Node)
		{
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(Owner, Node.ActorGuid);
			if (BGUFunctionLibraryCS.BGUGetTarget(actorByGuid2) == null)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid2);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_AICatchTarget.Invoke(CatchedTarget, ETargetSourceType.Target_FamilyAssignTarget);
				}
			}
		});
	}
}
