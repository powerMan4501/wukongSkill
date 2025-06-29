using UnrealEngine.Runtime;

namespace b1;

public struct FTouchIKInfo
{
	public FVector TouchIKJointTargetLocation;

	public float TouchIKAlpha;

	public FVector MeshSpaceIKOffset;

	public FVector WorldSpaceEffectorOffset;

	public FVector TouchIKEffectorLocation { get; set; }
}
