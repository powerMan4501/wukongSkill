using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessFLinearColorParam : DBCAdvProcessFLinearColor
{
	public FName ParamName;

	public DBCAdvProcessFLinearColorParam(FName _ParamName, BUC_DispLibUtil_DBCAdvProcessFLinearColor _SourceStruct, float StartAge)
		: base(_SourceStruct, StartAge)
	{
		ParamName = _ParamName;
	}
}
