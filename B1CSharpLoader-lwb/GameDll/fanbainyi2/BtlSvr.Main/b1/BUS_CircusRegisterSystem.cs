using UnrealEngine.Engine;

namespace b1;

public class BUS_CircusRegisterSystem : UActorCompBaseCS
{
	private bool RegFlag;

	private BUCircusBase CircusActor;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		CircusActor = Owner as BUCircusBase;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (RegFlag)
		{
			return;
		}
		foreach (CircusCollector item in CircusActor.FamilyTree)
		{
			if (item.MemberType == CircusMemberType.Tamer)
			{
				BUTamerActor bUTamerActor = item.Member as BUTamerActor;
				if (bUTamerActor == null || bUTamerActor.CurrentRef == null)
				{
					return;
				}
			}
		}
		base.BGSEventCollection.Evt_RegisterFamilyTree.Invoke(CircusActor, Register: true);
		RegFlag = true;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (RegFlag)
		{
			base.BGSEventCollection.Evt_RegisterFamilyTree.Invoke(CircusActor, Register: false);
		}
	}
}
