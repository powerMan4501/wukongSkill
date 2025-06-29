using UnrealEngine.Engine;

namespace b1;

public class BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData
{
	public UAnimSequence ASStopBlendAnim { get; private set; }

	public float BlendInTime { get; private set; }

	public float BlendOutTime { get; private set; }

	public float PlayRate { get; private set; }

	public float StartPosition { get; private set; }

	public BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData(in FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim Setting)
	{
		ASStopBlendAnim = Setting.ASStopBlendAnim;
		BlendInTime = Setting.BlendInTime;
		BlendOutTime = Setting.BlendOutTime;
		PlayRate = Setting.PlayRate;
		StartPosition = Setting.StartPosition;
	}
}
