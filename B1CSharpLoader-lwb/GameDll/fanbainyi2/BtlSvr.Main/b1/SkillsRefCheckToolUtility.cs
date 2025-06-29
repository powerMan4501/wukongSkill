using System;
using System.Collections.Generic;
using System.IO;
using BtlB1;
using BtlShare;
using UnrealEngine.Blutility;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.SkillsRefCheckToolUtility")]
internal class SkillsRefCheckToolUtility : UEditorUtilityObject
{
	private FileStream fs;

	private StreamWriter sw;

	private Dictionary<int, HashSet<int>> EffectIngore;

	private Dictionary<int, HashSet<int>> BulletIngore;

	private Dictionary<int, HashSet<int>> EffectDelay;

	private Dictionary<int, HashSet<int>> BulletDelay;

	private static bool CheckNotify_IsValid;

	private static IntPtr CheckNotify_FunctionAddress;

	private static int CheckNotify_ParamsSize;

	private static bool CheckNotify_skillID_IsValid;

	private static int CheckNotify_skillID_Offset;

	private static bool CheckNotify_notify_IsValid;

	private static int CheckNotify_notify_Offset;

	private static FFieldAddress CheckNotify_notify_PropertyAddress;

	private static bool CheckMontage_IsValid;

	private static IntPtr CheckMontage_FunctionAddress;

	private static int CheckMontage_ParamsSize;

	private static bool CheckMontage_skillID_IsValid;

	private static int CheckMontage_skillID_Offset;

	private static bool CheckMontage_path_IsValid;

	private static int CheckMontage_path_Offset;

	private static FFieldAddress CheckMontage_path_PropertyAddress;

	private IntPtr CheckMontage_InstanceFunctionAddressInstance;

	private static bool Run_IsValid;

	private static IntPtr Run_FunctionAddress;

