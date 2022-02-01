﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Testing.ResourceNames.Snippets
{
    // [START unknown_generated_ResourceNames_WildcardMultiPatternMultipleMethod_sync_flattened_resourceNames1]
    using System.Collections.Generic;
    using Testing.ResourceNames;

    public sealed partial class GeneratedResourceNamesClientSnippets
    {
        /// <summary>Snippet for WildcardMultiPatternMultipleMethod</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void WildcardMultiPatternMultipleMethodResourceNames1()
        {
            // Create client
            ResourceNamesClient resourceNamesClient = ResourceNamesClient.Create();
            // Initialize request argument(s)
            WildcardMultiPatternMultipleName @ref = WildcardMultiPatternMultipleName.FromConstPattern();
            IEnumerable<WildcardMultiPatternMultipleName> repeatedRef = new WildcardMultiPatternMultipleName[]
            {
                WildcardMultiPatternMultipleName.FromConstPattern(),
            };
            // Make the request
            Response response = resourceNamesClient.WildcardMultiPatternMultipleMethod(@ref, repeatedRef);
        }
    }
    // [END unknown_generated_ResourceNames_WildcardMultiPatternMultipleMethod_sync_flattened_resourceNames1]
}