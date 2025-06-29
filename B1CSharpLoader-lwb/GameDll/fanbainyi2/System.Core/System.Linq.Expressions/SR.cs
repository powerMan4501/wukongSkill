using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Linq.Expressions;

internal sealed class SR
{
	internal const string MethodPreconditionViolated = "MethodPreconditionViolated";

	internal const string InvalidArgumentValue = "InvalidArgumentValue";

	internal const string NonEmptyCollectionRequired = "NonEmptyCollectionRequired";

	internal const string ArgCntMustBeGreaterThanNameCnt = "ArgCntMustBeGreaterThanNameCnt";

	internal const string ReducibleMustOverrideReduce = "ReducibleMustOverrideReduce";

	internal const string MustReduceToDifferent = "MustReduceToDifferent";

	internal const string ReducedNotCompatible = "ReducedNotCompatible";

	internal const string SetterHasNoParams = "SetterHasNoParams";

	internal const string PropertyCannotHaveRefType = "PropertyCannotHaveRefType";

	internal const string IndexesOfSetGetMustMatch = "IndexesOfSetGetMustMatch";

	internal const string AccessorsCannotHaveVarArgs = "AccessorsCannotHaveVarArgs";

	internal const string AccessorsCannotHaveByRefArgs = "AccessorsCannotHaveByRefArgs";

	internal const string BoundsCannotBeLessThanOne = "BoundsCannotBeLessThanOne";

	internal const string TypeMustNotBeByRef = "TypeMustNotBeByRef";

	internal const string TypeDoesNotHaveConstructorForTheSignature = "TypeDoesNotHaveConstructorForTheSignature";

	internal const string CountCannotBeNegative = "CountCannotBeNegative";

	internal const string ArrayTypeMustBeArray = "ArrayTypeMustBeArray";

	internal const string SetterMustBeVoid = "SetterMustBeVoid";

	internal const string PropertyTyepMustMatchSetter = "PropertyTyepMustMatchSetter";

	internal const string BothAccessorsMustBeStatic = "BothAccessorsMustBeStatic";

	internal const string OnlyStaticFieldsHaveNullInstance = "OnlyStaticFieldsHaveNullInstance";

	internal const string OnlyStaticPropertiesHaveNullInstance = "OnlyStaticPropertiesHaveNullInstance";

	internal const string OnlyStaticMethodsHaveNullInstance = "OnlyStaticMethodsHaveNullInstance";

	internal const string PropertyTypeCannotBeVoid = "PropertyTypeCannotBeVoid";

	internal const string InvalidUnboxType = "InvalidUnboxType";

	internal const string ExpressionMustBeReadable = "ExpressionMustBeReadable";

	internal const string ExpressionMustBeWriteable = "ExpressionMustBeWriteable";

	internal const string ArgumentMustNotHaveValueType = "ArgumentMustNotHaveValueType";

	internal const string MustBeReducible = "MustBeReducible";

	internal const string AllTestValuesMustHaveSameType = "AllTestValuesMustHaveSameType";

	internal const string AllCaseBodiesMustHaveSameType = "AllCaseBodiesMustHaveSameType";

	internal const string DefaultBodyMustBeSupplied = "DefaultBodyMustBeSupplied";

	internal const string MethodBuilderDoesNotHaveTypeBuilder = "MethodBuilderDoesNotHaveTypeBuilder";

	internal const string TypeMustBeDerivedFromSystemDelegate = "TypeMustBeDerivedFromSystemDelegate";

	internal const string ArgumentTypeCannotBeVoid = "ArgumentTypeCannotBeVoid";

	internal const string LabelMustBeVoidOrHaveExpression = "LabelMustBeVoidOrHaveExpression";

	internal const string LabelTypeMustBeVoid = "LabelTypeMustBeVoid";

	internal const string QuotedExpressionMustBeLambda = "QuotedExpressionMustBeLambda";

	internal const string VariableMustNotBeByRef = "VariableMustNotBeByRef";

	internal const string DuplicateVariable = "DuplicateVariable";

	internal const string StartEndMustBeOrdered = "StartEndMustBeOrdered";

	internal const string FaultCannotHaveCatchOrFinally = "FaultCannotHaveCatchOrFinally";

	internal const string TryMustHaveCatchFinallyOrFault = "TryMustHaveCatchFinallyOrFault";

	internal const string BodyOfCatchMustHaveSameTypeAsBodyOfTry = "BodyOfCatchMustHaveSameTypeAsBodyOfTry";

	internal const string ExtensionNodeMustOverrideProperty = "ExtensionNodeMustOverrideProperty";

