using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PlayerFreeCameraType")]
public enum EPlayerFreeCameraType : byte
{
	None,
	AutoTrail,
	G4Mode,
	SeqMatch
}
