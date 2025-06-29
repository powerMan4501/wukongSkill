namespace System.Diagnostics;

public class InstanceData
{
	private string instanceName;

	private CounterSample sample;

	public string InstanceName => instanceName;

	public CounterSample Sample => sample;

	public long RawValue => sample.RawValue;

	public InstanceData(string instanceName, CounterSample sample)
	{
		this.instanceName = instanceName;
		this.sample = sample;
	}
}
