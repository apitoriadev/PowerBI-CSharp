// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Admin.
    /// </summary>
    public static partial class AdminExtensions
    {
            /// <summary>
            /// Adds an encryption key for Power BI workspaces assigned to a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 600 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantKeyCreationRequest'>
            /// Tenant key information
            /// </param>
            public static TenantKey AddPowerBIEncryptionKey(this IAdmin operations, TenantKeyCreationRequest tenantKeyCreationRequest)
            {
                return operations.AddPowerBIEncryptionKeyAsync(tenantKeyCreationRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds an encryption key for Power BI workspaces assigned to a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 600 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantKeyCreationRequest'>
            /// Tenant key information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantKey> AddPowerBIEncryptionKeyAsync(this IAdmin operations, TenantKeyCreationRequest tenantKeyCreationRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPowerBIEncryptionKeyWithHttpMessagesAsync(tenantKeyCreationRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the encryption keys for the tenant.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TenantKeys GetPowerBIEncryptionKeys(this IAdmin operations)
            {
                return operations.GetPowerBIEncryptionKeysAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the encryption keys for the tenant.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantKeys> GetPowerBIEncryptionKeysAsync(this IAdmin operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPowerBIEncryptionKeysWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Rotate the encryption key for Power BI workspaces assigned to a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 600 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantKeyId'>
            /// The tenant key ID
            /// </param>
            /// <param name='tenantKeyRotationRequest'>
            /// Tenant key information
            /// </param>
            public static TenantKey RotatePowerBIEncryptionKey(this IAdmin operations, System.Guid tenantKeyId, TenantKeyRotationRequest tenantKeyRotationRequest)
            {
                return operations.RotatePowerBIEncryptionKeyAsync(tenantKeyId, tenantKeyRotationRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rotate the encryption key for Power BI workspaces assigned to a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 600 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantKeyId'>
            /// The tenant key ID
            /// </param>
            /// <param name='tenantKeyRotationRequest'>
            /// Tenant key information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantKey> RotatePowerBIEncryptionKeyAsync(this IAdmin operations, System.Guid tenantKeyId, TenantKeyRotationRequest tenantKeyRotationRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RotatePowerBIEncryptionKeyWithHttpMessagesAsync(tenantKeyId, tenantKeyRotationRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of capacities for the organization.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
            /// </param>
            public static Capacities GetCapacitiesAsAdmin(this IAdmin operations, string expand = default(string))
            {
                return operations.GetCapacitiesAsAdminAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of capacities for the organization.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Capacities> GetCapacitiesAsAdminAsync(this IAdmin operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacitiesAsAdminWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Changes specific capacity information. Currently, this API call only
            /// supports changing the capacity's encryption key.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='capacityPatchRequest'>
            /// Patch capacity information
            /// </param>
            public static void PatchCapacityAsAdmin(this IAdmin operations, System.Guid capacityId, CapacityPatchRequest capacityPatchRequest)
            {
                operations.PatchCapacityAsAdminAsync(capacityId, capacityPatchRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes specific capacity information. Currently, this API call only
            /// supports changing the capacity's encryption key.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='capacityPatchRequest'>
            /// Patch capacity information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchCapacityAsAdminAsync(this IAdmin operations, System.Guid capacityId, CapacityPatchRequest capacityPatchRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchCapacityAsAdminWithHttpMessagesAsync(capacityId, capacityPatchRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of refreshables for the organization within a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Returns a subset of a results based on
            /// [Odata](https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_SystemQueryOptions)
            /// filter query parameter condition.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshables(this IAdmin operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesAsync(top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for the organization within a capacity.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Returns a subset of a results based on
            /// [Odata](https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_SystemQueryOptions)
            /// filter query parameter condition.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesAsync(this IAdmin operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesWithHttpMessagesAsync(top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity that the user has
            /// access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Returns a subset of a results based on
            /// [Odata](https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_SystemQueryOptions)
            /// filter query parameter condition.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshablesForCapacity(this IAdmin operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesForCapacityAsync(capacityId, top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity that the user has
            /// access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Returns a subset of a results based on
            /// [Odata](https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_SystemQueryOptions)
            /// filter query parameter condition.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesForCapacityAsync(this IAdmin operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesForCapacityWithHttpMessagesAsync(capacityId, top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity that the user
            /// has access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable ID
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            public static Refreshables GetRefreshableForCapacity(this IAdmin operations, System.Guid capacityId, string refreshableId, string expand = default(string))
            {
                return operations.GetRefreshableForCapacityAsync(capacityId, refreshableId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity that the user
            /// has access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable ID
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshableForCapacityAsync(this IAdmin operations, System.Guid capacityId, string refreshableId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshableForCapacityWithHttpMessagesAsync(capacityId, refreshableId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of audit activity events for a tenant.
            /// </summary>
            /// <remarks>
            ///
            /// Provide either a continuation token or both a start and end date time.
            /// `StartDateTime` and `EndDateTime` must be in the same UTC day and should be
            /// wrapped in single quotes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// - Maximum 200 requests per hour.
            /// - Activity logging isn't supported for Microsoft Cloud Deutschland.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDateTime'>
            /// Start date and time of the window for audit event results. Must be in ISO
            /// 8601 compliant UTC format.
            /// </param>
            /// <param name='endDateTime'>
            /// End date and time of the window for audit event results. Must be in ISO
            /// 8601 compliant UTC format.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition, using 'Activity',
            /// 'UserId', or both properties. Supports only 'eq' and 'and' operators.
            /// </param>
            public static ActivityEventResponse GetActivityEvents(this IAdmin operations, string startDateTime = default(string), string endDateTime = default(string), string continuationToken = default(string), string filter = default(string))
            {
                return operations.GetActivityEventsAsync(startDateTime, endDateTime, continuationToken, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of audit activity events for a tenant.
            /// </summary>
            /// <remarks>
            ///
            /// Provide either a continuation token or both a start and end date time.
            /// `StartDateTime` and `EndDateTime` must be in the same UTC day and should be
            /// wrapped in single quotes.
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// When running under service prinicipal authentication, an app **must not**
            /// have any admin-consent required premissions for Power BI set on it in the
            /// Azure portal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// Relevant only when authenticating via a standard delegated admin access
            /// token. Must not be present when authentication via a service principal is
            /// used.
            ///
            /// ## Limitations
            ///
            /// - Maximum 200 requests per hour.
            /// - Activity logging isn't supported for Microsoft Cloud Deutschland.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDateTime'>
            /// Start date and time of the window for audit event results. Must be in ISO
            /// 8601 compliant UTC format.
            /// </param>
            /// <param name='endDateTime'>
            /// End date and time of the window for audit event results. Must be in ISO
            /// 8601 compliant UTC format.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition, using 'Activity',
            /// 'UserId', or both properties. Supports only 'eq' and 'and' operators.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivityEventResponse> GetActivityEventsAsync(this IAdmin operations, string startDateTime = default(string), string endDateTime = default(string), string continuationToken = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetActivityEventsWithHttpMessagesAsync(startDateTime, endDateTime, continuationToken, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}