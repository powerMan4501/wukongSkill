using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_WidgetComponent")]
public class BUI_WidgetComponent : UObject
{
	private BUI_Widget ParentWidget;

	protected BUI_Widget GetParentWidget()
	{
		return ParentWidget;
	}

	public void Init(BUI_Widget Parent)
	{
		ParentWidget = Parent;
		OnAttach(Parent);
	}

	public void ParentDestruct()
	{
		OnParentDestruct();
	}

	public void DoTick(float DeltaTime, BUI_Widget Parent)
	{
		OnTick(DeltaTime, Parent);
	}

	protected virtual void OnAttach(BUI_Widget Parent)
	{
	}

	protected virtual void OnParentDestruct()
	{
	}

	protected virtual void OnTick(float DeltaTime, BUI_Widget Parent)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_WidgetComponent");
	}

	static BUI_WidgetComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_WidgetComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_WidgetComponent));
	}
}
