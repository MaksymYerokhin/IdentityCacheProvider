﻿namespace Intersystems.AspNet.Identity.Cache
{
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class IdentityResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal IdentityResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.Identity.EntityFramework.IdentityResources", typeof(IdentityResources).Assembly);
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
        ///   Looks up a localized string similar to Database Validation failed..
        /// </summary>
        internal static string DbValidationFailed {
            get {
                return ResourceManager.GetString("DbValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email {0} is already taken..
        /// </summary>
        internal static string DuplicateEmail {
            get {
                return ResourceManager.GetString("DuplicateEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name {0} is already taken..
        /// </summary>
        internal static string DuplicateUserName {
            get {
                return ResourceManager.GetString("DuplicateUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity Type {0} failed validation..
        /// </summary>
        internal static string EntityFailedValidation {
            get {
                return ResourceManager.GetString("EntityFailedValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A user with that external login already exists..
        /// </summary>
        internal static string ExternalLoginExists {
            get {
                return ResourceManager.GetString("ExternalLoginExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model backing the &apos;ApplicationDbContext&apos; context has changed since the database was created. This could have happened because the model used by ASP.NET Identity Framework has changed or the model being used in your application has changed. To resolve this issue, you need to update your database. Consider using Code First Migrations to update the database (http://go.microsoft.com/fwlink/?LinkId=301867).  Before you update your database using Code First Migrations, please disable the schema consistency ch [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IdentityV1SchemaError {
            get {
                return ResourceManager.GetString("IdentityV1SchemaError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect type, expected type of {0}..
        /// </summary>
        internal static string IncorrectType {
            get {
                return ResourceManager.GetString("IncorrectType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be null or empty..
        /// </summary>
        internal static string PropertyCannotBeEmpty {
            get {
                return ResourceManager.GetString("PropertyCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role {0} already exists..
        /// </summary>
        internal static string RoleAlreadyExists {
            get {
                return ResourceManager.GetString("RoleAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role is not empty..
        /// </summary>
        internal static string RoleIsNotEmpty {
            get {
                return ResourceManager.GetString("RoleIsNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role {0} does not exist..
        /// </summary>
        internal static string RoleNotFound {
            get {
                return ResourceManager.GetString("RoleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User already in role..
        /// </summary>
        internal static string UserAlreadyInRole {
            get {
                return ResourceManager.GetString("UserAlreadyInRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UserId cannot be found..
        /// </summary>
        internal static string UserIdNotFound {
            get {
                return ResourceManager.GetString("UserIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UserLogin already exists for loginProvider: {0} with providerKey: {1}.
        /// </summary>
        internal static string UserLoginAlreadyExists {
            get {
                return ResourceManager.GetString("UserLoginAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} does not exist..
        /// </summary>
        internal static string UserNameNotFound {
            get {
                return ResourceManager.GetString("UserNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not in role..
        /// </summary>
        internal static string UserNotInRole {
            get {
                return ResourceManager.GetString("UserNotInRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        internal static string ValueCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ValueCannotBeNullOrEmpty", resourceCulture);
            }
        }
    }
}