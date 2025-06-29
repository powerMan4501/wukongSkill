namespace System.Diagnostics;

public enum TraceLogRetentionOption
{
	SingleFileUnboundedSize = 2,
	SingleFileBoundedSize = 4,
	UnlimitedSequentialFiles = 0,
	LimitedSequentialFiles = 3,
	LimitedCircularFiles = 1
}
