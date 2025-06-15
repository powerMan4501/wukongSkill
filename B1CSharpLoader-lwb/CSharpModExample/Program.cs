using System;
using b1;
using BtlShare;
using CSharpModBase;
using CSharpModBase.Input;
// using HarmonyLib;

namespace CSharpExample
{
    public class MyMod : ICSharpMod
    {
        public string Name => "ModExample";
        public string Version => "0.1.4";

        public MyMod()
        {
            
        }

        public void Init()
        {
            Console.WriteLine($"{Name} Init");
            Utils.RegisterKeyBind(Key.ENTER, () => Console.WriteLine("Enter pressed"));
            Utils.RegisterKeyBind(ModifierKeys.Control, Key.ENTER, FindPlayer);
        }

        public void DeInit()
        {
            Console.WriteLine($"{Name} DeInit");
            // harmony.UnpatchAll();
        }

        private void FindPlayer()
        {
            Console.WriteLine("Ctrl+Enter pressed");
            var player = MyUtils.GetControlledPawn();
            if (player == null)
            {
                Console.WriteLine("Player not found");
            }
            else
            {
                Console.WriteLine($"Player found: {player}");
                float hp = BGUFunctionLibraryCS.GetAttrValue(player, EBGUAttrFloat.Hp);
                float hpMax = BGUFunctionLibraryCS.GetAttrValue(player, EBGUAttrFloat.HpMax);
                Console.WriteLine($"HP: {hp}/{hpMax}");
            }
        }
    }
}
