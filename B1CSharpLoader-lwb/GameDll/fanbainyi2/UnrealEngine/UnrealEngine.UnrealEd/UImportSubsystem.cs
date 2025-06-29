using System;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/UnrealEd.ImportSubsystem", "UnrealEd", UnrealModuleType.Engine)]
public class UImportSubsystem : UEditorSubsystem
{
	[UDelegate]
	[UMetaPath("/Script/UnrealEd.ImportSubsystem:OnAssetReimport_Dyn__DelegateSignature")]
	public class FOnAssetReimport_Dyn : FMulticastDelegate<FOnAssetReimport_Dyn.Signature>
	{
		public delegate void Signature(UObject InCreatedObject);

		private static bool OnAssetReimport_Dyn__DelegateSignature_IsValid;

		private static IntPtr OnAssetReimport_Dyn__DelegateSignature_FunctionAddress;

		private static int OnAssetReimport_Dyn__DelegateSignature_ParamsSize;

		private static bool OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_IsValid;

		private static FFieldAddress OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress;

		private static int OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnAssetReimport_Dyn()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnAssetReimport_Dyn__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.ImportSubsystem:OnAssetReimport_Dyn__DelegateSignature");
			OnAssetReimport_Dyn__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAssetReimport_Dyn__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress, OnAssetReimport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject");
			OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetReimport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject");
			OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetReimport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject", Classes.FObjectProperty);
			OnAssetReimport_Dyn__DelegateSignature_IsValid = OnAssetReimport_Dyn__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UnrealEd.ImportSubsystem:OnAssetReimport_Dyn__DelegateSignature", OnAssetReimport_Dyn__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UObject InCreatedObject)
		{
			if (!OnAssetReimport_Dyn__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.ImportSubsystem:OnAssetReimport_Dyn__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnAssetReimport_Dyn__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAssetReimport_Dyn__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_Offset), 0, OnAssetReimport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress.Address, InCreatedObject);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UnrealEd.ImportSubsystem:OnAssetPreImport_Dyn__DelegateSignature")]
	public class FOnAssetPreImport_Dyn : FMulticastDelegate<FOnAssetPreImport_Dyn.Signature>
	{
		public delegate void Signature(UFactory InFactory, TSubclassOf<UObject> InClass, UObject InParent, FName Name, string Type);

		private static bool OnAssetPreImport_Dyn__DelegateSignature_IsValid;

		private static IntPtr OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_ParamsSize;

		private static bool OnAssetPreImport_Dyn__DelegateSignature_InFactory_IsValid;

		private static FFieldAddress OnAssetPreImport_Dyn__DelegateSignature_InFactory_PropertyAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_InFactory_Offset;

		private static bool OnAssetPreImport_Dyn__DelegateSignature_InClass_IsValid;

		private static FFieldAddress OnAssetPreImport_Dyn__DelegateSignature_InClass_PropertyAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_InClass_Offset;

		private static bool OnAssetPreImport_Dyn__DelegateSignature_InParent_IsValid;

		private static FFieldAddress OnAssetPreImport_Dyn__DelegateSignature_InParent_PropertyAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_InParent_Offset;

		private static bool OnAssetPreImport_Dyn__DelegateSignature_Name_IsValid;

		private static FFieldAddress OnAssetPreImport_Dyn__DelegateSignature_Name_PropertyAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_Name_Offset;

		private static bool OnAssetPreImport_Dyn__DelegateSignature_Type_IsValid;

		private static FFieldAddress OnAssetPreImport_Dyn__DelegateSignature_Type_PropertyAddress;

