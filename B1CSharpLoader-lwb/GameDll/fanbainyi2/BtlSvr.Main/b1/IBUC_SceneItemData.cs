using UnrealEngine.Engine;

namespace b1;

public interface IBUC_SceneItemData
{
	BGUSceneItemBase SceneItemCatch { get; }

	bool HasSceneItem();

	bool HasSceneItemCatch();

	AActor GetCatchedSceneItemByAMID(int AMID);
}
