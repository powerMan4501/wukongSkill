using System.Collections.Generic;
using b1.BGU.BUAnim;

namespace b1;

internal class BUC_AnimMgrData
{
	public BUAnimHumanoidCS AbpInst;

	public List<EAnimMode> ActiveList;

	public EAnimMode CurActiveMode;

	public double UpdataExitTimer;

	public bool InExitAnim;

	public FBUAnimSettingsLocomotionEx ExAS_Default;

	public PatrolBlendSpaceSetting ExBS_Patrol;

	public FBUAnimSettingsLocomotionEx ExAS_EQSRun;

	public FBUAnimSettingsLocomotionEx ExAS_Shield;

	public FBUAnimSettingsLocomotionEx ExAS_PowerStorage;
}
