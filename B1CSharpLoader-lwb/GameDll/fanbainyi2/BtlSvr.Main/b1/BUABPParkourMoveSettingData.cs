using UnrealEngine.Engine;

namespace b1;

public class BUABPParkourMoveSettingData : BUABPSettingDataBase
{
	public bool bEnableParkourAnim { get; private set; }

	public UAnimSequence ASStrideUpLeftFootLow { get; private set; }

	public UAnimSequence ASStrideUpRightFootLow { get; private set; }

	public UAnimSequence ASStrideUpLeftFootHigh { get; private set; }

	public UAnimSequence ASStrideUpRightFootHigh { get; private set; }

	public UAnimSequence ASStrideUpLeftFootFall { get; private set; }

	public UAnimSequence ASStrideUpRightFootFall { get; private set; }

	public UAnimSequence ASStrideUpLeftFootEnd { get; private set; }

	public UAnimSequence ASStrideUpRightFootEnd { get; private set; }

	public UAnimSequence ASStrideUpLeftFootLandMove { get; private set; }

	public UAnimSequence ASStrideUpRightFootLandMove { get; private set; }

	public UAnimSequence ASStrideDownLeftFoot { get; private set; }

	public UAnimSequence ASStrideDownRightFoot { get; private set; }

	public UAnimSequence ASStrideDownLeftFootFall { get; private set; }

	public UAnimSequence ASStrideDownRightFootFall { get; private set; }

	public UAnimSequence ASStrideDownLeftFootEnd { get; private set; }

	public UAnimSequence ASStrideDownRightFootEnd { get; private set; }

	public UAnimSequence ASStrideDownLeftFootLandMove { get; private set; }

	public UAnimSequence ASStrideDownRightFootLandMove { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_ParkourMove parkourMoveSetting = ABPSetting.ParkourMoveSetting;
			bEnableParkourAnim = parkourMoveSetting.bEnableParkourAnim;
			ASStrideUpLeftFootLow = parkourMoveSetting.ASStrideUpLeftFootLow;
			ASStrideUpRightFootLow = parkourMoveSetting.ASStrideUpRightFootLow;
			ASStrideUpLeftFootHigh = parkourMoveSetting.ASStrideUpLeftFootHigh;
			ASStrideUpRightFootHigh = parkourMoveSetting.ASStrideUpRightFootHigh;
			ASStrideUpLeftFootFall = parkourMoveSetting.ASStrideUpLeftFootFall;
			ASStrideUpRightFootFall = parkourMoveSetting.ASStrideUpRightFootFall;
			ASStrideUpLeftFootEnd = parkourMoveSetting.ASStrideUpLeftFootEnd;
			ASStrideUpRightFootEnd = parkourMoveSetting.ASStrideUpRightFootEnd;
			ASStrideUpLeftFootLandMove = parkourMoveSetting.ASStrideUpLeftFootLandMove;
			ASStrideUpRightFootLandMove = parkourMoveSetting.ASStrideUpRightFootLandMove;
			ASStrideDownLeftFoot = parkourMoveSetting.ASStrideDownLeftFoot;
			ASStrideDownRightFoot = parkourMoveSetting.ASStrideDownRightFoot;
			ASStrideDownLeftFootFall = parkourMoveSetting.ASStrideDownLeftFootFall;
			ASStrideDownRightFootFall = parkourMoveSetting.ASStrideDownRightFootFall;
			ASStrideDownLeftFootEnd = parkourMoveSetting.ASStrideDownLeftFootEnd;
			ASStrideDownRightFootEnd = parkourMoveSetting.ASStrideDownRightFootEnd;
			ASStrideDownLeftFootLandMove = parkourMoveSetting.ASStrideDownLeftFootLandMove;
			ASStrideDownRightFootLandMove = parkourMoveSetting.ASStrideDownRightFootLandMove;
		}
	}
}
