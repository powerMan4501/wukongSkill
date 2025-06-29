using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GM_AIRootPanel")]
internal class BUI_GM_AIRootPanel : BUI_Widget
{
	private UTextBlock ExecutingActionText;

	private UTextBlock ExecutableActionText;

	private UTextBlock CharacterNameText;

	private UTextBlock ValidFeatureText;

	private UTextBlock TreeInfoText;

	private UTextBlock SkillInfoText;

	private UTextBlock AllUpdateActionText;

	private UEditableTextBox DebugFeatureEditText;

	private UButton SwitchCharButton;

	private ACharacter CurCharacter;

	private static bool OnSwitchButtonPress_IsValid;

	private static IntPtr OnSwitchButtonPress_FunctionAddress;

	private static int OnSwitchButtonPress_ParamsSize;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CharacterNameText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.CharacterName) as UTextBlock;
		ExecutingActionText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.ExecutingAction) as UTextBlock;
		ExecutableActionText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.ExecutableAction) as UTextBlock;
		ValidFeatureText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.ValidFeature) as UTextBlock;
		DebugFeatureEditText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.DebugFeatureID) as UEditableTextBox;
		SwitchCharButton = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.SwitchChar) as UButton;
		TreeInfoText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TreeInfo) as UTextBlock;
		SkillInfoText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.SkillInfo) as UTextBlock;
		AllUpdateActionText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.UnExeAction) as UTextBlock;
		SwitchCharButton.OnClicked.Bind(OnSwitchButtonPress);
		CurCharacter = UGSE_CameraUtilFuncLib.GetCameraViewTarget(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).PlayerCameraManager) as ACharacter;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_AIRootPanel:OnSwitchButtonPress")]
	private void OnSwitchButtonPress()
	{
		List<ACharacter> list = UGameplayStatics.GetAllActorsOfClass<ACharacter>(this).ToList();
		if (!list.Contains(CurCharacter))
		{
			CurCharacter = UGSE_CameraUtilFuncLib.GetCameraViewTarget(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).PlayerCameraManager) as ACharacter;
		}
		int num = list.IndexOf(CurCharacter);
		num++;
		if (num >= list.Count)
		{
			num = 0;
		}
		CurCharacter = list[num];
	}

	private void DebugAllCharacter()
	{
		ACharacter[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACharacter>(this);
		foreach (ACharacter aCharacter in allActorsOfClass)
		{
			DebugSingle(aCharacter);
		}
	}

	private void DebugSingle(ACharacter Char)
	{
		IBUC_GOAPData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(Char);
		foreach (ActionProcessBase actionProcess in readOnlyData.GetActionProcessList())
		{
			NormalMoveAction normalMoveAction = actionProcess as NormalMoveAction;
			_ = actionProcess is NormalSkillCastAction;
			if (normalMoveAction != null)
			{
				USystemLibrary.DrawDebugArrow(Char, BGUFuncLibActorTransformCS.BGUGetActorLocation(Char), normalMoveAction.TargetLoc, 100f, FLinearColor.Pink);
			}
		}
		foreach (TStrongObjectPtr<AFSkillArea> skillAreaFeature in readOnlyData.GetSkillAreaFeatureList())
		{
			AFSkillArea aFSkillArea = skillAreaFeature.Get();
			UBGUFunctionLibraryForCS.BGUDrawDebugRect(Char.World, aFSkillArea.BaseLoc + new FVector(1.0, 0.0, 0.0).RotateAngleAxis(aFSkillArea.RectParam.RotateAngle + aFSkillArea.RectParam.Yaw, FVector.UpVector) * aFSkillArea.RectParam.Height / 2.0, new FVector(1.0, 0.0, 0.0).RotateAngleAxis(aFSkillArea.RectParam.RotateAngle + aFSkillArea.RectParam.Yaw, FVector.UpVector), aFSkillArea.RectParam.Width, aFSkillArea.RectParam.Height);
			UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Char.World, aFSkillArea.BaseLoc, aFSkillArea.RoundParam.Radius);
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		DebugAllCharacter();
		CharacterNameText.SetText(FText.FromString(CurCharacter.GetName()));
		IBUC_GOAPData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(CurCharacter);
		string text = "可执行行为ID：";
		string text2 = "执行中行为ID：";
		string text3 = "Valid特征ID：";
		string text4 = "SkillInfo:\n";
		string text5 = "AllUpdateAction:\n";
		string str = "TreeInfo:\n";
		List<AIActionElem> executableActionElemList = readOnlyData.GetExecutableActionElemList();
		List<AIActionElem> executingActionElemList = readOnlyData.GetExecutingActionElemList();
		List<AIFeatureElem> validFeatureElemList = readOnlyData.GetValidFeatureElemList();
		List<AIElement> allRootElemList = readOnlyData.GetAllRootElemList();
		List<AISkillInfo> validSkillInfoList = readOnlyData.GetValidSkillInfoList();
		List<AIActionElem> allUpdateActionList = readOnlyData.GetAllUpdateActionList();
		foreach (AIActionElem item in executableActionElemList)
		{
			text = text + item.ActionID + "\n";
		}
		foreach (AIActionElem item2 in executingActionElemList)
		{
			text2 = text2 + item2.ActionID + "\n";
		}
		foreach (AIFeatureElem item3 in validFeatureElemList)
		{
			text3 = text3 + item3.FeatureID + "\n";
		}
		foreach (AISkillInfo item4 in validSkillInfoList)
		{
			text4 = text4 + item4.SkillID + "\n";
		}
		foreach (AIActionElem item5 in allUpdateActionList)
		{
			text5 = text5 + item5.ActionID + " " + item5.State.ToString() + "\n";
		}
		foreach (AIElement item6 in allRootElemList)
		{
			_ = item6;
		}
		ExecutingActionText.SetText(FText.FromString(text2));
		ExecutableActionText.SetText(FText.FromString(text));
		ValidFeatureText.SetText(FText.FromString(text3));
		TreeInfoText.SetText(FText.FromString(str));
		SkillInfoText.SetText(FText.FromString(text4));
		AllUpdateActionText.SetText(FText.FromString(text5));
		if (!int.TryParse(DebugFeatureEditText.GetText(), out var result))
		{
			return;
		}
		foreach (AIFeatureElem item7 in validFeatureElemList)
		{
			if (item7.FeatureID == result)
			{
				DebugFeatureElem(item7);
				break;
			}
		}
	}

	private void DebugFeatureElem(AIFeatureElem FeatureElem)
	{
		foreach (AIDataBase data in FeatureElem.OutputData.DataList)
		{
			FVector location = data.GetLocation();
			USystemLibrary.DrawDebugPoint(this, location, 8f, FLinearColor.Purple);
		}
	}

	private string DebugTree(AIElement Elem, int PreStrLen, bool IsFirst)
	{
		string text = "";
		if (!IsFirst)
		{
			for (int i = 0; i < PreStrLen; i++)
			{
				text += " ";
			}
		}
		text += "-";
		AIFeatureElem aIFeatureElem = Elem as AIFeatureElem;
		AIActionElem aIActionElem = Elem as AIActionElem;
		AIThinkElem aIThinkElem = Elem as AIThinkElem;
		List<string> list = new List<string>();
		if (aIFeatureElem != null)
		{
			text = text + "F" + aIFeatureElem.FeatureID + aIFeatureElem.State;
		}
		if (aIActionElem != null)
		{
			text = text + "A" + aIActionElem.ActionID + aIActionElem.State;
		}
		if (aIThinkElem != null)
		{
			text = text + "T" + aIThinkElem.ThinkID + "Cur:" + Elem2IDStr(aIThinkElem.CurElem);
		}
		for (int j = 0; j < Elem.ChildElems.Count; j++)
		{
			list.Add(DebugTree(Elem.ChildElems[j], PreStrLen + text.Length, j == 0));
		}
		for (int k = 0; k < list.Count; k++)
		{
			text = ((k != 0) ? (text + "\n" + list[k]) : (text + list[0]));
		}
		return text;
	}

	private string Elem2IDStr(AIElement Elem)
	{
		AIFeatureElem aIFeatureElem = Elem as AIFeatureElem;
		AIActionElem aIActionElem = Elem as AIActionElem;
		AIThinkElem aIThinkElem = Elem as AIThinkElem;
		if (aIFeatureElem != null)
		{
			return "F" + aIFeatureElem.FeatureID;
		}
		if (aIActionElem != null)
		{
			return "A" + aIActionElem.ActionID;
		}
		if (aIThinkElem != null)
		{
			return "T" + aIThinkElem.ThinkID;
		}
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_AIRootPanel:OnSwitchButtonPress")]
	private static void OnSwitchButtonPress__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GM_AIRootPanel bUI_GM_AIRootPanel = GCHelper.Find<b1.UI.BUI_GM_AIRootPanel>(obj);
		bUI_GM_AIRootPanel.OnSwitchButtonPress();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GM_AIRootPanel");
		OnSwitchButtonPress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSwitchButtonPress");
		OnSwitchButtonPress_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSwitchButtonPress_FunctionAddress);
		OnSwitchButtonPress_IsValid = OnSwitchButtonPress_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_AIRootPanel:OnSwitchButtonPress", OnSwitchButtonPress_IsValid);
	}

	static BUI_GM_AIRootPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GM_AIRootPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GM_AIRootPanel));
	}
}
