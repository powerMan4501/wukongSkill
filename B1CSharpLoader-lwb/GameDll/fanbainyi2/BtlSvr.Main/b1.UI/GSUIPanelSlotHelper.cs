using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

public class GSUIPanelSlotHelper
{
	public static void WidgetSlotCopy(UWidget FromWidget, UWidget ToWidget)
	{
		if (FromWidget.Slot.GetType().Name == "UHorizontalBoxSlot")
		{
			UHorizontalBoxSlot fromSlot = FromWidget.Slot as UHorizontalBoxSlot;
			UHorizontalBoxSlot toSlot = ToWidget.Slot as UHorizontalBoxSlot;
			HorizontalBoxSlotCopy(fromSlot, toSlot);
		}
		else if (FromWidget.Slot.GetType().Name == "UVerticalBoxSlot")
		{
			UVerticalBoxSlot fromSlot2 = FromWidget.Slot as UVerticalBoxSlot;
			UVerticalBoxSlot toSlot2 = ToWidget.Slot as UVerticalBoxSlot;
			VerticalBoxSlotCopy(fromSlot2, toSlot2);
		}
		else if (FromWidget.Slot.GetType().Name == "UWrapBoxSlot")
		{
			UWrapBoxSlot fromSlot3 = FromWidget.Slot as UWrapBoxSlot;
			UWrapBoxSlot toSlot3 = ToWidget.Slot as UWrapBoxSlot;
			WrapBoxSlotCopy(fromSlot3, toSlot3);
		}
		else if (FromWidget.Slot.GetType().Name == "UOverlaySlot")
		{
			UOverlaySlot fromSlot4 = FromWidget.Slot as UOverlaySlot;
			UOverlaySlot toSlot4 = ToWidget.Slot as UOverlaySlot;
			OverlaySlotCopy(fromSlot4, toSlot4);
		}
		else if (FromWidget.Slot.GetType().Name == "UCanvasPanelSlot")
		{
			UCanvasPanelSlot fromSlot5 = FromWidget.Slot as UCanvasPanelSlot;
			UCanvasPanelSlot toSlot5 = ToWidget.Slot as UCanvasPanelSlot;
			CanvasPanelSlotCopy(fromSlot5, toSlot5);
		}
		else if (FromWidget.Slot.GetType().Name == "UScaleBoxSlot")
		{
			UScaleBoxSlot fromSlot6 = FromWidget.Slot as UScaleBoxSlot;
			UScaleBoxSlot toSlot6 = ToWidget.Slot as UScaleBoxSlot;
			ScaleBoxSlot(fromSlot6, toSlot6);
		}
		else if (FromWidget.Slot.GetType().Name == "UGridSlot")
		{
			UGridSlot fromSlot7 = FromWidget.Slot as UGridSlot;
			UGridSlot toSlot7 = ToWidget.Slot as UGridSlot;
			GridBoxSlot(fromSlot7, toSlot7);
		}
		else if (FromWidget.Slot.GetType().Name == "UScrollBoxSlot")
		{
			UScrollBoxSlot fromSlot8 = FromWidget.Slot as UScrollBoxSlot;
			UScrollBoxSlot toSlot8 = ToWidget.Slot as UScrollBoxSlot;
			ScrollBoxSlot(fromSlot8, toSlot8);
		}
	}

	public static void OverlaySlotCopy(UOverlaySlot FromSlot, UOverlaySlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void WrapBoxSlotCopy(UWrapBoxSlot FromSlot, UWrapBoxSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetFillEmptySpace(FromSlot.FillEmptySpace);
		ToSlot.SetFillSpanWhenLessThan(FromSlot.FillSpanWhenLessThan);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void HorizontalBoxSlotCopy(UHorizontalBoxSlot FromSlot, UHorizontalBoxSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetSize(FromSlot.Size);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void VerticalBoxSlotCopy(UVerticalBoxSlot FromSlot, UVerticalBoxSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetSize(FromSlot.Size);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void CanvasPanelSlotCopy(UCanvasPanelSlot FromSlot, UCanvasPanelSlot ToSlot)
	{
		ToSlot.SetAlignment(FromSlot.GetAlignment());
		ToSlot.SetAnchors(FromSlot.GetAnchors());
		ToSlot.SetPosition(FromSlot.GetPosition());
		ToSlot.SetSize(FromSlot.GetSize());
		ToSlot.SetZOrder(FromSlot.GetZOrder());
	}

	public static void ScaleBoxSlot(UScaleBoxSlot FromSlot, UScaleBoxSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void GridBoxSlot(UGridSlot FromSlot, UGridSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
		ToSlot.SetLayer(FromSlot.Layer);
	}

	public static void ScrollBoxSlot(UScrollBoxSlot FromSlot, UScrollBoxSlot ToSlot)
	{
		ToSlot.SetPadding(FromSlot.Padding);
		ToSlot.SetHorizontalAlignment(FromSlot.HorizontalAlignment);
		ToSlot.SetVerticalAlignment(FromSlot.VerticalAlignment);
	}

	public static void GridSlotSetRowColumn(UGridSlot TargetSlot, int RowIndex, int ColumnIndex)
	{
		TargetSlot.SetRow(RowIndex);
		TargetSlot.SetColumn(ColumnIndex);
	}

	public static void GridSlotListResetRowColumn(ref List<UWidget> GridWidgetList, int NumPerRow)
	{
		for (int i = 0; i < GridWidgetList.Count; i++)
		{
			int row = (int)Math.Ceiling((double)(i / NumPerRow));
			int column = i % NumPerRow;
			UGridSlot obj = GridWidgetList[i].Slot as UGridSlot;
			obj?.SetRow(row);
			obj?.SetColumn(column);
		}
	}

	public static void SetOverlaySlotToFullScreen(UOverlaySlot OverlaySlot)
	{
		OverlaySlot.SetPadding(new FMargin
		{
			Left = 0f,
			Right = 0f,
			Top = 0f,
			Bottom = 0f
		});
		OverlaySlot.SetHorizontalAlignment(EHorizontalAlignment.HAlign_Fill);
		OverlaySlot.SetVerticalAlignment(EVerticalAlignment.VAlign_Fill);
	}

	public static void SetSlotToFullScreen(UCanvasPanelSlot PanelSlot, int ZOrder = 0)
	{
		FAnchors anchors = default(FAnchors);
		anchors.Minimum = FVector2D.ZeroVector;
		anchors.Maximum = FVector2D.UnitVector;
		PanelSlot.SetAnchors(anchors);
		PanelSlot.SetOffsets(new FMargin
		{
			Left = 0f,
			Right = 0f,
			Top = 0f,
			Bottom = 0f
		});
		PanelSlot.ZOrder = ZOrder;
	}
}
