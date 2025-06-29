using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Montage Jump To Section When Has Buff")]
[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff")]
internal class BANS_GSMontageJumpToSectionWhenHasBuff : BANS_GSBase
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool bJumpImmediately_IsValid;

	private static int bJumpImmediately_Offset;

	private static FFieldAddress bJumpImmediately_PropertyAddress;

	private static bool JumpToSectionName_IsValid;

	private static int JumpToSectionName_Offset;

	private static bool JumpableSectionPrefix_IsValid;

	private static int JumpableSectionPrefix_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

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

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[Tooltip("若为true，该Notify触发时立即跳转到指定Section；否则等待当前Section结束再跳转")]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:bJumpImmediately")]
	public bool bJumpImmediately
	{
		get
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:bJumpImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:bJumpImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("跳转到的Section名")]
	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpToSectionName")]
	public FName JumpToSectionName
	{
		get
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpToSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, JumpToSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpToSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, JumpToSectionName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[Tooltip("所有可跳转的Section名的前缀")]
	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpableSectionPrefix")]
	public string JumpableSectionPrefix
	{
		get
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpableSectionPrefix");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:JumpableSectionPrefix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		CheckLogic(NotifyParam.owner);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
	}

	private void CheckLogic(AActor Owner)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed() && BGUFunctionLibraryCS.BGUHasBuffByID(bGUCharacterCS, BuffID))
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
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetJumpableSectionPrefix")]
	protected override string GetJumpableSectionPrefix_Implementation()
	{
		return JumpableSectionPrefix;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.MontageJumpToSection;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSMontageJumpToSectionWhenHasBuff.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSMontageJumpToSectionWhenHasBuff.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSMontageJumpToSectionWhenHasBuff.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSMontageJumpToSectionWhenHasBuff.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		bool value = bANS_GSMontageJumpToSectionWhenHasBuff.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetJumpableSectionPrefix")]
	private static void GetJumpableSectionPrefix__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMontageJumpToSectionWhenHasBuff bANS_GSMontageJumpToSectionWhenHasBuff = GCHelper.Find<b1.BANS_GSMontageJumpToSectionWhenHasBuff>(obj);
		string jumpableSectionPrefix_Implementation = bANS_GSMontageJumpToSectionWhenHasBuff.GetJumpableSectionPrefix_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetJumpableSectionPrefix_ReturnValue_Offset), jumpableSectionPrefix_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bJumpImmediately_PropertyAddress, intPtr, "bJumpImmediately");
		bJumpImmediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJumpImmediately");
		bJumpImmediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJumpImmediately", Classes.FBoolProperty);
		JumpToSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpToSectionName");
		JumpToSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpToSectionName", Classes.FNameProperty);
		JumpableSectionPrefix_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpableSectionPrefix");
		JumpableSectionPrefix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpableSectionPrefix", Classes.FStrProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GSAllowCrossSection", GSAllowCrossSection_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMontageJumpToSectionWhenHasBuff:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
	}

	static BANS_GSMontageJumpToSectionWhenHasBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSMontageJumpToSectionWhenHasBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSMontageJumpToSectionWhenHasBuff));
	}
}
