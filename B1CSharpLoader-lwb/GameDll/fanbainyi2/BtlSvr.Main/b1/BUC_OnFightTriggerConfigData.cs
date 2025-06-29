using UnrealEngine.Runtime;

namespace b1;

internal class BUC_OnFightTriggerConfigData
{
	private TStrongObjectPtr<BGUCharacterCS> mTargetUnit = new TStrongObjectPtr<BGUCharacterCS>();

	public int OnFightSkillID;

	public BGUCharacterCS TargetUnit
	{
		get
		{
			return mTargetUnit.Get();
		}
		set
		{
			mTargetUnit.Set(value);
		}
	}
}
