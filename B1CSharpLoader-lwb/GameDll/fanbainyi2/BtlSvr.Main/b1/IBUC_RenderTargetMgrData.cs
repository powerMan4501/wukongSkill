using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_RenderTargetMgrData
{
	UTextureRenderTarget2D GetTextureRenderTarget(RenderTargetType RTType);

	FName GetParamName(RenderTargetType RTType);

	FVector2D GetDrawPosition();
}
