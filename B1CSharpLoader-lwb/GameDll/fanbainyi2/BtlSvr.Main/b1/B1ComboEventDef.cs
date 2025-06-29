using UnrealEngine.Runtime;

namespace b1;

public static class B1ComboEventDef
{
	public static readonly FName COMBO_EVENT_ATTACK_LIGHT = new FName("EAttackLight");

	public static readonly FName COMBO_EVENT_ATTACK_LIGHT_RELEASE = new FName("EAttackLightRelease");

	public static readonly FName COMBO_EVENT_ATTACK_HEAVY = new FName("EAttackHeavy");

	public static readonly FName COMBO_EVENT_ATTACK_HEAVY_RELEASE = new FName("EAttackHeavyRelease");

	public static readonly FName COMBO_EVENT_SPECIAL_CHARGE_START = new FName("ESpecialCharge");

	public static readonly FName COMBO_EVENT_SPECIAL_CHARGE_RELEASE = new FName("ESpecialChargeRelease");

	public static readonly FName COMBO_EVENT_COMBO_TIMEOUT = new FName("EComboTimeout");

	public static readonly FName COMBO_EVENT_COMBO_RESTART = new FName("EComboRestart");

	public static readonly FName COMBO_EVENT_CHARGE_END = new FName("EAttackChargeEnd");

	public static readonly FName COMBO_EVENT_CHARGE_TIMEOUT = new FName("EAttackChargeTimeOut");

	public static readonly FName COMBO_EVENT_CHARGE_STAMINAOVER = new FName("EAttackChargeStaminaOver");

	public static readonly FName COMBO_EVENT_PE_LEVELGROWUP = new FName("EAttackPELevelGrowUp");

	public static readonly FName COMBO_EVENT_MOVE_FORWARD = new FName("EMoveForward");

	public static readonly FName COMBO_EVENT_MOVE_FORWARD_RELEASE = new FName("EMoveForwardRelease");

	public static readonly FName COMBO_EVENT_ATTACK_LIGHT_FALLING = new FName("EAttackLightFalling");

	public static readonly FName COMBO_EVENT_ATTACK_HEAVY_FALLING = new FName("EAttackHeavyFalling");
}
