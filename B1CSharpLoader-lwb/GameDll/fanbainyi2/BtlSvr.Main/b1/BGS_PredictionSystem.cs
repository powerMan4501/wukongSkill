using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1;

public class BGS_PredictionSystem : GameStateSystemBase
{
	private BGC_PredictionKeyData PredictionKeyData;

	private static List<int> sPredictionKeyIdListToBeRollBack = new List<int>();

	public override void OnAttach()
	{
		base.OnAttach();
		PredictionKeyData = RequireWritableData<BGC_PredictionKeyData>();
		base.BGSEventCollection.Evt_BGS_AllocPredictionKey += new Del_AllocPredictionKey(AllocPredictionKey);
		base.BGSEventCollection.Evt_BGS_GetPredictionKeyById += new Del_GetPredictionKeyById(GetPredictionKeyById);
		base.BGSEventCollection.Evt_BGS_ConfirmPredictionKey += new Del_Void_Int(ConfirmPredictionKey);
		base.BGSEventCollection.Evt_BGS_RollBackPredictionKey += new Del_Void_Int(RollBackPredictionKey);
	}

	public GSPredictionKey AllocPredictionKey()
	{
		int predictionKeyAlloc = PredictionKeyData.PredictionKeyAlloc;
		PredictionKeyData.PredictionKeyAlloc++;
		GSPredictionKey gSPredictionKey = new GSPredictionKey
		{
			Id = predictionKeyAlloc
		};
		PredictionKeyData.PredictionKeySet[predictionKeyAlloc] = gSPredictionKey;
		PredictionKeyData.PredictingingPredictionKey?.AddChild(gSPredictionKey);
		return gSPredictionKey;
	}

	public GSPredictionKey GetPredictionKeyById(int PredictionKeyId)
	{
		PredictionKeyData.PredictionKeySet.TryGetValue(PredictionKeyId, out var value);
		return value;
	}

	public void RollBackAllPredictionKeyBellow(int PredictionKeyId)
	{
		sPredictionKeyIdListToBeRollBack.Clear();
		foreach (KeyValuePair<int, GSPredictionKey> item in PredictionKeyData.PredictionKeySet)
		{
			if (item.Key < PredictionKeyId)
			{
				sPredictionKeyIdListToBeRollBack.Add(item.Key);
			}
		}
		foreach (int item2 in sPredictionKeyIdListToBeRollBack)
		{
			RollBackPredictionKey(item2);
		}
	}

	public void ConfirmPredictionKey(int PredictionKeyId)
	{
		GSPredictionKey predictionKeyById = GetPredictionKeyById(PredictionKeyId);
		if (predictionKeyById != null)
		{
			predictionKeyById.DoConfirm();
			PredictionKeyData.PredictionKeySet.Remove(PredictionKeyId);
		}
	}

	public void RollBackPredictionKey(int PredictionKeyId)
	{
		GSPredictionKey predictionKeyById = GetPredictionKeyById(PredictionKeyId);
		if (predictionKeyById != null)
		{
			predictionKeyById.DoRollBack();
			PredictionKeyData.PredictionKeySet.Remove(PredictionKeyId);
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}
}
