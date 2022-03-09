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
    /// The metadata of a dataflow. The API returns a subset of the following
    /// list of dataflow properties. The subset depends on the API called,
    /// caller permissions, and the availability of data in the Power BI
    /// database.
    /// </summary>
    public partial class DataflowBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the DataflowBaseProperties class.
        /// </summary>
        public DataflowBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataflowBaseProperties class.
        /// </summary>
        /// <param name="objectId">The dataflow ID</param>
        /// <param name="name">The dataflow name</param>
        /// <param name="description">The dataflow description</param>
        /// <param name="modelUrl">A URL to the dataflow definition file
        /// (model.json)</param>
        /// <param name="configuredBy">The dataflow owner</param>
        /// <param name="modifiedBy">The user that modified the
        /// dataflow</param>
        /// <param name="modifiedDateTime">The date and time that the dataflow
        /// was last modified</param>
        /// <param name="users">(Empty value) The dataflow user access details.
        /// This property will be removed from the payload response in an
        /// upcoming release. You can retrieve user information on a Power BI
        /// dataflow by using the [Get Dataflow Users as
        /// Admin](/rest/api/power-bi/admin/dataflows-get-dataflow-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUser` parameter.</param>
        public DataflowBaseProperties(System.Guid objectId, string name = default(string), string description = default(string), string modelUrl = default(string), string configuredBy = default(string), string modifiedBy = default(string), System.DateTime? modifiedDateTime = default(System.DateTime?), IList<DataflowUser> users = default(IList<DataflowUser>))
        {
            ObjectId = objectId;
            Name = name;
            Description = description;
            ModelUrl = modelUrl;
            ConfiguredBy = configuredBy;
            ModifiedBy = modifiedBy;
            ModifiedDateTime = modifiedDateTime;
            Users = users;
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
        /// Gets or sets the user that modified the dataflow
        /// </summary>
        [JsonProperty(PropertyName = "modifiedBy")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the dataflow was last modified
        /// </summary>
        [JsonProperty(PropertyName = "modifiedDateTime")]
        public System.DateTime? ModifiedDateTime { get; set; }

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
        }
    }
}
