namespace b1.GSMUI;

public interface IGSMUITickable
{
	bool IsUObjectDestroyed();

	bool IsGSNeedTick();

	void DoGSTick(float DeltaTime);

	void BindTickMgr(GSMUITickMgr _TickMgr);
}
