using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCacheSceneItem")]
internal class BAID_CheckCacheSceneItem : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(actor);
			if (readOnlyData != null && readOnlyData.HasSceneItemCatch())
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCacheSceneItem");
	}

	static BAID_CheckCacheSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCacheSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCacheSceneItem));
	}
}
