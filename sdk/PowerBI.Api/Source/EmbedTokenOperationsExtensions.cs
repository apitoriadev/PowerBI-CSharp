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
    /// Extension methods for EmbedTokenOperations.
    /// </summary>
    public static partial class EmbedTokenOperationsExtensions
    {
            /// <summary>
            /// Generates an embed token for multiple reports, datasets and target
            /// workspaces. Reports and datasets do not have to be related. The binding of
            /// a report to a dataset can be done during embedding. Creating a report can
            /// only be done in workspaces specified in
            /// *targetWrokspaces*.&lt;br/&gt;&lt;br/&gt;This API is relevant only to ['App
            /// owns data' embed
            /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
            /// For more information about using this API, see [Considerations when
            /// generating an embed
            /// token](https://docs.microsoft.com/power-bi/developer/embedded/generate-embed-token).
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: &lt;ul&gt;&lt;li&gt;Content.Create -
            /// required only if a target workspace is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
            /// or Report.Read.All - required only if a report is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
            /// - required if allowEdit flag is specified for at least one report in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All
            /// or Dataset.Read.All&lt;/li&gt;&lt;/ul&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;When
            /// using service principal for authentication, refer to [Service Principal
            /// with Power
            /// BI](https://docs.microsoft.com/power-bi/developer/embed-service-principal)
            /// document along with considerations and limitations section.&lt;li&gt;For
            /// PowerBI reports with a Paginated visual the Paginated report Id should be
            /// included in the GenerateToken request (see
            /// example).&lt;/li&gt;&lt;h2&gt;Restrictions&lt;/h2&gt;&lt;ul&gt;&lt;li&gt;All
            /// the reports and datasets must reside in workspace V2. All the target
            /// workpaces must be workspace V2.&lt;/li&gt;&lt;li&gt;Maximum number of
            /// reports, datasets and target workspaces is 50
            /// each.&lt;/li&gt;&lt;li&gt;Generating Embed Token with RLS may not work for
            /// AS Azure or AS OnPrem live connection reports for several minutes after a
            /// [Rebind](/rest/api/power-bi/reports/RebindReport).&lt;/li&gt;&lt;/ul&gt;&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            public static EmbedToken GenerateToken(this IEmbedTokenOperations operations, GenerateTokenRequestV2 requestParameters)
            {
                return operations.GenerateTokenAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates an embed token for multiple reports, datasets and target
            /// workspaces. Reports and datasets do not have to be related. The binding of
            /// a report to a dataset can be done during embedding. Creating a report can
            /// only be done in workspaces specified in
            /// *targetWrokspaces*.&lt;br/&gt;&lt;br/&gt;This API is relevant only to ['App
            /// owns data' embed
            /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
            /// For more information about using this API, see [Considerations when
            /// generating an embed
            /// token](https://docs.microsoft.com/power-bi/developer/embedded/generate-embed-token).
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: &lt;ul&gt;&lt;li&gt;Content.Create -
            /// required only if a target workspace is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
            /// or Report.Read.All - required only if a report is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
            /// - required if allowEdit flag is specified for at least one report in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All
            /// or Dataset.Read.All&lt;/li&gt;&lt;/ul&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;When
            /// using service principal for authentication, refer to [Service Principal
            /// with Power
            /// BI](https://docs.microsoft.com/power-bi/developer/embed-service-principal)
            /// document along with considerations and limitations section.&lt;li&gt;For
            /// PowerBI reports with a Paginated visual the Paginated report Id should be
            /// included in the GenerateToken request (see
            /// example).&lt;/li&gt;&lt;h2&gt;Restrictions&lt;/h2&gt;&lt;ul&gt;&lt;li&gt;All
            /// the reports and datasets must reside in workspace V2. All the target
            /// workpaces must be workspace V2.&lt;/li&gt;&lt;li&gt;Maximum number of
            /// reports, datasets and target workspaces is 50
            /// each.&lt;/li&gt;&lt;li&gt;Generating Embed Token with RLS may not work for
            /// AS Azure or AS OnPrem live connection reports for several minutes after a
            /// [Rebind](/rest/api/power-bi/reports/RebindReport).&lt;/li&gt;&lt;/ul&gt;&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmbedToken> GenerateTokenAsync(this IEmbedTokenOperations operations, GenerateTokenRequestV2 requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateTokenWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
