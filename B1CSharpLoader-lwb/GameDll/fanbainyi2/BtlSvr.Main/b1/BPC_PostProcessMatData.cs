using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BPC_PostProcessMatData
{
	public Dictionary<EPostProcessSource, Dictionary<int, TStrongObjectPtr<UPostProcessMatInfo>>> MaterialDictionary { get; } = new Dictionary<EPostProcessSource, Dictionary<int, TStrongObjectPtr<UPostProcessMatInfo>>>();

	public TWeakObject<APostProcessVolume> PostProcessCompPtr { get; set; }

	public BGUPlayerCharacterCS CurrentFramePlayer { get; set; }
}
