// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace OverrideUpdate
{
    public class OverrideUpdateOutputs: SystemResults
    {
		/// <summary>
		/// The volume.
		/// </summary>
		[JsonProperty("Volume")]
		public double Volume { get; set; }

        /// <summary>
        /// Construct a OverrideUpdateOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public OverrideUpdateOutputs() : base()
        {
        }

        /// <summary>
        /// Construct a OverrideUpdateOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public OverrideUpdateOutputs(double volume) : base()
        {
			this.Volume = volume;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}