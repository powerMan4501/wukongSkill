using UnrealEngine.Runtime;

namespace b1;

public class BGUGridInfo
{
	public BGUGridChunk[,] Grid = new BGUGridChunk[9, 9];

	public FVector2D CenterLocation { get; set; }
}
