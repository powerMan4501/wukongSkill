using UnrealEngine.UMG;

namespace b1.UI;

internal class DebugItemAttrPair
{
	public int Row = -1;

	public int Column = -1;

	public b1.UI.AttrSizeInGrid Size;

	public b1.UI.BI_DebugTextInGrid KeyComp;

	private UGridSlot KeyCompSlot;

	public b1.UI.BI_DebugTextInGrid ValueComp;

	private UGridSlot ValueCompSlot;

	public DebugItemAttrPair(b1.UI.BI_DebugTextInGrid KeyComp, b1.UI.BI_DebugTextInGrid ValueComp)
	{
		this.KeyComp = KeyComp;
		this.ValueComp = ValueComp;
		KeyCompSlot = KeyComp.Slot as UGridSlot;
		ValueCompSlot = ValueComp.Slot as UGridSlot;
	}

	public void SetPos(int NewRow, int NewColumn)
	{
		Row = NewRow;
		Column = NewColumn;
		KeyCompSlot.SetRow(NewRow);
		ValueCompSlot.SetRow(NewRow);
		KeyCompSlot.SetColumn(NewColumn);
		KeyCompSlot.SetColumnSpan((Size == b1.UI.AttrSizeInGrid.Two) ? 1 : 2);
		ValueCompSlot.SetColumn((Size != b1.UI.AttrSizeInGrid.Two) ? (NewColumn += 2) : (++NewColumn));
		ValueCompSlot.SetColumnSpan((Size == b1.UI.AttrSizeInGrid.Two) ? 1 : 2);
	}

	private bool IsOddEvenSame(int num1, int num2)
	{
		bool num3 = num1 % 2 != 0;
		bool flag = num2 % 2 != 0;
		return num3 == flag;
	}
}
