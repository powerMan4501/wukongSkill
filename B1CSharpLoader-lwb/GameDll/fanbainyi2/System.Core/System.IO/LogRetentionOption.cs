namespace System.IO;

internal enum LogRetentionOption
{
	SingleFileUnboundedSize = 2,
	SingleFileBoundedSize = 4,
	UnlimitedSequentialFiles = 0,
	LimitedSequentialFiles = 3,
	LimitedCircularFiles = 1
}
