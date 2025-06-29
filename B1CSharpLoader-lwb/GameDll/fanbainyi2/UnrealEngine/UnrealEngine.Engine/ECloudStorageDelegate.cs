using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECloudStorageDelegate", "Engine", UnrealModuleType.Engine)]
public enum ECloudStorageDelegate
{
	CSD_KeyValueReadComplete,
	CSD_KeyValueWriteComplete,
	CSD_ValueChanged,
	CSD_DocumentQueryComplete,
	CSD_DocumentReadComplete,
	CSD_DocumentWriteComplete,
	CSD_DocumentConflictDetected
}
