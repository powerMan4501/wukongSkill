using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_FXProcessComp : UActorCompBaseCS
{
	private b1.BUC_FXActorBaseData FXActorBaseData;

	public override void OnAttach()
	{
		FXActorBaseData = RequireWritableData<b1.BUC_FXActorBaseData>();
	}

	public override void OnBeginPlay()
	{
		if (GetOwner().ActorHasTag(B1GlobalFNames.SVF))
		{
			base.BUSEventCollection.Evt_SetFloatValueToMaterialAdvect += new Del_SetFloatValueToMaterialAdvect(SetFloatValueToMaterialAdvect);
		}
	}

	private void SetFloatValueToMaterialAdvect(FName ParamName, float FloatValue)
	{
		BGUFXActorBase bGUFXActorBase = GetOwner() as BGUFXActorBase;
		if (bGUFXActorBase != null)
		{
			bGUFXActorBase.SetFloatValueToMaterialAdvect(ParamName, FloatValue);
		}
	}
}
