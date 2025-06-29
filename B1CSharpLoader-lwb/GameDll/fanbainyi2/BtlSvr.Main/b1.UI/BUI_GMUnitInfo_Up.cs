using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Up")]
internal class BUI_GMUnitInfo_Up : BUI_Widget
{
	private UTextBlock SimpleState;

	private UTextBlock UnitState;

	private const string SIMPLESTATE_NAME = "SimpleState";

	private const string UNITSTATE_NAME = "UnitState";

	private UTextBlock CurFSMState;

	private const string CURFSMSTATE_NAME = "CurFSMState";

	private ABGUCharacter PlayerCharacter;

	private IBUC_ControllerData ControllerData;

	private ABGUCharacter Target;

	private BUC_SimpleStateData SimpStateData;

	private BUC_UnitStateData UnitStateData;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
		PlayerCharacter = controlledPawn as ABGUCharacter;
		if (!(controlledPawn == null) && !(PlayerCharacter == null))
		{
			ControllerData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ControllerData, BUC_ControllerData>(PlayerCharacter);
			SimpleState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SimpleState")) as UTextBlock;
			UnitState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitState")) as UTextBlock;
			CurFSMState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CurFSMState")) as UTextBlock;
			if (!(SimpleState == null) && !(UnitState == null))
			{
				_ = CurFSMState == null;
			}
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (!IsVisible())
		{
			return;
		}
		if (PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			if (firstLocalPlayerController == null)
			{
				return;
			}
			AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
			PlayerCharacter = controlledPawn as ABGUCharacter;
			ControllerData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ControllerData, BUC_ControllerData>(PlayerCharacter);
		}
		if (!(PlayerCharacter == null) && !PlayerCharacter.IsPendingKill)
		{
			UpdateFSMInfo();
			UpdateStateInfo();
		}
	}

	private void UpdateFSMInfo()
	{
		CurFSMState.SetText(FText.FromString("TODO Show Wukong GCFSM State"));
	}

	private void UpdateStateInfo()
	{
		string text = "";
		string text2 = "";
		SimpStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Target);
		string text3 = SimpStateData.GetString();
		string text4 = "SimpleStateList:";
		string text5 = text3.Substring(text4.Length, text3.Length - text4.Length);
		for (int i = 0; i < text5.Length; i++)
		{
			text = ((text5[i] == ',') ? (text + "\n") : (text + text5[i]));
		}
		SimpleState.SetText(FText.FromString(text));
		UnitStateData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Target);
		string text6 = UnitStateData.GetString();
		string text7 = "UnitStateData:";
		string text8 = text6.Substring(text7.Length, text6.Length - text7.Length);
		for (int j = 0; j < text8.Length; j++)
		{
			text2 = ((text8[j] == ',') ? (text2 + "\n") : (text2 + text8[j]));
		}
		UnitState.SetText(FText.FromString(text2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMUnitInfo_Up");
	}

	static BUI_GMUnitInfo_Up()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMUnitInfo_Up)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMUnitInfo_Up));
	}
}
