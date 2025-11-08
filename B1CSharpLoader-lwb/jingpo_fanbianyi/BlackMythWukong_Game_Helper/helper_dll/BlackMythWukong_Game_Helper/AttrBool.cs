namespace BlackMythWukong_Game_Helper;

public class AttrBool
{
	public bool LockHP { get; set; } = false;

	public bool LockMP { get; set; } = false;

	public bool LockPE { get; set; } = false;

	public bool LockStamina { get; set; } = false;

	public bool LockVigorEnergy { get; set; } = false;

	public bool LockFaBaoEnergy { get; set; } = false;

	public bool LockCD { get; set; } = false;

	public bool LockJDY { get; set; } = false;

	public bool LockSpeed { get; set; } = false;

	public bool LockVariation { get; set; } = false;

	public bool LockPrecise { get; set; } = false;

	public bool LockSpellRebirth { get; set; } = false;

	public int LockKuaiSuXuLi { get; set; } = 0;

	public int LockPreciseType { get; set; } = 0;

	public bool SpellCD_0 { get; set; } = true;

	public bool SpellCD_0_All { get; set; } = true;

	public bool Trans2DaSheng { get; set; } = false;

	public float HpMaxMu { get; set; } = 1f;

	public int InDsModItemID { get; set; } = 2208;

	public int Duration { get; set; } = 60;
}
