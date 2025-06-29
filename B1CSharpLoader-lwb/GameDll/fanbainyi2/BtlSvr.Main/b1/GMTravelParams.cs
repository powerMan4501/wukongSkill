using ArchiveB1;
using CommB1;

namespace b1;

public struct GMTravelParams
{
	public GMTransportTarget FullSnapShotTransportTarget;

	public FUStBEDArchivesData FullSnapShotArchivesData;

	public EGMTravelType GMTravelType { get; set; }

	public int MonsterTeleportId { get; set; }

	public int SeqPreviewId { get; set; }
}
