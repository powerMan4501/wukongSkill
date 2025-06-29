using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("演员")]
[UClass]
[USharpPath("/Script/b1-Managed.PerformerParam_Performer")]
public class UPerformerParam_Performer : UPerformerParamBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool PerformerGuid_IsValid;

	private static int PerformerGuid_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerParam_Performer:Performer")]
	public TSoftObject<BGUPerformerActorCS> Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Performer:Performer");
				return default(TSoftObject<BGUPerformerActorCS>);
			}
			return TSoftObjectMarshaler<BGUPerformerActorCS>.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Performer:Performer");
			}
			else
			{
				TSoftObjectMarshaler<BGUPerformerActorCS>.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParam_Performer:PerformerGuid")]
	public string PerformerGuid
	{
		get
		{
			CheckDestroyed();
			if (!PerformerGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Performer:PerformerGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PerformerGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Performer:PerformerGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PerformerGuid_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.ParamType = EPerformerParamType.Performer;
	}

	public override string GetActorGuid()
	{
		return PerformerGuid;
	}

	[USharpPath("/Script/b1-Managed.PerformerParam_Performer:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName == "Performer")
		{
			if (Performer.IsNull)
			{
				PerformerGuid = "";
			}
			else if (Performer.IsValid)
			{
				BGUPerformerActorCS value = Performer.Value;
				base.ParamName = new FName(value.GetActorLabel());
				PerformerGuid = BGU_DataUtil.GetActorGuid(value, bFindFromComponent: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.PerformerParam_Performer:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		UPerformerParam_Performer uPerformerParam_Performer = GCHelper.Find<UPerformerParam_Performer>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		uPerformerParam_Performer.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PerformerParam_Performer");
		Performer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Performer", Classes.FSoftObjectProperty);
		PerformerGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformerGuid");
		PerformerGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformerGuid", Classes.FStrProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.PerformerParam_Performer:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static UPerformerParam_Performer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerParam_Performer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerParam_Performer));
	}
}
