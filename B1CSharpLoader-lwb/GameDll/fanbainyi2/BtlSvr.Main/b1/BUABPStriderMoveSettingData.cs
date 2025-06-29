namespace b1;

public class BUABPStriderMoveSettingData : BUABPSettingDataBase
{
	public float StriderStopTime { get; private set; }

	public float StriderStopDistance { get; private set; }

	public float StriderLoopAnimTimeStart { get; private set; }

	public float StriderGuiChuTime { get; private set; }

	public float StriderSingleStep { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_StriderMove striderMoveSetting = ABPSetting.StriderMoveSetting;
			StriderStopTime = striderMoveSetting.StriderStopTime;
			StriderStopDistance = striderMoveSetting.StriderStopDistance;
			StriderLoopAnimTimeStart = striderMoveSetting.StriderLoopAnimTimeStart;
			StriderGuiChuTime = striderMoveSetting.StriderGuiChuTime;
			StriderSingleStep = striderMoveSetting.StriderSingleStep;
		}
	}
}
