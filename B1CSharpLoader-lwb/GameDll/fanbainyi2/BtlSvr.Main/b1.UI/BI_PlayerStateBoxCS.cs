using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_PlayerStateBoxCS")]
public class BI_PlayerStateBoxCS : BUI_Widget
{
	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private UHorizontalBox StateBox;

	private UHorizontalBox DebuffCon;

	private UHorizontalBox BuffCon;

	private BI_PlayerStateItemCS SpItemRef;

	private BI_PlayerStateItemCS BuffItemRef;

	private BI_PlayerStateItemCS DebuffItemRef;

	private List<BI_PlayerStateItemCS> SpItemList = new List<BI_PlayerStateItemCS>();

	private List<BI_PlayerStateItemCS> BuffItemList = new List<BI_PlayerStateItemCS>();

	private List<BI_PlayerStateItemCS> DebuffItemList = new List<BI_PlayerStateItemCS>();

	private int WidgetGSID;

	private int TickCount;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		StateBox = FindChildWidget("StateBox") as UHorizontalBox;
		DebuffCon = FindChildWidget("DebuffCon") as UHorizontalBox;
		BuffCon = FindChildWidget("BuffCon") as UHorizontalBox;
		SpItemRef = FindChildWidget("SpBuffIcon") as BI_PlayerStateItemCS;
		SpItemRef.SetVisibility(ESlateVisibility.Collapsed);
		BuffItemRef = FindChildWidget("BuffIcon") as BI_PlayerStateItemCS;
		BuffItemRef.SetVisibility(ESlateVisibility.Collapsed);
		DebuffItemRef = FindChildWidget("DebuffIcon") as BI_PlayerStateItemCS;
		DebuffItemRef.SetVisibility(ESlateVisibility.Collapsed);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		CheckItemList();
		TickCount++;
	}

	private void CheckItemList()
	{
		if (BattleMainInfoData == null || BattleMainInfoData.BuffIconList == null)
		{
			return;
		}
		foreach (int buffIcon in BattleMainInfoData.BuffIconList)
		{
			UpdateItem(buffIcon);
		}
	}

	private void UpdateItem(int ItemID)
	{
		int num = ItemID / 1000;
		List<BI_PlayerStateItemCS> list = null;
		BI_PlayerStateItemCS bI_PlayerStateItemCS = null;
		UUserWidget uUserWidget = null;
		UHorizontalBox uHorizontalBox = StateBox;
		switch (num)
		{
		case 1:
			uUserWidget = BuffItemRef;
			list = BuffItemList;
			uHorizontalBox = BuffCon;
			break;
		case 2:
			uUserWidget = DebuffItemRef;
			list = DebuffItemList;
			uHorizontalBox = DebuffCon;
			break;
		case 3:
			uUserWidget = SpItemRef;
			list = BuffItemList;
			uHorizontalBox = BuffCon;
			break;
		}
		foreach (BI_PlayerStateItemCS item in list)
		{
			if (item.GetItemID() == ItemID)
			{
				return;
			}
			if (item.IsIdle())
			{
				bI_PlayerStateItemCS = item;
			}
		}
		if (bI_PlayerStateItemCS == null && uUserWidget != null)
		{
			bI_PlayerStateItemCS = UGSE_UMGFuncLib.CloneUserWidget(uUserWidget, new FName($"{uUserWidget.GetFName()}_{WidgetGSID}")) as BI_PlayerStateItemCS;
			WidgetGSID++;
			if (bI_PlayerStateItemCS == null)
			{
				return;
			}
			bI_PlayerStateItemCS.Evt_ShowOut = RemoveItem;
			list.Add(bI_PlayerStateItemCS);
		}
		uHorizontalBox.AddChild(bI_PlayerStateItemCS);
		bI_PlayerStateItemCS.UpdateContent(ItemID);
		list.Sort((BI_PlayerStateItemCS X, BI_PlayerStateItemCS Y) => Y.GetItemID().CompareTo(X.GetItemID()));
		foreach (BI_PlayerStateItemCS item2 in list)
		{
			RemoveItem(item2);
			uHorizontalBox.AddChild(item2);
			GSUIPanelSlotHelper.WidgetSlotCopy(uUserWidget, item2);
			if (item2.GetItemID() == ItemID)
			{
				item2.ShowIn(ItemID, TickCount == 0);
			}
			else
			{
				item2.UpdateShowState("Show", IsForce: true);
			}
		}
	}

	private void RemoveItem(BI_PlayerStateItemCS Item)
	{
		StateBox.AddChild(Item);
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_PlayerStateBoxCS");
	}

	static BI_PlayerStateBoxCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_PlayerStateBoxCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_PlayerStateBoxCS));
	}
}
