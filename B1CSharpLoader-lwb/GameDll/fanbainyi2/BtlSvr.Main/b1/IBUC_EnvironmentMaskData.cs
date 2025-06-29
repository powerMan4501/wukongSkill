using System.Collections.Generic;
using BtlB1;

namespace b1;

public interface IBUC_EnvironmentMaskData
{
	Dictionary<ESceneItemSurfaceType, float> AccumulatedMaskData { get; }
}
