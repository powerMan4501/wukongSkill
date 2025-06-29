using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLib_One_UnitMat_ScalarParamState : DispLib_One_ParamState_UtilData
{
	public float InitialValue { get; protected set; }

	public float Value { get; protected set; }

	public DispLib_One_UnitMat_ScalarParamState(FName _ParamName, float _InitialValue)
	{
		base.OperationCount = 0;
		base.ParamName = _ParamName;
		InitialValue = _InitialValue;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}

	public void SetData(float _ScalarValue, float _CurRequestStartTime, int _Priority)
	{
		base.HasValidEvent = true;
		Value = _ScalarValue;
		base.CurRequestStartTime = _CurRequestStartTime;
		base.Priority = _Priority;
	}

	public override void OnParamValueForceReset()
	{
		base.OperationCount = 0;
		base.HasValidEvent = false;
		base.CurTickNeedReset2InitialValue = false;
		Value = InitialValue;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}

	public override void OnParamValueReset()
	{
		base.HasValidEvent = false;
		base.CurTickNeedReset2InitialValue = false;
		Value = InitialValue;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}
}
