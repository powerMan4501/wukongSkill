using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_ClearPlayerStates")]
public class MovieNodeInstance_ClearPlayerStates : MovieNodeInstance
{
	public bool bStopJump { get; set; }

	public override void PostCreate()
	{
		MovieCustom_ClearPlayerStates movieCustom_ClearPlayerStates = new MovieCustom_ClearPlayerStates();
		movieCustom_ClearPlayerStates.MergeFrom(base.Node.NodeData);
		bStopJump = movieCustom_ClearPlayerStates.IsStopJump;
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
				if (bUS_GSEventCollection != null && bStopJump)
				{
					bUS_GSEventCollection.Evt_JumpBreak.Invoke();
				}
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_ClearPlayerStates");
	}

	static MovieNodeInstance_ClearPlayerStates()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_ClearPlayerStates)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_ClearPlayerStates));
	}
}
