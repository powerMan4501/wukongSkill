using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GuardConditionCommonData
{
	public IBGC_MovieData MovieData { get; set; }

	public IBGC_PlayerGuideData PlayerGuideData { get; set; }

	public APlayerController PlayerController { get; set; }

	public IBPC_PlayerRoleData PlayerRoleData { get; set; }

	public APlayerState PlayerState { get; set; }

	public IBPC_PlayerTagData PlayerTagData { get; set; }

	public APawn PlayerPawn { get; set; }

	public IBUC_CheckData PlayerCheckData { get; set; }

	public IBUC_AbnormalStateHandlers AbnormalStateHandlers { get; set; }

	public IBUC_CloudMoveData CloudMoveData { get; set; }

	public IBUC_UnitStateData PlayerUnitStateData { get; set; }

	public void UpdateData_PreTick(UObject InWorldContext)
	{
		MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(InWorldContext);
		PlayerGuideData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_PlayerGuideData, BGC_PlayerGuideData>(InWorldContext);
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext);
		PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
		PlayerState = PlayerController.PlayerState;
		PlayerTagData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(PlayerState);
		PlayerPawn = ((PlayerController == null) ? null : PlayerController.GetControlledPawn());
		if (PlayerPawn is IECSWorldObj)
		{
			PlayerCheckData = ((PlayerPawn == null) ? null : BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(PlayerPawn));
			AbnormalStateHandlers = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>(PlayerPawn);
			CloudMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(PlayerPawn);
			PlayerUnitStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(PlayerPawn);
		}
	}

	public void ReleaseData_BeforePostUpdateWork()
	{
		MovieData = null;
		PlayerGuideData = null;
		PlayerController = null;
		PlayerRoleData = null;
		PlayerState = null;
		PlayerTagData = null;
		PlayerPawn = null;
		PlayerCheckData = null;
		AbnormalStateHandlers = null;
		CloudMoveData = null;
		PlayerUnitStateData = null;
	}
}
