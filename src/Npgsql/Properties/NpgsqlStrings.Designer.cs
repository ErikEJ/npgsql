﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Npgsql.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NpgsqlStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NpgsqlStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Npgsql.Properties.NpgsqlStrings", typeof(NpgsqlStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; must be positive..
        /// </summary>
        internal static string ArgumentMustBePositive {
            get {
                return ResourceManager.GetString("ArgumentMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays aren&apos;t enabled; please call {0} on {1} to enable arrays..
        /// </summary>
        internal static string ArraysNotEnabled {
            get {
                return ResourceManager.GetString("ArraysNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read infinity value since Npgsql.DisableDateTimeInfinityConversions is enabled..
        /// </summary>
        internal static string CannotReadInfinityValue {
            get {
                return ResourceManager.GetString("CannotReadInfinityValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read interval values with non-zero months as TimeSpan, since that type doesn&apos;t support months. Consider using NodaTime Period which better corresponds to PostgreSQL interval, or read the value as NpgsqlInterval, or transform the interval to not contain months or years in PostgreSQL before reading it..
        /// </summary>
        internal static string CannotReadIntervalWithMonthsAsTimeSpan {
            get {
                return ResourceManager.GetString("CannotReadIntervalWithMonthsAsTimeSpan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When registering a password provider, a password or password file may not be set..
        /// </summary>
        internal static string CannotSetBothPasswordProviderAndPassword {
            get {
                return ResourceManager.GetString("CannotSetBothPasswordProviderAndPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple kinds of password providers were found, only one kind may be configured per DbDataSource..
        /// </summary>
        internal static string CannotSetMultiplePasswordProviderKinds {
            get {
                return ResourceManager.GetString("CannotSetMultiplePasswordProviderKinds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When creating a multi-host data source, TargetSessionAttributes cannot be specified. Create without TargetSessionAttributes, and then obtain DataSource wrappers from it. Consult the docs for more information..
        /// </summary>
        internal static string CannotSpecifyTargetSessionAttributes {
            get {
                return ResourceManager.GetString("CannotSpecifyTargetSessionAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RootCertificate cannot be used in conjunction with SslClientAuthenticationOptionsCallback overwriting RemoteCertificateValidationCallback; when registering a validation callback, perform whatever validation you require in that callback..
        /// </summary>
        internal static string CannotUseSslRootCertificateWithCustomValidationCallback {
            get {
                return ResourceManager.GetString("CannotUseSslRootCertificateWithCustomValidationCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SslMode.{0} cannot be used in conjunction with SslClientAuthenticationOptionsCallback overwriting RemoteCertificateValidationCallback; when registering a validation callback, perform whatever validation you require in that callback..
        /// </summary>
        internal static string CannotUseSslVerifyWithCustomValidationCallback {
            get {
                return ResourceManager.GetString("CannotUseSslVerifyWithCustomValidationCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ValidationRootCertificateCallback cannot be used in conjunction with SslClientAuthenticationOptionsCallback overwriting RemoteCertificateValidationCallback; when registering a validation callback, perform whatever validation you require in that callback..
        /// </summary>
        internal static string CannotUseValidationRootCertificateCallbackWithCustomValidationCallback {
            get {
                return ResourceManager.GetString("CannotUseValidationRootCertificateCallbackWithCustomValidationCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; required dynamic JSON serialization, which requires an explicit opt-in; call &apos;{1}&apos; on &apos;{2}&apos; or NpgsqlConnection.GlobalTypeMapper (see https://www.npgsql.org/doc/types/json.html and the 8.0 release notes for more details). Alternatively, if you meant to use Newtonsoft JSON.NET instead of System.Text.Json, call UseJsonNet() instead.
        ///.
        /// </summary>
        internal static string DynamicJsonNotEnabled {
            get {
                return ResourceManager.GetString("DynamicJsonNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Full-text search isn&apos;t enabled; please call {0} on {1} to enable full-text search..
        /// </summary>
        internal static string FullTextSearchNotEnabled {
            get {
                return ResourceManager.GetString("FullTextSearchNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integrated security hasn&apos;t been enabled; please call {0} on NpgsqlSlimDataSourceBuilder to enable it..
        /// </summary>
        internal static string IntegratedSecurityDisabled {
            get {
                return ResourceManager.GetString("IntegratedSecurityDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ltree isn&apos;t enabled; please call {0} on {1} to enable LTree..
        /// </summary>
        internal static string LTreeNotEnabled {
            get {
                return ResourceManager.GetString("LTreeNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiranges aren&apos;t enabled; please call {0} on {1} to enable multiranges..
        /// </summary>
        internal static string MultirangesNotEnabled {
            get {
                return ResourceManager.GetString("MultirangesNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No multirange type could be found in the database for subtype {0}..
        /// </summary>
        internal static string NoMultirangeTypeFound {
            get {
                return ResourceManager.GetString("NoMultirangeTypeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection and transaction access is not supported on batches created from DbDataSource..
        /// </summary>
        internal static string NotSupportedOnDataSourceBatch {
            get {
                return ResourceManager.GetString("NotSupportedOnDataSourceBatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection and transaction access is not supported on commands created from DbDataSource..
        /// </summary>
        internal static string NotSupportedOnDataSourceCommand {
            get {
                return ResourceManager.GetString("NotSupportedOnDataSourceCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The right type of password provider (sync or async) was not found..
        /// </summary>
        internal static string PasswordProviderMissing {
            get {
                return ResourceManager.GetString("PasswordProviderMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When using CommandType.StoredProcedure, all positional parameters must come before named parameters..
        /// </summary>
        internal static string PositionalParameterAfterNamed {
            get {
                return ResourceManager.GetString("PositionalParameterAfterNamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ranges aren&apos;t enabled; please call {0} on {1} to enable ranges..
        /// </summary>
        internal static string RangesNotEnabled {
            get {
                return ResourceManager.GetString("RangesNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not read a PostgreSQL record. If you&apos;re attempting to read a record as a .NET tuple, call &apos;{0}&apos; on &apos;{1}&apos; or NpgsqlConnection.GlobalTypeMapper (see https://www.npgsql.org/doc/types/basic.html and the 8.0 release notes for more details). If you&apos;re reading a record as a .NET object array using NpgsqlSlimDataSourceBuilder, call &apos;{2}&apos;.
        ///.
        /// </summary>
        internal static string RecordsNotEnabled {
            get {
                return ResourceManager.GetString("RecordsNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SslClientAuthenticationOptionsCallback is not supported together with UserCertificateValidationCallback and ClientCertificatesCallback.
        /// </summary>
        internal static string SslClientAuthenticationOptionsCallbackWithOtherCallbacksNotSupported {
            get {
                return ResourceManager.GetString("SslClientAuthenticationOptionsCallbackWithOtherCallbacksNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both sync and async connection initializers must be provided..
        /// </summary>
        internal static string SyncAndAsyncConnectionInitializersRequired {
            get {
                return ResourceManager.GetString("SyncAndAsyncConnectionInitializersRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both sync and async password providers must be provided..
        /// </summary>
        internal static string SyncAndAsyncPasswordProvidersRequired {
            get {
                return ResourceManager.GetString("SyncAndAsyncPasswordProvidersRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write DateTime with Kind=UTC to PostgreSQL type &apos;{0}&apos;, consider using &apos;{1}&apos;. Note that it&apos;s not possible to mix DateTimes with different Kinds in an array, range, or multirange..
        /// </summary>
        internal static string TimestampNoDateTimeUtc {
            get {
                return ResourceManager.GetString("TimestampNoDateTimeUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write DateTime with Kind={0} to PostgreSQL type &apos;{1}&apos;, only UTC is supported. Note that it&apos;s not possible to mix DateTimes with different Kinds in an array, range, or multirange..
        /// </summary>
        internal static string TimestampTzNoDateTimeUnspecified {
            get {
                return ResourceManager.GetString("TimestampTzNoDateTimeUnspecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transport security hasn&apos;t been enabled; please call {0} on NpgsqlSlimDataSourceBuilder to enable it..
        /// </summary>
        internal static string TransportSecurityDisabled {
            get {
                return ResourceManager.GetString("TransportSecurityDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading and writing unmapped enums requires an explicit opt-in; call &apos;{0}&apos; on &apos;{1}&apos; or NpgsqlConnection.GlobalTypeMapper (see https://www.npgsql.org/doc/types/enums_and_composites.html and the 8.0 release notes for more details)..
        /// </summary>
        internal static string UnmappedEnumsNotEnabled {
            get {
                return ResourceManager.GetString("UnmappedEnumsNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading and writing unmapped ranges and multiranges requires an explicit opt-in; call &apos;{0}&apos; on &apos;{1}&apos; or NpgsqlConnection.GlobalTypeMapper (see https://www.npgsql.org/doc/types/ranges.html and the 8.0 release notes for more details)..
        /// </summary>
        internal static string UnmappedRangesNotEnabled {
            get {
                return ResourceManager.GetString("UnmappedRangesNotEnabled", resourceCulture);
            }
        }
    }
}
