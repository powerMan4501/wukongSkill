using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_UnitBarCS")]
public class BI_UnitBarCS : BI_HpProgBarCS
{
	private UTextBlock TxtName;

	private BI_SimAbnormalStateAccBoxCS BISimStateBox;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		BISimStateBox = FindChildWidget("BI_SimStateBox") as BI_SimAbnormalStateAccBoxCS;
	}

	public override void BindEvent()
	{
		base.BindEvent();
		if (DataStore is DSHpProgBar dSHpProgBar)
		{
			BindValueToCustom(dSHpProgBar.Name, OnChangeName);
			BindValueToCustom(dSHpProgBar.CharacterActor, OnChangeCharacterActor);
			BISimStateBox?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		if (DataStore is DSLinkAttrProgBar dSLinkAttrProgBar)
		{
			BindValueToCustom(dSLinkAttrProgBar.Name, OnChangeName);
			BISimStateBox?.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public override void Reset()
	{
		base.Reset();
		OnChangeIsShow(EChangeReason.Init, OldValue: false, NewValue: false);
	}

	private void OnChangeCharacterActor(EChangeReason Reason, BGUCharacterCS OldValue, BGUCharacterCS NewValue)
	{
		BISimStateBox?.UpdateUnitInfo(NewValue);
	}

	private void OnChangeName(EChangeReason Reason, FText OldValue, FText NewValue)
	{
		if (NewValue != null)
		{
			TxtName.SetText(NewValue);
		}
	}

	protected override void OnChangeIsShow(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		SetVisibility(ESlateVisibility.HitTestInvisible);
		GSAnimKeyToState("AKBShowHide", NewValue ? "Show" : "Hide", Reason == EChangeReason.Init);
	}

	protected override void OnChangeBarData(EChangeReason Reason, FBarData OldValue, FBarData NewValue)
	{
		base.OnChangeBarData(Reason, OldValue, NewValue);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_UnitBarCS");
	}

	static BI_UnitBarCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_UnitBarCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_UnitBarCS));
	}
}
