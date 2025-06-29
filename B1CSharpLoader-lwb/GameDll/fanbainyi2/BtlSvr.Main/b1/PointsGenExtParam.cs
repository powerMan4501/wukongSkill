using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PointsGenExtParam")]
public struct PointsGenExtParam
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:SocketName")]
	public FName SocketName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:SocketNameList")]
	public List<FName> SocketNameList;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:EQSPath")]
	public string EQSPath;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:EQSTemplate")]
	public UEnvQuery EQSTemplate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:SceneItemTag")]
	public string SceneItemTag;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_DesiredNum")]
	public int Explode_DesiredNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_LineTraceMaxLength")]
	public float Explode_LineTraceMaxLength;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_TraceTypeQuery")]
	public ETraceTypeQuery Explode_TraceTypeQuery;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_PointMinBetween")]
	public float Explode_PointMinBetween;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_RangeDir_X")]
	public FFloatRange Explode_RangeDir_X;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_RangeDir_Y")]
	public FFloatRange Explode_RangeDir_Y;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsGenExtParam:Explode_RangeDir_Z")]
	public FFloatRange Explode_RangeDir_Z;

	private static int PointsGenExtParam_StructSize;

	private static int PointsGenExtParam_IsValid;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SocketNameList_IsValid;

	private static int SocketNameList_Offset;

	private static FFieldAddress SocketNameList_PropertyAddress;

	private static bool EQSPath_IsValid;

	private static int EQSPath_Offset;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool SceneItemTag_IsValid;

	private static int SceneItemTag_Offset;

	private static bool Explode_DesiredNum_IsValid;

	private static int Explode_DesiredNum_Offset;

	private static bool Explode_LineTraceMaxLength_IsValid;

	private static int Explode_LineTraceMaxLength_Offset;

	private static bool Explode_TraceTypeQuery_IsValid;

	private static int Explode_TraceTypeQuery_Offset;

	private static FFieldAddress Explode_TraceTypeQuery_PropertyAddress;

	private static bool Explode_PointMinBetween_IsValid;

	private static int Explode_PointMinBetween_Offset;

	private static bool Explode_RangeDir_X_IsValid;

	private static int Explode_RangeDir_X_Offset;

	private static bool Explode_RangeDir_Y_IsValid;

	private static int Explode_RangeDir_Y_Offset;

	private static bool Explode_RangeDir_Z_IsValid;

	private static int Explode_RangeDir_Z_Offset;

	public PointsGenExtParam Copy()
	{
		PointsGenExtParam result = this;
		if (SocketNameList != null)
		{
			result.SocketNameList = new List<FName>(SocketNameList);
		}
		return result;
	}

	public static PointsGenExtParam FromNative(IntPtr nativeBuffer)
	{
		return new PointsGenExtParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, PointsGenExtParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static PointsGenExtParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new PointsGenExtParam(IntPtr.Add(nativeBuffer, arrayIndex * PointsGenExtParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, PointsGenExtParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PointsGenExtParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PointsGenExtParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PointsGenExtParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		new TArrayCopyMarshaler<FName>(1, SocketNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SocketNameList_Offset), SocketNameList);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, EQSPath_Offset), EQSPath);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset), EQSTemplate);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SceneItemTag_Offset), SceneItemTag);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Explode_DesiredNum_Offset), Explode_DesiredNum);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Explode_LineTraceMaxLength_Offset), Explode_LineTraceMaxLength);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(nativeStruct, Explode_TraceTypeQuery_Offset), 0, Explode_TraceTypeQuery_PropertyAddress.Address, Explode_TraceTypeQuery);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Explode_PointMinBetween_Offset), Explode_PointMinBetween);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, Explode_RangeDir_X_Offset), Explode_RangeDir_X);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, Explode_RangeDir_Y_Offset), Explode_RangeDir_Y);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, Explode_RangeDir_Z_Offset), Explode_RangeDir_Z);
	}

	public PointsGenExtParam(IntPtr nativeStruct)
	{
		if (PointsGenExtParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PointsGenExtParam");
			SocketName = default(FName);
			SocketNameList = null;
			EQSPath = null;
			EQSTemplate = null;
			SceneItemTag = null;
			Explode_DesiredNum = 0;
			Explode_LineTraceMaxLength = 0f;
			Explode_TraceTypeQuery = ETraceTypeQuery.TraceTypeQuery1;
			Explode_PointMinBetween = 0f;
			Explode_RangeDir_X = default(FFloatRange);
			Explode_RangeDir_Y = default(FFloatRange);
			Explode_RangeDir_Z = default(FFloatRange);
		}
		else
		{
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			SocketNameList = new TArrayCopyMarshaler<FName>(1, SocketNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SocketNameList_Offset));
			EQSPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, EQSPath_Offset));
			EQSTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset));
			SceneItemTag = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SceneItemTag_Offset));
			Explode_DesiredNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Explode_DesiredNum_Offset));
			Explode_LineTraceMaxLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Explode_LineTraceMaxLength_Offset));
			Explode_TraceTypeQuery = EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(nativeStruct, Explode_TraceTypeQuery_Offset), 0, Explode_TraceTypeQuery_PropertyAddress.Address);
			Explode_PointMinBetween = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Explode_PointMinBetween_Offset));
			Explode_RangeDir_X = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, Explode_RangeDir_X_Offset));
			Explode_RangeDir_Y = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, Explode_RangeDir_Y_Offset));
			Explode_RangeDir_Z = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, Explode_RangeDir_Z_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PointsGenExtParam");
		PointsGenExtParam_StructSize = NativeReflection.GetStructSize(intPtr);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SocketNameList_PropertyAddress, intPtr, "SocketNameList");
		SocketNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketNameList");
		SocketNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketNameList", Classes.FArrayProperty);
		EQSPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSPath");
		EQSPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSPath", Classes.FStrProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplate", Classes.FObjectProperty);
		SceneItemTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneItemTag");
		SceneItemTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneItemTag", Classes.FStrProperty);
		Explode_DesiredNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_DesiredNum");
		Explode_DesiredNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_DesiredNum", Classes.FIntProperty);
		Explode_LineTraceMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_LineTraceMaxLength");
		Explode_LineTraceMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_LineTraceMaxLength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Explode_TraceTypeQuery_PropertyAddress, intPtr, "Explode_TraceTypeQuery");
		Explode_TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_TraceTypeQuery");
		Explode_TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_TraceTypeQuery", Classes.FEnumProperty);
		Explode_PointMinBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_PointMinBetween");
		Explode_PointMinBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_PointMinBetween", Classes.FFloatProperty);
		Explode_RangeDir_X_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_RangeDir_X");
		Explode_RangeDir_X_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_RangeDir_X", Classes.FStructProperty);
		Explode_RangeDir_Y_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_RangeDir_Y");
		Explode_RangeDir_Y_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_RangeDir_Y", Classes.FStructProperty);
		Explode_RangeDir_Z_Offset = NativeReflection.GetPropertyOffset(intPtr, "Explode_RangeDir_Z");
		Explode_RangeDir_Z_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Explode_RangeDir_Z", Classes.FStructProperty);
		PointsGenExtParam_IsValid = ((intPtr != IntPtr.Zero && SocketName_IsValid && SocketNameList_IsValid && EQSPath_IsValid && EQSTemplate_IsValid && SceneItemTag_IsValid && Explode_DesiredNum_IsValid && Explode_LineTraceMaxLength_IsValid && Explode_TraceTypeQuery_IsValid && Explode_PointMinBetween_IsValid && Explode_RangeDir_X_IsValid && Explode_RangeDir_Y_IsValid && Explode_RangeDir_Z_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PointsGenExtParam", (byte)PointsGenExtParam_IsValid != 0);
	}

	static PointsGenExtParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PointsGenExtParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PointsGenExtParam));
	}
}
