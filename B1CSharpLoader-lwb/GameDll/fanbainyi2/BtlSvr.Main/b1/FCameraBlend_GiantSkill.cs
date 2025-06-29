namespace b1;

public class FCameraBlend_GiantSkill : FCameraBlend_Giant
{
	public FCameraBlend_GiantSkill(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}

	protected override void BlendCamera()
	{
		if (base.CameraState.bUseMonsterSkillCamera)
		{
			Blend2GiantCamera();
		}
	}
}
