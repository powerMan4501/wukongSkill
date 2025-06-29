using System;
using System.Collections.Generic;
using System.Reflection;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_DebugComm")]
internal class BUI_DebugComm : BUI_Widget
{
	private List<b1.UI.DebugItem> DebugItemList = new List<b1.UI.DebugItem>();

	private static bool OwnerActor_IsValid;

	private static int OwnerActor_Offset;

	private static bool Destruct_IsValid;

	private static IntPtr Destruct_FunctionAddress;

	private static int Destruct_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_DebugComm:OwnerActor")]
	private AActor OwnerActor
	{
		get
		{
			CheckDestroyed();
			if (!OwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugComm:OwnerActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, OwnerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugComm:OwnerActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, OwnerActor_Offset), value);
			}
		}
	}

	protected override void OnUIInitialized()
	{
		DebugItemList.Add(new b1.UI.DebugItem(FindChildWidget("bg") as UImage, FindChildWidget("ProgBar") as UProgressBar, FindChildWidget("Lamp") as UImage, FindChildWidget("Lamp_1") as UImage, FindChildWidget("Lamp_2") as UImage, FindChildWidget("TxtTitle") as URichTextBlock, FindChildWidget("TxtTemp") as URichTextBlock, FindChildWidget("TxtTemp_1") as URichTextBlock, FindChildWidget("TxtTemp_2") as URichTextBlock, FindChildWidget("TxtTemp_3") as URichTextBlock, FindChildWidget("TxtTemp_4") as URichTextBlock, FindChildWidget("AttrPanel") as UGridPanel, FindChildWidget("KeyTemplete") as b1.UI.BI_DebugTextInGrid, FindChildWidget("ValueTemplete") as b1.UI.BI_DebugTextInGrid));
		DebugItemList.Add(new b1.UI.DebugItem(FindChildWidget("bg_1") as UImage, FindChildWidget("ProgBar_1") as UProgressBar, FindChildWidget("Lamp_3") as UImage, FindChildWidget("Lamp_4") as UImage, FindChildWidget("Lamp_5") as UImage, FindChildWidget("TxtTitle_1") as URichTextBlock, FindChildWidget("TxtTemp_5") as URichTextBlock, FindChildWidget("TxtTemp_6") as URichTextBlock, FindChildWidget("TxtTemp_7") as URichTextBlock, FindChildWidget("TxtTemp_8") as URichTextBlock, FindChildWidget("TxtTemp_9") as URichTextBlock, FindChildWidget("AttrPanel_1") as UGridPanel, FindChildWidget("KeyTemplete") as b1.UI.BI_DebugTextInGrid, FindChildWidget("ValueTemplete") as b1.UI.BI_DebugTextInGrid));
		DebugItemList.Add(new b1.UI.DebugItem(FindChildWidget("bg_2") as UImage, FindChildWidget("ProgBar_2") as UProgressBar, FindChildWidget("Lamp_6") as UImage, FindChildWidget("Lamp_7") as UImage, FindChildWidget("Lamp_8") as UImage, FindChildWidget("TxtTitle_2") as URichTextBlock, FindChildWidget("TxtTemp_10") as URichTextBlock, FindChildWidget("TxtTemp_11") as URichTextBlock, FindChildWidget("TxtTemp_12") as URichTextBlock, FindChildWidget("TxtTemp_13") as URichTextBlock, FindChildWidget("TxtTemp_14") as URichTextBlock, FindChildWidget("AttrPanel_2") as UGridPanel, FindChildWidget("KeyTemplete") as b1.UI.BI_DebugTextInGrid, FindChildWidget("ValueTemplete") as b1.UI.BI_DebugTextInGrid));
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
	}

	public void InitValue(AActor OwnerActor)
	{
		this.OwnerActor = OwnerActor;
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIInfo += new Del_UpdateDebugUIInfo(OnUpdateDebugUIInfo);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_HideDebugUIInfo += new Del_HideDebugUIInfo(OnHideDebugUIInfo);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUILamp += new Del_UpdateDebugUILamp(OnUpdateDebugUILamp);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIProg += new Del_UpdateDebugUIProg(OnUpdateDebugUIProg);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUILog += new Del_UpdateDebugUILog(OnUpdateDebugUILog);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIKeyValuePair += new Del_UpdateDebugUIKeyValuePair(OnUpdateDebugKeyValuePair);
		BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUITitle += new Del_UpdateDebugUILog(OnUpdateDebugUITitle);
	}

	[USharpPath("/Script/b1-Managed.BUI_DebugComm:Destruct")]
	protected override void Destruct_Implementation()
	{
		base.Destruct_Implementation();
		if (!OwnerActor.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIInfo -= new Del_UpdateDebugUIInfo(OnUpdateDebugUIInfo);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_HideDebugUIInfo -= new Del_HideDebugUIInfo(OnHideDebugUIInfo);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUILamp -= new Del_UpdateDebugUILamp(OnUpdateDebugUILamp);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIProg -= new Del_UpdateDebugUIProg(OnUpdateDebugUIProg);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUILog -= new Del_UpdateDebugUILog(OnUpdateDebugUILog);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUIKeyValuePair -= new Del_UpdateDebugUIKeyValuePair(OnUpdateDebugKeyValuePair);
			BUS_EventCollectionCS.Get(OwnerActor).Evt_UpdateDebugUITitle -= new Del_UpdateDebugUILog(OnUpdateDebugUITitle);
		}
	}

	private void OnUpdateDebugKeyValuePair(string Name, string Key, string Value)
	{
		if (!CheckTagActive(Name))
		{
			return;
		}
		b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
		if (debugItemByUserName == null)
		{
			return;
		}
		if (debugItemByUserName.AttrDic.TryGetValue(Key, out var value))
		{
			value.KeyComp.SetText(Key);
			value.ValueComp.SetText(Value);
			if (value.Size == b1.UI.AttrSizeInGrid.Two && JudgeIsLongAttr(Key, Value))
			{
				value.Size = b1.UI.AttrSizeInGrid.Four;
				debugItemByUserName.SetAttrGridMode(b1.UI.AttrDisplayMode.Double, Force: true);
			}
			return;
		}
		b1.UI.DebugItemAttrPair debugItemAttrPair = new b1.UI.DebugItemAttrPair(CloneItem(debugItemByUserName.KeyTemplete, default(FName), debugItemByUserName.AttrPanel) as b1.UI.BI_DebugTextInGrid, CloneItem(debugItemByUserName.ValueTemplete, default(FName), debugItemByUserName.AttrPanel) as b1.UI.BI_DebugTextInGrid);
		bool flag = JudgeIsLongAttr(Key, Value);
		if (flag)
		{
			debugItemAttrPair.Size = b1.UI.AttrSizeInGrid.Four;
		}
		debugItemAttrPair.KeyComp.SetText(Key);
		debugItemAttrPair.ValueComp.SetText(Value);
		debugItemByUserName.AttrDic.Add(Key, debugItemAttrPair);
		debugItemByUserName.GetBestAttrPostion(debugItemAttrPair.Size, out var Row, out var Column);
		debugItemAttrPair.SetPos(Row, Column);
		if (debugItemByUserName.AttrDic.Count == 6 || flag)
		{
			debugItemByUserName.SetAttrGridMode(b1.UI.AttrDisplayMode.Double);
		}
	}

	public bool JudgeIsLongAttr(string Key, string Value)
	{
		if (GetStringLengthWithoutTags(Key) > 14 || GetStringLengthWithoutTags(Value) > 14)
		{
			return true;
		}
		return false;
	}

	private int GetStringLengthWithoutTags(string str)
	{
		bool flag = false;
		int num = 0;
		for (int i = 0; i < str.Length; i++)
		{
			switch (str[i])
			{
			case '<':
				flag = true;
				continue;
			case '>':
				flag = false;
				continue;
			}
			if (!flag)
			{
				num++;
			}
		}
		return num;
	}

	private void OnUpdateDebugUIInfo(string Name, string Value, int Column, float ResetTime)
	{
		if (CheckTagActive(Name))
		{
			b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
			if (debugItemByUserName != null && Column < debugItemByUserName.TextBlockList.Count)
			{
				debugItemByUserName.TextBlockList[Column].SetVisibility(ESlateVisibility.HitTestInvisible);
				debugItemByUserName.TextBlockList[Column].SetText(FText.FromString(Value));
			}
		}
	}

	private void OnHideDebugUIInfo(string Name, int Column)
	{
		if (CheckTagActive(Name))
		{
			b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
			if (debugItemByUserName != null && Column < debugItemByUserName.TextBlockList.Count)
			{
				debugItemByUserName.TextBlockList[Column].SetVisibility(ESlateVisibility.Hidden);
			}
		}
	}

	private void OnUpdateDebugUILamp(string Name, FSlateColor Color, int Column, float ResetTime)
	{
		if (CheckTagActive(Name))
		{
			b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
			if (debugItemByUserName != null && Column < debugItemByUserName.LampList.Count)
			{
				debugItemByUserName.LampList[Column].SetVisibility(ESlateVisibility.HitTestInvisible);
				debugItemByUserName.LampList[Column].SetBrushTintColor(Color);
			}
		}
	}

	private void OnUpdateDebugUIProg(string Name, float Value, float ResetTime)
	{
		if (CheckTagActive(Name))
		{
			b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
			if (debugItemByUserName != null)
			{
				debugItemByUserName.ProgressBar.SetVisibility(ESlateVisibility.HitTestInvisible);
				debugItemByUserName.ProgressBar.SetPercent(Value);
			}
		}
	}

	private void OnUpdateDebugUITitle(string Name, string Value)
	{
		if (CheckTagActive(Name))
		{
			b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
			debugItemByUserName.TextTitle.SetText(FText.FromString(Value));
			debugItemByUserName.TextTitle.SetVisibility(ESlateVisibility.HitTestInvisible);
		}
	}

	private void OnUpdateDebugUILog(string Name, string Value)
	{
		if (!CheckTagActive(Name))
		{
			return;
		}
		b1.UI.DebugItem debugItemByUserName = GetDebugItemByUserName(Name);
		string text = Value;
		for (int num = debugItemByUserName.TextBlockList.Count - 1; num >= 0; num--)
		{
			string text2 = debugItemByUserName.TextBlockList[num].GetText();
			debugItemByUserName.TextBlockList[num].SetText(FText.FromString(text));
			if (text.Length != 0)
			{
				debugItemByUserName.TextBlockList[num].SetVisibility(ESlateVisibility.HitTestInvisible);
			}
			text = text2;
		}
	}

	private b1.UI.DebugItem GetDebugItemByUserName(string UserName)
	{
		foreach (b1.UI.DebugItem debugItem in DebugItemList)
		{
			debugItem.DebugPanelBG.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			if (debugItem.User == null)
			{
				debugItem.User = UserName;
				return debugItem;
			}
			if (debugItem.User.Equals(UserName))
			{
				return debugItem;
			}
		}
		return null;
	}

	private bool CheckTagActive(string Tag)
	{
		PropertyInfo[] properties = typeof(DebugConfig).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.Name.Equals(Tag, StringComparison.OrdinalIgnoreCase))
			{
				return (bool)propertyInfo.GetValue(propertyInfo);
			}
		}
		return false;
	}

	private UUserWidget CloneItem(UUserWidget RefWidget, FName Name, UPanelWidget ParentNode = null)
	{
		if (RefWidget == null)
		{
			throw new Exception("RefWidget Is Null Name:" + Name.ToString());
		}
		UUserWidget uUserWidget = null;
		uUserWidget = UGSE_UMGFuncLib.CloneUserWidget(RefWidget, Name);
		uUserWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		if (ParentNode == null)
		{
			RefWidget.GetParent().AddChild(uUserWidget);
		}
		else
		{
			ParentNode.AddChild(uUserWidget);
		}
		GSUIPanelSlotHelper.WidgetSlotCopy(RefWidget, uUserWidget);
		return uUserWidget;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DebugComm:Destruct")]
	private static void Destruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_DebugComm bUI_DebugComm = GCHelper.Find<b1.UI.BUI_DebugComm>(obj);
		bUI_DebugComm.Destruct_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_DebugComm");
		OwnerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwnerActor");
		OwnerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwnerActor", Classes.FObjectProperty);
		Destruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Destruct");
		Destruct_ParamsSize = NativeReflection.GetFunctionParamsSize(Destruct_FunctionAddress);
		Destruct_IsValid = Destruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DebugComm:Destruct", Destruct_IsValid);
	}

	static BUI_DebugComm()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_DebugComm)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_DebugComm));
	}
}
