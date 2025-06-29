using UnrealEngine.Engine;

namespace b1;

public class BUS_AudioEmitterComp : UActorCompBaseCS
{
	private IBUC_GuidData GuidData { get; set; }

	private BUC_AudioEmitterData AudioEmitterData { get; set; }

	public override void OnAttach()
	{
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		AudioEmitterData = RequireWritableData<BUC_AudioEmitterData>();
	}

	public override void OnBeginPlay()
	{
		base.BGSEventCollection.Evt_RegisterAudioEmitter.Invoke(GuidData.GetFinalGuid(), AudioEmitterData.AudioEmitter);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_UnRegisterAudioEmitter.Invoke(GuidData.GetFinalGuid());
	}
}
