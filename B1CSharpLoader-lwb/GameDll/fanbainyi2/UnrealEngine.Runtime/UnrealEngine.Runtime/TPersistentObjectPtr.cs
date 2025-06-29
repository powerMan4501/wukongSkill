namespace UnrealEngine.Runtime;

public struct TPersistentObjectPtr<TObjectID> where TObjectID : struct
{
	public FWeakObjectPtr WeakPtr;

	public int TagAtLastTest;

	public TObjectID ObjectID;
}
