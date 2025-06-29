using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UCanvasRenderTarget2D_CsExtensions
{
	public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(this UWorld WorldContextObject, TSubclassOf<UCanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width = 1024, int Height = 1024)
	{
		return UCanvasRenderTarget2D.CreateCanvasRenderTarget2D(WorldContextObject, CanvasRenderTarget2DClass, Width, Height);
	}
}
