namespace b1;

public interface IBUC_TimeScaleData
{
	float GlobalNormalScale { get; }

	FGSTimeScaleSetting TimeScaleSetting { get; }

	float PassedDuration { get; }

	float TotalDuration { get; }

	float RealTimeStart { get; }

	float RealTimeOutStart { get; }

	bool IsDuringTimeScale { get; }

	uint LastLocalTimeScaleHandleID { get; }
}
