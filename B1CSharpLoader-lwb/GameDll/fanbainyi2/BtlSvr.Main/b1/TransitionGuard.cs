using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class TransitionGuard
{
	public FGuardConditionBase Condition { get; set; }

	public string GuardPin { get; set; }

	public FName GuardPinName { get; set; }

	private bool bStarted { get; set; }

	public void Start(UObject InOwner)
	{
		Condition.NotifyStart(InOwner);
		bStarted = true;
	}

	public void OnTick(float DeltaTime)
	{
		Condition.NotifyTick(DeltaTime);
	}

	public void Stop()
	{
		if (bStarted)
		{
			Condition.NotifyStop();
			bStarted = false;
		}
	}

	public void Reset()
	{
		if (bStarted)
		{
			Condition.NotifyReset();
		}
	}

	public bool IsSuccess()
	{
		return Condition.IsSuccess() > 0;
	}

	public TransitionGuard(CalliopeCustom_CompositeTransitionCondition_Idle IdleCompositeTransition, PsmNodeInstance InPsmNodeInstance)
	{
		GuardPin = IdleCompositeTransition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(IdleCompositeTransition, InPsmNodeInstance);
	}

	public TransitionGuard(CalliopeCustom_CompositeTransitionCondition_Battle BattleCompositeTransition, PsmNodeInstance InPsmNodeInstance)
	{
		GuardPin = BattleCompositeTransition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(BattleCompositeTransition, InPsmNodeInstance);
	}

	public TransitionGuard(CalliopeCustom_CompositeTransitionCondition_Group GroupCompositeTransition, PsmNodeInstance InPsmNodeInstance)
	{
		GuardPin = GroupCompositeTransition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(GroupCompositeTransition, InPsmNodeInstance);
	}

	public TransitionGuard(CalliopeCustom_CompositeTransitionCondition_State StateCompositeTransition)
	{
		GuardPin = StateCompositeTransition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(StateCompositeTransition);
	}

	public TransitionGuard(CalliopeCustom_DetectUnitCondition DetectUnitCondition)
	{
		GuardPin = DetectUnitCondition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(DetectUnitCondition);
	}

	public TransitionGuard(CalliopeCustom_CompositeTransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GuardPin = GuideCondition.PinName;
		GuardPinName = FNameExtension.ToFName(GuardPin);
		Condition = FGuardConditionFactory.New(GuideCondition, InPsmNodeInstance);
	}
}
