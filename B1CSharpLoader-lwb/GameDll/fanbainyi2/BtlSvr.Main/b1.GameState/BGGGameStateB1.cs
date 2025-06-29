using System;
using UnrealEngine.Runtime;

namespace b1.GameState;

[UClass]
[USharpPath("/Script/b1-Managed.BGGGameStateB1")]
public class BGGGameStateB1 : BGGGameStateCS
{
	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.GameEventCollection = initializer.CreateDefaultSubobject<BGS_GSEventCollection>(this, new FName("GameEventCollection"));
		base.BGSDataComp = initializer.CreateDefaultSubobject<BGG_GameStateDataCompB1>(this, B1GlobalFNames.GameStateDataCompB1);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGGGameStateB1");
	}

	static BGGGameStateB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGGGameStateB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGGGameStateB1));
	}
}
