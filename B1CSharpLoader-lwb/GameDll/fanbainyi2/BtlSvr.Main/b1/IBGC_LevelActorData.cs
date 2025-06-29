using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_LevelActorData
{
	void GetSceneItemsByTag(FName Tag, out List<AActor> OutSceneItems);

	void GetSceneItemsByTags(List<FName> Tags, out List<AActor> OutSceneItems);

	void GetAllowUseSpecialItemArea(int itemID, out List<BUAllowUseSpecialItemArea> OutAreas);

	bool CheckIsInSpecialItemArea(int ItemID, AActor Caster);
}
