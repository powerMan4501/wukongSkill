using System;
using System.Text.RegularExpressions;
using UnrealEngine.Runtime;
using UnrealEngine.UMGEditor;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_EndCreditsPage")]
public class BUI_EndCreditsPage : BUI_EndCreditsItem
{
	private const string Pattern = "_C_\\d+$";

	private static readonly Regex EndRegex;

	private static bool PageAction_IsValid;

	private static int PageAction_Offset;

	private static FFieldAddress PageAction_PropertyAddress;

	private static bool ScrollSpeed_IsValid;

	private static int ScrollSpeed_Offset;

	private static bool ScrollEndOffset_IsValid;

	private static int ScrollEndOffset_Offset;

	[DisplayName("行为")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsPage:PageAction")]
	public EEndCreditsPageAction PageAction
	{
		get
		{
			CheckDestroyed();
			if (!PageAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:PageAction");
				return EEndCreditsPageAction.Anim;
			}
			return EnumMarshaler<EEndCreditsPageAction>.FromNative(IntPtr.Add(base.Address, PageAction_Offset), 0, PageAction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PageAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:PageAction");
			}
			else
			{
				EnumMarshaler<EEndCreditsPageAction>.ToNative(IntPtr.Add(base.Address, PageAction_Offset), 0, PageAction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("速度")]
	[UMeta(MDProp.EditCondition, "PageAction == EndCreditsPageAction::AnimAndScroll || PageAction == EndCreditsPageAction::SwitchSpeedScroll")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsPage:ScrollSpeed")]
	public float ScrollSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:ScrollSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:ScrollSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollSpeed_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "PageAction == EndCreditsPageAction::ScrollAnimEnd")]
	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[DisplayName("停止位置(与顶部距离)")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsPage:ScrollEndOffset")]
	public float ScrollEndOffset
	{
		get
		{
			CheckDestroyed();
			if (!ScrollEndOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:ScrollEndOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollEndOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollEndOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsPage:ScrollEndOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollEndOffset_Offset), value);
			}
		}
	}

	public override EndCreditsData ExportData()
	{
		string text = EndRegex.Replace(GetName(), string.Empty);
		FName assetLongPackageName = UBGUFunctionLibrary.GetAssetLongPackageName(UClass.GetClass(typeof(UWidgetBlueprint)).GetFName(), text);
		string inPagePath = $"{assetLongPackageName}.{text}_C";
		EndCreditsPageData endCreditsPageData = EndCreditsData.CreatePage(text, PageAction, ScrollSpeed, ScrollEndOffset, inPagePath);
		InitChilds(endCreditsPageData);
		return endCreditsPageData;
	}

	static BUI_EndCreditsPage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_EndCreditsPage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_EndCreditsPage));
		EndRegex = new Regex("_C_\\d+$");
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_EndCreditsPage");
		NativeReflection.GetPropertyRef(ref PageAction_PropertyAddress, unrealStruct, "PageAction");
		PageAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PageAction");
		PageAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PageAction", Classes.FEnumProperty);
		ScrollSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollSpeed");
		ScrollSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollSpeed", Classes.FFloatProperty);
		ScrollEndOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollEndOffset");
		ScrollEndOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollEndOffset", Classes.FFloatProperty);
	}
}
