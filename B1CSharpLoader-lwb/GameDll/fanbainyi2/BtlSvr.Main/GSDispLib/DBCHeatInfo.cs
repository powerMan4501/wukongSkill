using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCHeatInfo
{
	public bool isUsing;

	public FVector CenterPosWS { get; protected set; }

	public FVector SizeV3 { get; protected set; }

	public float DistanceDamplingRate { get; protected set; }

	public float Intensity { get; protected set; }

	public FVector4 WindDataV4 { get; protected set; }

	public DBCHeatInfo SetData(bool _isUsing, FVector _CenterPosWS, FVector _SizeV3, float _Intensity, float _DistanceDamplingRate, FVector4 _DataV4)
	{
		isUsing = _isUsing;
		CenterPosWS = _CenterPosWS;
		SizeV3 = _SizeV3;
		DistanceDamplingRate = _DistanceDamplingRate;
		WindDataV4 = _DataV4;
		Intensity = _Intensity;
		return this;
	}
}
