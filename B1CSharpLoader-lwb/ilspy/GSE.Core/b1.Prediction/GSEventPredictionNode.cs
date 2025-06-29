using System.Collections.Generic;

namespace b1.Prediction;

public class GSEventPredictionNode
{
	public GSEventPredictionNode Parent;

	public List<GSEventPredictionNode> Child = new List<GSEventPredictionNode>();

	public int Id;

	public int EventId;

	public GSEventPredictionNode(int Id, int EventId, GSEventPredictionNode Parent)
	{
		this.Id = Id;
		this.EventId = EventId;
		this.Parent = Parent;
	}
}
