using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLibRefParam
{
	private static DispLibRefParam sInstance = new DispLibRefParam();

	public uint DBCReturn_uintID;

	public UNiagaraComponent DBCReturn_FirstNC;

	public UFXSystemComponent DBCReturn_FirstFXSC;

	public FName DBCReturn_FirstFXMetaString;

	public List<DispLibDBC_FXSCExternalInfo> DBCReturn_AllFXSC = new List<DispLibDBC_FXSCExternalInfo>();

	public AActor DBCSpawnedActor;

	public static DispLibRefParam Instance => sInstance;

	public DispLibRefParam Set(uint _DBCReturn_intID, AActor _DBCSpawnedActor)
	{
		Clean();
		DBCReturn_uintID = _DBCReturn_intID;
		DBCSpawnedActor = _DBCSpawnedActor;
		return Instance;
	}

	public DispLibRefParam Set(uint _DBCReturn_intID)
	{
		Clean();
		DBCReturn_uintID = _DBCReturn_intID;
		return Instance;
	}

	public DispLibRefParam Set(uint _DBCReturn_intID, UFXSystemComponent _DBCReturn_FirstFXSC)
	{
		Clean();
		DBCReturn_uintID = _DBCReturn_intID;
		DBCReturn_FirstFXSC = _DBCReturn_FirstFXSC;
		DBCReturn_FirstNC = _DBCReturn_FirstFXSC as UNiagaraComponent;
		return Instance;
	}

	public DispLibRefParam Set(uint _DBCReturn_intID, UFXSystemComponent _DBCReturn_FirstFXSC, FName _DBCReturn_FirstFXMetaString)
	{
		Clean();
		DBCReturn_uintID = _DBCReturn_intID;
		DBCReturn_FirstFXSC = _DBCReturn_FirstFXSC;
		DBCReturn_FirstNC = _DBCReturn_FirstFXSC as UNiagaraComponent;
		DBCReturn_FirstFXMetaString = _DBCReturn_FirstFXMetaString;
		return Instance;
	}

	public void Clean()
	{
		DBCReturn_uintID = 0u;
		DBCReturn_FirstNC = null;
		DBCReturn_FirstFXMetaString = default(FName);
		DBCReturn_FirstFXSC = null;
		if (DBCReturn_AllFXSC == null)
		{
			DBCReturn_AllFXSC = new List<DispLibDBC_FXSCExternalInfo>();
		}
		else
		{
			DBCReturn_AllFXSC.Clear();
		}
		DBCSpawnedActor = null;
	}
}
