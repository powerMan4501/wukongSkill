using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Finish")]
public class MovieNodeInstance_Finish : MovieNodeInstance
{
	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.OnFlowFinished();
		Finish();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Finish");
	}

	static MovieNodeInstance_Finish()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Finish)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Finish));
	}
}
