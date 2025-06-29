using b1.EventDelDefine;

namespace b1;

internal class BUS_CustomTimeDilationComp : UActorCompBaseCS
{
	private b1.BUC_CustomTimeDilationData CustomTimeDilationData;

	private IBUC_PropMgrData PropMgrData;

	public override void OnAttach()
	{
		CustomTimeDilationData = RequireWritableData<b1.BUC_CustomTimeDilationData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_SetGMCustomTimeDilation += new Del_Void_Float(OnSetGMCustomTimeDilation);
	}

	private void OnSetGMCustomTimeDilation(float Value)
	{
		if (Value.Equals(1f))
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(CustomTimeDilationData.CustomTimeDilationHandleID);
			CustomTimeDilationData.CustomTimeDilationHandleID = 0u;
		}
		else if (CustomTimeDilationData.CustomTimeDilationHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, Value);
			CustomTimeDilationData.CustomTimeDilationHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, Value, CustomTimeDilationData.CustomTimeDilationHandleID);
		}
	}
}
