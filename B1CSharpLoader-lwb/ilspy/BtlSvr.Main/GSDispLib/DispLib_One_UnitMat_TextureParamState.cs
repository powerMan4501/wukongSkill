using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLib_One_UnitMat_TextureParamState : DispLib_One_ParamState_UtilData
{
	public UTexture Value;

	public UTexture InitialValue { get; protected set; }

	public DispLib_One_UnitMat_TextureParamState(FName _ParamName, UTexture _InitialValue)
	{
		base.OperationCount = 0;
		base.ParamName = _ParamName;
		InitialValue = _InitialValue;
		base.Priority = int.MinValue;
		base.CurRequestStartTime = -1f;
	}

	public void SetData(UTexture _TextureValue, float _CurRequestStartTimeint, int _Priority)
	{
		base.HasValidEvent = true;
		Value = _TextureValue;
		base.CurRequestStartTime = _CurRequestStartTimeint;
		base.Priority = _Priority;
	}

	public override void OnParamValueForceReset()
	{
		base.HasValidEvent = false;
		base.CurTickNeedReset2InitialValue = false;
		Value = InitialValue;
		base.OperationCount = 0;
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
