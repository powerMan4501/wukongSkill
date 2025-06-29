using b1.ECS;

namespace b1;

public class BUC_SimpleJumpData : IBUC_SimpleJumpData, IPersistentECSData
{
	public bool bStartJump { get; set; }

	public bool IsRootMotionJump { get; set; }

	public uint MovementModeHandleID { get; set; }
}
