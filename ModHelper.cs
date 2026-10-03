using b1;

namespace PanelActionsMod
{
    /// <summary>
    /// 极简角色辅助：画板只需要「拿到当前玩家角色」。
    /// </summary>
    public static class ModHelper
    {
        /// <summary>获取当前受控的玩家角色；变身期间受控 Pawn 不是玩家类时返回 null。</summary>
        public static BGUPlayerCharacterCS? GetCharacter()
        {
            return ModUtils.GetControlledPawn() as BGUPlayerCharacterCS;
        }
    }
}
