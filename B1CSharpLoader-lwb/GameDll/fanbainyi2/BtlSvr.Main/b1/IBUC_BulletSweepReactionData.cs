using System.Collections.Generic;

namespace b1;

internal interface IBUC_BulletSweepReactionData
{
	Dictionary<int, FBulletSweepReactionInfo> GetBeHitedTriggerEffectIDs();

	Dictionary<int, FBulletSweepReactionInfo> GetSweepBuffTriggerEffectIDs();

	Dictionary<EBGUSimpleState, FBulletSweepReactionInfo> GetSweepSimpleStateTriggerEffectIDs();
}
