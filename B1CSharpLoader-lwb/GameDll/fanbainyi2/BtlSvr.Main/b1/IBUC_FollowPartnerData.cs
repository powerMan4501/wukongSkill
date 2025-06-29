namespace b1;

public interface IBUC_FollowPartnerData
{
	bool IsFollowPartnerUnit { get; }

	bool IsAssociationUnit { get; }

	float PlayerBattleLeisureTime { get; }

	bool CanTickIdleDisp();
}
