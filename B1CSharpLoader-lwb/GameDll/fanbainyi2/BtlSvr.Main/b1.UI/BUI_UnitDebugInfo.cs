using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_UnitDebugInfo")]
internal class BUI_UnitDebugInfo : BUI_Widget
{
	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	private Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private UVerticalBox InfoBox;

	private const string INFOBOX_NAME = "InfoBox";

	private const string INFOCONTENT_0 = "ID";

	private const string INFOCONTENT_1 = "HP";

	private const string INFOCONTENT_2 = "LifeTime";

	private UTextBlock BuffText;

	private const string BUFFTEXT_NAME = "BuffText";

	private string buffstr;

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	private static bool UnitSelf_IsValid;

	private static int UnitSelf_Offset;

	private static bool OnRegistOwner_IsValid;

	private static IntPtr OnRegistOwner_FunctionAddress;

	private static int OnRegistOwner_ParamsSize;

	private static bool OnRegistOwner_UnitActor_IsValid;

	private static int OnRegistOwner_UnitActor_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_UnitDebugInfo:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_UnitDebugInfo:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_UnitDebugInfo:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_UnitDebugInfo:UnitSelf")]
	private BGUCharacterCS UnitSelf
	{
		get
		{
			CheckDestroyed();
			if (!UnitSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_UnitDebugInfo:UnitSelf");
				return null;
			}
			return UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, UnitSelf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_UnitDebugInfo:UnitSelf");
			}
			else
			{
				UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, UnitSelf_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
		BuffText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BuffText")) as UTextBlock;
		if (!(InfoBox == null) && !(BuffText == null))
		{
			AddInitInfo(InfoBox, "ID");
			AddInitInfo(InfoBox, "HP");
			AddInitInfo(InfoBox, "LifeTime");
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (IsVisible())
		{
			UpdateBaseInfo();
			UpdateBuffInfo();
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

	private void UpdateBuffInfo()
	{
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(UnitSelf);
		buffstr = "BuffID [Layer] Time\n";
		if (readOnlyData == null || readOnlyData.BuffInstsDict == null)
		{
			return;
		}
		foreach (BuffInstData allBuffInstDatum in readOnlyData.GetAllBuffInstData())
		{
			int num = (int)allBuffInstDatum.LeftTime;
			buffstr += $"{allBuffInstDatum.BuffID} [{allBuffInstDatum.Layer}] {num}s \n";
		}
		BuffText.SetText(FText.FromString(buffstr));
	}

	private void UpdateBaseInfo()
	{
		if (UnitSelf == null)
		{
			InfoDic["HP"].SetText(FText.FromString(""));
			InfoDic["LifeTime"].SetText(FText.FromString(""));
			return;
		}
		InfoDic["ID"].SetText(FText.FromString(UnitSelf.GetResID().ToString()));
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(UnitSelf);
		if (readOnlyData != null)
		{
			InfoDic["HP"].SetText(FText.FromString(readOnlyData.GetFloatValue(EBGUAttrFloat.Hp) + " / " + readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax)));
		}
		b1.IBUC_SummonBehaviorData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SummonBehaviorData, b1.BUC_SummonBehaviorData>(UnitSelf);
		if (unPersistentReadOnlyData != null)
		{
			InfoDic["LifeTime"].SetText(FText.FromString(unPersistentReadOnlyData.SummonAliveTimer.ToString()));
		}
		else
		{
			InfoDic["LifeTime"].SetText(FText.FromString("None"));
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_UnitDebugInfo:OnRegistOwner")]
	public void OnRegistOwner(BGUCharacterCS UnitActor)
	{
		UnitSelf = UnitActor;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_UnitDebugInfo:OnRegistOwner")]
	private static void OnRegistOwner__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_UnitDebugInfo bUI_UnitDebugInfo = GCHelper.Find<b1.UI.BUI_UnitDebugInfo>(obj);
		BGUCharacterCS unitActor = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, OnRegistOwner_UnitActor_Offset));
		bUI_UnitDebugInfo.OnRegistOwner(unitActor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_UnitDebugInfo");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfoTemp", Classes.FClassProperty);
		UnitSelf_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitSelf");
		UnitSelf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitSelf", Classes.FObjectProperty);
		OnRegistOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRegistOwner");
		OnRegistOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRegistOwner_FunctionAddress);
		OnRegistOwner_UnitActor_Offset = NativeReflection.GetPropertyOffset(OnRegistOwner_FunctionAddress, "UnitActor");
		OnRegistOwner_UnitActor_IsValid = NativeReflection.ValidatePropertyClass(OnRegistOwner_FunctionAddress, "UnitActor", Classes.FObjectProperty);
		OnRegistOwner_IsValid = OnRegistOwner_FunctionAddress != IntPtr.Zero && OnRegistOwner_UnitActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_UnitDebugInfo:OnRegistOwner", OnRegistOwner_IsValid);
	}

	static BUI_UnitDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_UnitDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_UnitDebugInfo));
	}
}
