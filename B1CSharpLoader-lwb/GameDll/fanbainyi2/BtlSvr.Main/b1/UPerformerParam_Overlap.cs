using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("触发盒")]
[USharpPath("/Script/b1-Managed.PerformerParam_Overlap")]
public class UPerformerParam_Overlap : UPerformerParamBase
{
	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParam_Overlap:Actor")]
	public TSoftObject<BGUOverlapArea> Actor
	{
		get
		{
			CheckDestroyed();
			if (!Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Overlap:Actor");
				return default(TSoftObject<BGUOverlapArea>);
			}
			return TSoftObjectMarshaler<BGUOverlapArea>.FromNative(IntPtr.Add(base.Address, Actor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Overlap:Actor");
			}
			else
			{
				TSoftObjectMarshaler<BGUOverlapArea>.ToNative(IntPtr.Add(base.Address, Actor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParam_Overlap:ActorGuid")]
	public string ActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!ActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Overlap:ActorGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParam_Overlap:ActorGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ActorGuid_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.ParamType = EPerformerParamType.Overlap;
	}

	public override string GetActorGuid()
	{
		return ActorGuid;
	}

	[USharpPath("/Script/b1-Managed.PerformerParam_Overlap:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName == "Actor")
		{
			if (Actor.IsNull)
			{
				ActorGuid = "";
			}
			else if (Actor.IsValid)
			{
				BGUOverlapArea value = Actor.Value;
				base.ParamName = new FName(value.GetActorLabel());
				ActorGuid = BGU_DataUtil.GetActorGuid(value, bFindFromComponent: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.PerformerParam_Overlap:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		UPerformerParam_Overlap uPerformerParam_Overlap = GCHelper.Find<UPerformerParam_Overlap>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		uPerformerParam_Overlap.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PerformerParam_Overlap");
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.PerformerParam_Overlap:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static UPerformerParam_Overlap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerParam_Overlap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerParam_Overlap));
	}
}
