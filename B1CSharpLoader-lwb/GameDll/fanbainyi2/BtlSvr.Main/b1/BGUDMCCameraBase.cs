using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDMCCameraBase")]
public class BGUDMCCameraBase : ABGU3rdCameraBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDMCCameraBase");
	}

	static BGUDMCCameraBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDMCCameraBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDMCCameraBase));
	}
}
