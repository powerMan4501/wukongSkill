using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public abstract class DispLib_One_ParamState_UtilData
{
	public FName ParamName { get; protected set; }

	public int OperationCount { get; protected set; }

	public float CurRequestStartTime { get; protected set; }

	public int Priority { get; protected set; }

	public bool HasValidEvent { get; protected set; }

	public bool CurTickNeedReset2InitialValue { get; protected set; }

	public void InheritOtherParamState(DispLib_One_ParamState_UtilData OldParamState)
	{
		OperationCount = OldParamState.OperationCount;
		Priority = OldParamState.Priority;
		HasValidEvent = OldParamState.HasValidEvent;
		CurTickNeedReset2InitialValue = OldParamState.CurTickNeedReset2InitialValue;
	}

	public int OperationCountAdd()
	{
		OperationCount++;
		CurTickNeedReset2InitialValue = false;
		return OperationCount;
	}

	public int OperationCountRemove()
	{
		OperationCount--;
		if (OperationCount < 0)
		{
			BGW_LogUtil.LogError($"[DBC] [DispLib OneParamState] OperationCount overflow; ParamName = {ParamName};");
			OperationCount = 0;
		}
		if (OperationCount == 0)
		{
			CurTickNeedReset2InitialValue = true;
		}
		return OperationCount;
	}

	public void TryReleasePriorityControl(int EventPriority)
	{
		if (EventPriority >= Priority)
		{
			Priority = 0;
			HasValidEvent = false;
			CurRequestStartTime = -1f;
		}
	}

	public abstract void OnParamValueReset();

	public abstract void OnParamValueForceReset();
}
