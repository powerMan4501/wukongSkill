using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class UnitTeamForData
{
	public List<TStrongObjectPtr<BGUCharacterCS>> CharacterList;

	public UnitTeamForData(in FUnitTeam UnitTeam)
	{
		CharacterList = new List<TStrongObjectPtr<BGUCharacterCS>>();
		foreach (BGUCharacterCS character in UnitTeam.CharacterList)
		{
			CharacterList.Add(new TStrongObjectPtr<BGUCharacterCS>(character));
		}
	}
}
