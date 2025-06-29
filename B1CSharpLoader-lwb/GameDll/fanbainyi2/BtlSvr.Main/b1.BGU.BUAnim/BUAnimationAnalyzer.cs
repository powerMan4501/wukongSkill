using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer")]
public class BUAnimationAnalyzer : UAnimationAnalyzer, ICallbackValidator
{
	private Dictionary<string, int> AnimSoftPathRefMap = new Dictionary<string, int>();

	private bool bAnimSoftPathRefMapInit;

	private Dictionary<FSoftObjectPath, bool> AnimSoftPathHasRequiredMap = new Dictionary<FSoftObjectPath, bool>();

	private static bool GenerateNewAACSAsset_IsValid;

	private static IntPtr GenerateNewAACSAsset_FunctionAddress;

	private static int GenerateNewAACSAsset_ParamsSize;

	private static bool GenerateNewAACSAsset_OrgAA_IsValid;

	private static int GenerateNewAACSAsset_OrgAA_Offset;

	private static bool GenerateNewAACSAsset_ReturnValue_IsValid;

	private static int GenerateNewAACSAsset_ReturnValue_Offset;

	private static bool FindABPSettingSameToAA_IsValid;

	private static IntPtr FindABPSettingSameToAA_FunctionAddress;

	private static int FindABPSettingSameToAA_ParamsSize;

	private static bool FindABPSettingSameToAA_ABP_Setting_IsValid;

	private static int FindABPSettingSameToAA_ABP_Setting_Offset;

	private static bool FindABPSettingSameToAA_OrgAAPackageName_IsValid;

	private static int FindABPSettingSameToAA_OrgAAPackageName_Offset;

	private static FFieldAddress FindABPSettingSameToAA_OrgAAPackageName_PropertyAddress;

	private static bool FindABPSettingSameToAA_ReturnValue_IsValid;

	private static int FindABPSettingSameToAA_ReturnValue_Offset;

	private static FFieldAddress FindABPSettingSameToAA_ReturnValue_PropertyAddress;

	private static bool AddToABPSettingSameToAA_IsValid;

	private static IntPtr AddToABPSettingSameToAA_FunctionAddress;

	private static int AddToABPSettingSameToAA_ParamsSize;

	private static bool AddToABPSettingSameToAA_ABP_Setting_IsValid;

	private static int AddToABPSettingSameToAA_ABP_Setting_Offset;

	private static bool AddToABPSettingSameToAA_OrgAAPackageName_IsValid;

	private static int AddToABPSettingSameToAA_OrgAAPackageName_Offset;

	private static FFieldAddress AddToABPSettingSameToAA_OrgAAPackageName_PropertyAddress;

	private static bool AddToABPSettingSameToAA_ReturnValue_IsValid;

	private static int AddToABPSettingSameToAA_ReturnValue_Offset;

	private static FFieldAddress AddToABPSettingSameToAA_ReturnValue_PropertyAddress;

	private static bool MMAnimationSeqUsingNotify_Inner_IsValid;

	private static IntPtr MMAnimationSeqUsingNotify_Inner_FunctionAddress;

	private static int MMAnimationSeqUsingNotify_Inner_ParamsSize;

	private static bool MMAnimationSeqUsingNotify_Inner_Ref_IsValid;

	private static int MMAnimationSeqUsingNotify_Inner_Ref_Offset;

	private static bool MMAnimationSeqUsingNotify_Inner_Owner_IsValid;

	private static int MMAnimationSeqUsingNotify_Inner_Owner_Offset;

	private static bool CheckIsFirstLoadRequireDesireAsset_IsValid;

	private static IntPtr CheckIsFirstLoadRequireDesireAsset_FunctionAddress;

	private static int CheckIsFirstLoadRequireDesireAsset_ParamsSize;

	private static bool CheckIsFirstLoadRequireDesireAsset_Ref_IsValid;

	private static int CheckIsFirstLoadRequireDesireAsset_Ref_Offset;

	private static bool CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid;

	private static int CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset;

	private static FFieldAddress CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress;

	private static bool RequireAnimationsLoadAtDesiredReferences_IsValid;

