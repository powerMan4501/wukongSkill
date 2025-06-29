using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using b1.Prediction;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PredictionTestComp : UActorCompBaseCS
{
	private BUC_PredictionTestData PredictionTestData;

	private bool TestCalled;

	public override void OnAttach()
	{
		base.OnAttach();
		PredictionTestData = RequireWritableData<BUC_PredictionTestData>();
		base.BUSEventCollection.Evt_TestPredict.Predict += new GSDel_Void_IPK_Del.Del_Predict(TestPredict_Predict);
		base.BUSEventCollection.Evt_TestPredict.Confirm += new GSDel_Void_IPK_Del.Del_Predict(TestPredict_Confirm);
		base.BUSEventCollection.Evt_TestPredict.RollBack += new GSDel_Void_IPK_Del.Del_Predict(TestPredict_RollBack);
		base.BUSEventCollection.Evt_TestPredict.Cue += new GSDel_Void_IPK_Del.Del_Predict(TestPredict_Cue);
		base.BUSEventCollection.Evt_TestPredictServer_Validate += () => false;
	}

	public override void PreBeginPlay()
	{
		PredictionTestData.TestList.Add(PredictionTestData.TestInt);
		PredictionTestData.TestDictionary.Add("Test", PredictionTestData.TestInt);
		PredictionTestData.PredictionKeyData = RequireReadOnlyGameStateData<IBGC_PredictionKeyData, BGC_PredictionKeyData>();
	}

	private void LogInfo(string Tag, GSPredictionKey PredictionKey = null)
	{
		BGW_LogUtil.LogError($"BUS_PredictionTestComp {Tag} PredictionKey:{PredictionKey} ::LocalRole:{GetOwner().GetLocalRole()} {PredictionTestData.TestInt} {PredictionTestData.TestVector} {PredictionTestData.TestString}");
		BGW_LogUtil.LogError($"BUS_PredictionTestComp {Tag} PredictionKey:{PredictionKey} ::LocalRole:{GetOwner().GetLocalRole()}:: TestList : {PredictionTestData.TestList}");
		BGW_LogUtil.LogError($"BUS_PredictionTestComp {Tag} PredictionKey:{PredictionKey} ::LocalRole:{GetOwner().GetLocalRole()}:: TestDictionary : {PredictionTestData.TestDictionary}");
	}

	private void TestPredict_Cue(GSPredictionKey PredictionKey)
	{
		LogInfo("Cue Begin");
		PredictionTestData.TestInt += 1;
		PredictionTestData.TestString = "TestPredict_Cue";
		LogInfo("Cue End");
	}

	private void TestPredict_Predict(GSPredictionKey PredictionKey)
	{
		LogInfo("Predict Begin");
		PredictionTestData.TestInt += 1;
		PredictionTestData.TestString = $"PredictionKey:{PredictionKey.Id}";
		PredictionTestData.TestList.Set(0, PredictionTestData.TestInt * 100 + FMath.RandRange(0, 100), PredictionKey);
		PredictionTestData.TestDictionary.Set("Test", PredictionTestData.TestInt * 100 + FMath.RandRange(0, 100), PredictionKey);
		LogInfo("Predict End");
	}

	private void TestPredict_Confirm(GSPredictionKey PredictionKey)
	{
		LogInfo("Confirm Begin");
		LogInfo("Confirming 1");
		LogInfo("Confirming 2");
		LogInfo("Confirm End");
	}

	private void TestPredict_RollBack(GSPredictionKey PredictionKey)
	{
		LogInfo("RollBack");
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner) && !TestCalled)
		{
			TestCalled = true;
			base.BUSEventCollection.Evt_TestPredict.Invoke();
		}
		foreach (Entity item in PredictionTestData.TestEntityList1)
		{
			_ = item;
		}
		foreach (Entity item2 in PredictionTestData.TestEntityListWithNetRole)
		{
			_ = item2;
		}
		foreach (KeyValuePair<int, Entity> item3 in PredictionTestData.TestEntityDic)
		{
			_ = item3;
		}
	}
}