	internal const string UserDefinedOperatorMustBeStatic = "UserDefinedOperatorMustBeStatic";

	internal const string UserDefinedOperatorMustNotBeVoid = "UserDefinedOperatorMustNotBeVoid";

	internal const string CoercionOperatorNotDefined = "CoercionOperatorNotDefined";

	internal const string DynamicBinderResultNotAssignable = "DynamicBinderResultNotAssignable";

	internal const string DynamicObjectResultNotAssignable = "DynamicObjectResultNotAssignable";

	internal const string DynamicBindingNeedsRestrictions = "DynamicBindingNeedsRestrictions";

	internal const string BinderNotCompatibleWithCallSite = "BinderNotCompatibleWithCallSite";

	internal const string UnaryOperatorNotDefined = "UnaryOperatorNotDefined";

	internal const string BinaryOperatorNotDefined = "BinaryOperatorNotDefined";

	internal const string ReferenceEqualityNotDefined = "ReferenceEqualityNotDefined";

	internal const string OperandTypesDoNotMatchParameters = "OperandTypesDoNotMatchParameters";

	internal const string OverloadOperatorTypeDoesNotMatchConversionType = "OverloadOperatorTypeDoesNotMatchConversionType";

	internal const string ConversionIsNotSupportedForArithmeticTypes = "ConversionIsNotSupportedForArithmeticTypes";

	internal const string ArgumentMustBeArray = "ArgumentMustBeArray";

	internal const string ArgumentMustBeBoolean = "ArgumentMustBeBoolean";

	internal const string EqualityMustReturnBoolean = "EqualityMustReturnBoolean";

	internal const string ArgumentMustBeFieldInfoOrPropertInfo = "ArgumentMustBeFieldInfoOrPropertInfo";

	internal const string ArgumentMustBeFieldInfoOrPropertInfoOrMethod = "ArgumentMustBeFieldInfoOrPropertInfoOrMethod";

	internal const string ArgumentMustBeInstanceMember = "ArgumentMustBeInstanceMember";

	internal const string ArgumentMustBeInteger = "ArgumentMustBeInteger";

	internal const string ArgumentMustBeArrayIndexType = "ArgumentMustBeArrayIndexType";

	internal const string ArgumentMustBeSingleDimensionalArrayType = "ArgumentMustBeSingleDimensionalArrayType";

	internal const string ArgumentTypesMustMatch = "ArgumentTypesMustMatch";

	internal const string CannotAutoInitializeValueTypeElementThroughProperty = "CannotAutoInitializeValueTypeElementThroughProperty";

	internal const string CannotAutoInitializeValueTypeMemberThroughProperty = "CannotAutoInitializeValueTypeMemberThroughProperty";

	internal const string IncorrectTypeForTypeAs = "IncorrectTypeForTypeAs";

	internal const string CoalesceUsedOnNonNullType = "CoalesceUsedOnNonNullType";

	internal const string ExpressionTypeCannotInitializeArrayType = "ExpressionTypeCannotInitializeArrayType";

	internal const string ExpressionTypeDoesNotMatchConstructorParameter = "ExpressionTypeDoesNotMatchConstructorParameter";

	internal const string ArgumentTypeDoesNotMatchMember = "ArgumentTypeDoesNotMatchMember";

	internal const string ArgumentMemberNotDeclOnType = "ArgumentMemberNotDeclOnType";

	internal const string ExpressionTypeDoesNotMatchMethodParameter = "ExpressionTypeDoesNotMatchMethodParameter";

	internal const string ExpressionTypeDoesNotMatchParameter = "ExpressionTypeDoesNotMatchParameter";

	internal const string ExpressionTypeDoesNotMatchReturn = "ExpressionTypeDoesNotMatchReturn";

	internal const string ExpressionTypeDoesNotMatchAssignment = "ExpressionTypeDoesNotMatchAssignment";

	internal const string ExpressionTypeDoesNotMatchLabel = "ExpressionTypeDoesNotMatchLabel";

	internal const string ExpressionTypeNotInvocable = "ExpressionTypeNotInvocable";

	internal const string FieldNotDefinedForType = "FieldNotDefinedForType";

	internal const string InstanceFieldNotDefinedForType = "InstanceFieldNotDefinedForType";

	internal const string FieldInfoNotDefinedForType = "FieldInfoNotDefinedForType";

	internal const string IncorrectNumberOfIndexes = "IncorrectNumberOfIndexes";

	internal const string IncorrectNumberOfLambdaArguments = "IncorrectNumberOfLambdaArguments";

	internal const string IncorrectNumberOfLambdaDeclarationParameters = "IncorrectNumberOfLambdaDeclarationParameters";

