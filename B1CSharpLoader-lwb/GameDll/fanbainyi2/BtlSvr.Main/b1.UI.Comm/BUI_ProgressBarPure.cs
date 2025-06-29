using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ProgressBarPure")]
internal abstract class BUI_ProgressBarPure : BUI_Widget
{
	protected UProgressBar ProgressBarWidget;

	public abstract void OnProgressUpdated(float percent);

	public abstract void ToggleVisibility(bool IsVisible);

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_ProgressBarPure");
	}

	static BUI_ProgressBarPure()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.Comm.BUI_ProgressBarPure)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.Comm.BUI_ProgressBarPure));
	}
}
