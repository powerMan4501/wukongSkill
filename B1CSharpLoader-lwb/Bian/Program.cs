using bian;
using CSharpModBase;



namespace Bian
{
    public class BianMod : ICSharpMod
    {
        public string Name => "bian";
        public string Version => "0.1.5";

        public BianMod()
        {

        }

        public void Init()
        {
            // Log.Info($"{Name} Init");
            Manager.RegisterManager();
        }
        public void DeInit()
        {
            Manager.UnregisterManager();
        }
    }
}
