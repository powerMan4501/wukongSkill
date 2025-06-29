using b1;

namespace GSDispLib;

public class BUC_DispLibDBCQueueData : BUC_DispLibDataBase
{
	public UnorderedDict<int, uint> GamePlayDispReqIDToDBCID;

	public int GamePlayDispReqID { get; private set; }

	public int RequestNewGamePlayDispReqID()
	{
		GamePlayDispReqID++;
		if (GamePlayDispReqID <= 0)
		{
			GamePlayDispReqID = 1;
		}
		return GamePlayDispReqID;
	}

	internal void Init()
	{
		base.DataInitOver = false;
		GamePlayDispReqID = 0;
		GamePlayDispReqIDToDBCID = new UnorderedDict<int, uint>();
		base.DataInitOver = true;
	}

	internal void Reset()
	{
		base.DataInitOver = false;
		GamePlayDispReqID = 0;
		GamePlayDispReqIDToDBCID.Clear();
	}
}
