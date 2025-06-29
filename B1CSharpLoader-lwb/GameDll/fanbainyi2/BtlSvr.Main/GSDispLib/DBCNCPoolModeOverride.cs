using UnrealEngine.Plugins.Niagara;

namespace GSDispLib;

public struct DBCNCPoolModeOverride
{
	public bool Override;

	public ENCPoolMethod Mode;

	private static readonly DBCNCPoolModeOverride Identity = new DBCNCPoolModeOverride(_Override: false, ENCPoolMethod.None);

	public static readonly DBCNCPoolModeOverride Default = Identity;

	public DBCNCPoolModeOverride(bool _Override, ENCPoolMethod _Mode)
	{
		Override = _Override;
		Mode = _Mode;
	}
}
