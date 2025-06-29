using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveScalarParam : DBCPCurveScalar
{
	public FName ParamName;

	public DBCPCurveScalarParam(FName _ParamName, BUC_DispLibUtil_DBCPCurveScalar _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, float _ParamCurValue, float _ParamInitialValue, float StartAge)
		: base(_SourcePCurveStruct, _ExternalDependencyMode, _ParamCurValue, _ParamInitialValue, StartAge)
	{
		ParamName = _ParamName;
	}

	public bool IsValid()
	{
		return ParamName != default(FName);
	}
}
