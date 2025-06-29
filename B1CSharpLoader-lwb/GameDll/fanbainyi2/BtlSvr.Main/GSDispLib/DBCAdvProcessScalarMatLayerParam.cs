using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessScalarMatLayerParam : DBCAdvProcessScalar
{
	public EMaterialParameterAssociation Association;

	public UMaterialFunctionInterface LayerFunction;

	public FName ParamName;

	public DBCAdvProcessScalarMatLayerParam()
	{
	}

	public DBCAdvProcessScalarMatLayerParam(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCAdvProcessScalar _SourceStruct, float StartAge)
		: base(_SourceStruct, StartAge)
	{
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
	}

	public void SetInitialData(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCAdvProcessScalar _SourceStruct, float StartAge)
	{
		Init(_SourceStruct, StartAge);
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

	public void CleanData()
	{
		Association = EMaterialParameterAssociation.GlobalParameter;
		LayerFunction = null;
		ParamName = default(FName);
		SourceStruct = default(BUC_DispLibUtil_DBCAdvProcessScalar);
		base.InitOver = false;
		base.isEndStage = false;
		base.EventRealEnd = false;
		base.CurFrameValue = 0f;
		base.ValueOnEndStageBegin = 0f;
		base.LoopAge = 0f;
		base.Age = 0f;
		base.ParentEventRealEnd = false;
	}
}
