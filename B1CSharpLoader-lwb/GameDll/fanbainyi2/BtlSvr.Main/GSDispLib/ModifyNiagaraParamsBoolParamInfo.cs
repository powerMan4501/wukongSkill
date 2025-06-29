using UnrealEngine.Runtime;

namespace GSDispLib;

public class ModifyNiagaraParamsBoolParamInfo : ModifyNiagaraParamsBoolInfo
{
	public FName ParamName;

	public ModifyNiagaraParamsBoolParamInfo(BUC_DispLibUtil_ModNiagara_NameAndBoolValue _SourceStruct, float StartAge)
		: base(_SourceStruct, StartAge)
	{
		ParamName = _SourceStruct.ParamName;
	}
}
