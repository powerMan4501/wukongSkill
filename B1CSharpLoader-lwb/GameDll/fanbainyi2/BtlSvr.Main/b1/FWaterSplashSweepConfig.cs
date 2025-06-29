using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FWaterSplashSweepConfig
{
	public int MappingID;

	public float SweepRadius;

	public int WeaponIndex;

	public List<FName> SocketNameList;

	public Dictionary<float, FVector> PresetLocalPoints;

	public List<FVector> PresetLocalSweepTangent;

	public float CurTime;

	public int Index;

	public bool AlreadyPostAudio;

	public int PlayingID;

	public FWaterSplashSweepConfig(int _MappingID, float _SweepRadius, int _WeaponIndex, TArrayReadWrite<FName> _SocketNameList, TMapReadWrite<float, FVector> _PresetLocalPoints, TArrayReadWrite<FVector> _PresetLocalSweepTangent)
	{
		MappingID = _MappingID;
		SweepRadius = _SweepRadius;
		WeaponIndex = _WeaponIndex;
		SocketNameList = new List<FName>();
		foreach (FName _SocketName in _SocketNameList)
		{
			SocketNameList.Add(_SocketName);
		}
		PresetLocalPoints = new Dictionary<float, FVector>();
		foreach (KeyValuePair<float, FVector> _PresetLocalPoint in _PresetLocalPoints)
		{
			PresetLocalPoints.Add(_PresetLocalPoint.Key, _PresetLocalPoint.Value);
		}
		PresetLocalSweepTangent = new List<FVector>();
		foreach (FVector item in _PresetLocalSweepTangent)
		{
			PresetLocalSweepTangent.Add(item);
		}
		CurTime = 0f;
		Index = 0;
		AlreadyPostAudio = false;
		PlayingID = -1;
	}
}
