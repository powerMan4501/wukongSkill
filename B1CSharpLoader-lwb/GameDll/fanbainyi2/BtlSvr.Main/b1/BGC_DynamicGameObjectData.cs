using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_DynamicGameObjectData : IPersistentECSData
{
	private uint Itor;

	private Dictionary<int, DynamicGameObjectWrap> DynamicGameObjectDict = new Dictionary<int, DynamicGameObjectWrap>();

	public BGC_DynamicGameObjectData()
	{
		DynamicGameObjectDict = new Dictionary<int, DynamicGameObjectWrap>();
	}

	public void GetNewGameObject(UObject WorldContext, out DynamicGameObjectWrap GameObjectWrap)
	{
		GameObjectWrap = new DynamicGameObjectWrap(WorldContext, (int)Itor, IsActive: true);
		DynamicGameObjectDict.Add((int)Itor, GameObjectWrap);
		Itor++;
	}

	public void ReleaseGameObject(int GameObjectIndex)
	{
		if (DynamicGameObjectDict.TryGetValue(GameObjectIndex, out var value))
		{
			if (!value.GameObject.IsNullOrDestroyed())
			{
				value.GameObject.DestroyActor();
			}
			DynamicGameObjectDict.Remove(GameObjectIndex);
		}
	}

	public void ReleaseGameObject(DynamicGameObjectWrap GameObjectWrap)
	{
		ReleaseGameObject(GameObjectWrap.GameObjectIndex);
	}
}
