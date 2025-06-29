using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGSInputModeChangeReason")]
public enum EGSInputModeChangeReason : byte
{
	Unknown,
	Init,
	UI,
	GM,
	MiniGM,
	ReportBug,
	ExceptionPanel,
	DataValidate,
	WXLogin,
	BP_GMActor_GMPanel,
	BP_GMActor_ZBBPanel,
	BP_GMActor_OCEAN,
	Reset,
	PreLoadMap,
	Replay,
	LoadingScreenPreview
}
