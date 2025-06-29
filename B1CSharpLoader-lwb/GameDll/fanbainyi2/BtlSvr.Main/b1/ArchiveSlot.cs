using ArchiveB1;
using CommB1;

namespace b1;

public class ArchiveSlot
{
	public readonly int ArchiveId = -1;

	private bool _IsInUse;

	private ArchiveInfo _ArchiveFileInfo;

	private ArchiveSummaryData _SummaryData;

	public bool IsInUse => _IsInUse;

	public bool IsEmpty => !_IsInUse;

	public ArchiveInfo ArchiveFileInfoClone
	{
		get
		{
			if (_ArchiveFileInfo != null)
			{
				return _ArchiveFileInfo.Clone();
			}
			return null;
		}
	}

	public ArchiveSummaryData SummaryData => _SummaryData;

	public ArchiveSlot(int ArchiveId)
	{
		this.ArchiveId = ArchiveId;
	}

	public void Reset()
	{
		_ArchiveFileInfo = null;
		_SummaryData = null;
		_IsInUse = false;
	}

	public void CacheArchiveFileInfo(ArchiveInfo ArchiveFileInfo)
	{
		_ArchiveFileInfo = ArchiveFileInfo.Clone();
	}

	public void CacheSummaryData(ArchiveSummaryData SummaryData)
	{
		_SummaryData = SummaryData.Clone();
	}

	public void MarkInUse(bool IsInUse)
	{
		_IsInUse = IsInUse;
	}
}
