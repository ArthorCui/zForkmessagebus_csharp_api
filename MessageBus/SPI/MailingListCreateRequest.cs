// Copyright (c) 2012. Mail Bypass, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License
//

using System;
using MessageBus.API.V3;

namespace MessageBus.SPI
{
    public class MailingListCreateRequest
    {
        public MailingListCreateRequest(MessageBusMailingList mailingList)
        {
            name = mailingList.Name;
            mergeFieldKeys = mailingList.MergeFieldKeys;
        }

        public string name { get; set; }
        public string[] mergeFieldKeys { get; set; }
    }
}