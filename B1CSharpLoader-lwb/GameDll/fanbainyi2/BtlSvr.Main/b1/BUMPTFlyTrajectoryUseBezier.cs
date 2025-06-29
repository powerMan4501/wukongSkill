using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUMPTFlyTrajectoryUseBezier : BUMatchingPosTypeTemplate
{
	public override bool TriggerMatchingPos(AActor User, in FMatchingPositionMoveParam Param)
	{
		FTransform targetTrans = Param.TargetTrans;
		if (!targetTrans.IsValid())
		{
			return false;
		}
		BUS_EventCollectionCS.Get(User).Evt_SetMatchingPosInterpInfo.Invoke(targetTrans, Param.InterpMoveTime, EnableZAxisMove: true);
		return true;
	}
}
