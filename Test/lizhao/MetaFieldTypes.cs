// This file is auto-generated from the ISDA Common Domain Model, do not edit.
//
// Version: ${project.version}
//

#nullable enable // Allow nullable reference types

namespace Org.Isda.Cdm.MetaFields
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using NodaTime;

    using Rosetta.Lib.Meta;


public class Key
{
    [JsonConstructor]
    public Key(string keyValue, string? scope)
    {
        Scope = scope;
        KeyValue = keyValue;
    }
    
    [JsonProperty("value")]
    public string KeyValue { get; }
    public string? Scope { get; }
}

public class Reference
{
    [JsonConstructor]
    public Reference(string? reference, string? scope)
    {
        Scope = scope;
        ReferenceValue = reference;
    }
    [JsonProperty("value")]
    public string? ReferenceValue { get; }
    public string? Scope { get; }
}

    public class MetaFields
    {
        [JsonConstructor]
        public MetaFields(string? globalKey, string? externalKey, IEnumerable<Key> location)
        {
            GlobalKey = globalKey;
            ExternalKey = externalKey;
            Location = location;
        }
        
        
        public string? GlobalKey { get; }
        
        public string? ExternalKey { get; }
        
        public IEnumerable<Key> Location { get; }
    }
    
    public class MetaAndTemplateFields
    {
        [JsonConstructor]
        public MetaAndTemplateFields(string? globalKey, string? externalKey, string? templateGlobalReference, IEnumerable<Key> location)
        {
            GlobalKey = globalKey;
            ExternalKey = externalKey;
            TemplateGlobalReference = templateGlobalReference;
            Location = location;
        }
        
        
        public string? GlobalKey { get; }
        
        public string? ExternalKey { get; }
        
        public string? TemplateGlobalReference { get; }
        
        public IEnumerable<Key> Location { get; }
    }
    
}