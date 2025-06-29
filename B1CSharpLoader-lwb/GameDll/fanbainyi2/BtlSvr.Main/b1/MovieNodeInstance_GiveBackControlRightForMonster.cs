using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_GiveBackControlRightForMonster")]
public class MovieNodeInstance_GiveBackControlRightForMonster : MovieNodeInstance
{
	private MovieCustom_GiveBackControlRightForMonster CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_GiveBackControlRightForMonster();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		BGS_EventCollectionCS.Get(this)?.Evt_GiveBackControlRightForMonster.Invoke(base.ParentInstance, CustomData.MonsterGuid);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_GiveBackControlRightForMonster");
	}

	static MovieNodeInstance_GiveBackControlRightForMonster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_GiveBackControlRightForMonster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_GiveBackControlRightForMonster));
	}
}
