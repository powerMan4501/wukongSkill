using System.Collections.Generic;

namespace b1;

public class BGUDebugTargetInfo
{
	public BGUCharacterCS Self;

	public int Masks;

	public BGUDebugNiaActor AITargetNiaActor;

	public BGUDebugNiaActor AOTargetNiaActor;

	public BGUDebugNiaActor SkillBaseTargetNiaActor;

	public BGUDebugNiaActor ComboTargetNiaActor;

	public BGUDebugNiaActor MoveToTargetNiaActor;

	public List<BGUDebugNiaActor> HatredTargetNiaActor;

	public BGUDebugTargetInfo(BGUCharacterCS _Self, int _Masks, BGS_DebugTargetMgr OwnerComp)
	{
		Self = _Self;
		Masks = _Masks;
		if ((Masks & 1) != 0)
		{
			AITargetNiaActor = OwnerComp.GetNiaActorFromPool();
		}
		if ((Masks & 2) != 0)
		{
			AOTargetNiaActor = OwnerComp.GetNiaActorFromPool();
		}
		if ((Masks & 4) != 0)
		{
			SkillBaseTargetNiaActor = OwnerComp.GetNiaActorFromPool();
		}
		if ((Masks & 8) != 0)
		{
			ComboTargetNiaActor = OwnerComp.GetNiaActorFromPool();
		}
		if ((Masks & 0x10) != 0)
		{
			MoveToTargetNiaActor = OwnerComp.GetNiaActorFromPool();
		}
		HatredTargetNiaActor = new List<BGUDebugNiaActor>();
	}
}
