namespace b1;

public interface IFromLeftNodeEdge
{
	FCalliopeEdge Edge { get; }

	bool bFromFailedPin { get; }

	FBehaviorLeftNodeInstance FromNodeInstance { get; }

	int IsInputSuccess();
}
