using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Delay")]
public class MovieNodeInstance_Delay : MovieNodeInstance
{
	public override void TriggerInput(string InputPin = "")
	{
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Delay");
	}

	static MovieNodeInstance_Delay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Delay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Delay));
	}
}
