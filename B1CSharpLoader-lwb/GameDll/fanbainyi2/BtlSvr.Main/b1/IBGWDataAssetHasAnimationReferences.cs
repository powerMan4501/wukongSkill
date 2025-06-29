using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UInterface]
internal interface IBGWDataAssetHasAnimationReferences
{
	void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages);
}
