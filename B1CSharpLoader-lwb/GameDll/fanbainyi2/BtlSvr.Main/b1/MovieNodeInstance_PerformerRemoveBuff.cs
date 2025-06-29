using System;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerRemoveBuff")]
public class MovieNodeInstance_PerformerRemoveBuff : MovieNodeInstance
{
	private MovieCustom_PerformerRemoveBuff CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerRemoveBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (CustomData.IsPlayerAsPerformer)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
			{
				RemoveBuffFromCharacter(allPlayerActor);
			}
			return;
		}
		BGUCharacterCS character = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		RemoveBuffFromCharacter(character);
	}

	private void RemoveBuffFromCharacter(BGUCharacterCS Character)
	{
		if (Character == null)
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
		}
		else
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Character);
			if (bUS_GSEventCollection != null)
			{
				for (int i = 0; i < CustomData.BuffLayer; i++)
				{
					bUS_GSEventCollection.Evt_BuffRemove.Invoke(CustomData.BuffId, EBuffEffectTriggerType.None, CustomData.BuffLayer, CustomData.IsTriggerRemoveEffect);
				}
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerRemoveBuff");
	}

	static MovieNodeInstance_PerformerRemoveBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerRemoveBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerRemoveBuff));
	}
}
