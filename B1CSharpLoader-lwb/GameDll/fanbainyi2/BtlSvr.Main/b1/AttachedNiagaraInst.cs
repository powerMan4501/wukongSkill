using UnrealEngine.Runtime;

namespace b1;

public class AttachedNiagaraInst
{
	public int GamePlayDispReqID { get; set; }

	public string DBCPathName { get; set; }

	public FVector HitLocation { get; set; }

	public FName BoneName { get; set; }

	public FVector RelativeLocation { get; set; }

	public float Timer { get; set; }

	public float DurTime { get; set; }

	public AttachedNiagaraInst(FVector _HitLocation, float _DurTime, FName _BoneName, FVector _RelativeLocation, int _GamePlayDispReqID = -1, string _DBCPathName = "")
	{
		GamePlayDispReqID = _GamePlayDispReqID;
		DBCPathName = _DBCPathName;
		HitLocation = _HitLocation;
		DurTime = _DurTime;
		Timer = _DurTime;
		BoneName = _BoneName;
		RelativeLocation = _RelativeLocation;
	}
}
