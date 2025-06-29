using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameModeDataCompStartUp")]
public class BGG_GameModeDataCompStartUp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameModeDataCompStartUp");
	}

	static BGG_GameModeDataCompStartUp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameModeDataCompStartUp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameModeDataCompStartUp));
	}
}
