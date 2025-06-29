using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

public class GSRandomPatrolConfig : GSWaitAMConfig
{
	private TStrongObjectPtr<UEnvQuery> mEnvQuery = new TStrongObjectPtr<UEnvQuery>();

	public UEnvQuery EnvQuery
	{
		get
		{
			return mEnvQuery.Get();
		}
		set
		{
			mEnvQuery.Set(value);
		}
	}

	public GSRandomPatrolConfig(in FRandomPatrolConfig InConfig)
		: base(InConfig.WaitAMProbability, InConfig.WaitAM)
	{
		EnvQuery = InConfig.EnvQuery;
	}

	public GSRandomPatrolConfig(GSRandomPatrolConfig other)
		: base(other)
	{
		EnvQuery = other.EnvQuery;
	}
}
