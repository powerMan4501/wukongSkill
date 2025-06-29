using UnrealEngine.Runtime;

namespace GSDispLib;

public class ModifyNiagaraParamsFLinearColorParamInfo : ModifyNiagaraParamsFLinearColorInfo
{
	public FName ParamName;

	public ModifyNiagaraParamsFLinearColorParamInfo(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct.ProcessValue, _Velocity, StartAge)
	{
		ParamName = _SourceStruct.ParamName;
	}

	public ModifyNiagaraParamsFLinearColorParamInfo(FName _ParamName, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct, _Velocity, StartAge)
	{
		ParamName = _ParamName;
	}
}
