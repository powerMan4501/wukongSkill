using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGUCopyABPSettingComp")]
internal class BGUCopyABPSettingComp : UBaseActorComp
{
	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[USharpPath("/Script/b1-Managed.BGUCopyABPSettingComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			return;
		}
		foreach (BGUCharacterCS allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList<BGUCharacterCS>(this))
		{
			CreateAndSaveABPSetting(allActorsOfClass);
		}
	}

	private void CreateAndSaveABPSetting(BGUCharacterCS Character)
	{
		if (!(Character.Mesh == null))
		{
			BUAnimHumanoidCS bUAnimHumanoidCS = Character.Mesh.GetAnimInstance() as BUAnimHumanoidCS;
			if (!(bUAnimHumanoidCS == null))
			{
				CreateDefaultABPSettings(bUAnimHumanoidCS);
			}
		}
	}

	private void CreateDefaultABPSettings(BUAnimHumanoidCS AnimInstance)
	{
		string pathName = AnimInstance.GetClass().GetOutermost().GetPathName();
		string text = pathName.Substring(pathName.LastIndexOf('/') + 1);
		string text2 = text.Substring(text.IndexOf('_') + 1);
		string path = pathName.Substring(0, pathName.LastIndexOf('/') + 1);
		string name = "ABPSetting_" + text2;
		UClass uClass = UClass.GetClass<BGWDataAsset_AbpHumanoidSetting>();
		BGWDataAsset_AbpHumanoidSetting bGWDataAsset_AbpHumanoidSetting = UGSE_EngineFuncLib.CreateAsset(path, name, uClass) as BGWDataAsset_AbpHumanoidSetting;
		UGSFuncLibForEditor.CheckoutAndSavePackage(new List<UPackage> { bGWDataAsset_AbpHumanoidSetting.GetOutermost() }, bCheckDirty: false, bPromptToSave: false, out var _);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCopyABPSettingComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUCopyABPSettingComp bGUCopyABPSettingComp = GCHelper.Find<b1.BGUCopyABPSettingComp>(obj);
		bGUCopyABPSettingComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUCopyABPSettingComp");
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCopyABPSettingComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BGUCopyABPSettingComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUCopyABPSettingComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUCopyABPSettingComp));
	}
}