	internal const string IncorrectNumberOfMethodCallArguments = "IncorrectNumberOfMethodCallArguments";

	internal const string IncorrectNumberOfConstructorArguments = "IncorrectNumberOfConstructorArguments";

	internal const string IncorrectNumberOfMembersForGivenConstructor = "IncorrectNumberOfMembersForGivenConstructor";

	internal const string IncorrectNumberOfArgumentsForMembers = "IncorrectNumberOfArgumentsForMembers";

	internal const string LambdaTypeMustBeDerivedFromSystemDelegate = "LambdaTypeMustBeDerivedFromSystemDelegate";

	internal const string MemberNotFieldOrProperty = "MemberNotFieldOrProperty";

	internal const string MethodContainsGenericParameters = "MethodContainsGenericParameters";

	internal const string MethodIsGeneric = "MethodIsGeneric";

	internal const string MethodNotPropertyAccessor = "MethodNotPropertyAccessor";

	internal const string PropertyDoesNotHaveGetter = "PropertyDoesNotHaveGetter";

	internal const string PropertyDoesNotHaveSetter = "PropertyDoesNotHaveSetter";

	internal const string PropertyDoesNotHaveAccessor = "PropertyDoesNotHaveAccessor";

	internal const string NotAMemberOfType = "NotAMemberOfType";

	internal const string OperatorNotImplementedForType = "OperatorNotImplementedForType";

	internal const string ParameterExpressionNotValidAsDelegate = "ParameterExpressionNotValidAsDelegate";

	internal const string PropertyNotDefinedForType = "PropertyNotDefinedForType";

	internal const string InstancePropertyNotDefinedForType = "InstancePropertyNotDefinedForType";

	internal const string InstancePropertyWithoutParameterNotDefinedForType = "InstancePropertyWithoutParameterNotDefinedForType";

	internal const string InstancePropertyWithSpecifiedParametersNotDefinedForType = "InstancePropertyWithSpecifiedParametersNotDefinedForType";

	internal const string InstanceAndMethodTypeMismatch = "InstanceAndMethodTypeMismatch";

	internal const string TypeContainsGenericParameters = "TypeContainsGenericParameters";

	internal const string TypeIsGeneric = "TypeIsGeneric";

	internal const string TypeMissingDefaultConstructor = "TypeMissingDefaultConstructor";

	internal const string ListInitializerWithZeroMembers = "ListInitializerWithZeroMembers";

	internal const string ElementInitializerMethodNotAdd = "ElementInitializerMethodNotAdd";

	internal const string ElementInitializerMethodNoRefOutParam = "ElementInitializerMethodNoRefOutParam";

	internal const string ElementInitializerMethodWithZeroArgs = "ElementInitializerMethodWithZeroArgs";

	internal const string ElementInitializerMethodStatic = "ElementInitializerMethodStatic";

	internal const string TypeNotIEnumerable = "TypeNotIEnumerable";

	internal const string TypeParameterIsNotDelegate = "TypeParameterIsNotDelegate";

	internal const string UnexpectedCoalesceOperator = "UnexpectedCoalesceOperator";

	internal const string InvalidCast = "InvalidCast";

	internal const string UnhandledBinary = "UnhandledBinary";

	internal const string UnhandledBinding = "UnhandledBinding";

	internal const string UnhandledBindingType = "UnhandledBindingType";

	internal const string UnhandledConvert = "UnhandledConvert";

	internal const string UnhandledExpressionType = "UnhandledExpressionType";

	internal const string UnhandledUnary = "UnhandledUnary";

	internal const string UnknownBindingType = "UnknownBindingType";

	internal const string UserDefinedOpMustHaveConsistentTypes = "UserDefinedOpMustHaveConsistentTypes";

	internal const string UserDefinedOpMustHaveValidReturnType = "UserDefinedOpMustHaveValidReturnType";

	internal const string LogicalOperatorMustHaveBooleanOperators = "LogicalOperatorMustHaveBooleanOperators";

	internal const string MethodDoesNotExistOnType = "MethodDoesNotExistOnType";

	internal const string MethodWithArgsDoesNotExistOnType = "MethodWithArgsDoesNotExistOnType";

	internal const string GenericMethodWithArgsDoesNotExistOnType = "GenericMethodWithArgsDoesNotExistOnType";

	internal const string MethodWithMoreThanOneMatch = "MethodWithMoreThanOneMatch";

	internal const string PropertyWithMoreThanOneMatch = "PropertyWithMoreThanOneMatch";

	internal const string IncorrectNumberOfTypeArgsForFunc = "IncorrectNumberOfTypeArgsForFunc";

