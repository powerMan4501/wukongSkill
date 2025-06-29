using UnrealEngine.Runtime;

namespace GSDispLib;

public class ModifyNiagaraParamsFVectorParamInfo : ModifyNiagaraParamsFVectorInfo
{
	public FName ParamName;

	public ModifyNiagaraParamsFVectorParamInfo(BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct.ProcessValue, _Velocity, StartAge)
	{
		ParamName = _SourceStruct.ParamName;
	}

	public ModifyNiagaraParamsFVectorParamInfo(FName _ParamName, BUC_DispLibUtil_ModifyNiagaraParams_FVector _SourceStruct, FVector _Velocity, float StartAge)
		: base(_SourceStruct, _Velocity, StartAge)
	{
		ParamName = _ParamName;
	}
}
