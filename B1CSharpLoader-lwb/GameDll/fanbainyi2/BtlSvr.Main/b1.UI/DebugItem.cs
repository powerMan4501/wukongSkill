using System.Collections.Generic;
using UnrealEngine.UMG;

namespace b1.UI;

internal class DebugItem
{
	public string User;

	public UImage DebugPanelBG;

	public UProgressBar ProgressBar;

	public List<UImage> LampList;

	public URichTextBlock TextTitle;

	public List<URichTextBlock> TextBlockList;

	public UGridPanel AttrPanel;

	public b1.UI.BI_DebugTextInGrid KeyTemplete;

	public b1.UI.BI_DebugTextInGrid ValueTemplete;

	public Dictionary<string, b1.UI.DebugItemAttrPair> AttrDic;

	private b1.UI.AttrDisplayMode Mode;

	public DebugItem(UImage DebugPanelBG, UProgressBar ProgressBar, UImage Lamp_1, UImage Lamp_2, UImage Lamp_3, URichTextBlock TextTitle, URichTextBlock TextBlock1, URichTextBlock TextBlock2, URichTextBlock TextBlock3, URichTextBlock TextBlock4, URichTextBlock TextBlock5, UGridPanel AttrPanel, b1.UI.BI_DebugTextInGrid KeyTemplete, b1.UI.BI_DebugTextInGrid ValueTemplete)
	{
		this.DebugPanelBG = DebugPanelBG;
		this.ProgressBar = ProgressBar;
		LampList = new List<UImage>();
		LampList.Add(Lamp_1);
		LampList.Add(Lamp_2);
		LampList.Add(Lamp_3);
		this.TextTitle = TextTitle;
		this.TextTitle.SetVisibility(ESlateVisibility.Collapsed);
		TextBlockList = new List<URichTextBlock>();
		TextBlockList.Add(TextBlock1);
		TextBlockList.Add(TextBlock2);
		TextBlockList.Add(TextBlock3);
		TextBlockList.Add(TextBlock4);
		TextBlockList.Add(TextBlock5);
		ProgressBar.SetVisibility(ESlateVisibility.Collapsed);
		this.DebugPanelBG.SetVisibility(ESlateVisibility.Collapsed);
		Lamp_1.SetVisibility(ESlateVisibility.Collapsed);
		Lamp_2.SetVisibility(ESlateVisibility.Collapsed);
		Lamp_3.SetVisibility(ESlateVisibility.Collapsed);
		TextBlock1.SetVisibility(ESlateVisibility.Collapsed);
		TextBlock2.SetVisibility(ESlateVisibility.Collapsed);
		TextBlock3.SetVisibility(ESlateVisibility.Collapsed);
		TextBlock4.SetVisibility(ESlateVisibility.Collapsed);
		TextBlock5.SetVisibility(ESlateVisibility.Collapsed);
		this.AttrPanel = AttrPanel;
		this.KeyTemplete = KeyTemplete;
		this.ValueTemplete = ValueTemplete;
		KeyTemplete.SetVisibility(ESlateVisibility.Collapsed);
		ValueTemplete.SetVisibility(ESlateVisibility.Collapsed);
		AttrDic = new Dictionary<string, b1.UI.DebugItemAttrPair>();
	}

	public void SetAttrGridMode(b1.UI.AttrDisplayMode NewMode, bool Force = false)
	{
		if (Mode != NewMode || Force)
		{
			Mode = NewMode;
			RelayoutAttrGrid();
		}
	}

	public void GetBestAttrPostion(b1.UI.AttrSizeInGrid Size, out int Row, out int Column)
	{
		Row = 0;
		Column = 0;
		foreach (KeyValuePair<string, b1.UI.DebugItemAttrPair> item in AttrDic)
		{
			if (Row == item.Value.Row && (Column == item.Value.Column || item.Value.Size == b1.UI.AttrSizeInGrid.Four))
			{
				if (Size == b1.UI.AttrSizeInGrid.Two && Mode == b1.UI.AttrDisplayMode.Double && item.Value.Size == b1.UI.AttrSizeInGrid.Two)
				{
					if (Column == 0)
					{
						Column = 2;
						continue;
					}
					Row++;
					Column = 0;
				}
				else
				{
					Row++;
					Column = 0;
				}
			}
			else if (Size != b1.UI.AttrSizeInGrid.Four || item.Value.Row >= Row)
			{
				break;
			}
		}
	}

	public void RelayoutAttrGrid()
	{
		foreach (KeyValuePair<string, b1.UI.DebugItemAttrPair> item in AttrDic)
		{
			item.Value.Row = -1;
			item.Value.Column = -1;
		}
		foreach (KeyValuePair<string, b1.UI.DebugItemAttrPair> item2 in AttrDic)
		{
			GetBestAttrPostion(item2.Value.Size, out var Row, out var Column);
			item2.Value.SetPos(Row, Column);
		}
	}
}
