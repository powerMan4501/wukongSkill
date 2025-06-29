using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal")]
public struct FTamerInfo_ForAbnormal
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:TamerFileName")]
	public string TamerFileName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:TamerPath")]
	public string TamerPath;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:ResID")]
	public int ResID;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:SKMeshPath")]
	public string SKMeshPath;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:SKScale")]
	public float SKScale;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:FinnalExtendID")]
	public int FinnalExtendID;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:AbnormalDispID_Attacker")]
	public int AbnormalDispID_Attacker;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:AbnormalDispID_Victim")]
	public int AbnormalDispID_Victim;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:ErrorFlag")]
	public bool ErrorFlag;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:ErrorLog")]
	public string ErrorLog;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerInfo_ForAbnormal:ImmueList")]
	public List<Birth_AbnormalStateImmueType> ImmueList;

	private static int TamerInfo_ForAbnormal_StructSize;

	private static int TamerInfo_ForAbnormal_IsValid;

	private static bool TamerFileName_IsValid;

	private static int TamerFileName_Offset;

	private static bool TamerPath_IsValid;

	private static int TamerPath_Offset;

	private static bool ResID_IsValid;

	private static int ResID_Offset;

	private static bool SKMeshPath_IsValid;

	private static int SKMeshPath_Offset;

	private static bool SKScale_IsValid;

	private static int SKScale_Offset;

	private static bool FinnalExtendID_IsValid;

	private static int FinnalExtendID_Offset;

	private static bool AbnormalDispID_Attacker_IsValid;

	private static int AbnormalDispID_Attacker_Offset;

	private static bool AbnormalDispID_Victim_IsValid;

	private static int AbnormalDispID_Victim_Offset;

	private static bool ErrorFlag_IsValid;

	private static int ErrorFlag_Offset;

	private static FFieldAddress ErrorFlag_PropertyAddress;

	private static bool ErrorLog_IsValid;

	private static int ErrorLog_Offset;

	private static bool ImmueList_IsValid;

	private static int ImmueList_Offset;

	private static FFieldAddress ImmueList_PropertyAddress;

	public FTamerInfo_ForAbnormal Copy()
	{
		FTamerInfo_ForAbnormal result = this;
		if (ImmueList != null)
		{
			result.ImmueList = new List<Birth_AbnormalStateImmueType>(ImmueList);
		}
		return result;
	}

	public static FTamerInfo_ForAbnormal FromNative(IntPtr nativeBuffer)
	{
		return new FTamerInfo_ForAbnormal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerInfo_ForAbnormal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerInfo_ForAbnormal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerInfo_ForAbnormal(IntPtr.Add(nativeBuffer, arrayIndex * TamerInfo_ForAbnormal_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerInfo_ForAbnormal value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TamerInfo_ForAbnormal_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TamerInfo_ForAbnormal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerInfo_ForAbnormal");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TamerFileName_Offset), TamerFileName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TamerPath_Offset), TamerPath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResID_Offset), ResID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SKMeshPath_Offset), SKMeshPath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SKScale_Offset), SKScale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FinnalExtendID_Offset), FinnalExtendID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AbnormalDispID_Attacker_Offset), AbnormalDispID_Attacker);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AbnormalDispID_Victim_Offset), AbnormalDispID_Victim);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ErrorFlag_Offset), 0, ErrorFlag_PropertyAddress.Address, ErrorFlag);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ErrorLog_Offset), ErrorLog);
		new TArrayCopyMarshaler<Birth_AbnormalStateImmueType>(1, ImmueList_PropertyAddress, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.FromNative, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ImmueList_Offset), ImmueList);
	}

	public FTamerInfo_ForAbnormal(IntPtr nativeStruct)
	{
		if (TamerInfo_ForAbnormal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerInfo_ForAbnormal");
			TamerFileName = null;
			TamerPath = null;
			ResID = 0;
			SKMeshPath = null;
			SKScale = 0f;
			FinnalExtendID = 0;
			AbnormalDispID_Attacker = 0;
			AbnormalDispID_Victim = 0;
			ErrorFlag = false;
			ErrorLog = null;
			ImmueList = null;
		}
		else
		{
			TamerFileName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TamerFileName_Offset));
			TamerPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TamerPath_Offset));
			ResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResID_Offset));
			SKMeshPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SKMeshPath_Offset));
			SKScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SKScale_Offset));
			FinnalExtendID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FinnalExtendID_Offset));
			AbnormalDispID_Attacker = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AbnormalDispID_Attacker_Offset));
			AbnormalDispID_Victim = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AbnormalDispID_Victim_Offset));
			ErrorFlag = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ErrorFlag_Offset), 0, ErrorFlag_PropertyAddress.Address);
			ErrorLog = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ErrorLog_Offset));
			ImmueList = new TArrayCopyMarshaler<Birth_AbnormalStateImmueType>(1, ImmueList_PropertyAddress, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.FromNative, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ImmueList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TamerInfo_ForAbnormal");
		TamerInfo_ForAbnormal_StructSize = NativeReflection.GetStructSize(intPtr);
		TamerFileName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerFileName");
		TamerFileName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerFileName", Classes.FStrProperty);
		TamerPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerPath");
		TamerPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerPath", Classes.FStrProperty);
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
		SKMeshPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMeshPath");
		SKMeshPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMeshPath", Classes.FStrProperty);
		SKScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKScale");
		SKScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKScale", Classes.FFloatProperty);
		FinnalExtendID_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinnalExtendID");
		FinnalExtendID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinnalExtendID", Classes.FIntProperty);
		AbnormalDispID_Attacker_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalDispID_Attacker");
		AbnormalDispID_Attacker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalDispID_Attacker", Classes.FIntProperty);
		AbnormalDispID_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalDispID_Victim");
		AbnormalDispID_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalDispID_Victim", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ErrorFlag_PropertyAddress, intPtr, "ErrorFlag");
		ErrorFlag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ErrorFlag");
		ErrorFlag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ErrorFlag", Classes.FBoolProperty);
		ErrorLog_Offset = NativeReflection.GetPropertyOffset(intPtr, "ErrorLog");
		ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ImmueList_PropertyAddress, intPtr, "ImmueList");
		ImmueList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImmueList");
		ImmueList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImmueList", Classes.FArrayProperty);
		TamerInfo_ForAbnormal_IsValid = ((intPtr != IntPtr.Zero && TamerFileName_IsValid && TamerPath_IsValid && ResID_IsValid && SKMeshPath_IsValid && SKScale_IsValid && FinnalExtendID_IsValid && AbnormalDispID_Attacker_IsValid && AbnormalDispID_Victim_IsValid && ErrorFlag_IsValid && ErrorLog_IsValid && ImmueList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TamerInfo_ForAbnormal", (byte)TamerInfo_ForAbnormal_IsValid != 0);
	}

	static FTamerInfo_ForAbnormal()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTamerInfo_ForAbnormal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerInfo_ForAbnormal));
	}
}
