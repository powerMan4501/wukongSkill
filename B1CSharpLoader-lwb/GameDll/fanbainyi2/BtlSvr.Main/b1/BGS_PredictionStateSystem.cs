using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BGS_PredictionStateSystem : GameStateSystemBase
{
	private BGC_PredictionKeyData PredictionKeyData;

	public override void OnAttach()
	{
		base.OnAttach();
		PredictionKeyData = RequireWritableData<BGC_PredictionKeyData>();
		base.BGSEventCollection.Evt_BGS_BeginPredictionScope += new Del_BeginPredictionScope(BeginPredictionScope);
		base.BGSEventCollection.Evt_BGS_EndPredictionScope += new Del_Void(EndPredictionScope);
	}

	protected void BeginPredictionScope(EPredictionState ScopeState, IntPtr ActiveFunctionAddr, int RelatedKeyId, APlayerState PridictOriginator)
	{
		PredictionKeyData.PredictionState.Push(ScopeState);
		PredictionKeyData.ActiveFunctionAddr = ActiveFunctionAddr;
		PredictionKeyData.PridictOriginator = PridictOriginator;
		switch (ScopeState)
		{
		case EPredictionState.ClientPredicting:
			PredictionKeyData.PredictingingPredictionKeyStack.Push(PredictionKeyData.PredictionKeySet[RelatedKeyId]);
			break;
		case EPredictionState.ClientConfiming:
		{
			if (GSEUtil.Ensure(PredictionKeyData.PredictionKeySet.TryGetValue(RelatedKeyId, out var value)))
			{
				PredictionKeyData.ConfirmmingPredictionKey = value;
			}
			break;
		}
		}
	}

	protected void EndPredictionScope()
	{
		EPredictionState ePredictionState = PredictionKeyData.PredictionState.Pop();
		PredictionKeyData.ActiveFunctionAddr = IntPtr.Zero;
		PredictionKeyData.PridictOriginator = null;
		switch (ePredictionState)
		{
		case EPredictionState.ClientPredicting:
			PredictionKeyData.PredictingingPredictionKeyStack.Pop();
			break;
		case EPredictionState.ClientConfiming:
			PredictionKeyData.ConfirmmingPredictionKey = null;
			break;
		}
	}
}
