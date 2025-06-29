using System.Collections.Generic;
using System.Text;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1.GameState.Data;

public class BGC_AudioData
{
	private TWeakObject<UAkAudioEvent> _enterLevelEvent;

	private TWeakObject<UAkAudioEvent> _exitLevelEvent;

	public UAkAudioEvent EnterLevelEvent
	{
		get
		{
			return _enterLevelEvent.Get();
		}
		set
		{
			_enterLevelEvent.Set(value);
		}
	}

	public FVector EnterLevelEventLocation { get; set; }

	public UAkAudioEvent ExitLevelEvent
	{
		get
		{
			return _exitLevelEvent.Get();
		}
		set
		{
			_exitLevelEvent.Set(value);
		}
	}

	public TWeakObject<UAkComponent> LevelAudioAkComponent { get; set; }

	public bool bShowListener { get; set; }

	public bool bShowMaxAttentionRadius { get; set; }

	public bool bShowObjectDirectionAxis { get; set; }

	public float AxisLength { get; set; }

	public float CurrentIntervalTime { get; set; }

	public float RefreshInterval { get; set; }

	public float DebugDurationTime { get; set; }

	public float ShowDebugRange { get; set; }

	public StringBuilder Builder { get; } = new StringBuilder();

	public Dictionary<string, FAudioEmitter> AudioEmitters { get; } = new Dictionary<string, FAudioEmitter>();
}
