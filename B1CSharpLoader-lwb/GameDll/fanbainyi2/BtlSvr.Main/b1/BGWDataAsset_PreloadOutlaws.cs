using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws")]
public class BGWDataAsset_PreloadOutlaws : UBGWDataAsset
{
	private static bool Outlaws_IsValid;

	private static int Outlaws_Offset;

	private static FFieldAddress Outlaws_PropertyAddress;

	private TMapReadWriteMarshaler<int, FResourceID_PreloadOutlaws> Outlaws_Marshaler;

	private static bool CheckedList_IsValid;

	private static int CheckedList_Offset;

	private static FFieldAddress CheckedList_PropertyAddress;

	private TMapReadWriteMarshaler<int, FResourceID_PreloadOutlaws> CheckedList_Marshaler;

	private static bool Outlaw_AbnormalState_IsValid;

	private static int Outlaw_AbnormalState_Offset;

	private static FFieldAddress Outlaw_AbnormalState_PropertyAddress;

	private TArrayReadWriteMarshaler<string> Outlaw_AbnormalState_Marshaler;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:Outlaws")]
	public TMapReadWrite<int, FResourceID_PreloadOutlaws> Outlaws
	{
		get
		{
			CheckDestroyed();
			if (!Outlaws_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:Outlaws");
				return null;
			}
			if (Outlaws_Marshaler == null)
			{
				Outlaws_Marshaler = new TMapReadWriteMarshaler<int, FResourceID_PreloadOutlaws>(1, Outlaws_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaws, FResourceID_PreloadOutlaws>.FromNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaws, FResourceID_PreloadOutlaws>.ToNative);
			}
			return Outlaws_Marshaler.FromNative(IntPtr.Add(base.Address, Outlaws_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:CheckedList")]
	public TMapReadWrite<int, FResourceID_PreloadOutlaws> CheckedList
	{
		get
		{
			CheckDestroyed();
			if (!CheckedList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:CheckedList");
				return null;
			}
			if (CheckedList_Marshaler == null)
			{
				CheckedList_Marshaler = new TMapReadWriteMarshaler<int, FResourceID_PreloadOutlaws>(1, CheckedList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaws, FResourceID_PreloadOutlaws>.FromNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaws, FResourceID_PreloadOutlaws>.ToNative);
			}
			return CheckedList_Marshaler.FromNative(IntPtr.Add(base.Address, CheckedList_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:Outlaw_AbnormalState")]
	public TArrayReadWrite<string> Outlaw_AbnormalState
	{
		get
		{
			CheckDestroyed();
			if (!Outlaw_AbnormalState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws:Outlaw_AbnormalState");
				return null;
			}
			if (Outlaw_AbnormalState_Marshaler == null)
			{
				Outlaw_AbnormalState_Marshaler = new TArrayReadWriteMarshaler<string>(1, Outlaw_AbnormalState_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Outlaw_AbnormalState_Marshaler.FromNative(IntPtr.Add(base.Address, Outlaw_AbnormalState_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PreloadOutlaws");
		NativeReflection.GetPropertyRef(ref Outlaws_PropertyAddress, unrealStruct, "Outlaws");
		Outlaws_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Outlaws");
		Outlaws_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Outlaws", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref CheckedList_PropertyAddress, unrealStruct, "CheckedList");
		CheckedList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckedList");
		CheckedList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckedList", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref Outlaw_AbnormalState_PropertyAddress, unrealStruct, "Outlaw_AbnormalState");
		Outlaw_AbnormalState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Outlaw_AbnormalState");
		Outlaw_AbnormalState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Outlaw_AbnormalState", Classes.FArrayProperty);
	}

	static BGWDataAsset_PreloadOutlaws()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PreloadOutlaws)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PreloadOutlaws));
	}
}
