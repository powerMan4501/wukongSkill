using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MenuButton")]
public class BUI_MenuButton : BUI_Button
{
	protected readonly GSBindProp<EMenuUIStat> GSParentMenuUIStat = new GSBindProp<EMenuUIStat>();

	protected readonly GSBindProp<bool> GSShowArrow = new GSBindProp<bool>();

	protected BUI_Menu ParentMenu;

	protected UWidget ArrowCon;

	private static bool MenuUIStat_IsValid;

	private static int MenuUIStat_Offset;

	private static FFieldAddress MenuUIStat_PropertyAddress;

	[DisplayName("当前展示状态")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Menu")]
	[USharpPath("/Script/b1-Managed.BUI_MenuButton:MenuUIStat")]
	public EMenuUIStat MenuUIStat
	{
		get
		{
			CheckDestroyed();
			if (!MenuUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MenuButton:MenuUIStat");
				return EMenuUIStat.None;
			}
			return EnumMarshaler<EMenuUIStat>.FromNative(IntPtr.Add(base.Address, MenuUIStat_Offset), 0, MenuUIStat_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!MenuUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MenuButton:MenuUIStat");
			}
			else
			{
				EnumMarshaler<EMenuUIStat>.ToNative(IntPtr.Add(base.Address, MenuUIStat_Offset), 0, MenuUIStat_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		ArrowCon = FindChildWidget("ArrowCon");
		UpdateShowArrowStat();
	}

	protected override void BindStatEvent()
	{
		base.BindStatEvent();
		GSBindProp<EMenuUIStat> gSParentMenuUIStat = GSParentMenuUIStat;
		gSParentMenuUIStat.OnValueChanged = (GSBindProp<EMenuUIStat>.ValueChangedHandler)Delegate.Combine(gSParentMenuUIStat.OnValueChanged, (GSBindProp<EMenuUIStat>.ValueChangedHandler)delegate(EChangeReason Reason, EMenuUIStat OldValue, EMenuUIStat NewValue)
		{
			bool isForce = Reason == EChangeReason.Init;
			UpdateMenuUIStat(isForce);
			MenuUIStat = NewValue;
		});
		GSBindProp<bool> gSShowArrow = GSShowArrow;
		gSShowArrow.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(gSShowArrow.OnValueChanged, (GSBindProp<bool>.ValueChangedHandler)delegate
		{
			UpdateShowArrowStat();
		});
	}

	private void UpdateMenuUIStat(bool IsForce)
	{
		switch (GSParentMenuUIStat.Value)
		{
		case EMenuUIStat.Normal:
			GSAnimKeyToState("GSAKBMenuStateAnim", "Normal", IsForce);
			break;
		case EMenuUIStat.Actived:
			GSAnimKeyToState("GSAKBMenuStateAnim", "Actived", IsForce);
			break;
		}
	}

	private void UpdateShowArrowStat()
	{
		ArrowCon?.SetVisibility((!GSShowArrow.Value) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public virtual void SetParentMenu(BUI_Menu InParent)
	{
		ParentMenu = InParent;
	}

	public virtual void DebugSetBtnState(ButtonUIStat Stat)
	{
		base.GSButtonUIStat = Stat;
		ParentSetBtnState(base.GSButtonUIStat);
	}

	public override void RemoveFromParentBtn()
	{
		base.RemoveFromParentBtn();
		if (ParentMenu != null)
		{
			ParentMenu.RemoveItem(this);
			ParentMenu = null;
		}
	}

	public void SetShowArrow(bool bShow)
	{
		GSShowArrow.SetValue(EChangeReason.ManualSet, bShow);
	}

	public void SetMenuUIStat(EMenuUIStat InStat)
	{
		GSParentMenuUIStat.SetValue(EChangeReason.ManualSet, InStat);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_MenuButton");
		NativeReflection.GetPropertyRef(ref MenuUIStat_PropertyAddress, unrealStruct, "MenuUIStat");
		MenuUIStat_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MenuUIStat");
		MenuUIStat_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MenuUIStat", Classes.FEnumProperty);
	}

	static BUI_MenuButton()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MenuButton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MenuButton));
	}
}
