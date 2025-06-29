namespace b1.UI;

public struct FBarData
{
	public float Value;

	public float MaxValue;

	public float Percent;

	public FBarData(float InValue, float InMaxValue, float InPercent)
	{
		Value = InValue;
		MaxValue = InMaxValue;
		Percent = InPercent;
	}

	public bool Equals(FBarData obj)
	{
		FBarData fBarData = obj;
		if (Value == fBarData.Value && MaxValue == fBarData.MaxValue)
		{
			return Percent == fBarData.Percent;
		}
		return false;
	}
}
