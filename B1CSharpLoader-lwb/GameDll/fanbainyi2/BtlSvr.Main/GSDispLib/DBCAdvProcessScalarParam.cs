using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessScalarParam : DBCAdvProcessScalar
{
	public FName ParamName;

	public DBCAdvProcessScalarParam(FName _ParamName, BUC_DispLibUtil_DBCAdvProcessScalar _SourceStruct, float StartAge)
		: base(_SourceStruct, StartAge)
	{
		ParamName = _ParamName;
	}
}
