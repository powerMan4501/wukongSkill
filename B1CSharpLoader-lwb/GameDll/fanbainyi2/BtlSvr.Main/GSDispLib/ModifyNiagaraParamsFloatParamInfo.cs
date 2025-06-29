using UnrealEngine.Runtime;

namespace GSDispLib;

public class ModifyNiagaraParamsFloatParamInfo : ModifyNiagaraParamsFloatInfo
{
	public FName ParamName;

	public ModifyNiagaraParamsFloatParamInfo(BUC_DispLibUtil_ModifyNiagaraParams_FloatParam _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct.ProcessValue, _Velocity, StartAge)
	{
		ParamName = _SourceStruct.ParamName;
	}

	public ModifyNiagaraParamsFloatParamInfo(FName _ParamName, BUC_DispLibUtil_ModifyNiagaraParams_Float _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct, _Velocity, StartAge)
	{
		ParamName = _ParamName;
	}
}
