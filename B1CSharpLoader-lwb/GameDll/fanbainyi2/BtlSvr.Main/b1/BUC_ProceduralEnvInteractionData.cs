using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ProceduralEnvInteractionData
{
	public bool bEnableDecal;

	public bool bEnableMesh;

	public FVector2D WorldSize;

	public ESceneItemSurfaceType DefaultSceneItemSurfaceType;

	public HashSet<ESceneItemSurfaceType> ActiveSurfaceTypes = new HashSet<ESceneItemSurfaceType>();
}
