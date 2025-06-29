using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.EditorFramework;

public sealed class IAssetEditorContextInterfaceImpl : IInterfaceImpl, IAssetEditorContextInterface, IInterface
{
	static IAssetEditorContextInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAssetEditorContextInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAssetEditorContextInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/EditorFramework.AssetEditorContextInterface");
	}
}
