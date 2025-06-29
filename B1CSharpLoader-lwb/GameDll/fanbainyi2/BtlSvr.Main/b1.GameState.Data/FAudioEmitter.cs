using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GameState.Data;

public class FAudioEmitter
{
	public bool bDebug { get; set; }

	public bool bDebugLog { get; set; }

	public bool bFollowPlayerElevation { get; set; }

	public UAkAudioEvent AkEventEmitter { get; set; }

	public float EmitterHeight { get; set; }

	public FName StateGroup { get; set; }

	public FName StateInside { get; set; }

	public FName StateOutside { get; set; }

	public float OccRefreshInterval { get; set; }

	public float MaxRangeFadeDistance { get; set; }

	public float MinHeightLimit { get; set; }

	public float MaxHeightLimit { get; set; }

	public bool bInsideSplineRange { get; set; }

	public bool bInsideSpline { get; set; }

	public bool bLazy { get; set; }

	public float LazyDistance { get; set; } = 1000f;

	public bool bInitialized { get; set; }

	public UAkComponent AkComponent { get; set; }

	public USplineComponent SplineComponent { get; set; }

	public FVector EmitterLocation { get; set; }
}
