/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>ListTables</i> operation.</para>
    /// </summary>
    public partial class ListTablesResult : AmazonWebServiceResponse
    {
        
        private List<string> tableNames = new List<string>();
        private string lastEvaluatedTableName;


        /// <summary>
        /// The names of the tables associated with the current account at the current endpoint.
        ///  
        /// </summary>
        public List<string> TableNames
        {
            get { return this.tableNames; }
            set { this.tableNames = value; }
        }

        // Check to see if TableNames property is set
        internal bool IsSetTableNames()
        {
            return this.tableNames.Count > 0;
        }

        /// <summary>
        /// The name of the last table in the current list, only if some tables for the account and endpoint have not been returned. This value does not
        /// exist in a response if all table names are already returned. Use this value as the <i>ExclusiveStartTableName</i> in a new request to
        /// continue the list until all the table names are returned.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LastEvaluatedTableName
        {
            get { return this.lastEvaluatedTableName; }
            set { this.lastEvaluatedTableName = value; }
        }

        // Check to see if LastEvaluatedTableName property is set
        internal bool IsSetLastEvaluatedTableName()
        {
            return this.lastEvaluatedTableName != null;
        }
    }
}
