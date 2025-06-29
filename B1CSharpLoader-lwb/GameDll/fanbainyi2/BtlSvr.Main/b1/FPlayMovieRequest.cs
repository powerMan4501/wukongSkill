using System;

namespace b1;

public struct FPlayMovieRequest
{
	public int SequenceID { get; set; }

	public bool bDisablePlayerControl { get; set; }

	public bool bDisableMovementInput { get; set; }

	public bool bDisableLookAtInput { get; set; }

	public bool bHidePlayer { get; set; }

	public bool bHideHud { get; set; }

	public string OverlapBoxGuid { get; set; }

	public ESequenceBlendInMatchPositionType MatchType { get; set; }

	public Action BeforePlayFinishCallback { get; set; }

	public Action MovieFinishCallback { get; set; }
}
