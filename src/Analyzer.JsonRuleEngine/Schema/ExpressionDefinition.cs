﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Azure.Templates.Analyzer.RuleEngines.JsonEngine.Converters;
using Microsoft.Azure.Templates.Analyzer.RuleEngines.JsonEngine.Expressions;
using Microsoft.Azure.Templates.Analyzer.Utilities;
using Newtonsoft.Json;

namespace Microsoft.Azure.Templates.Analyzer.RuleEngines.JsonEngine.Schemas
{
    /// <summary>
    /// The base class for all Expression schemas in JSON rules.
    /// </summary>
    [JsonConverter(typeof(ExpressionConverter))]
    internal abstract class ExpressionDefinition
    {
        /// <summary>
        /// Gets or sets the Path property.
        /// </summary>
        [JsonProperty]
        public virtual string Path { get; set; }

        /// <summary>
        /// Gets or sets the ResourceType property.
        /// </summary>
        [JsonProperty]
        public string ResourceType { get; set; }

        /// <summary>
        /// Creates an <c>Expression</c> that can evaluate a template.
        /// </summary>
        /// <param name="jsonLineNumberResolver">An <c>IJsonLineNumberResolver</c> to
        /// pass to the created <c>Expression</c>.</param>
        /// <returns>The <c>Expression</c>.</returns>
        public abstract Expression ToExpression(ILineNumberResolver jsonLineNumberResolver);
    }
}
