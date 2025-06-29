using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerAddBuff")]
public class MovieNodeInstance_PerformerAddBuff : MovieNodeInstance
{
	private MovieCustom_PerformerAddBuff CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerAddBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (CustomData.IsPlayerAsPerformer)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
			{
				AddBuffToCharacter(allPlayerActor);
			}
			return;
		}
		BGUCharacterCS character = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		AddBuffToCharacter(character);
	}

	private void AddBuffToCharacter(BGUCharacterCS Character)
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
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(CustomData.BuffId, Character, Character, CustomData.BuffDuration, EBuffSourceType.CMG);
				}
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerAddBuff");
	}

	static MovieNodeInstance_PerformerAddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerAddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerAddBuff));
	}
}
