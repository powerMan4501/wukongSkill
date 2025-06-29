namespace b1;

public class FMovieCallPath
{
	public string NodeClass { get; set; }

	public string ConditionType { get; set; }

	public string Comment { get; set; }

	public override string ToString()
	{
		return "Node:" + NodeClass + "\tCondition:" + ConditionType + "\tNote:" + Comment;
	}
}
