namespace b1;

public interface IBGC_AssociationUnitData
{
	bool GetAssociationUnitConfigIDByGUID(string UnitGUID, out int OutConfigID, out AssoicationUnitInfo OutAUI);
}
