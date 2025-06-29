using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IInterface_AsyncCompilationImpl : IInterfaceImpl, IInterface_AsyncCompilation, IInterface
{
	static IInterface_AsyncCompilationImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_AsyncCompilationImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_AsyncCompilationImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Interface_AsyncCompilation");
	}
}
