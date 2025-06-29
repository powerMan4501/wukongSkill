using UnrealEngine.Runtime;

namespace b1;

public struct FScarDecalBrushInfo
{
	private FVector2D _DrawPosition;

	public int BeginY { get; }

	public int EndY { get; }

	public int XLength { get; }

	public int YLength { get; }

	public FVector2D DrawPosition => _DrawPosition;

	public FScarDecalBrushInfo(int _BeginY, int _EndY, int _XLength)
	{
		BeginY = _BeginY;
		EndY = _EndY;
		XLength = _XLength;
		YLength = EndY - BeginY;
		_DrawPosition = default(FVector2D);
	}

	public void NextRow()
	{
		ref FVector2D drawPosition = ref _DrawPosition;
		float y = drawPosition.Y + 1f;
		drawPosition.Y = y;
		_DrawPosition.Y %= YLength;
		_DrawPosition.Y += BeginY;
	}

	public void NextCol()
	{
		ref FVector2D drawPosition = ref _DrawPosition;
		float x = drawPosition.X + 1f;
		drawPosition.X = x;
		_DrawPosition.X %= XLength;
	}

	public void Reset()
	{
		_DrawPosition.X = 0f;
		_DrawPosition.Y = BeginY;
	}

	public void BeginDraw()
	{
		_DrawPosition.X = 0f;
	}
}
