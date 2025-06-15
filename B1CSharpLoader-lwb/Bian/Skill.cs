using b1;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace bian
{
    public class Skill
    {

        public int HitCount = 0;

        public float PlayTimeRate {  get; set; }
        public int Id { get; set; }
        public bool CanBreak {get; set;}
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AnimPath { get; set; }

        public int[]? Buffers { get; set; }
        public int[]? Buffs { get; set; }  // 兼容老版本
        public int[]? Bullets { get; set; }

        public string? Key { get; set; }

        public int? Step { get; set; }

        public int? StepCount { get; set; }

        public bool IsMimicry { get; set; }

        private string FName;


        public int[] GetAllBuffers() {
            return (Buffers ?? new int[0]).Concat(Buffs ?? new int[0]).ToArray();
        }
        public string KeyText()
        {
            if (Key == null || Key == "")
            {
                return "未配置";
            }
            return Key.Replace("S+", "shift+").Replace("A+", "alt+").Replace("C+", "ctrl+");
        }

        public Skill(){
            IsMimicry = false;
            HitCount = 0;
            CanBreak = true;
            Step = 0;
            Name = "未命名";
            Description = "空";
            StepCount = 0;
            FName = "";
            PlayTimeRate = 1;
        }

        public void SetFName(string fName) { 
            FName = fName;
        }

        public string GetFName()
        {
            return FName;
        }
    }


    public class MockedFGSProjectileSpawnInfo
    {
        public AActor Spawner;

        public EProjectileType ProjectileType;

        public int SkillID;

        public List<int> BuffIDList;

        public int ProjectileID;

        public int TotalNumInAWave;

        public int SelfIndexInAWave;

        public FSpawnBulletSpeed ProjectileFlySpd;

        public FSpawnBulletSpeed ProjectileRotSpd;

        public FSpawnBulletSpeedGroup BulletSpdGroup;

        public FVector SpawnPosition;

        public FRotator BornDir;

        public bool UseSocket_Spawn;

        public FName SpawnPointName;

        public bool UseSocket_Target;

        public FName TargetSocketNameFromNotify;

        public AActor CurTarget;

        public FGSTargetOffsetInfo TargetOffsetInfo;

        public FVector TargetPos;

        public AActor InnerSceneItem;

        public bool AttachToSpawnBase;

        public AActor AttachToSpawnBase_SpawnBaseActor;

        public FName AttachToSpawnBase_SocketName;

        public USceneComponent AttachToSpawnBase_SocketOwnerComp;

        public EAttachmentRule AttachRule_Rot;

        public AActor ModularActor;

        public string ToString(string format) { 
            return $"""
===

""";
        }
    }
}
