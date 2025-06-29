using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSLeisureRandomConfig
{
	public float Weight;

	private TStrongObjectPtr<UAnimMontage> mRandomAnim = new TStrongObjectPtr<UAnimMontage>();

	public float CDTime;

	public UAnimMontage RandomAnim
	{
		get
		{
			return mRandomAnim.Get();
		}
		set
		{
			mRandomAnim.Set(value);
		}
	}

	public GSLeisureRandomConfig(in FGSLeisureRandomConfig Config)
	{
		Weight = Config.Weight;
		RandomAnim = Config.RandomAnim;
		CDTime = Config.CD_Time;
	}
}
