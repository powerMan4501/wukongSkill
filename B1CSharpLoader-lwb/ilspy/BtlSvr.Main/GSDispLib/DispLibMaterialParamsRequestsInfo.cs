using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLibMaterialParamsRequestsInfo
{
	public uint CurSetMatRequestID;

	public bool HasParamNeedReset;

	public bool isDirty;

	public bool isSleep;

	public Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> GlobalScalarParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> LayerScalarParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> BlendScalarParamQueue;

	public Dictionary<FName, DispLib_One_UnitMat_ColorParamState> GlobalColorParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> LayerColorParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> BlendColorParamQueue;

	public Dictionary<FName, DispLib_One_UnitMat_TextureParamState> GlobalTextureParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_TextureParamState>> LayerTextureParamQueue;

	public Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_TextureParamState>> BlendTextureParamQueue;

	public bool RequestsQueueIsEmpty()
	{
		if (GlobalScalarParamQueue.Count == 0 && LayerScalarParamQueue.Count == 0 && BlendScalarParamQueue.Count == 0 && GlobalColorParamQueue.Count == 0 && LayerColorParamQueue.Count == 0 && BlendColorParamQueue.Count == 0 && GlobalTextureParamQueue.Count == 0 && LayerTextureParamQueue.Count == 0)
		{
			return BlendTextureParamQueue.Count == 0;
		}
		return false;
	}

	public DispLibMaterialParamsRequestsInfo()
	{
		GlobalScalarParamQueue = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
		LayerScalarParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>>();
		BlendScalarParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>>();
		GlobalColorParamQueue = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
		LayerColorParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>>();
		BlendColorParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>>();
		GlobalTextureParamQueue = new Dictionary<FName, DispLib_One_UnitMat_TextureParamState>();
		LayerTextureParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_TextureParamState>>();
		BlendTextureParamQueue = new Dictionary<int, Dictionary<FName, DispLib_One_UnitMat_TextureParamState>>();
	}

	public DispLib_One_UnitMat_ScalarParamState GetOrAdd_One_ScalarParamData(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		if (MIDycInfo == null || MIDycInfo.MIDyc.IsNullOrDestroyed())
		{
			return null;
		}
		if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI))
		{
			return null;
		}
		DispLib_One_UnitMat_ScalarParamState value = null;
		switch (Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			if (!GlobalScalarParamQueue.TryGetValue(ParameterName, out value))
			{
				float scalarParameterValueByInfo3 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo3);
				GlobalScalarParamQueue.Add(ParameterName, value);
			}
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			int index2 = MPI.Index;
			if (!LayerScalarParamQueue.TryGetValue(index2, out var value3))
			{
				value3 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
				LayerScalarParamQueue.Add(index2, value3);
			}
			if (!value3.TryGetValue(ParameterName, out value))
			{
				float scalarParameterValueByInfo2 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo2);
				value3.Add(ParameterName, value);
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			int index = MPI.Index;
			if (!BlendScalarParamQueue.TryGetValue(index, out var value2))
			{
				value2 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
				BlendScalarParamQueue.Add(index, value2);
			}
			if (!value2.TryGetValue(ParameterName, out value))
			{
				float scalarParameterValueByInfo = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo);
				value2.Add(ParameterName, value);
			}
			break;
		}
		}
		return value;
	}

	public DispLib_One_UnitMat_ColorParamState GetOrAdd_One_ColorParamData(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		if (MIDycInfo == null)
		{
			return null;
		}
		DispLib_One_UnitMat_ColorParamState value = null;
		FMaterialParameterInfo MPI;
		switch (Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			if (!GlobalColorParamQueue.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
				{
					return null;
				}
				FLinearColor vectorParameterValueByInfo3 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo3);
				GlobalColorParamQueue.Add(ParameterName, value);
			}
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
			{
				return null;
			}
			int index2 = MPI.Index;
			if (!LayerColorParamQueue.TryGetValue(index2, out var value3))
			{
				value3 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
				LayerColorParamQueue.Add(index2, value3);
			}
			if (!value3.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				FLinearColor vectorParameterValueByInfo2 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo2);
				value3.Add(ParameterName, value);
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
			{
				return null;
			}
			int index = MPI.Index;
			if (!BlendColorParamQueue.TryGetValue(index, out var value2))
			{
				value2 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
				BlendColorParamQueue.Add(index, value2);
			}
			if (!value2.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				FLinearColor vectorParameterValueByInfo = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo);
				value2.Add(ParameterName, value);
			}
			break;
		}
		}
		return value;
	}

	public DispLib_One_UnitMat_TextureParamState GetOrAdd_One_TextureParamData(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		if (MIDycInfo == null)
		{
			return null;
		}
		DispLib_One_UnitMat_TextureParamState value = null;
		FMaterialParameterInfo MPI;
		switch (Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			if (!GlobalTextureParamQueue.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
				{
					return null;
				}
				UTexture textureParameterValueByInfo3 = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo3);
				GlobalTextureParamQueue.Add(ParameterName, value);
			}
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
			{
				return null;
			}
			int index2 = MPI.Index;
			if (!LayerTextureParamQueue.TryGetValue(index2, out var value3))
			{
				value3 = new Dictionary<FName, DispLib_One_UnitMat_TextureParamState>();
				LayerTextureParamQueue.Add(index2, value3);
			}
			if (!value3.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				UTexture textureParameterValueByInfo2 = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo2);
				value3.Add(ParameterName, value);
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			if (!MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out MPI))
			{
				return null;
			}
			int index = MPI.Index;
			if (!BlendTextureParamQueue.TryGetValue(index, out var value2))
			{
				value2 = new Dictionary<FName, DispLib_One_UnitMat_TextureParamState>();
				BlendTextureParamQueue.Add(index, value2);
			}
			if (!value2.TryGetValue(ParameterName, out value))
			{
				if (MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					return null;
				}
				UTexture textureParameterValueByInfo = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
				value = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo);
				value2.Add(ParameterName, value);
			}
			break;
		}
		}
		return value;
	}

	public bool ScalarParamStateCacheResetPriority(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, int EventPriority)
	{
		DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData = GetOrAdd_One_ScalarParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ScalarParamData == null)
		{
			return false;
		}
		orAdd_One_ScalarParamData.TryReleasePriorityControl(EventPriority);
		return true;
	}

	public bool ColorParamStateCacheResetPriority(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, int EventPriority)
	{
		DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData = GetOrAdd_One_ColorParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ColorParamData == null)
		{
			return false;
		}
		orAdd_One_ColorParamData.TryReleasePriorityControl(EventPriority);
		return true;
	}

	public bool TextureParamStateCacheResetPriority(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, int EventPriority)
	{
		DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData = GetOrAdd_One_TextureParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_TextureParamData == null)
		{
			return false;
		}
		orAdd_One_TextureParamData.TryReleasePriorityControl(EventPriority);
		return true;
	}

	public bool ScalarParamOperationCounterAdd(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData = GetOrAdd_One_ScalarParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ScalarParamData == null)
		{
			return false;
		}
		orAdd_One_ScalarParamData.OperationCountAdd();
		isSleep = false;
		return true;
	}

	public bool ColorParamOperationCounterAdd(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData = GetOrAdd_One_ColorParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ColorParamData == null)
		{
			return false;
		}
		orAdd_One_ColorParamData.OperationCountAdd();
		isSleep = false;
		return true;
	}

	public bool TextureParamOperationCounterAdd(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo)
	{
		DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData = GetOrAdd_One_TextureParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_TextureParamData == null)
		{
			return false;
		}
		orAdd_One_TextureParamData.OperationCountAdd();
		isSleep = false;
		return true;
	}

	public bool ScalarParamOperationCounterRemove(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, uint MatParamEventID, FName OperationEventName)
	{
		DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData = GetOrAdd_One_ScalarParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ScalarParamData == null)
		{
			return false;
		}
		orAdd_One_ScalarParamData.OperationCountRemove();
		HasParamNeedReset = HasParamNeedReset || orAdd_One_ScalarParamData.CurTickNeedReset2InitialValue;
		return true;
	}

	public bool ColorParamOperationCounterRemove(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, uint MatParamEventID, FName OperationEventName)
	{
		DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData = GetOrAdd_One_ColorParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_ColorParamData == null)
		{
			return false;
		}
		orAdd_One_ColorParamData.OperationCountRemove();
		HasParamNeedReset = HasParamNeedReset || orAdd_One_ColorParamData.CurTickNeedReset2InitialValue;
		return true;
	}

	public bool TextureParamOperationCounterRemove(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, MIDycInfo MIDycInfo, uint MatParamEventID, FName OperationEventName)
	{
		DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData = GetOrAdd_One_TextureParamData(Association, LayerFunction, ParameterName, MIDycInfo);
		if (orAdd_One_TextureParamData == null)
		{
			return false;
		}
		orAdd_One_TextureParamData.OperationCountRemove();
		HasParamNeedReset = HasParamNeedReset || orAdd_One_TextureParamData.CurTickNeedReset2InitialValue;
		return true;
	}

	public int GetValidEventsCount()
	{
		int num = 0;
		foreach (DispLib_One_UnitMat_ScalarParamState value in GlobalScalarParamQueue.Values)
		{
			num += value.OperationCount;
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value2 in LayerScalarParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_ScalarParamState value3 in value2.Values)
			{
				num += value3.OperationCount;
			}
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value4 in BlendScalarParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_ScalarParamState value5 in value4.Values)
			{
				num += value5.OperationCount;
			}
		}
		foreach (DispLib_One_UnitMat_ColorParamState value6 in GlobalColorParamQueue.Values)
		{
			num += value6.OperationCount;
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value7 in LayerColorParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_ColorParamState value8 in value7.Values)
			{
				num += value8.OperationCount;
			}
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value9 in BlendColorParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_ColorParamState value10 in value9.Values)
			{
				num += value10.OperationCount;
			}
		}
		foreach (DispLib_One_UnitMat_TextureParamState value11 in GlobalTextureParamQueue.Values)
		{
			num += value11.OperationCount;
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_TextureParamState> value12 in LayerTextureParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_TextureParamState value13 in value12.Values)
			{
				num += value13.OperationCount;
			}
		}
		foreach (Dictionary<FName, DispLib_One_UnitMat_TextureParamState> value14 in BlendTextureParamQueue.Values)
		{
			foreach (DispLib_One_UnitMat_TextureParamState value15 in value14.Values)
			{
				num += value15.OperationCount;
			}
		}
		return num;
	}
}
