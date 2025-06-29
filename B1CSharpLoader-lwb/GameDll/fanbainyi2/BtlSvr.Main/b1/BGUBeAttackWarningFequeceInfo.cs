namespace b1;

public class BGUBeAttackWarningFequeceInfo
{
	public float MontageResetTime { get; set; }

	public float ResetTime { get; set; }

	public int FromInstanceID { get; set; }

	public int GroupID { get; set; }

	public bool IsTriggered { get; set; }

	public BGUBeAttackWarningFequeceInfo(int _FromInstanceID, int _GroupID, float _ResetTime, float _MontageResetTime, bool _IsTriggered)
	{
		ResetTime = _ResetTime;
		FromInstanceID = _FromInstanceID;
		GroupID = _GroupID;
		MontageResetTime = _MontageResetTime;
		IsTriggered = _IsTriggered;
	}
}
