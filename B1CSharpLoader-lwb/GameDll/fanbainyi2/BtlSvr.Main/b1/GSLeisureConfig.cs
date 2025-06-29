using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSLeisureConfig
{
	private TStrongObjectPtr<UAnimMontage> mLeisureAnim = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> mNPCAnimOverrideLeisureAnim = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> mAfterSequenceOverrideLeisureAnim = new TStrongObjectPtr<UAnimMontage>();

	public UAnimMontage LeisureAnim
	{
		get
		{
			return mLeisureAnim.Get();
		}
		set
		{
			mLeisureAnim.Set(value);
		}
	}

	public bool bRandomStartTime { get; set; }

	public bool bGroupSyncLeisure { get; set; }

	public List<GSLeisureRandomConfig> RandomConfig { get; set; } = new List<GSLeisureRandomConfig>();

	public UAnimMontage NPCAnimOverrideLeisureAnim
	{
		get
		{
			return mNPCAnimOverrideLeisureAnim.Get();
		}
		set
		{
			mNPCAnimOverrideLeisureAnim.Set(value);
		}
	}

	public int ReplaceLeisureSequenceID { get; set; }

	public UAnimMontage AfterSequenceOverrideLeisureAnim
	{
		get
		{
			return mAfterSequenceOverrideLeisureAnim.Get();
		}
		set
		{
			mAfterSequenceOverrideLeisureAnim.Set(value);
		}
	}

	public GSLeisureConfig(in FGSLeisureConfig InConfig)
	{
		LeisureAnim = InConfig.LeisureAnim;
		bRandomStartTime = InConfig.bRandomStartTime;
		bGroupSyncLeisure = InConfig.bGroupSyncLeisure;
		foreach (FGSLeisureRandomConfig item in InConfig.RandomConfig)
		{
			FGSLeisureRandomConfig Config = item;
			RandomConfig.Add(new GSLeisureRandomConfig(in Config));
		}
	}
}
