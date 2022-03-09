// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ScorecardsOperations operations.
    /// </summary>
    public partial interface IScorecardsOperations
    {
        /// <summary>
        /// Returns a list of scorecards from a workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Scorecards>> GetWithHttpMessagesAsync(int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new scorecard.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='scorecard'>
        /// The new scorecard properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Scorecard>> PostWithHttpMessagesAsync(ScorecardCreateRequest scorecard, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a scorecard with ID.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `goals`, `goalValues`,
        /// `aggregations`, and `notes`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Scorecard>> GetByIDWithHttpMessagesAsync(string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a scorecard by its ID
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='scorecard'>
        /// The scorecard properties to patch
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Scorecard>> PatchByIDWithHttpMessagesAsync(Scorecard scorecard, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a scorecard by its ID.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteByIDWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reads a scorecard associated with an internal report ID.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='reportId'>
        /// The ID of the internal report associated with the scorecard
        /// </param>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `goals`, `goalValues`,
        /// and `aggregations`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Scorecard>> GetScorecardByReportIdWithHttpMessagesAsync(System.Guid reportId, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Moves goals within the scorecard. Changes their ranks and parents.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='moveGoalsRequest'>
        /// The request describing the move operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> MoveGoalsWithHttpMessagesAsync(GoalsMoveRequest moveGoalsRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
