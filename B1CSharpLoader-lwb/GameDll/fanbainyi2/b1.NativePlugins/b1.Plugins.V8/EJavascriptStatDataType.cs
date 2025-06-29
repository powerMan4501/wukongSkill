using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UEnum]
[UMetaPath("/Script/V8.EJavascriptStatDataType", "V8", UnrealModuleType.GamePlugin)]
public enum EJavascriptStatDataType
{
	Invalid,
	ST_None,
	ST_int64,
	ST_double,
	ST_FName,
	ST_Ptr
}
