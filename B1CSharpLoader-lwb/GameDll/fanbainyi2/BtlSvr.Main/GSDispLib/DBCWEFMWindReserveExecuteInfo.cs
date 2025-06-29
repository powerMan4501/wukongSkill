using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCWEFMWindReserveExecuteInfo
{
	public uint RequesterUniqueID { get; protected set; }

	public FVector CenterPosWS { get; protected set; }

	public FVector DirWS { get; protected set; }

	public FVector SizeV3 { get; protected set; }

	public float DistanceDamplingRate { get; protected set; }

	public int WindType { get; protected set; }

	public float Intensity { get; protected set; }

	public FVector4 WindDataV4 { get; protected set; }

	public void MergeData(FVector _CenterPosWS, FVector _DirWS, FVector _WindSizeV3, float _Intensity, FVector4 _WindDataV4)
	{
		Intensity += _Intensity;
	}

	public void CleanData()
	{
		RequesterUniqueID = 0u;
		CenterPosWS = FVector.ZeroVector;
		DirWS = FVector.ZeroVector;
		SizeV3 = FVector.ZeroVector;
		DistanceDamplingRate = 0f;
		WindType = 0;
		Intensity = 0f;
		WindDataV4 = FVector4.ZeroVector;
	}

	public DBCWEFMWindReserveExecuteInfo(uint _RequesterUniqueID, FVector _CenterPosWS, FVector _DirWS, FVector _WindSizeV3, float _Intensity, int _WindType, float _DistanceDamplingRate, FVector4 _WindDataV4)
	{
		RequesterUniqueID = _RequesterUniqueID;
		CenterPosWS = _CenterPosWS;
		DirWS = _DirWS;
		SizeV3 = _WindSizeV3;
		WindType = _WindType;
		DistanceDamplingRate = _DistanceDamplingRate;
		WindDataV4 = _WindDataV4;
		Intensity = _Intensity;
	}

	public DBCWEFMWindReserveExecuteInfo SetData(uint _RequesterUniqueID, FVector _CenterPosWS, FVector _DirWS, FVector _WindSizeV3, float _Intensity, int _WindType, float _DistanceDamplingRate, FVector4 _WindDataV4)
	{
		RequesterUniqueID = _RequesterUniqueID;
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
