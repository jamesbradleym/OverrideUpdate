// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace OverrideUpdate
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class OverrideUpdateInputs : ArgsBase
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public OverrideUpdateInputs(double? @optionalNumberEnum, OverrideUpdateInputsOptionalStringEnum? @optionalStringEnum, Overrides @overrides, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideUpdateInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @optionalNumberEnum, @optionalStringEnum, @overrides});
            }
        
            this.OptionalNumberEnum = @optionalNumberEnum;
            this.OptionalStringEnum = @optionalStringEnum ?? this.OptionalStringEnum;
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Optional Number Enum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OptionalNumberEnum { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Optional String Enum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OverrideUpdateInputsOptionalStringEnum? OptionalStringEnum { get; set; }
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum OverrideUpdateInputsOptionalStringEnum
    {
        [System.Runtime.Serialization.EnumMember(Value = @"One")]
        One = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Two")]
        Two = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Three")]
        Three = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(IList<OptionsOverride> @options)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @options});
            }
        
            this.Options = @options ?? this.Options;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Options", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<OptionsOverride> Options { get; set; } = new List<OptionsOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OptionsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public OptionsOverride(string @id, OptionsIdentity @identity, OptionsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OptionsOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OptionsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OptionsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OptionsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public OptionsIdentity(string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OptionsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name});
            }
        
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OptionsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public OptionsValue(string @option)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OptionsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @option});
            }
        
            this.Option = @option;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Option", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option { get; set; }
    
    }
}