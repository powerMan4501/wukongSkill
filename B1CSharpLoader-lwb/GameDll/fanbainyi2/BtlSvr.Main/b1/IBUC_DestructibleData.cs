using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1;

internal interface IBUC_DestructibleData
{
	float Mass { get; }

	float DestroyedLifeTime { get; }

	DestructibleStrengthLevel StrengthLevel { get; }

	bool IsDestroyed { get; }

	List<EGSHitDestructibleStrengthLevel> CanParryStrengthLevel { get; }

	UAkAudioEvent DestructibleParryEvent { get; }

	UBGWDataAsset DestructibleParryDispConfig { get; }

	bool CanBeHitByBullet { get; }
}
