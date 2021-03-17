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
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Testing.ResourceNames;

    public sealed partial class GeneratedResourceNamesClientStandaloneSnippets
    {
        /// <summary>Snippet for SinglePatternMethodAsync</summary>
        public async Task SinglePatternMethodAsync()
        {
            // Snippet: SinglePatternMethodAsync(string, string, IEnumerable<string>, string, IEnumerable<string>, CallSettings)
            // Additional: SinglePatternMethodAsync(string, string, IEnumerable<string>, string, IEnumerable<string>, CancellationToken)
            // Create client
            ResourceNamesClient resourceNamesClient = await ResourceNamesClient.CreateAsync();
            // Initialize request argument(s)
            string realName = "items/[ITEM_ID]";
            string @ref = "items/[ITEM_ID]";
            IEnumerable<string> repeatedRef = new string[] { "items/[ITEM_ID]", };
            string valueRef = "items/[ITEM_ID]";
            IEnumerable<string> repeatedValueRef = new string[] { "items/[ITEM_ID]", };
            // Make the request
            Response response = await resourceNamesClient.SinglePatternMethodAsync(realName, @ref, repeatedRef, valueRef, repeatedValueRef);
            // End snippet
        }
    }
}