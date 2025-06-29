namespace System.Globalization;

internal struct DaylightTimeStruct
{
	public DateTime Start { get; }

	public DateTime End { get; }

	public TimeSpan Delta { get; }

	public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
	{
		Start = start;
		End = end;
		Delta = delta;
	}
}
