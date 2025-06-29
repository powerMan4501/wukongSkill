using System.Diagnostics;

namespace System.Collections.Generic;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
internal struct CopyPosition
{
	public static CopyPosition Start => default(CopyPosition);

	internal int Row { get; }

	internal int Column { get; }

	private string DebuggerDisplay => $"[{Row}, {Column}]";

	internal CopyPosition(int row, int column)
	{
		Row = row;
		Column = column;
	}
}
