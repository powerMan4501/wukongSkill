using BtlB1;

namespace b1;

public class InteractContext
{
	public BGP_PlayerControllerCS OwnerController;

	public BPC_PlayerInteractData PlayerInteractData;

	public IBUC_UnitStateData UnitStateData;

	public IBUC_SimpleStateData SimpleStateData;

	public IBPC_PlayerTagData PlayerTagData;

	public IBUC_UnitStateData TargetUnitStateData;

	public IBUC_SimpleStateData TargetSimpleStateData;

	public BUC_InteractData TargetInteractData;

	public FUStInteractiveUnitCommDesc InteractiveUnitCommDesc;

	public BUInteractTypeTemplate InteractTypeTemplate;

	public BUInteractActionTemplate InteractActionTemplate;

	public bool IsOnline;
}
