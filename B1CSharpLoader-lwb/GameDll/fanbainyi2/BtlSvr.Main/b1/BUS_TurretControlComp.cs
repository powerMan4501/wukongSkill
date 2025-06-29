namespace b1;

public class BUS_TurretControlComp : UActorCompBaseCS
{
	private BUC_TurretControlData TurretControlData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	public override void OnAttach()
	{
		TurretControlData = RequireWritableData<BUC_TurretControlData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
	}

	public override void PreBeginPlay()
	{
		TurretControlData.Turn2CameraYawSpeed = 1f / TurretControlData.Turn2CameraBlendTime;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TurretControlData.bEnableTurretControl)
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				TurretControlData.bEnableTurretRotate = false;
			}
			else
			{
				TurretControlData.bEnableTurretRotate = true;
			}
			if (TargetInfoData.GetTargetInfo().IsValidManualTargetInfo())
			{
				TurretControlData.Turn2CameraTriggerYaw = TurretControlData.Turn2CameraOriginTriggerYaw;
				TurretControlData.Turn2CameraDelay = TurretControlData.Turn2CameraOriginDelay;
			}
			else
			{
				TurretControlData.Turn2CameraTriggerYaw = 0f;
				TurretControlData.Turn2CameraDelay = 0f;
			}
		}
	}
}
