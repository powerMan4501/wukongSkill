using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Montage Jump To Section")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection")]
internal class BANS_GSMontageJumpToSection : BANS_GSBase
{
	private static bool bReversePreDetectionResult_IsValid;

	private static int bReversePreDetectionResult_Offset;

	private static FFieldAddress bReversePreDetectionResult_PropertyAddress;

	private static bool bJumpImmediately_IsValid;

	private static int bJumpImmediately_Offset;

	private static FFieldAddress bJumpImmediately_PropertyAddress;

	private static bool JumpToSectionName_IsValid;

	private static int JumpToSectionName_Offset;

	private static bool JumpableSectionPrefix_IsValid;

	private static int JumpableSectionPrefix_Offset;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSAllowCrossSection_IsValid;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	private static bool GetJumpableSectionPrefix_IsValid;

	private static IntPtr GetJumpableSectionPrefix_FunctionAddress;

	private static int GetJumpableSectionPrefix_ParamsSize;

	private static bool GetJumpableSectionPrefix_ReturnValue_IsValid;

	private static int GetJumpableSectionPrefix_ReturnValue_Offset;

	private static FFieldAddress GetJumpableSectionPrefix_ReturnValue_PropertyAddress;

	[Tooltip("若为true，预检测结果不通过时跳转到指定Section；否则通过时跳转到指定Section")]
	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:bReversePreDetectionResult")]
	public bool bReversePreDetectionResult
	{
		get
		{
			CheckDestroyed();
			if (!bReversePreDetectionResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:bReversePreDetectionResult");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReversePreDetectionResult_Offset), 0, bReversePreDetectionResult_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReversePreDetectionResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:bReversePreDetectionResult");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReversePreDetectionResult_Offset), 0, bReversePreDetectionResult_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("若为true，该Notify触发时立即跳转到指定Section；否则等待当前Section结束再跳转")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:bJumpImmediately")]
	public bool bJumpImmediately
	{
		get
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:bJumpImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:bJumpImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("跳转到的Section名")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpToSectionName")]
	public FName JumpToSectionName
	{
		get
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpToSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, JumpToSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpToSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, JumpToSectionName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("所有可跳转的Section名的前缀")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpableSectionPrefix")]
	public string JumpableSectionPrefix
	{
		get
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpableSectionPrefix");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSection:JumpableSectionPrefix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		if ((!bReversePreDetectionResult && BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.MontageSectionJumpApproved)) || (bReversePreDetectionResult && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.MontageSectionJumpApproved)))
		{
			if (bJumpImmediately)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_MontageJumpToSection.Invoke(JumpToSectionName);
			}
			else
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_MontageSetNextSection.Invoke(JumpToSectionName);
			}
		}
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.MontageSectionJumpApproved))
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, EBGUSimpleState.MontageSectionJumpApproved, IsRemove: true);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.MontageJumpToSection;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetJumpableSectionPrefix")]
	protected override string GetJumpableSectionPrefix_Implementation()
	{
		return JumpableSectionPrefix;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSection bANS_GSMontageJumpToSection = GCHelper.Find<b1.BANS_GSMontageJumpToSection>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSMontageJumpToSection.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSection bANS_GSMontageJumpToSection = GCHelper.Find<b1.BANS_GSMontageJumpToSection>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSMontageJumpToSection.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSection bANS_GSMontageJumpToSection = GCHelper.Find<b1.BANS_GSMontageJumpToSection>(obj);
		bool value = bANS_GSMontageJumpToSection.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetJumpableSectionPrefix")]
	private static void GetJumpableSectionPrefix__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSection bANS_GSMontageJumpToSection = GCHelper.Find<b1.BANS_GSMontageJumpToSection>(obj);
		string jumpableSectionPrefix_Implementation = bANS_GSMontageJumpToSection.GetJumpableSectionPrefix_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetJumpableSectionPrefix_ReturnValue_Offset), jumpableSectionPrefix_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSMontageJumpToSection");
		NativeReflection.GetPropertyRef(ref bReversePreDetectionResult_PropertyAddress, intPtr, "bReversePreDetectionResult");
		bReversePreDetectionResult_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReversePreDetectionResult");
		bReversePreDetectionResult_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReversePreDetectionResult", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bJumpImmediately_PropertyAddress, intPtr, "bJumpImmediately");
		bJumpImmediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJumpImmediately");
		bJumpImmediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJumpImmediately", Classes.FBoolProperty);
		JumpToSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpToSectionName");
		JumpToSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpToSectionName", Classes.FNameProperty);
		JumpableSectionPrefix_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpableSectionPrefix");
		JumpableSectionPrefix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpableSectionPrefix", Classes.FStrProperty);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSection:GSAllowCrossSection", GSAllowCrossSection_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSection:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
	}

	static BANS_GSMontageJumpToSection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSMontageJumpToSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSMontageJumpToSection));
	}
}
