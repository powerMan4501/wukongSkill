namespace b1;

public class FCameraBlend_PlayerSkill : FCameraBlend_Player
{
	protected override void BlendCamera()
	{
		if (base.CameraState.bUsePlayerSkillCamera)
		{
			BlendPlayerCamera();
		}
	}

	public FCameraBlend_PlayerSkill(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
