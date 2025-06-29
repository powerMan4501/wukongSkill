using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class MIDycInfo
{
	public UMaterialInstanceDynamic MIDyc { get; protected set; }

	public FName SlotName { get; protected set; }

	public int MaterialQuality { get; private set; } = -99;

	public float LastSetMatQualityTime { get; private set; } = -99f;

	public Dictionary<UMaterialFunctionInterface, int> LayerFunction2LayerIndex { get; protected set; }

	public Dictionary<UMaterialFunctionInterface, List<FName>> LayerAndBlendLayerInvalidRequestCache { get; protected set; }

	public void SetMIDyc(UMaterialInstanceDynamic _MIDyc)
	{
		MIDyc = _MIDyc;
	}

	public void SetMaterialQuality(AActor WorldCtx, int _MaterialQuality)
	{
		if (MaterialQuality != _MaterialQuality && !WorldCtx.IsNullOrDestroyed())
		{
			float num = BGU_DispLibDataUtil.GSTimeAfterBeginPlay(WorldCtx);
			if (_MaterialQuality == -1 || num - LastSetMatQualityTime >= 5f)
			{
				MaterialQuality = _MaterialQuality;
				LastSetMatQualityTime = num;
				UGSE_ActorFuncLib.SetMaterialInterfaceQualityLevel(WorldCtx, MIDyc, MaterialQuality);
			}
		}
	}

	public MIDycInfo(UMaterialInstanceDynamic _MIDyc, FName _SlotName)
	{
		MIDyc = _MIDyc;
		SlotName = _SlotName;
		LayerFunction2LayerIndex = new Dictionary<UMaterialFunctionInterface, int>();
		LayerAndBlendLayerInvalidRequestCache = new Dictionary<UMaterialFunctionInterface, List<FName>>();
	}

	public bool GetMPI(EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, out FMaterialParameterInfo MPI)
	{
		MPI = default(FMaterialParameterInfo);
		MPI.Association = Association;
		MPI.Name = ParameterName;
		if (Association == EMaterialParameterAssociation.GlobalParameter)
		{
			MPI.Index = -1;
			return true;
		}
		if (LayerFunction.IsNullOrDestroyed())
		{
			return false;
		}
		if (LayerFunction2LayerIndex.TryGetValue(LayerFunction, out var value))
		{
			MPI.Index = value;
			return true;
		}
		if (MIDyc.IsNullOrDestroyed())
		{
			return false;
		}
		bool flag = false;
		if (LayerAndBlendLayerInvalidRequestCache.TryGetValue(LayerFunction, out var value2))
		{
			flag = true;
			if (value2.Contains(ParameterName))
			{
				return false;
			}
		}
		FMaterialParameterInfo parameterInfo = MIDyc.GetParameterInfo(Association, ParameterName, LayerFunction);
		if (parameterInfo.Name == FName.None)
		{
			if (flag)
			{
				LayerAndBlendLayerInvalidRequestCache[LayerFunction].Add(ParameterName);
			}
			else
			{
				LayerAndBlendLayerInvalidRequestCache.Add(LayerFunction, new List<FName> { ParameterName });
			}
			return false;
		}
		LayerFunction2LayerIndex.Add(LayerFunction, parameterInfo.Index);
		MPI = parameterInfo;
		return true;
	}

	public override string ToString()
	{
		return "MIDyc = {" + (MIDyc.IsNullOrDestroyed() ? "null" : MIDyc.GetName()) + "}; SlotName = {" + SlotName.ToString() + "}; ";
	}
}
