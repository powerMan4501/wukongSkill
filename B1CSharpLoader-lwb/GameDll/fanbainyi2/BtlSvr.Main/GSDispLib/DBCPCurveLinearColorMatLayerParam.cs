using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveLinearColorMatLayerParam : DBCPCurveLinearColor
{
	public EMaterialParameterAssociation Association;

	public UMaterialFunctionInterface LayerFunction;

	public FName ParamName;

	public DBCPCurveLinearColorMatLayerParam(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCPCurveColor _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, FLinearColor _ParamCurValue, FLinearColor _ParamInitialValue, float StartAge)
		: base(_SourcePCurveStruct, _ExternalDependencyMode, _ParamCurValue, _ParamInitialValue, StartAge)
	{
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
	}

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		if (Association != EMaterialParameterAssociation.GlobalParameter && LayerFunction.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}
}
