using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDeviceProfileRedirectMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDeviceProfileRedirectMode
{
	CVar,
	DeviceProfile
}
