namespace b1;

public class CheckIsPlayerReadySaveResult
{
	public bool GamePlayerReady;

	public string Message;

	public void Reset()
	{
		GamePlayerReady = true;
		Message = string.Empty;
	}
}
