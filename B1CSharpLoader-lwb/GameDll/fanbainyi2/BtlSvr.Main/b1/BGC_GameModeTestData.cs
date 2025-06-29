namespace b1;

public class BGC_GameModeTestData : IBGC_GameModeTestData
{
	public int TestID { get; set; }

	public BindListInt TestIDList { get; set; }

	public BindDictEPropType_UInt TestPropIDDict { get; set; }

	public BindListFRepInnerClass TestInnerClassList { get; set; }
}
