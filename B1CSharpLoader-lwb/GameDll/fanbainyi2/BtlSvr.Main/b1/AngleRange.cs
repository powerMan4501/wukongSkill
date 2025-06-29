namespace b1;

internal class AngleRange
{
	private float Buffer;

	public float MinAngle { get; set; }

	public float MaxAngle { get; set; }

	public AngleRange(float Min, float Max)
	{
		MinAngle = Min;
		MaxAngle = Max;
	}

	public void SetBuffer(float buffer)
	{
		Buffer = buffer;
	}

	public static bool IsInRange(float Angle, b1.AngleRange Range)
	{
		float num = Range.MinAngle - Range.Buffer;
		float num2 = Range.MaxAngle + Range.Buffer;
		if (!(num2 >= num))
		{
			if (!(num <= Angle))
			{
				return Angle <= num2;
			}
			return true;
		}
		if (num <= Angle)
		{
			return Angle <= num2;
		}
		return false;
	}
}
