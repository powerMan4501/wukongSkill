using UnrealEngine.Runtime;

namespace b1;

public class BUC_NPCConfigInfoData : IBUC_NPCConfigInfoData
{
	private TStrongObjectPtr<BGWDataAsset_NPCAnimInfoConfig> mOverrideAnimConfig = new TStrongObjectPtr<BGWDataAsset_NPCAnimInfoConfig>();

	public int NPCInfoID { get; set; }

	public BGWDataAsset_NPCAnimInfoConfig OverrideAnimConfig
	{
		get
		{
			return mOverrideAnimConfig.Get();
		}
		set
		{
			mOverrideAnimConfig = new TStrongObjectPtr<BGWDataAsset_NPCAnimInfoConfig>(value);
		}
	}
}
