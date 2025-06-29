using UnrealEngine.Runtime;

namespace b1;

public struct RTParams
{
	public float RemainingUpdateTime;

	public FTransform HitTransform;

	public FVector HitDir;

	public float Strength;

	public float BeginAnimTime;
}
