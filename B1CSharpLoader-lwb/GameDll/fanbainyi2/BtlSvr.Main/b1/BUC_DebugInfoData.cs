using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class BUC_DebugInfoData : IBUC_DebugInfoData
{
	private TStrongObjectPtr<UWidgetComponent> DebugInfoCompPtr { get; } = new TStrongObjectPtr<UWidgetComponent>();

	public UWidgetComponent DebugInfoComp
	{
		get
		{
			return DebugInfoCompPtr.Get();
		}
		set
		{
			DebugInfoCompPtr.Set(value);
		}
	}

	public bool IsDebugWidgetShown()
	{
		return !DebugInfoComp.IsNullOrDestroyed();
	}
}
