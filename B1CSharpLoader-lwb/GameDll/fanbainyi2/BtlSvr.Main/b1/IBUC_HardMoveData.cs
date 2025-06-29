namespace b1;

public interface IBUC_HardMoveData
{
	bool bEnableHardMove { get; }

	bool bFrozenHardMoving { get; }

	bool bMuddyHardMoving { get; }

	bool bWindyHardMoving { get; }

	bool bSpiderSilkyHardMoving { get; }

	bool IsHardMoving();
}
