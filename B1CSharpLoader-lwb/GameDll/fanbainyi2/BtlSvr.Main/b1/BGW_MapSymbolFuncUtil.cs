using UnrealEngine.Runtime;

namespace b1;

public static class BGW_MapSymbolFuncUtil
{
	public static FVector2D ClcWorldToMap(float WorldPosX, float WorldPosY)
	{
		float num = 550000f;
		float num2 = 6816f / num;
		FVector2D zeroVector = FVector2D.ZeroVector;
		FVector2D zeroVector2 = FVector2D.ZeroVector;
		zeroVector2.X = (WorldPosX + zeroVector.X) * num2;
		zeroVector2.Y = (WorldPosY + zeroVector.Y) * num2;
		return zeroVector2;
	}
}
