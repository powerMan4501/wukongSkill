using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_GourdSlotCS")]
public class BI_GourdSlotCS : BUI_Widget
{
	private UWidgetAnimation AnimCosted;

	private int ItemID;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		AnimCosted = FindWidgetAnimation("AnimCosted");
		GSAnimKeyToState("AKBGourdSlotState", "Empty", IsForce: true);
	}

	public void UpdateItemID(int ItemID)
	{
		this.ItemID = ItemID;
		if (ItemID == 0)
		{
			GSAnimKeyToState("AKBGourdSlotState", "Empty");
		}
		else
		{
			GSAnimKeyToState("AKBGourdSlotState", "Full");
		}
	}

	public int GetItemID()
	{
		return ItemID;
	}

	public void PlayAnimCost()
	{
		StopAnimation(AnimCosted);
		PlayWidgetAnimation(AnimCosted);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_GourdSlotCS");
	}

	static BI_GourdSlotCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_GourdSlotCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_GourdSlotCS));
	}
}
