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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.Glacier.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for GetJobOutput operation
      /// </summary>
      internal class GetJobOutputResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          GetJobOutputResponse response = new GetJobOutputResponse();          
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,GetJobOutputResponse response)
        {
          

            if (context.ResponseData.GetHeaderValue("x-amz-sha256-tree-hash") != null)
                response.Checksum = context.ResponseData.GetHeaderValue("x-amz-sha256-tree-hash");
            if (context.ResponseData.GetHeaderValue("Content-Range") != null)
                response.ContentRange = context.ResponseData.GetHeaderValue("Content-Range");
            if (context.ResponseData.GetHeaderValue("Accept-Ranges") != null)
                response.AcceptRanges = context.ResponseData.GetHeaderValue("Accept-Ranges");
            if (context.ResponseData.GetHeaderValue("Content-Type") != null)
                response.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            if (context.ResponseData.GetHeaderValue("x-amz-archive-description") != null)
                response.ArchiveDescription = context.ResponseData.GetHeaderValue("x-amz-archive-description");
            response.Status = (int)context.ResponseData.StatusCode;
            response.Body = context.Stream;
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
          {
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
          {
            return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
          {
            return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
          {
            return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetJobOutputResponseUnmarshaller instance;
        public static GetJobOutputResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new GetJobOutputResponseUnmarshaller();
          }
          return instance;
        }
  
        internal override bool HasStreamingProperty
        {
           get { return true;}
        }
        
      }
    }
  
