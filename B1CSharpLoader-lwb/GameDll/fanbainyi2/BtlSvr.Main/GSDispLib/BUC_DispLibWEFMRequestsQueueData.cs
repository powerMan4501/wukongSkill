using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLibWEFMRequestsQueueData : BUC_DispLibDataBase
{
	internal BUC_DispLib_PermanentWindMotor[] PermanentWindRequests;

	internal BUC_DispLib_PermanentHeatMotor[] PermanentHeatRequests;

	internal void Init(BUC_DispLibDBCPermanentWEFMMotorDataAsset PermanentWEFMMotorsDataAsset, UPrimitiveComponent MeshComp, int MaxDynamicRequestsCount = 10)
	{
		if (PermanentWEFMMotorsDataAsset.IsNullOrDestroyed() || MeshComp.IsNullOrDestroyed())
		{
			PermanentWindRequests = new BUC_DispLib_PermanentWindMotor[0];
			PermanentHeatRequests = new BUC_DispLib_PermanentHeatMotor[0];
			return;
		}
		TArrayReadWrite<BUC_DispLibDBC_WEFMPermanentWind> baseWindMotor = PermanentWEFMMotorsDataAsset.BaseWindMotor;
		PermanentWindRequests = new BUC_DispLib_PermanentWindMotor[baseWindMotor.Count];
		for (int i = 0; i < PermanentWindRequests.Length; i++)
		{
			PermanentWindRequests[i] = new BUC_DispLib_PermanentWindMotor(baseWindMotor[i], MeshComp);
		}
		TArrayReadWrite<BUC_DispLibDBC_Heat> baseHeatMotor = PermanentWEFMMotorsDataAsset.BaseHeatMotor;
		PermanentHeatRequests = new BUC_DispLib_PermanentHeatMotor[baseHeatMotor.Count];
		for (int j = 0; j < PermanentHeatRequests.Length; j++)
		{
			PermanentHeatRequests[j] = new BUC_DispLib_PermanentHeatMotor(baseHeatMotor[j], MeshComp);
		}
	}
}
