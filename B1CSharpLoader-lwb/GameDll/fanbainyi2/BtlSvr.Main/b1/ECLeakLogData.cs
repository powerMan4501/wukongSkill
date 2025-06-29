namespace b1;

public class ECLeakLogData : LeakLogData
{
	public string Name;

	public string ECName;

	public string ECType;

	public string Owner;

	public ECLeakLogData(GSEventCollectionBase EC)
	{
		if (EC != null)
		{
			Name = EC.ToString();
			ECName = EC.GetFullName();
			ECType = EC.GetType().ToString();
			Owner = ((EC.GetOwner() != null) ? EC.GetOwner().GetFullName() : "None");
			return;
		}
		if ((object)EC != null)
		{
			Name = EC.ToString();
		}
		else
		{
			Name = "None";
		}
		ECName = "None";
		ECType = "Unkown";
		Owner = "None";
	}
}
