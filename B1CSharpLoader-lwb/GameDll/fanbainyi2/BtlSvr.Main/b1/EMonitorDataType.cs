namespace b1;

public enum EMonitorDataType : byte
{
	None = 0,
	ControllerInput = 1,
	ControllerRotation = 2,
	ControllerPitchRange = 3,
	ArmLocation = 4,
	ArmSocketOffset = 5,
	ArmLength = 6,
	Fov = 7,
	PlayerPos = 8,
	TargetPos = 9,
	PlayerRoot = 101,
	PlayerPelvis = 102,
	PlayerRef = 103,
	TargetRoot = 104,
	TargetPelvis = 105,
	TargetRef = 106,
	CameraRef = 107,
	CameraPos = 108,
	CameraFacePos = 109,
	ArmPos = 110,
	CameraPitchPos = 111
}
