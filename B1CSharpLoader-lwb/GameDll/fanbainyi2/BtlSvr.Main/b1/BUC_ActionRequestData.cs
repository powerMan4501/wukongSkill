namespace b1;

public class BUC_ActionRequestData : IBUC_ActionRequestData
{
	private int LastMoveReqIdx;

	private int LastSkillReqIdx;

	private int LastSkillID;

	private int IndexGenerator;

	public BUC_ActionRequestData()
	{
		LastMoveReqIdx = 0;
		LastSkillReqIdx = 0;
		LastSkillID = 0;
		IndexGenerator = 0;
	}

	private int RequestIndex()
	{
		if (IndexGenerator < 0)
		{
			IndexGenerator = 0;
		}
		IndexGenerator++;
		return IndexGenerator;
	}

	public int RequestMoveIdx()
	{
		LastMoveReqIdx = RequestIndex();
		return LastMoveReqIdx;
	}

	public void ReleaseMoveIdx()
	{
		LastMoveReqIdx = 0;
	}

	public int GetLastMoveIdx()
	{
		return LastMoveReqIdx;
	}

	public int RequestSkillIdx(int SkillID)
	{
		LastSkillID = SkillID;
		LastSkillReqIdx = RequestIndex();
		return LastSkillReqIdx;
	}

	public int GetLastSkillIdx()
	{
		return LastSkillReqIdx;
	}

	public int GetLastSkillID()
	{
		return LastSkillID;
	}
}
