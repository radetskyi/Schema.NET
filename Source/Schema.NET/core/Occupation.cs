namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
    [DataContract]
    public partial class Occupation : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Occupation";

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EducationRequirements { get; set; }

        /// <summary>
        /// An estimated salary for a job posting based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        [DataMember(Name = "estimatedSalary", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MonetaryAmountDistribution>? EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ExperienceRequirements { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? OccupationalCategory { get; set; }

        /// <summary>
        /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
        /// </summary>
        [DataMember(Name = "occupationLocation", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<AdministrativeArea>? OccupationLocation { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Responsibilities { get; set; }

        /// <summary>
        /// Skills required to fulfill this role or in this Occupation.
        /// </summary>
        [DataMember(Name = "skills", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Skills { get; set; }
    }
}
