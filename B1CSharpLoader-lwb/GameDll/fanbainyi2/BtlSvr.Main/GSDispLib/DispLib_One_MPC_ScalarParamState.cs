using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLib_One_MPC_ScalarParamState : DispLib_One_ParamState_UtilData
{
	public string MPCAssetPath { get; protected set; }

	public bool isInitialValueValid { get; protected set; }

	public float InitialValue { get; protected set; }

	public float Value { get; protected set; }

	public DispLib_One_MPC_ScalarParamState(string _MPCAssetPath, FName _ParamName)
	{
		MPCAssetPath = _MPCAssetPath;
		isInitialValueValid = false;
		base.OperationCount = 0;
		InitialValue = 0f;
		base.ParamName = _ParamName;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}

	public void SetParamInitialValue(float _InitialValue)
	{
		isInitialValueValid = true;
		InitialValue = _InitialValue;
	}

	public void SetData(float _Value, float _CurRequestStartTimeint, int _Priority)
	{
		base.HasValidEvent = true;
		Value = _Value;
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
