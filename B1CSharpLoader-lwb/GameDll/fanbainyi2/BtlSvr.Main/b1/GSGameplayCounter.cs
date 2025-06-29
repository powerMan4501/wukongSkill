namespace b1;

public class GSGameplayCounter
{
	public EGameplayCounterType CounterType { get; set; }

	public float StartValue { get; set; }

	public float TargetValue { get; set; }

	public GSGameplayCounter(EGameplayCounterType InCounterType, float InStartValue, float InTargetValue)
	{
		CounterType = InCounterType;
		StartValue = InStartValue;
		TargetValue = InTargetValue;
	}
}
