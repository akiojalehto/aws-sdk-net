/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateTagOptionFromResource operation.
    /// Disassociates a TagOption from a resource.
    /// </summary>
    public partial class DisassociateTagOptionFromResourceRequest : AmazonServiceCatalogRequest
    {
        private string _resourceId;
        private string _tagOptionId;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Identifier of the resource from which to disassociate the TagOption.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TagOptionId. 
        /// <para>
        /// Identifier of the TagOption to disassociate from the resource.
        /// </para>
        /// </summary>
        public string TagOptionId
        {
            get { return this._tagOptionId; }
            set { this._tagOptionId = value; }
        }

        // Check to see if TagOptionId property is set
        internal bool IsSetTagOptionId()
        {
            return this._tagOptionId != null;
        }

    }
}