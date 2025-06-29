using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

public sealed class IClassVariableCreatorImpl : IInterfaceImpl, IClassVariableCreator, IInterface
{
	static IClassVariableCreatorImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IClassVariableCreatorImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IClassVariableCreatorImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AnimGraph.ClassVariableCreator");
	}
}
