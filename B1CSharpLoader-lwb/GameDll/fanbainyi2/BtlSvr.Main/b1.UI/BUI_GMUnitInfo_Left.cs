using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Left")]
internal class BUI_GMUnitInfo_Left : BUI_Widget
{
	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	private Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private UVerticalBox InfoBox;

	private const string TARGETNAME_NAME = "TargetName";

	private const string INFOBOX_NAME = "InfoBox";

	private const string INFOCONTENT_1 = "怪物距离";

	private const string INFOCONTENT_2 = "玩家于怪物的角度";

	private const string INFOCONTENT_3 = "目标MMState";

	private const string INFOCONTENT_4 = "目标血量";

	private const string INFOCONTENT_6 = "怪物技能破甲值";

	private const string INFOCONTENT_7 = "目标MoveMode";

	private IBUC_ControllerData ControllerData;

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	private static bool PlayerCharacter_IsValid;

	private static int PlayerCharacter_Offset;

	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Left:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Left:PlayerCharacter")]
	private ABGUCharacter PlayerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:PlayerCharacter");
				return null;
			}
			return UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(base.Address, PlayerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:PlayerCharacter");
			}
			else
			{
				UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(base.Address, PlayerCharacter_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Left:Target")]
	public ABGUCharacter Target
	{
		get
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:Target");
				return null;
			}
			return UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(base.Address, Target_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Left:Target");
			}
			else
			{
				UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(base.Address, Target_Offset), value);
			}
		}
	}

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
			InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
			if (!(InfoBox == null))
			{
				AddInitInfo(InfoBox, "怪物距离");
				AddInitInfo(InfoBox, "玩家于怪物的角度");
				AddInitInfo(InfoBox, "目标MMState");
				AddInitInfo(InfoBox, "目标血量");
				AddInitInfo(InfoBox, "怪物技能破甲值");
				AddInitInfo(InfoBox, "目标MoveMode");
			}
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (!IsVisible() || Target.IsNullOrDestroyed())
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
			UpdateBaseInfo();
		}
	}

	private void AddInitInfo(UVerticalBox infobox, string infoname)
	{
		if (!(infobox == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, InfoTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoName")) as UTextBlock).SetText(FText.FromString(infoname));
			UTextBlock value = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoValue")) as UTextBlock;
			InfoDic.Add(infoname, value);
			infobox.AddChild(uUserWidget);
		}
	}

	private void UpdateBaseInfo()
	{
		if (Target == null || PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			return;
		}
		if (Target != PlayerCharacter)
		{
			InfoDic["怪物距离"].SetText(FText.FromString(Target.GetDistanceTo(PlayerCharacter).ToString()));
			float num = UMathLibrary.NormalizeAxis(UMathLibrary.NormalizeAxis(UMathLibrary.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Target), BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter)).Yaw) - UMathLibrary.NormalizeAxis(BGUFuncLibActorTransformCS.BGUGetActorRotation(Target).Yaw));
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(num.ToString("0.00")));
			InfoDic["怪物技能破甲值"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmor) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmorMax)));
		}
		else
		{
			InfoDic["怪物距离"].SetText(FText.FromString(""));
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(""));
			InfoDic["怪物技能破甲值"].SetText(FText.FromString(""));
		}
		InfoDic["目标血量"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.Hp) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.HpMax)));
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Target);
		if (unPersistentReadOnlyData != null)
		{
			InfoDic["目标MMState"].SetText(FText.FromString(unPersistentReadOnlyData.MotionMatchingState.ToString()));
		}
		BUC_MovementModes unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(Target);
		if (Target == null || Target == PlayerCharacter)
		{
			InfoDic["目标MoveMode"].SetText(FText.FromString("No Target"));
		}
		else if (unPersistentReadOnlyData2 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData2.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				InfoDic["目标MoveMode"].SetText(FText.FromString(array[1]));
			}
			else
			{
				InfoDic["目标MoveMode"].SetText(FText.FromString("No ActiveMover"));
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMUnitInfo_Left");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InfoTemp", Classes.FClassProperty);
		PlayerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerCharacter");
		PlayerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerCharacter", Classes.FObjectProperty);
		Target_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Target");
		Target_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Target", Classes.FObjectProperty);
	}

	static BUI_GMUnitInfo_Left()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMUnitInfo_Left)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMUnitInfo_Left));
	}
}
