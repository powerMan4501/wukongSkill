using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISoundParameterControllerInterfaceImpl : IInterfaceImpl
{
	static ISoundParameterControllerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISoundParameterControllerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISoundParameterControllerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SoundParameterControllerInterface");
	}
}
