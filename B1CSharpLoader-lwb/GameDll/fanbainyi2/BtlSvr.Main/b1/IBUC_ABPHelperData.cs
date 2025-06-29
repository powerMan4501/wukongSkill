using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPHelperData
{
	UAnimInstance AnimInst { get; }

	BUABPSettingData ABPSettingData { get; }

	bool GetFloatAnimCurveValue(in FName CurveName, out float OutCurveValue);

	float GetStateMachineWeight(in FName StateMachineName, in FName StateName);

	bool HasValidMoveAnimConfig(EMoveSpeedLevel SpeedLevel, bool bLockMove);
}
