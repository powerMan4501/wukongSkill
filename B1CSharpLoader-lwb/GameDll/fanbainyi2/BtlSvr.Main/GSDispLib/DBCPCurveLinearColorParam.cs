using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveLinearColorParam : DBCPCurveLinearColor
{
	public FName ParamName;

	public DBCPCurveLinearColorParam(FName _ParamName, BUC_DispLibUtil_DBCPCurveColor _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, FLinearColor _ParamCurValue, FLinearColor _ParamInitialValue, float StartAge)
		: base(_SourcePCurveStruct, _ExternalDependencyMode, _ParamCurValue, _ParamInitialValue, StartAge)
	{
		ParamName = _ParamName;
	}

	public bool IsValid()
	{
		return ParamName != default(FName);
	}
}
