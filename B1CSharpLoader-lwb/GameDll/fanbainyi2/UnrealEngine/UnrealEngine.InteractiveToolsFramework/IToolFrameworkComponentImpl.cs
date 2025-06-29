using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

public sealed class IToolFrameworkComponentImpl : IInterfaceImpl, IToolFrameworkComponent, IInterface
{
	static IToolFrameworkComponentImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IToolFrameworkComponentImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IToolFrameworkComponentImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InteractiveToolsFramework.ToolFrameworkComponent");
	}
}
