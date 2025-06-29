using ArchiveB1;
using CommB1;

namespace b1;

public class GSArchiveFileContainer
{
	public ArchiveFile GameArchiveFile;

	public ShareArchiveFile ShareArchiveFile;

	public ReadArchiveResult ReadShareArchiveResult = ReadArchiveResult.Unknown;

	public ArchiveSummaryData ArchiveSummaryDataForUpdate;
}
