using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public interface IBUC_DispLibDBCCarrierActorBaseData
{
	bool GetInitOver();

	USceneComponent GetEmitterComp();

	FVector GetEmitterStartPos();

	USceneComponent GetTargetComp();

	FVector GetTargetStartPos();
}
