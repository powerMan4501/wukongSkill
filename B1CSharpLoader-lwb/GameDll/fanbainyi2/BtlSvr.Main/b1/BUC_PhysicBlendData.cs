using System.Collections.Generic;

namespace b1;

public class BUC_PhysicBlendData : b1.IBUC_PhysicBlendData
{
	public List<PhysicBlendBoneInfo> NeedBlendBoneInfoList { get; set; }

	public List<PhysicBlendBoneInfoForDeath> NeedBlendBoneInfoForDeathList { get; set; }

	public bool bLastShouldEnablePhysicsBlend { get; set; }

	public float PhysicBlendAlpha_ForRigidBody { get; set; }

	public bool CallDissolveWhenPhysicsFinish { get; set; }

	public BUC_PhysicBlendData()
	{
		NeedBlendBoneInfoList = new List<PhysicBlendBoneInfo>();
		NeedBlendBoneInfoForDeathList = new List<PhysicBlendBoneInfoForDeath>();
		PhysicBlendAlpha_ForRigidBody = 1f;
		CallDissolveWhenPhysicsFinish = false;
	}
}
