using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSweepCheckCombineInfo
{
	public int TriggerSkillID = -1;

	public List<string> CombinedConfigShapeNotifyIDSet = new List<string>();

	public FUStCheckShape SweepCheckShape;

	public FTransform SharingTransform;

	public bool bTramsformInit;

	public bool bCanHitProjectile;

	[UProperty]
	public UAnimSequenceBase SharingAnimation;

	public bool TryRemoveConfigAndCheckValid(in string NotifyID)
	{
		if (CombinedConfigShapeNotifyIDSet.Contains(NotifyID))
		{
			CombinedConfigShapeNotifyIDSet.Remove(NotifyID);
		}
		return CombinedConfigShapeNotifyIDSet.Count > 0;
	}
}
