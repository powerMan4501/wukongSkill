using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

public class ProcBarSizeHelper
{
	private readonly float DefSize;

	private readonly float MaxSize;

	private readonly float DefValue;

	private readonly float MaxValue;

	public ProcBarSizeHelper(float InDefSize, float InMaxSize, float InDefValue, float InMaxValue)
	{
		DefSize = InDefSize;
		MaxSize = InMaxSize;
		DefValue = InDefValue;
		MaxValue = InMaxValue;
	}

	public float GetFinalSize(float CurValue)
	{
		if (CurValue <= DefValue || DefValue == MaxValue)
		{
			float num = DefSize / DefValue;
			return CurValue * num;
		}
		float num2 = (MaxSize - DefSize) / (MaxValue - DefValue);
		float val = DefSize + (CurValue - DefValue) * num2;
		return FMath.Min(val, MaxSize);
	}
}
