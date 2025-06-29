using UnrealEngine.Runtime;

namespace b1;

public class FLoadingColorAlphaTracker
{
	private bool _isOpen;

	private readonly BGWGameInstanceCS _gameInstance;

	public FLoadingColorAlphaTracker(UObject WorldContext)
	{
		_isOpen = false;
		_gameInstance = BGWGameInstanceCS.Get(WorldContext);
	}

	public void Open()
	{
		if (!_isOpen)
		{
			_isOpen = true;
			BGW_UIEventCollection.Get(_gameInstance).Evt_UI_OpenTagUIColorAlpha(B1: false);
		}
	}

	public void Close()
	{
		if (_isOpen)
		{
			_isOpen = false;
			BGW_UIEventCollection.Get(_gameInstance).Evt_UI_OpenTagUIColorAlpha(B1: true);
		}
	}
}
