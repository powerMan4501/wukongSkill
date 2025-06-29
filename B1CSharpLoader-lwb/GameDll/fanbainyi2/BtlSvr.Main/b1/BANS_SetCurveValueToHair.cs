using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Set CurveValue To Hair【已废弃】")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair")]
internal class BANS_SetCurveValueToHair : BANS_GSBase
{
	private static bool TemporaryClose_IsValid;

	private static int TemporaryClose_Offset;

	private static FFieldAddress TemporaryClose_PropertyAddress;

	private static bool HairType_IsValid;

	private static int HairType_Offset;

	private static FFieldAddress HairType_PropertyAddress;

	private static bool HairCompTagList_IsValid;

	private static int HairCompTagList_Offset;

	private static FFieldAddress HairCompTagList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> HairCompTagList_Marshaler;

	private static bool FloatCurveParamList_IsValid;

	private static int FloatCurveParamList_Offset;

	private static FFieldAddress FloatCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> FloatCurveParamList_Marshaler;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair:TemporaryClose")]
	public bool TemporaryClose
	{
		get
		{
			CheckDestroyed();
			if (!TemporaryClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:TemporaryClose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TemporaryClose_Offset), 0, TemporaryClose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TemporaryClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:TemporaryClose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TemporaryClose_Offset), 0, TemporaryClose_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair:HairType")]
	public EGSHairType HairType
	{
		get
		{
			CheckDestroyed();
			if (!HairType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:HairType");
				return EGSHairType.TressFX;
			}
			return EnumMarshaler<EGSHairType>.FromNative(IntPtr.Add(base.Address, HairType_Offset), 0, HairType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HairType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:HairType");
			}
			else
			{
				EnumMarshaler<EGSHairType>.ToNative(IntPtr.Add(base.Address, HairType_Offset), 0, HairType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair:HairCompTagList")]
	public TArrayReadWrite<FName> HairCompTagList
	{
		get
		{
			CheckDestroyed();
			if (!HairCompTagList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:HairCompTagList");
				return null;
			}
			if (HairCompTagList_Marshaler == null)
			{
				HairCompTagList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, HairCompTagList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return HairCompTagList_Marshaler.FromNative(IntPtr.Add(base.Address, HairCompTagList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair:FloatCurveParamList")]
	public TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetCurveValueToHair:FloatCurveParamList");
				return null;
			}
			if (FloatCurveParamList_Marshaler == null)
			{
				FloatCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, FloatCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return FloatCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, FloatCurveParamList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		HairType = EGSHairType.TressFX;
		TemporaryClose = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_SetCurveValueToHair:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.SetCurveValueToHair;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SetCurveValueToHair:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SetCurveValueToHair bANS_SetCurveValueToHair = GCHelper.Find<b1.BANS_SetCurveValueToHair>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_SetCurveValueToHair.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_SetCurveValueToHair");
		NativeReflection.GetPropertyRef(ref TemporaryClose_PropertyAddress, intPtr, "TemporaryClose");
		TemporaryClose_Offset = NativeReflection.GetPropertyOffset(intPtr, "TemporaryClose");
		TemporaryClose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TemporaryClose", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HairType_PropertyAddress, intPtr, "HairType");
		HairType_Offset = NativeReflection.GetPropertyOffset(intPtr, "HairType");
		HairType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HairType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HairCompTagList_PropertyAddress, intPtr, "HairCompTagList");
		HairCompTagList_Offset = NativeReflection.GetPropertyOffset(intPtr, "HairCompTagList");
		HairCompTagList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HairCompTagList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FloatCurveParamList_PropertyAddress, intPtr, "FloatCurveParamList");
		FloatCurveParamList_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatCurveParamList");
		FloatCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatCurveParamList", Classes.FArrayProperty);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SetCurveValueToHair:GetAnimNSType", GetAnimNSType_IsValid);
	}

	static BANS_SetCurveValueToHair()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_SetCurveValueToHair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_SetCurveValueToHair));
	}
}
