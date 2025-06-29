namespace b1;

public class BGUAdsortLevelConfigInfo
{
	public int ExplosiveDamageBuff { get; set; }

	public float ExplosiveRadius { get; set; }

	public int ExplosiveLevel { get; set; }

	public int PlayerGainBuff { get; set; }

	public float PlayerGainRadius { get; set; }

	public BGUAdsortLevelConfigInfo(int _ExplosiveDamageBuffOne, float _ExplosiveRadius, int _ExplosiveLevel, int _PlayerGainBuff, float _PlayerGainRadius)
	{
		ExplosiveDamageBuff = _ExplosiveDamageBuffOne;
		ExplosiveRadius = _ExplosiveRadius;
		ExplosiveLevel = _ExplosiveLevel;
		PlayerGainBuff = _PlayerGainBuff;
		PlayerGainRadius = _PlayerGainRadius;
	}
}
