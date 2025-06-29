using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_MFDirectionData : b1.IBUC_MFDirectionData
{
	public EMagicFieldDirectionUsage MFDirectionUsage { get; set; }

	public EMagicFieldDirectionType MFDirectionType { get; set; }

	public EMagicFieldDirectionTypeDetail MFDirectionTypeDetail { get; set; }

	public FName AnchorPointTag { get; set; }

	public MultiMap<EMagicFieldEffectTriggerEvent, MFDirectionEffectForData> DirectionEffects { get; } = new MultiMap<EMagicFieldEffectTriggerEvent, MFDirectionEffectForData>();

	public USceneComponent AnchorPointComp
	{
		get
		{
			return mAnchorPointComp.Get();
		}
		set
		{
			mAnchorPointComp.Set(value);
		}
	}

	private TStrongObjectPtr<USceneComponent> mAnchorPointComp { get; } = new TStrongObjectPtr<USceneComponent>();
}
