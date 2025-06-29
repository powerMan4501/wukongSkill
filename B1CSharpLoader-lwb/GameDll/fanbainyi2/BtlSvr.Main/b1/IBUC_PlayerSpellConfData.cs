using System.Collections.Generic;
using BtlB1;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_PlayerSpellConfData
{
	SpellType DefaultSpellType { get; }

	List<FUStMagicConfInfo> MagicConfInfo { get; }

	int CurrentTransFormID { get; }
}
