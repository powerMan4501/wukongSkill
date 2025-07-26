using b1;
using UnrealEngine.Engine;

namespace Game_Helper;

public class BuffRunComp : UActorCompBaseCS
{
	public AActor _Owner;

	public BGS_GSEventCollection _BGSEventCollection;

	public BGW_EventCollection _BGWEventCollection;

	public BUS_GSEventCollection _BUSEventCollection;

	public override void OnAttach()
	{
		_Owner = base.Owner;
		_BGSEventCollection = ((UActorCompBaseCS)this).BGSEventCollection;
		_BGWEventCollection = ((UActorCompBaseCS)this).BGWEventCollection;
		_BUSEventCollection = ((UActorCompBaseCS)this).BUSEventCollection;
		((UActorCompBaseCS)this).SetCanTick(true);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public override int GetTickGroupMask()
	{
		return ((UActorCompBaseCS)this).CanTick() ? 1 : 0;
	}

	public void DeInit()
	{
		((UActorCompBaseCS)this).SetCanTick(false);
	}

	public void ReInit()
	{
		((UActorCompBaseCS)this).SetCanTick(true);
	}
}
