using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameModeDataCompB1")]
public class BGG_GameModeDataCompB1 : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BGC_GameModeTestData>();
		CreateDataClass<BGC_ActorBeginPlayData>();
		CreateDataClass<BGC_DSDebugData>();
		CreateDataClass<BGC_ServerTamerAuthData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameModeDataCompB1");
	}

	static BGG_GameModeDataCompB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameModeDataCompB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameModeDataCompB1));
	}
}
