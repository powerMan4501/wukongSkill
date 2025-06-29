namespace b1;

public class BUC_TimeScaleData : IBUC_TimeScaleData
{
	public float GlobalNormalScale { get; set; }

	public FGSTimeScaleSetting TimeScaleSetting { get; set; }

	public float PassedDuration { get; set; }

	public float TotalDuration { get; set; }

	public float RealTimeStart { get; set; }

	public float RealTimeOutStart { get; set; }

	public bool IsDuringTimeScale { get; set; }

	public uint LastLocalTimeScaleHandleID { get; set; }

	public void Reset()
	{
		PassedDuration = 0f;
		TotalDuration = 0f;
		RealTimeStart = 0f;
		RealTimeOutStart = 0f;
		IsDuringTimeScale = false;
		LastLocalTimeScaleHandleID = 0u;
		TimeScaleSetting.Reset();
	}

	public void CopyData(IBUC_TimeScaleData OtherData)
	{
		if (OtherData != null)
		{
			GlobalNormalScale = OtherData.GlobalNormalScale;
			TimeScaleSetting = OtherData.TimeScaleSetting;
			PassedDuration = OtherData.PassedDuration;
			TotalDuration = OtherData.TotalDuration;
			RealTimeStart = OtherData.RealTimeStart;
			RealTimeOutStart = OtherData.RealTimeOutStart;
			IsDuringTimeScale = OtherData.IsDuringTimeScale;
			LastLocalTimeScaleHandleID = OtherData.LastLocalTimeScaleHandleID;
		}
	}
}
