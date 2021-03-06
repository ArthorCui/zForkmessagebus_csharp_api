// Copyright (c) 2012. Mail Bypass, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License
//

using System;

namespace MessageBus.SPI {
    /// <summary>
    /// used internally to translate JSON responses into consumable format
    /// </summary>
    public class BatchEmailResponse {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }
        public DateTime statusTime { get; set; }
        public int successCount { get; set; }
        public int failureCount { get; set; }
        public BatchEmailResult[] results { get; set; }

    }

    /// <summary>
    /// used internally to translate JSON responses for each message into consumable format
    /// </summary>
    public class BatchEmailResult {
        public string toEmail { get; set; }
        public string messageId { get; set; }
        public int messageStatus { get; set; }
    }
}