		private static int OnAssetPreImport_Dyn__DelegateSignature_Type_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnAssetPreImport_Dyn()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.ImportSubsystem:OnAssetPreImport_Dyn__DelegateSignature");
			OnAssetPreImport_Dyn__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPreImport_Dyn__DelegateSignature_InFactory_PropertyAddress, OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InFactory");
			OnAssetPreImport_Dyn__DelegateSignature_InFactory_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InFactory");
			OnAssetPreImport_Dyn__DelegateSignature_InFactory_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InFactory", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPreImport_Dyn__DelegateSignature_InClass_PropertyAddress, OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InClass");
			OnAssetPreImport_Dyn__DelegateSignature_InClass_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InClass");
			OnAssetPreImport_Dyn__DelegateSignature_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InClass", Classes.FClassProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPreImport_Dyn__DelegateSignature_InParent_PropertyAddress, OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InParent");
			OnAssetPreImport_Dyn__DelegateSignature_InParent_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InParent");
			OnAssetPreImport_Dyn__DelegateSignature_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "InParent", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPreImport_Dyn__DelegateSignature_Name_PropertyAddress, OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Name");
			OnAssetPreImport_Dyn__DelegateSignature_Name_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Name");
			OnAssetPreImport_Dyn__DelegateSignature_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Name", Classes.FNameProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPreImport_Dyn__DelegateSignature_Type_PropertyAddress, OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Type");
			OnAssetPreImport_Dyn__DelegateSignature_Type_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Type");
			OnAssetPreImport_Dyn__DelegateSignature_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress, "Type", Classes.FStrProperty);
			OnAssetPreImport_Dyn__DelegateSignature_IsValid = OnAssetPreImport_Dyn__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAssetPreImport_Dyn__DelegateSignature_InFactory_IsValid && OnAssetPreImport_Dyn__DelegateSignature_InClass_IsValid && OnAssetPreImport_Dyn__DelegateSignature_InParent_IsValid && OnAssetPreImport_Dyn__DelegateSignature_Name_IsValid && OnAssetPreImport_Dyn__DelegateSignature_Type_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UnrealEd.ImportSubsystem:OnAssetPreImport_Dyn__DelegateSignature", OnAssetPreImport_Dyn__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UFactory InFactory, TSubclassOf<UObject> InClass, UObject InParent, FName Name, string Type)
		{
			if (!OnAssetPreImport_Dyn__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.ImportSubsystem:OnAssetPreImport_Dyn__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnAssetPreImport_Dyn__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAssetPreImport_Dyn__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(intPtr, OnAssetPreImport_Dyn__DelegateSignature_InFactory_Offset), 0, OnAssetPreImport_Dyn__DelegateSignature_InFactory_PropertyAddress.Address, InFactory);
				TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnAssetPreImport_Dyn__DelegateSignature_InClass_Offset), 0, OnAssetPreImport_Dyn__DelegateSignature_InClass_PropertyAddress.Address, InClass);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnAssetPreImport_Dyn__DelegateSignature_InParent_Offset), 0, OnAssetPreImport_Dyn__DelegateSignature_InParent_PropertyAddress.Address, InParent);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnAssetPreImport_Dyn__DelegateSignature_Name_Offset), 0, OnAssetPreImport_Dyn__DelegateSignature_Name_PropertyAddress.Address, Name);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnAssetPreImport_Dyn__DelegateSignature_Type_Offset), 0, OnAssetPreImport_Dyn__DelegateSignature_Type_PropertyAddress.Address, Type);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnAssetPreImport_Dyn__DelegateSignature_Type_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UnrealEd.ImportSubsystem:OnAssetPostLODImport_Dyn__DelegateSignature")]
	public class FOnAssetPostLODImport_Dyn : FMulticastDelegate<FOnAssetPostLODImport_Dyn.Signature>
	{
		public delegate void Signature(UObject InObject, int InLODIndex);

		private static bool OnAssetPostLODImport_Dyn__DelegateSignature_IsValid;

		private static IntPtr OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress;

		private static int OnAssetPostLODImport_Dyn__DelegateSignature_ParamsSize;

		private static bool OnAssetPostLODImport_Dyn__DelegateSignature_InObject_IsValid;

		private static FFieldAddress OnAssetPostLODImport_Dyn__DelegateSignature_InObject_PropertyAddress;

		private static int OnAssetPostLODImport_Dyn__DelegateSignature_InObject_Offset;

		private static bool OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_IsValid;

		private static FFieldAddress OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_PropertyAddress;

		private static int OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnAssetPostLODImport_Dyn()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.ImportSubsystem:OnAssetPostLODImport_Dyn__DelegateSignature");
			OnAssetPostLODImport_Dyn__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPostLODImport_Dyn__DelegateSignature_InObject_PropertyAddress, OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InObject");
			OnAssetPostLODImport_Dyn__DelegateSignature_InObject_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InObject");
			OnAssetPostLODImport_Dyn__DelegateSignature_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InObject", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_PropertyAddress, OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InLODIndex");
			OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InLODIndex");
			OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress, "InLODIndex", Classes.FIntProperty);
			OnAssetPostLODImport_Dyn__DelegateSignature_IsValid = OnAssetPostLODImport_Dyn__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAssetPostLODImport_Dyn__DelegateSignature_InObject_IsValid && OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UnrealEd.ImportSubsystem:OnAssetPostLODImport_Dyn__DelegateSignature", OnAssetPostLODImport_Dyn__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UObject InObject, int InLODIndex)
		{
			if (!OnAssetPostLODImport_Dyn__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.ImportSubsystem:OnAssetPostLODImport_Dyn__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnAssetPostLODImport_Dyn__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAssetPostLODImport_Dyn__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnAssetPostLODImport_Dyn__DelegateSignature_InObject_Offset), 0, OnAssetPostLODImport_Dyn__DelegateSignature_InObject_PropertyAddress.Address, InObject);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_Offset), 0, OnAssetPostLODImport_Dyn__DelegateSignature_InLODIndex_PropertyAddress.Address, InLODIndex);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UnrealEd.ImportSubsystem:OnAssetPostImport_Dyn__DelegateSignature")]
	public class FOnAssetPostImport_Dyn : FMulticastDelegate<FOnAssetPostImport_Dyn.Signature>
	{
		public delegate void Signature(UFactory InFactory, UObject InCreatedObject);

		private static bool OnAssetPostImport_Dyn__DelegateSignature_IsValid;

		private static IntPtr OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress;

		private static int OnAssetPostImport_Dyn__DelegateSignature_ParamsSize;

		private static bool OnAssetPostImport_Dyn__DelegateSignature_InFactory_IsValid;

		private static FFieldAddress OnAssetPostImport_Dyn__DelegateSignature_InFactory_PropertyAddress;

		private static int OnAssetPostImport_Dyn__DelegateSignature_InFactory_Offset;

		private static bool OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_IsValid;

		private static FFieldAddress OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress;

		private static int OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnAssetPostImport_Dyn()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.ImportSubsystem:OnAssetPostImport_Dyn__DelegateSignature");
			OnAssetPostImport_Dyn__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPostImport_Dyn__DelegateSignature_InFactory_PropertyAddress, OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InFactory");
			OnAssetPostImport_Dyn__DelegateSignature_InFactory_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InFactory");
			OnAssetPostImport_Dyn__DelegateSignature_InFactory_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InFactory", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress, OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject");
			OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_Offset = NativeReflectionCached.GetPropertyOffset(OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject");
			OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress, "InCreatedObject", Classes.FObjectProperty);
			OnAssetPostImport_Dyn__DelegateSignature_IsValid = OnAssetPostImport_Dyn__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAssetPostImport_Dyn__DelegateSignature_InFactory_IsValid && OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UnrealEd.ImportSubsystem:OnAssetPostImport_Dyn__DelegateSignature", OnAssetPostImport_Dyn__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UFactory InFactory, UObject InCreatedObject)
		{
			if (!OnAssetPostImport_Dyn__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.ImportSubsystem:OnAssetPostImport_Dyn__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnAssetPostImport_Dyn__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAssetPostImport_Dyn__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(intPtr, OnAssetPostImport_Dyn__DelegateSignature_InFactory_Offset), 0, OnAssetPostImport_Dyn__DelegateSignature_InFactory_PropertyAddress.Address, InFactory);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_Offset), 0, OnAssetPostImport_Dyn__DelegateSignature_InCreatedObject_PropertyAddress.Address, InCreatedObject);
				ProcessDelegate(intPtr);
			}
		}
	}

	static UImportSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UImportSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UImportSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealEd.ImportSubsystem");
	}
}
