using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCWEFMWindExecuteInfo
{
	public bool isUsing;

	public FVector CenterPosWS { get; protected set; }

	public FVector DirWS { get; protected set; }

	public FVector SizeV3 { get; protected set; }

	public float DistanceDamplingRate { get; protected set; }

	public int WindType { get; protected set; }

	public float Intensity { get; protected set; }

	public FVector4 WindDataV4 { get; protected set; }

	public DBCWEFMWindExecuteInfo SetData(bool _isUsing, FVector _CenterPosWS, FVector _DirWS, FVector _WindSizeV3, float _Intensity, int _WindType, float _DistanceDamplingRate, FVector4 _WindDataV4)
	{
		isUsing = _isUsing;
		CenterPosWS = _CenterPosWS;
		DirWS = _DirWS;
		SizeV3 = _WindSizeV3;
		WindType = _WindType;
		DistanceDamplingRate = _DistanceDamplingRate;
		WindDataV4 = _WindDataV4;
		Intensity = _Intensity;
		return this;
	}
}
