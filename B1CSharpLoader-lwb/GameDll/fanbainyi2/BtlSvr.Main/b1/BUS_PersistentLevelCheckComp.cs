using UnrealEngine.Engine;

namespace b1;

internal class BUS_PersistentLevelCheckComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.OnAttach();
		if (!(Owner != null))
		{
			return;
		}
		ULevel level = Owner.GetLevel();
		if (level != null && !level.GetFName().ToString().Contains("PersistentLevel"))
		{
			ULevel uLevel = UGSE_WorldFuncLib.WorldGetPersistentLevel(Owner.World);
			if (uLevel != null && uLevel != level)
			{
				BGW_LogUtil.LogError($"{Owner.GetFName()}Ӧ\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffdPersistentLevel, \ufffd\ufffd\ufffd\ufffd");
			}
		}
	}
}
