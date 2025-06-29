using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DecalMatComp : UActorCompBaseCS
{
	private b1.IBUC_DecalConfigData DecalConfigData;

	private b1.IBUC_FXActorLifeData FXActorLifeData;

	public override void OnBeginPlay()
	{
		DecalConfigData = RequireReadOnlyData<b1.IBUC_DecalConfigData, b1.BUC_DecalConfigData>();
		FXActorLifeData = RequireReadOnlyData<b1.IBUC_FXActorLifeData, BUC_FXActorLifeData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateMat();
	}

	private void UpdateMat()
	{
		BGUDecalActor bGUDecalActor = GetOwner() as BGUDecalActor;
		if (bGUDecalActor.IsNullOrDestroyed() || DecalConfigData == null || FXActorLifeData == null)
		{
			return;
		}
		UDecalComponent decal = bGUDecalActor.GetDecal();
		if (decal == null)
		{
			return;
		}
		UMaterialInstanceDynamic uMaterialInstanceDynamic = decal.GetDecalMaterial() as UMaterialInstanceDynamic;
		if (uMaterialInstanceDynamic == null)
		{
			uMaterialInstanceDynamic = decal.CreateDynamicMaterialInstance();
		}
		if (uMaterialInstanceDynamic == null)
		{
			return;
		}
		foreach (b1.GSFloatCurveToParam floatCurve in DecalConfigData.FloatCurveList)
		{
			if (floatCurve.CurveFloat != null)
			{
				float floatValue = floatCurve.CurveFloat.GetFloatValue(FXActorLifeData.FXActorAge);
				uMaterialInstanceDynamic.SetScalarParameterValue(floatCurve.ParamName, floatValue);
			}
		}
		foreach (b1.GSLinearColorCurveToParam linearColorCurve in DecalConfigData.LinearColorCurveList)
		{
			if (linearColorCurve.CurveLinearColor != null)
			{
				FLinearColor linearColorValue = linearColorCurve.CurveLinearColor.GetLinearColorValue(FXActorLifeData.FXActorAge);
				uMaterialInstanceDynamic.SetVectorParameterValue(linearColorCurve.ParamName, linearColorValue);
			}
		}
	}
}
