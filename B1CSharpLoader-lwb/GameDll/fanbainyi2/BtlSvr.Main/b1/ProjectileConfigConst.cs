using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public static class ProjectileConfigConst
{
	public static Dictionary<Type_CheckCompProfileName_Bullet, FName> TypeMap_CheckCompProfileName_Bullet;

	public static Dictionary<Type_CheckCompProfileName_MagicField, FName> TypeMap_CheckCompProfileName_MagicField;

	static ProjectileConfigConst()
	{
		TypeMap_CheckCompProfileName_Bullet = new Dictionary<Type_CheckCompProfileName_Bullet, FName>();
		TypeMap_CheckCompProfileName_MagicField = new Dictionary<Type_CheckCompProfileName_MagicField, FName>();
		TypeMap_CheckCompProfileName_Bullet.Add(Type_CheckCompProfileName_Bullet.NormalBullet, B1GlobalFNames.NormalBullet);
		TypeMap_CheckCompProfileName_MagicField.Add(Type_CheckCompProfileName_MagicField.NormalMagicField, B1GlobalFNames.NormalMagicField);
		TypeMap_CheckCompProfileName_MagicField.Add(Type_CheckCompProfileName_MagicField.JustCheckPhysicsBody, B1GlobalFNames.MagicField_CheckBody);
	}
}
