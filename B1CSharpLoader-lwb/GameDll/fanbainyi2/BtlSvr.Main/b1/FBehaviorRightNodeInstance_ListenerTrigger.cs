using UnrealEngine.Engine;

namespace b1;

public abstract class FBehaviorRightNodeInstance_ListenerTrigger : FBehaviorRightNodeInstance
{
	protected string ListenerFlagID { get; set; }

	protected virtual string GetListenerFlagID(AActor Owner)
	{
		return "";
	}

	public static bool ValueOperation(int IntValue, int CompareValue, EValueCompareOperationType CompareOperationType)
	{
		bool result = false;
		switch (CompareOperationType)
		{
		case EValueCompareOperationType.EqualTo:
			result = IntValue == CompareValue;
			break;
		case EValueCompareOperationType.NotEqualTo:
			result = IntValue != CompareValue;
			break;
		case EValueCompareOperationType.LessThan:
			result = IntValue < CompareValue;
			break;
		case EValueCompareOperationType.LessThanOrEqualTo:
			result = IntValue <= CompareValue;
			break;
		case EValueCompareOperationType.GreaterThan:
			result = IntValue > CompareValue;
			break;
		case EValueCompareOperationType.GreaterThanOrEqualTo:
			result = IntValue >= CompareValue;
			break;
		}
		return result;
	}

	public static bool ValueOperation(float FloatValue, float CompareValue, EValueCompareOperationType CompareOperationType)
	{
		bool result = false;
		switch (CompareOperationType)
		{
		case EValueCompareOperationType.EqualTo:
			result = FloatValue == CompareValue;
			break;
		case EValueCompareOperationType.NotEqualTo:
			result = FloatValue != CompareValue;
			break;
		case EValueCompareOperationType.LessThan:
			result = FloatValue < CompareValue;
			break;
		case EValueCompareOperationType.LessThanOrEqualTo:
			result = FloatValue <= CompareValue;
			break;
		case EValueCompareOperationType.GreaterThan:
			result = FloatValue > CompareValue;
			break;
		case EValueCompareOperationType.GreaterThanOrEqualTo:
			result = FloatValue >= CompareValue;
			break;
		}
		return result;
	}
}