	private static int Run_ParamsSize;

	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckMontage")]
	public unsafe void CheckMontage(int skillID, string path)
	{
		CheckDestroyed();
		if (!CheckMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckMontage");
			return;
		}
		if (CheckMontage_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CheckMontage_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CheckMontage");
		}
		byte* value = stackalloc byte[(int)(uint)CheckMontage_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CheckMontage_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CheckMontage_skillID_Offset), skillID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckMontage_path_Offset), path);
		NativeReflection.InvokeFunction(base.Address, CheckMontage_InstanceFunctionAddressInstance, intPtr, CheckMontage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckMontage_path_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckNotify")]
	public void CheckNotify(int skillID, FAnimNotifyEvent notify)
	{
		Dictionary<int, FUStSkillSDesc> allSkillSDesc = BGW_GameDB.GetAllSkillSDesc();
		Dictionary<int, FUStSkillEffectDesc> allSkillEffectDesc = BGW_GameDB.GetAllSkillEffectDesc();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		if (notify.NotifyStateClass != null)
		{
			BANS_GSSpawnBullets bANS_GSSpawnBullets = notify.NotifyStateClass as BANS_GSSpawnBullets;
			BANS_GSSweepCheck bANS_GSSweepCheck = notify.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSpawnBullets != null)
			{
				int bulletID = bANS_GSSpawnBullets.GetBulletID();
				if (!CheckIsInWhiteListDict(bulletID, skillID, BulletIngore))
				{
					if (bulletID / 100 != skillID)
					{
						string text = "Bullet ID is not matched ::\tID: " + bulletID + ((bulletID < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
						text = (CheckIsInWhiteListDict(bulletID, skillID, BulletDelay) ? ("Bullet,Not Matched - Delay," + bulletID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Bullet,Not Matched," + bulletID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
						sw.Write(text);
					}
					if (!allProjectileCommDesc.ContainsKey(bulletID))
					{
						string text2 = "Bullet ID is not existed ::\tID: " + bulletID + ((bulletID < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
						text2 = (CheckIsInWhiteListDict(bulletID, skillID, BulletDelay) ? ("Bullet,Not Existed - Delay," + bulletID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Bullet,Not Existed," + bulletID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
						sw.Write(text2);
					}
				}
			}
			else
			{
				if (!(bANS_GSSweepCheck != null))
				{
					return;
				}
				foreach (int effectID2 in bANS_GSSweepCheck.EffectIDList)
				{
					if (!CheckIsInWhiteListDict(effectID2, skillID, EffectIngore))
					{
						if (effectID2 / 100 != skillID)
						{
							string text3 = "Effect ID is not matched ::\tID: " + effectID2 + ((effectID2 < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
							text3 = (CheckIsInWhiteListDict(effectID2, skillID, EffectDelay) ? ("Effect,Not Matched - Delay," + effectID2 + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Effect,Not Matched," + effectID2 + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
							sw.Write(text3);
						}
						if (!allSkillEffectDesc.ContainsKey(effectID2))
						{
							string text4 = "Effect ID is not existed ::\tID: " + effectID2 + ((effectID2 < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
							text4 = (CheckIsInWhiteListDict(effectID2, skillID, EffectDelay) ? ("Effect,Not Existed - Delay," + effectID2 + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Effect,Not Existed," + effectID2 + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
							sw.Write(text4);
						}
					}
				}
			}
		}
		else
		{
			if (!(notify.Notify != null))
			{
				return;
			}
			BAN_GSTriggerEffect bAN_GSTriggerEffect = notify.Notify as BAN_GSTriggerEffect;
			if (!(bAN_GSTriggerEffect != null))
			{
				return;
			}
			int effectID = bAN_GSTriggerEffect.EffectID;
			if (!CheckIsInWhiteListDict(effectID, skillID, EffectIngore))
			{
				if (effectID / 100 != skillID)
				{
					string text5 = "Effect ID is not matched ::\tID: " + effectID + ((effectID < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
					text5 = (CheckIsInWhiteListDict(effectID, skillID, EffectDelay) ? ("Effect,Not Matched - Delay," + effectID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Effect,Not Matched," + effectID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
					sw.Write(text5);
				}
				if (!allSkillEffectDesc.ContainsKey(effectID))
				{
					string text6 = "Effect ID is not existed ::\tID: " + effectID + ((effectID < 100000) ? "\t" : "") + "\t\tWrong In Skill ID: " + skillID + "\t\tNotify: " + notify.NotifyName.ToString() + "\t\tMontage Path: " + allSkillSDesc[skillID].TemplatePath + "\n";
					text6 = (CheckIsInWhiteListDict(effectID, skillID, EffectDelay) ? ("Effect,Not Existed - Delay," + effectID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n") : ("Effect,Not Existed," + effectID + "," + skillID + "," + notify.NotifyName.ToString() + "," + allSkillSDesc[skillID].TemplatePath + "\n"));
					sw.Write(text6);
				}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.SkillsRefCheckToolUtility:Run")]
	protected override void Run_Implementation()
	{
		BGW_GameDB.Init("B1");
		Dictionary<int, FUStSkillSDesc> allSkillSDesc = BGW_GameDB.GetAllSkillSDesc();
		fs = new FileStream(FPaths.ProjectDir + "\\LogFiles\\CheckLog.csv", FileMode.Create);
		sw = new StreamWriter(fs);
		sw.Write("Ref Type,Error Type, ID, Skill ID, Notify Name, Skill Montage Path\n");
		Dictionary<int, FUStSkillsRefCheckWhiteListDesc> allSkillsRefCheckWhiteListDesc = BGW_GameDB.GetAllSkillsRefCheckWhiteListDesc();
		EffectIngore = new Dictionary<int, HashSet<int>>();
		BulletIngore = new Dictionary<int, HashSet<int>>();
		EffectDelay = new Dictionary<int, HashSet<int>>();
		BulletDelay = new Dictionary<int, HashSet<int>>();
		foreach (FUStSkillsRefCheckWhiteListDesc value in allSkillsRefCheckWhiteListDesc.Values)
		{
			Dictionary<int, HashSet<int>> dictionary = null;
			switch (value.IDType)
			{
			case ESkillsRefIDType.Effect:
				if (value.WhiteListType == ESkillsRefWhiteListType.Ignore)
				{
					dictionary = EffectIngore;
				}
				else if (value.WhiteListType == ESkillsRefWhiteListType.Delay)
				{
					dictionary = EffectDelay;
				}
				break;
			case ESkillsRefIDType.Bullet:
				if (value.WhiteListType == ESkillsRefWhiteListType.Ignore)
				{
					dictionary = BulletIngore;
				}
				else if (value.WhiteListType == ESkillsRefWhiteListType.Delay)
				{
					dictionary = BulletDelay;
				}
				break;
			}
			if (dictionary != null)
			{
				if (!dictionary.ContainsKey(value.WhiteListID))
				{
					dictionary.Add(value.WhiteListID, new HashSet<int> { value.SkillID });
				}
				else
				{
					dictionary[value.WhiteListID].Add(value.SkillID);
				}
			}
		}
		int num = 0;
		foreach (int key in allSkillSDesc.Keys)
		{
			num++;
			CheckMontage(key, allSkillSDesc[key].TemplatePath);
		}
		sw.Flush();
		sw.Close();
		fs.Close();
	}

	private bool CheckIsInWhiteListDict(int WhiteListID, int SkillID, Dictionary<int, HashSet<int>> Dict)
	{
		if (Dict.ContainsKey(WhiteListID))
		{
			return Dict[WhiteListID].Contains(SkillID);
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckNotify")]
	private static void CheckNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.SkillsRefCheckToolUtility skillsRefCheckToolUtility = GCHelper.Find<b1.SkillsRefCheckToolUtility>(obj);
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, CheckNotify_skillID_Offset));
		FAnimNotifyEvent notify = StructAsClassMarshaler<FAnimNotifyEvent>.FromNative(IntPtr.Add(buffer, CheckNotify_notify_Offset));
		skillsRefCheckToolUtility.CheckNotify(skillID, notify);
	}

	[UFunctionInvoker("/Script/b1-Managed.SkillsRefCheckToolUtility:Run")]
	private static void Run__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.SkillsRefCheckToolUtility skillsRefCheckToolUtility = GCHelper.Find<b1.SkillsRefCheckToolUtility>(obj);
		skillsRefCheckToolUtility.Run_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.SkillsRefCheckToolUtility");
		CheckNotify_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckNotify");
		CheckNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckNotify_FunctionAddress);
		CheckNotify_skillID_Offset = NativeReflection.GetPropertyOffset(CheckNotify_FunctionAddress, "skillID");
		CheckNotify_skillID_IsValid = NativeReflection.ValidatePropertyClass(CheckNotify_FunctionAddress, "skillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckNotify_notify_PropertyAddress, CheckNotify_FunctionAddress, "notify");
		CheckNotify_notify_Offset = NativeReflection.GetPropertyOffset(CheckNotify_FunctionAddress, "notify");
		CheckNotify_notify_IsValid = NativeReflection.ValidatePropertyClass(CheckNotify_FunctionAddress, "notify", Classes.FStructProperty);
		CheckNotify_IsValid = CheckNotify_FunctionAddress != IntPtr.Zero && CheckNotify_skillID_IsValid && CheckNotify_notify_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckNotify", CheckNotify_IsValid);
		CheckMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckMontage");
		CheckMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckMontage_FunctionAddress);
		CheckMontage_skillID_Offset = NativeReflection.GetPropertyOffset(CheckMontage_FunctionAddress, "skillID");
		CheckMontage_skillID_IsValid = NativeReflection.ValidatePropertyClass(CheckMontage_FunctionAddress, "skillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckMontage_path_PropertyAddress, CheckMontage_FunctionAddress, "path");
		CheckMontage_path_Offset = NativeReflection.GetPropertyOffset(CheckMontage_FunctionAddress, "path");
		CheckMontage_path_IsValid = NativeReflection.ValidatePropertyClass(CheckMontage_FunctionAddress, "path", Classes.FStrProperty);
		CheckMontage_IsValid = CheckMontage_FunctionAddress != IntPtr.Zero && CheckMontage_skillID_IsValid && CheckMontage_path_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SkillsRefCheckToolUtility:CheckMontage", CheckMontage_IsValid);
		Run_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Run");
		Run_ParamsSize = NativeReflection.GetFunctionParamsSize(Run_FunctionAddress);
		Run_IsValid = Run_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SkillsRefCheckToolUtility:Run", Run_IsValid);
	}

	static SkillsRefCheckToolUtility()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.SkillsRefCheckToolUtility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.SkillsRefCheckToolUtility));
	}
}
