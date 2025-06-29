using System;
using GSDispLib;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset")]
public class BGWFollowPartnerConfigDataAsset : UBGWDataAsset
{
	private static bool SeqShowingFinishMoveEQSTemplate_IsValid;

	private static int SeqShowingFinishMoveEQSTemplate_Offset;

	private static bool HiddenSelfDBC_IsValid;

	private static int HiddenSelfDBC_Offset;

	[DisplayName("Seq表演结束移动EQS模板")]
	[Category("SeqShowing")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:SeqShowingFinishMoveEQSTemplate")]
	public UEnvQuery SeqShowingFinishMoveEQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!SeqShowingFinishMoveEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:SeqShowingFinishMoveEQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, SeqShowingFinishMoveEQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeqShowingFinishMoveEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:SeqShowingFinishMoveEQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, SeqShowingFinishMoveEQSTemplate_Offset), value);
			}
		}
	}

	[DisplayName("Seq表演中隐藏自身DBC")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SeqShowing")]
	[USharpPath("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:HiddenSelfDBC")]
	public BUC_DispLibDispBaseConfigDataAsset HiddenSelfDBC
	{
		get
		{
			CheckDestroyed();
			if (!HiddenSelfDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:HiddenSelfDBC");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(base.Address, HiddenSelfDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HiddenSelfDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset:HiddenSelfDBC");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.ToNative(IntPtr.Add(base.Address, HiddenSelfDBC_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWFollowPartnerConfigDataAsset");
		SeqShowingFinishMoveEQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeqShowingFinishMoveEQSTemplate");
		SeqShowingFinishMoveEQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeqShowingFinishMoveEQSTemplate", Classes.FObjectProperty);
		HiddenSelfDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HiddenSelfDBC");
		HiddenSelfDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HiddenSelfDBC", Classes.FObjectProperty);
	}

	static BGWFollowPartnerConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWFollowPartnerConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWFollowPartnerConfigDataAsset));
	}
}
