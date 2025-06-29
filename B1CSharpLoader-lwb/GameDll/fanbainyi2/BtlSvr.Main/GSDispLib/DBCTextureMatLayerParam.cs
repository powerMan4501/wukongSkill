using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCTextureMatLayerParam : DBCTexture
{
	public EMaterialParameterAssociation Association;

	public UMaterialFunctionInterface LayerFunction;

	public FName ParamName;

	public DBCTextureMatLayerParam(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCTexture _SourceStruct, float StartAge)
		: base(_SourceStruct, StartAge)
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
