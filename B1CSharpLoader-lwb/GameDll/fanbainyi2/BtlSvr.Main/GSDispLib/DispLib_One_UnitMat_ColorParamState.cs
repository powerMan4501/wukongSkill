using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLib_One_UnitMat_ColorParamState : DispLib_One_ParamState_UtilData
{
	public FLinearColor Value;

	public FLinearColor InitialValue { get; protected set; }

	public DispLib_One_UnitMat_ColorParamState(FName _ParamName, FLinearColor _InitialValue)
	{
		base.OperationCount = 0;
		base.ParamName = _ParamName;
		InitialValue = _InitialValue;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}

	public void SetData(FLinearColor _LinearColorValue, float _CurRequestStartTimeint, int _Priority)
	{
		base.HasValidEvent = true;
		Value = _LinearColorValue;
		base.CurRequestStartTime = _CurRequestStartTimeint;
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
