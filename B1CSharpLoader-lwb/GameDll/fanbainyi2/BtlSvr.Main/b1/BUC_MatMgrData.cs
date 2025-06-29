using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_MatMgrData
{
	public Dictionary<int, Dictionary<FName, int>> MatParameterLayerIndexCache;

	public Dictionary<FName, int> MatParamNameToGamePlayDispReqID;

	public Dictionary<FName, int> LayerMat_GlobalParamNameToGamePlayDispReqID;

	public Dictionary<UMaterialFunctionInterface, Dictionary<FName, int>> LayerMat_LayerParamNameToGamePlayDispReqID;

	public Dictionary<UMaterialFunctionInterface, Dictionary<FName, int>> LayerMat_BlendParamNameToGamePlayDispReqID;

	public Dictionary<string, Dictionary<FName, int>> MPCAssetPathToParamNameToGamePlayDispReqID;

	public Dictionary<int, List<int>> SetCurveValueEventIDToGamePlayDispReqIDList;

	public BUC_MatMgrData()
	{
		MatParameterLayerIndexCache = new Dictionary<int, Dictionary<FName, int>>();
		MatParamNameToGamePlayDispReqID = new Dictionary<FName, int>();
		LayerMat_GlobalParamNameToGamePlayDispReqID = new Dictionary<FName, int>();
		LayerMat_LayerParamNameToGamePlayDispReqID = new Dictionary<UMaterialFunctionInterface, Dictionary<FName, int>>();
		LayerMat_BlendParamNameToGamePlayDispReqID = new Dictionary<UMaterialFunctionInterface, Dictionary<FName, int>>();
		MPCAssetPathToParamNameToGamePlayDispReqID = new Dictionary<string, Dictionary<FName, int>>();
		SetCurveValueEventIDToGamePlayDispReqIDList = new Dictionary<int, List<int>>();
	}
}
