using b1.ECS;

namespace b1;

internal class BUS_PredictionTestCompSvr : UActorCompBaseCS
{
	private BUC_PredictionTestData PredictionTestData;

	public float TmpCountdown;

	public override void OnAttach()
	{
		base.OnAttach();
		PredictionTestData = RequireWritableData<BUC_PredictionTestData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TmpCountdown -= DeltaTime;
		if (TmpCountdown <= 0f)
		{
			TmpCountdown = 5f;
			if (PredictionTestData.TestEntity1 == Entity.Null)
			{
				PredictionTestData.TestEntity1 = ECSExtension.ToEntity(GetOwner());
				PredictionTestData.TestEntityList1.Add(PredictionTestData.TestEntity1);
				PredictionTestData.TestEntityListWithNetRole[0] = PredictionTestData.TestEntity1;
				PredictionTestData.TestEntityListWithNetRole[1] = PredictionTestData.TestEntity1;
				PredictionTestData.TestEntityDic[500] = PredictionTestData.TestEntity1;
			}
			else
			{
				PredictionTestData.TestEntity1 = Entity.Null;
				PredictionTestData.TestEntityList1.RemoveAt(0);
				PredictionTestData.TestEntityDic[500] = Entity.Null;
				PredictionTestData.TestEntityListWithNetRole[0] = Entity.Null;
				PredictionTestData.TestEntityListWithNetRole[1] = Entity.Null;
			}
		}
	}
}
