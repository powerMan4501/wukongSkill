using UnrealEngine.Runtime;

namespace b1;

public class SliceInfo
{
	public BGURuntimeMeshActor SliceActor;

	public FVector PivotLocation;

	public FVector Normal;

	public float ApplyForce;

	public bool bShowDebug;

	public SliceInfo(BGURuntimeMeshActor _SliceActor, FVector _PivotLocation, FVector _Normal, float _ApplyForce, bool _ShowDebug)
	{
		SliceActor = _SliceActor;
		PivotLocation = _PivotLocation;
		Normal = _Normal;
		ApplyForce = _ApplyForce;
		bShowDebug = _ShowDebug;
	}
}
