using System;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IDetailCustomizationForCsInterfaceImpl : IInterfaceImpl, IDetailCustomizationForCsInterface, IInterface
{
	static IDetailCustomizationForCsInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IDetailCustomizationForCsInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IDetailCustomizationForCsInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.DetailCustomizationForCsInterface");
	}
}
