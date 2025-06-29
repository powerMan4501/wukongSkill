using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveScalarMatLayerParam : DBCPCurveScalar
{
	public EMaterialParameterAssociation Association;

	public UMaterialFunctionInterface LayerFunction;

	public FName ParamName;

	public DBCPCurveScalarMatLayerParam(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCPCurveScalar _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, float _ParamCurValue, float _ParamInitialValue, float StartAge)
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
