// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The metadata of a dataflow returned by Workspace Info APIs. Below is a
    /// list of properties that may be returned for a dataflow. Only a subset
    /// of the properties will be returned depending on the API called, the
    /// caller permissions and the availability of the data in the Power BI
    /// database.
    /// </summary>
    public partial class WorkspaceInfoDataflow
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataflow class.
        /// </summary>
        public WorkspaceInfoDataflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataflow class.
        /// </summary>
        /// <param name="objectId">The dataflow ID</param>
        /// <param name="name">The dataflow name</param>
        /// <param name="description">The dataflow description</param>
        /// <param name="modelUrl">A URL to the dataflow definition file
        /// (model.json)</param>
        /// <param name="configuredBy">The dataflow owner</param>
        /// <param name="users">(Empty value) The dataflow user access details.
        /// This property will be removed from the payload response in an
        /// upcoming release. You can retrieve user information on a Power BI
        /// dataflow by using the [Get Dataflow Users as
        /// Admin](/rest/api/power-bi/admin/dataflows-get-dataflow-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUser` parameter.</param>
        /// <param name="datasourceUsages">The data source usages</param>
        /// <param name="misconfiguredDatasourceUsages">The data source
        /// misconfigured usages</param>
        /// <param name="upstreamDataflows">The list of all the dataflows this
        /// item depends on</param>
        /// <param name="upstreamDatamarts">The list of all the datamarts this
        /// item depends on</param>
        /// <param name="endorsementDetails">The endorsement details</param>
        /// <param name="sensitivityLabel">The sensitivity label</param>
        public WorkspaceInfoDataflow(System.Guid objectId, string name = default(string), string description = default(string), string modelUrl = default(string), string configuredBy = default(string), IList<DataflowUser> users = default(IList<DataflowUser>), IList<DatasourceUsage> datasourceUsages = default(IList<DatasourceUsage>), IList<DatasourceUsage> misconfiguredDatasourceUsages = default(IList<DatasourceUsage>), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>), IList<DependentDatamart> upstreamDatamarts = default(IList<DependentDatamart>), EndorsementDetails endorsementDetails = default(EndorsementDetails), SensitivityLabel sensitivityLabel = default(SensitivityLabel))
        {
            ObjectId = objectId;
            Name = name;
            Description = description;
            ModelUrl = modelUrl;
            ConfiguredBy = configuredBy;
            Users = users;
            DatasourceUsages = datasourceUsages;
            MisconfiguredDatasourceUsages = misconfiguredDatasourceUsages;
            UpstreamDataflows = upstreamDataflows;
            UpstreamDatamarts = upstreamDatamarts;
            EndorsementDetails = endorsementDetails;
            SensitivityLabel = sensitivityLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataflow ID
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public System.Guid ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the dataflow name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataflow description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a URL to the dataflow definition file (model.json)
        /// </summary>
        [JsonProperty(PropertyName = "modelUrl")]
        public string ModelUrl { get; set; }

        /// <summary>
        /// Gets or sets the dataflow owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Gets or sets (Empty value) The dataflow user access details. This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve user information on a Power BI dataflow
        /// by using the [Get Dataflow Users as
        /// Admin](/rest/api/power-bi/admin/dataflows-get-dataflow-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUser` parameter.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DataflowUser> Users { get; set; }

        /// <summary>
        /// Gets or sets the data source usages
        /// </summary>
        [JsonProperty(PropertyName = "datasourceUsages")]
        public IList<DatasourceUsage> DatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets the data source misconfigured usages
        /// </summary>
        [JsonProperty(PropertyName = "misconfiguredDatasourceUsages")]
        public IList<DatasourceUsage> MisconfiguredDatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets the list of all the dataflows this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

        /// <summary>
        /// Gets or sets the list of all the datamarts this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDatamarts")]
        public IList<DependentDatamart> UpstreamDatamarts { get; set; }

        /// <summary>
        /// Gets or sets the endorsement details
        /// </summary>
        [JsonProperty(PropertyName = "endorsementDetails")]
        public EndorsementDetails EndorsementDetails { get; set; }

        /// <summary>
        /// Gets or sets the sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Users != null)
            {
                foreach (var element in Users)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DatasourceUsages != null)
            {
                foreach (var element1 in DatasourceUsages)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (MisconfiguredDatasourceUsages != null)
            {
                foreach (var element2 in MisconfiguredDatasourceUsages)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
        }
    }
}
