using b1.ECS;

namespace b1;

public static class BGU_ECSArchTypes
{
	public static void CreateAll(EntityManager EntityMgr)
	{
		for (int i = 0; i < 13; i++)
		{
			CreateArcheType(EntityMgr, i);
		}
	}

	private static void CreateArcheType(EntityManager EntityMgr, int Index)
	{
		EntityArchetype orCreateArchetype = EntityMgr.GetOrCreateArchetype(Index);
		if (Index == 6 || Index == 5)
		{
			orCreateArchetype.AddDataType<BUC_SpeedCtrlData, BUC_SpeedCtrlData_Raw>(NeedSnapshot: true);
		}
		else
		{
			_ = 7;
		}
		if (Index == 6)
		{
			orCreateArchetype.PreAllocate(128);
		}
		else
		{
			orCreateArchetype.PreAllocate(64);
		}
	}
}
