using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ScrollTips")]
public class BUI_ScrollTips : BUI_Widget
{
	private UWidget RootCon;

	private UImage ImgScrollArrow;

	private UMaterialInstanceDynamic ImgScrollArrowMat;

	private static readonly FName ParamNameScrollState;

	private readonly GSBindProp<EScrollState> ScrollState = new GSBindProp<EScrollState>();

	private static bool ScrollBox_IsValid;

	private static int ScrollBox_Offset;

	[EditAnywhere]
	[UProperty]
	[Category("GSProperty|Config")]
	[Tooltip("ScrollBox")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ScrollTips:ScrollBox")]
	public GSScrollBox ScrollBox
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ScrollTips:ScrollBox");
				return null;
			}
			return UObjectMarshaler<GSScrollBox>.FromNative(IntPtr.Add(base.Address, ScrollBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ScrollTips:ScrollBox");
			}
			else
			{
				UObjectMarshaler<GSScrollBox>.ToNative(IntPtr.Add(base.Address, ScrollBox_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		RootCon = FindChildWidget("RootCon");
		RootCon?.SetRenderOpacity(0f);
		ImgScrollArrow = FindChildWidget("ImgScrollArrow") as UImage;
		ImgScrollArrowMat = ImgScrollArrow?.GetDynamicMaterial();
		if (ScrollBox != null)
		{
			ScrollBox.OnScrollOffsetChanged += ScrollBox_OnScrollOffsetChanged;
			ScrollBox.OnScrollOffsetOfEndChanged += ScrollBox_OnScrollOffsetChanged;
		}
		BindValueToCustom(ScrollState, OnChangeScrollState);
	}

	private void OnChangeScrollState(EChangeReason Reason, EScrollState OldValue, EScrollState NewValue)
	{
		bool flag = true;
		switch (NewValue)
		{
		case EScrollState.Cant:
			flag = false;
			break;
		case EScrollState.Up:
			ImgScrollArrowMat?.SetScalarParameterValue(ParamNameScrollState, 2f);
			break;
		case EScrollState.Down:
			ImgScrollArrowMat?.SetScalarParameterValue(ParamNameScrollState, 1f);
			break;
		case EScrollState.Both:
			ImgScrollArrowMat?.SetScalarParameterValue(ParamNameScrollState, 0f);
			break;
		}
		GSAnimKeyToState("AKBShowHide", flag ? "Show" : "Hide");
		RootCon?.SetVisibility((!flag) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void ScrollBox_OnScrollOffsetChanged(float Offset)
	{
		if (!(ImgScrollArrowMat == null))
		{
			EScrollState scrollState = ScrollBox.GetScrollState();
			ScrollState.SetValue(EChangeReason.InputSet, scrollState);
		}
	}

	static BUI_ScrollTips()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ScrollTips)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ScrollTips));
		ParamNameScrollState = new FName("ScrollState");
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ScrollTips");
		ScrollBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollBox");
		ScrollBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollBox", Classes.FObjectProperty);
	}
}
