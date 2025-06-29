using UnrealEngine.Engine;

namespace b1;

public class BUABPGlideMove_StartSettingData
{
	public UAnimSequence ASGlideStartGroundFlatSlow { get; private set; }

	public UAnimSequence ASGlideStartGroundFlatFast { get; private set; }

	public UAnimSequence ASGlideStartGroundSteepSlow { get; private set; }

	public UAnimSequence ASGlideStartGroundSteepFast { get; private set; }

	public UAnimSequence ASGlideStartAirFlatSlow { get; private set; }

	public UAnimSequence ASGlideStartAirFlatFast { get; private set; }

	public UAnimSequence ASGlideStartAirSteepSlow { get; private set; }

	public UAnimSequence ASGlideStartAirSteepFast { get; private set; }

	public UAnimSequence ASGlideStartBackAirFlat { get; private set; }

	public UAnimSequence ASGlideStartBackAirSteep { get; private set; }

	public BUABPGlideMove_StartSettingData(in FAnimHumanoidSetting_GlideMove_Start Setting)
	{
		ASGlideStartGroundFlatSlow = Setting.ASGlideStartGroundFlatSlow;
		ASGlideStartGroundFlatFast = Setting.ASGlideStartGroundFlatFast;
		ASGlideStartGroundSteepSlow = Setting.ASGlideStartGroundSteepSlow;
		ASGlideStartGroundSteepFast = Setting.ASGlideStartGroundSteepFast;
		ASGlideStartAirFlatSlow = Setting.ASGlideStartAirFlatSlow;
		ASGlideStartAirFlatFast = Setting.ASGlideStartAirFlatFast;
		ASGlideStartAirSteepSlow = Setting.ASGlideStartAirSteepSlow;
		ASGlideStartAirSteepFast = Setting.ASGlideStartAirSteepFast;
		ASGlideStartBackAirFlat = Setting.ASGlideStartBackAirFlat;
		ASGlideStartBackAirSteep = Setting.ASGlideStartBackAirSteep;
	}
}
