using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerSetHiddenInGame")]
public class MovieNodeInstance_PerformerSetHiddenInGame : MovieNodeInstance
{
	private MovieCustom_PerformerSetHiddenInGame CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerSetHiddenInGame();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
		}
		else
		{
			bGUCharacterCS.SetActorHiddenInGame(CustomData.HiddenInGame);
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerSetHiddenInGame");
	}

	static MovieNodeInstance_PerformerSetHiddenInGame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerSetHiddenInGame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerSetHiddenInGame));
	}
}
