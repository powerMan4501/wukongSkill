using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class CircusMember
{
	public CircusMember Parent;

	public FName Socket;

	public bool SpawnByDefault;

	public bool AwakeSync;

	public string ActorGuid;

	public CircusMemberType MemberType;

	public int ResId;

	public List<string> NickName;

	public List<CircusMember> ChildMembers;

	public CircusMember(FName Socket, string CircusMemberGuid, List<CircusMember> Children)
	{
		this.Socket = Socket;
		ActorGuid = CircusMemberGuid;
		ChildMembers = Children;
	}

	public CircusMember(string CircusMemberGuid)
	{
		Socket = FName.None;
		ActorGuid = CircusMemberGuid;
		ChildMembers = null;
	}

	public CircusMember(AActor MemberActor)
	{
		Socket = FName.None;
		ChildMembers = null;
		if (MemberActor is BUTamerActor bUTamerActor)
		{
			ActorGuid = bUTamerActor.GetFinalGuid();
			return;
		}
		IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(MemberActor);
		if (readOnlyData != null)
		{
			ActorGuid = readOnlyData.GetFinalGuid();
		}
	}
}
