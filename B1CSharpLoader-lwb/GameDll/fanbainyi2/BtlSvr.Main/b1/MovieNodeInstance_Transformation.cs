using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Transformation")]
public class MovieNodeInstance_Transformation : MovieNodeInstance
{
	private MovieCustom_Transformation CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_Transformation();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		PlayerTransParam playerTransParam = new PlayerTransParam
		{
			NeedBlend = false,
			SpawnSkillId = 0,
			TargetResId = CustomData.ResId,
			TransSkillId = 0
		};
		BPS_EventCollectionCS.GetLocal(this)?.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.Sequence, playerTransParam);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Transformation");
	}

	static MovieNodeInstance_Transformation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Transformation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Transformation));
	}
}
