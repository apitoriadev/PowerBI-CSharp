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
    /// Extension methods for WorkspaceInfoOperations.
    /// </summary>
    public static partial class WorkspaceInfoOperationsExtensions
    {
            /// <summary>
            /// Initiate a call to receive metadata for the requested list of workspaces.
            /// (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 500 requests per hour, and not more than 16 simultaneously.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requiredWorkspaces'>
            /// Required workspace IDs to get info for
            /// </param>
            /// <param name='lineage'>
            /// Whether to return lineage info (upstream dataflows, tiles, datasource IDs)​
            /// </param>
            /// <param name='datasourceDetails'>
            /// Whether to return datasource details​
            /// </param>
            /// <param name='datasetSchema'>
            /// Whether to return dataset schema (Tables, Columns and Measures)​
            /// </param>
            /// <param name='datasetExpressions'>
            /// Whether to return dataset expressions (Dax query and Mashup)​
            /// </param>
            public static ScanRequest PostWorkspaceInfo(this IWorkspaceInfoOperations operations, RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?))
            {
                return operations.PostWorkspaceInfoAsync(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiate a call to receive metadata for the requested list of workspaces.
            /// (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 500 requests per hour, and not more than 16 simultaneously.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requiredWorkspaces'>
            /// Required workspace IDs to get info for
            /// </param>
            /// <param name='lineage'>
            /// Whether to return lineage info (upstream dataflows, tiles, datasource IDs)​
            /// </param>
            /// <param name='datasourceDetails'>
            /// Whether to return datasource details​
            /// </param>
            /// <param name='datasetSchema'>
            /// Whether to return dataset schema (Tables, Columns and Measures)​
            /// </param>
            /// <param name='datasetExpressions'>
            /// Whether to return dataset expressions (Dax query and Mashup)​
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScanRequest> PostWorkspaceInfoAsync(this IWorkspaceInfoOperations operations, RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWorkspaceInfoWithHttpMessagesAsync(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets scan status for the specified scan. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 10000 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan id to provide is the one from the response of workspaces/getInfo
            /// API which triggered the scan
            /// </param>
            public static ScanRequest GetScanStatus(this IWorkspaceInfoOperations operations, System.Guid scanId)
            {
                return operations.GetScanStatusAsync(scanId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets scan status for the specified scan. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 10000 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan id to provide is the one from the response of workspaces/getInfo
            /// API which triggered the scan
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScanRequest> GetScanStatusAsync(this IWorkspaceInfoOperations operations, System.Guid scanId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScanStatusWithHttpMessagesAsync(scanId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets scan result for the specified scan (should be called only after
            /// getting status Succeeded in the scan status API). Scan result will be
            /// available for up to 24 hours. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 500 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan id to provide is the one from the response of workspaces/getInfo
            /// API which triggered the scan
            /// </param>
            public static WorkspaceInfoResponse GetScanResult(this IWorkspaceInfoOperations operations, System.Guid scanId)
            {
                return operations.GetScanResultAsync(scanId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets scan result for the specified scan (should be called only after
            /// getting status Succeeded in the scan status API). Scan result will be
            /// available for up to 24 hours. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 500 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan id to provide is the one from the response of workspaces/getInfo
            /// API which triggered the scan
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceInfoResponse> GetScanResultAsync(this IWorkspaceInfoOperations operations, System.Guid scanId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScanResultWithHttpMessagesAsync(scanId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of workspace IDs in the organization. When using modifiedSince,
            /// returns only the IDs of workspaces that had changed since the time
            /// specified in the modifiedSince parameter. If not provided, returns a list
            /// of all workspace IDs in the organization. modifiedSince parameter should
            /// range from 30 minutes to 30 days ago. Notice changes can take up to 30
            /// minutes to take effect. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 30 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modifiedSince'>
            /// Last modified date​ (must be in ISO 8601 compliant UTC format)
            /// </param>
            /// <param name='excludePersonalWorkspaces'>
            /// Whether to exclude personal workspaces​
            /// </param>
            public static ModifiedWorkspaces GetModifiedWorkspaces(this IWorkspaceInfoOperations operations, System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?))
            {
                return operations.GetModifiedWorkspacesAsync(modifiedSince, excludePersonalWorkspaces).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workspace IDs in the organization. When using modifiedSince,
            /// returns only the IDs of workspaces that had changed since the time
            /// specified in the modifiedSince parameter. If not provided, returns a list
            /// of all workspace IDs in the organization. modifiedSince parameter should
            /// range from 30 minutes to 30 days ago. Notice changes can take up to 30
            /// minutes to take effect. (Preview)
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Microsoft 365
            /// Global Administrator or Power BI Service Administrator) to call this API or
            /// authenticate via service principal. &lt;br/&gt;This API allows a maximum of
            /// 30 requests per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.Read.All or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
            /// scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modifiedSince'>
            /// Last modified date​ (must be in ISO 8601 compliant UTC format)
            /// </param>
            /// <param name='excludePersonalWorkspaces'>
            /// Whether to exclude personal workspaces​
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ModifiedWorkspaces> GetModifiedWorkspacesAsync(this IWorkspaceInfoOperations operations, System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetModifiedWorkspacesWithHttpMessagesAsync(modifiedSince, excludePersonalWorkspaces, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
