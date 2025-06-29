using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayerLockTarget")]
public class MovieNodeInstance_PlayerLockTarget : MovieNodeInstance
{
	private MovieCustom_PlayerLockTarget CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PlayerLockTarget();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
		{
			PlayerLockTarget(allPlayerActor);
		}
	}

	private void PlayerLockTarget(ACharacter Player)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Player);
		if (bUS_GSEventCollection != null)
		{
			if (CustomData.IsUnlock)
			{
				bUS_GSEventCollection.Evt_ClearCameraLock.Invoke();
			}
			else
			{
				BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(this, CustomData.TargetGuid) as BGUCharacterCS;
				if (bGUCharacterCS == null)
				{
					LogError("未找到Guid为" + CustomData.TargetGuid + "的目标");
				}
				else
				{
					bUS_GSEventCollection.Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(bGUCharacterCS, ETargetSourceType.None));
				}
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PlayerLockTarget");
	}

	static MovieNodeInstance_PlayerLockTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PlayerLockTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PlayerLockTarget));
	}
}