	private static IntPtr RequireAnimationsLoadAtDesiredReferences_FunctionAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_ParamsSize;

	private static bool RequireAnimationsLoadAtDesiredReferences_Ref_IsValid;

	private static int RequireAnimationsLoadAtDesiredReferences_Ref_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid;

	private static int RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset;

	private static FFieldAddress RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress;

	private static bool RequireAnimationsLoadAtDesiredReferences_obj_IsValid;

	private static int RequireAnimationsLoadAtDesiredReferences_obj_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid;

	private static int RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:GenerateNewAACSAsset")]
	private static BUAnimationAnalyzer GenerateNewAACSAsset(UAnimationAnalyzer OrgAA)
	{
		UClass uClass = UClass.GetClass<BUAnimationAnalyzer>();
		string pathName = OrgAA.GetOutermost().GetPathName();
		string text = pathName.Substring(pathName.LastIndexOf('/') + 1);
		string text2 = text.Substring(text.IndexOf('_') + 1);
		string path = pathName.Substring(0, pathName.LastIndexOf('/') + 1);
		string name = "AAcs_" + text2;
		BUAnimationAnalyzer bUAnimationAnalyzer = UGSE_EngineFuncLib.CreateAsset(path, name, uClass) as BUAnimationAnalyzer;
		bUAnimationAnalyzer.TryInitFromAA(OrgAA);
		UGSFuncLibForEditor.CheckoutAndSavePackage(new List<UPackage> { bUAnimationAnalyzer.GetOutermost() }, bCheckDirty: false, bPromptToSave: false, out var _);
		return bUAnimationAnalyzer;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:AddToABPSettingSameToAA")]
	private bool AddToABPSettingSameToAA(BGWDataAsset_AbpHumanoidSetting ABP_Setting, string OrgAAPackageName)
	{
		bool flag = false;
		foreach (KeyValuePair<EState_MM, UAnimationAnalyzer> item in ABP_Setting.MotionMatchingSetting.MMState2AA)
		{
			if (item.Value.GetOutermost().GetPathName() == OrgAAPackageName)
			{
				EState_MM key = item.Key;
				if (!ABP_Setting.MotionMatchingSetting.MMState2AACS.ContainsKey(key))
				{
					FAnimHumanoidSetting_MotionMatching motionMatchingSetting = ABP_Setting.MotionMatchingSetting;
					motionMatchingSetting.MMState2AACS.Add(key, this);
					ABP_Setting.MotionMatchingSetting = motionMatchingSetting;
					ABP_Setting.MarkPackageDirty();
					flag = true;
				}
				else
				{
					BGW_LogUtil.LogError("ABP_Setting{0} MMState2AACS {1} Already Has AACS!!!!", ABP_Setting.GetOutermost().GetPathName(), key);
				}
			}
		}
		List<UPackage> OutFailedPackages;
		if (flag)
		{
			return UGSFuncLibForEditor.CheckoutAndSavePackage(new List<UPackage> { ABP_Setting.GetOutermost() }, bCheckDirty: false, bPromptToSave: false, out OutFailedPackages);
		}
		BGW_LogUtil.LogError("ABP_Setting{0} Doesnt Using AA {1} !!!!", ABP_Setting.GetOutermost().GetPathName(), OrgAAPackageName);
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:FindABPSettingSameToAA")]
	private bool FindABPSettingSameToAA(BGWDataAsset_AbpHumanoidSetting ABP_Setting, string OrgAAPackageName)
	{
		bool flag = false;
		string text = OrgAAPackageName.Replace("AAcs", "AA");
		foreach (KeyValuePair<EState_MM, UAnimationAnalyzer> item in ABP_Setting.MotionMatchingSetting.MMState2AA)
		{
			if (item.Value.GetOutermost().GetPathName() == text)
			{
				EState_MM key = item.Key;
				if (!ABP_Setting.MotionMatchingSetting.MMState2AACS.ContainsKey(key))
				{
					flag = true;
				}
			}
		}
		if (flag)
		{
			new List<UPackage>().Add(ABP_Setting.GetOutermost());
			BGW_LogUtil.LogError("ABP_Setting{0} Need Changing AACS!!!", ABP_Setting.GetOutermost().GetPathName());
		}
		return false;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.UsingAssetSoftRef = true;
	}

	public void SetSoftPathHasBeenLoading(FSoftObjectPath Path, bool bLoading = true)
	{
		if (!AnimSoftPathHasRequiredMap.TryGetValue(Path, out var _))
		{
			AnimSoftPathHasRequiredMap.Add(Path, value: true);
		}
		else
		{
			AnimSoftPathHasRequiredMap[Path] = bLoading;
		}
	}

	public bool GetSoftPathNeverLoading(FSoftObjectPath Path)
	{
		if (!AnimSoftPathHasRequiredMap.TryGetValue(Path, out var value))
		{
			return true;
		}
		return !value;
	}

	public bool IsValidAcceptCallback()
	{
		return true;
	}

	private void OnAnimationAssetLoadStatChangeCS(int Ref, EAnimSeqAssetLoadStatType Stat, UAnimSequence Anim)
	{
		OnAnimationAssetLoadStatChange(Ref, Stat, Anim);
	}

	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:MMAnimationSeqUsingNotify_Inner")]
	protected override void MMAnimationSeqUsingNotify_Inner_Implementation(int Ref, AActor Owner)
	{
	}

	public void OnAnimationAssetLoadFinished(int _, UObject obj)
	{
		if (!bAnimSoftPathRefMapInit)
		{
			InitAnimSoftPathRefMap();
		}
		UAnimSequence uAnimSequence = obj as UAnimSequence;
		if (uAnimSequence == null)
		{
			BGW_LogUtil.LogError("BUAnimationAnalyzer AnimSeq Load Callback AnimSeq INVALID!!!!!!");
			return;
		}
		string pathName = uAnimSequence.GetPathName();
		if (AnimSoftPathRefMap.TryGetValue(pathName, out var value))
		{
			OnAnimationAssetLoadStatChangeCS(value, EAnimSeqAssetLoadStatType.LOADED, uAnimSequence);
		}
	}

	public void InitAnimSoftPathRefMap()
	{
		if (AnimSoftPathRefMap.Count != 0)
		{
			return;
		}
		bAnimSoftPathRefMapInit = true;
		int num = 0;
		foreach (FMotionMatchingAnimSeqdata animationSeqSoftData in base.AnimationSeqSoftDatas)
		{
			FSoftObjectPath animationSoftPath = animationSeqSoftData.AnimationSoftPath;
			AnimSoftPathRefMap.Add(animationSoftPath.AssetPathName.ToString(), num);
			num++;
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences")]
	protected override int RequireAnimationsLoadAtDesiredReferences_Implementation(int Ref, bool bLoadAll, UObject obj)
	{
		if (obj == null)
		{
			return -1;
		}
		UAnimInstance uAnimInstance = obj as UAnimInstance;
		if (uAnimInstance == null)
		{
			return -2;
		}
		AActor owner = uAnimInstance.GetOwningComponent().GetOwner();
		if (owner == null)
		{
			return -3;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return -4;
		}
		if (!bLoadAll)
		{
			if (!AnimationContextIsValid(Ref))
			{
				return -5;
			}
			if (!CheckIsFirstLoadRequireDesireAsset(Ref))
			{
				return 0;
			}
			FSoftObjectPath softPathByIndex = GetSoftPathByIndex(Ref);
			softPathByIndex.AssetPathName.ToString();
			SetSoftPathHasBeenLoading(softPathByIndex);
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_MotionMatchingAnimUsingPreLoad.Invoke(softPathByIndex, OnAnimationAssetLoadFinished);
			return 1;
		}
		for (int i = 0; i < CountAnimationReferences(); i++)
		{
			if (CheckIsFirstLoadRequireDesireAsset(i))
			{
				FSoftObjectPath softPathByIndex2 = GetSoftPathByIndex(i);
				softPathByIndex2.AssetPathName.ToString();
				SetSoftPathHasBeenLoading(softPathByIndex2);
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_MotionMatchingAnimUsingPreLoad.Invoke(softPathByIndex2, OnAnimationAssetLoadFinished);
			}
		}
		return 1;
	}

	[USharpPath("/Script/b1-Managed.BUAnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset")]
	protected override bool CheckIsFirstLoadRequireDesireAsset_Implementation(int Ref)
	{
		FSoftObjectPath softPathByIndex = GetSoftPathByIndex(Ref);
		return GetSoftPathNeverLoading(softPathByIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:GenerateNewAACSAsset")]
	private static void GenerateNewAACSAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimationAnalyzer orgAA = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(buffer, GenerateNewAACSAsset_OrgAA_Offset));
		BUAnimationAnalyzer value = GenerateNewAACSAsset(orgAA);
		UObjectMarshaler<BUAnimationAnalyzer>.ToNative(IntPtr.Add(buffer, GenerateNewAACSAsset_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:FindABPSettingSameToAA")]
	private static void FindABPSettingSameToAA__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimationAnalyzer bUAnimationAnalyzer = GCHelper.Find<BUAnimationAnalyzer>(obj);
		BGWDataAsset_AbpHumanoidSetting aBP_Setting = UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(buffer, FindABPSettingSameToAA_ABP_Setting_Offset));
		string orgAAPackageName = FStringMarshaler.FromNative(IntPtr.Add(buffer, FindABPSettingSameToAA_OrgAAPackageName_Offset));
		bool value = bUAnimationAnalyzer.FindABPSettingSameToAA(aBP_Setting, orgAAPackageName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FindABPSettingSameToAA_ReturnValue_Offset), 0, FindABPSettingSameToAA_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:AddToABPSettingSameToAA")]
	private static void AddToABPSettingSameToAA__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimationAnalyzer bUAnimationAnalyzer = GCHelper.Find<BUAnimationAnalyzer>(obj);
		BGWDataAsset_AbpHumanoidSetting aBP_Setting = UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(buffer, AddToABPSettingSameToAA_ABP_Setting_Offset));
		string orgAAPackageName = FStringMarshaler.FromNative(IntPtr.Add(buffer, AddToABPSettingSameToAA_OrgAAPackageName_Offset));
		bool value = bUAnimationAnalyzer.AddToABPSettingSameToAA(aBP_Setting, orgAAPackageName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, AddToABPSettingSameToAA_ReturnValue_Offset), 0, AddToABPSettingSameToAA_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:MMAnimationSeqUsingNotify_Inner")]
	private static void MMAnimationSeqUsingNotify_Inner__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimationAnalyzer bUAnimationAnalyzer = GCHelper.Find<BUAnimationAnalyzer>(obj);
		int num = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, MMAnimationSeqUsingNotify_Inner_Ref_Offset));
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, MMAnimationSeqUsingNotify_Inner_Owner_Offset));
		bUAnimationAnalyzer.MMAnimationSeqUsingNotify_Inner_Implementation(num, owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset")]
	private static void CheckIsFirstLoadRequireDesireAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimationAnalyzer bUAnimationAnalyzer = GCHelper.Find<BUAnimationAnalyzer>(obj);
		int num = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, CheckIsFirstLoadRequireDesireAsset_Ref_Offset));
		bool value = bUAnimationAnalyzer.CheckIsFirstLoadRequireDesireAsset_Implementation(num);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset), 0, CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences")]
	private static void RequireAnimationsLoadAtDesiredReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimationAnalyzer bUAnimationAnalyzer = GCHelper.Find<BUAnimationAnalyzer>(obj);
		int num = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, RequireAnimationsLoadAtDesiredReferences_Ref_Offset));
		bool bLoadAll = BoolMarshaler.FromNative(IntPtr.Add(buffer, RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset), 0, RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress.Address);
		UObject obj2 = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RequireAnimationsLoadAtDesiredReferences_obj_Offset));
		int value = bUAnimationAnalyzer.RequireAnimationsLoadAtDesiredReferences_Implementation(num, bLoadAll, obj2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUAnimationAnalyzer");
		GenerateNewAACSAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateNewAACSAsset");
		GenerateNewAACSAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateNewAACSAsset_FunctionAddress);
		GenerateNewAACSAsset_OrgAA_Offset = NativeReflection.GetPropertyOffset(GenerateNewAACSAsset_FunctionAddress, "OrgAA");
		GenerateNewAACSAsset_OrgAA_IsValid = NativeReflection.ValidatePropertyClass(GenerateNewAACSAsset_FunctionAddress, "OrgAA", Classes.FObjectProperty);
		GenerateNewAACSAsset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GenerateNewAACSAsset_FunctionAddress, "ReturnValue");
		GenerateNewAACSAsset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GenerateNewAACSAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GenerateNewAACSAsset_IsValid = GenerateNewAACSAsset_FunctionAddress != IntPtr.Zero && GenerateNewAACSAsset_OrgAA_IsValid && GenerateNewAACSAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:GenerateNewAACSAsset", GenerateNewAACSAsset_IsValid);
		FindABPSettingSameToAA_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindABPSettingSameToAA");
		FindABPSettingSameToAA_ParamsSize = NativeReflection.GetFunctionParamsSize(FindABPSettingSameToAA_FunctionAddress);
		FindABPSettingSameToAA_ABP_Setting_Offset = NativeReflection.GetPropertyOffset(FindABPSettingSameToAA_FunctionAddress, "ABP_Setting");
		FindABPSettingSameToAA_ABP_Setting_IsValid = NativeReflection.ValidatePropertyClass(FindABPSettingSameToAA_FunctionAddress, "ABP_Setting", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FindABPSettingSameToAA_OrgAAPackageName_PropertyAddress, FindABPSettingSameToAA_FunctionAddress, "OrgAAPackageName");
		FindABPSettingSameToAA_OrgAAPackageName_Offset = NativeReflection.GetPropertyOffset(FindABPSettingSameToAA_FunctionAddress, "OrgAAPackageName");
		FindABPSettingSameToAA_OrgAAPackageName_IsValid = NativeReflection.ValidatePropertyClass(FindABPSettingSameToAA_FunctionAddress, "OrgAAPackageName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref FindABPSettingSameToAA_ReturnValue_PropertyAddress, FindABPSettingSameToAA_FunctionAddress, "ReturnValue");
		FindABPSettingSameToAA_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindABPSettingSameToAA_FunctionAddress, "ReturnValue");
		FindABPSettingSameToAA_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindABPSettingSameToAA_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindABPSettingSameToAA_IsValid = FindABPSettingSameToAA_FunctionAddress != IntPtr.Zero && FindABPSettingSameToAA_ABP_Setting_IsValid && FindABPSettingSameToAA_OrgAAPackageName_IsValid && FindABPSettingSameToAA_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:FindABPSettingSameToAA", FindABPSettingSameToAA_IsValid);
		AddToABPSettingSameToAA_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddToABPSettingSameToAA");
		AddToABPSettingSameToAA_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToABPSettingSameToAA_FunctionAddress);
		AddToABPSettingSameToAA_ABP_Setting_Offset = NativeReflection.GetPropertyOffset(AddToABPSettingSameToAA_FunctionAddress, "ABP_Setting");
		AddToABPSettingSameToAA_ABP_Setting_IsValid = NativeReflection.ValidatePropertyClass(AddToABPSettingSameToAA_FunctionAddress, "ABP_Setting", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AddToABPSettingSameToAA_OrgAAPackageName_PropertyAddress, AddToABPSettingSameToAA_FunctionAddress, "OrgAAPackageName");
		AddToABPSettingSameToAA_OrgAAPackageName_Offset = NativeReflection.GetPropertyOffset(AddToABPSettingSameToAA_FunctionAddress, "OrgAAPackageName");
		AddToABPSettingSameToAA_OrgAAPackageName_IsValid = NativeReflection.ValidatePropertyClass(AddToABPSettingSameToAA_FunctionAddress, "OrgAAPackageName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref AddToABPSettingSameToAA_ReturnValue_PropertyAddress, AddToABPSettingSameToAA_FunctionAddress, "ReturnValue");
		AddToABPSettingSameToAA_ReturnValue_Offset = NativeReflection.GetPropertyOffset(AddToABPSettingSameToAA_FunctionAddress, "ReturnValue");
		AddToABPSettingSameToAA_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(AddToABPSettingSameToAA_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddToABPSettingSameToAA_IsValid = AddToABPSettingSameToAA_FunctionAddress != IntPtr.Zero && AddToABPSettingSameToAA_ABP_Setting_IsValid && AddToABPSettingSameToAA_OrgAAPackageName_IsValid && AddToABPSettingSameToAA_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:AddToABPSettingSameToAA", AddToABPSettingSameToAA_IsValid);
		MMAnimationSeqUsingNotify_Inner_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MMAnimationSeqUsingNotify_Inner");
		MMAnimationSeqUsingNotify_Inner_ParamsSize = NativeReflection.GetFunctionParamsSize(MMAnimationSeqUsingNotify_Inner_FunctionAddress);
		MMAnimationSeqUsingNotify_Inner_Ref_Offset = NativeReflection.GetPropertyOffset(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Ref");
		MMAnimationSeqUsingNotify_Inner_Ref_IsValid = NativeReflection.ValidatePropertyClass(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Ref", Classes.FIntProperty);
		MMAnimationSeqUsingNotify_Inner_Owner_Offset = NativeReflection.GetPropertyOffset(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Owner");
		MMAnimationSeqUsingNotify_Inner_Owner_IsValid = NativeReflection.ValidatePropertyClass(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Owner", Classes.FObjectProperty);
		MMAnimationSeqUsingNotify_Inner_IsValid = MMAnimationSeqUsingNotify_Inner_FunctionAddress != IntPtr.Zero && MMAnimationSeqUsingNotify_Inner_Ref_IsValid && MMAnimationSeqUsingNotify_Inner_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:MMAnimationSeqUsingNotify_Inner", MMAnimationSeqUsingNotify_Inner_IsValid);
		CheckIsFirstLoadRequireDesireAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckIsFirstLoadRequireDesireAsset");
		CheckIsFirstLoadRequireDesireAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsFirstLoadRequireDesireAsset_FunctionAddress);
		CheckIsFirstLoadRequireDesireAsset_Ref_Offset = NativeReflection.GetPropertyOffset(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "Ref");
		CheckIsFirstLoadRequireDesireAsset_Ref_IsValid = NativeReflection.ValidatePropertyClass(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress, CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue");
		CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue");
		CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsFirstLoadRequireDesireAsset_IsValid = CheckIsFirstLoadRequireDesireAsset_FunctionAddress != IntPtr.Zero && CheckIsFirstLoadRequireDesireAsset_Ref_IsValid && CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset", CheckIsFirstLoadRequireDesireAsset_IsValid);
		RequireAnimationsLoadAtDesiredReferences_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequireAnimationsLoadAtDesiredReferences");
		RequireAnimationsLoadAtDesiredReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(RequireAnimationsLoadAtDesiredReferences_FunctionAddress);
		RequireAnimationsLoadAtDesiredReferences_Ref_Offset = NativeReflection.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "Ref");
		RequireAnimationsLoadAtDesiredReferences_Ref_IsValid = NativeReflection.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll");
		RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset = NativeReflection.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll");
		RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid = NativeReflection.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll", Classes.FBoolProperty);
		RequireAnimationsLoadAtDesiredReferences_obj_Offset = NativeReflection.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "obj");
		RequireAnimationsLoadAtDesiredReferences_obj_IsValid = NativeReflection.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "obj", Classes.FObjectProperty);
		RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "ReturnValue");
		RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RequireAnimationsLoadAtDesiredReferences_IsValid = RequireAnimationsLoadAtDesiredReferences_FunctionAddress != IntPtr.Zero && RequireAnimationsLoadAtDesiredReferences_Ref_IsValid && RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid && RequireAnimationsLoadAtDesiredReferences_obj_IsValid && RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences", RequireAnimationsLoadAtDesiredReferences_IsValid);
	}

	static BUAnimationAnalyzer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimationAnalyzer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimationAnalyzer));
	}
}
