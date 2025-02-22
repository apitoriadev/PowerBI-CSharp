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
    /// Extension methods for Profiles.
    /// </summary>
    public static partial class ProfilesExtensions
    {
            /// <summary>
            /// Returns a list of service principal profiles for the organization.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator or authenticate using a service
            /// principal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition, using 'id',
            /// 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. This parameter must be in the range of
            /// 1-5000.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 5000.
            /// </param>
            public static AdminServicePrincipalProfiles GetProfilesAsAdmin(this IProfiles operations, string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetProfilesAsAdminAsync(filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of service principal profiles for the organization.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator or authenticate using a service
            /// principal.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition, using 'id',
            /// 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. This parameter must be in the range of
            /// 1-5000.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 5000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdminServicePrincipalProfiles> GetProfilesAsAdminAsync(this IProfiles operations, string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProfilesAsAdminWithHttpMessagesAsync(filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified service principal profile.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            public static void DeleteProfileAsAdmin(this IProfiles operations, System.Guid profileId)
            {
                operations.DeleteProfileAsAdminAsync(profileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified service principal profile.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must be a Fabric administrator.
            ///
            /// ## Required Scope
            ///
            /// Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteProfileAsAdminAsync(this IProfiles operations, System.Guid profileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteProfileAsAdminWithHttpMessagesAsync(profileId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of service principal profiles.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Returns a list of profiles that belongs to service principal
            /// caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            /// <param name='filter'>
            /// Get a profile by DisplayName
            /// </param>
            public static ServicePrincipalProfiles GetProfiles(this IProfiles operations, int? top = default(int?), int? skip = default(int?), string filter = default(string))
            {
                return operations.GetProfilesAsync(top, skip, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of service principal profiles.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Returns a list of profiles that belongs to service principal
            /// caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            /// <param name='filter'>
            /// Get a profile by DisplayName
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalProfiles> GetProfilesAsync(this IProfiles operations, int? top = default(int?), int? skip = default(int?), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProfilesWithHttpMessagesAsync(top, skip, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal. The maximum number of profiles a
            /// single service principal can have, is 100,000.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createOrUpdateProfileRequest'>
            /// The create profile request
            /// </param>
            public static ServicePrincipalProfile CreateProfile(this IProfiles operations, CreateOrUpdateProfileRequest createOrUpdateProfileRequest)
            {
                return operations.CreateProfileAsync(createOrUpdateProfileRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal. The maximum number of profiles a
            /// single service principal can have, is 100,000.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createOrUpdateProfileRequest'>
            /// The create profile request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalProfile> CreateProfileAsync(this IProfiles operations, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateProfileWithHttpMessagesAsync(createOrUpdateProfileRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Returns the specified profile if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            public static ServicePrincipalProfile GetProfile(this IProfiles operations, System.Guid profileId)
            {
                return operations.GetProfileAsync(profileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Returns the specified profile if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalProfile> GetProfileAsync(this IProfiles operations, System.Guid profileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProfileWithHttpMessagesAsync(profileId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified service principal profile name.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            /// <param name='createOrUpdateProfileRequest'>
            /// The update profile request
            /// </param>
            public static ServicePrincipalProfile UpdateProfile(this IProfiles operations, System.Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest)
            {
                return operations.UpdateProfileAsync(profileId, createOrUpdateProfileRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified service principal profile name.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            /// <param name='createOrUpdateProfileRequest'>
            /// The update profile request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalProfile> UpdateProfileAsync(this IProfiles operations, System.Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateProfileWithHttpMessagesAsync(profileId, createOrUpdateProfileRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            public static void DeleteProfile(this IProfiles operations, System.Guid profileId)
            {
                operations.DeleteProfileAsync(profileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified service principal profile.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to
            /// service principal caller.
            ///
            /// ## Limitations
            ///
            /// Can only be called by a service principal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileId'>
            /// The service principal profile ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteProfileAsync(this IProfiles operations, System.Guid profileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteProfileWithHttpMessagesAsync(profileId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
