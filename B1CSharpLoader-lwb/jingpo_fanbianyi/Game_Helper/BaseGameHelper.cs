namespace Game_Helper;

public interface BaseGameHelper
{
	bool IsRuning { get; set; }

	void OnInitialize();

	void StartRun();

	void OnTick(float DeltTime, int TickGroup);

	void StopRun();
}
