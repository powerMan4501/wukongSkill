using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISoundEffectPresetWidgetInterfaceImpl : IInterfaceImpl
{
	static ISoundEffectPresetWidgetInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISoundEffectPresetWidgetInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISoundEffectPresetWidgetInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SoundEffectPresetWidgetInterface");
	}
}
