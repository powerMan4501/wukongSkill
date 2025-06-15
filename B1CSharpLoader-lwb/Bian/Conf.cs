using B1UI.GSUI;
using CSharpModBase;
using System.Collections.Generic;

namespace bian
{

    public class KeyItem
    {
        public string? Key { get; set; }
        public string? Type { get; set; }
        public string? Label { get; set; }

        public string? Name { get; set; }
        public bool AlawaysCanCast { get; set; }

        public object[] Params { get; set; }
        public int? BuffId { get; set; }
        public int? BuffTime { get; set; }

        // BuffId

        public string KeyText()
        {
            if (Key == null || Key == "")
            {
                return "未配置";
            }
            return Key.Replace("S+", "shift+").Replace("A+", "alt+").Replace("C+", "ctrl+");
        }
    }

    public class AfterTransDone
    {
        public List<int>? Buffers { get; set; }
    }

    public class DebugItem
    {
        public List<string> Log { get; set; }
    }

    public class Conf
    {
        public List<KeyItem> KeyMapping { get; set; }
        public AfterTransDone? TransDone { get; set; }

        public DebugItem? Debug { get; set; }


        public bool CanLogDebug(string name)
        {
            return Debug != null && Debug.Log != null && Debug.Log.IndexOf(name) > -1;
        }

    }

    public class GamePadConf
    {
        public Dictionary<string, string> KeyBinding { get; set; }
    }
}
