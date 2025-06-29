using System.Text;

namespace b1;

public class BlockInputHelper
{
	public readonly GSBindProp<bool> BlockInput = new GSBindProp<bool>();

	private readonly bool[] BlockData = new bool[7];

	private bool GetBlockInput()
	{
		for (int i = 0; i < BlockData.Length; i++)
		{
			if (BlockData[i])
			{
				return true;
			}
		}
		return false;
	}

	public void SetBlockInput(EBlockInputReason Reason, bool Value)
	{
		BlockData[(int)Reason] = Value;
		BlockInput.SetValue(EChangeReason.InnerOp, GetBlockInput());
	}

	public void ResetBlock()
	{
		for (int i = 0; i < BlockData.Length; i++)
		{
			BlockData[i] = false;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("[Reason : ");
		for (int i = 0; i < BlockData.Length; i++)
		{
			if (BlockData[i])
			{
				stringBuilder.Append($"{(EBlockInputReason)i}, ");
			}
		}
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}
}
