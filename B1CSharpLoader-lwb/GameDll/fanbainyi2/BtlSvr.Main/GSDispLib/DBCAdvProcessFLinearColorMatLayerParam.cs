using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessFLinearColorMatLayerParam : DBCAdvProcessFLinearColor
{
	public EMaterialParameterAssociation Association;

	public UMaterialFunctionInterface LayerFunction;

	public FName ParamName;

	public DBCAdvProcessFLinearColorMatLayerParam()
	{
	}

	public DBCAdvProcessFLinearColorMatLayerParam(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCAdvProcessFLinearColor _SourceStruct, float StartAge)
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

	public void SetInitialData(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCAdvProcessFLinearColor _SourceStruct, float StartAge)
	{
		Init(_SourceStruct, StartAge);
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
	}

	public void CleanData()
	{
		Association = EMaterialParameterAssociation.GlobalParameter;
		LayerFunction = null;
		ParamName = default(FName);
		SourceStruct = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor);
		base.InitOver = false;
		base.isEndStage = false;
		base.EventRealEnd = false;
		base.CurFrameValue = default(FLinearColor);
		base.ValueOnEndStageBegin = default(FLinearColor);
		base.LoopAge = 0f;
		base.Age = 0f;
		base.ParentEventRealEnd = false;
	}
}
