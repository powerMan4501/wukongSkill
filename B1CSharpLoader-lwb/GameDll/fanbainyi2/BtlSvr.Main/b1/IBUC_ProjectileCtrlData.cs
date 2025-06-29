using System.Collections.Generic;

namespace b1;

public interface IBUC_ProjectileCtrlData
{
	List<BGUProjectileBaseActor> ProjectileList { get; }

	int GetAllCtrableProjectilesByID(int ProjectileID, out List<BGUProjectileBaseActor> OutProjectileList);
}
