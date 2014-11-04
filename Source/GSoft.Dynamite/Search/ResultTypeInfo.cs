﻿using System.Collections.Generic;
using GSoft.Dynamite.Branding;
using Microsoft.Office.Server.Search.Administration;

namespace GSoft.Dynamite.Search
{
    /// <summary>
    /// Easily serializable SharePoint search result type metadata
    /// </summary>
    public class ResultTypeInfo
    {
        /// <summary>
        /// Initializes a new <see cref="ResultTypeInfo"/> instance
        /// </summary>
        /// <param name="name">The name of the type</param>
        /// <param name="displayTemplate">Display template metadata</param>
        /// <param name="resultSource">Result source metadata</param>
        public ResultTypeInfo(string name, DisplayTemplateInfo displayTemplate, ResultSourceInfo resultSource)
        {
            this.Name = name;
            this.DisplayProperties = new List<ManagedPropertyInfo>();
            this.Rules = new List<ResultTypeRuleInfo>();
            this.DisplayTemplate = displayTemplate;
            this.ResultSource = resultSource;
        }

        /// <summary>
        /// Name of the result type
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Whether the result type is optimized for frequent use
        /// </summary>
        public bool OptimizeForFrequenUse { get; set; }

        /// <summary>
        /// The priority of the result type
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Associated display template metadata
        /// </summary>
        public DisplayTemplateInfo DisplayTemplate { get; private set; }

        /// <summary>
        /// Associated result source metadata
        /// </summary>
        public ResultSourceInfo ResultSource { get; private set; }

        /// <summary>
        /// The type's rules
        /// </summary>
        public IList<ResultTypeRuleInfo> Rules { get; set; }

        /// <summary>
        /// The type's managed property metadata
        /// </summary>
        public IList<ManagedPropertyInfo> DisplayProperties { get; set; }
    }
}