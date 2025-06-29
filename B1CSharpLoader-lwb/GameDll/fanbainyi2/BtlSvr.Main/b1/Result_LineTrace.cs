using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class Result_LineTrace
{
	public int ReqID;

	public List<FHitResult> HitResults;

	public Result_LineTrace(int _ReqID, List<FHitResult> _HitResults)
	{
		ReqID = _ReqID;
		HitResults = _HitResults;
	}

	public bool bHasResult()
	{
		return HitResults.Count > 0;
	}
}
