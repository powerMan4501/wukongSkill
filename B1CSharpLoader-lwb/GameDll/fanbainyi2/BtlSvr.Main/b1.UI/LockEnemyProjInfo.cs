using b1.UI.Comm;
using UnrealEngine.Runtime;

namespace b1.UI;

public class LockEnemyProjInfo : IProjInfo
{
	public BGUCharacterCS BindedUnit;

	private FName SocketName = B1GlobalFNames.CAMERA_LOCK;

	public LockEnemyProjInfo(BGUCharacterCS InBindedUnit, string InSocketName)
	{
		BindedUnit = InBindedUnit;
		SocketName = (string.IsNullOrEmpty(InSocketName) ? B1GlobalFNames.CAMERA_LOCK : new FName(InSocketName));
	}

	public FVector GetLocation()
	{
		if (BindedUnit != null)
		{
			return BindedUnit.Mesh.GetSocketLocation(SocketName);
		}
		return FVector.ZeroVector;
	}
}
