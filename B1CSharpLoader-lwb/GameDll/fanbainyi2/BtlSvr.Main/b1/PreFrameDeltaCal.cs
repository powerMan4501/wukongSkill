namespace b1;

public class PreFrameDeltaCal
{
	private float SliderFreq;

	private float PreFrameDelta;

	private PreFrameDeltaCal(float InSliderFreq)
	{
		SliderFreq = InSliderFreq;
	}

	public float GetDeltaTime(float InDeltaTime)
	{
		PreFrameDelta = InDeltaTime * SliderFreq + PreFrameDelta;
		return PreFrameDelta;
	}

	public float GetSliderFreq()
	{
		return SliderFreq;
	}

	public void SetSliderFreq(float InSliderFreq)
	{
		SliderFreq = InSliderFreq;
	}

	public static PreFrameDeltaCal Create(float InSliderFreq)
	{
		return new PreFrameDeltaCal(InSliderFreq);
	}
}
