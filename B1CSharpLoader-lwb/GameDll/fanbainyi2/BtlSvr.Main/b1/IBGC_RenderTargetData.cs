using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_RenderTargetData
{
	UTextureRenderTarget2D GetGlobalRTBySurfaceType(ESceneItemSurfaceType SurfaceType);

	FName GetGlobalRTParamNameBySurfaceType(ESceneItemSurfaceType SurfaceType);
}
