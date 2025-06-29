using b1.Plugins.AsyncLoadingScreen;
using ResB1;

namespace b1;

public class FSMCondition_GI_Loading_IsEnableLoadingUserInput : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsEnableLoadingUserInput(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsEnableLoadingUserInput_Result GetEResult()
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(Context.GameInst);
		if (bGW_SettingMgrV != null && Context.GameInst.GetCurLoadingScreenType() == EGSLoadingScreenType.Full)
		{
			if (bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.ManuallyCloseToggleLoading))
			{
				return EGI_Loading_IsEnableLoadingUserInput_Result.False;
			}
			return EGI_Loading_IsEnableLoadingUserInput_Result.True;
		}
		return EGI_Loading_IsEnableLoadingUserInput_Result.False;
	}
}
