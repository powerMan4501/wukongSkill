using System.Collections;

namespace System.Diagnostics;

internal class ProcessInfo
{
	public ArrayList threadInfoList = new ArrayList();

	public int basePriority;

	public string processName;

	public int processId;

	public int handleCount;

	public long poolPagedBytes;

	public long poolNonpagedBytes;

	public long virtualBytes;

	public long virtualBytesPeak;

	public long workingSetPeak;

	public long workingSet;

	public long pageFileBytesPeak;

	public long pageFileBytes;

	public long privateBytes;

	public int mainModuleId;

	public int sessionId;
}
