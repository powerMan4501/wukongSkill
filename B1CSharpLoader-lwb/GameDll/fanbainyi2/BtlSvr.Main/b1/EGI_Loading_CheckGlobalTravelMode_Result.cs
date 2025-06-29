using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGI_Loading_CheckGlobalTravelMode_Result")]
public enum EGI_Loading_CheckGlobalTravelMode_Result : byte
{
	MainMenu,
	StandAlone,
	ListenServer,
	Client
}
