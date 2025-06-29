using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FISMBuildInfo
{
	private static bool ISMComponentName_IsValid;

	private static int ISMComponentName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo:ISMComponentName")]
	public string ISMComponentName;

	private static bool SMTemplateResPath_IsValid;

	private static int SMTemplateResPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo:SMTemplateResPath")]
	public string SMTemplateResPath;

	private static bool CPDString_IsValid;

	private static int CPDString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo:CPDString")]
	public string CPDString;

	private static bool ActorNames_IsValid;

	private static int ActorNames_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo:ActorNames")]
	public string ActorNames;

	private static bool InstanceNum_IsValid;

	private static int InstanceNum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ISMBuildInfo:InstanceNum")]
	public int InstanceNum;

	private static bool FISMBuildInfo_IsValid;

	private static int FISMBuildInfo_StructSize;

	public FISMBuildInfo Copy()
	{
		return this;
	}

	public static FISMBuildInfo FromNative(IntPtr nativeBuffer)
	{
		return new FISMBuildInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FISMBuildInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FISMBuildInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FISMBuildInfo(nativeBuffer + arrayIndex * FISMBuildInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FISMBuildInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FISMBuildInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FISMBuildInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ISMBuildInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ISMComponentName_Offset), ISMComponentName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SMTemplateResPath_Offset), SMTemplateResPath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CPDString_Offset), CPDString);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorNames_Offset), ActorNames);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InstanceNum_Offset), InstanceNum);
	}

	public FISMBuildInfo(IntPtr nativeStruct)
	{
		if (!FISMBuildInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ISMBuildInfo");
			ISMComponentName = FStringMarshaler.DefaultString;
			SMTemplateResPath = FStringMarshaler.DefaultString;
			CPDString = FStringMarshaler.DefaultString;
			ActorNames = FStringMarshaler.DefaultString;
			InstanceNum = 0;
		}
		else
		{
			ISMComponentName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ISMComponentName_Offset));
			SMTemplateResPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SMTemplateResPath_Offset));
			CPDString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CPDString_Offset));
			ActorNames = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorNames_Offset));
			InstanceNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InstanceNum_Offset));
		}
	}

	static FISMBuildInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FISMBuildInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FISMBuildInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.ISMBuildInfo");
		FISMBuildInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ISMComponentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ISMComponentName");
		ISMComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ISMComponentName", Classes.FStrProperty);
		SMTemplateResPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SMTemplateResPath");
		SMTemplateResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SMTemplateResPath", Classes.FStrProperty);
		CPDString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CPDString");
		CPDString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CPDString", Classes.FStrProperty);
		ActorNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorNames");
		ActorNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorNames", Classes.FStrProperty);
		InstanceNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceNum");
		InstanceNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceNum", Classes.FIntProperty);
		FISMBuildInfo_IsValid = intPtr != IntPtr.Zero && ISMComponentName_IsValid && SMTemplateResPath_IsValid && CPDString_IsValid && ActorNames_IsValid && InstanceNum_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.ISMBuildInfo", FISMBuildInfo_IsValid);
	}
}
