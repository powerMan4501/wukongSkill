using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PipelineStateMgr")]
public class BGW_PipelineStateMgr : GameInstanceSystemBaseUObj
{
	public override bool bTickEnabled => true;

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UGSE_EngineFuncLib.UploadPSOHttpRequest(10);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PipelineStateMgr");
	}

	static BGW_PipelineStateMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PipelineStateMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PipelineStateMgr));
	}
}
