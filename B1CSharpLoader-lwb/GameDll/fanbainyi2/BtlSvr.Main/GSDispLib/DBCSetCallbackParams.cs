namespace GSDispLib;

public struct DBCSetCallbackParams
{
	public BUS_DispLibEventCollection.Del_DBCFXCallback SpawnCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback OverTickCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreEndCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreDestroyCallback;

	private static readonly DBCSetCallbackParams Identity = new DBCSetCallbackParams(null, null, null, null);

	public static readonly DBCSetCallbackParams Default = Identity;

	public DBCSetCallbackParams(BUS_DispLibEventCollection.Del_DBCFXCallback _SpawnCallback, BUS_DispLibEventCollection.Del_DBCFXCallback _OverTickCallback, BUS_DispLibEventCollection.Del_DBCFXCallback _PreEndCallback, BUS_DispLibEventCollection.Del_DBCFXCallback _PreDestroyCallback)
	{
		SpawnCallback = _SpawnCallback;
		OverTickCallback = _OverTickCallback;
		PreEndCallback = _PreEndCallback;
		PreDestroyCallback = _PreDestroyCallback;
	}
}
