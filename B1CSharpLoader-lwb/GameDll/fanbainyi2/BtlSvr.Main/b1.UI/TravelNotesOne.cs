using UnrealEngine.Runtime;

namespace b1.UI;

public struct TravelNotesOne
{
	public ETravelNotesTabType Type;

	public int ID;

	public FText TextName;

	public FText TextSubName;

	public TravelNotesOne(ETravelNotesTabType _Type, int _ID, FText _TextName, FText _TextSubName)
	{
		ID = _ID;
		Type = _Type;
		TextName = _TextName;
		TextSubName = _TextSubName;
	}
}
