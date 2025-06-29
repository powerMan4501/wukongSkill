using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EHoudiniPDGImportBGEOResult", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EHoudiniPDGImportBGEOResult
{
	HPIBR_Failed,
	HPIBR_Success,
	HPIBR_PartialSuccess
}
