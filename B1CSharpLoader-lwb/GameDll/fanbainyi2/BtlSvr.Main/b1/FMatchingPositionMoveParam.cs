using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public struct FMatchingPositionMoveParam
{
	public EMatchingPosType MatchingPosType;

	public FTransform TargetTrans;

	public EAIMoveSpeedType MoveSpeedType;

	public bool bFacingTargetRotation;

	public bool bIncludeSelfRadius;

	public float AcceptableRadius;

	public float InterpMoveTime;

	public Del_MatchingPositionFinishCallback AIPathMoveCallbackFunc;

	public Del_MatchingPositionFinishCallback InterpMoveCallbackFunc;
}
