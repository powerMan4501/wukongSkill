using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCDebug_ModifyMaterialEventOverride
{
	public DBCDebug_ModifyMaterialEventOverrideMode Mode;

	public string DBCDataAssetPath;

	public int ModMatEventIndex;

	public int ParamEventIndex;

	public string ParamNameOverride;

	public float ParamFloatValueOverride;

	public FVector4 ParamVector4ValueOverride;
}
