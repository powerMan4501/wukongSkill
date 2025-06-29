namespace b1;

public class FCameraBlend_LockSkill : FCameraBlend_Lock
{
	public FCameraBlend_LockSkill(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}

	protected override void BlendCamera()
	{
		if (base.CameraState.bUseMonsterSkillCamera)
		{
			Blend2LockCamera();
		}
	}
}
