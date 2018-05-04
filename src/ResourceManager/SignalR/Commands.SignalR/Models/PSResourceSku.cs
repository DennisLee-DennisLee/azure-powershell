﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.SignalR.Models;

namespace Microsoft.Azure.Commands.SignalR.Models
{
    public class PSResourceSku
    {
        public int? Capacity { get; }

        public string Family { get; }

        public string Name { get; }

        public string Size { get; }

        public string Tier { get; }

        public PSResourceSku(ResourceSku resourceSku)
        {
            Capacity = resourceSku.Capacity;
            Family = resourceSku.Family;
            Name = resourceSku.Name;
            Size = resourceSku.Size;
            Tier = resourceSku.Tier;
        }
    }
}
