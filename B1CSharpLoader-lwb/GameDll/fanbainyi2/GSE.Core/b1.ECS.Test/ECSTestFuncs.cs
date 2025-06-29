using System.Collections.Generic;

namespace b1.ECS.Test;

public static class ECSTestFuncs
{
	private static void Assert(bool Condition, string ErrMsg)
	{
		if (!Condition)
		{
			BGW_LogUtil.LogError("ECSTestFuncs" + ErrMsg);
		}
	}

	public static void TestCounter()
	{
		EntityManager entityManager = new EntityManager();
		EntityArchetype orCreateArchetype = entityManager.GetOrCreateArchetype(0);
		orCreateArchetype.AddDataType<TestDataSafe, TestData>();
		orCreateArchetype.PreAllocate(129);
		Assert(orCreateArchetype.Chunks.Count == 3, "Chunk Count Error");
		List<Entity> list = new List<Entity>();
		for (int i = 0; i < 193; i++)
		{
			Entity entity = entityManager.CreateEntity(0);
			entityManager.GetDataSafe<TestDataSafe>(entity).Data = i;
			list.Add(entity);
		}
		Assert(orCreateArchetype.Chunks.Count == 4, "Chunk Count Error 2");
		for (int j = 0; j < orCreateArchetype.Chunks.Count - 1; j++)
		{
			Assert(orCreateArchetype.Chunks[j].Count == 64, "Chunk Count Error 3");
		}
		Assert(orCreateArchetype.Chunks[orCreateArchetype.Chunks.Count - 1].Count == 1, "Chunk Count Error 4");
		Assert(orCreateArchetype.Chunks[0].IsUsed[1], "Chunk Count Error 6");
		entityManager.DestroyEntity(list[1]);
		Assert(orCreateArchetype.Chunks[0].Count == 63, "Chunk Count Error 5");
		Assert(!orCreateArchetype.Chunks[0].IsUsed[1], "Chunk Count Error 6");
		Assert(!entityManager.Exists(list[1]), "Chunk Count Error 7");
		for (int k = 0; k < list.Count; k++)
		{
			Entity inEntity = list[k];
			TestDataSafe dataSafe = entityManager.GetDataSafe<TestDataSafe>(inEntity);
			if (k == 1)
			{
				Assert(dataSafe == null, "Chuck Count Error 8");
				continue;
			}
			Assert(dataSafe != null, "Chuck Count Error 8");
			Assert(dataSafe.Data == k, "Chuck Count Error 9");
		}
	}

	public static void TestEntityIndex()
	{
		Entity entity = default(Entity);
		Assert(entity.IsNull(), "Entity Index Err 1");
		int num = 15;
		int num2 = 20;
		int num3 = 30;
		int num4 = 111;
		int num5 = 13;
		entity.SetChunkIndices(num, num2, num3, num4, num5);
		entity.GetChunkIndices(out var OutEntityMgrIdx, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		Assert(!entity.IsNull(), "Entity Index Err 2");
		Assert(OutEntityMgrIdx == num && OutArchIndex == num2 && OutChunkIndex == num3 && OutIndexInChunk == num4 && OutVersion == num5, "Entity Index Err 3");
		Assert(entity.EntityMgrIdx == num && entity.ArchIndex == num2 && entity.ChunkIndex == num3 && entity.IndexInChunk == num4 && entity.Version == num5, "Entity Index Err 4");
		entity.SetNull();
		Assert(entity.IsNull(), "Entity Index Err 5");
	}
}
