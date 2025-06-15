using System.Collections.Generic;

namespace bian
{

    public class WeaponConfig {
        public string Weapon { get; set; }
        public string SocketName { get; set; }
    }

    public class TFXConfig
    {
        public string TFXAsset { get; set; }
        public bool EnableSimulation { get; set; }
        public float LodScreenSize { get; set; }

        public MockFTressFXShadeSettings ShadeSettings { get; set; }

        public string HairMaterial { get; set; }

        public override string ToString()
        {
            return $"TFXConfig[{TFXAsset}|{EnableSimulation}|{LodScreenSize}|{HairMaterial}|{ShadeSettings}]";
        }
    }

    public class MockedInteractBone {
        public int WeaponIndex { get; set; }
        public string FirstBoneName { get; set; }
        public float FirstRadius { get; set; }
        public string NextBoneName { get; set; }
        public float NextRadius { get; set; }

        public override string ToString() {
            return $"InteractBone[{FirstBoneName}|{FirstRadius}|{NextBoneName}|{NextRadius}]";
        }
    }

    public class MockFTressFXShadeSettings {
        public float FiberRadius { get; set; }
        public float FiberSpacing { get; set; }
        public float HairThickness { get; set; }
        public float RootTangentBlending { get; set; }
        public float ShadowThickness { get; set; }

        public override string ToString()
        {
            return $"FTressFXShadeSettings[{FiberRadius}|{FiberSpacing}|{HairThickness}|{RootTangentBlending}|{ShadowThickness}]";
        }
    }

    public class BossConfig
    {
        public float CapsuleHalfHeight { set; get; }
        public float CapsuleRadius { set; get; }

        public string SKMesh { set; get; }

        public string ABPClass { set; get; }

        public string PhysicsAsset { set; get; }

        public List<WeaponConfig> Weapons { set; get; }

        public List<TFXConfig> TFXConfigs { set; get; }

        public List<MockedInteractBone> InteractBones { set; get; }

        public int Override_AbnormalDispID_Attacker { set; get; }

        public int Override_AbnormalDispID_Victim { set; get; }

    }
}
