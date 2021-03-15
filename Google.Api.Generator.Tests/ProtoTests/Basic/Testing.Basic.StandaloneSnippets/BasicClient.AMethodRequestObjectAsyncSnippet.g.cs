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

namespace Testing.Basic.Snippets
{
    using System.Threading.Tasks;
    using Testing.Basic;

    public sealed partial class GeneratedBasicClientStandaloneSnippets
    {
        /// <summary>Snippet for AMethodAsync</summary>
        public async Task AMethodRequestObjectAsync()
        {
            // Snippet: AMethodAsync(Request, CallSettings)
            // Additional: AMethodAsync(Request, CancellationToken)
            // Create client
            BasicClient basicClient = await BasicClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            Response response = await basicClient.AMethodAsync(request);
            // End snippet
        }
    }
}
