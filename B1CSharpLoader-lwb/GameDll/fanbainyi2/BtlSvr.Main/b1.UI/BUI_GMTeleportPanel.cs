using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMTeleportPanel")]
internal class BUI_GMTeleportPanel : BUI_Widget
{
	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMTeleportPanel");
	}

	static BUI_GMTeleportPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMTeleportPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMTeleportPanel));
	}
}
