using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_RemoveCacheSceneItem")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_RemoveCacheSceneItem")]
internal class BAIT_RemoveCacheSceneItem : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_RemoveCatchedSceneItemAndReset.Invoke();
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_RemoveCacheSceneItem");
	}

	static BAIT_RemoveCacheSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_RemoveCacheSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_RemoveCacheSceneItem));
	}
}
