using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class BGMVolumeGroupInfo
{
	public FName VolumeGroupName;

	public int VolumePriority;

	public UAkAudioEvent PriorityEvent;

	public BGMVolumeGroupInfo()
	{
		VolumeGroupName = FName.None;
		VolumePriority = 0;
		PriorityEvent = null;
	}

	public BGMVolumeGroupInfo(FName VolumeGroupName, int VolumePriority, UAkAudioEvent PriorityEvent)
	{
		this.VolumeGroupName = VolumeGroupName;
		this.VolumePriority = VolumePriority;
		this.PriorityEvent = PriorityEvent;
	}
}
