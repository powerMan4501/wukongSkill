using System;
using b1.GSMUI.Core;
using b1.Localization;
using b1.Plugins.GSInput;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutDescCS")]
public class BI_ShortcutDescCS : BUI_Widget
{
	private UImage ImgIcon;

	private UTextBlock TxtName;

	private UTextBlock TxtDesc;

	private UGSInputActionIcon ImgInput;

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private static bool InputAction_IsValid;

	private static int InputAction_Offset;

	private static bool InputIconTexture_IsValid;

	private static int InputIconTexture_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_ShortcutDescCS:InputAction")]
	public UInputAction InputAction
	{
		get
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutDescCS:InputAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, InputAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutDescCS:InputAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, InputAction_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutDescCS:InputIconTexture")]
	public UTexture2D InputIconTexture
	{
		get
		{
			CheckDestroyed();
			if (!InputIconTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutDescCS:InputIconTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, InputIconTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputIconTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutDescCS:InputIconTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, InputIconTexture_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		TxtDesc = FindChildWidget("TxtDesc") as UTextBlock;
		ImgInput = FindChildWidget("InputIconSub") as UGSInputActionIcon;
		UpdateIconType(IsPassive: false, IsForce: true);
	}

	public void UpdateDesc(int BaseID)
	{
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(BaseID);
		if (spellDesc != null)
		{
			UpdateIconType(spellDesc.IsPassive == YesNoType.Yes);
		}
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(BaseID);
		if (itemDesc == null)
		{
			GSAnimKeyToState("AKBItemState", "None", IsForce: true);
			TxtName.SetText(GSMUIUtil.GetUIWordDescFText(EUIWordID.ITEM_TITLE_EMPTY));
			TxtDesc.SetText(FText.GetEmpty());
		}
		else
		{
			GSAnimKeyToState("AKBItemState", "Has", IsForce: true);
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetItemIconGPath(BaseID));
			TxtName.SetText(itemDesc.Name.ToFTextRemoveRich());
			TxtDesc.SetText(itemDesc.EffectDesc.ToFTextRemoveRich());
		}
		if (InputAction != null)
		{
			ImgInput.SetInputAction(InputAction);
		}
	}

	private void UpdateIconType(bool IsPassive = false, bool IsForce = false)
	{
		GSAnimKeyToState("AKBIconType", IsPassive ? "Passive" : "Default", IsForce);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutDescCS");
		InputAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputAction");
		InputAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputAction", Classes.FObjectProperty);
		InputIconTexture_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputIconTexture");
		InputIconTexture_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputIconTexture", Classes.FObjectProperty);
	}

	static BI_ShortcutDescCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutDescCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutDescCS));
	}
}
