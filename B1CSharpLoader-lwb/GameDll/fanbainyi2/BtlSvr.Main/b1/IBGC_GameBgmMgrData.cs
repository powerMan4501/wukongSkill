using b1.ECS;

namespace b1;

public interface IBGC_GameBgmMgrData
{
	bool HasInit { get; }

	BGWBGMConfigInfo BGMConfigInfo { get; }

	BGMWrap GetRandomDefaultBGMWrap(Entity Entity, EBGMPriority RandomPriority);

	BGMWrap GetCurrentWanderBGM();

	bool TryGetCurrentEntityBattleBgmWrap(Entity entity, out BGMWrap BgmWrap);
}