	internal const string IncorrectNumberOfTypeArgsForAction = "IncorrectNumberOfTypeArgsForAction";

	internal const string ArgumentCannotBeOfTypeVoid = "ArgumentCannotBeOfTypeVoid";

	internal const string AmbiguousMatchInExpandoObject = "AmbiguousMatchInExpandoObject";

	internal const string SameKeyExistsInExpando = "SameKeyExistsInExpando";

	internal const string KeyDoesNotExistInExpando = "KeyDoesNotExistInExpando";

	internal const string NoOrInvalidRuleProduced = "NoOrInvalidRuleProduced";

	internal const string FirstArgumentMustBeCallSite = "FirstArgumentMustBeCallSite";

	internal const string BindingCannotBeNull = "BindingCannotBeNull";

	internal const string InvalidOperation = "InvalidOperation";

	internal const string OutOfRange = "OutOfRange";

	internal const string QueueEmpty = "QueueEmpty";

	internal const string LabelTargetAlreadyDefined = "LabelTargetAlreadyDefined";

	internal const string LabelTargetUndefined = "LabelTargetUndefined";

	internal const string ControlCannotLeaveFinally = "ControlCannotLeaveFinally";

	internal const string ControlCannotLeaveFilterTest = "ControlCannotLeaveFilterTest";

	internal const string AmbiguousJump = "AmbiguousJump";

	internal const string ControlCannotEnterTry = "ControlCannotEnterTry";

	internal const string ControlCannotEnterExpression = "ControlCannotEnterExpression";

	internal const string NonLocalJumpWithValue = "NonLocalJumpWithValue";

	internal const string ExtensionNotReduced = "ExtensionNotReduced";

	internal const string CannotCompileConstant = "CannotCompileConstant";

	internal const string CannotCompileDynamic = "CannotCompileDynamic";

	internal const string InvalidLvalue = "InvalidLvalue";

	internal const string InvalidMemberType = "InvalidMemberType";

	internal const string UnknownLiftType = "UnknownLiftType";

	internal const string InvalidOutputDir = "InvalidOutputDir";

	internal const string InvalidAsmNameOrExtension = "InvalidAsmNameOrExtension";

	internal const string CollectionReadOnly = "CollectionReadOnly";

	internal const string IllegalNewGenericParams = "IllegalNewGenericParams";

	internal const string UndefinedVariable = "UndefinedVariable";

	internal const string CannotCloseOverByRef = "CannotCloseOverByRef";

	internal const string UnexpectedVarArgsCall = "UnexpectedVarArgsCall";

	internal const string RethrowRequiresCatch = "RethrowRequiresCatch";

	internal const string TryNotAllowedInFilter = "TryNotAllowedInFilter";

	internal const string MustRewriteToSameNode = "MustRewriteToSameNode";

	internal const string MustRewriteChildToSameType = "MustRewriteChildToSameType";

	internal const string MustRewriteWithoutMethod = "MustRewriteWithoutMethod";

	internal const string InvalidNullValue = "InvalidNullValue";

	internal const string InvalidObjectType = "InvalidObjectType";

	internal const string TryNotSupportedForMethodsWithRefArgs = "TryNotSupportedForMethodsWithRefArgs";

	internal const string TryNotSupportedForValueTypeInstances = "TryNotSupportedForValueTypeInstances";

	internal const string CollectionModifiedWhileEnumerating = "CollectionModifiedWhileEnumerating";

	internal const string EnumerationIsDone = "EnumerationIsDone";

	internal const string HomogenousAppDomainRequired = "HomogenousAppDomainRequired";

	internal const string TestValueTypeDoesNotMatchComparisonMethodParameter = "TestValueTypeDoesNotMatchComparisonMethodParameter";

	internal const string SwitchValueTypeDoesNotMatchComparisonMethodParameter = "SwitchValueTypeDoesNotMatchComparisonMethodParameter";

	internal const string InvalidMetaObjectCreated = "InvalidMetaObjectCreated";

	internal const string PdbGeneratorNeedsExpressionCompiler = "PdbGeneratorNeedsExpressionCompiler";

	private static SR loader;

	private ResourceManager resources;

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("System.Linq.Expressions", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			SR value = new SR();
			Interlocked.CompareExchange(ref loader, value, null);
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string text = sR.resources.GetString(name, Culture);
		if (args != null && args.Length != 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string { Length: >1024 } text2)
				{
					args[i] = text2.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, text, args);
		}
		return text;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static string GetString(string name, out bool usedFallback)
	{
		usedFallback = false;
		return GetString(name);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
