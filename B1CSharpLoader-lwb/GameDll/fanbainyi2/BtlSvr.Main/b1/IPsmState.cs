namespace b1;

public interface IPsmState
{
	void OnEnterAction();

	void OnExitAction();

	void OnTickAction(float InDeltaTime);

	void OnResetAction();

	void OnRecoverAction();

	void Shutdown();
}
