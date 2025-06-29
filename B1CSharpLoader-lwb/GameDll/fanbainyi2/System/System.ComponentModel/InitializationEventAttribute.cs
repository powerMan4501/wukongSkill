namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public sealed class InitializationEventAttribute : Attribute
{
	private string eventName;

	public string EventName => eventName;

	public InitializationEventAttribute(string eventName)
	{
		this.eventName = eventName;
	}
}
