using UnrealEngine.Runtime;

namespace b1.UI.Comm;

public class NumProjInfo : IProjInfo
{
	public FVector Location;

	public NumProjInfo(FVector InLocation)
	{
		Location = InLocation;
	}

	public FVector GetLocation()
	{
		return Location;
	}
}
