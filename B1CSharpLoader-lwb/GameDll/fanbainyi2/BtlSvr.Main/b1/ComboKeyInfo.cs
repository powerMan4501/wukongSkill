using System.Collections.Generic;
using BtlShare;

namespace b1;

public class ComboKeyInfo
{
	public EInputActionType InputActionType;

	public bool IsRelease;

	public List<int> GroupIDList;

	public ComboKeyInfo()
	{
	}

	public ComboKeyInfo(EInputActionType _InputActionType, bool _IsRelease)
	{
		InputActionType = _InputActionType;
		IsRelease = _IsRelease;
		GroupIDList = null;
	}

	public ComboKeyInfo(EInputActionType _InputActionType, bool _IsRelease, List<int> _GroupIDList)
	{
		InputActionType = _InputActionType;
		IsRelease = _IsRelease;
		GroupIDList = _GroupIDList;
	}
}
